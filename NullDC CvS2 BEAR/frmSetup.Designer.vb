﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetup
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_Volume = New System.Windows.Forms.TrackBar()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbAllowSpectators = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.tbPort = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSaveExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPlayerName = New System.Windows.Forms.TextBox()
        Me.cbShowConsole = New System.Windows.Forms.CheckBox()
        Me.tb_eVolume = New System.Windows.Forms.TrackBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbCWWidth = New System.Windows.Forms.TextBox()
        Me.tbCWHeight = New System.Windows.Forms.TextBox()
        Me.GBCustomWindowSize = New System.Windows.Forms.GroupBox()
        Me.CustomSizeContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.tbCWY = New System.Windows.Forms.TextBox()
        Me.tbCWX = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbUseCustomWindowSize = New System.Windows.Forms.CheckBox()
        Me.cbOverlay = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cb_ShowGameInTitle = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbVsync = New System.Windows.Forms.ComboBox()
        Me.OptionsContainer = New System.Windows.Forms.TableLayoutPanel()
        Me.cbThemes = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbP2Name = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cb_nullDCPriority = New System.Windows.Forms.ComboBox()
        Me.cb_MinimizeToTray = New System.Windows.Forms.CheckBox()
        Me.cb_mono = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tb_eVolume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GBCustomWindowSize.SuspendLayout()
        Me.CustomSizeContainer.SuspendLayout()
        Me.OptionsContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.NullDC_CvS2_BEAR.My.Resources.Resources.Clippy
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.InitialImage = Global.NullDC_CvS2_BEAR.My.Resources.Resources.Clippy
        Me.PictureBox1.Location = New System.Drawing.Point(450, 106)
        Me.PictureBox1.Name = "PictureBox1"
        Me.OptionsContainer.SetRowSpan(Me.PictureBox1, 4)
        Me.PictureBox1.Size = New System.Drawing.Size(140, 135)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(57, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "BEAR"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tb_Volume
        '
        Me.tb_Volume.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_Volume.Location = New System.Drawing.Point(57, 16)
        Me.tb_Volume.Maximum = 100
        Me.tb_Volume.Name = "tb_Volume"
        Me.tb_Volume.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tb_Volume.Size = New System.Drawing.Size(45, 146)
        Me.tb_Volume.TabIndex = 12
        Me.tb_Volume.TabStop = False
        Me.tb_Volume.TickFrequency = 10
        Me.tb_Volume.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(173, 90)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Allow Spectators"
        '
        'cbAllowSpectators
        '
        Me.cbAllowSpectators.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAllowSpectators.FormattingEnabled = True
        Me.cbAllowSpectators.Items.AddRange(New Object() {"Yes", "No"})
        Me.cbAllowSpectators.Location = New System.Drawing.Point(173, 106)
        Me.cbAllowSpectators.Name = "cbAllowSpectators"
        Me.cbAllowSpectators.Size = New System.Drawing.Size(97, 21)
        Me.cbAllowSpectators.TabIndex = 9
        Me.cbAllowSpectators.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Lime
        Me.OptionsContainer.SetColumnSpan(Me.Button2, 2)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Location = New System.Drawing.Point(13, 247)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(257, 54)
        Me.Button2.TabIndex = 7
        Me.Button2.TabStop = False
        Me.Button2.Text = "CLICK ME" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Add Windows Firewall Entry for BEAR" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = False
        '
        'tbPort
        '
        Me.tbPort.Location = New System.Drawing.Point(333, 26)
        Me.tbPort.Name = "tbPort"
        Me.tbPort.Size = New System.Drawing.Size(97, 20)
        Me.tbPort.TabIndex = 6
        Me.tbPort.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(333, 10)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "NullDC Port"
        '
        'btnSaveExit
        '
        Me.btnSaveExit.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSaveExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSaveExit.Location = New System.Drawing.Point(450, 409)
        Me.btnSaveExit.Name = "btnSaveExit"
        Me.btnSaveExit.Size = New System.Drawing.Size(144, 51)
        Me.btnSaveExit.TabIndex = 4
        Me.btnSaveExit.TabStop = False
        Me.btnSaveExit.Text = "Save"
        Me.btnSaveExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "What's your name?"
        '
        'tbPlayerName
        '
        Me.tbPlayerName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbPlayerName.Location = New System.Drawing.Point(13, 26)
        Me.tbPlayerName.Name = "tbPlayerName"
        Me.tbPlayerName.Size = New System.Drawing.Size(154, 20)
        Me.tbPlayerName.TabIndex = 0
        Me.tbPlayerName.TabStop = False
        '
        'cbShowConsole
        '
        Me.cbShowConsole.AutoSize = True
        Me.cbShowConsole.Location = New System.Drawing.Point(13, 156)
        Me.cbShowConsole.Name = "cbShowConsole"
        Me.cbShowConsole.Size = New System.Drawing.Size(130, 17)
        Me.cbShowConsole.TabIndex = 14
        Me.cbShowConsole.Text = "Show NullDC Console"
        Me.cbShowConsole.UseVisualStyleBackColor = True
        '
        'tb_eVolume
        '
        Me.tb_eVolume.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tb_eVolume.Location = New System.Drawing.Point(3, 16)
        Me.tb_eVolume.Maximum = 100
        Me.tb_eVolume.Name = "tb_eVolume"
        Me.tb_eVolume.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.tb_eVolume.Size = New System.Drawing.Size(48, 146)
        Me.tb_eVolume.TabIndex = 15
        Me.tb_eVolume.TabStop = False
        Me.tb_eVolume.TickFrequency = 10
        Me.tb_eVolume.TickStyle = System.Windows.Forms.TickStyle.Both
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Emulator"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(333, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.OptionsContainer.SetRowSpan(Me.GroupBox1, 9)
        Me.GroupBox1.Size = New System.Drawing.Size(111, 184)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Volume"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.tb_Volume, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tb_eVolume, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(105, 165)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tbCWWidth
        '
        Me.tbCWWidth.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbCWWidth.Location = New System.Drawing.Point(157, 29)
        Me.tbCWWidth.Name = "tbCWWidth"
        Me.tbCWWidth.Size = New System.Drawing.Size(148, 20)
        Me.tbCWWidth.TabIndex = 18
        Me.tbCWWidth.Text = "656"
        '
        'tbCWHeight
        '
        Me.tbCWHeight.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbCWHeight.Location = New System.Drawing.Point(157, 3)
        Me.tbCWHeight.Name = "tbCWHeight"
        Me.tbCWHeight.Size = New System.Drawing.Size(148, 20)
        Me.tbCWHeight.TabIndex = 19
        Me.tbCWHeight.Text = "538"
        '
        'GBCustomWindowSize
        '
        Me.GBCustomWindowSize.AutoSize = True
        Me.GBCustomWindowSize.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.OptionsContainer.SetColumnSpan(Me.GBCustomWindowSize, 2)
        Me.GBCustomWindowSize.Controls.Add(Me.CustomSizeContainer)
        Me.GBCustomWindowSize.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GBCustomWindowSize.Location = New System.Drawing.Point(13, 307)
        Me.GBCustomWindowSize.Name = "GBCustomWindowSize"
        Me.GBCustomWindowSize.Size = New System.Drawing.Size(314, 153)
        Me.GBCustomWindowSize.TabIndex = 20
        Me.GBCustomWindowSize.TabStop = False
        Me.GBCustomWindowSize.Text = "Custom Window Size"
        '
        'CustomSizeContainer
        '
        Me.CustomSizeContainer.AutoSize = True
        Me.CustomSizeContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CustomSizeContainer.ColumnCount = 2
        Me.CustomSizeContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.CustomSizeContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.CustomSizeContainer.Controls.Add(Me.Button4, 0, 4)
        Me.CustomSizeContainer.Controls.Add(Me.tbCWY, 1, 3)
        Me.CustomSizeContainer.Controls.Add(Me.tbCWX, 1, 2)
        Me.CustomSizeContainer.Controls.Add(Me.Label9, 0, 3)
        Me.CustomSizeContainer.Controls.Add(Me.Label7, 0, 2)
        Me.CustomSizeContainer.Controls.Add(Me.Label5, 0, 1)
        Me.CustomSizeContainer.Controls.Add(Me.Label4, 0, 0)
        Me.CustomSizeContainer.Controls.Add(Me.tbCWWidth, 1, 1)
        Me.CustomSizeContainer.Controls.Add(Me.tbCWHeight, 1, 0)
        Me.CustomSizeContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CustomSizeContainer.Location = New System.Drawing.Point(3, 16)
        Me.CustomSizeContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.CustomSizeContainer.Name = "CustomSizeContainer"
        Me.CustomSizeContainer.RowCount = 5
        Me.CustomSizeContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.CustomSizeContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.CustomSizeContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.CustomSizeContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.CustomSizeContainer.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.CustomSizeContainer.Size = New System.Drawing.Size(308, 134)
        Me.CustomSizeContainer.TabIndex = 21
        '
        'Button4
        '
        Me.Button4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Location = New System.Drawing.Point(0, 104)
        Me.Button4.Margin = New System.Windows.Forms.Padding(0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(154, 30)
        Me.Button4.TabIndex = 23
        Me.Button4.Text = "Default"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'tbCWY
        '
        Me.tbCWY.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbCWY.Location = New System.Drawing.Point(157, 81)
        Me.tbCWY.Name = "tbCWY"
        Me.tbCWY.Size = New System.Drawing.Size(148, 20)
        Me.tbCWY.TabIndex = 25
        Me.tbCWY.Text = "250"
        '
        'tbCWX
        '
        Me.tbCWX.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbCWX.Location = New System.Drawing.Point(157, 55)
        Me.tbCWX.Name = "tbCWX"
        Me.tbCWX.Size = New System.Drawing.Size(148, 20)
        Me.tbCWX.TabIndex = 24
        Me.tbCWX.Text = "250"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label9.Location = New System.Drawing.Point(3, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(148, 26)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Screen Y"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(3, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 26)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Screen X"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(3, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 26)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Width"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 26)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Height"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'cbUseCustomWindowSize
        '
        Me.cbUseCustomWindowSize.AutoSize = True
        Me.cbUseCustomWindowSize.Location = New System.Drawing.Point(13, 179)
        Me.cbUseCustomWindowSize.Name = "cbUseCustomWindowSize"
        Me.cbUseCustomWindowSize.Size = New System.Drawing.Size(154, 17)
        Me.cbUseCustomWindowSize.TabIndex = 22
        Me.cbUseCustomWindowSize.Text = "Use Custom Window Size?"
        Me.cbUseCustomWindowSize.UseVisualStyleBackColor = True
        '
        'cbOverlay
        '
        Me.cbOverlay.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbOverlay.FormattingEnabled = True
        Me.cbOverlay.Items.AddRange(New Object() {"Off", "Top Full", "Top Minimal", "Bottom Full", "Bottom Minimal"})
        Me.cbOverlay.Location = New System.Drawing.Point(13, 106)
        Me.cbOverlay.Name = "cbOverlay"
        Me.cbOverlay.Size = New System.Drawing.Size(154, 21)
        Me.cbOverlay.TabIndex = 23
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 13)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "NullDC Priority"
        '
        'cb_ShowGameInTitle
        '
        Me.cb_ShowGameInTitle.AutoSize = True
        Me.cb_ShowGameInTitle.Location = New System.Drawing.Point(13, 133)
        Me.cb_ShowGameInTitle.Name = "cb_ShowGameInTitle"
        Me.cb_ShowGameInTitle.Size = New System.Drawing.Size(134, 17)
        Me.cb_ShowGameInTitle.TabIndex = 25
        Me.cb_ShowGameInTitle.Text = "Show Game In Titlebar"
        Me.cb_ShowGameInTitle.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(173, 50)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(36, 13)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Vsync"
        '
        'cbVsync
        '
        Me.cbVsync.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbVsync.FormattingEnabled = True
        Me.cbVsync.Items.AddRange(New Object() {"Off", "On"})
        Me.cbVsync.Location = New System.Drawing.Point(173, 66)
        Me.cbVsync.Name = "cbVsync"
        Me.cbVsync.Size = New System.Drawing.Size(97, 21)
        Me.cbVsync.TabIndex = 27
        '
        'OptionsContainer
        '
        Me.OptionsContainer.AutoSize = True
        Me.OptionsContainer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.OptionsContainer.ColumnCount = 5
        Me.OptionsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OptionsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OptionsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OptionsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.OptionsContainer.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.OptionsContainer.Controls.Add(Me.Label2, 0, 0)
        Me.OptionsContainer.Controls.Add(Me.PictureBox1, 4, 5)
        Me.OptionsContainer.Controls.Add(Me.GBCustomWindowSize, 0, 10)
        Me.OptionsContainer.Controls.Add(Me.cb_ShowGameInTitle, 0, 6)
        Me.OptionsContainer.Controls.Add(Me.cbUseCustomWindowSize, 0, 8)
        Me.OptionsContainer.Controls.Add(Me.Button2, 0, 9)
        Me.OptionsContainer.Controls.Add(Me.cbShowConsole, 0, 7)
        Me.OptionsContainer.Controls.Add(Me.tbPlayerName, 0, 1)
        Me.OptionsContainer.Controls.Add(Me.GroupBox1, 3, 2)
        Me.OptionsContainer.Controls.Add(Me.cbOverlay, 0, 5)
        Me.OptionsContainer.Controls.Add(Me.cbThemes, 4, 1)
        Me.OptionsContainer.Controls.Add(Me.Label12, 4, 0)
        Me.OptionsContainer.Controls.Add(Me.btnSaveExit, 4, 10)
        Me.OptionsContainer.Controls.Add(Me.Label6, 3, 0)
        Me.OptionsContainer.Controls.Add(Me.tbPort, 3, 1)
        Me.OptionsContainer.Controls.Add(Me.tbP2Name, 1, 1)
        Me.OptionsContainer.Controls.Add(Me.Label13, 1, 0)
        Me.OptionsContainer.Controls.Add(Me.Label14, 0, 4)
        Me.OptionsContainer.Controls.Add(Me.Label11, 1, 2)
        Me.OptionsContainer.Controls.Add(Me.cbVsync, 1, 3)
        Me.OptionsContainer.Controls.Add(Me.Label10, 0, 2)
        Me.OptionsContainer.Controls.Add(Me.cb_nullDCPriority, 0, 3)
        Me.OptionsContainer.Controls.Add(Me.Label8, 1, 4)
        Me.OptionsContainer.Controls.Add(Me.cbAllowSpectators, 1, 5)
        Me.OptionsContainer.Controls.Add(Me.cb_MinimizeToTray, 1, 6)
        Me.OptionsContainer.Controls.Add(Me.cb_mono, 1, 7)
        Me.OptionsContainer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.OptionsContainer.Location = New System.Drawing.Point(0, 0)
        Me.OptionsContainer.Name = "OptionsContainer"
        Me.OptionsContainer.Padding = New System.Windows.Forms.Padding(10)
        Me.OptionsContainer.RowCount = 11
        Me.OptionsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OptionsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OptionsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OptionsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OptionsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OptionsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OptionsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OptionsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OptionsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OptionsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OptionsContainer.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.OptionsContainer.Size = New System.Drawing.Size(607, 472)
        Me.OptionsContainer.TabIndex = 28
        '
        'cbThemes
        '
        Me.cbThemes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbThemes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbThemes.FormattingEnabled = True
        Me.cbThemes.Location = New System.Drawing.Point(450, 26)
        Me.cbThemes.Name = "cbThemes"
        Me.cbThemes.Size = New System.Drawing.Size(144, 21)
        Me.cbThemes.TabIndex = 28
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(450, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Theme"
        '
        'tbP2Name
        '
        Me.tbP2Name.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbP2Name.Location = New System.Drawing.Point(173, 26)
        Me.tbP2Name.Name = "tbP2Name"
        Me.tbP2Name.Size = New System.Drawing.Size(154, 20)
        Me.tbP2Name.TabIndex = 30
        Me.tbP2Name.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(173, 10)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(109, 13)
        Me.Label13.TabIndex = 31
        Me.Label13.Text = "Player 2 Offline Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 90)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(69, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Overlay Style"
        '
        'cb_nullDCPriority
        '
        Me.cb_nullDCPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cb_nullDCPriority.FormattingEnabled = True
        Me.cb_nullDCPriority.Items.AddRange(New Object() {"Normal", "Above Normal", "High", "Realtime"})
        Me.cb_nullDCPriority.Location = New System.Drawing.Point(13, 66)
        Me.cb_nullDCPriority.Name = "cb_nullDCPriority"
        Me.cb_nullDCPriority.Size = New System.Drawing.Size(154, 21)
        Me.cb_nullDCPriority.TabIndex = 33
        '
        'cb_MinimizeToTray
        '
        Me.cb_MinimizeToTray.AutoSize = True
        Me.cb_MinimizeToTray.Location = New System.Drawing.Point(173, 133)
        Me.cb_MinimizeToTray.Name = "cb_MinimizeToTray"
        Me.cb_MinimizeToTray.Size = New System.Drawing.Size(102, 17)
        Me.cb_MinimizeToTray.TabIndex = 34
        Me.cb_MinimizeToTray.Text = "Minimize to Tray"
        Me.cb_MinimizeToTray.UseVisualStyleBackColor = True
        '
        'cb_mono
        '
        Me.cb_mono.AutoSize = True
        Me.cb_mono.Location = New System.Drawing.Point(173, 156)
        Me.cb_mono.Name = "cb_mono"
        Me.cb_mono.Size = New System.Drawing.Size(119, 17)
        Me.cb_mono.TabIndex = 35
        Me.cb_mono.Text = "Force MONO Audio"
        Me.cb_mono.UseVisualStyleBackColor = True
        '
        'frmSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(607, 472)
        Me.Controls.Add(Me.OptionsContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "frmSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BEAR Setup"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_Volume, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tb_eVolume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.GBCustomWindowSize.ResumeLayout(False)
        Me.GBCustomWindowSize.PerformLayout()
        Me.CustomSizeContainer.ResumeLayout(False)
        Me.CustomSizeContainer.PerformLayout()
        Me.OptionsContainer.ResumeLayout(False)
        Me.OptionsContainer.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPlayerName As TextBox
    Friend WithEvents btnSaveExit As Button
    Friend WithEvents tbPort As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cbAllowSpectators As ComboBox
    Friend WithEvents tb_Volume As TrackBar
    Friend WithEvents Label3 As Label
    Friend WithEvents cbShowConsole As CheckBox
    Friend WithEvents tb_eVolume As TrackBar
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tbCWWidth As TextBox
    Friend WithEvents tbCWHeight As TextBox
    Friend WithEvents GBCustomWindowSize As GroupBox
    Friend WithEvents CustomSizeContainer As TableLayoutPanel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cbUseCustomWindowSize As CheckBox
    Friend WithEvents tbCWY As TextBox
    Friend WithEvents tbCWX As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents cbOverlay As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cb_ShowGameInTitle As CheckBox
    Friend WithEvents Label11 As Label
    Friend WithEvents cbVsync As ComboBox
    Friend WithEvents OptionsContainer As TableLayoutPanel
    Friend WithEvents cbThemes As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents tbP2Name As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents cb_nullDCPriority As ComboBox
    Friend WithEvents cb_MinimizeToTray As CheckBox
    Friend WithEvents cb_mono As CheckBox
End Class
