<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Launcher
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Launcher))
        Me.grpGeneral = New System.Windows.Forms.GroupBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.chkName = New System.Windows.Forms.CheckBox
        Me.cboPlayer = New System.Windows.Forms.ComboBox
        Me.chkPlayer = New System.Windows.Forms.CheckBox
        Me.chkVideo = New System.Windows.Forms.CheckBox
        Me.chkConsole = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tabs = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.grpVPK = New System.Windows.Forms.GroupBox
        Me.pgbVPK = New System.Windows.Forms.ProgressBar
        Me.lstMaps = New System.Windows.Forms.ListBox
        Me.cboMaps = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.optNormal = New System.Windows.Forms.RadioButton
        Me.optImpossible = New System.Windows.Forms.RadioButton
        Me.optHard = New System.Windows.Forms.RadioButton
        Me.optEasy = New System.Windows.Forms.RadioButton
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.grpNetwork = New System.Windows.Forms.GroupBox
        Me.pgbNetwork = New System.Windows.Forms.ProgressBar
        Me.txtPeer = New System.Windows.Forms.TextBox
        Me.chkCustomPeer = New System.Windows.Forms.CheckBox
        Me.lstNetwork = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.grpNetworkScanning = New System.Windows.Forms.GroupBox
        Me.cboScan = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.lblTimeout = New System.Windows.Forms.Label
        Me.lblPort = New System.Windows.Forms.Label
        Me.txtTimeout = New System.Windows.Forms.TextBox
        Me.txtPort = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.chkClipboard = New System.Windows.Forms.CheckBox
        Me.txtCommandLine = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.lblVersion = New System.Windows.Forms.Label
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblNetwork = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboGameType = New System.Windows.Forms.ComboBox
        Me.chkMultiplayer = New System.Windows.Forms.CheckBox
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.btnFix = New System.Windows.Forms.Button
        Me.picBanner = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnLaunch = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.grpGeneral.SuspendLayout()
        Me.tabs.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpVPK.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.grpNetwork.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.grpNetworkScanning.SuspendLayout()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpGeneral
        '
        Me.grpGeneral.Controls.Add(Me.txtName)
        Me.grpGeneral.Controls.Add(Me.chkName)
        Me.grpGeneral.Controls.Add(Me.cboPlayer)
        Me.grpGeneral.Controls.Add(Me.chkPlayer)
        Me.grpGeneral.Controls.Add(Me.chkVideo)
        Me.grpGeneral.Controls.Add(Me.chkConsole)
        Me.grpGeneral.Location = New System.Drawing.Point(71, 147)
        Me.grpGeneral.Name = "grpGeneral"
        Me.grpGeneral.Size = New System.Drawing.Size(433, 69)
        Me.grpGeneral.TabIndex = 0
        Me.grpGeneral.TabStop = False
        Me.grpGeneral.Text = "General options"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(109, 16)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(118, 20)
        Me.txtName.TabIndex = 1
        '
        'chkName
        '
        Me.chkName.AutoSize = True
        Me.chkName.Location = New System.Drawing.Point(6, 19)
        Me.chkName.Name = "chkName"
        Me.chkName.Size = New System.Drawing.Size(77, 17)
        Me.chkName.TabIndex = 0
        Me.chkName.Text = "&Nickname:"
        Me.chkName.UseVisualStyleBackColor = True
        '
        'cboPlayer
        '
        Me.cboPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayer.FormattingEnabled = True
        Me.cboPlayer.Items.AddRange(New Object() {"Bill", "Francis", "Louis", "Zoey"})
        Me.cboPlayer.Location = New System.Drawing.Point(109, 40)
        Me.cboPlayer.Name = "cboPlayer"
        Me.cboPlayer.Size = New System.Drawing.Size(118, 21)
        Me.cboPlayer.TabIndex = 4
        '
        'chkPlayer
        '
        Me.chkPlayer.AutoSize = True
        Me.chkPlayer.Location = New System.Drawing.Point(6, 42)
        Me.chkPlayer.Name = "chkPlayer"
        Me.chkPlayer.Size = New System.Drawing.Size(103, 17)
        Me.chkPlayer.TabIndex = 3
        Me.chkPlayer.Text = "&Preferred player:"
        Me.chkPlayer.UseVisualStyleBackColor = True
        '
        'chkVideo
        '
        Me.chkVideo.AutoSize = True
        Me.chkVideo.Location = New System.Drawing.Point(243, 42)
        Me.chkVideo.Name = "chkVideo"
        Me.chkVideo.Size = New System.Drawing.Size(112, 17)
        Me.chkVideo.TabIndex = 6
        Me.chkVideo.Text = "Display intro &video"
        Me.chkVideo.UseVisualStyleBackColor = True
        '
        'chkConsole
        '
        Me.chkConsole.AutoSize = True
        Me.chkConsole.Checked = True
        Me.chkConsole.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConsole.Location = New System.Drawing.Point(243, 19)
        Me.chkConsole.Name = "chkConsole"
        Me.chkConsole.Size = New System.Drawing.Size(99, 17)
        Me.chkConsole.TabIndex = 5
        Me.chkConsole.Text = "Enable c&onsole"
        Me.chkConsole.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Easily set up & join Left 4 Dead network games"
        Me.Label1.UseMnemonic = False
        '
        'tabs
        '
        Me.tabs.Controls.Add(Me.TabPage1)
        Me.tabs.Controls.Add(Me.TabPage2)
        Me.tabs.Controls.Add(Me.TabPage3)
        Me.tabs.ImageList = Me.ImageList
        Me.tabs.Location = New System.Drawing.Point(71, 222)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(433, 240)
        Me.tabs.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cboGameType)
        Me.TabPage1.Controls.Add(Me.grpVPK)
        Me.TabPage1.Controls.Add(Me.lstMaps)
        Me.TabPage1.Controls.Add(Me.cboMaps)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.optNormal)
        Me.TabPage1.Controls.Add(Me.optImpossible)
        Me.TabPage1.Controls.Add(Me.optHard)
        Me.TabPage1.Controls.Add(Me.optEasy)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(425, 213)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Host"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'grpVPK
        '
        Me.grpVPK.Controls.Add(Me.pgbVPK)
        Me.grpVPK.Location = New System.Drawing.Point(106, 112)
        Me.grpVPK.Name = "grpVPK"
        Me.grpVPK.Size = New System.Drawing.Size(204, 40)
        Me.grpVPK.TabIndex = 16
        Me.grpVPK.TabStop = False
        Me.grpVPK.Text = "Reading VPK file..."
        Me.grpVPK.Visible = False
        '
        'pgbVPK
        '
        Me.pgbVPK.Location = New System.Drawing.Point(6, 17)
        Me.pgbVPK.Name = "pgbVPK"
        Me.pgbVPK.Size = New System.Drawing.Size(191, 15)
        Me.pgbVPK.TabIndex = 16
        '
        'lstMaps
        '
        Me.lstMaps.ColumnWidth = 162
        Me.lstMaps.FormattingEnabled = True
        Me.lstMaps.IntegralHeight = False
        Me.lstMaps.Location = New System.Drawing.Point(9, 56)
        Me.lstMaps.MultiColumn = True
        Me.lstMaps.Name = "lstMaps"
        Me.lstMaps.Size = New System.Drawing.Size(410, 151)
        Me.lstMaps.TabIndex = 13
        '
        'cboMaps
        '
        Me.cboMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMaps.FormattingEnabled = True
        Me.cboMaps.Location = New System.Drawing.Point(60, 29)
        Me.cboMaps.Name = "cboMaps"
        Me.cboMaps.Size = New System.Drawing.Size(183, 21)
        Me.cboMaps.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Map set:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Difficulty:"
        '
        'optNormal
        '
        Me.optNormal.AutoSize = True
        Me.optNormal.Checked = True
        Me.optNormal.Location = New System.Drawing.Point(116, 6)
        Me.optNormal.Name = "optNormal"
        Me.optNormal.Size = New System.Drawing.Size(58, 17)
        Me.optNormal.TabIndex = 9
        Me.optNormal.TabStop = True
        Me.optNormal.Text = "&Normal"
        Me.optNormal.UseVisualStyleBackColor = True
        '
        'optImpossible
        '
        Me.optImpossible.AutoSize = True
        Me.optImpossible.Location = New System.Drawing.Point(234, 6)
        Me.optImpossible.Name = "optImpossible"
        Me.optImpossible.Size = New System.Drawing.Size(74, 17)
        Me.optImpossible.TabIndex = 11
        Me.optImpossible.Text = "&Impossible"
        Me.optImpossible.UseVisualStyleBackColor = True
        '
        'optHard
        '
        Me.optHard.AutoSize = True
        Me.optHard.Location = New System.Drawing.Point(180, 6)
        Me.optHard.Name = "optHard"
        Me.optHard.Size = New System.Drawing.Size(48, 17)
        Me.optHard.TabIndex = 10
        Me.optHard.Text = "H&ard"
        Me.optHard.UseVisualStyleBackColor = True
        '
        'optEasy
        '
        Me.optEasy.AutoSize = True
        Me.optEasy.Location = New System.Drawing.Point(62, 6)
        Me.optEasy.Name = "optEasy"
        Me.optEasy.Size = New System.Drawing.Size(48, 17)
        Me.optEasy.TabIndex = 8
        Me.optEasy.Text = "&Easy"
        Me.optEasy.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.grpNetwork)
        Me.TabPage2.Controls.Add(Me.txtPeer)
        Me.TabPage2.Controls.Add(Me.chkCustomPeer)
        Me.TabPage2.Controls.Add(Me.lstNetwork)
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(425, 213)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Join"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'grpNetwork
        '
        Me.grpNetwork.Controls.Add(Me.lblNetwork)
        Me.grpNetwork.Controls.Add(Me.pgbNetwork)
        Me.grpNetwork.Location = New System.Drawing.Point(111, 82)
        Me.grpNetwork.Name = "grpNetwork"
        Me.grpNetwork.Size = New System.Drawing.Size(204, 40)
        Me.grpNetwork.TabIndex = 15
        Me.grpNetwork.TabStop = False
        Me.grpNetwork.Text = "Populating network peers..."
        Me.grpNetwork.Visible = False
        '
        'pgbNetwork
        '
        Me.pgbNetwork.BackColor = System.Drawing.Color.Black
        Me.pgbNetwork.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.pgbNetwork.Location = New System.Drawing.Point(6, 17)
        Me.pgbNetwork.Name = "pgbNetwork"
        Me.pgbNetwork.Size = New System.Drawing.Size(191, 15)
        Me.pgbNetwork.TabIndex = 16
        '
        'txtPeer
        '
        Me.txtPeer.Location = New System.Drawing.Point(247, 187)
        Me.txtPeer.Name = "txtPeer"
        Me.txtPeer.Size = New System.Drawing.Size(172, 20)
        Me.txtPeer.TabIndex = 14
        '
        'chkCustomPeer
        '
        Me.chkCustomPeer.AutoSize = True
        Me.chkCustomPeer.Location = New System.Drawing.Point(177, 189)
        Me.chkCustomPeer.Name = "chkCustomPeer"
        Me.chkCustomPeer.Size = New System.Drawing.Size(64, 17)
        Me.chkCustomPeer.TabIndex = 13
        Me.chkCustomPeer.Text = "Custom:"
        Me.chkCustomPeer.UseVisualStyleBackColor = True
        '
        'lstNetwork
        '
        Me.lstNetwork.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstNetwork.FullRowSelect = True
        Me.lstNetwork.Location = New System.Drawing.Point(6, 6)
        Me.lstNetwork.MultiSelect = False
        Me.lstNetwork.Name = "lstNetwork"
        Me.lstNetwork.Size = New System.Drawing.Size(413, 175)
        Me.lstNetwork.TabIndex = 16
        Me.lstNetwork.UseCompatibleStateImageBehavior = False
        Me.lstNetwork.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Server"
        Me.ColumnHeader1.Width = 110
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Name"
        Me.ColumnHeader2.Width = 102
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Players"
        Me.ColumnHeader3.Width = 70
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Map"
        Me.ColumnHeader4.Width = 106
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.chkMultiplayer)
        Me.TabPage3.Controls.Add(Me.grpNetworkScanning)
        Me.TabPage3.Controls.Add(Me.chkClipboard)
        Me.TabPage3.Controls.Add(Me.txtCommandLine)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(425, 213)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Additional parameters"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'grpNetworkScanning
        '
        Me.grpNetworkScanning.Controls.Add(Me.Label9)
        Me.grpNetworkScanning.Controls.Add(Me.cboScan)
        Me.grpNetworkScanning.Controls.Add(Me.Label8)
        Me.grpNetworkScanning.Controls.Add(Me.lblTimeout)
        Me.grpNetworkScanning.Controls.Add(Me.lblPort)
        Me.grpNetworkScanning.Controls.Add(Me.txtTimeout)
        Me.grpNetworkScanning.Controls.Add(Me.txtPort)
        Me.grpNetworkScanning.Controls.Add(Me.Label5)
        Me.grpNetworkScanning.Controls.Add(Me.Label4)
        Me.grpNetworkScanning.Location = New System.Drawing.Point(6, 106)
        Me.grpNetworkScanning.Name = "grpNetworkScanning"
        Me.grpNetworkScanning.Size = New System.Drawing.Size(413, 101)
        Me.grpNetworkScanning.TabIndex = 7
        Me.grpNetworkScanning.TabStop = False
        Me.grpNetworkScanning.Text = "Network peer scanning"
        '
        'cboScan
        '
        Me.cboScan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboScan.FormattingEnabled = True
        Me.cboScan.Items.AddRange(New Object() {"Broadcast", "Range scan"})
        Me.cboScan.Location = New System.Drawing.Point(81, 19)
        Me.cboScan.Name = "cboScan"
        Me.cboScan.Size = New System.Drawing.Size(141, 21)
        Me.cboScan.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Scan mode:"
        '
        'lblTimeout
        '
        Me.lblTimeout.AutoSize = True
        Me.lblTimeout.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblTimeout.Location = New System.Drawing.Point(151, 74)
        Me.lblTimeout.Name = "lblTimeout"
        Me.lblTimeout.Size = New System.Drawing.Size(91, 13)
        Me.lblTimeout.TabIndex = 12
        Me.lblTimeout.Text = "Recommended: 0"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.ForeColor = System.Drawing.SystemColors.GrayText
        Me.lblPort.Location = New System.Drawing.Point(151, 49)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(53, 13)
        Me.lblPort.TabIndex = 11
        Me.lblPort.Text = "Default: 0"
        '
        'txtTimeout
        '
        Me.txtTimeout.Location = New System.Drawing.Point(81, 71)
        Me.txtTimeout.Name = "txtTimeout"
        Me.txtTimeout.Size = New System.Drawing.Size(64, 20)
        Me.txtTimeout.TabIndex = 10
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(81, 46)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(64, 20)
        Me.txtPort.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Timeout (ms):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "TCP/IP port:"
        '
        'chkClipboard
        '
        Me.chkClipboard.AutoSize = True
        Me.chkClipboard.Location = New System.Drawing.Point(9, 53)
        Me.chkClipboard.Name = "chkClipboard"
        Me.chkClipboard.Size = New System.Drawing.Size(304, 17)
        Me.chkClipboard.TabIndex = 2
        Me.chkClipboard.Text = "Copy execution command to clipboard instead of launching"
        Me.chkClipboard.UseVisualStyleBackColor = True
        '
        'txtCommandLine
        '
        Me.txtCommandLine.Location = New System.Drawing.Point(9, 27)
        Me.txtCommandLine.Name = "txtCommandLine"
        Me.txtCommandLine.Size = New System.Drawing.Size(410, 20)
        Me.txtCommandLine.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(346, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Specify additional command line arguments:"
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "server_network.ico")
        Me.ImageList.Images.SetKeyName(1, "client_network.ico")
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Black
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.Silver
        Me.lblVersion.Location = New System.Drawing.Point(71, 4)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(64, 13)
        Me.lblVersion.TabIndex = 13
        Me.lblVersion.Text = "L4D version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblNetwork
        '
        Me.lblNetwork.Location = New System.Drawing.Point(6, 14)
        Me.lblNetwork.Name = "lblNetwork"
        Me.lblNetwork.Size = New System.Drawing.Size(191, 16)
        Me.lblNetwork.TabIndex = 17
        Me.lblNetwork.Text = "No servers found on the network."
        Me.lblNetwork.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblNetwork.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(261, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Game type:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboGameType
        '
        Me.cboGameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGameType.FormattingEnabled = True
        Me.cboGameType.Items.AddRange(New Object() {"Coop", "Versus", "Survival"})
        Me.cboGameType.Location = New System.Drawing.Point(328, 29)
        Me.cboGameType.Name = "cboGameType"
        Me.cboGameType.Size = New System.Drawing.Size(91, 21)
        Me.cboGameType.TabIndex = 17
        '
        'chkMultiplayer
        '
        Me.chkMultiplayer.AutoSize = True
        Me.chkMultiplayer.Checked = True
        Me.chkMultiplayer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMultiplayer.Location = New System.Drawing.Point(9, 76)
        Me.chkMultiplayer.Name = "chkMultiplayer"
        Me.chkMultiplayer.Size = New System.Drawing.Size(140, 17)
        Me.chkMultiplayer.TabIndex = 8
        Me.chkMultiplayer.Text = "Enable multiplayer mode"
        Me.chkMultiplayer.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.L4D_launcher.My.Resources.Resources.close_glow_16
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(442, 468)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(4, 0, 6, 0)
        Me.btnCancel.Size = New System.Drawing.Size(62, 30)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "E&xit"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Image = Global.L4D_launcher.My.Resources.Resources.refresh_glow_16
        Me.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnRefresh.Location = New System.Drawing.Point(162, 468)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Padding = New System.Windows.Forms.Padding(4, 0, 3, 0)
        Me.btnRefresh.Size = New System.Drawing.Size(77, 30)
        Me.btnRefresh.TabIndex = 14
        Me.btnRefresh.Text = "&Refresh"
        Me.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnFix
        '
        Me.btnFix.Image = Global.L4D_launcher.My.Resources.Resources.fix_glow_16
        Me.btnFix.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnFix.Location = New System.Drawing.Point(309, 468)
        Me.btnFix.Name = "btnFix"
        Me.btnFix.Padding = New System.Windows.Forms.Padding(4, 0, 7, 0)
        Me.btnFix.Size = New System.Drawing.Size(127, 30)
        Me.btnFix.TabIndex = 3
        Me.btnFix.Text = "&Fix uninstall path"
        Me.btnFix.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnFix.UseVisualStyleBackColor = True
        Me.btnFix.Visible = False
        '
        'picBanner
        '
        Me.picBanner.BackColor = System.Drawing.Color.Black
        Me.picBanner.Dock = System.Windows.Forms.DockStyle.Top
        Me.picBanner.Image = CType(resources.GetObject("picBanner.Image"), System.Drawing.Image)
        Me.picBanner.Location = New System.Drawing.Point(0, 0)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(516, 119)
        Me.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBanner.TabIndex = 11
        Me.picBanner.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 125)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(48, 48)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'btnLaunch
        '
        Me.btnLaunch.Image = Global.L4D_launcher.My.Resources.Resources.accepted_glow_16
        Me.btnLaunch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLaunch.Location = New System.Drawing.Point(71, 468)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Padding = New System.Windows.Forms.Padding(4, 0, 7, 0)
        Me.btnLaunch.Size = New System.Drawing.Size(85, 30)
        Me.btnLaunch.TabIndex = 2
        Me.btnLaunch.Text = "&Launch"
        Me.btnLaunch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.GrayText
        Me.Label9.Location = New System.Drawing.Point(228, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(133, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Recommended: Broadcast"
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(516, 508)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnFix)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.picBanner)
        Me.Controls.Add(Me.tabs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpGeneral)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLaunch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Launcher"
        Me.Text = "L4D Launcher"
        Me.grpGeneral.ResumeLayout(False)
        Me.grpGeneral.PerformLayout()
        Me.tabs.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.grpVPK.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.grpNetwork.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.grpNetworkScanning.ResumeLayout(False)
        Me.grpNetworkScanning.PerformLayout()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLaunch As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grpGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkVideo As System.Windows.Forms.CheckBox
    Friend WithEvents chkConsole As System.Windows.Forms.CheckBox
    Friend WithEvents tabs As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtCommandLine As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkClipboard As System.Windows.Forms.CheckBox
    Friend WithEvents chkPlayer As System.Windows.Forms.CheckBox
    Friend WithEvents cboPlayer As System.Windows.Forms.ComboBox
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents chkName As System.Windows.Forms.CheckBox
    Friend WithEvents grpNetworkScanning As System.Windows.Forms.GroupBox
    Friend WithEvents txtTimeout As System.Windows.Forms.TextBox
    Friend WithEvents txtPort As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblTimeout As System.Windows.Forms.Label
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnFix As System.Windows.Forms.Button
    Friend WithEvents cboMaps As System.Windows.Forms.ComboBox
    Friend WithEvents lstMaps As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents optNormal As System.Windows.Forms.RadioButton
    Friend WithEvents optImpossible As System.Windows.Forms.RadioButton
    Friend WithEvents optHard As System.Windows.Forms.RadioButton
    Friend WithEvents optEasy As System.Windows.Forms.RadioButton
    Friend WithEvents txtPeer As System.Windows.Forms.TextBox
    Friend WithEvents chkCustomPeer As System.Windows.Forms.CheckBox
    Friend WithEvents grpVPK As System.Windows.Forms.GroupBox
    Friend WithEvents pgbVPK As System.Windows.Forms.ProgressBar
    Friend WithEvents grpNetwork As System.Windows.Forms.GroupBox
    Friend WithEvents pgbNetwork As System.Windows.Forms.ProgressBar
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents lstNetwork As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents cboScan As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblNetwork As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboGameType As System.Windows.Forms.ComboBox
    Friend WithEvents chkMultiplayer As System.Windows.Forms.CheckBox
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class