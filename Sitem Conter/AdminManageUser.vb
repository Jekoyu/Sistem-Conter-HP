Public Class AdminManageUser
    Sub Tampilkan()
        clm = "*"
        tbl = "tb_Users"
        Tampil(clm, tbl)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Sub Getcb()
        q = "select * from tb_role order by id asc"
        Koneksi()
        cmd = New SqlClient.SqlCommand(q, conn)
        dr = cmd.ExecuteReader
        CbRole.Items.Clear()

        While dr.Read
            CbRole.Items.Add(dr.Item("id") + "-" + dr.Item("name"))
        End While
    End Sub
    Sub GetId()
        q = "select * from tb_users order by id desc"
        Cari(q)
        If dr.HasRows Then
            TbId.Text = "USR" + Format(Microsoft.VisualBasic.Right(dr.Item("id"), 6) + 1, "000000")
        Else
            TbId.Text = "USR000001"
        End If
    End Sub

    Sub Kosongkan()
        TbId.Clear()
        Tampilkan()
        GetId()
        Getcb()
        TbUsername.Clear()
        TbEmail.Clear()
        TbPassword.Clear()
        TbAlamat.Clear()
        TbNohp.Clear()
        CbRole.Text = ""
        TbUsername.Focus()
    End Sub
    Sub Hapuskan()
        q = "delete from tb_users where id = '" & TbId.Text & "'"
        ENQ(q)
        Kosongkan()
    End Sub
    Sub Tambahkan()
        Dim str As String = CbRole.Text
        Dim idrole As String = str.Substring(0, 1)
        'MsgBox(idrole)
        q = "select * from tb_users where id = '" & TbId.Text & "'"
        Cari(q)
        If dr.HasRows Then
            q = "update tb_users set username = '" & TbUsername.Text & "',email ='" & TbEmail.Text & "',password = '" & TbPassword.Text & "',alamat ='" & TbAlamat.Text & "',nohp = '" & TbNohp.Text & "', role = '" & idrole & "' where id = '" & TbId.Text & "'"
            'MsgBox(q)
            ENQ(q)
            Kosongkan()
        Else
            q = "insert into tb_users (id,username,email,password,alamat,nohp,role) values('" & TbId.Text & "','" & TbUsername.Text & "','" & TbEmail.Text & "','" & TbPassword.Text & "','" & TbAlamat.Text & "','" & TbNohp.Text & "','" & idrole & "')"
            ENQ(q)
            Kosongkan()
        End If
    End Sub
    Private Sub AdminManageUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kosongkan()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TbUsername.Text = "" Or TbEmail.Text = "" Or TbPassword.Text = "" Or TbAlamat.Text = "" Or TbNohp.Text = "" Or CbRole.Text = "" Then
            m = "Terdapat Kolom Kosong"
            Msg(m)
        Else
            Try
                Tambahkan()
            Catch ex As Exception
                m = ex.ToString
                Msg(m)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim r As String
        r = MsgBox("Yakin Hapus??", vbYesNo)
        If r = vbYes Then
            Try
                Hapuskan()
            Catch ex As Exception
                m = ex.ToString
                Msg(m)
            End Try
        Else
            Kosongkan()
        End If
    End Sub



    Private Sub DGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDoubleClick
        TbId.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        TbUsername.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        TbEmail.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        TbPassword.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        TbAlamat.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        TbNohp.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        Dim id As String
        id = DGV.Rows(e.RowIndex).Cells(6).Value
        q = "select * from tb_role where id = '" & id & "'"
        Cari(q)
        Try
            CbRole.Text = dr.Item("id") + "-" + dr.Item("name")
        Catch ex As Exception
            m = ex.ToString
            Msg(m)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Kosongkan()
    End Sub
End Class