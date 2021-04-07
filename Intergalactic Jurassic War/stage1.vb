Public Class stage1
    Dim A As Integer

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Timer1.Enabled = False
            Me.Close()
            outcome.BackColor = Color.Gray
            splash0.Close()
            'gameover.Close()
            'congrats.Close()
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
        If (npc.Top > Panel1.Top) And Val(A) > 0 And Timer1.Enabled = True And e.KeyCode = Keys.W Then
            npc.Top -= 15
        End If
        If (npc.Left + npc.Width > Panel1.Left) And Val(A) > 0 And Timer1.Enabled = True And e.KeyCode = Keys.A Then
            npc.Left -= 15
            npc.Image = My.Resources.triceratops_prorsus_digital_sculpture_by_tyranttr_d62pe0
        End If
        If (npc.Top + npc.Height < Panel1.Top + Panel1.Height) And Val(A) > 0 And Timer1.Enabled = True And e.KeyCode = Keys.S Then
            npc.Top += 15
        End If
        If (npc.Left + npc.Width < Panel1.Width) And Val(A) > 0 And Timer1.Enabled = True And e.KeyCode = Keys.D Then
            npc.Left += 15
            npc.Image = My.Resources.triceratops_prorsus_digital_sculpture_by_tyranttr_d62pe0right
        End If
        
        If e.KeyCode = Keys.N Then
            If (Val(Label1.Text) >= 4 And Val(A) > 0) Then
                Me.Hide()
                Splash.Show()
                Splash.Timer1.Enabled = True
                Splash.Timer2.Enabled = True
                Splash.Timer3.Enabled = True
            Else
                Timer1.Enabled = False
                outcome.Image = Nothing
                Label1.Text = 0
                Label2.Text = 5
                outcome.BackColor = Color.Gray
                npc.Left = 300
                npc.Top = 50
                en1.Left = 300
                en1.Top = 500
                en2.Top = 400
                en2.Left = 100
                en3.Left = 650
                en3.Top = 600
                en4.Left = 550
                en4.Top = 400
                gem.Left = 550
                gem.Top = 550

            End If
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'gameover.Close()
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
            obj1.left -= 5
        End If
        If obj1.left + obj1.width < obj2.left Then
            obj1.left += 5
        End If
        If obj1.top + obj1.height > obj2.top Then
            obj1.top -= 5
        End If
        If obj1.top + obj1.height < obj2.top Then
            obj1.top += 5
        End If
    End Function

    Private Function bounce(ByRef obj1 As Object, ByRef obj2 As Object)
        If collision(obj1, obj2) Then
            If (obj1.left > obj2.left) Then
                obj1.left += 2
                obj2.left -= 2
            Else
                obj1.left += 2
                obj2.left += 2
            End If
            If (obj1.top > obj2.top) Then
                obj1.top += 2
                obj2.top -= 2
            Else
                obj1.top += 2
                obj2.top += 2
            End If
        End If
    End Function

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
        '2
        A = Val(Label2.Text)

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
        If A > 0 And Val(Label1.Text) < 0 Then
            Label1.Text = 0
        End If
        If A <= 0 Then
            Timer1.Enabled = False
            'MsgBox(Label2.Text)
            'gameover.Show()
            gem.Left = 550
            gem.Top = 550
            outcome.Image = My.Resources.Game_Over
        End If
        '5
        If Val(Label1.Text) >= 4 Then
            Timer1.Enabled = False
            'congrats.Show()
            outcome.BackColor = Color.ForestGreen
        End If



        If collision(npc, en1) Or collision(npc, en2) Or collision(npc, en3) Or collision(npc, en4) Then
            Timer1.Enabled = False
            A = Val(Label2.Text) - 1
            'MsgBox(A)
            Label2.Text = A

            npc.Left = 300
            npc.Top = 50
            ' Timer1.Enabled = False
            Label1.Text = Val(Label1.Text) - 1
            en1.Left = 300
            en1.Top = 500
            en2.Top = 400
            en2.Left = 100
            en3.Left = 650
            en3.Top = 600
            en4.Left = 550
            en4.Top = 400
        End If
        '3
       
    End Sub

    Private Sub en3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub
End Class
