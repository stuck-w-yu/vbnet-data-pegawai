Imports MySql.Data.MySqlClient

Module ModuleMySQL
    ' HANYA INI SAJA ISINYA
    Public ConnStr As String = "server=localhost;user id=root;password=;database=ADOGaji;Convert Zero Datetime=True;"

    Public X As Integer
    Public S As String = ""
    Public MYSQLCMD As MySqlCommand
    Public MYSQLRDR As MySqlDataReader
    Public CNN As MySqlConnection

End Module
