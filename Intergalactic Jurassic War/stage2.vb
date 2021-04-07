Public Class stage2

    Private Sub stage2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            outcome.BackColor = Color.Gray
            Splash.Close()
            stage1.Close()
            start.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            Timer1.Enabled = True
        End If
        If Timer1.Enabled = True And e.KeyCode = Keys.P Then
            Timer1.Enabled = False
        Else
            Timer1.Enabled = True
        End If
        If (npc.Top > Panel1.Top) And Val(Label2.Text) > 0 And Timer1.Enabled = True And e.KeyCode = Keys.W Then
            npc.Top -= 20
        End If
        If (npc.Left + npc.Width > Panel1.Left) And Val(Label2.Text) > 0 And Timer1.Enabled = True And e.KeyCode = Keys.A Then
            npc.Left -= 20
            npc.Image = My.Resources.PteraThumb1left
        End If
        If (npc.Top + npc.Height < Panel1.Top + Panel1.Height) And Val(Label2.Text) > 0 And Timer1.Enabled = True And e.KeyCode = Keys.S Then
            npc.Top += 20
        End If
        If (npc.Left + npc.Width < Panel1.Width) And Val(Label2.Text) > 0 And Timer1.Enabled = True And e.KeyCode = Keys.D Then
            npc.Left += 20
            npc.Image = My.Resources.PteraThumb1
        End If

        If e.KeyCode = Keys.N Then
            If (Val(Label1.Text) >= 5 And Val(Label2.Text) > 0) Then
                Me.Close()
                stage1.Close()
                splash2.Show()
                splash2.Timer1.Enabled = True
                splash2.Timer2.Enabled = True
                splash2.Timer3.Enabled = True
            Else
                Timer1.Enabled = False
                outcome.Image = Nothing
                outcome.BackColor = Color.Gray
                Label1.Text = 0
                Label2.Text = 3
                'npc=600, 50
                npc.Left = 600
                npc.Top = 50
                'en1=100, 500
                en1.Left = 100
                en1.Top = 500
                'en2=100, 300
                en2.Left = 100
                en2.Top = 300
                'en3=500, 500
                en3.Left = 500
                en3.Top = 500
                'en4=500, 300
                en4.Left = 500
                en4.Top = 300
                'gem=350, 450
                gem.Left = 350
                gem.Top = 450

            End If
        End If
    End Sub

    Private Function collision(ByVal obja As Object, ByVal objb As Object) As Boolean
        Dim collided As Boolean = False
        If obja.top + obja.height >= objb.top And objb.top + objb.height >= obja.top And obja.left + obja.width >= objb.left And objb.left + objb.width >= obja.left Then
            collided = True
        End If
        Return collided
    End Function

    Private Function chase(ByRef obj1 As Object, ByRef obj2 As Object)
        If obj1.left + obj1.width > obj2.left Then
            obj1.left -= 6
        End If
        If obj1.left + obj1.width < obj2.left Then
            obj1.left += 6
        End If
        If obj1.top + obj1.height > obj2.top Then
            obj1.top -= 6
        End If
        If obj1.top + obj1.height < obj2.top Then
            obj1.top += 6
        End If
    End Function

    Private Function bounce(ByRef obj1 As Object, ByRef obj2 As Object)
        If collision(obj1, obj2) Then
            If (obj1.left > obj2.left) Then
                obj1.left += 2
                obj2.left -= 2
            Else
                obj1.left -= 2
                obj2.left += 2
            End If
            If (obj1.top > obj2.top) Then
                obj1.top += 2
                obj2.top -= 2
            Else
                obj1.top -= 2
                obj2.top += 2
            End If
        End If
    End Function

    Private Sub stage2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'gameover.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        '1
        chase(en1, npc)
        chase(en2, npc)
        chase(en3, npc)
        chase(en4, npc)
        bounce(en1, en2)
        bounce(en2, en1)
        bounce(en2, en3)
        bounce(en3, en2)
        bounce(en3, en1)
        bounce(en1, en3)
        bounce(en4, en1)
        bounce(en1, en4)
        bounce(en4, en2)
        bounce(en2, en4)
        bounce(en3, en4)
        bounce(en4, en3)
        
        '3
        If collision(npc, gem) = True Then
            Label1.Text = Val(Label1.Text) + 1
            gem.Left = en1.Left
            gem.Top = en1.Top
            If gem.Left < Panel1.Left Then
                gem.Left = Panel1.Left + 100
            End If
            If gem.Top < Panel1.Top Then
                gem.Top = gem.Top + 100
            End If
        End If
        '4
        If Val(Label2.Text) > 0 And Val(Label1.Text) < 0 Then
            Label1.Text = 0
        End If
        If Val(Label2.Text) = 0 Then
            Timer1.Enabled = False
            'gameover.Show()
            outcome.Image = My.Resources.Game_Over
            gem.Left = 550
            gem.Top = 550
        End If
        '5
        If Val(Label1.Text) >= 5 Then
            Timer1.Enabled = False
            'congrats.Show()
            outcome.BackColor = Color.ForestGreen
        End If
        '2
        If collision(npc, en1) Or collision(npc, en2) Or collision(npc, en3) Or collision(npc, en4) Then
            Timer1.Enabled = False
            Label2.Text = Val(Label2.Text) - 1
            'npc=600, 50
            npc.Left = 600
            npc.Top = 50
            Label1.Text = Val(Label1.Text) - 1
            'npc=600, 50
            npc.Left = 600
            npc.Top = 50
            'en1=100, 500
            en1.Left = 100
            en1.Top = 500
            'en2=100, 300
            en2.Left = 100
            en2.Top = 300
            'en3=500, 500
            en3.Left = 500
            en3.Top = 500
            'en4=500, 300
            en4.Left = 500
            en4.Top = 300
        End If
    End Sub

    Private Sub en4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles en4.Click

    End Sub
End Class