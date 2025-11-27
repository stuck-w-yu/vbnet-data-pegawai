Imports MySql.Data.MySqlClient

Module ModuleMySQL
    Public X As Integer
    Public S As String = ""
    Public MYSQLCMD As MySqlCommand
    Public MYSQLRDR As MySqlDataReader
    Public CNN As MySqlConnection
    Public ConnStr As String = "server=localhost;user id=root;database=ADOGaji;"
End Module