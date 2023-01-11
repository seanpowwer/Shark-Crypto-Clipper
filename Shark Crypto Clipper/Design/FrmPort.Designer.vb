<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPort
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPort))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.TextBox2 = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Button2 = New Guna.UI2.WinForms.Guna2GradientButton()
        Me.TextBox1 = New Guna.UI2.WinForms.Guna2NumericUpDown()
        Me.guna2PictureBox2 = New Guna.UI2.WinForms.Guna2PictureBox()
        Me.guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.guna2PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label1.Location = New System.Drawing.Point(33, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Port "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.Label2.ForeColor = System.Drawing.Color.DeepSkyBlue
        Me.Label2.Location = New System.Drawing.Point(33, 209)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'guna2BorderlessForm1
        '
        Me.guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.G2402080114300C350C1C0D2412390C1404.G243B3E2E39012726
        Me.guna2BorderlessForm1.ContainerControl = Me
        Me.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'TextBox2
        '
        Me.TextBox2.Animated = True
        Me.TextBox2.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.TextBox2.BorderRadius = 4
        Me.TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox2.DefaultText = ""
        Me.TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextBox2.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextBox2.Location = New System.Drawing.Point(36, 238)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextBox2.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TextBox2.PlaceholderText = ""
        Me.TextBox2.SelectedText = ""
        Me.TextBox2.Size = New System.Drawing.Size(228, 36)
        Me.TextBox2.TabIndex = 16
        '
        'Button2
        '
        Me.Button2.Animated = True
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
        Me.Button2.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.Button2.HoverState.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Button2.HoverState.ForeColor = System.Drawing.Color.LightGray
        Me.Button2.Location = New System.Drawing.Point(12, 303)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(293, 49)
        Me.Button2.TabIndex = 163
        Me.Button2.Text = "Go !"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Transparent
        Me.TextBox1.BorderColor = System.Drawing.Color.DeepSkyBlue
        Me.TextBox1.BorderRadius = 4
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TextBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.TextBox1.Location = New System.Drawing.Point(36, 146)
        Me.TextBox1.Maximum = New Decimal(New Integer() {99999999, 0, 0, 0})
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(228, 36)
        Me.TextBox1.TabIndex = 165
        Me.TextBox1.UpDownButtonFillColor = System.Drawing.Color.DeepSkyBlue
        '
        'guna2PictureBox2
        '
        Me.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.guna2PictureBox2.Image = CType(resources.GetObject("guna2PictureBox2.Image"), System.Drawing.Image)
        Me.guna2PictureBox2.ImageRotate = 0!
        Me.guna2PictureBox2.Location = New System.Drawing.Point(105, 12)
        Me.guna2PictureBox2.Name = "guna2PictureBox2"
        Me.guna2PictureBox2.Size = New System.Drawing.Size(89, 82)
        Me.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.guna2PictureBox2.TabIndex = 168
        Me.guna2PictureBox2.TabStop = False
        Me.guna2PictureBox2.UseTransparentBackground = True
        '
        'guna2ControlBox3
        '
        Me.guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.guna2ControlBox3.FillColor = System.Drawing.Color.Transparent
        Me.guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.guna2ControlBox3.Location = New System.Drawing.Point(238, 4)
        Me.guna2ControlBox3.Name = "guna2ControlBox3"
        Me.guna2ControlBox3.Size = New System.Drawing.Size(34, 26)
        Me.guna2ControlBox3.TabIndex = 171
        '
        'guna2ControlBox1
        '
        Me.guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.guna2ControlBox1.IconColor = System.Drawing.Color.White
        Me.guna2ControlBox1.Location = New System.Drawing.Point(278, 4)
        Me.guna2ControlBox1.Name = "guna2ControlBox1"
        Me.guna2ControlBox1.Size = New System.Drawing.Size(34, 26)
        Me.guna2ControlBox1.TabIndex = 169
        '
        'FrmPort
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(317, 372)
        Me.Controls.Add(Me.guna2ControlBox3)
        Me.Controls.Add(Me.guna2ControlBox1)
        Me.Controls.Add(Me.guna2PictureBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmPort"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CryptoShark"
        Me.TopMost = True
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.guna2PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents TextBox2 As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents Button2 As Guna.UI2.WinForms.Guna2GradientButton
    Friend WithEvents TextBox1 As Guna.UI2.WinForms.Guna2NumericUpDown
    Private WithEvents guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Private WithEvents guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Private WithEvents guna2PictureBox2 As Guna.UI2.WinForms.Guna2PictureBox
End Class
