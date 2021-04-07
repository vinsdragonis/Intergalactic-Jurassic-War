Public Class splash0
    Dim ys As Integer = 1
    Dim gr As Integer = 2

    Private Sub Splash_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If ProgressBar1.Value = 100 And e.KeyCode = Keys.Enter Then
            stage1.Show()
            ProgressBar1.Value = 0
            Timer1.Enabled = False
        End If
        If e.KeyCode = Keys.Space Then
            ys = -35
            dino.Top -= ys
        End If
    End Sub

    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer2.Enabled = True
        Timer3.Enabled = True
        'gameover.Close()
        'congrats.Close()
    End Sub

    Private Function collision(ByVal obja As Object, ByVal objb As Object) As Boolean
        Dim collided As Boolean = False
        If obja.top + obja.height >= objb.top And objb.top + objb.height >= obja.top And obja.left + obja.width >= objb.left And objb.left + objb.width >= obja.left Then
            collided = True
        End If
        Return collided
    End Function


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If ProgressBar1.Value >= 0 Then
            Do Until ProgressBar1.Value = 100
                ProgressBar1.Value += 1
            Loop
        End If

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        ys += gr
        dino.Top += ys
        toppipe.Left -= 5
        bottompipe.Left -= 5
        If toppipe.Left <= -50 And bottompipe.Left <= -50 Then
            toppipe.Left += 620
            bottompipe.Left += 620
        End If
        If dino.Visible = True And (collision(dino, toppipe) Or collision(dino, bottompipe)) = True Then
            dino.Visible = False
        Else
            dino.Visible = True
        End If
        If dino.Top <= 0 Then
            dino.Top = 0
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        If Val(Label1.Text) = 0 Then
            Timer2.Enabled = False
            Timer3.Enabled = False
            Me.Hide()
            stage1.Show()
        Else
            Label1.Text -= 1
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick


    End Sub
End Class