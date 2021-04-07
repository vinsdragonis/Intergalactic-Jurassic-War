<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class splash0
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.toppipe = New System.Windows.Forms.PictureBox
        Me.bottompipe = New System.Windows.Forms.PictureBox
        Me.dino = New System.Windows.Forms.PictureBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.toppipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bottompipe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(261, 616)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(834, 55)
        Me.ProgressBar1.TabIndex = 1
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
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.Intergalactic_Jurassic_War_part_2.My.Resources.Resources.instruction_stage_1
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(586, 70)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(689, 394)
        Me.Panel3.TabIndex = 7
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
        Me.dino.Image = Global.Intergalactic_Jurassic_War_part_2.My.Resources.Resources.velociraptor1
        Me.dino.Location = New System.Drawing.Point(65, 232)
        Me.dino.Name = "dino"
        Me.dino.Size = New System.Drawing.Size(118, 81)
        Me.dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dino.TabIndex = 0
        Me.dino.TabStop = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(512, 510)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(300, 85)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Collect 4 fragments in this stage." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "After that, press enter to move on to the nex" & _
            "t stage."
        '
        'splash0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "splash0"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "splash0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.toppipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bottompipe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents toppipe As System.Windows.Forms.PictureBox
    Friend WithEvents bottompipe As System.Windows.Forms.PictureBox
    Friend WithEvents dino As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
