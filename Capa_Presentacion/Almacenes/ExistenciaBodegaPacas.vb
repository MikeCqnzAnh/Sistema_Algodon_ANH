Public Class ExistenciaBodegaPacas
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
        RbEntrada.Checked = True
        CbNivel.Enabled = False
        CbNoLote.Enabled = False
        BtAceptar.Enabled = False
        Panel3.Enabled = False
    End Sub
    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        'ArrayNiveles()
        If CbNivel.SelectedValue Is Nothing Then

        Else
            CreaMatriz()
            ConsultaBodega()
            TbEtiqueta.Select()
        End If
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
        TbEtiqueta.Text = ""
        TbEtiqueta.Select()
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
            CbNivel.Enabled = True
            CbNoLote.Enabled = True
            BtAceptar.Enabled = True
            Panel3.Enabled = True
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
            InsertaPaca(row("PosicionColumna"), row("PosicionFila"), row("BaleID"), row("Estatusalmacen"))
        Next
    End Sub
    Private Sub ActualizaPaca(ByVal Fil As Integer, ByVal Col As Integer, ByVal Baleid As Integer, ByVal estatus As Integer)
        Dim EntidadExistenciaBodegaPacas As New Capa_Entidad.ExistenciaBodegaPacas
        Dim NegocioExistenciaBodegaPacas As New Capa_Negocio.ExistenciaBodegaPacas
        Try
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

            GeneraRegistroBitacora(Me.Text.Clone.ToString, BtInsertar.Text, TbIdAlmacen.Text, Baleid & " COMO " & IIf(RbEntrada.Checked = True, "ENTRADA", "SALIDA"))
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub InsertaPaca(ByVal Col As Byte, ByVal Fil As Byte, ByVal BaleID As Integer, ByVal estatus As Integer)
        DgvMatriz(Col, Fil).Value = IIf(BaleID = 0, "", BaleID)
        Select Case estatus
            Case 0
                DgvMatriz(Col, Fil).Style.BackColor = Color.White
            Case 1
                DgvMatriz(Col, Fil).Style.BackColor = Color.Green
            Case 2
                DgvMatriz(Col, Fil).Style.BackColor = Color.Yellow
        End Select
    End Sub
    Private Sub insertapacamatriz()
        Dim existe As Boolean = False
        Dim IDAlmacen As Integer
        Dim NoLote As Integer
        Dim LNivel As String
        Dim estatusalmacen As Boolean

        Dim EntidadExistenciaBodegaPacas As New Capa_Entidad.ExistenciaBodegaPacas
        Dim NegocioExistenciaBodegaPacas As New Capa_Negocio.ExistenciaBodegaPacas
        EntidadExistenciaBodegaPacas.IdAlmacenEncabezado = Val(TbIdAlmacen.Text)
        EntidadExistenciaBodegaPacas.BaleID = Val(TbEtiqueta.Text)
        EntidadExistenciaBodegaPacas.Consulta = Consulta.ConsultaAlmacen
        NegocioExistenciaBodegaPacas.Consultar(EntidadExistenciaBodegaPacas)
        Tabla = EntidadExistenciaBodegaPacas.TablaConsulta
        If Tabla.Rows.Count > 0 Then
            IDAlmacen = Tabla.Rows(0).Item("IdAlmacenEncabezado")
            NoLote = Tabla.Rows(0).Item("IdLote")
            LNivel = Tabla.Rows(0).Item("Nivel")
            existe = Tabla.Rows(0).Item("existe")
            estatusalmacen = IIf(Tabla.Rows(0).Item("EstatusAlmacen") = 2, 1, 0)
        End If
        Dim i, j As Byte
        columna = DgvMatriz.ColumnCount
        fila = DgvMatriz.RowCount
        If TbEtiqueta.Text <> "" Then
            If existe = False And RbEntrada.Checked = True Then
                For j = 0 To fila - 1
                    For i = 0 To columna - 1
                        Dim Reg As Integer = Val(TbFilas.Text) * Val(TbColumnas.Text)
                        If DgvMatriz(i, j).Value.ToString <> "" Then

                        ElseIf DgvMatriz(i, j).Value.ToString = "" Then
                            DgvMatriz(i, j).Value = Val(TbEtiqueta.Text)
                            ActualizaPaca(j, i, DgvMatriz(i, j).Value, IIf(RbEntrada.Checked = True, 1, 2))
                            If i = (Val(TbColumnas.Text) - 1) And CbNivel.SelectedIndex = (CbNivel.Items.Count - 1) And validaceldas() < Reg Then
                                CbNivel.SelectedIndex = 0
                                CreaMatriz()
                                ConsultaBodega()
                            ElseIf i = (Val(TbColumnas.Text) - 1) And CbNivel.SelectedIndex = (CbNivel.Items.Count - 1) And Reg = validaceldas() Then
                                CbNivel.SelectedIndex = 0
                                CbNoLote.SelectedIndex = CbNoLote.SelectedIndex + 1
                                CreaMatriz()
                                ConsultaBodega()
                            ElseIf i = (Val(TbColumnas.Text) - 1) And CbNivel.SelectedIndex < (CbNivel.Items.Count - 1) Then
                                CbNivel.SelectedIndex = CbNivel.SelectedIndex + 1
                                CreaMatriz()
                                ConsultaBodega()
                            End If
                            CreaMatriz()
                            ConsultaBodega()
                            Exit Sub
                        End If
                    Next
                Next
            ElseIf existe = True And estatusalmacen = False And RbSalidas.Checked = True Then
                For j = 0 To fila - 1
                    For i = 0 To columna - 1
                        Dim Reg As Integer = Val(TbFilas.Text) * Val(TbColumnas.Text)
                        If DgvMatriz(i, j).Value.ToString = TbEtiqueta.Text Then
                            DgvMatriz(i, j).Value = Val(TbEtiqueta.Text)
                            ActualizaPaca(j, i, DgvMatriz(i, j).Value, IIf(RbEntrada.Checked = True, 1, 2))
                            If i = (Val(TbColumnas.Text) - 1) And CbNivel.SelectedIndex = (CbNivel.Items.Count - 1) And validaceldas() < Reg Then
                                CbNivel.SelectedIndex = 0
                                CreaMatriz()
                                ConsultaBodega()
                            ElseIf i = (Val(TbColumnas.Text) - 1) And CbNivel.SelectedIndex = (CbNivel.Items.Count - 1) And Reg = validaceldas() Then
                                CbNivel.SelectedIndex = 0
                                CbNoLote.SelectedIndex = CbNoLote.SelectedIndex + 1
                                CreaMatriz()
                                ConsultaBodega()
                            ElseIf i = (Val(TbColumnas.Text) - 1) And CbNivel.SelectedIndex < (CbNivel.Items.Count - 1) Then
                                CbNivel.SelectedIndex = CbNivel.SelectedIndex + 1
                                CreaMatriz()
                                ConsultaBodega()
                            End If
                            CreaMatriz()
                            ConsultaBodega()
                            Exit Sub
                        End If
                    Next
                Next
            ElseIf existe = True And estatusalmacen = False And RbEntrada.Checked = True Then
                MsgBox("La Paca con etiqueta " & TbEtiqueta.Text & " ya existe en el Lote #" & CbNoLote.Text)
                Exit Sub
            ElseIf existe = True And estatusalmacen = True And RbSalidas.Checked = True Then
                MsgBox("La Paca con etiqueta " & TbEtiqueta.Text & " ya existe en el Lote #" & CbNoLote.Text)
                Exit Sub
            ElseIf existe = False And RbSalidas.Checked = True Then
                MsgBox("La paca no existe para darle salida, verifique o cambie a opcion Entradas para continuar", MsgBoxStyle.Information, "Aviso")
            ElseIf existe = True And estatusalmacen = True And RbEntrada.Checked = True Then
                MsgBox("La paca " & TbEtiqueta.Text & " ya se registro su salida, revise la informacion o contacte al administrador del sistema.", MsgBoxStyle.Information, "Aviso")
            End If
        Else
            MsgBox("El campo de etiqueta no puede estar vacio.", MsgBoxStyle.Information, "Aviso")
        End If
    End Sub
    Function validaceldas()
        Dim contar As Integer = 0
        Dim i, j As Byte
        columna = DgvMatriz.ColumnCount
        fila = DgvMatriz.RowCount
        For j = 0 To fila - 1
            For i = 0 To columna - 1
                If DgvMatriz(i, j).Value.ToString <> "" Then
                    contar = contar + 1
                End If
            Next
        Next
        Return contar
    End Function
    Private Function validaexistencia(ByVal BaleId As Integer) As Boolean
        Dim existe As Boolean
        Dim EntidadExistenciaBodegaPacas As New Capa_Entidad.ExistenciaBodegaPacas
        Dim NegocioExistenciaBodegaPacas As New Capa_Negocio.ExistenciaBodegaPacas
        EntidadExistenciaBodegaPacas.IdAlmacenEncabezado = Val(TbIdAlmacen.Text)
        EntidadExistenciaBodegaPacas.BaleID = Val(TbEtiqueta.Text)
        EntidadExistenciaBodegaPacas.Consulta = Consulta.ConsultaAlmacen
        NegocioExistenciaBodegaPacas.Consultar(EntidadExistenciaBodegaPacas)
        Tabla = EntidadExistenciaBodegaPacas.TablaConsulta
        If Tabla.Rows.Count > 0 Then
            existe = Tabla.Rows(0).Item("existe")
        End If
        Return existe
    End Function
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