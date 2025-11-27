Imports MySql.Data.MySqlClient

Public Class Form1
    Sub bersih()
        TxtNIP.Text = ""
        TxtNama.Text = ""
        TxtAlamat.Text = ""
        CmbPendidikan.Text = ""
        CmbBagian.Text = ""
        DateTglLhr.Value = DateTime.Now
        RBkwn.Checked = False
        RBblmkwn.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        Using conn As New MySqlConnection(ConnStr)
            Try
                conn.Open()
                Dim query As String = "UPDATE pegawai SET NamaPgw = @NamaPgw, Bagian = @Bagian, TglLhr = @TglLhr, Alamat = @Alamat, Pendidikan = @Pendidikan, Status = @Status WHERE NIP = @NIP"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NamaPgw", TxtNama.Text)
                    cmd.Parameters.AddWithValue("@Bagian", CmbBagian.Text)
                    cmd.Parameters.AddWithValue("@TglLhr", DateTglLhr.Value)
                    cmd.Parameters.AddWithValue("@Alamat", TxtAlamat.Text)
                    cmd.Parameters.AddWithValue("@Pendidikan", CmbPendidikan.Text)
                    Dim statusValue As String = ""
                    If RBkwn.Checked Then
                        statusValue = "Sudah Menikah"
                    ElseIf RBblmkwn.Checked Then
                        statusValue = "Belum Menikah"
                    End If
                    cmd.Parameters.AddWithValue("@Status", statusValue)
                    cmd.Parameters.AddWithValue("@NIP", TxtNIP.Text)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Data berhasil diupdate!")
                        bersih()
                    Else
                        MessageBox.Show("Data tidak ditemukan atau tidak ada perubahan!")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Gagal mengupdate data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Using conn As New MySqlConnection(ConnStr)
            Try
                conn.Open()
                Dim query As String = "INSERT INTO pegawai (NIP, NamaPgw, Bagian, TglLhr, Alamat, Pendidikan, Status) VALUES (@NIP, @NamaPgw, @Bagian, @TglLhr, @Alamat, @Pendidikan, @Status)"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NIP", TxtNIP.Text)
                    cmd.Parameters.AddWithValue("@NamaPgw", TxtNama.Text)
                    cmd.Parameters.AddWithValue("@Bagian", CmbBagian.Text)
                    cmd.Parameters.AddWithValue("@TglLhr", DateTglLhr.Value)
                    cmd.Parameters.AddWithValue("@Alamat", TxtAlamat.Text)
                    cmd.Parameters.AddWithValue("@Pendidikan", CmbPendidikan.Text)
                    Dim statusValue As String = ""
                    If RBkwn.Checked Then
                        statusValue = "Sudah Menikah"
                    ElseIf RBblmkwn.Checked Then
                        statusValue = "Belum Menikah"
                    End If
                    cmd.Parameters.AddWithValue("@Status", statusValue)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("Data berhasil disimpan!")
                bersih()
            Catch ex As MySqlException
                MessageBox.Show("Gagal menyimpan data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conn As New MySqlConnection(ConnStr)
            Try
                conn.Open()
                MessageBox.Show("Koneksi ke database berhasil!")
            Catch ex As MySqlException
                MessageBox.Show("Koneksi gagal: " & ex.Message)
            End Try
        End Using

        CmbBagian.Items.Clear()
        CmbBagian.Items.Add("HRD")
        CmbBagian.Items.Add("Keuangan")
        CmbBagian.Items.Add("IT")
        CmbBagian.Items.Add("Produksi")
        CmbBagian.Items.Add("Marketing")

        CmbPendidikan.Items.Clear()
        CmbPendidikan.Items.Add("SD")
        CmbPendidikan.Items.Add("SMP")
        CmbPendidikan.Items.Add("SMA")
        CmbPendidikan.Items.Add("D3")
        CmbPendidikan.Items.Add("S1")
        CmbPendidikan.Items.Add("S2")
        CmbPendidikan.Items.Add("S3")
    End Sub

    Private Sub BtnCari_Click(sender As Object, e As EventArgs) Handles BtnCari.Click
        Using conn As New MySqlConnection(ConnStr)
            Try
                conn.Open()
                Dim query As String = "SELECT NamaPgw, Bagian, TglLhr, Alamat, Pendidikan, Status FROM pegawai WHERE NIP = @NIP"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NIP", TxtNIP.Text)
                    Using rdr As MySqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            TxtNama.Text = rdr("NamaPgw").ToString()
                            CmbBagian.Text = rdr("Bagian").ToString()
                            DateTglLhr.Value = Convert.ToDateTime(rdr("TglLhr"))
                            TxtAlamat.Text = rdr("Alamat").ToString()
                            CmbPendidikan.Text = rdr("Pendidikan").ToString()
                            Dim statusValue As String = rdr("Status").ToString()
                            If statusValue = "Sudah Menikah" Then
                                RBkwn.Checked = True
                            ElseIf statusValue = "Belum Menikah" Then
                                RBblmkwn.Checked = True
                            Else
                                RBkwn.Checked = False
                                RBblmkwn.Checked = False
                            End If
                        Else
                            MessageBox.Show("Data tidak ditemukan!")
                            bersih()
                        End If
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Gagal mencari data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        If TxtNIP.Text.Trim() = "" Then
            MessageBox.Show("Masukkan NIP yang akan dihapus!")
            Exit Sub
        End If

        Using conn As New MySqlConnection(ConnStr)
            Try
                conn.Open()
                Dim query As String = "DELETE FROM pegawai WHERE NIP = @NIP"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@NIP", TxtNIP.Text)
                    Dim rowsAffected As Integer = cmd.ExecuteNonQuery()
                    If rowsAffected > 0 Then
                        MessageBox.Show("Data berhasil dihapus!")
                        bersih()
                    Else
                        MessageBox.Show("Data tidak ditemukan!")
                    End If
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Gagal menghapus data: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        bersih()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    Private Sub BtnList_Click(sender As Object, e As EventArgs) Handles BtnList.Click
        Dim popForm As New poppeg()
        popForm.ShowDialog()
    End Sub
End Class