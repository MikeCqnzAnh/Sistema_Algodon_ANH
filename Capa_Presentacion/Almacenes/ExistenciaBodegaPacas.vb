﻿Public Class ExistenciaBodegaPacas
    Dim columna, fila, Niveles, Lotes As Byte
    Private Sub ExistenciaBodegaPacas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Limpiar()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub Limpiar()
        TbIdAlmacen.Text = ""
        TbNombreAlmacen.Text = ""
        TbCantidadRack.Text = ""
        TbCantidadNiveles.Text = ""
        TbColumnas.Text = ""
        TbFilas.Text = ""
        CbNivel.DataSource = Nothing
        CbNivel.Items.Clear()
        CbNoLote.DataSource = Nothing
        CbNoLote.Items.Clear()
        DgvMatriz.Columns.Clear()
        DgvMatriz.Refresh()
    End Sub
    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        'ArrayNiveles()
        CreaMatriz()
        ConsultaBodega()
        TbEtiqueta.Select()
    End Sub
    Private Sub CreaMatriz()
        Dim i As Byte
        columna = Val(TbColumnas.Text)
        fila = Val(TbFilas.Text)

        DgvMatriz.ColumnCount = columna
        DgvMatriz.RowCount = fila
        For i = 0 To fila - 1
            DgvMatriz.Rows(i).HeaderCell.Value = (CbNivel.Text & i + 1).ToString
        Next
        For i = 0 To columna - 1
            DgvMatriz.Columns(i).HeaderText = i + 1
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
        CbNivel.MaxDropDownItems = 8
        CbNivel.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub comboLotes()
        Dim i As Byte
        Lotes = Val(TbCantidadRack.Text)
        Dim dt As DataTable = New DataTable("Tabla")
        Dim dr As DataRow
        dt.Columns.Add("ID")
        dt.Columns.Add("Descripcion")
        For i = 0 To Lotes - 1
            dr = dt.NewRow()
            dr("ID") = i + 1
            dr("Descripcion") = i + 1
            dt.Rows.Add(dr)
        Next
        CbNoLote.DataSource = dt
        CbNoLote.ValueMember = "ID"
        CbNoLote.DisplayMember = "Descripcion"
        CbNoLote.MaxDropDownItems = 8
        CbNoLote.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub
    Private Sub TbEtiquetaActual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbEtiqueta.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub BtIdAlmacen_Click(sender As Object, e As EventArgs) Handles BtIdAlmacen.Click
        Dim EntidadAlmacenes As New Capa_Entidad.Almacenes
        Dim NegocioAlmacenes As New Capa_Negocio.Almacenes
        Dim Tabla As New DataTable
        ConsultaAlmacen.ShowDialog()
        EntidadAlmacenes.IdAlmacenEncabezado = ConsultaAlmacen.IdAlmacen
        EntidadAlmacenes.Descripcion = ""
        EntidadAlmacenes.Consulta = Consulta.ConsultaAlmacen
        NegocioAlmacenes.Consultar(EntidadAlmacenes)
        Tabla = EntidadAlmacenes.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        Try
            TbIdAlmacen.Text = Tabla.Rows(0).Item("IdAlmacenencabezado")
            TbNombreAlmacen.Text = Tabla.Rows(0).Item("Descripcion")
            TbCantidadRack.Text = Tabla.Rows(0).Item("CantidadLotes")
            TbCantidadNiveles.Text = Tabla.Rows(0).Item("CantidadNiveles")
            TbColumnas.Text = Tabla.Rows(0).Item("Columnas")
            TbFilas.Text = Tabla.Rows(0).Item("Filas")
            ArrayNiveles()
            comboLotes()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultaBodega()
        Dim EntidadExistenciaBodegaPacas As New Capa_Entidad.ExistenciaBodegaPacas
        Dim NegocioExistenciaBodegaPacas As New Capa_Negocio.ExistenciaBodegaPacas
        Dim Tabla As New DataTable
        EntidadExistenciaBodegaPacas.IdAlmacenEncabezado = Val(TbIdAlmacen.Text)
        EntidadExistenciaBodegaPacas.IdLote = CbNoLote.Text
        EntidadExistenciaBodegaPacas.Nivel = CbNivel.Text
        EntidadExistenciaBodegaPacas.Consulta = Consulta.ConsultaAlmacenLote
        NegocioExistenciaBodegaPacas.Consultar(EntidadExistenciaBodegaPacas)
        Tabla = EntidadExistenciaBodegaPacas.TablaConsulta
        For Each row As DataRow In Tabla.Rows
            InsertaPaca(row("PosicionColumna"), row("PosicionFila"), row("BaleID"))
        Next
    End Sub
    Private Sub ActualizaPaca(ByVal Fil As Integer, ByVal Col As Integer, ByVal Baleid As Integer, ByVal estatus As Integer)
        Dim EntidadExistenciaBodegaPacas As New Capa_Entidad.ExistenciaBodegaPacas
        Dim NegocioExistenciaBodegaPacas As New Capa_Negocio.ExistenciaBodegaPacas
        EntidadExistenciaBodegaPacas.IdAlmacenEncabezado = Val(TbIdAlmacen.Text)
        EntidadExistenciaBodegaPacas.IdLote = CbNoLote.Text
        EntidadExistenciaBodegaPacas.Nivel = CbNivel.Text
        EntidadExistenciaBodegaPacas.PosicionColumna = Col
        EntidadExistenciaBodegaPacas.posicionfila = Fil
        EntidadExistenciaBodegaPacas.BaleID = Baleid
        EntidadExistenciaBodegaPacas.EstatusAlmacen = estatus
        EntidadExistenciaBodegaPacas.Guarda = Guardar.GuardarDetalle
        NegocioExistenciaBodegaPacas.Guardar(EntidadExistenciaBodegaPacas)
        Tabla = EntidadExistenciaBodegaPacas.TablaConsulta
    End Sub
    Private Sub InsertaPaca(ByVal Col As Byte, ByVal Fil As Byte, ByVal BaleID As Integer)
        DgvMatriz(Col, Fil).Value = IIf(BaleID = 0, "", BaleID)
    End Sub
    Private Sub insertapacamatriz()
        Dim i, j As Byte
        columna = DgvMatriz.ColumnCount
        fila = DgvMatriz.RowCount
        For j = 0 To fila - 1
            For i = 0 To columna - 1
                If DgvMatriz(i, j).Value.ToString = TbEtiqueta.Text Then
                    MsgBox("La Paca con etiqueta " & TbEtiqueta.Text & " ya existe en el rack #" & CbNoLote.Text)
                    Exit Sub
                    'ElseIf DgvMatriz(i, j).Value IsNot Nothing And DgvMatriz(i, j).Value = 0 Then

                ElseIf DgvMatriz(i, j).Value.ToString <> "" Then

                Else
                    DgvMatriz(i, j).Value = Val(TbEtiqueta.Text)
                    ActualizaPaca(j, i, DgvMatriz(i, j).Value, 1)
                    If i = (Val(TbColumnas.Text) - 1) And CbNivel.SelectedIndex = (CbNivel.Items.Count - 1) Then
                        CbNivel.SelectedIndex = 0
                        CreaMatriz()
                        ConsultaBodega()
                    ElseIf i = (Val(TbColumnas.Text) - 1) And CbNivel.SelectedIndex < (CbNivel.Items.Count - 1) Then
                        CbNivel.SelectedIndex = CbNivel.SelectedIndex + 1
                        CreaMatriz()
                        ConsultaBodega()
                    End If
                    Exit Sub
                End If
            Next
        Next
    End Sub
    Private Sub TbEtiqueta_KeyDown(sender As Object, e As KeyEventArgs) Handles TbEtiqueta.KeyDown
        If e.KeyCode = Keys.Enter Then
            If DgvMatriz.Rows.Count > 0 Then
                insertapacamatriz()
                TbEtiqueta.Text = ""
                TbEtiqueta.Select()
            Else
                MsgBox("No hay lote seleccionado para capturar.", MsgBoxStyle.Exclamation, "Aviso")
            End If
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class