Imports MySql.Data.MySqlClient

Public Class LoginForm1
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Using conn As New MySqlConnection(ConnStr)
            Try
                conn.Open()
                Dim query As String = "SELECT COUNT(*) FROM login WHERE username=@username AND password=@password"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", UsernameTextBox.Text)
                    cmd.Parameters.AddWithValue("@password", PasswordTextBox.Text)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If count > 0 Then
                        MessageBox.Show("Login berhasil!")
                        Me.Hide()
                        Dim form1 As New Form1()
                        form1.ShowDialog()
                        Me.Close()
                    Else
                        MessageBox.Show("Username atau password salah!")
                        PasswordTextBox.Clear()
                        PasswordTextBox.Focus()
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Gagal koneksi ke database: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged
        ' Optional: Tambahkan logika jika diperlukan
    End Sub

    Private Sub LogoPictureBox_Click(sender As Object, e As EventArgs) Handles LogoPictureBox.Click
        ' Optional: Tambahkan logika jika diperlukan
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
