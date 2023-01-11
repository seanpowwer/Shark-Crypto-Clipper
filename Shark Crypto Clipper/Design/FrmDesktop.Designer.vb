<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDesktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDesktop))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Button2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.ToolStripStatusLabel4 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ToolStripStatusLabel3 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.ToolStripStatusLabel2 = New Guna.UI2.WinForms.Guna2CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.label15 = New System.Windows.Forms.Label()
        Me.pictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.ErrorImage = Nothing
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(0, 112)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(827, 388)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 300
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.ToolStripStatusLabel4)
        Me.Panel1.Controls.Add(Me.ToolStripStatusLabel3)
        Me.Panel1.Controls.Add(Me.ToolStripStatusLabel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(827, 63)
        Me.Panel1.TabIndex = 8
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.Transparent
        Me.ComboBox1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ComboBox1.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.ComboBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.ComboBox1.ItemHeight = 20
        Me.ComboBox1.Items.AddRange(New Object() {"10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%", "100%", "200%"})
        Me.ComboBox1.Location = New System.Drawing.Point(347, 15)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(78, 26)
        Me.ComboBox1.TabIndex = 160
        '
        'Button2
        '
        Me.Button2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.BorderRadius = 4
        Me.Button2.BorderThickness = 1
        Me.Button2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Button2.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button2.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical
        Me.Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Button2.HoverState.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button2.HoverState.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button2.HoverState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.Button2.Location = New System.Drawing.Point(22, 17)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(101, 29)
        Me.Button2.TabIndex = 159
        Me.Button2.Text = "Stop"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.AutoSize = True
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ToolStripStatusLabel4.CheckedState.BorderRadius = 0
        Me.ToolStripStatusLabel4.CheckedState.BorderThickness = 1
        Me.ToolStripStatusLabel4.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ToolStripStatusLabel4.CheckMarkColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ToolStripStatusLabel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripStatusLabel4.Location = New System.Drawing.Point(217, 10)
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(51, 17)
        Me.ToolStripStatusLabel4.TabIndex = 127
        Me.ToolStripStatusLabel4.Text = "Save"
        Me.ToolStripStatusLabel4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ToolStripStatusLabel4.UncheckedState.BorderRadius = 0
        Me.ToolStripStatusLabel4.UncheckedState.BorderThickness = 1
        Me.ToolStripStatusLabel4.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ToolStripStatusLabel4.UseVisualStyleBackColor = False
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.AutoSize = True
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ToolStripStatusLabel3.CheckedState.BorderRadius = 0
        Me.ToolStripStatusLabel3.CheckedState.BorderThickness = 1
        Me.ToolStripStatusLabel3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ToolStripStatusLabel3.CheckMarkColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ToolStripStatusLabel3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripStatusLabel3.Location = New System.Drawing.Point(153, 33)
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(115, 17)
        Me.ToolStripStatusLabel3.TabIndex = 126
        Me.ToolStripStatusLabel3.Text = "Keyboard tracking "
        Me.ToolStripStatusLabel3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ToolStripStatusLabel3.UncheckedState.BorderRadius = 0
        Me.ToolStripStatusLabel3.UncheckedState.BorderThickness = 1
        Me.ToolStripStatusLabel3.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ToolStripStatusLabel3.UseVisualStyleBackColor = False
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.AutoSize = True
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.Transparent
        Me.ToolStripStatusLabel2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ToolStripStatusLabel2.CheckedState.BorderRadius = 0
        Me.ToolStripStatusLabel2.CheckedState.BorderThickness = 1
        Me.ToolStripStatusLabel2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ToolStripStatusLabel2.CheckMarkColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.ToolStripStatusLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.ToolStripStatusLabel2.Location = New System.Drawing.Point(153, 10)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(58, 17)
        Me.ToolStripStatusLabel2.TabIndex = 125
        Me.ToolStripStatusLabel2.Text = "Mouse"
        Me.ToolStripStatusLabel2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.ToolStripStatusLabel2.UncheckedState.BorderRadius = 0
        Me.ToolStripStatusLabel2.UncheckedState.BorderThickness = 1
        Me.ToolStripStatusLabel2.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ToolStripStatusLabel2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.LightGray
        Me.Label1.Location = New System.Drawing.Point(308, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Size :"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.LightGray
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(14, 17)
        Me.ToolStripStatusLabel1.Text = ".."
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 500)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(827, 22)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'guna2BorderlessForm1
        '
        Me.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.G2402080114300C350C1C0D2412390C1404.G243B3E2E39012726
        Me.guna2BorderlessForm1.ContainerControl = Me
        Me.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.guna2BorderlessForm1.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(193, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.pictureBox2)
        Me.Guna2Panel2.Controls.Add(Me.guna2ControlBox3)
        Me.Guna2Panel2.Controls.Add(Me.guna2ControlBox1)
        Me.Guna2Panel2.Controls.Add(Me.label15)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(827, 49)
        Me.Guna2Panel2.TabIndex = 138
        '
        'guna2ControlBox3
        '
        Me.guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.guna2ControlBox3.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.guna2ControlBox3.Location = New System.Drawing.Point(719, 6)
        Me.guna2ControlBox3.Name = "guna2ControlBox3"
        Me.guna2ControlBox3.Size = New System.Drawing.Size(45, 31)
        Me.guna2ControlBox3.TabIndex = 166
        '
        'guna2ControlBox1
        '
        Me.guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.guna2ControlBox1.Location = New System.Drawing.Point(770, 6)
        Me.guna2ControlBox1.Name = "guna2ControlBox1"
        Me.guna2ControlBox1.Size = New System.Drawing.Size(45, 31)
        Me.guna2ControlBox1.TabIndex = 165
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.ForeColor = System.Drawing.Color.White
        Me.label15.Location = New System.Drawing.Point(49, 13)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(144, 20)
        Me.label15.TabIndex = 11
        Me.label15.Text = "Remote Desktop"
        '
        'pictureBox2
        '
        Me.pictureBox2.Image = CType(resources.GetObject("pictureBox2.Image"), System.Drawing.Image)
        Me.pictureBox2.Location = New System.Drawing.Point(3, 3)
        Me.pictureBox2.Name = "pictureBox2"
        Me.pictureBox2.Size = New System.Drawing.Size(40, 42)
        Me.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictureBox2.TabIndex = 167
        Me.pictureBox2.TabStop = False
        '
        'FrmDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(827, 522)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(707, 446)
        Me.Name = "FrmDesktop"
        Me.ShowIcon = False
        Me.Text = "Desktop"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        CType(Me.pictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Private WithEvents guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Private WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Private WithEvents guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Private WithEvents label15 As Label
    Public WithEvents ToolStripStatusLabel2 As Guna.UI2.WinForms.Guna2CheckBox
    Public WithEvents ToolStripStatusLabel3 As Guna.UI2.WinForms.Guna2CheckBox
    Public WithEvents ToolStripStatusLabel4 As Guna.UI2.WinForms.Guna2CheckBox
    Public WithEvents Button2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents ComboBox1 As Guna.UI2.WinForms.Guna2ComboBox
    Private WithEvents pictureBox2 As PictureBox
End Class
