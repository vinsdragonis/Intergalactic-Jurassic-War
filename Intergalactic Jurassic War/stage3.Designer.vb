<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class stage3
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.time = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.outcome = New System.Windows.Forms.PictureBox
        Me.boss = New System.Windows.Forms.PictureBox
        Me.npc = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Panel1.SuspendLayout()
        CType(Me.outcome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.boss, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.npc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 35
        '
        'Timer2
        '
        Me.Timer2.Interval = 1000
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 38.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(1056, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(247, 90)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "STAGE-3"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(1090, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 47)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Life:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(1230, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 47)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "3"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.boss)
        Me.Panel1.Controls.Add(Me.npc)
        Me.Panel1.Location = New System.Drawing.Point(50, 15)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 740)
        Me.Panel1.TabIndex = 14
        '
        'time
        '
        Me.time.BackColor = System.Drawing.Color.Transparent
        Me.time.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.time.ForeColor = System.Drawing.Color.White
        Me.time.Location = New System.Drawing.Point(1196, 562)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(68, 47)
        Me.time.TabIndex = 22
        Me.time.Text = "30"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(1158, 515)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 47)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Timer"
        '
        'outcome
        '
        Me.outcome.BackColor = System.Drawing.Color.Gray
        Me.outcome.Location = New System.Drawing.Point(1093, 218)
        Me.outcome.Name = "outcome"
        Me.outcome.Size = New System.Drawing.Size(210, 130)
        Me.outcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.outcome.TabIndex = 23
        Me.outcome.TabStop = False
        '
        'boss
        '
        Me.boss.BackColor = System.Drawing.Color.Transparent
        Me.boss.Image = Global.Intergalactic_Jurassic_War_part_2.My.Resources.Resources.Magmasaur_the_Volcanic_Tricerotops
        Me.boss.Location = New System.Drawing.Point(750, 550)
        Me.boss.Name = "boss"
        Me.boss.Size = New System.Drawing.Size(179, 119)
        Me.boss.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.boss.TabIndex = 11
        Me.boss.TabStop = False
        '
        'npc
        '
        Me.npc.BackColor = System.Drawing.Color.Transparent
        Me.npc.Image = Global.Intergalactic_Jurassic_War_part_2.My.Resources.Resources.tyrannosaurus_rex_3d_model_low_poly_max_obj_fbx_ma_mb_copy__2_
        Me.npc.Location = New System.Drawing.Point(100, 100)
        Me.npc.Name = "npc"
        Me.npc.Size = New System.Drawing.Size(180, 120)
        Me.npc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.npc.TabIndex = 10
        Me.npc.TabStop = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(1090, 364)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(221, 53)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "OUTCOME"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(1161, 417)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 108)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "Press N after your outcome turns green."
        '
        'stage3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.BackgroundImage = Global.Intergalactic_Jurassic_War_part_2.My.Resources.Resources.dinosaur_alien_spaceship_battle001
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.outcome)
        Me.Controls.Add(Me.time)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "stage3"
        Me.Text = "stage3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        CType(Me.outcome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.boss, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.npc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents npc As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents boss As System.Windows.Forms.PictureBox
    Friend WithEvents time As System.Windows.Forms.Label
    Friend WithEvents outcome As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
