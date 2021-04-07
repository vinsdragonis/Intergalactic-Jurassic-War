<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash2
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
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.toppipe = New System.Windows.Forms.PictureBox
        Me.bottompipe = New System.Windows.Forms.PictureBox
        Me.dino = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.toppipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bottompipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.toppipe)
        Me.Panel1.Controls.Add(Me.bottompipe)
        Me.Panel1.Controls.Add(Me.dino)
        Me.Panel1.Location = New System.Drawing.Point(70, 70)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 400)
        Me.Panel1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "15"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(261, 616)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(834, 55)
        Me.ProgressBar1.TabIndex = 3
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Interval = 45
        '
        'Timer3
        '
        Me.Timer3.Interval = 1000
        '
        'Timer4
        '
        Me.Timer4.Interval = 45
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(1120, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(184, 394)
        Me.Panel2.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Intergalactic_Jurassic_War_part_2.My.Resources.Resources.level_3
        Me.PictureBox1.Location = New System.Drawing.Point(587, 77)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(508, 283)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'toppipe
        '
        Me.toppipe.BackColor = System.Drawing.Color.Red
        Me.toppipe.Location = New System.Drawing.Point(447, 0)
        Me.toppipe.Name = "toppipe"
        Me.toppipe.Size = New System.Drawing.Size(50, 107)
        Me.toppipe.TabIndex = 2
        Me.toppipe.TabStop = False
        '
        'bottompipe
        '
        Me.bottompipe.BackColor = System.Drawing.Color.Red
        Me.bottompipe.Location = New System.Drawing.Point(447, 233)
        Me.bottompipe.Name = "bottompipe"
        Me.bottompipe.Size = New System.Drawing.Size(50, 167)
        Me.bottompipe.TabIndex = 1
        Me.bottompipe.TabStop = False
        '
        'dino
        '
        Me.dino.Image = Global.Intergalactic_Jurassic_War_part_2.My.Resources.Resources.velociraptor
        Me.dino.Location = New System.Drawing.Point(65, 232)
        Me.dino.Name = "dino"
        Me.dino.Size = New System.Drawing.Size(118, 81)
        Me.dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dino.TabIndex = 0
        Me.dino.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 310)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Survive in this stage!"
        '
        'splash2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "splash2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "splash2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.toppipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bottompipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents toppipe As System.Windows.Forms.PictureBox
    Friend WithEvents bottompipe As System.Windows.Forms.PictureBox
    Friend WithEvents dino As System.Windows.Forms.PictureBox
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
