<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stage1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(stage1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.outcome = New System.Windows.Forms.PictureBox
        Me.en4 = New System.Windows.Forms.PictureBox
        Me.en3 = New System.Windows.Forms.PictureBox
        Me.en2 = New System.Windows.Forms.PictureBox
        Me.gem = New System.Windows.Forms.PictureBox
        Me.en1 = New System.Windows.Forms.PictureBox
        Me.npc = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.outcome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gem, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.en1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 45
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1274, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 47)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1274, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 47)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "5"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1056, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(224, 47)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fragments:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1134, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 47)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Life:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.en4)
        Me.Panel1.Controls.Add(Me.en3)
        Me.Panel1.Controls.Add(Me.en2)
        Me.Panel1.Controls.Add(Me.gem)
        Me.Panel1.Controls.Add(Me.en1)
        Me.Panel1.Controls.Add(Me.npc)
        Me.Panel1.Location = New System.Drawing.Point(50, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 740)
        Me.Panel1.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(1179, 685)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 71)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Press P to pause."
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1100, 160)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 90)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "STAGE-1"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(1179, 567)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(142, 108)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Press Enter to start."
        '
        'outcome
        '
        Me.outcome.BackColor = System.Drawing.Color.Gray
        Me.outcome.Location = New System.Drawing.Point(1100, 250)
        Me.outcome.Name = "outcome"
        Me.outcome.Size = New System.Drawing.Size(210, 130)
        Me.outcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.outcome.TabIndex = 17
        Me.outcome.TabStop = False
        '
        'en4
        '
        Me.en4.BackColor = System.Drawing.Color.Transparent
        Me.en4.Image = CType(resources.GetObject("en4.Image"), System.Drawing.Image)
        Me.en4.Location = New System.Drawing.Point(550, 400)
        Me.en4.Name = "en4"
        Me.en4.Size = New System.Drawing.Size(120, 90)
        Me.en4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en4.TabIndex = 15
        Me.en4.TabStop = False
        Me.en4.Tag = "foe"
        '
        'en3
        '
        Me.en3.BackColor = System.Drawing.Color.Transparent
        Me.en3.Image = CType(resources.GetObject("en3.Image"), System.Drawing.Image)
        Me.en3.Location = New System.Drawing.Point(650, 600)
        Me.en3.Name = "en3"
        Me.en3.Size = New System.Drawing.Size(120, 90)
        Me.en3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en3.TabIndex = 14
        Me.en3.TabStop = False
        Me.en3.Tag = "foe"
        '
        'en2
        '
        Me.en2.BackColor = System.Drawing.Color.Transparent
        Me.en2.Image = CType(resources.GetObject("en2.Image"), System.Drawing.Image)
        Me.en2.Location = New System.Drawing.Point(100, 400)
        Me.en2.Name = "en2"
        Me.en2.Size = New System.Drawing.Size(120, 90)
        Me.en2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en2.TabIndex = 13
        Me.en2.TabStop = False
        Me.en2.Tag = "foe"
        '
        'gem
        '
        Me.gem.BackColor = System.Drawing.Color.Gold
        Me.gem.Image = Global.Intergalactic_Jurassic_War_part_2.My.Resources.Resources.remote
        Me.gem.Location = New System.Drawing.Point(550, 550)
        Me.gem.Name = "gem"
        Me.gem.Size = New System.Drawing.Size(20, 20)
        Me.gem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.gem.TabIndex = 12
        Me.gem.TabStop = False
        '
        'en1
        '
        Me.en1.BackColor = System.Drawing.Color.Transparent
        Me.en1.Image = CType(resources.GetObject("en1.Image"), System.Drawing.Image)
        Me.en1.Location = New System.Drawing.Point(300, 500)
        Me.en1.Name = "en1"
        Me.en1.Size = New System.Drawing.Size(120, 90)
        Me.en1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.en1.TabIndex = 11
        Me.en1.TabStop = False
        Me.en1.Tag = "foe"
        '
        'npc
        '
        Me.npc.BackColor = System.Drawing.Color.Transparent
        Me.npc.Image = Global.Intergalactic_Jurassic_War_part_2.My.Resources.Resources.triceratops_prorsus_digital_sculpture_by_tyranttr_d62pe0
        Me.npc.Location = New System.Drawing.Point(300, 50)
        Me.npc.Name = "npc"
        Me.npc.Size = New System.Drawing.Size(120, 70)
        Me.npc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.npc.TabIndex = 10
        Me.npc.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(1100, 399)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(221, 53)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "OUTCOME"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1179, 459)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 108)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Press N after your outcome turns green."
        '
        'stage1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Intergalactic_Jurassic_War_part_2.My.Resources.Resources.dinosaur_alien_spaceship_battle001
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.outcome)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stage1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stage 2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.outcome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gem, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.en1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents gem As System.Windows.Forms.PictureBox
    Friend WithEvents en1 As System.Windows.Forms.PictureBox
    Friend WithEvents npc As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents en2 As System.Windows.Forms.PictureBox
    Friend WithEvents en3 As System.Windows.Forms.PictureBox
    Friend WithEvents en4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents outcome As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label

End Class
