<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeSerialNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2CustomGradientPanel2 = New Guna.UI2.WinForms.Guna2CustomGradientPanel()
        Me.txtReading = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btnGo = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblfooter2 = New System.Windows.Forms.Label()
        Me.lblfooter1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2CustomGradientPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SerialPort1
        '
        Me.SerialPort1.BaudRate = 115200
        Me.SerialPort1.Parity = System.IO.Ports.Parity.Even
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeSerialNameToolStripMenuItem})
        Me.SettingsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ChangeSerialNameToolStripMenuItem
        '
        Me.ChangeSerialNameToolStripMenuItem.Image = CType(resources.GetObject("ChangeSerialNameToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ChangeSerialNameToolStripMenuItem.Name = "ChangeSerialNameToolStripMenuItem"
        Me.ChangeSerialNameToolStripMenuItem.Size = New System.Drawing.Size(179, 22)
        Me.ChangeSerialNameToolStripMenuItem.Text = "Change Serial name"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(417, 24)
        Me.MenuStrip1.TabIndex = 53
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(74, 57)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 3
        Me.PictureBox2.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(88, 15)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(309, 34)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Wire Diameter Automation"
        '
        'Guna2CustomGradientPanel2
        '
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.PictureBox2)
        Me.Guna2CustomGradientPanel2.Controls.Add(Me.Label4)
        Me.Guna2CustomGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2CustomGradientPanel2.FillColor = System.Drawing.Color.LimeGreen
        Me.Guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.LimeGreen
        Me.Guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.DarkGreen
        Me.Guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.DarkGreen
        Me.Guna2CustomGradientPanel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2CustomGradientPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Guna2CustomGradientPanel2.Name = "Guna2CustomGradientPanel2"
        Me.Guna2CustomGradientPanel2.Size = New System.Drawing.Size(417, 68)
        Me.Guna2CustomGradientPanel2.TabIndex = 50
        '
        'txtReading
        '
        Me.txtReading.BackColor = System.Drawing.Color.Transparent
        Me.txtReading.BorderColor = System.Drawing.Color.Black
        Me.txtReading.BorderRadius = 20
        Me.txtReading.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtReading.DefaultText = ""
        Me.txtReading.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtReading.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtReading.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReading.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtReading.FillColor = System.Drawing.Color.Black
        Me.txtReading.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReading.Font = New System.Drawing.Font("Lucida Fax", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReading.ForeColor = System.Drawing.Color.Lime
        Me.txtReading.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtReading.Location = New System.Drawing.Point(53, 130)
        Me.txtReading.Margin = New System.Windows.Forms.Padding(3, 6, 3, 6)
        Me.txtReading.Name = "txtReading"
        Me.txtReading.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtReading.PlaceholderText = ""
        Me.txtReading.ReadOnly = True
        Me.txtReading.SelectedText = ""
        Me.txtReading.ShadowDecoration.BorderRadius = 30
        Me.txtReading.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtReading.ShadowDecoration.Enabled = True
        Me.txtReading.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(0, 0, 10, 10)
        Me.txtReading.Size = New System.Drawing.Size(316, 71)
        Me.txtReading.TabIndex = 42
        Me.txtReading.TabStop = False
        Me.txtReading.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.Transparent
        Me.btnGo.BorderColor = System.Drawing.Color.RoyalBlue
        Me.btnGo.BorderRadius = 18
        Me.btnGo.BorderThickness = 3
        Me.btnGo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGo.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.btnGo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.btnGo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.btnGo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.btnGo.FillColor = System.Drawing.Color.White
        Me.btnGo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGo.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGo.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGo.HoverState.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGo.HoverState.ForeColor = System.Drawing.Color.White
        Me.btnGo.ImageSize = New System.Drawing.Size(30, 30)
        Me.btnGo.Location = New System.Drawing.Point(150, 239)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.ShadowDecoration.BorderRadius = 18
        Me.btnGo.ShadowDecoration.Color = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGo.ShadowDecoration.Depth = 20
        Me.btnGo.ShadowDecoration.Enabled = True
        Me.btnGo.ShadowDecoration.Shadow = New System.Windows.Forms.Padding(8)
        Me.btnGo.Size = New System.Drawing.Size(110, 39)
        Me.btnGo.TabIndex = 43
        Me.btnGo.Text = "to Excel"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblfooter2)
        Me.Panel1.Controls.Add(Me.lblfooter1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Guna2CustomGradientPanel2)
        Me.Panel1.Controls.Add(Me.txtReading)
        Me.Panel1.Controls.Add(Me.btnGo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(417, 346)
        Me.Panel1.TabIndex = 54
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(32, 74)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 62
        Me.TextBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(164, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 37)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Result"
        '
        'lblfooter2
        '
        Me.lblfooter2.AutoSize = True
        Me.lblfooter2.BackColor = System.Drawing.Color.Transparent
        Me.lblfooter2.Font = New System.Drawing.Font("Nirmala UI", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfooter2.ForeColor = System.Drawing.Color.Black
        Me.lblfooter2.Location = New System.Drawing.Point(9, 319)
        Me.lblfooter2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfooter2.Name = "lblfooter2"
        Me.lblfooter2.Size = New System.Drawing.Size(108, 12)
        Me.lblfooter2.TabIndex = 66
        Me.lblfooter2.Text = "© LF Philipines - TSG 2024"
        '
        'lblfooter1
        '
        Me.lblfooter1.AutoSize = True
        Me.lblfooter1.BackColor = System.Drawing.Color.Transparent
        Me.lblfooter1.Font = New System.Drawing.Font("Nirmala UI", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfooter1.ForeColor = System.Drawing.Color.Black
        Me.lblfooter1.Location = New System.Drawing.Point(11, 308)
        Me.lblfooter1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfooter1.Name = "lblfooter1"
        Me.lblfooter1.Size = New System.Drawing.Size(133, 12)
        Me.lblfooter1.TabIndex = 65
        Me.lblfooter1.Text = "LITTELFUSE PHILIPPINES INC." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 370)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2CustomGradientPanel2.ResumeLayout(False)
        Me.Guna2CustomGradientPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeSerialNameToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2CustomGradientPanel2 As Guna.UI2.WinForms.Guna2CustomGradientPanel
    Friend WithEvents txtReading As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btnGo As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblfooter2 As Label
    Friend WithEvents lblfooter1 As Label
End Class
