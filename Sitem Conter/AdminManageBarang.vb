Public Class AdminManageBarang
    Sub Tampilkan()
        clm = "*"
        tbl = "tb_barang"
        Tampil(clm, tbl)
        DGV.DataSource = ds.Tables(0)
        DGV.ReadOnly = True
    End Sub
    Sub GetId()
        q = "select * from tb_barang order by id desc"
        Cari(q)
        If dr.HasRows Then
            TbId.Text = "ITM" + Format(Microsoft.VisualBasic.Right(dr.Item("id"), 6) + 1, "000000")
        Else
            TbId.Text = "ITM000001"
        End If
    End Sub

    Sub Kosongkan()
        Tampilkan()
        TbId.Clear()
        GetId()
        TbNama.Clear()
        TbHarga.Clear()
        TbStok.Clear()
        TbGambar.Clear()
        TbKet.Clear()
        TbNama.Focus()
    End Sub
    Sub Hapuskan()
        q = "delete  from tb_barang where id = '" & TbId.Text & "'"
        ENQ(q)
        Kosongkan()
    End Sub
    Sub Tambahkan()
        q = "select * from tb_barang where id = '" & TbId.Text & "'"
        Cari(q)
        If dr.HasRows Then
            q = "update tb_barang set nama = '" & TbNama.Text & "',gambar = '" & TbGambar.Text & "',harga = '" & TbHarga.Text & "',stok = '" & TbStok.Text & "',keterangan = '" & TbKet.Text & "' where id = '" & TbId.Text & "'"
            ENQ(q)
            Kosongkan()
        Else
            q = "insert into tb_barang(id,nama,gambar,harga,stok,keterangan) values('" & TbId.Text & "','" & TbNama.Text & "','" & TbGambar.Text & "','" & TbHarga.Text & "','" & TbStok.Text & "','" & TbKet.Text & "')"
            ENQ(q)
            Kosongkan()
        End If
    End Sub
    Private Sub AdminManageBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Kosongkan()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        With OFD
            .Filter = "IMAGE|*.jpg;*.png;*.bmp"
        End With
        If OFD.ShowDialog = DialogResult.OK Then
            TbGambar.Text = OFD.FileName
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If TbNama.Text = "" Or TbGambar.Text = "" Or TbHarga.Text = "" Or TbStok.Text = "" Or TbKet.Text = "" Then
            m = "Kolom Ada Yang Kosong"
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
            Hapuskan()
            Kosongkan()
        Else
            Kosongkan()
        End If
    End Sub


    Private Sub DGV_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DGV.CellMouseDoubleClick
        TbId.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        TbNama.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        TbGambar.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        TbHarga.Text = DGV.Rows(e.RowIndex).Cells(3).Value
        TbStok.Text = DGV.Rows(e.RowIndex).Cells(4).Value
        TbKet.Text = DGV.Rows(e.RowIndex).Cells(5).Value
    End Sub
End Class