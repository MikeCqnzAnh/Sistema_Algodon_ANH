Public Class ExistenciaBodegaPacas
    Dim columna, fila, Niveles As Byte
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub Limpiar()
        TbCantidadRack.Text = ""
        TbCantidadNiveles.Text = ""
        TbColumnas.Text = ""
        TbFilas.Text = ""
        CbNivel.DataSource = Nothing
        CbNivel.Items.Clear()
        DgvMatriz.Columns.Clear()
    End Sub
    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        ArrayNiveles()
        CreaMatriz()
    End Sub
    Private Sub CreaMatriz()
        Dim i As Byte
        columna = Val(TbColumnas.Text)
        fila = Val(TbFilas.Text)

        DgvMatriz.ColumnCount = columna
        DgvMatriz.RowCount = fila
        For i = 0 To columna - 1
            DgvMatriz.Columns(i).HeaderText = i + 1
        Next
        For i = 0 To fila - 1
            DgvMatriz.Rows(i).HeaderCell.Value = (CbNivel.Text & i + 1).ToString
        Next
    End Sub
    Private Sub BtInsertar_Click(sender As Object, e As EventArgs) Handles BtInsertar.Click
        insertapacamatriz()
    End Sub
    Private Sub ArrayNiveles()
        Dim ArrayCadena() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"}
        Dim i As Byte
        Niveles = Val(TbCantidadNiveles.Text)
        Dim dt As DataTable = New DataTable("Tabla")
        Dim dr As DataRow
        dt.Columns.Add("Codigo")
        dt.Columns.Add("Descripcion")
        For i = 0 To Niveles - 1
            dr = dt.NewRow()
            dr("Codigo") = i + 1
            dr("Descripcion") = ArrayCadena(i)
            dt.Rows.Add(dr)
        Next
        CbNivel.DataSource = dt
        CbNivel.ValueMember = "Codigo"
        CbNivel.DisplayMember = "Descripcion"
    End Sub
    Private Sub insertapacamatriz()
        Dim i, j As Byte
        columna = DgvMatriz.ColumnCount
        fila = DgvMatriz.RowCount
        For j = 0 To fila - 1
            For i = 0 To columna - 1
                If DgvMatriz(i, j).Value = Val(TbEtiqueta.Text) Then
                    MsgBox("La Paca con etiqueta " & TbEtiqueta.Text & " ya existe en el rack #")
                    Exit Sub
                ElseIf DgvMatriz(i, j).Value IsNot Nothing Then

                Else
                    DgvMatriz(i, j).Value = Val(TbEtiqueta.Text)
                    Exit Sub
                End If
            Next
        Next
    End Sub
    Private Sub TbEtiqueta_KeyDown(sender As Object, e As KeyEventArgs) Handles TbEtiqueta.KeyDown
        If e.KeyCode = Keys.Enter Then
            insertapacamatriz()
            TbEtiqueta.Text = ""
        End If
    End Sub
End Class