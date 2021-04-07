Public Class start

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        splash0.Show()
        Me.Hide()
        splash0.Timer1.Enabled = True
        splash0.Timer2.Enabled = True
        splash0.Timer3.Enabled = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        splash0.Close()
        stage1.Close()
        Splash.Close()
        splash2.Close()
        stage3.Close()
        stage2.Close()
        'gameover.Close()
        'congrats.Close()

    End Sub

    Private Sub start_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'congrats.Close()
        'gameover.Close()
    End Sub
End Class