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
        Me.btnCancel = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cboPlayer = New System.Windows.Forms.ComboBox
        Me.chkPlayer = New System.Windows.Forms.CheckBox
        Me.chkVideo = New System.Windows.Forms.CheckBox
        Me.chkConsole = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.tabs = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label2 = New System.Windows.Forms.Label
        Me.cboGameType = New System.Windows.Forms.ComboBox
        Me.chkMultiplayer = New System.Windows.Forms.CheckBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.optNormal = New System.Windows.Forms.RadioButton
        Me.optImpossible = New System.Windows.Forms.RadioButton
        Me.optHard = New System.Windows.Forms.RadioButton
        Me.optEasy = New System.Windows.Forms.RadioButton
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lstMaps = New System.Windows.Forms.ListBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.pgbNetwork = New System.Windows.Forms.ProgressBar
        Me.txtPeer = New System.Windows.Forms.TextBox
        Me.chkCustomPeer = New System.Windows.Forms.CheckBox
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.lstNetwork = New System.Windows.Forms.ListBox
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.chkClipboard = New System.Windows.Forms.CheckBox
        Me.txtCommandLine = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.picBanner = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.btnLaunch = New System.Windows.Forms.Button
        Me.lblVersion = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.tabs.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Image = Global.L4D_launcher.My.Resources.Resources.close_glow_16
        Me.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancel.Location = New System.Drawing.Point(370, 464)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Padding = New System.Windows.Forms.Padding(4, 0, 8, 0)
        Me.btnCancel.Size = New System.Drawing.Size(67, 30)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "E&xit"
        Me.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboPlayer)
        Me.GroupBox1.Controls.Add(Me.chkPlayer)
        Me.GroupBox1.Controls.Add(Me.chkVideo)
        Me.GroupBox1.Controls.Add(Me.chkConsole)
        Me.GroupBox1.Location = New System.Drawing.Point(71, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(366, 69)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "General options"
        '
        'cboPlayer
        '
        Me.cboPlayer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboPlayer.FormattingEnabled = True
        Me.cboPlayer.Items.AddRange(New Object() {"Bill", "Francis", "Louis", "Zoey"})
        Me.cboPlayer.Location = New System.Drawing.Point(115, 40)
        Me.cboPlayer.Name = "cboPlayer"
        Me.cboPlayer.Size = New System.Drawing.Size(91, 21)
        Me.cboPlayer.TabIndex = 7
        '
        'chkPlayer
        '
        Me.chkPlayer.AutoSize = True
        Me.chkPlayer.Location = New System.Drawing.Point(6, 42)
        Me.chkPlayer.Name = "chkPlayer"
        Me.chkPlayer.Size = New System.Drawing.Size(103, 17)
        Me.chkPlayer.TabIndex = 2
        Me.chkPlayer.Text = "&Preferred player:"
        Me.chkPlayer.UseVisualStyleBackColor = True
        '
        'chkVideo
        '
        Me.chkVideo.AutoSize = True
        Me.chkVideo.Checked = True
        Me.chkVideo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkVideo.Location = New System.Drawing.Point(176, 19)
        Me.chkVideo.Name = "chkVideo"
        Me.chkVideo.Size = New System.Drawing.Size(113, 17)
        Me.chkVideo.TabIndex = 1
        Me.chkVideo.Text = "Disable intro &video"
        Me.chkVideo.UseVisualStyleBackColor = True
        '
        'chkConsole
        '
        Me.chkConsole.AutoSize = True
        Me.chkConsole.Checked = True
        Me.chkConsole.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkConsole.Location = New System.Drawing.Point(6, 19)
        Me.chkConsole.Name = "chkConsole"
        Me.chkConsole.Size = New System.Drawing.Size(99, 17)
        Me.chkConsole.TabIndex = 0
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
        Me.tabs.Location = New System.Drawing.Point(71, 218)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(366, 240)
        Me.tabs.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.cboGameType)
        Me.TabPage1.Controls.Add(Me.chkMultiplayer)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox3)
        Me.TabPage1.ImageIndex = 0
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(358, 213)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Host"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(194, 190)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Game type:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cboGameType
        '
        Me.cboGameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboGameType.FormattingEnabled = True
        Me.cboGameType.Items.AddRange(New Object() {"Coop", "Versus", "Survival"})
        Me.cboGameType.Location = New System.Drawing.Point(261, 186)
        Me.cboGameType.Name = "cboGameType"
        Me.cboGameType.Size = New System.Drawing.Size(91, 21)
        Me.cboGameType.TabIndex = 6
        '
        'chkMultiplayer
        '
        Me.chkMultiplayer.AutoSize = True
        Me.chkMultiplayer.Checked = True
        Me.chkMultiplayer.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMultiplayer.Location = New System.Drawing.Point(6, 189)
        Me.chkMultiplayer.Name = "chkMultiplayer"
        Me.chkMultiplayer.Size = New System.Drawing.Size(140, 17)
        Me.chkMultiplayer.TabIndex = 5
        Me.chkMultiplayer.Text = "Enable multiplayer mode"
        Me.chkMultiplayer.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.optNormal)
        Me.GroupBox2.Controls.Add(Me.optImpossible)
        Me.GroupBox2.Controls.Add(Me.optHard)
        Me.GroupBox2.Controls.Add(Me.optEasy)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 42)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Difficulty"
        '
        'optNormal
        '
        Me.optNormal.AutoSize = True
        Me.optNormal.Checked = True
        Me.optNormal.Location = New System.Drawing.Point(81, 19)
        Me.optNormal.Name = "optNormal"
        Me.optNormal.Size = New System.Drawing.Size(58, 17)
        Me.optNormal.TabIndex = 3
        Me.optNormal.TabStop = True
        Me.optNormal.Text = "&Normal"
        Me.optNormal.UseVisualStyleBackColor = True
        '
        'optImpossible
        '
        Me.optImpossible.AutoSize = True
        Me.optImpossible.Location = New System.Drawing.Point(241, 19)
        Me.optImpossible.Name = "optImpossible"
        Me.optImpossible.Size = New System.Drawing.Size(74, 17)
        Me.optImpossible.TabIndex = 5
        Me.optImpossible.Text = "&Impossible"
        Me.optImpossible.UseVisualStyleBackColor = True
        '
        'optHard
        '
        Me.optHard.AutoSize = True
        Me.optHard.Location = New System.Drawing.Point(166, 19)
        Me.optHard.Name = "optHard"
        Me.optHard.Size = New System.Drawing.Size(48, 17)
        Me.optHard.TabIndex = 4
        Me.optHard.Text = "H&ard"
        Me.optHard.UseVisualStyleBackColor = True
        '
        'optEasy
        '
        Me.optEasy.AutoSize = True
        Me.optEasy.Location = New System.Drawing.Point(6, 19)
        Me.optEasy.Name = "optEasy"
        Me.optEasy.Size = New System.Drawing.Size(48, 17)
        Me.optEasy.TabIndex = 2
        Me.optEasy.Text = "&Easy"
        Me.optEasy.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lstMaps)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 54)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(346, 129)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Map / Episode"
        '
        'lstMaps
        '
        Me.lstMaps.ColumnWidth = 150
        Me.lstMaps.FormattingEnabled = True
        Me.lstMaps.IntegralHeight = False
        Me.lstMaps.Location = New System.Drawing.Point(6, 19)
        Me.lstMaps.MultiColumn = True
        Me.lstMaps.Name = "lstMaps"
        Me.lstMaps.Size = New System.Drawing.Size(334, 104)
        Me.lstMaps.TabIndex = 6
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.ImageIndex = 1
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(358, 213)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Join"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.pgbNetwork)
        Me.GroupBox4.Controls.Add(Me.txtPeer)
        Me.GroupBox4.Controls.Add(Me.chkCustomPeer)
        Me.GroupBox4.Controls.Add(Me.btnRefresh)
        Me.GroupBox4.Controls.Add(Me.lstNetwork)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(346, 198)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Network peers"
        '
        'pgbNetwork
        '
        Me.pgbNetwork.Location = New System.Drawing.Point(78, 83)
        Me.pgbNetwork.Name = "pgbNetwork"
        Me.pgbNetwork.Size = New System.Drawing.Size(191, 15)
        Me.pgbNetwork.TabIndex = 10
        Me.pgbNetwork.Visible = False
        '
        'txtPeer
        '
        Me.txtPeer.Location = New System.Drawing.Point(179, 169)
        Me.txtPeer.Name = "txtPeer"
        Me.txtPeer.Size = New System.Drawing.Size(161, 20)
        Me.txtPeer.TabIndex = 9
        '
        'chkCustomPeer
        '
        Me.chkCustomPeer.AutoSize = True
        Me.chkCustomPeer.Location = New System.Drawing.Point(115, 173)
        Me.chkCustomPeer.Name = "chkCustomPeer"
        Me.chkCustomPeer.Size = New System.Drawing.Size(64, 17)
        Me.chkCustomPeer.TabIndex = 8
        Me.chkCustomPeer.Text = "Custom:"
        Me.chkCustomPeer.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(6, 168)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(102, 24)
        Me.btnRefresh.TabIndex = 7
        Me.btnRefresh.Text = "Refresh list"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'lstNetwork
        '
        Me.lstNetwork.ColumnWidth = 150
        Me.lstNetwork.FormattingEnabled = True
        Me.lstNetwork.IntegralHeight = False
        Me.lstNetwork.Location = New System.Drawing.Point(6, 19)
        Me.lstNetwork.MultiColumn = True
        Me.lstNetwork.Name = "lstNetwork"
        Me.lstNetwork.Size = New System.Drawing.Size(334, 143)
        Me.lstNetwork.TabIndex = 6
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.chkClipboard)
        Me.TabPage3.Controls.Add(Me.txtCommandLine)
        Me.TabPage3.Controls.Add(Me.Label3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(358, 213)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Additional parameters"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'chkClipboard
        '
        Me.chkClipboard.AutoSize = True
        Me.chkClipboard.Location = New System.Drawing.Point(6, 53)
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
        Me.txtCommandLine.Size = New System.Drawing.Size(343, 20)
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
        'picBanner
        '
        Me.picBanner.Dock = System.Windows.Forms.DockStyle.Top
        Me.picBanner.Image = CType(resources.GetObject("picBanner.Image"), System.Drawing.Image)
        Me.picBanner.Location = New System.Drawing.Point(0, 0)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(449, 119)
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
        Me.btnLaunch.Location = New System.Drawing.Point(71, 464)
        Me.btnLaunch.Name = "btnLaunch"
        Me.btnLaunch.Padding = New System.Windows.Forms.Padding(4, 0, 8, 0)
        Me.btnLaunch.Size = New System.Drawing.Size(85, 30)
        Me.btnLaunch.TabIndex = 7
        Me.btnLaunch.Text = "&Launch"
        Me.btnLaunch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLaunch.UseVisualStyleBackColor = True
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.AutoSize = True
        Me.lblVersion.BackColor = System.Drawing.Color.Black
        Me.lblVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.ForeColor = System.Drawing.Color.Silver
        Me.lblVersion.Location = New System.Drawing.Point(4, 4)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(92, 13)
        Me.lblVersion.TabIndex = 13
        Me.lblVersion.Text = "L4D Launcher 1.0"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Launcher
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(449, 505)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.picBanner)
        Me.Controls.Add(Me.tabs)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLaunch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Launcher"
        Me.Text = "L4D Launcher"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tabs.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLaunch As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chkVideo As System.Windows.Forms.CheckBox
    Friend WithEvents chkConsole As System.Windows.Forms.CheckBox
    Friend WithEvents tabs As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optNormal As System.Windows.Forms.RadioButton
    Friend WithEvents optImpossible As System.Windows.Forms.RadioButton
    Friend WithEvents optHard As System.Windows.Forms.RadioButton
    Friend WithEvents optEasy As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lstMaps As System.Windows.Forms.ListBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ImageList As System.Windows.Forms.ImageList
    Friend WithEvents chkMultiplayer As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lstNetwork As System.Windows.Forms.ListBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents txtPeer As System.Windows.Forms.TextBox
    Friend WithEvents chkCustomPeer As System.Windows.Forms.CheckBox
    Friend WithEvents pgbNetwork As System.Windows.Forms.ProgressBar
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboGameType As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents txtCommandLine As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chkClipboard As System.Windows.Forms.CheckBox
    Friend WithEvents chkPlayer As System.Windows.Forms.CheckBox
    Friend WithEvents cboPlayer As System.Windows.Forms.ComboBox
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label

End Class