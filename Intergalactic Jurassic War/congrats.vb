Public Class congrats

    Private Sub congrats_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Or e.KeyCode = Keys.Escape Then
            Me.Close()
            stage3.Close()
            stage2.Close()
            splash2.Close()
            splash0.Close()
            Splash.Close()
            stage1.Close()
            start.Show()
        End If
    End Sub

    Private Sub congrats_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class