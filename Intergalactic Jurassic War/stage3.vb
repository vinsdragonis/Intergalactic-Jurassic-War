Public Class stage3

    Private Sub stage3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
            stage2.Close()
            splash2.Close()
            splash0.Close()
            Splash.Close()
            stage1.Close()
            start.Show()
        End If
        If e.KeyCode = Keys.Enter Then
            Timer1.Enabled = True
            Timer2.Enabled = True
        End If
        If Timer1.Enabled = True And e.KeyCode = Keys.P Then
            Timer1.Enabled = False
            Timer2.Enabled = False
        Else
            Timer1.Enabled = True
            Timer2.Enabled = True
        End If
        If (npc.Top > Panel1.Top) And Val(Label2.Text) > 0 And Timer1.Enabled = True And e.KeyCode = Keys.W Then
            npc.Top -= 25
        End If
        If (npc.Left + npc.Width > Panel1.Left) And Val(Label2.Text) > 0 And Timer1.Enabled = True And e.KeyCode = Keys.A Then
            npc.Left -= 25
            npc.Image = My.Resources.tyrannosaurus_rex_3d_model_low_poly_max_obj_fbx_ma_mb_copy_left
        End If
        If (npc.Top + npc.Height < Panel1.Top + Panel1.Height) And Val(Label2.Text) > 0 And Timer1.Enabled = True And e.KeyCode = Keys.S Then
            npc.Top += 25
        End If
        If (npc.Left + npc.Width < Panel1.Width) And Val(Label2.Text) > 0 And Timer1.Enabled = True And e.KeyCode = Keys.D Then
            npc.Left += 25
            npc.Image = My.Resources.tyrannosaurus_rex_3d_model_low_poly_max_obj_fbx_ma_mb_copy__2_
        End If

        If e.KeyCode = Keys.N Then
            If time.Text = 0 And (Val(Label2.Text) > 0) And collision(npc, boss) = False Then
                stage1.Close()
                Splash.Close()
                splash2.Close()
                splash0.Close()
                stage2.Close()
                congrats.Show()
            Else
                Timer1.Enabled = False
                Timer2.Enabled = False
                Label2.Text = 3
                outcome.BackColor = Color.Gray
                outcome.Image = Nothing
                'npc=100, 100
                npc.Left = 100
                npc.Top = 100
                'boss=750,550
                boss.Left = 750
                boss.Top = 550
                time.Text = 30
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
            obj1.left -= 9
        End If
        If obj1.left + obj1.width < obj2.left Then
            obj1.left += 9
        End If
        If obj1.top + obj1.height > obj2.top Then
            obj1.top -= 9
        End If
        If obj1.top + obj1.height < obj2.top Then
            obj1.top += 9
        End If
    End Function

    Private Sub stage3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        chase(boss, npc)
        If boss.Left < npc.Left Then
            boss.Image = My.Resources.Magmasaur_the_Volcanic_Tricerotops_right
        Else
            boss.Image = My.Resources.Magmasaur_the_Volcanic_Tricerotops
        End If
        If collision(npc, boss) Then
            Label2.Text = Val(Label2.Text) - 1
            time.Text = Val(time.Text) + 10
            'npc=100, 100
            npc.Left = 100
            npc.Top = 100
            'boss=750,550
            boss.Left = 750
            boss.Top = 550
            Timer1.Enabled = False
            Timer2.Enabled = False
        End If
        If Label2.Text = 0 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            time.Text = 0
            outcome.Image = My.Resources.Game_Over
        End If
        If time.Text = 0 And (Val(Label2.Text) > 0) And collision(npc, boss) = False Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            outcome.BackColor = Color.ForestGreen
            time.Text = 0
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If time.Text = 0 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            time.Text = 30
        Else
            time.Text = Val(time.Text) - 1
        End If
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub
End Class