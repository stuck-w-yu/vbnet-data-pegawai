Imports MySql.Data.MySqlClient

Public Class poppeg
    Private Sub poppeg_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupListView()
        LoadPegawaiList("")
        UpdateCounter() ' Tambahkan pemanggilan UpdateCounter saat form dimuat
    End Sub

    Private Sub SetupListView()
        ListView1.Items.Clear()
        ListView1.Columns.Clear()
        ListView1.View = View.Details

        ListView1.Columns.Add("NIP", 80)
        ListView1.Columns.Add("Nama", 120)
        ListView1.Columns.Add("Bagian", 100)
        ListView1.Columns.Add("TglLhr", 90)
        ListView1.Columns.Add("Alamat", 150)
        ListView1.Columns.Add("Pendidikan", 80)
        ListView1.Columns.Add("Status", 100)
    End Sub

    Private Sub LoadPegawaiList(filter As String)
        ListView1.Items.Clear()
        Dim sql As String = "SELECT NIP, NamaPgw, Bagian, TglLhr, Alamat, Pendidikan, Status FROM pegawai"
        If Not String.IsNullOrWhiteSpace(filter) Then
            sql &= " WHERE NIP LIKE @filter OR NamaPgw LIKE @filter"
        End If

        Using conn As New MySqlConnection(ConnStr)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    If Not String.IsNullOrWhiteSpace(filter) Then
                        cmd.Parameters.AddWithValue("@filter", "%" & filter & "%")
                    End If
                    Using rdr As MySqlDataReader = cmd.ExecuteReader()
                        While rdr.Read()
                            Dim item As New ListViewItem(rdr("NIP").ToString())
                            item.SubItems.Add(rdr("NamaPgw").ToString())
                            item.SubItems.Add(rdr("Bagian").ToString())
                            If Not IsDBNull(rdr("TglLhr")) Then
                                item.SubItems.Add(Convert.ToDateTime(rdr("TglLhr")).ToString("dd-MM-yyyy"))
                            Else
                                item.SubItems.Add("")
                            End If
                            item.SubItems.Add(rdr("Alamat").ToString())
                            item.SubItems.Add(rdr("Pendidikan").ToString())
                            item.SubItems.Add(rdr("Status").ToString())
                            ListView1.Items.Add(item)
                        End While
                    End Using
                End Using
            Catch ex As MySqlException
                MessageBox.Show("Gagal menampilkan data: " & ex.Message)
            End Try
        End Using
        UpdateCounter()
    End Sub

    Private Sub TxtCariList_TextChanged(sender As Object, e As EventArgs) Handles TxtCari.TextChanged
        LoadPegawaiList(TxtCari.Text)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        ' Optional: Isi detail ke kontrol lain jika diperlukan
    End Sub

    Private Sub TxtCounter_TextChanged(sender As Object, e As EventArgs) Handles TxtCounter.TextChanged
        ' Tidak ada aksi yang diperlukan di sini
    End Sub

    Private Sub UpdateCounter()
        Dim sql As String = "SELECT COUNT(*) FROM pegawai"
        Using conn As New MySqlConnection(ConnStr)
            Try
                conn.Open()
                Using cmd As New MySqlCommand(sql, conn)
                    Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    TxtCounter.Text = count.ToString()
                End Using
            Catch ex As MySqlException
                TxtCounter.Text = "0"
            End Try
        End Using
    End Sub

    Private Sub BtnOK_Click(sender As Object, e As EventArgs) Handles BtnOK.Click
        Me.Close()
    End Sub
End Class