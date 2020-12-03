Public Class Form1
    Dim r As New Random
    Dim score As Integer

    Sub Randmove(p As PictureBox)
        Dim x As Integer
        Dim y As Integer
        x = r.Next(-10, 11)
        y = r.Next(-10, 11)
        MoveTo(p, x, y)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox4wall.Image.RotateFlip(RotateFlipType.Rotate180FlipX)
        PictureBox2wall.Image.RotateFlip(RotateFlipType.Rotate180FlipX)
        PictureBox5wall.Image.RotateFlip(RotateFlipType.Rotate180FlipX)
        PictureBox3Wall.Image.RotateFlip(RotateFlipType.Rotate180FlipX)
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(mario)
        chase(mario)
        Randmove(mario)
        ScoreLabel.Text = score

    End Sub
    Sub Move(p As PictureBox, x As Integer, y As Integer)
        p.Location = New Point(p.Location.X + x, p.Location.Y + y)
        If Collision(p, "wall") Then
            MsgBox("Game Over")
        End If
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.R
                PictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX)
                Me.Refresh()
            Case Keys.Up
                MoveTo(PictureBox1, 0, -5)
            Case Keys.Down
                MoveTo(PictureBox1, 0, 5)
            Case Keys.Left
                MoveTo(PictureBox1, -5, 0)
            Case Keys.Right
                MoveTo(PictureBox1, 5, 0)
            Case Keys.Space
                Bullet.Location = PictureBox1.Location
                Bullet.Visible = False
                Timer2.Enabled = True
                xoffset = 10
                yoffset = -10
        End Select
    End Sub

    Function Collision(p As PictureBox, t As String)
        Dim col As Boolean

        For Each c In Controls
            Dim obj As Control
            obj = c
            If p.Bounds.IntersectsWith(obj.Bounds) And obj.Name.ToUpper.Contains(t.ToUpper) Then
                col = True
            End If
        Next
        Return col
    End Function
    Function IsClear(p As PictureBox, distx As Integer, disty As Integer, t As String) As Boolean
        Dim b As Boolean

        p.Location += New Point(distx, disty)
        b = Not Collision(p, t)
        p.Location -= New Point(distx, disty)
        Return b
    End Function
    Sub MoveTo(p As PictureBox, distx As Integer, disty As Integer)
        Static e As Boolean

        If IsClear(p, distx, disty, "Wall") Then
            p.Location += New Point(distx, disty)

        Else
            Me.Visible = False
            If Not e Then
                e = True
                Form2.ShowDialog()
            End If

        End If

            If p.Name = "PictureBox1" And Collision(p, "Game Over") Then
                Me.BackColor = Color.Green
                Me.Visible = False
                Dim f As New Form2
                f.ShowDialog()
                Me.Visible = True

                Return
            End If

            If p.Name = "Bullet" And Collision(p, "mario") Then
                mario.Visible = False
                Return
                score = score + 1
            End If
    End Sub
    Sub chase(p As PictureBox)
        Static headstart As Integer
        Static c As New Collection
        c.Add(PictureBox1.Location)
        headstart = headstart + 1
        If headstart > 10 Then
            p.Location = c.Item(1)
            c.Remove(1)
        End If
    End Sub
    Public Sub follow(p As PictureBox)
        Dim x, y As Integer
        If p.Location.X > PictureBox1.Location.X Then
            x = -5
        Else
            x = 5

        End If
        MoveTo(p, x, 0)
        If p.Location.Y < PictureBox1.Location.Y Then
            y = 5
        Else
            y = -5
        End If
        MoveTo(p, x, y)
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        MoveTo(Bullet, 30, 0)
    End Sub

    Dim xoffset As Integer
    Dim yoffset As Integer

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        MoveTo(PictureBox1, 0 + xoffset, 5.5 + yoffset)
        If xoffset > 0 Then
            xoffset = xoffset - 1
        End If
        If yoffset < 0 Then
            yoffset = yoffset + 1
        End If
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick

    End Sub

    Private Sub ScoreLabel_Click(sender As Object, e As EventArgs) Handles ScoreLabel.Click

    End Sub
End Class
