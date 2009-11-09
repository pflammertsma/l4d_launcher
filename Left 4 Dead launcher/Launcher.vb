Imports Microsoft.Win32
Imports System.IO

' -game left4dead -console -novid +sv_lan 1 +sv_allow_lobby_connect_only 0 +z_difficulty normal +map l4d_hospital01_apartment

' HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Left 4 Dead
' "C:\Windows\Left 4 Dead\uninstall.exe" "/U:C:\Program Files\Left 4 Dead\Uninstall\uninstall.xml"

Public Class Launcher

    Private sAppDir As String = ""
    Private sGameDir As String = ""
    Private bNeedFix As Boolean

    Delegate Sub ListDelegate(ByVal count As Integer)

    Public Shared _listDelegate As ListDelegate

    Private ThreadWinNT As GetWinNTList = AddressOf NetworkProbe.Probe
    Private ThreadPing As GetPingIPs = AddressOf IPHlp.ReturnMachines
    Private ThreadWinNTCallback As AsyncCallback = AddressOf ThreadWinNTComplete
    Private ThreadPingCallback As AsyncCallback = AddressOf ThreadPingComplete

    '*** a delegate for executing handler methods
    Delegate Function GetWinNTList() As Collection
    Delegate Function GetPingIPs(ByVal nTimeout As Integer, ByVal nPort As Integer, ByVal nStart As Integer, ByVal nEnd As Integer) As PingObject
    Delegate Sub UpdateMachinesHandler(ByVal Machines As Collection, ByVal bLast As Boolean)
    Delegate Sub UpdateProgressHandler(ByVal Value As Integer, ByVal Max As Integer)

    Private nDefaultPort As Integer = 27015
    Private nDefaultTimeout As Integer = 2000
    Dim nPort As Integer = nDefaultPort
    Dim nTimeout As Integer = nDefaultTimeout

    Private cControls As New Collection()
    Private settingIniFile As String = "prefs.ini"
    Private nSelectedMap As Integer

    Private cMaps As New Collection
    Private cAddons As New Collection

    Private nTotalIPs As Integer
    Private nMaxIPs As Integer
    Private nFirstIP As Integer = 0
    Private nLastIP As Integer = 256
    Private nStepIP As Integer = 1
    Private Refreshing As Boolean
    Private ListEmpty As Boolean
    Private cMachines As New Collection

    Private Sub Launcher_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Me.Hide()
        [Delegate].RemoveAll(_listDelegate, _listDelegate)
        End
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim iBuildInfo As FileVersionInfo = FileVersionInfo.GetVersionInfo(Application.ExecutablePath)
            lblVersion.Text = "v" & iBuildInfo.ProductVersion
            lblVersion.Parent = picBanner
            lblVersion.BackColor = Color.Transparent
            lblVersion.Left = picBanner.Width - lblVersion.Width - 4
        Catch
            lblVersion.Visible = False
        End Try

        sAppDir = AppDomain.CurrentDomain.BaseDirectory
        If sAppDir.Substring(sAppDir.Length - 1) <> "\" Then
            sAppDir &= "\"
        End If

        cboPlayer.SelectedIndex = 0
        cboGameType.SelectedIndex = 0
        txtPort.Text = nDefaultPort
        txtTimeout.Text = nDefaultTimeout

        ToolTip.SetToolTip(chkNameINI, "Writes the ""PlayerName"" entry into the L4D ""rev.ini"" file")

        sGameDir = ""

        GetControls(Me)
        LoadSettings()

        Call chkName_CheckedChanged(Nothing, Nothing)
        Call chkPlayer_CheckedChanged(Nothing, Nothing)
        Call chkCustomPeer_CheckedChanged(Nothing, Nothing)
        lblPort.Text = "Default: " & nDefaultPort
        lblTimeout.Text = "Recommended: " & nDefaultTimeout

        Try
            RefreshNetwork()
        Catch
        End Try

        bNeedFix = True
        Try
            Dim sErr As String = ""
            Dim pos1 As Integer, pos2 As Integer
            Dim sRegPath As String
            sRegPath = GetRegValue(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Left 4 Dead", "UninstallString", sErr)
            If sErr <> "" And False Then
                MsgBox("Something went wrong while reading the install path from the registry." & vbCrLf & vbCrLf & sErr, MsgBoxStyle.Critical)
            End If
            pos1 = InStr(sRegPath, "/U:")
            If pos1 > -1 Then
                pos1 += 3
                pos2 = InStrRev(sRegPath, "\Uninstall\uninstall.xml")
                If pos2 > pos1 Then
                    bNeedFix = False
                    sGameDir = Mid(sRegPath, pos1, pos2 - pos1 + 1)
                End If
            End If
        Catch
        End Try

        btnFix.Visible = bNeedFix

        Me.Show()

        For Each arg As String In Environment.GetCommandLineArgs()
            Dim parts As String() = arg.Split("=")
            If parts.Length = 2 Then
                Select Case parts(0)
                    Case "gamedir"
                        sGameDir = StripQuotes(parts(1))
                        CheckGameDir(False, True)
                End Select
            End If
        Next arg

        CheckGameDir(False, False)

        RefreshMaps()

    End Sub

    Sub RefreshMaps()
        cboMaps.Items.Clear()
        cboMaps.Items.Add("All original maps")
        cboMaps.Items.Add("Original coop maps")
        cboMaps.Items.Add("Original versus maps")
        cboMaps.Items.Add("Original survival maps")

        Dim pos As Integer
        Dim map As String = Dir(sGameDir & "left4dead\maps\*.bsp")
        Do While map <> ""
            Dim oMap As New Map(map)
            cMaps.Add(oMap)
            map = Dir()
        Loop

        Dim addon As String = Dir(sGameDir & "left4dead\addons\*.vpk")
        Do While addon <> ""
            pos = InStrRev(addon, ".vpk")
            If pos > 0 Then
                cAddons.Add(addon)
                Console.WriteLine(addon)
                Dim parser As New VPKParser()
                parser.Parse(sGameDir & "left4dead\addons\", addon, cMaps, pgbVPK)
                addon = Mid(addon, 1, pos - 1)
                cboMaps.Items.Add("Addon: " & addon)
            End If
            addon = Dir()
        Loop

        cboMaps.SelectedIndex = nSelectedMap
    End Sub

    Public Function StripQuotes(ByVal input As String) As String
        If Mid(input, 1, 1) = """" Then
            input = Mid(input, 2)
        End If
        If Mid(input, Len(input)) = """" Then
            input = Mid(input, 1, Len(input) - 1)
        End If
        Return input
    End Function

    Public Function GetRegKey(ByVal Hive As RegistryHive)
        Select Case Hive
            Case RegistryHive.ClassesRoot
                Return Registry.ClassesRoot
            Case RegistryHive.CurrentConfig
                Return Registry.CurrentConfig
            Case RegistryHive.CurrentUser
                Return Registry.CurrentUser
            Case RegistryHive.DynData
                Return Registry.DynData
            Case RegistryHive.LocalMachine
                Return Registry.LocalMachine
            Case RegistryHive.PerformanceData
                Return Registry.PerformanceData
            Case RegistryHive.Users
                Return Registry.Users
            Case Else
                Return Nothing
        End Select
    End Function

    Public Function GetRegValue(ByVal Hive As RegistryHive, ByVal Key As String, ByVal ValueName As String, Optional ByRef ErrInfo As String = "") As String
        Dim objParent As RegistryKey = GetRegKey(Hive)
        If objParent Is Nothing Then Return Nothing

        Dim objSubkey As RegistryKey
        Dim sAns As String = ""

        Try
            objSubkey = objParent.OpenSubKey(Key)
            'if can't be found, object is not initialized
            If Not objSubkey Is Nothing Then
                sAns = (objSubkey.GetValue(ValueName))
            End If

        Catch ex As Exception

            ErrInfo = ex.Message
        Finally

            'if no error but value is empty, populate errinfo
            If ErrInfo = "" And sAns = "" Then
                ErrInfo = _
                   "No value found for requested registry key"
            End If
        End Try
        Return sAns
    End Function

    Public Function SetRegValue(ByVal Hive As RegistryHive, ByVal Key As String, ByVal ValueName As String, ByVal Value As String, Optional ByRef ErrInfo As String = "") As Boolean
        Dim success As Boolean = False

        Try
            Dim objSubkey As RegistryKey = CreateRegKeys(Hive, Key, "", ErrInfo)
            'if can't be found, object is not initialized
            If Not objSubkey Is Nothing Then
                objSubkey.SetValue(ValueName, Value)
                success = True
                objSubkey.Close()
            ElseIf ErrInfo = "" Then
                ErrInfo = "Failed opening registry key: """ & Key & """"
            End If
        Catch ex As Exception
            ErrInfo = ex.Message
        End Try
        Return success
    End Function

    Public Function CreateRegKeys(ByVal Hive As RegistryHive, ByVal Key As String, ByVal SubKey As String, ByRef ErrInfo As String) As RegistryKey
        If SubKey = "" Then
            Console.WriteLine("Navigating to registry subkey: """ & SubKey & """ in """ & Key & """")
        Else
            Console.WriteLine("Navigating to registry key """ & Key & """")
        End If
        Try
            Dim objParent As RegistryKey = GetRegKey(Hive)
            If objParent Is Nothing Then
                ErrInfo = "Registry hive does not exist."
                Return Nothing
            End If

            Dim objSubkey As RegistryKey = objParent.OpenSubKey(Key, True)
            If objSubkey Is Nothing Then
                Dim nPos As Integer = Key.LastIndexOf("\")
                If nPos > 0 Then
                    objSubkey = CreateRegKeys(Hive, Mid(Key, 1, nPos), Mid(Key, nPos + 2), ErrInfo)
                    If objSubkey Is Nothing Then
                        Return Nothing
                    End If
                Else
                    ErrInfo = "Reached registry root; something went wrong with creating the registry key"
                    Return Nothing
                End If
            ElseIf SubKey <> "" Then
                Console.WriteLine("Creating registry subkey: """ & SubKey & """ in """ & Key & """")
                objSubkey.CreateSubKey(SubKey).Close()
            End If
            objSubkey = objParent.OpenSubKey(Key, True)
            If objSubkey Is Nothing Then
                ErrInfo = "The registry key couldn't be created:" & vbCrLf & Key
            End If
            Return objSubkey
        Catch ex As Exception
            ErrInfo = ex.Message
        End Try
        Return Nothing
    End Function

    Function CheckGameDir(ByVal showError As Boolean, ByVal fixReg As Boolean) As Boolean
        If sGameDir.Length > 1 Then
            If sGameDir.Substring(sGameDir.Length - 1) <> "\" Then
                sGameDir &= "\"
            End If
        End If
        sGameDir = sGameDir.Replace("\\", "\")
        Dim exeFile As New FileInfo(sGameDir & "left4dead.exe")
        If exeFile.Exists() Then
            If fixReg Then
                If VistaSecurity.IsAdmin Then
                    Dim str As String = """C:\Windows\Left 4 Dead\uninstall.exe"" ""/U:" & sGameDir & "\Uninstall\uninstall.xml"""
                    Dim sErr As String = ""
                    If SetRegValue(RegistryHive.LocalMachine, "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall\Left 4 Dead", "UninstallString", str, sErr) Then
                        bNeedFix = False
                    Else
                        If sErr <> "" Then
                            MsgBox("Something went wrong while storing the registry information. You might want to try again running this application in administrator mode." & vbCrLf & vbCrLf & sErr, MsgBoxStyle.Critical)
                        Else
                            MsgBox("Something went wrong while storing the registry information. You might want to try again running this application in administrator mode.", MsgBoxStyle.Critical)
                        End If
                    End If
                Else
                    VistaSecurity.RestartElevated("gamedir=""" & sGameDir & """")
                End If
            End If
            btnFix.Visible = bNeedFix
            Return True
        End If
        btnFix.Visible = bNeedFix
        If sGameDir = "" Then
            sGameDir = "C:\Program Files\Left 4 Dead\"
        End If
        If showError Then
            MsgBox("The specified path does not contain ""left4dead.exe"".", MsgBoxStyle.Exclamation)
        End If
        NotFound.SetPath(sGameDir)
        NotFound.NoExit = False
        Dim res As DialogResult = NotFound.ShowDialog(Me)
        If res <> Windows.Forms.DialogResult.Cancel Then
            sGameDir = NotFound.GetPath()
            If res = Windows.Forms.DialogResult.Retry Then
                CheckGameDir(True, True)
            Else
                CheckGameDir(True, False)
            End If
        Else
            Me.Close()
        End If
    End Function

    Function IsLocalhost(ByVal sIP As String) As Boolean
        If sIP = "localhost" Or sIP = IPHlp.Localhost Then
            Return True
        End If
        Return False
    End Function

    Sub Launch(ByVal mode As Integer)
        Dim sCommandLine As String
        sCommandLine = ""
        If chkConsole.Checked Then
            sCommandLine &= " -console"
        End If
        If Not chkVideo.Checked Then
            sCommandLine &= " -novid"
        End If
        If txtCommandLine.TextLength > 0 Then
            sCommandLine &= " " & txtCommandLine.Text
        End If
        If txtName.Enabled Then
            sCommandLine &= " +name """ & txtName.Text & """"
            If chkNameINI.Checked Then
                Dim revIniFile As String = "rev.ini"
                Dim iniFile As New FileInfo(sGameDir & revIniFile)
                If iniFile.Exists() Then
                    Dim revIni As New IniFile(sGameDir & revIniFile)
                    Dim sName As String = revIni.GetString("steamclient", "PlayerName", "")
                    If sName <> txtName.Text Then
                        Dim iniBakFile As New FileInfo(sGameDir & revIniFile & ".bak")
                        If Not iniBakFile.Exists() Then
                            FileCopy(sGameDir & revIniFile, sGameDir & revIniFile & ".bak")
                        End If
                        revIni.WriteString("steamclient", "PlayerName", txtName.Text)
                    End If
                Else
                    MsgBox("The INI file required to set the player name is missing:" & vbCrLf & vbCrLf & "    " & sGameDir & revIniFile, MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
        End If
        If cboPlayer.Enabled Then
            sCommandLine &= " +team_desired ""Survivor " & cboPlayer.Text & """"
        End If
        If mode = 2 Then
            If chkCustomPeer.Checked Then
                If txtPeer.Text = "" Then
                    MsgBox("You didn't specify a custom peer to connect to. Please enter a machine name.", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
                If IsLocalhost(txtPeer.Text) Then
                    If MsgBox("Are you sure you want to connect to your own machine?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If
                sCommandLine &= " +connect " & txtPeer.Text
            ElseIf False And Refreshing Then
                MsgBox("Please wait for the list of network peers to finish populating and make a selection, or specify a custom machine name.", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf Not lstNetwork.Enabled Or ListEmpty Then
                MsgBox("The list of network peers is empty. Refresh it and select one, or specify a custom machine name.", MsgBoxStyle.Exclamation)
                Exit Sub
            ElseIf lstNetwork.SelectedIndex = -1 Then
                MsgBox("Please make a selection from the list of network peers or specify a custom machine name.", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                If IsLocalhost(cMachines.Item(lstNetwork.SelectedIndex + 1)) Then
                    If MsgBox("Are you sure you want to connect to your own machine?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If
                sCommandLine &= " +connect " & cMachines.Item(lstNetwork.SelectedIndex + 1)
            End If
        Else
            If lstMaps.SelectedItems.Count = 0 Then
                MsgBox("Please make a selection from the list of maps.", MsgBoxStyle.Exclamation)
                Exit Sub
            End If
            Dim map As String = lstMaps.SelectedItem.ToString
            If cboGameType.SelectedIndex = 1 Then
                If map.IndexOf("_vs_") = 0 Then
                    If MsgBox("You seem to have selected a non-versus map. Are you sure you would like to use the versus game mode?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If
                sCommandLine &= " +sv_gametypes versus +mp_gamemode versus"
            ElseIf cboGameType.SelectedIndex = 2 Then
                If MsgBox("You need to have the Left 4 Dead Survival Pack to play survival mode. Also, be sure that the selected map supports survival mode." & vbCrLf & vbCrLf & "Are you sure you want to use the survival game mode?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Exit Sub
                End If
                sCommandLine &= " +sv_gametypes survival +mp_gamemode survival"
            Else
                If map.IndexOf("_vs_") > 0 Then
                    If MsgBox("You seem to have selected a versus map. Are you sure you would like to use the cooperative game mode?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        Exit Sub
                    End If
                End If
                sCommandLine &= " +sv_gametypes coop +mp_gamemode coop"
            End If
            If optEasy.Checked Then
                sCommandLine &= " +z_difficulty easy"
            End If
            If optNormal.Checked Then
                sCommandLine &= " +z_difficulty normal"
            End If
            If optHard.Checked Then
                sCommandLine &= " +z_difficulty hard"
            End If
            If optImpossible.Checked Then
                sCommandLine &= " +z_difficulty impossible"
            End If
            If chkMultiplayer.Checked Then
                sCommandLine &= " +sv_lan 1 +sv_allow_lobby_connect_only 0 +hostport " & nPort
            End If
            If lstMaps.SelectedItems.Count > 0 Then
                sCommandLine &= " +map " & map
            End If
        End If
        Dim sExec As String = sGameDir & "left4dead.exe -game left4dead" & sCommandLine
        If chkClipboard.Checked Then
            Clipboard.SetText(sExec)
            MsgBox("The execution command has been copied to the clipboard:" & vbCrLf & vbCrLf & sExec, MsgBoxStyle.Information)
        Else
            Shell(sExec, AppWinStyle.NormalFocus)
        End If
    End Sub

    Private Sub btnLaunch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLaunch.Click
        SaveSettings()
        If tabs.SelectedIndex = 0 Then
            Launch(1)
        ElseIf tabs.SelectedIndex = 1 Then
            Launch(2)
        Else
            MsgBox("Please specify whether you want to host or join a game by selecting the appropriate tab.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        SaveSettings()
        Me.Close()
    End Sub

    Sub RefreshNetwork()
        btnRefresh.Enabled = False
        Refreshing = True
        ListEmpty = True

        lstNetwork.Items.Clear()
        lstNetwork.Enabled = False
        lstNetwork.Items.Add("Please wait; populating...")

        pgbNetwork.Value = 0
        pgbNetwork.Visible = True
        pgbNetwork.Style = ProgressBarStyle.Marquee

        nTimeout = CInt(txtTimeout.Text)
        nPort = CInt(txtPort.Text)
        nTotalIPs = 0
        nMaxIPs = nLastIP - nFirstIP
        If False Then
            ThreadWinNT.BeginInvoke(ThreadWinNTCallback, Nothing)
        Else
            For i = nFirstIP To nLastIP Step nStepIP
                Dim nThisStep As Integer = Math.Min(i + nStepIP - 1, nLastIP)
                ThreadPing.BeginInvoke(nTimeout, nPort, i, nThisStep, ThreadPingCallback, Nothing)
            Next i
        End If
    End Sub

    Sub ThreadWinNTComplete(ByVal iAsyncResult As IAsyncResult)
        Try
            Dim Machines As Collection
            Machines = ThreadWinNT.EndInvoke(iAsyncResult)
            If Me.InvokeRequired Then
                Dim handler As New UpdateMachinesHandler(AddressOf UpdateMachines)
                Dim args() As Object = {Machines, True}
                Me.BeginInvoke(handler, args)
            Else
                UpdateMachines(Machines, True)
            End If
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

    Sub ThreadPingComplete(ByVal iAsyncResult As IAsyncResult)
        Try
            SyncLock Me
                Dim oPingObject As PingObject
                oPingObject = ThreadPing.EndInvoke(iAsyncResult)
                nTotalIPs += oPingObject.nEnd - oPingObject.nStart + 1
                If Me.InvokeRequired Then
                    Dim handler1 As New UpdateMachinesHandler(AddressOf UpdateMachines)
                    Dim args1() As Object = {oPingObject.cMachines, nTotalIPs >= nMaxIPs}
                    Me.BeginInvoke(handler1, args1)
                    Dim handler2 As New UpdateProgressHandler(AddressOf UpdateProgress)
                    Dim args2() As Object = {Math.Min(nTotalIPs, nMaxIPs), nMaxIPs}
                    Me.BeginInvoke(handler2, args2)
                Else
                    UpdateMachines(oPingObject.cMachines, nTotalIPs >= nMaxIPs)
                End If
            End SyncLock
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub

    Sub UpdateMachines(ByVal Machines As Collection, ByVal bLast As Boolean)
        SyncLock Me
            If ListEmpty And Machines.Count > 0 Then
                lstNetwork.Items.Clear()
                cMachines.Clear()
                ListEmpty = False
            End If
            Dim obj As NetworkObject
            For Each obj In Machines
                lstNetwork.Items.Add(obj.Name)
                cMachines.Add(obj.IP)
            Next
            lstNetwork.Enabled = Not chkCustomPeer.Checked And Not ListEmpty
            If bLast Then
                If ListEmpty Then
                    lstNetwork.Items.Clear()
                    lstNetwork.Items.Add("No games found on network using port " & nPort & ".")
                End If
                pgbNetwork.Visible = False
                btnRefresh.Enabled = True
                Refreshing = False
            End If
        End SyncLock
    End Sub

    Sub UpdateProgress(ByVal Value As Integer, ByVal Max As Integer)
        pgbNetwork.Maximum = Max
        pgbNetwork.Value = Value
        pgbNetwork.Style = ProgressBarStyle.Blocks
    End Sub

    Sub GetControls(ByRef cParent As Control)
        For Each cControl As Control In cParent.Controls
            cControls.Add(cControl)
            Console.WriteLine(cControl.Name)
            If cControl.HasChildren Then
                GetControls(cControl)
            End If
        Next
    End Sub

    Sub LoadSettings()
        Dim settingIni As New IniFile(sAppDir & settingIniFile)
        Dim sDir As String = settingIni.GetString("l4d", "gamedir", Nothing)
        If Not sDir Is Nothing Then
            sGameDir = sDir
        End If
        For Each cControl In cControls
            LoadSettingIni(settingIni, cControl)
        Next
    End Sub

    Sub SaveSettings()
        Dim settingIni As New IniFile(sAppDir & settingIniFile)
        settingIni.WriteString("l4d", "gamedir", sGameDir)
        For Each cControl In cControls
            SaveSettingIni(settingIni, cControl)
        Next
        'SaveSettingIni(settingIni, chkName)
        'SaveSettingIni(settingIni, txtName)
        'SaveSettingIni(settingIni, chkNameINI)
    End Sub

    Sub LoadSettingIni(ByRef settingIni As IniFile, ByRef cControl As Control)
        If cControl.Name = "cboMaps" Then
            nSelectedMap = settingIni.GetInteger("controls", cControl.Name, cboMaps.SelectedIndex)
        Else
            If TypeOf cControl Is CheckBox Then
                Dim cCheck As CheckBox = cControl
                cCheck.Checked = settingIni.GetInteger("controls", cControl.Name, cCheck.Checked)
            ElseIf TypeOf cControl Is TextBox Then
                Dim cText As TextBox = cControl
                cText.Text = settingIni.GetString("controls", cControl.Name, cText.Text)
            ElseIf TypeOf cControl Is ComboBox Then
                Dim cCombo As ComboBox = cControl
                cCombo.SelectedIndex = settingIni.GetInteger("controls", cControl.Name, cCombo.SelectedIndex)
            End If
        End If
    End Sub

    Sub SaveSettingIni(ByRef settingIni As IniFile, ByRef cControl As Control)
        If TypeOf cControl Is CheckBox Then
            Dim cCheck As CheckBox = cControl
            settingIni.WriteInteger("controls", cControl.Name, IIf(cCheck.Checked, 1, 0))
        ElseIf TypeOf cControl Is TextBox Then
            Dim cText As TextBox = cControl
            settingIni.WriteString("controls", cControl.Name, cText.Text)
        ElseIf TypeOf cControl Is ComboBox Then
            Dim cCombo As ComboBox = cControl
            settingIni.WriteInteger("controls", cControl.Name, cCombo.SelectedIndex)
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RefreshNetwork()
    End Sub

    Private Sub chkCustomPeer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtPeer.Enabled = chkCustomPeer.Checked
        lstNetwork.Enabled = Not chkCustomPeer.Checked And Not ListEmpty
    End Sub

    Private Sub chkPlayer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkPlayer.CheckedChanged
        cboPlayer.Enabled = chkPlayer.Checked
    End Sub

    Private Sub chkName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkName.CheckedChanged
        txtName.Enabled = chkName.Checked
        chkNameINI.Enabled = chkName.Checked
    End Sub

    Private Sub btnFix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFix.Click
        NotFound.SetPath(sGameDir)
        NotFound.NoExit = True
        Dim res As DialogResult = NotFound.ShowDialog(Me)
        If res <> Windows.Forms.DialogResult.Cancel Then
            sGameDir = NotFound.GetPath()
            If res = Windows.Forms.DialogResult.Retry Then
                CheckGameDir(True, True)
            Else
                CheckGameDir(True, False)
            End If
        Else
            Exit Sub
        End If
    End Sub

    Private Sub cboMaps_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMaps.SelectedIndexChanged
        lstMaps.Items.Clear()
        Dim items As New ArrayList
        For Each mMap As Map In cMaps
            Select Case cboMaps.SelectedIndex
                Case 0
                    If Not mMap.AddOn Is Nothing Then Continue For
                Case 1
                    If Not mMap.AddOn Is Nothing Then Continue For
                    If Not mMap.IsCoop Then Continue For
                Case 2
                    If Not mMap.AddOn Is Nothing Then Continue For
                    If Not mMap.IsVersus Then Continue For
                Case 3
                    If Not mMap.AddOn Is Nothing Then Continue For
                    If Not mMap.IsSurival Then Continue For
                Case Else
                    Dim sAddon As String = cAddons(cboMaps.SelectedIndex - 3)
                    If mMap.AddOn <> sAddon Then Continue For
            End Select
            Dim pos As Integer = InStrRev(mMap.Name, ".bsp")
            If pos > 0 Then
                items.Add(Mid(mMap.Name, 1, pos - 1))
            End If
        Next
        items.Sort()
        lstMaps.Items.AddRange(items.ToArray)
    End Sub

End Class
