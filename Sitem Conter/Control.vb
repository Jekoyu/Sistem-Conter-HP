Imports System.Data.SqlClient
Module Control
    Public conn As SqlConnection
    Public cmd As SqlCommand
    Public dr As SqlDataReader
    Public da As New SqlDataAdapter
    Public ds As DataSet
    Public role As String
    Public m As String
    Public q As String
    Public clm As String
    Public tbl As String
    Public Sub Msg(ByVal m As String)
        MessageBox.Show(m)
    End Sub
    Public Sub Koneksi()
        Try
            conn = New SqlConnection("Data Source=DESKTOP-VOQEHKC\SQLEXPRESS;Initial Catalog=db_conter;Integrated Security=True;MultipleActiveResultSets=True")
            conn.Open()
        Catch ex As Exception
            m = ex.ToString
            Msg(m)
        End Try
    End Sub

    Function Tampil(ByVal tbl As String, clm As String) As Boolean
        Try
            Koneksi()
            da = New SqlDataAdapter("select " + clm + " from " + tbl, conn)
            ds = New DataSet
            da.Fill(ds)
        Catch ex As Exception
            m = ex.ToString
            Msg(m)
        End Try
        Return True
    End Function
    Function Cari(ByVal q As String) As Boolean
        Try
            Koneksi()
            cmd = New SqlCommand(q, conn)
            dr = cmd.ExecuteReader
            dr.Read()
        Catch ex As Exception
            m = ex.ToString
            Msg(m)
        End Try
        Return True
    End Function
    Function ENQ(ByVal q As String) As Boolean
        Try
            Koneksi()
            cmd = New SqlCommand(q, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            m = ex.ToString
            Msg(m)
        End Try
        Return True
    End Function

End Module
