Public Class Form1
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim Beranda = "https://m.facebook.com"
    Dim Profil = "https://m.facebook.com/profile.php?"
    Dim Pesan = "https://m.facebook.com/messages/?"
    Dim Pemberitahuan = "https://m.facebook.com/notifications.php?"
    Dim Obrolan = "https://m.facebook.com/buddylist.php?"
    Private Sub TitleDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown, Label2.MouseDown
        drag = True
        mousex = Windows.Forms.Cursor.Position.X - Me.Left
        mousey = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub TitleMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove, Label2.MouseMove
        If drag Then
            Me.Top = Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub

    Private Sub TitleUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp, Label2.MouseUp
        drag = False
    End Sub
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.Close()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(Beranda)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        WebBrowser1.Navigate(Profil)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        WebBrowser1.Navigate(Pesan)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        WebBrowser1.Navigate(Pemberitahuan)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        WebBrowser1.Navigate(Obrolan)
    End Sub
End Class
