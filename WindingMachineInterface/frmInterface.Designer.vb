<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInterface
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInterface))
        Me.cmd_FullTurn_CW = New System.Windows.Forms.Button()
        Me.cmbCOMPorts = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtXsteps = New System.Windows.Forms.NumericUpDown()
        Me.txtEsteps = New System.Windows.Forms.NumericUpDown()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblCurrentTurn = New System.Windows.Forms.Label()
        Me.Progress = New System.Windows.Forms.ProgressBar()
        Me.txtNTurns = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtWireDia = New System.Windows.Forms.NumericUpDown()
        Me.txtDepth = New System.Windows.Forms.NumericUpDown()
        Me.txtWidth = New System.Windows.Forms.NumericUpDown()
        Me.cmdExecuteCoil = New System.Windows.Forms.Button()
        Me.chkX_Forward = New System.Windows.Forms.CheckBox()
        Me.chkCW_Winds = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmd_HalfTurn_CW = New System.Windows.Forms.Button()
        Me.cmd_QuarterTurn_CW = New System.Windows.Forms.Button()
        Me.cmd_QuarterTurn_CCW = New System.Windows.Forms.Button()
        Me.cmd_HalfTurn_CCW = New System.Windows.Forms.Button()
        Me.cmd_1mmF = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cmdHome = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmd_FullTurn_CCW = New System.Windows.Forms.Button()
        Me.cmd_10mmB = New System.Windows.Forms.Button()
        Me.cmd_1mmB = New System.Windows.Forms.Button()
        Me.cmd_10mm_F = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtXsteps, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEsteps, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtNTurns, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWireDia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDepth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_FullTurn_CW
        '
        Me.cmd_FullTurn_CW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_FullTurn_CW.Location = New System.Drawing.Point(290, 287)
        Me.cmd_FullTurn_CW.Name = "cmd_FullTurn_CW"
        Me.cmd_FullTurn_CW.Size = New System.Drawing.Size(86, 33)
        Me.cmd_FullTurn_CW.TabIndex = 0
        Me.cmd_FullTurn_CW.Text = "1 Turn CW"
        Me.cmd_FullTurn_CW.UseVisualStyleBackColor = True
        '
        'cmbCOMPorts
        '
        Me.cmbCOMPorts.FormattingEnabled = True
        Me.cmbCOMPorts.Location = New System.Drawing.Point(71, 19)
        Me.cmbCOMPorts.Name = "cmbCOMPorts"
        Me.cmbCOMPorts.Size = New System.Drawing.Size(127, 21)
        Me.cmbCOMPorts.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtXsteps)
        Me.GroupBox1.Controls.Add(Me.txtEsteps)
        Me.GroupBox1.Controls.Add(Me.cmdUpdate)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbCOMPorts)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 119)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configuration"
        '
        'txtXsteps
        '
        Me.txtXsteps.Location = New System.Drawing.Point(106, 73)
        Me.txtXsteps.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtXsteps.Name = "txtXsteps"
        Me.txtXsteps.Size = New System.Drawing.Size(92, 20)
        Me.txtXsteps.TabIndex = 24
        Me.txtXsteps.Value = New Decimal(New Integer() {2038, 0, 0, 0})
        '
        'txtEsteps
        '
        Me.txtEsteps.Location = New System.Drawing.Point(106, 47)
        Me.txtEsteps.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtEsteps.Name = "txtEsteps"
        Me.txtEsteps.Size = New System.Drawing.Size(92, 20)
        Me.txtEsteps.TabIndex = 23
        Me.txtEsteps.Value = New Decimal(New Integer() {3200, 0, 0, 0})
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Image = Global.WindingMachineInterface.My.Resources.Resources.recur
        Me.cmdUpdate.Location = New System.Drawing.Point(204, 19)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.Size = New System.Drawing.Size(24, 24)
        Me.cmdUpdate.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.cmdUpdate, "Updates the COM Port List")
        Me.cmdUpdate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 75)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Steps/mm X axis:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Steps/rev E axis:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "COM Port"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblCurrentTurn)
        Me.GroupBox2.Controls.Add(Me.Progress)
        Me.GroupBox2.Controls.Add(Me.txtNTurns)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtWireDia)
        Me.GroupBox2.Controls.Add(Me.txtDepth)
        Me.GroupBox2.Controls.Add(Me.txtWidth)
        Me.GroupBox2.Controls.Add(Me.cmdExecuteCoil)
        Me.GroupBox2.Controls.Add(Me.chkX_Forward)
        Me.GroupBox2.Controls.Add(Me.chkCW_Winds)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.PictureBox1)
        Me.GroupBox2.Location = New System.Drawing.Point(614, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(306, 550)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coil Dimensions [mm]"
        '
        'lblCurrentTurn
        '
        Me.lblCurrentTurn.AutoSize = True
        Me.lblCurrentTurn.Location = New System.Drawing.Point(5, 465)
        Me.lblCurrentTurn.Name = "lblCurrentTurn"
        Me.lblCurrentTurn.Size = New System.Drawing.Size(69, 13)
        Me.lblCurrentTurn.TabIndex = 32
        Me.lblCurrentTurn.Text = "Current Turn:"
        '
        'Progress
        '
        Me.Progress.Location = New System.Drawing.Point(8, 481)
        Me.Progress.Name = "Progress"
        Me.Progress.Size = New System.Drawing.Size(292, 24)
        Me.Progress.TabIndex = 31
        '
        'txtNTurns
        '
        Me.txtNTurns.Enabled = False
        Me.txtNTurns.Location = New System.Drawing.Point(131, 348)
        Me.txtNTurns.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.txtNTurns.Name = "txtNTurns"
        Me.txtNTurns.Size = New System.Drawing.Size(87, 20)
        Me.txtNTurns.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Number of Turns:"
        '
        'txtWireDia
        '
        Me.txtWireDia.DecimalPlaces = 3
        Me.txtWireDia.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.txtWireDia.Location = New System.Drawing.Point(131, 320)
        Me.txtWireDia.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtWireDia.Minimum = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.txtWireDia.Name = "txtWireDia"
        Me.txtWireDia.Size = New System.Drawing.Size(87, 20)
        Me.txtWireDia.TabIndex = 27
        Me.txtWireDia.Value = New Decimal(New Integer() {16, 0, 0, 131072})
        '
        'txtDepth
        '
        Me.txtDepth.DecimalPlaces = 2
        Me.txtDepth.Location = New System.Drawing.Point(6, 121)
        Me.txtDepth.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.txtDepth.Name = "txtDepth"
        Me.txtDepth.Size = New System.Drawing.Size(65, 20)
        Me.txtDepth.TabIndex = 26
        Me.txtDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtDepth.Value = New Decimal(New Integer() {3, 0, 0, 0})
        '
        'txtWidth
        '
        Me.txtWidth.DecimalPlaces = 2
        Me.txtWidth.Location = New System.Drawing.Point(139, 37)
        Me.txtWidth.Maximum = New Decimal(New Integer() {50, 0, 0, 0})
        Me.txtWidth.Name = "txtWidth"
        Me.txtWidth.Size = New System.Drawing.Size(65, 20)
        Me.txtWidth.TabIndex = 25
        Me.txtWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtWidth.Value = New Decimal(New Integer() {6, 0, 0, 0})
        '
        'cmdExecuteCoil
        '
        Me.cmdExecuteCoil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdExecuteCoil.Image = Global.WindingMachineInterface.My.Resources.Resources._1rightarrow
        Me.cmdExecuteCoil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdExecuteCoil.Location = New System.Drawing.Point(175, 511)
        Me.cmdExecuteCoil.Name = "cmdExecuteCoil"
        Me.cmdExecuteCoil.Size = New System.Drawing.Size(125, 33)
        Me.cmdExecuteCoil.TabIndex = 20
        Me.cmdExecuteCoil.Text = "Execute Full Coil"
        Me.cmdExecuteCoil.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdExecuteCoil.UseVisualStyleBackColor = True
        '
        'chkX_Forward
        '
        Me.chkX_Forward.AutoSize = True
        Me.chkX_Forward.Checked = True
        Me.chkX_Forward.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkX_Forward.Location = New System.Drawing.Point(0, 412)
        Me.chkX_Forward.Name = "chkX_Forward"
        Me.chkX_Forward.Size = New System.Drawing.Size(90, 17)
        Me.chkX_Forward.TabIndex = 12
        Me.chkX_Forward.Text = "X forward first"
        Me.ToolTip1.SetToolTip(Me.chkX_Forward, "If checked, winds the first X layer by moving forward")
        Me.chkX_Forward.UseVisualStyleBackColor = True
        '
        'chkCW_Winds
        '
        Me.chkCW_Winds.AutoSize = True
        Me.chkCW_Winds.Checked = True
        Me.chkCW_Winds.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCW_Winds.Location = New System.Drawing.Point(0, 389)
        Me.chkCW_Winds.Name = "chkCW_Winds"
        Me.chkCW_Winds.Size = New System.Drawing.Size(77, 17)
        Me.chkCW_Winds.TabIndex = 11
        Me.chkCW_Winds.Text = "CW Winds"
        Me.ToolTip1.SetToolTip(Me.chkCW_Winds, "If checked, winding will occur clockwise")
        Me.chkCW_Winds.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 322)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Insulated wire dia. [mm]:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(35, 42)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(234, 259)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'cmd_HalfTurn_CW
        '
        Me.cmd_HalfTurn_CW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_HalfTurn_CW.Location = New System.Drawing.Point(382, 287)
        Me.cmd_HalfTurn_CW.Name = "cmd_HalfTurn_CW"
        Me.cmd_HalfTurn_CW.Size = New System.Drawing.Size(96, 33)
        Me.cmd_HalfTurn_CW.TabIndex = 11
        Me.cmd_HalfTurn_CW.Text = "1/2 Turn CW"
        Me.cmd_HalfTurn_CW.UseVisualStyleBackColor = True
        '
        'cmd_QuarterTurn_CW
        '
        Me.cmd_QuarterTurn_CW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_QuarterTurn_CW.Location = New System.Drawing.Point(484, 287)
        Me.cmd_QuarterTurn_CW.Name = "cmd_QuarterTurn_CW"
        Me.cmd_QuarterTurn_CW.Size = New System.Drawing.Size(88, 33)
        Me.cmd_QuarterTurn_CW.TabIndex = 12
        Me.cmd_QuarterTurn_CW.Text = "1/4 Turn CW"
        Me.cmd_QuarterTurn_CW.UseVisualStyleBackColor = True
        '
        'cmd_QuarterTurn_CCW
        '
        Me.cmd_QuarterTurn_CCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_QuarterTurn_CCW.Location = New System.Drawing.Point(484, 11)
        Me.cmd_QuarterTurn_CCW.Name = "cmd_QuarterTurn_CCW"
        Me.cmd_QuarterTurn_CCW.Size = New System.Drawing.Size(88, 33)
        Me.cmd_QuarterTurn_CCW.TabIndex = 16
        Me.cmd_QuarterTurn_CCW.Text = "1/4 Turn CCW"
        Me.cmd_QuarterTurn_CCW.UseVisualStyleBackColor = True
        '
        'cmd_HalfTurn_CCW
        '
        Me.cmd_HalfTurn_CCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_HalfTurn_CCW.Location = New System.Drawing.Point(382, 11)
        Me.cmd_HalfTurn_CCW.Name = "cmd_HalfTurn_CCW"
        Me.cmd_HalfTurn_CCW.Size = New System.Drawing.Size(96, 33)
        Me.cmd_HalfTurn_CCW.TabIndex = 15
        Me.cmd_HalfTurn_CCW.Text = "1/2 Turn CCW"
        Me.cmd_HalfTurn_CCW.UseVisualStyleBackColor = True
        '
        'cmd_1mmF
        '
        Me.cmd_1mmF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_1mmF.Location = New System.Drawing.Point(14, 72)
        Me.cmd_1mmF.Name = "cmd_1mmF"
        Me.cmd_1mmF.Size = New System.Drawing.Size(105, 33)
        Me.cmd_1mmF.TabIndex = 18
        Me.cmd_1mmF.Text = "1 mm Forward"
        Me.cmd_1mmF.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmdHome)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cmd_FullTurn_CCW)
        Me.GroupBox3.Controls.Add(Me.cmd_10mmB)
        Me.GroupBox3.Controls.Add(Me.cmd_1mmB)
        Me.GroupBox3.Controls.Add(Me.cmd_QuarterTurn_CW)
        Me.GroupBox3.Controls.Add(Me.cmd_10mm_F)
        Me.GroupBox3.Controls.Add(Me.cmd_1mmF)
        Me.GroupBox3.Controls.Add(Me.cmd_QuarterTurn_CCW)
        Me.GroupBox3.Controls.Add(Me.cmd_HalfTurn_CCW)
        Me.GroupBox3.Controls.Add(Me.cmd_HalfTurn_CW)
        Me.GroupBox3.Controls.Add(Me.cmd_FullTurn_CW)
        Me.GroupBox3.Controls.Add(Me.PictureBox2)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(586, 425)
        Me.GroupBox3.TabIndex = 19
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manual Controls"
        '
        'cmdHome
        '
        Me.cmdHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmdHome.Image = Global.WindingMachineInterface.My.Resources.Resources.home_food
        Me.cmdHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdHome.Location = New System.Drawing.Point(93, 356)
        Me.cmdHome.Name = "cmdHome"
        Me.cmdHome.Size = New System.Drawing.Size(81, 33)
        Me.cmdHome.TabIndex = 21
        Me.cmdHome.Text = "Home X"
        Me.cmdHome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdHome.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Location = New System.Drawing.Point(103, 108)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Stepper Side"
        '
        'cmd_FullTurn_CCW
        '
        Me.cmd_FullTurn_CCW.BackColor = System.Drawing.Color.Transparent
        Me.cmd_FullTurn_CCW.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_FullTurn_CCW.Location = New System.Drawing.Point(290, 11)
        Me.cmd_FullTurn_CCW.Name = "cmd_FullTurn_CCW"
        Me.cmd_FullTurn_CCW.Size = New System.Drawing.Size(86, 33)
        Me.cmd_FullTurn_CCW.TabIndex = 20
        Me.cmd_FullTurn_CCW.Text = "1 Turn CCW"
        Me.cmd_FullTurn_CCW.UseVisualStyleBackColor = False
        '
        'cmd_10mmB
        '
        Me.cmd_10mmB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_10mmB.Location = New System.Drawing.Point(153, 303)
        Me.cmd_10mmB.Name = "cmd_10mmB"
        Me.cmd_10mmB.Size = New System.Drawing.Size(105, 34)
        Me.cmd_10mmB.TabIndex = 21
        Me.cmd_10mmB.Text = "10 mm Backward"
        Me.cmd_10mmB.UseVisualStyleBackColor = True
        '
        'cmd_1mmB
        '
        Me.cmd_1mmB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_1mmB.Location = New System.Drawing.Point(14, 303)
        Me.cmd_1mmB.Name = "cmd_1mmB"
        Me.cmd_1mmB.Size = New System.Drawing.Size(105, 34)
        Me.cmd_1mmB.TabIndex = 20
        Me.cmd_1mmB.Text = "1 mm Backward"
        Me.cmd_1mmB.UseVisualStyleBackColor = True
        '
        'cmd_10mm_F
        '
        Me.cmd_10mm_F.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_10mm_F.Location = New System.Drawing.Point(153, 72)
        Me.cmd_10mm_F.Name = "cmd_10mm_F"
        Me.cmd_10mm_F.Size = New System.Drawing.Size(105, 33)
        Me.cmd_10mm_F.TabIndex = 19
        Me.cmd_10mm_F.Text = "10 mm Forward"
        Me.cmd_10mm_F.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.WindingMachineInterface.My.Resources.Resources.Coil_Plus_Guide
        Me.PictureBox2.InitialImage = CType(resources.GetObject("PictureBox2.InitialImage"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(38, 46)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(526, 263)
        Me.PictureBox2.TabIndex = 20
        Me.PictureBox2.TabStop = False
        '
        'frmInterface
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 581)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInterface"
        Me.Text = "Coil Winder Interface"
        Me.TransparencyKey = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtXsteps, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEsteps, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtNTurns, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWireDia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDepth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtWidth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmd_FullTurn_CW As Button
    Friend WithEvents cmbCOMPorts As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents cmd_HalfTurn_CW As Button
    Friend WithEvents cmd_QuarterTurn_CW As Button
    Friend WithEvents cmd_QuarterTurn_CCW As Button
    Friend WithEvents cmd_HalfTurn_CCW As Button
    Friend WithEvents cmd_1mmF As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cmd_10mm_F As Button
    Friend WithEvents cmd_10mmB As Button
    Friend WithEvents cmd_1mmB As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents cmdUpdate As Button
    Friend WithEvents cmd_FullTurn_CCW As Button
    Friend WithEvents chkX_Forward As CheckBox
    Friend WithEvents chkCW_Winds As CheckBox
    Friend WithEvents cmdExecuteCoil As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtEsteps As NumericUpDown
    Friend WithEvents txtXsteps As NumericUpDown
    Friend WithEvents txtWireDia As NumericUpDown
    Friend WithEvents txtDepth As NumericUpDown
    Friend WithEvents txtWidth As NumericUpDown
    Friend WithEvents txtNTurns As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents lblCurrentTurn As Label
    Friend WithEvents Progress As ProgressBar
    Friend WithEvents cmdHome As Button
End Class
