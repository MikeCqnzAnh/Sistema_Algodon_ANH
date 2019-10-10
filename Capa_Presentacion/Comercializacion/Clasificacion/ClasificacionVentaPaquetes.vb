Imports Capa_Operacion.Configuracion
Imports System.IO
Imports System.Data.OleDb
Public Class ClasificacionVentaPaquetes
    Private TablaClasificacionGrid, TablaClasificacionGlobal As New DataTable
    Private PlantaVerifica As String
    Private IdPaqueteEncabezadoVerifica As Integer
    Private Sub ClasificacionVentaPaquetes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaCombos()
        propiedadesDgv1()
        CreaTabla()
        Limpiar()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
    End Sub
    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Consultar()
    End Sub
    Private Sub BtIgualarClasificacion_Click(sender As Object, e As EventArgs) Handles BtIgualarClasificacion.Click
        Consultar()
    End Sub
    Private Sub BtRevisarClases_Click(sender As Object, e As EventArgs) Handles BtRevisarClases.Click
        IdentificaColor()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub MarcaSeleccion()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        For i As Integer = 0 To DgvPacasClasificacion1.Rows.Count - 1
            Dim Seleccion As Boolean = CType(Me.DgvPacasClasificacion1.Rows(i).Cells("Sel").EditedFormattedValue, Boolean)

            EntidadClasificacionVentaPaquetes.Actualiza = Actuliza.ActualizaSeleccion
            EntidadClasificacionVentaPaquetes.IdPaquete = TbIdPaquete.Text
            EntidadClasificacionVentaPaquetes.NumeroPaca = DgvPacasClasificacion1.Rows(i).Cells("BaleID").Value
            EntidadClasificacionVentaPaquetes.Seleccion = Seleccion
            NegocioClasificacionVentaPaquetes.Actualizar(EntidadClasificacionVentaPaquetes)
        Next
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
        '----Compradores
        Dim EntidadCompradores As New Capa_Entidad.Compradores
        Dim NegocioCompradores As New Capa_Negocio.Compradores
        Dim Tabla3 As New DataTable
        EntidadCompradores.Consulta = Consulta.ConsultaBasica
        NegocioCompradores.Consultar(EntidadCompradores)
        Tabla3 = EntidadCompradores.TablaConsulta
        CbComprador.DataSource = Tabla3
        CbComprador.ValueMember = "IdComprador"
        CbComprador.DisplayMember = "Nombre"
        CbComprador.SelectedIndex = -1
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
        TbNoPaca.Text = ""
        CbPlanta.SelectedValue = 1
        CbClases.SelectedValue = 1
        CbEstatus.SelectedValue = 1
        chkfinalizado.Checked = False
        TbDescripcion.Text = ""
        TbCantidadPacas.Text = ""
        NuPromedioUI.Value = 0
        DgvPacasClasificacion1.Enabled = True
        TbEntrega.Text = ""
        CbComprador.SelectedIndex = -1
    End Sub
    Private Sub CreaTabla()
        TablaClasificacionGrid.Columns.Clear()
        TablaClasificacionGrid.Columns.Add(New DataColumn("IdHviDetalle", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("IdOrdenTrabajo", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("BaleID", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("BaleGroup", System.Type.GetType("System.String")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Operator", System.Type.GetType("System.String")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Date", System.Type.GetType("System.DateTime")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Temperature", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Humidity", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Amount", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("UHML", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("UI", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Strength", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Elongation", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("SFI", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Maturity", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Grade", System.Type.GetType("System.String")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Moist", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Mic", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Rd", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Plusb", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("ColorGrade", System.Type.GetType("System.String")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("TrashCount", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("TrashArea", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("TrashID", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("SCI", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Nep", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("UV", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("FlagTerminado", System.Type.GetType("System.Boolean")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("EstatusCompra", System.Type.GetType("System.Boolean")))
    End Sub
    Private Sub ContarPacas()
        TbCantidadPacas.Text = DgvPacasClasificacion1.Rows.Count
    End Sub
    Private Sub GeneraPromedioUI()
        Dim Index As Integer
        Dim SumaUI As Double = 0
        If DgvPacasClasificacion1.Rows.Count > 0 Then
            For Each row As DataGridViewRow In DgvPacasClasificacion1.Rows
                Index = Convert.ToUInt64(row.Index)
                SumaUI += DgvPacasClasificacion1.Rows(Index).Cells("UI").Value
            Next
            NuPromedioUI.Value = SumaUI / DgvPacasClasificacion1.Rows.Count
        ElseIf DgvPacasClasificacion1.Rows.Count = 0 Then
            NuPromedioUI.Value = 0
        End If
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

            rengloninsertar("IdHviDetalle") = DgvPacasClasificacion1.Rows(index).Cells("IdHviDetalle").Value
            rengloninsertar("IdOrdenTrabajo") = DgvPacasClasificacion1.Rows(index).Cells("IdOrdenTrabajo").Value
            rengloninsertar("BaleID") = DgvPacasClasificacion1.Rows(index).Cells("BaleID").Value
            rengloninsertar("BaleGroup") = DgvPacasClasificacion1.Rows(index).Cells("BaleGroup").Value
            rengloninsertar("Operator") = DgvPacasClasificacion1.Rows(index).Cells("Operator").Value
            rengloninsertar("Date") = DgvPacasClasificacion1.Rows(index).Cells("Date").Value
            rengloninsertar("Temperature") = DgvPacasClasificacion1.Rows(index).Cells("Temperature").Value
            rengloninsertar("Humidity") = DgvPacasClasificacion1.Rows(index).Cells("Humidity").Value
            rengloninsertar("Amount") = DgvPacasClasificacion1.Rows(index).Cells("Amount").Value
            rengloninsertar("UHML") = DgvPacasClasificacion1.Rows(index).Cells("UHML").Value
            rengloninsertar("UI") = DgvPacasClasificacion1.Rows(index).Cells("UI").Value
            rengloninsertar("Strength") = DgvPacasClasificacion1.Rows(index).Cells("Strength").Value
            rengloninsertar("Elongation") = DgvPacasClasificacion1.Rows(index).Cells("Elongation").Value
            rengloninsertar("SFI") = DgvPacasClasificacion1.Rows(index).Cells("SFI").Value
            rengloninsertar("Maturity") = DgvPacasClasificacion1.Rows(index).Cells("Maturity").Value
            rengloninsertar("Grade") = DgvPacasClasificacion1.Rows(index).Cells("Grade").Value
            rengloninsertar("Moist") = DgvPacasClasificacion1.Rows(index).Cells("Moist").Value
            rengloninsertar("Mic") = DgvPacasClasificacion1.Rows(index).Cells("Mic").Value
            rengloninsertar("Rd") = DgvPacasClasificacion1.Rows(index).Cells("Rd").Value
            rengloninsertar("Plusb") = DgvPacasClasificacion1.Rows(index).Cells("Plusb").Value
            rengloninsertar("ColorGrade") = DgvPacasClasificacion1.Rows(index).Cells("ColorGrade").Value
            rengloninsertar("TrashCount") = DgvPacasClasificacion1.Rows(index).Cells("TrashCount").Value
            rengloninsertar("TrashArea") = DgvPacasClasificacion1.Rows(index).Cells("TrashArea").Value
            rengloninsertar("TrashID") = DgvPacasClasificacion1.Rows(index).Cells("TrashID").Value
            rengloninsertar("SCI") = DgvPacasClasificacion1.Rows(index).Cells("SCI").Value
            rengloninsertar("Nep") = DgvPacasClasificacion1.Rows(index).Cells("Nep").Value
            rengloninsertar("UV") = DgvPacasClasificacion1.Rows(index).Cells("UV").Value
            rengloninsertar("FlagTerminado") = DgvPacasClasificacion1.Rows(index).Cells("FlagTerminado").Value
            rengloninsertar("EstatusCompra") = 1

            TablaClasificacionGrid.Rows.Add(rengloninsertar)
        Next
        TablaClasificacionGlobal = TablaClasificacionGrid
    End Sub
    Private Sub TextBox_PreviewKeyDown(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DgvPacasClasificacion1.CellEndEdit
        Dim GradoColor As String = Convert.ToString(DgvPacasClasificacion1.CurrentRow.Cells("ColorGrade").Value)
        Dim TrashId As Integer = DgvPacasClasificacion1.CurrentRow.Cells("TrashID").Value
        Dim ResultadoSCI As Integer = 0
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla2 As New DataTable
        DgvPacasClasificacion1.CurrentRow.Cells("SCI").Value = CalculaSCI(ResultadoSCI)
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
                DgvPacasClasificacion1.CurrentRow.Cells("Grade").Value = Tabla2.Rows(0).Item("ClaveCorta")
                IdentificaColor()
                Exit Sub
            End If
        Else
            Exit Sub
        End If
    End Sub
    Private Function CalculaSCI(ByVal ResultadoSCI As Integer)
        ResultadoSCI = -414.67 + 2.9 * DgvPacasClasificacion1.CurrentRow.Cells("Strength").Value - 9.32 * DgvPacasClasificacion1.CurrentRow.Cells("Mic").Value + 49.17 * DgvPacasClasificacion1.CurrentRow.Cells("UHML").Value + 4.74 * DgvPacasClasificacion1.CurrentRow.Cells("UI").Value + 0.65 * DgvPacasClasificacion1.CurrentRow.Cells("RD").Value + 0.36 * DgvPacasClasificacion1.CurrentRow.Cells("PLUSB").Value
        Return ResultadoSCI
    End Function
    Private Sub TbNoPaca_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbNoPaca.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If TbNoPaca.Text <> "" And TbIdPaquete.Text <> "" Then
                    If ExistePacaProduccion(TbNoPaca.Text) = False Then
                        MsgBox("Paca " & TbNoPaca.Text & " no existe en produccion, revisa el ID capturado.")
                        TbNoPaca.Text = ""
                    ElseIf ExistePacaHVI(TbNoPaca.Text) = False Then
                        MsgBox("Paca " & TbNoPaca.Text & " no existe en HVI, revisa el ID capturado.")
                        TbNoPaca.Text = ""
                    ElseIf VerificaPacaPlanta(TbNoPaca.Text) = True Then
                        Dim resultPlanta As Integer = MessageBox.Show("Paca " & TbNoPaca.Text & " pertenece a " & PlantaVerifica & "¿Deseas moverla a planta actual seleccionada?.", "Aviso", MessageBoxButtons.YesNo)
                        If resultPlanta = DialogResult.Yes Then
                            If ExistePacaPaquete(TbNoPaca.Text) = True And TbIdPaquete.Text <> IdPaqueteEncabezadoVerifica Then
                                Dim resultPaca As Integer = MessageBox.Show("Paca " & TbNoPaca.Text & " existe en paquete " & IdPaqueteEncabezadoVerifica & " ¿Desea moverla a paquete " & TbIdPaquete.Text & " actual?", "Aviso", MessageBoxButtons.YesNo)
                                If resultPaca = DialogResult.Yes Then
                                    ActualizaPaca()
                                    InsertaPaca()
                                    Guardar()
                                    'MessageBox.Show("El paquete ha sido actualizado!")
                                    TbNoPaca.Text = ""
                                ElseIf resultPaca = DialogResult.No Then
                                    TbNoPaca.Text = ""
                                End If
                            ElseIf ExistePacaPaquete(TbNoPaca.Text) = True And TbIdPaquete.Text = IdPaqueteEncabezadoVerifica Then
                                MessageBox.Show("La Paca No " & TbNoPaca.Text & " ya existe en el paquete actual.")
                                TbNoPaca.Text = ""
                            End If
                        ElseIf resultPlanta = DialogResult.No Then
                            TbNoPaca.Text = ""
                        End If
                    ElseIf ExistePacaPaquete(TbNoPaca.Text) = True And TbIdPaquete.Text <> IdPaqueteEncabezadoVerifica Then
                        Dim result As Integer = MessageBox.Show("Paca " & TbNoPaca.Text & " existe en paquete " & IdPaqueteEncabezadoVerifica & "  ¿Desea moverla a paquete " & TbIdPaquete.Text & " actual?", "Aviso", MessageBoxButtons.YesNo)
                        If result = DialogResult.Yes Then
                            ActualizaPaca()
                            InsertaPaca()
                            Guardar()
                            ' MessageBox.Show("El paquete ha sido actualizado!")
                            TbNoPaca.Text = ""
                        ElseIf result = DialogResult.No Then
                            TbNoPaca.Text = ""
                        End If
                    ElseIf ExistePacaPaquete(TbNoPaca.Text) = True And TbIdPaquete.Text = IdPaqueteEncabezadoVerifica Then
                        MessageBox.Show("La Paca No " & TbNoPaca.Text & " ya existe en el paquete actual.")
                        TbNoPaca.Text = ""
                    Else
                        InsertaPaca()
                        Guardar()
                        TbNoPaca.Text = ""
                    End If
                Else
                    MsgBox("Ingrese el ID...")
                    TbIdPaquete.Text = ""
                    TbNoPaca.Text = ""
                    Exit Sub
                End If
        End Select
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
            DgvPacasClasificacion1.Rows.Add(Tabla.Rows(0).Item("IdHviDetalle"), Tabla.Rows(0).Item("IdOrdenTrabajo"), Tabla.Rows(0).Item("BaleID"), Tabla.Rows(0).Item("BaleGroup"), Tabla.Rows(0).Item("Operator"), Tabla.Rows(0).Item("Date"), Tabla.Rows(0).Item("Temperature"), Tabla.Rows(0).Item("Humidity"), Tabla.Rows(0).Item("Amount"), Tabla.Rows(0).Item("UHML"), Tabla.Rows(0).Item("UI"), Tabla.Rows(0).Item("Strength"), Tabla.Rows(0).Item("Elongation"), Tabla.Rows(0).Item("SFI"), Tabla.Rows(0).Item("Maturity"), Tabla.Rows(0).Item("Grade"), Tabla.Rows(0).Item("Moist"), Tabla.Rows(0).Item("Mic"), Tabla.Rows(0).Item("Rd"), Tabla.Rows(0).Item("Plusb"), Tabla.Rows(0).Item("ColorGrade"), Tabla.Rows(0).Item("TrashCount"), Tabla.Rows(0).Item("TrashArea"), Tabla.Rows(0).Item("TrashID"), Tabla.Rows(0).Item("SCI"), Tabla.Rows(0).Item("Nep"), Tabla.Rows(0).Item("UV"), Tabla.Rows(0).Item("FlagTerminado"))
        Else
            MsgBox("El numero de paca ya se encuentra registrado.")
        End If
        DgvPacasClasificacion1.Sort(DgvPacasClasificacion1.Columns("BaleID"), System.ComponentModel.ListSortDirection.Descending)
        ContarPacas()
        IdentificaColor()
        GeneraPromedioUI()
    End Sub
    Private Sub IgualaClases()
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
            DgvPacasClasificacion1.Rows.Add(Tabla.Rows(0).Item("IdHviDetalle"), Tabla.Rows(0).Item("IdOrdenTrabajo"), Tabla.Rows(0).Item("BaleID"), Tabla.Rows(0).Item("BaleGroup"), Tabla.Rows(0).Item("Operator"), Tabla.Rows(0).Item("Date"), Tabla.Rows(0).Item("Temperature"), Tabla.Rows(0).Item("Humidity"), Tabla.Rows(0).Item("Amount"), Tabla.Rows(0).Item("UHML"), Tabla.Rows(0).Item("UI"), Tabla.Rows(0).Item("Strength"), Tabla.Rows(0).Item("Elongation"), Tabla.Rows(0).Item("SFI"), Tabla.Rows(0).Item("Maturity"), Tabla.Rows(0).Item("Grade"), Tabla.Rows(0).Item("Moist"), Tabla.Rows(0).Item("Mic"), Tabla.Rows(0).Item("Rd"), Tabla.Rows(0).Item("Plusb"), Tabla.Rows(0).Item("ColorGrade"), Tabla.Rows(0).Item("TrashCount"), Tabla.Rows(0).Item("TrashArea"), Tabla.Rows(0).Item("TrashID"), Tabla.Rows(0).Item("SCI"), Tabla.Rows(0).Item("Nep"), Tabla.Rows(0).Item("UV"), Tabla.Rows(0).Item("FlagTerminado"))
        Else
            MsgBox("El numero de paca ya se encuentra registrado.")
        End If
        DgvPacasClasificacion1.Sort(DgvPacasClasificacion1.Columns("BaleID"), System.ComponentModel.ListSortDirection.Descending)
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
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes.Eliminar = Eliminar.EliminaPacaSeleccionada
        EntidadClasificacionVentaPaquetes.IdPaquete = TbIdPaquete.Text
        NegocioClasificacionVentaPaquetes.Eliminar(EntidadClasificacionVentaPaquetes)
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
    Private Function IdentificaColor() As Integer
        Dim ContadorColor As Integer
        For Each fila As DataGridViewRow In DgvPacasClasificacion1.Rows
            If fila.Cells(15).Value.ToString <> CbClases.Text Then
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

            Dim colIdHviDetalle As New DataGridViewTextBoxColumn
            colIdHviDetalle.Name = "IdHviDetalle"
            'colIdHviDetalle.HeaderText = "No Paca"
            colIdHviDetalle.Visible = False
            DgvPacasClasificacion1.Columns.Insert(0, colIdHviDetalle)

            Dim colIdOrdenTrabajo As New DataGridViewTextBoxColumn
            colIdOrdenTrabajo.Name = "IdOrdenTrabajo"
            'colIdHviDetalle.HeaderText = "No Paca"
            colIdOrdenTrabajo.Visible = False
            DgvPacasClasificacion1.Columns.Insert(1, colIdOrdenTrabajo)

            Dim colBaleID As New DataGridViewTextBoxColumn
            colBaleID.Name = "BaleID"
            colBaleID.HeaderText = "No Paca"
            colBaleID.ReadOnly = True
            DgvPacasClasificacion1.Columns.Insert(2, colBaleID)

            Dim colBaleGroup As New DataGridViewTextBoxColumn
            colBaleGroup.Name = "BaleGroup"
            'colBaleGroup.HeaderText = "No Paca"
            colBaleGroup.Visible = False
            DgvPacasClasificacion1.Columns.Insert(3, colBaleGroup)

            Dim colOperator As New DataGridViewTextBoxColumn
            colOperator.Name = "Operator"
            'colBaleGroup.HeaderText = "No Paca"
            colOperator.Visible = False
            DgvPacasClasificacion1.Columns.Insert(4, colOperator)

            Dim colDate As New DataGridViewTextBoxColumn
            colDate.Name = "Date"
            colDate.Visible = False
            DgvPacasClasificacion1.Columns.Insert(5, colDate)

            Dim colTemperature As New DataGridViewTextBoxColumn
            colTemperature.Name = "Temperature"
            'colTemperature.HeaderText = "No Paca"
            colTemperature.Visible = False
            DgvPacasClasificacion1.Columns.Insert(6, colTemperature)

            Dim colHumidity As New DataGridViewTextBoxColumn
            colHumidity.Name = "Humidity"
            'colHumidity.HeaderText = "No Paca"
            colHumidity.Visible = False
            DgvPacasClasificacion1.Columns.Insert(7, colHumidity)

            Dim colAmount As New DataGridViewTextBoxColumn
            colAmount.Name = "Amount"
            'colAmount.HeaderText = "No Paca"
            colAmount.Visible = False
            DgvPacasClasificacion1.Columns.Insert(8, colAmount)

            Dim colUHML As New DataGridViewTextBoxColumn
            colUHML.Name = "UHML"
            colUHML.HeaderText = "UHML"
            colUHML.ReadOnly = False
            DgvPacasClasificacion1.Columns.Insert(9, colUHML)

            Dim colUI As New DataGridViewTextBoxColumn
            colUI.Name = "UI"
            'colUI.HeaderText = "No Paca"
            colUI.ReadOnly = True
            DgvPacasClasificacion1.Columns.Insert(10, colUI)

            Dim colStrength As New DataGridViewTextBoxColumn
            colStrength.Name = "Strength"
            colStrength.HeaderText = "Resistencia"
            colStrength.ReadOnly = False
            DgvPacasClasificacion1.Columns.Insert(11, colStrength)

            Dim colElongation As New DataGridViewTextBoxColumn
            colElongation.Name = "Elongation"
            'colElongation.HeaderText = "No Paca"
            colElongation.Visible = False
            DgvPacasClasificacion1.Columns.Insert(12, colElongation)

            Dim colSFI As New DataGridViewTextBoxColumn
            colSFI.Name = "SFI"
            'colSFI.HeaderText = "No Paca"
            colSFI.Visible = False
            DgvPacasClasificacion1.Columns.Insert(13, colSFI)

            Dim colMaturity As New DataGridViewTextBoxColumn
            colMaturity.Name = "Maturity"
            'colMaturity.HeaderText = "No Paca"
            colMaturity.Visible = False
            DgvPacasClasificacion1.Columns.Insert(14, colMaturity)

            Dim colGrade As New DataGridViewTextBoxColumn
            colGrade.Name = "Grade"
            'colGrade.HeaderText = "No Paca"
            colGrade.Visible = False
            'colGrade.ReadOnly = True
            DgvPacasClasificacion1.Columns.Insert(15, colGrade)

            Dim colMoist As New DataGridViewTextBoxColumn
            colMoist.Name = "Moist"
            'colMoist.HeaderText = "No Paca"
            colMoist.Visible = False
            DgvPacasClasificacion1.Columns.Insert(16, colMoist)

            Dim colMic As New DataGridViewTextBoxColumn
            colMic.Name = "Mic"
            colMic.HeaderText = "Micros"
            'colMic.Visible = False
            DgvPacasClasificacion1.Columns.Insert(17, colMic)

            Dim colRd As New DataGridViewTextBoxColumn
            colRd.Name = "Rd"
            'colRd.HeaderText = "No Paca"
            colRd.Visible = False
            DgvPacasClasificacion1.Columns.Insert(18, colRd)

            Dim colPlusb As New DataGridViewTextBoxColumn
            colPlusb.Name = "Plusb"
            'colPlusb.HeaderText = "No Paca"
            colPlusb.Visible = False
            DgvPacasClasificacion1.Columns.Insert(19, colPlusb)

            Dim colColorGrade As New DataGridViewTextBoxColumn
            colColorGrade.Name = "ColorGrade"
            colColorGrade.HeaderText = "Color Grade"
            colColorGrade.ReadOnly = False
            DgvPacasClasificacion1.Columns.Insert(20, colColorGrade)

            Dim colTrashCount As New DataGridViewTextBoxColumn
            colTrashCount.Name = "TrashCount"
            'colTrashCount.HeaderText = "No Paca"
            colTrashCount.Visible = False
            DgvPacasClasificacion1.Columns.Insert(21, colTrashCount)

            Dim colTrashArea As New DataGridViewTextBoxColumn
            colTrashArea.Name = "TrashArea"
            'colTrashArea.HeaderText = "No Paca"
            colTrashArea.Visible = False
            DgvPacasClasificacion1.Columns.Insert(22, colTrashArea)

            Dim colTrashID As New DataGridViewTextBoxColumn
            colTrashID.Name = "TrashID"
            colTrashID.HeaderText = "Trash ID"
            colTrashID.ReadOnly = False
            DgvPacasClasificacion1.Columns.Insert(23, colTrashID)

            Dim colSCI As New DataGridViewTextBoxColumn
            colSCI.Name = "SCI"
            'colSCI.HeaderText = "No Paca"
            colSCI.ReadOnly = True
            DgvPacasClasificacion1.Columns.Insert(24, colSCI)

            Dim colNep As New DataGridViewTextBoxColumn
            colNep.Name = "Nep"
            'colNep.HeaderText = "No Paca"
            colNep.Visible = False
            DgvPacasClasificacion1.Columns.Insert(25, colNep)

            Dim colUV As New DataGridViewTextBoxColumn
            colUV.Name = "UV"
            'colUV.HeaderText = "No Paca"
            colUV.Visible = False
            DgvPacasClasificacion1.Columns.Insert(26, colUV)

            Dim colFlagTerminado As New DataGridViewCheckBoxColumn
            colFlagTerminado.Name = "FlagTerminado"
            'colFlagTerminado.HeaderText = "No Paca"
            colFlagTerminado.Visible = False
            DgvPacasClasificacion1.Columns.Insert(27, colFlagTerminado)

            Dim colEstatusCompra As New DataGridViewCheckBoxColumn
            colEstatusCompra.Name = "EstatusCompra"
            'colEstatusCompra.HeaderText = "No Paca"
            colEstatusCompra.Visible = False
            DgvPacasClasificacion1.Columns.Insert(28, colEstatusCompra)

            Dim colSel As New DataGridViewCheckBoxColumn()
            colSel.Name = "Sel"
            DgvPacasClasificacion1.Columns.Insert(29, colSel)

        End If
    End Sub
    Private Sub EliminarPacasSeleccionadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPacasSeleccionadasToolStripMenuItem.Click
        MarcaSeleccion()
        EliminarRegistro()
        Consultar()
        Guardar()
    End Sub
    Private Sub Guardar()
        'If DgvPacasClasificacion11.RowCount > 0 Then
        'If TbIdPaquete.Text <> "" Then
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        If IdentificaColor() > 0 And chkfinalizado.Checked = True Then
            MsgBox("Por favor, verificar que los datos esten correctos.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
        Else
            EntidadClasificacionVentaPaquetes.IdPaquete = IIf(TbIdPaquete.Text = "", 0, TbIdPaquete.Text)
            EntidadClasificacionVentaPaquetes.IdPlanta = CbPlanta.SelectedValue
            EntidadClasificacionVentaPaquetes.IdComprador = CbComprador.SelectedValue
            EntidadClasificacionVentaPaquetes.IdClase = CbClases.SelectedValue
            EntidadClasificacionVentaPaquetes.CantidadPacas = TbCantidadPacas.Text
            EntidadClasificacionVentaPaquetes.Descripcion = CbClases.Text & "-" & TbIdPaquete.Text
            EntidadClasificacionVentaPaquetes.Entrega = TbEntrega.Text
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
            'DgvPacasClasificacion11.Enabled = False
        End If
        'Else
        '    MsgBox("El campo No Paca esta vacio, no se puede guardar informacion!", MsgBoxStyle.Information, "Aviso")
        'End If
        'Else
        '    MsgBox("No hay datos para guardar.", MsgBoxStyle.Exclamation)
        'End If
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
                CbComprador.SelectedValue = Tabla.Rows(0).Item("IdComprador")
                CbClases.SelectedValue = Tabla.Rows(0).Item("IdClase")
                TbCantidadPacas.Text = Tabla.Rows(0).Item("CantidadPacas")
                TbDescripcion.Text = Tabla.Rows(0).Item("Descripcion")
                TbEntrega.Text = Tabla.Rows(0).Item("Entrega")
                chkfinalizado.Checked = Tabla.Rows(0).Item("chkrevisado")
                CbEstatus.SelectedValue = Tabla.Rows(0).Item("IdEstatus")
                EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPorId
                EntidadClasificacionVentaPaquetes.IdPaquete = CInt(TbIdPaquete.Text)
                NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
                Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
                For i As Integer = 0 To Tabla.Rows.Count - 1
                    DgvPacasClasificacion1.Rows.Add(Tabla.Rows(i).Item("IdHviDetalle"), Tabla.Rows(i).Item("IdOrdenTrabajo"), Tabla.Rows(i).Item("BaleID"), Tabla.Rows(i).Item("BaleGroup"), Tabla.Rows(i).Item("Operator"), Tabla.Rows(i).Item("Date"), Tabla.Rows(i).Item("Temperature"), Tabla.Rows(i).Item("Humidity"), Tabla.Rows(i).Item("Amount"), Tabla.Rows(i).Item("UHML"), Tabla.Rows(i).Item("UI"), Tabla.Rows(i).Item("Strength"), Tabla.Rows(i).Item("Elongation"), Tabla.Rows(i).Item("SFI"), Tabla.Rows(i).Item("Maturity"), Tabla.Rows(i).Item("Grade"), Tabla.Rows(i).Item("Moist"), Tabla.Rows(i).Item("Mic"), Tabla.Rows(i).Item("Rd"), Tabla.Rows(i).Item("Plusb"), Tabla.Rows(i).Item("ColorGrade"), Tabla.Rows(i).Item("TrashCount"), Tabla.Rows(i).Item("TrashArea"), Tabla.Rows(i).Item("TrashID"), Tabla.Rows(i).Item("SCI"), Tabla.Rows(i).Item("Nep"), Tabla.Rows(i).Item("UV"), Tabla.Rows(i).Item("FlagTerminado"))
                Next
            Else
                MsgBox("No se encontraron registros con esos criterios.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                TbIdPaquete.Enabled = True
                TbIdPaquete.Text = ""
            End If
            GeneraPromedioUI()
        Else
            MsgBox("Por favor, verificar que los datos esten correctos.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
        End If
        DgvPacasClasificacion1.Sort(DgvPacasClasificacion1.Columns("BaleID"), System.ComponentModel.ListSortDirection.Descending)
        IdentificaColor()
        If chkfinalizado.Checked = True Then DgvPacasClasificacion1.Enabled = False
        desmarcaCheck()
        ContarPacas()
    End Sub
    Private Sub chkfinalizado_CheckedChanged(sender As Object, e As EventArgs) Handles chkfinalizado.CheckedChanged
        Dim index As Integer
        If chkfinalizado.Checked = True Then
            For Each row As DataGridViewRow In DgvPacasClasificacion1.Rows
                index = Convert.ToUInt64(row.Index)
                DgvPacasClasificacion1.Rows(index).Cells("FlagTerminado").Value = True
            Next
        Else
            For Each row As DataGridViewRow In DgvPacasClasificacion1.Rows
                index = Convert.ToUInt64(row.Index)
                DgvPacasClasificacion1.Rows(index).Cells("FlagTerminado").Value = False
            Next
        End If
    End Sub
    Function ExistePacaProduccion(ByVal IdPaca As Integer) As Boolean
        Dim Tabla As New DataTable
        Dim resultado As Boolean
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPacaExisteProduccion
        EntidadClasificacionVentaPaquetes.NumeroPaca = IdPaca
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        resultado = Tabla.Rows(0).Item("ExistePaca")
        Return resultado
    End Function
    Function ExistePacaHVI(ByVal IdPaca As Integer) As Boolean
        Dim Tabla As New DataTable
        Dim resultado As Boolean
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPacaExisteHVI
        EntidadClasificacionVentaPaquetes.NumeroPaca = IdPaca
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        resultado = Tabla.Rows(0).Item("ExistePaca")
        Return resultado
    End Function
    Function VerificaPacaPlanta(ByVal IdPaca As Integer) As Boolean
        Dim Tabla As New DataTable
        Dim Resultado As Boolean
        PlantaVerifica = ""
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPacaPlanta
        EntidadClasificacionVentaPaquetes.NumeroPaca = IdPaca
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        If CbPlanta.SelectedValue <> Tabla.Rows(0).Item("IdPlantaOrigen") Then
            Resultado = True
            PlantaVerifica = Tabla.Rows(0).Item("Descripcion")
        Else
            Resultado = False
        End If
        Return Resultado
    End Function
    Function ExistePacaPaquete(ByVal IdPaca As Integer) As Boolean
        Dim Tabla As New DataTable
        Dim Resultado As Boolean
        IdPaqueteEncabezadoVerifica = 0
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPacaExistePaquete
        EntidadClasificacionVentaPaquetes.NumeroPaca = IdPaca
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        If CBool(Tabla.Rows(0).Item("ExistePaca")) = True Then
            Resultado = True
            IdPaqueteEncabezadoVerifica = Tabla.Rows(0).Item("IdPaqueteEncabezado")
        End If
        Return Resultado
    End Function

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        VarGlob2.TablaExporta = Datagridtotable(DgvPacasClasificacion1)
        'VarGlob2.DgvExportaExcel.DataSource = DgvPacasClasificacion1
        RepClasificacion.ShowDialog()
    End Sub

    Private Function Datagridtotable(ByVal DgvExporta As DataGridView)
        Dim dt As New DataTable
        Dim r As DataRow

        dt.Columns.Add("BaleID", Type.GetType("System.Int32"))
        dt.Columns.Add("SCI", Type.GetType("System.Single"))
        dt.Columns.Add("Grade", Type.GetType("System.String"))
        dt.Columns.Add("Moist", Type.GetType("System.Single"))
        dt.Columns.Add("Mic", Type.GetType("System.Single"))
        dt.Columns.Add("Maturity", Type.GetType("System.Single"))
        dt.Columns.Add("UHML", Type.GetType("System.Single"))
        dt.Columns.Add("UI", Type.GetType("System.Single"))
        dt.Columns.Add("SFI", Type.GetType("System.Single"))
        dt.Columns.Add("Strength", Type.GetType("System.Single"))
        dt.Columns.Add("Elongation", Type.GetType("System.Single"))
        dt.Columns.Add("RD", Type.GetType("System.Single"))
        dt.Columns.Add("PlusB", Type.GetType("System.Single"))
        dt.Columns.Add("ColorGrade", Type.GetType("System.String"))
        dt.Columns.Add("TrashCount", Type.GetType("System.Int32"))
        dt.Columns.Add("TrashArea", Type.GetType("System.Single"))
        dt.Columns.Add("TrashID", Type.GetType("System.Int32"))
        dt.Columns.Add("Amount", Type.GetType("System.Int32"))

        For i = 0 To DgvExporta.Rows.Count - 1
            r = dt.NewRow
            r("BaleID") = DgvExporta.Item("BaleID", i).Value.ToString
            r("SCI") = DgvExporta.Item("SCI", i).Value.ToString
            r("Grade") = DgvExporta.Item("Grade", i).Value.ToString
            r("Moist") = DgvExporta.Item("Moist", i).Value.ToString
            r("Mic") = DgvExporta.Item("Mic", i).Value.ToString
            r("Maturity") = DgvExporta.Item("Maturity", i).Value.ToString
            r("UHML") = DgvExporta.Item("UHML", i).Value.ToString
            r("UI") = DgvExporta.Item("UI", i).Value.ToString
            r("SFI") = DgvExporta.Item("SFI", i).Value.ToString
            r("Strength") = DgvExporta.Item("Strength", i).Value.ToString
            r("Elongation") = DgvExporta.Item("Elongation", i).Value.ToString
            r("RD") = DgvExporta.Item("RD", i).Value.ToString
            r("PlusB") = DgvExporta.Item("PlusB", i).Value.ToString
            r("ColorGrade") = DgvExporta.Item("ColorGrade", i).Value.ToString
            r("TrashCount") = DgvExporta.Item("TrashCount", i).Value.ToString
            r("TrashArea") = DgvExporta.Item("TrashArea", i).Value.ToString
            r("TrashID") = DgvExporta.Item("TrashID", i).Value.ToString
            r("Amount") = DgvExporta.Item("Amount", i).Value.ToString
            dt.Rows.Add(r)
        Next
        Return dt
    End Function

    Private Function Clonar_DGV(ByVal pDgv As DataGridView) As DataGridView
        Dim dg2 As New DataGridView
        With pDgv
            For n As Integer = 0 To .ColumnCount - 1
                dg2.Columns.Insert(n, .Columns(n).Clone)
            Next
            For m As Integer = 0 To .Rows.Count - 1
                dg2.Rows.Add()
                For n2 As Integer = 0 To .ColumnCount - 1
                    dg2.Rows(m).Cells(n2).Value = .Rows(m).Cells(n2).Value
                Next
            Next
            dg2.Location = New Point(.Right + 10, .Location.Y)
        End With
        Return dg2
    End Function

    Private Sub ArchivoAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivoAccessToolStripMenuItem.Click
        Dim RutaPlantilla As String = "C:\Users\MSISTEMAS\Desktop\Desarrollo\Sistema_Algodon_ANH\Capa_Presentacion\Reportes\RPT\BaseHVI.mdb"
        Dim RutaCopiar As String = "c:\datos\HVI_" & CbClases.Text & "_" & TbIdPaquete.Text & ".mdb"
        If DgvPacasClasificacion1.RowCount > 0 Then
            If File.Exists(RutaCopiar) Then
                Dim opc As DialogResult = MsgBox("El Archivo ya existe, ¿Desea reemplazarlo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")
                If opc = DialogResult.Yes Then
                    File.Copy(RutaPlantilla, RutaCopiar, True)
                    ExportarExcel(RutaCopiar)
                ElseIf opc = DialogResult.No Then

                End If
            Else
                File.Copy(RutaPlantilla, RutaCopiar, True)
                ExportarExcel(RutaCopiar)
            End If
        Else
            MsgBox("No hay registros para exportar.")
        End If
        'Dim RutaPlantilla As String = Application.StartupPath & "\Reportes\RPT\BaseHVI.mdb"
    End Sub
    Private Sub ExportarExcel(ByVal RutaCopiar As String)
        ':::Declaramos nuestra variable Sql que almacenara nuestra consuta
        Dim Sql As String = ""
        Dim Con3 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" & RutaCopiar & "")
        ':::Usamos un ciclo For Each para recorrer nuestro DataGridView llamado DGTabla
        For Each Row As DataGridViewRow In DgvPacasClasificacion1.Rows
            ':::Obtenemos los valores que vamos a pasar a nuestra consulta para ser guardados
            Dim LotID As String = TbDescripcion.Text
            Dim BaleID As String = Row.Cells("BaleID").Value
            Dim BaleGroup As String = Row.Cells("BaleGroup").Value
            Dim Operator1 As String = "Operator1"
            Dim Date1 As DateTime = Row.Cells("Date").Value
            Dim Temperature As Double = Row.Cells("Temperature").Value
            Dim Humidity As Double = Row.Cells("Humidity").Value
            Dim Amount As Double = Row.Cells("Amount").Value
            Dim UHML As Double = Row.Cells("UHML").Value
            Dim UI As Double = Row.Cells("UI").Value
            Dim Strength As Double = Row.Cells("Strength").Value
            Dim Elongation As Double = Row.Cells("Elongation").Value
            Dim SFI As Double = Row.Cells("SFI").Value
            Dim Maturity As Double = Row.Cells("Maturity").Value
            Dim Grade As String = Row.Cells("Grade").Value
            Dim Moist As Double = Row.Cells("Moist").Value
            Dim Mic As Double = Row.Cells("Mic").Value
            Dim Rd As Double = Row.Cells("Rd").Value
            Dim PlusB As Double = Row.Cells("PlusB").Value
            Dim ColorGrade As String = Row.Cells("ColorGrade").Value
            Dim TrashCount As Double = Row.Cells("TrashCount").Value
            Dim TrashArea As Double = Row.Cells("TrashArea").Value
            Dim TrashID As Double = Row.Cells("TrashID").Value
            Dim SCI As Double = Row.Cells("SCI").Value
            Dim Nep As Double = IIf(IsDBNull(Row.Cells("Nep").Value), 0, Row.Cells("Nep").Value)
            Dim UV As Double = IIf(IsDBNull(Row.Cells("UV").Value), 0, Row.Cells("UV").Value)

            ':::Creamos nuestra consulta de tipo Insert y le pasamos nuestros valores
            Sql = "Insert into SystemTestData (LotID, BaleID, BaleGroup, Operator,[Date],Temperature,Humidity,Amount,UHML,UI,Strength,Elongation,SFI,Maturity,Grade,Moist,Mic,Rd,PlusB,ColorGrade,TrashCount,TrashArea,TrashID,SCI,Nep,UV) values ('" & LotID & "', '" & BaleID & "', '" & BaleGroup & "', '" & Operator1 & "', '" & Date1 & "', '" & Temperature & "', '" & Humidity & "', '" & Amount & "', '" & UHML & "', '" & UI & "', '" & Strength & "', '" & Elongation & "', '" & SFI & "', '" & Maturity & "', '" & Grade & "', '" & Moist & "', '" & Mic & "', '" & Rd & "', '" & PlusB & "', '" & ColorGrade & "', '" & TrashCount & "', '" & TrashArea & "', '" & TrashID & "', '" & SCI & "', '" & Nep & "', '" & UV & "')"
            ':::Llamamos el procedimiento que hemos creado en el modulo y le pasamos el parametro que es la consulta SQL

            Exportar_Access(Sql, Con3)
        Next

        MsgBox("Registros exportados exitosamente", MsgBoxStyle.Information, "Exportar")
        'LblTotal.Text = "Total registros exportados: " & DgvPacasClasificacion1.RowCount
    End Sub
    Sub Exportar_Access(ByVal Sql As String, ByVal Con3 As OleDbConnection)
        ':::Declaramos nuestro objeto de tipo OleDbCommand para ejecutar la consulta
        Dim cmd As New OleDbCommand(Sql, Con3)
        Try
            Con3.Open()
            cmd.ExecuteNonQuery()
            Con3.Close()
        Catch ex As Exception
            MsgBox("No se pueden guardar los registro por: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub ValidaNumeros(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbIdPaquete.KeyPress, TbNoPaca.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class