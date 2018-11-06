Imports Capa_Operacion.Configuracion
Public Class ClasificacionVentaPaquetes
    Private TablaClasificacionGrid, TablaClasificacionGlobal As New DataTable
    Private Sub ClasificacionVentaPaquetes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaCombos()
        'Consultar()
        propiedadesDgv1()
        CreaTabla()
        Limpiar()
    End Sub
    Private Sub CargaCombos()
        '---Planta Origen--
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbPlanta.DataSource = Tabla
        CbPlanta.ValueMember = "IdPlanta"
        CbPlanta.DisplayMember = "Descripcion"
        CbPlanta.SelectedValue = 1
        '---Clasificacion--
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla2 As New DataTable
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaClases
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla2 = EntidadClasificacionVentaPaquetes.TablaConsulta
        CbClases.DataSource = Tabla2
        CbClases.ValueMember = "IdClasificacion"
        CbClases.DisplayMember = "ClaveCorta"
        CbClases.SelectedValue = 1
        '----Estatus
        '---------------------------COMBO ESTATUS
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("IdEstatus")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("IdEstatus") = "1"
        dr("Descripcion") = "Activo"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("IdEstatus") = "2"
        dr("Descripcion") = "Inactivo"
        dt.Rows.Add(dr)
        CbEstatus.DataSource = dt
        CbEstatus.ValueMember = "IdEstatus"
        CbEstatus.DisplayMember = "Descripcion"
        CbEstatus.SelectedValue = 1
    End Sub
    Private Sub Limpiar()
        TbIdPaquete.Text = ""
        TbIdPaquete.Enabled = True
        TbIdPaquete.Focus()
        CbPlanta.SelectedValue = 1
        CbClases.SelectedValue = 1
        CbEstatus.SelectedValue = 1
        chkfinalizado.Checked = False
        TbDescripcion.Text = ""
        TbCantidadPacas.Text = ""
        DgvPacasClasificacion1.Enabled = True
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
    End Sub
    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Consultar()
    End Sub
    Private Sub CreaTabla()
        TablaClasificacionGrid.Columns.Clear()
        TablaClasificacionGrid.Columns.Add(New DataColumn("BaleId", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Mic", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("ColorGrade", System.Type.GetType("System.String")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("TrashId", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Clase", System.Type.GetType("System.String")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("UHML", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Strength", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("SCI", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("FlagTerminado", System.Type.GetType("System.Boolean")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("IdHviDetalle", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("IdOrdenTrabajo", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("EstatusCompra", System.Type.GetType("System.Int32")))
    End Sub
    Private Sub ContarPacas()
        TbCantidadPacas.Text = DgvPacasClasificacion1.Rows.Count
    End Sub
    Private Sub DataGridViewToTable()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim index As Integer
        Dim rengloninsertar As DataRow
        TablaClasificacionGrid.Clear()
        For Each row As DataGridViewRow In DgvPacasClasificacion1.Rows
            index = Convert.ToUInt64(row.Index)
            rengloninsertar = TablaClasificacionGrid.NewRow()
            rengloninsertar("BaleId") = DgvPacasClasificacion1.Rows(index).Cells("BaleId").Value
            rengloninsertar("Mic") = DgvPacasClasificacion1.Rows(index).Cells("Mic").Value
            rengloninsertar("ColorGrade") = DgvPacasClasificacion1.Rows(index).Cells("ColorGrade").Value
            rengloninsertar("TrashId") = DgvPacasClasificacion1.Rows(index).Cells("TrashId").Value
            rengloninsertar("Clase") = DgvPacasClasificacion1.Rows(index).Cells("Clase").Value
            rengloninsertar("UHML") = DgvPacasClasificacion1.Rows(index).Cells("LargoFibra").Value
            rengloninsertar("Strength") = DgvPacasClasificacion1.Rows(index).Cells("Resistencia").Value
            rengloninsertar("SCI") = DgvPacasClasificacion1.Rows(index).Cells("SCI").Value
            rengloninsertar("FlagTerminado") = IIf(DgvPacasClasificacion1.Rows(index).Cells("FlagTerminado").Value = Nothing, False, DgvPacasClasificacion1.Rows(index).Cells("FlagTerminado").Value)
            rengloninsertar("IdHviDetalle") = DgvPacasClasificacion1.Rows(index).Cells("IdHviDetalle").Value
            rengloninsertar("IdOrdenTrabajo") = DgvPacasClasificacion1.Rows(index).Cells("IdOrdenTrabajo").Value
            rengloninsertar("EstatusCompra") = 1

            TablaClasificacionGrid.Rows.Add(rengloninsertar)
        Next
        TablaClasificacionGlobal = TablaClasificacionGrid
    End Sub
    Private Sub TextBox_PreviewKeyDown(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DgvPacasClasificacion1.CellEnter
        Dim GradoColor As String = Convert.ToString(DgvPacasClasificacion1.CurrentRow.Cells("ColorGrade").Value)
        Dim TrashId As Integer = DgvPacasClasificacion1.CurrentRow.Cells("TrashID").Value
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla2 As New DataTable
        If GradoColor <> "" And TrashId <> 0 Then
            EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaClasesDetalle
            EntidadClasificacionVentaPaquetes.GradoColor = GradoColor
            EntidadClasificacionVentaPaquetes.TrashId = TrashId
            NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
            Tabla2 = EntidadClasificacionVentaPaquetes.TablaConsulta
            If Tabla2.Rows.Count = 0 Then
                MsgBox("Verifica los valores de Grado Color y TrashID", MsgBoxStyle.Exclamation)
                Exit Sub
            Else
                DgvPacasClasificacion1.CurrentRow.Cells("Clase").Value = Tabla2.Rows(0).Item("ClaveCorta")
                IdentificaColor()
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub
    Function VerificaExistenciaPacaEnPaquete(ByVal IdPaca As Integer)
        Dim ExistePaca As Integer
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla As New DataTable
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPacaExistente
        EntidadClasificacionVentaPaquetes.NumeroPaca = CInt(IIf(TbNoPaca.Text = "", 0, TbNoPaca.Text))
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        ExistePaca = Tabla.Rows(0).Item("IdPaqueteEncabezado")
        Return ExistePaca
    End Function
    Private Sub TbNoPaca_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbNoPaca.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If TbNoPaca.Text <> "" Then
                    Dim IdPaquete = VerificaExistenciaPacaEnPaquete(TbNoPaca.Text)
                    If IdPaquete = 0 Then
                        InsertaPaca()
                        TbNoPaca.Text = ""
                        Guardar()
                    Else
                        Dim result As Integer = MessageBox.Show("La paca No. " & TbNoPaca.Text & " Ya existe en el paquete " & IdPaquete & ", ¿Deseas cambiarla al Paquete actual?", "Aviso", MessageBoxButtons.YesNo)
                        If result = DialogResult.No Then

                        ElseIf result = DialogResult.Yes Then
                            ActualizaPaca()
                            InsertaPaca()
                            Guardar()
                            'MessageBox.Show("El paquete ha sido actualizado!")
                        End If
                        TbNoPaca.Text = ""
                    End If
                Else
                    MsgBox("Ingrese el ID de la orden de trabajo...")
                    Exit Sub
                End If
        End Select
        ContarPacas()
    End Sub
    Private Sub TbIdPaquete_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbIdPaquete.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If TbIdPaquete.Text <> "" Then
                    TbIdPaquete.Enabled = False
                    Consultar()
                    TbNoPaca.Text = ""
                    TbNoPaca.Focus()
                Else
                    MsgBox("Ingrese el ID del paquete...")
                    Exit Sub
                End If
        End Select
        ContarPacas()
    End Sub
    Private Sub ActualizaPaca()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        'Dim Tabla As New DataTable
        EntidadClasificacionVentaPaquetes.Actualiza = Actuliza.ActualizaIdPaca
        EntidadClasificacionVentaPaquetes.NumeroPaca = CInt(IIf(TbNoPaca.Text = "", 0, TbNoPaca.Text))
        EntidadClasificacionVentaPaquetes.IdPaquete = CInt(IIf(TbIdPaquete.Text = "", 0, TbIdPaquete.Text))
        NegocioClasificacionVentaPaquetes.Actualizar(EntidadClasificacionVentaPaquetes)
    End Sub
    Private Sub InsertaPaca()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla As New DataTable
        Dim VerificaDuplicado As Boolean
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPaca
        EntidadClasificacionVentaPaquetes.NumeroPaca = CInt(IIf(TbNoPaca.Text = "", 0, TbNoPaca.Text))
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            MsgBox("La paca no se encuentra en la base de datos HVI.")
        ElseIf VerificaPacaRepetida(VerificaDuplicado) = False Then
            DgvPacasClasificacion1.Rows.Add(Tabla.Rows(0).Item("BaleId"), Tabla.Rows(0).Item("Mic"), Tabla.Rows(0).Item("ColorGrade"), Tabla.Rows(0).Item("TrashId"), Tabla.Rows(0).Item("Clase"), Tabla.Rows(0).Item("LargoFibra"), Tabla.Rows(0).Item("ResistenciaFibra"), Tabla.Rows(0).Item("SCI"), Tabla.Rows(0).Item("IdHviDet"), Tabla.Rows(0).Item("IdOrdenTrabajo"), Tabla.Rows(0).Item("FlagTerminado"))
        Else
            MsgBox("El numero de paca ya se encuentra registrado.")
        End If
        DgvPacasClasificacion1.Sort(DgvPacasClasificacion1.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
        IdentificaColor()
    End Sub
    Public Function VerificaPacaRepetida(ByVal VerificaDuplicado As Boolean)
        VerificaDuplicado = False
        For Each row As DataGridViewRow In DgvPacasClasificacion1.Rows
            Dim NoPaca As Integer = TbNoPaca.Text
            If NoPaca = row.Cells("BaleId").Value Then
                VerificaDuplicado = True
            End If
        Next row
        Return VerificaDuplicado
    End Function
    Private Sub EliminarRegistro()
        Dim dt As DataTable = DataGridViewToDataTable(DgvPacasClasificacion1)
        Dim filas As Integer = dt.Rows.Count
        Dim idd As Boolean
        For i As Integer = 0 To dt.Rows.Count - 1
            idd = dt.Rows(i).Item(8)
            If idd = True Then
                dt.Rows.RemoveAt(i)
            End If
        Next
        DgvPacasClasificacion1.Columns.Clear()
        DgvPacasClasificacion1.DataSource = dt
    End Sub
    Private Sub EliminarRegistro2()
        For index = 0 To DgvPacasClasificacion1.Rows.Count - 1
            If Convert.ToBoolean(DgvPacasClasificacion1("sel", index).Value) Then
                DgvPacasClasificacion1.Rows.RemoveAt(index)
            End If
        Next
    End Sub
    Public Sub EditaFila()
        With DgvPacasClasificacion1
            .BeginEdit(True)
        End With
    End Sub
    Private Sub verificaChecks(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPacasClasificacion1.CellContentClick
        Dim Contador As Integer
        For Contador = 0 To DgvPacasClasificacion1.RowCount - 1
            If DgvPacasClasificacion1.Rows(Contador).Selected Then
                If DgvPacasClasificacion1.Rows(Contador).Cells("Sel").Value = False Then
                    DgvPacasClasificacion1.Rows(Contador).Cells("Sel").Value = True
                ElseIf DgvPacasClasificacion1.Rows(Contador).Cells("Sel").Value = True Then
                    DgvPacasClasificacion1.Rows(Contador).Cells("Sel").Value = False
                End If
            End If
            DgvPacasClasificacion1.Rows(Contador).Selected = False
        Next Contador
    End Sub
    Private Sub desmarcaCheck()
        Dim Contador As Integer
        For Contador = 0 To DgvPacasClasificacion1.RowCount - 1
            DgvPacasClasificacion1.Rows(Contador).Cells("Sel").Value = False
        Next Contador
    End Sub
    Private Sub EliminarRegistro3()
        For Each filap As DataGridViewRow In DgvPacasClasificacion1.Rows
            For Each fila As DataGridViewRow In DgvPacasClasificacion1.Rows
                If CBool(fila.Cells(9).Value) = True Then
                    DgvPacasClasificacion1.Rows.Remove(fila)
                End If
            Next
        Next
    End Sub
    Private Function IdentificaColor() As Integer
        Dim ContadorColor As Integer
        For Each fila As DataGridViewRow In DgvPacasClasificacion1.Rows
            If fila.Cells(4).Value.ToString <> CbClases.Text Then
                fila.DefaultCellStyle.BackColor = Color.Red
                ContadorColor = ContadorColor + 1
            Else
                fila.DefaultCellStyle.BackColor = Color.White
                ContadorColor = ContadorColor + 0
            End If
        Next
        Return ContadorColor
    End Function
    Private Sub PropiedadesDGV()
        DgvPacasClasificacion1.Columns("BaleId").ReadOnly = False
        DgvPacasClasificacion1.Columns("TrashID").ReadOnly = False
        DgvPacasClasificacion1.Columns("Resistencia").ReadOnly = False
        DgvPacasClasificacion1.Columns("Mic").ReadOnly = False
        DgvPacasClasificacion1.Columns("ColorGrade").ReadOnly = False
        DgvPacasClasificacion1.Columns("TrashID").ReadOnly = False
        DgvPacasClasificacion1.Columns("LargoFibra").ReadOnly = False
        DgvPacasClasificacion1.Columns("Resistencia").ReadOnly = False
    End Sub
    Private Sub propiedadesDgv1()
        DgvPacasClasificacion1.Columns.Clear()
        If DgvPacasClasificacion1.Columns("BaleId") Is Nothing Then
            Dim colBaleId As New DataGridViewTextBoxColumn
            colBaleId.Name = "BaleId"
            colBaleId.HeaderText = "No Paca"
            colBaleId.ReadOnly = True
            DgvPacasClasificacion1.Columns.Insert(0, colBaleId)

            Dim colMic As New DataGridViewTextBoxColumn
            colMic.Name = "Mic"
            DgvPacasClasificacion1.Columns.Insert(1, colMic)

            Dim colColorGrade As New DataGridViewTextBoxColumn
            colColorGrade.Name = "ColorGrade"
            DgvPacasClasificacion1.Columns.Insert(2, colColorGrade)

            Dim ColTrashId As New DataGridViewTextBoxColumn()
            ColTrashId.Name = "TrashId"
            DgvPacasClasificacion1.Columns.Insert(3, ColTrashId)

            Dim ColClase As New DataGridViewTextBoxColumn()
            ColClase.Name = "Clase"
            ColClase.ReadOnly = True
            DgvPacasClasificacion1.Columns.Insert(4, ColClase)

            Dim ColLargoFibra As New DataGridViewTextBoxColumn()
            ColLargoFibra.Name = "LargoFibra"
            ColLargoFibra.ValueType = GetType(Int32)
            DgvPacasClasificacion1.Columns.Insert(5, ColLargoFibra)

            Dim ColResistencia As New DataGridViewTextBoxColumn()
            ColResistencia.Name = "Resistencia"
            DgvPacasClasificacion1.Columns.Insert(6, ColResistencia)

            Dim ColSCI As New DataGridViewTextBoxColumn()
            ColSCI.Name = "SCI"
            ColSCI.ReadOnly = True
            DgvPacasClasificacion1.Columns.Insert(7, ColSCI)

            Dim colIdHviDetalle As New DataGridViewTextBoxColumn
            colIdHviDetalle.Name = "IdHviDetalle"
            colIdHviDetalle.Visible = False
            DgvPacasClasificacion1.Columns.Insert(8, colIdHviDetalle)

            Dim colIdOrdenTrabajo As New DataGridViewTextBoxColumn
            colIdOrdenTrabajo.Name = "IdOrdenTrabajo"
            colIdOrdenTrabajo.Visible = False
            DgvPacasClasificacion1.Columns.Insert(9, colIdOrdenTrabajo)

            Dim colSel As New DataGridViewCheckBoxColumn()
            colSel.Name = "Sel"
            DgvPacasClasificacion1.Columns.Insert(10, colSel)

            Dim colTerminado As New DataGridViewCheckBoxColumn()
            colTerminado.Name = "FlagTerminado"
            colTerminado.FalseValue = False
            colTerminado.Visible = False
            DgvPacasClasificacion1.Columns.Insert(11, colTerminado)
        End If
    End Sub
    Private Sub EliminarPacasSeleccionadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPacasSeleccionadasToolStripMenuItem.Click
        EliminarRegistro2()
        ContarPacas()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub Guardar()
        'If DgvPacasClasificacion1.RowCount > 0 Then
        'If TbIdPaquete.Text <> "" Then
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        If IdentificaColor() > 0 And chkfinalizado.Checked = True Then
            MsgBox("Por favor, verificar que los datos esten correctos.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
        Else
            EntidadClasificacionVentaPaquetes.IdPaquete = IIf(TbIdPaquete.Text = "", 0, TbIdPaquete.Text)
            EntidadClasificacionVentaPaquetes.IdPlanta = CbPlanta.SelectedValue
            EntidadClasificacionVentaPaquetes.IdClase = CbClases.SelectedValue
            EntidadClasificacionVentaPaquetes.CantidadPacas = TbCantidadPacas.Text
            EntidadClasificacionVentaPaquetes.Descripcion = TbDescripcion.Text
            EntidadClasificacionVentaPaquetes.chkrevisado = chkfinalizado.Checked
            EntidadClasificacionVentaPaquetes.IdEstatus = CbEstatus.SelectedValue
            EntidadClasificacionVentaPaquetes.IdUsuarioCreacion = 1
            EntidadClasificacionVentaPaquetes.FechaCreacion = Now
            EntidadClasificacionVentaPaquetes.IdUsuarioActualizacion = 1
            EntidadClasificacionVentaPaquetes.FechaActualizacion = Now
            DataGridViewToTable()
            EntidadClasificacionVentaPaquetes.TablaGeneral = TablaClasificacionGlobal
            NegocioClasificacionVentaPaquetes.GuardarTablas(EntidadClasificacionVentaPaquetes)
            TbIdPaquete.Text = EntidadClasificacionVentaPaquetes.IdPaquete
            'MsgBox("Paquete guardado con exito.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Aviso")
            DgvPacasClasificacion1.Enabled = False
        End If
        'Else
        '    MsgBox("El campo No Paca esta vacio, no se puede guardar informacion!", MsgBoxStyle.Information, "Aviso")
        'End If
        'Else
        '    MsgBox("No hay datos para guardar.", MsgBoxStyle.Exclamation)
        'End If
    End Sub

    Private Sub Datatb()
        Try
            Dim dt As DataTable = DataGridViewToDataTable(DgvPacasClasificacion1)
            MessageBox.Show(String.Format("Nº de filas añadidas: {0}", dt.Rows.Count))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        DgvPacasClasificacion1.Columns.Clear()
        propiedadesDgv1()
        Limpiar()
    End Sub

    Private Function DataGridViewToDataTable(dgv As DataGridView) As DataTable
        If (dgv Is Nothing) Then Return Nothing
        Dim dt As New DataTable()
        For Each col As DataGridViewColumn In dgv.Columns
            Dim column As New DataColumn(col.Name, Type.GetType("System.String"))
            dt.Columns.Add(column)
        Next
        For Each viewRow As DataGridViewRow In dgv.Rows
            Dim row As DataRow = dt.NewRow()
            For Each col As DataGridViewColumn In dgv.Columns
                Dim value As Object = viewRow.Cells(col.Name).Value
                row.Item(col.Name) = If(value Is Nothing, DBNull.Value, value)
            Next col
            dt.Rows.Add(row)
        Next viewRow
        Return dt
    End Function
    Private Sub Consultar()
        DgvPacasClasificacion1.Rows.Clear()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        If TbIdPaquete.Text <> "" Then
            EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaDetallada
            EntidadClasificacionVentaPaquetes.IdPaquete = CInt(TbIdPaquete.Text)
            NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
            Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
            If Tabla.Rows.Count <> 0 Then
                TbIdPaquete.Text = Tabla.Rows(0).Item("IdPaquete")
                CbPlanta.SelectedValue = Tabla.Rows(0).Item("IdPlanta")
                CbClases.SelectedValue = Tabla.Rows(0).Item("IdClase")
                TbCantidadPacas.Text = Tabla.Rows(0).Item("CantidadPacas")
                TbDescripcion.Text = Tabla.Rows(0).Item("Descripcion")
                chkfinalizado.Checked = Tabla.Rows(0).Item("chkrevisado")
                CbEstatus.SelectedValue = Tabla.Rows(0).Item("IdEstatus")
                EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPorId
                EntidadClasificacionVentaPaquetes.IdPaquete = CInt(TbIdPaquete.Text)
                NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
                Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
                For i As Integer = 0 To Tabla.Rows.Count - 1
                    'Dim index As Integer
                    'index = row.Index
                    DgvPacasClasificacion1.Rows.Add(Tabla.Rows(i).Item("BaleId"), Tabla.Rows(i).Item("Mic"), Tabla.Rows(i).Item("ColorGrade"), Tabla.Rows(i).Item("TrashId"), Tabla.Rows(i).Item("Clase"), Tabla.Rows(i).Item("LargoFibra"), Tabla.Rows(i).Item("ResistenciaFibra"), Tabla.Rows(i).Item("SCI"), Tabla.Rows(0).Item("FlagTerminado"), Tabla.Rows(i).Item("IdHviDetalle"))
                Next
            Else
                MsgBox("No se encontraron registros con esos criterios.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                TbIdPaquete.Enabled = True
                TbIdPaquete.Text = ""
            End If
        Else
            MsgBox("Por favor, verificar que los datos esten correctos.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
        End If
        IdentificaColor()
        If chkfinalizado.Checked = True Then DgvPacasClasificacion1.Enabled = False
        desmarcaCheck()
    End Sub

    Private Sub chkfinalizado_CheckedChanged(sender As Object, e As EventArgs) Handles chkfinalizado.CheckedChanged
        Dim index As Integer
        If chkfinalizado.Checked = True Then

            For Each row As DataGridViewRow In DgvPacasClasificacion1.Rows
                Index = Convert.ToUInt64(row.Index)
                DgvPacasClasificacion1.Rows(Index).Cells("FlagTerminado").Value = True
            Next
        Else
            For Each row As DataGridViewRow In DgvPacasClasificacion1.Rows
                index = Convert.ToUInt64(row.Index)
                DgvPacasClasificacion1.Rows(index).Cells("FlagTerminado").Value = False
            Next
        End If
    End Sub

    Private Sub BtRevisarClases_Click(sender As Object, e As EventArgs) Handles BtRevisarClases.Click
        IdentificaColor()
    End Sub
End Class