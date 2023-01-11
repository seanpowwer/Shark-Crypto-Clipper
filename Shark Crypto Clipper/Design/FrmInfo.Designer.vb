<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInfo))
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FuncInfp = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        Me.RefrechToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CopyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
        Me.Guna2Panel2 = New Guna.UI2.WinForms.Guna2Panel()
        Me.guna2ControlBox3 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.guna2Separator1 = New Guna.UI2.WinForms.Guna2Separator()
        Me.label15 = New System.Windows.Forms.Label()
        Me.FuncInfp.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.Guna2Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.ContextMenuStrip = Me.FuncInfp
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.LightGray
        Me.TextBox1.Location = New System.Drawing.Point(0, 67)
        Me.TextBox1.MinimumSize = New System.Drawing.Size(437, 248)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.TextBox1.Size = New System.Drawing.Size(757, 410)
        Me.TextBox1.TabIndex = 1
        '
        'FuncInfp
        '
        Me.FuncInfp.BackColor = System.Drawing.SystemColors.Control
        Me.FuncInfp.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FuncInfp.ImageScalingSize = New System.Drawing.Size(29, 29)
        Me.FuncInfp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefrechToolStripMenuItem, Me.CopyToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FuncInfp.Margin = New System.Windows.Forms.Padding(3)
        Me.FuncInfp.Name = "guna2ContextMenuStrip1"
        Me.FuncInfp.RenderStyle.ArrowColor = System.Drawing.Color.DimGray
        Me.FuncInfp.RenderStyle.BorderColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.FuncInfp.RenderStyle.ColorTable = Nothing
        Me.FuncInfp.RenderStyle.RoundedEdges = True
        Me.FuncInfp.RenderStyle.SelectionArrowColor = System.Drawing.Color.DimGray
        Me.FuncInfp.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.FuncInfp.RenderStyle.SelectionForeColor = System.Drawing.Color.DimGray
        Me.FuncInfp.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
        Me.FuncInfp.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
        Me.FuncInfp.Size = New System.Drawing.Size(115, 70)
        Me.FuncInfp.Text = "Сбросить логи"
        '
        'RefrechToolStripMenuItem
        '
        Me.RefrechToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RefrechToolStripMenuItem.Name = "RefrechToolStripMenuItem"
        Me.RefrechToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.RefrechToolStripMenuItem.Text = "Reload"
        '
        'CopyToolStripMenuItem
        '
        Me.CopyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        Me.CopyToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.CopyToolStripMenuItem.Text = "Copy"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 477)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 9, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(757, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(13, 17)
        Me.ToolStripStatusLabel1.Text = ".."
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Guna2BorderlessForm1
        '
        Me.Guna2BorderlessForm1.AnimationType = Guna.UI2.WinForms.Guna2BorderlessForm.G2402080114300C350C1C0D2412390C1404.G243B3E2E39012726
        Me.Guna2BorderlessForm1.ContainerControl = Me
        Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2BorderlessForm1.TransparentWhileDrag = True
        '
        'Guna2Panel2
        '
        Me.Guna2Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.Guna2Panel2.Controls.Add(Me.guna2ControlBox3)
        Me.Guna2Panel2.Controls.Add(Me.guna2ControlBox1)
        Me.Guna2Panel2.Controls.Add(Me.guna2Separator1)
        Me.Guna2Panel2.Controls.Add(Me.label15)
        Me.Guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel2.Name = "Guna2Panel2"
        Me.Guna2Panel2.Size = New System.Drawing.Size(757, 67)
        Me.Guna2Panel2.TabIndex = 138
        '
        'guna2ControlBox3
        '
        Me.guna2ControlBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.guna2ControlBox3.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom
        Me.guna2ControlBox3.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.guna2ControlBox3.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(38, Byte), Integer))
        Me.guna2ControlBox3.IconColor = System.Drawing.Color.White
        Me.guna2ControlBox3.Location = New System.Drawing.Point(649, 12)
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
        Me.guna2ControlBox1.Location = New System.Drawing.Point(700, 12)
        Me.guna2ControlBox1.Name = "guna2ControlBox1"
        Me.guna2ControlBox1.Size = New System.Drawing.Size(45, 31)
        Me.guna2ControlBox1.TabIndex = 165
        '
        'guna2Separator1
        '
        Me.guna2Separator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.guna2Separator1.BackColor = System.Drawing.Color.Transparent
        Me.guna2Separator1.FillColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(59, Byte), Integer))
        Me.guna2Separator1.Location = New System.Drawing.Point(-198, 61)
        Me.guna2Separator1.Name = "guna2Separator1"
        Me.guna2Separator1.Size = New System.Drawing.Size(1154, 10)
        Me.guna2Separator1.TabIndex = 13
        Me.guna2Separator1.UseTransparentBackground = True
        '
        'label15
        '
        Me.label15.AutoSize = True
        Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label15.ForeColor = System.Drawing.Color.White
        Me.label15.Location = New System.Drawing.Point(24, 22)
        Me.label15.Name = "label15"
        Me.label15.Size = New System.Drawing.Size(41, 20)
        Me.label15.TabIndex = 11
        Me.label15.Text = "Info"
        '
        'info
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(757, 499)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Guna2Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(757, 499)
        Me.Name = "info"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Информация о пк"
        Me.FuncInfp.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Guna2Panel2.ResumeLayout(False)
        Me.Guna2Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Private WithEvents FuncInfp As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents RefrechToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Private WithEvents Guna2Panel2 As Guna.UI2.WinForms.Guna2Panel
    Private WithEvents guna2ControlBox3 As Guna.UI2.WinForms.Guna2ControlBox
    Private WithEvents guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Private WithEvents guna2Separator1 As Guna.UI2.WinForms.Guna2Separator
    Private WithEvents label15 As Label
End Class
