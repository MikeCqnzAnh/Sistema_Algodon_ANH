Imports Capa_Operacion.Configuracion
Imports System.IO
Imports System.Data.OleDb
Public Class VentaClasificacion
    Private TablaClasificacionGrid, TablaClasificacionGlobal As New DataTable
    Private PlantaVerifica As String
    Private IdPaqueteEncabezadoVerifica As Integer
    Private Sub VentaClasificacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaCombos()
        propiedadesDgv()
        RevisaUsuario()
        CreaTabla()
        Limpiar()
    End Sub
    Private Sub RevisaUsuario()
        If TipoUsuario = "GERENTE LABORATORIO" Or TipoUsuario = "GERENTE" Or TipoUsuario = "ADMINISTRADOR" Then
            DesactivaCampos()
            BtIgualarClasificacion.Visible = True
        Else
            DesactivaCampos()
        End If
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        If DgvPacasClasificacion.Rows.Count > 0 Then
            Dim opc As DialogResult = MsgBox("¿Desea guardar el paquete actual?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Guardar")
            If opc = DialogResult.Yes Then
                Guardar()
                DgvPacasClasificacion.Columns.Clear()
                propiedadesDgv()
                Limpiar()
            ElseIf opc = DialogResult.no Then
                DgvPacasClasificacion.Columns.Clear()
                propiedadesDgv()
                Limpiar()
            End If
        Else
            DgvPacasClasificacion.Columns.Clear()
            propiedadesDgv()
            Limpiar()
        End If
    End Sub
    Private Sub ActivaCampos()
        DgvPacasClasificacion.Columns("BaleID").ReadOnly = True
        DgvPacasClasificacion.Columns("UHML").ReadOnly = False
        DgvPacasClasificacion.Columns("UI").ReadOnly = True
        DgvPacasClasificacion.Columns("Strength").ReadOnly = False
        DgvPacasClasificacion.Columns("Mic").ReadOnly = False
        DgvPacasClasificacion.Columns("ColorGrade").ReadOnly = False
        DgvPacasClasificacion.Columns("TrashID").ReadOnly = False
        DgvPacasClasificacion.Columns("SCI").ReadOnly = True
        DgvPacasClasificacion.Columns("sel").ReadOnly = False
    End Sub
    Private Sub DesactivaCampos()
        DgvPacasClasificacion.Columns("BaleID").ReadOnly = True
        DgvPacasClasificacion.Columns("UHML").ReadOnly = True
        DgvPacasClasificacion.Columns("UI").ReadOnly = True
        DgvPacasClasificacion.Columns("Strength").ReadOnly = True
        DgvPacasClasificacion.Columns("Mic").ReadOnly = True
        DgvPacasClasificacion.Columns("ColorGrade").ReadOnly = True
        DgvPacasClasificacion.Columns("TrashID").ReadOnly = True
        DgvPacasClasificacion.Columns("SCI").ReadOnly = True
        DgvPacasClasificacion.Columns("sel").ReadOnly = False
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
        CbPlanta.SelectedIndex = -1
        CbClases.SelectedIndex = -1
        CbEstatus.SelectedValue = 1
        'chkfinalizado.Checked = False
        TbDescripcion.Text = ""
        NuCantidadPacas.Value = 0
        NuPromedioUI.Value = 0
        DgvPacasClasificacion.Enabled = True
        TbEntrega.Text = ""
        CbComprador.SelectedIndex = -1
    End Sub
    Private Sub GuardarParaEliminar()
        If DgvPacasClasificacion.RowCount > 0 Then
            If CbPlanta.Text <> "" And CbClases.Text <> "" Then
                Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
                Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
                Try
                    EntidadClasificacionVentaPaquetes.IdPaquete = IIf(TbIdPaquete.Text = "", 0, TbIdPaquete.Text)
                    EntidadClasificacionVentaPaquetes.LotID = 0
                    EntidadClasificacionVentaPaquetes.IdPlanta = CbPlanta.SelectedValue
                    EntidadClasificacionVentaPaquetes.IdComprador = CbComprador.SelectedValue
                    EntidadClasificacionVentaPaquetes.IdClase = CbClases.SelectedValue
                    EntidadClasificacionVentaPaquetes.CantidadPacas = VerificaCheck()
                    EntidadClasificacionVentaPaquetes.Descripcion = CbClases.Text & "-" & TbIdPaquete.Text
                    EntidadClasificacionVentaPaquetes.Entrega = TbEntrega.Text
                    EntidadClasificacionVentaPaquetes.chkrevisado = False
                    EntidadClasificacionVentaPaquetes.IdEstatus = CbEstatus.SelectedValue
                    EntidadClasificacionVentaPaquetes.IdUsuarioCreacion = 1
                    EntidadClasificacionVentaPaquetes.FechaCreacion = Now
                    EntidadClasificacionVentaPaquetes.IdUsuarioActualizacion = 1
                    EntidadClasificacionVentaPaquetes.FechaActualizacion = Now
                    DataGridViewToTable()
                    EntidadClasificacionVentaPaquetes.TablaGeneral = TablaClasificacionGlobal
                    NegocioClasificacionVentaPaquetes.GuardarTablas(EntidadClasificacionVentaPaquetes)
                    TbIdPaquete.Text = EntidadClasificacionVentaPaquetes.IdPaquete
                    TbDescripcion.Text = CbClases.Text & "-" & TbIdPaquete.Text
                    For Each row As DataGridViewRow In DgvPacasClasificacion.Rows
                        If row.Cells(0).Value = True Then
                            EntidadClasificacionVentaPaquetes.Eliminar = Eliminar.EliminaPacaSeleccionada
                            EntidadClasificacionVentaPaquetes.IdPaquete = TbIdPaquete.Text
                            EntidadClasificacionVentaPaquetes.BaleID = row.Cells("BaleID").Value
                            NegocioClasificacionVentaPaquetes.Eliminar(EntidadClasificacionVentaPaquetes)
                            GeneraRegistroBitacora(Me.Text.Clone.ToString, "Eliminar Pacas Clasificacion", row.Cells("BaleID").Value, "LOTID= " & row.Cells("LOTID").Value & ", UHML= " & row.Cells("UHML").Value & ", UI= " & row.Cells("UI").Value & ", RESISTENCIA= " & row.Cells("Strength").Value & ", MICROS= " & row.Cells("Mic").Value & ", COLORGRADE= " & row.Cells("ColorGrade").Value & ", TRASH ID= " & row.Cells("TRASHID").Value & ", SCI= " & row.Cells("TRASHID").Value)
                        End If
                    Next
                Catch ex As Exception
                    MsgBox(ex)
                Finally
                    MsgBox("Pacas eliminadas con exito.")
                End Try
            Else
                MsgBox("Los campos Planta y Clase son requeridos para crear un paquete nuevo.")
                TbNoPaca.Select()
            End If
        Else
            MsgBox("No hay datos para guardar.", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Sub TbNoPaca_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbNoPaca.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If TbNoPaca.Text <> "" And CbPlanta.Text <> "" And CbClases.Text <> "" Then
                    If ExistePacaHVI(TbNoPaca.Text) = False Then
                        MsgBox("Paca " & TbNoPaca.Text & " no existe en HVI o en la planta seleccionada, revisa el ID capturado.")
                        TbNoPaca.Text = ""
                    ElseIf VerificaPacaPlanta(TbNoPaca.Text) = False Then
                        MessageBox.Show("Paca No " & TbNoPaca.Text & " no pertenece a planta " & CbPlanta.Text & ".", "Aviso")
                    ElseIf ExistePacaPaquete(TbNoPaca.Text) = True And Val(TbIdPaquete.Text) <> IdPaqueteEncabezadoVerifica Then
                        MessageBox.Show("Paca " & TbNoPaca.Text & " existe en paquete " & IdPaqueteEncabezadoVerifica & ".", "Aviso")
                        TbNoPaca.Text = ""
                    ElseIf ExistePacaPaquete(TbNoPaca.Text) = True And Val(TbIdPaquete.Text) = IdPaqueteEncabezadoVerifica Then
                        MessageBox.Show("La Paca No " & TbNoPaca.Text & " ya existe en el paquete actual.")
                        TbNoPaca.Text = ""
                    Else
                        InsertaPaca()
                        TbNoPaca.Text = ""
                    End If
                Else
                    MsgBox("Ingrese el campo Planta y Clase para continuar...")
                    TbIdPaquete.Text = ""
                    TbNoPaca.Text = ""
                    Exit Sub
                End If
        End Select
    End Sub
    Private Sub TbLotID_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbIdPaquete.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If TbIdPaquete.Text <> "" Then
                    If DgvPacasClasificacion.Rows.Count > 0 Then
                        Dim opc As DialogResult = MsgBox("¿Desea guardar el paquete actual?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Guardar")
                        If opc = DialogResult.Yes Then
                            Guardar()
                            TbIdPaquete.Enabled = False
                            Consultar()
                            TbNoPaca.Text = ""
                            TbNoPaca.Focus()
                        ElseIf opc = DialogResult.No Then
                            TbIdPaquete.Enabled = False
                            Consultar()
                            TbNoPaca.Text = ""
                            TbNoPaca.Focus()
                        End If
                    Else
                        TbIdPaquete.Enabled = False
                        Consultar()
                        TbNoPaca.Text = ""
                        TbNoPaca.Focus()
                    End If
                Else
                    MsgBox("Ingrese el ID del paquete...")
                    Exit Sub
                End If
        End Select
        ContarPacas()
    End Sub
    Private Sub propiedadesDgv()
        DgvPacasClasificacion.Columns.Clear()
        If DgvPacasClasificacion.Columns("BaleId") Is Nothing Then

            Dim colSel As New DataGridViewCheckBoxColumn()
            colSel.Name = "Sel"
            colSel.FalseValue = False
            colSel.TrueValue = True
            colSel.IndeterminateValue = False
            DgvPacasClasificacion.Columns.Insert(0, colSel)

            Dim colIdOrdenTrabajo As New DataGridViewTextBoxColumn
            colIdOrdenTrabajo.Name = "IdOrdenTrabajo"
            'colIdHviDetalle.HeaderText = "No Paca"
            colIdOrdenTrabajo.Visible = False
            DgvPacasClasificacion.Columns.Insert(1, colIdOrdenTrabajo)

            Dim colIdPlantaOrigen As New DataGridViewTextBoxColumn
            colIdPlantaOrigen.Name = "IdPlantaOrigen"
            colIdPlantaOrigen.HeaderText = "IdPlantaOrigen"
            colIdPlantaOrigen.Visible = False
            DgvPacasClasificacion.Columns.Insert(2, colIdPlantaOrigen)

            Dim colLotID As New DataGridViewTextBoxColumn
            colLotID.Name = "LotID"
            colLotID.HeaderText = "LotID"
            colLotID.ReadOnly = True
            DgvPacasClasificacion.Columns.Insert(3, colLotID)

            Dim colBaleID As New DataGridViewTextBoxColumn
            colBaleID.Name = "BaleID"
            colBaleID.HeaderText = "No Paca"
            colBaleID.ReadOnly = True
            DgvPacasClasificacion.Columns.Insert(4, colBaleID)

            Dim colBaleGroup As New DataGridViewTextBoxColumn
            colBaleGroup.Name = "BaleGroup"
            'colBaleGroup.HeaderText = "No Paca"
            colBaleGroup.Visible = False
            DgvPacasClasificacion.Columns.Insert(5, colBaleGroup)

            Dim colOperator As New DataGridViewTextBoxColumn
            colOperator.Name = "Operator"
            'colBaleGroup.HeaderText = "No Paca"
            colOperator.Visible = False
            DgvPacasClasificacion.Columns.Insert(6, colOperator)

            Dim colDate As New DataGridViewTextBoxColumn
            colDate.Name = "Date"
            colDate.Visible = False
            DgvPacasClasificacion.Columns.Insert(7, colDate)

            Dim colTemperature As New DataGridViewTextBoxColumn
            colTemperature.Name = "Temperature"
            'colTemperature.HeaderText = "No Paca"
            colTemperature.Visible = False
            DgvPacasClasificacion.Columns.Insert(8, colTemperature)

            Dim colHumidity As New DataGridViewTextBoxColumn
            colHumidity.Name = "Humidity"
            'colHumidity.HeaderText = "No Paca"
            colHumidity.Visible = False
            DgvPacasClasificacion.Columns.Insert(9, colHumidity)

            Dim colAmount As New DataGridViewTextBoxColumn
            colAmount.Name = "Amount"
            'colAmount.HeaderText = "No Paca"
            colAmount.Visible = False
            DgvPacasClasificacion.Columns.Insert(10, colAmount)

            Dim colUHML As New DataGridViewTextBoxColumn
            colUHML.Name = "UHML"
            colUHML.HeaderText = "UHML"
            colUHML.ReadOnly = False
            DgvPacasClasificacion.Columns.Insert(11, colUHML)

            Dim colUI As New DataGridViewTextBoxColumn
            colUI.Name = "UI"
            'colUI.HeaderText = "No Paca"
            colUI.ReadOnly = True
            DgvPacasClasificacion.Columns.Insert(12, colUI)

            Dim colStrength As New DataGridViewTextBoxColumn
            colStrength.Name = "Strength"
            colStrength.HeaderText = "Resistencia"
            colStrength.ReadOnly = False
            DgvPacasClasificacion.Columns.Insert(13, colStrength)

            Dim colElongation As New DataGridViewTextBoxColumn
            colElongation.Name = "Elongation"
            'colElongation.HeaderText = "No Paca"
            colElongation.Visible = False
            DgvPacasClasificacion.Columns.Insert(14, colElongation)

            Dim colSFI As New DataGridViewTextBoxColumn
            colSFI.Name = "SFI"
            'colSFI.HeaderText = "No Paca"
            colSFI.Visible = False
            DgvPacasClasificacion.Columns.Insert(15, colSFI)

            Dim colMaturity As New DataGridViewTextBoxColumn
            colMaturity.Name = "Maturity"
            'colMaturity.HeaderText = "No Paca"
            colMaturity.Visible = False
            DgvPacasClasificacion.Columns.Insert(16, colMaturity)

            Dim colGrade As New DataGridViewTextBoxColumn
            colGrade.Name = "Grade"
            'colGrade.HeaderText = "No Paca"
            colGrade.Visible = False
            'colGrade.ReadOnly = True
            DgvPacasClasificacion.Columns.Insert(17, colGrade)

            Dim colMoist As New DataGridViewTextBoxColumn
            colMoist.Name = "Moist"
            'colMoist.HeaderText = "No Paca"
            colMoist.Visible = False
            DgvPacasClasificacion.Columns.Insert(18, colMoist)

            Dim colMic As New DataGridViewTextBoxColumn
            colMic.Name = "Mic"
            colMic.HeaderText = "Micros"
            'colMic.Visible = False
            DgvPacasClasificacion.Columns.Insert(19, colMic)

            Dim colRd As New DataGridViewTextBoxColumn
            colRd.Name = "Rd"
            'colRd.HeaderText = "No Paca"
            colRd.Visible = True
            colRd.ReadOnly = True
            DgvPacasClasificacion.Columns.Insert(20, colRd)

            Dim colPlusb As New DataGridViewTextBoxColumn
            colPlusb.Name = "Plusb"
            'colPlusb.HeaderText = "No Paca"
            colPlusb.Visible = True
            colPlusb.ReadOnly = True
            DgvPacasClasificacion.Columns.Insert(21, colPlusb)

            Dim colColorGrade As New DataGridViewTextBoxColumn
            colColorGrade.Name = "ColorGrade"
            colColorGrade.HeaderText = "Color Grade"
            colColorGrade.ReadOnly = False
            DgvPacasClasificacion.Columns.Insert(22, colColorGrade)

            Dim colTrashCount As New DataGridViewTextBoxColumn
            colTrashCount.Name = "TrashCount"
            'colTrashCount.HeaderText = "No Paca"
            colTrashCount.Visible = False
            DgvPacasClasificacion.Columns.Insert(23, colTrashCount)

            Dim colTrashArea As New DataGridViewTextBoxColumn
            colTrashArea.Name = "TrashArea"
            'colTrashArea.HeaderText = "No Paca"
            colTrashArea.Visible = False
            DgvPacasClasificacion.Columns.Insert(24, colTrashArea)

            Dim colTrashID As New DataGridViewTextBoxColumn
            colTrashID.Name = "TrashID"
            colTrashID.HeaderText = "Trash ID"
            colTrashID.ReadOnly = False
            DgvPacasClasificacion.Columns.Insert(25, colTrashID)

            Dim colSCI As New DataGridViewTextBoxColumn
            colSCI.Name = "SCI"
            'colSCI.HeaderText = "No Paca"
            colSCI.ReadOnly = True
            DgvPacasClasificacion.Columns.Insert(26, colSCI)

            Dim colNep As New DataGridViewTextBoxColumn
            colNep.Name = "Nep"
            'colNep.HeaderText = "No Paca"
            colNep.Visible = False
            DgvPacasClasificacion.Columns.Insert(27, colNep)

            Dim colUV As New DataGridViewTextBoxColumn
            colUV.Name = "UV"
            'colUV.HeaderText = "No Paca"
            colUV.Visible = False
            DgvPacasClasificacion.Columns.Insert(28, colUV)

            Dim colFlagTerminado As New DataGridViewCheckBoxColumn
            colFlagTerminado.Name = "FlagTerminado"
            'colFlagTerminado.HeaderText = "No Paca"
            colFlagTerminado.Visible = False
            DgvPacasClasificacion.Columns.Insert(29, colFlagTerminado)

            Dim colEstatusCompra As New DataGridViewCheckBoxColumn
            colEstatusCompra.Name = "EstatusVenta"
            'colEstatusCompra.HeaderText = "No Paca"
            colEstatusCompra.Visible = False
            DgvPacasClasificacion.Columns.Insert(30, colEstatusCompra)

        End If
    End Sub
    Private Sub Consultar()
        DgvPacasClasificacion.Rows.Clear()
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
                NuCantidadPacas.Value = Tabla.Rows(0).Item("CantidadPacas")
                TbDescripcion.Text = Tabla.Rows(0).Item("Descripcion")
                TbEntrega.Text = Tabla.Rows(0).Item("Entrega")
                'chkfinalizado.Checked = Tabla.Rows(0).Item("chkrevisado")
                CbEstatus.SelectedValue = Tabla.Rows(0).Item("IdEstatus")
                EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPorId
                EntidadClasificacionVentaPaquetes.IdPaquete = CInt(TbIdPaquete.Text)
                NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
                Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
                For i As Integer = 0 To Tabla.Rows.Count - 1
                    DgvPacasClasificacion.Rows.Add(0, Tabla.Rows(i).Item("IdOrdenTrabajo"), Tabla.Rows(i).Item("IdPlantaOrigen"), Tabla.Rows(i).Item("lotID"), Tabla.Rows(i).Item("BaleID"), Tabla.Rows(i).Item("BaleGroup"), Tabla.Rows(i).Item("Operator"), Tabla.Rows(i).Item("Date"), Tabla.Rows(i).Item("Temperature"), Tabla.Rows(i).Item("Humidity"), Tabla.Rows(i).Item("Amount"), Tabla.Rows(i).Item("UHML"), Tabla.Rows(i).Item("UI"), Tabla.Rows(i).Item("Strength"), Tabla.Rows(i).Item("Elongation"), Tabla.Rows(i).Item("SFI"), Tabla.Rows(i).Item("Maturity"), Tabla.Rows(i).Item("Grade"), Tabla.Rows(i).Item("Moist"), Tabla.Rows(i).Item("Mic"), Tabla.Rows(i).Item("Rd"), Tabla.Rows(i).Item("Plusb"), Tabla.Rows(i).Item("ColorGrade"), Tabla.Rows(i).Item("TrashCount"), Tabla.Rows(i).Item("TrashArea"), Tabla.Rows(i).Item("TrashID"), Tabla.Rows(i).Item("SCI"), Tabla.Rows(i).Item("Nep"), Tabla.Rows(i).Item("UV"), Tabla.Rows(i).Item("FlagTerminado"))
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
        DgvPacasClasificacion.Sort(DgvPacasClasificacion.Columns("BaleID"), System.ComponentModel.ListSortDirection.Descending)
        'IdentificaColor()
        'If chkfinalizado.Checked = True Then DgvPacasClasificacion1.Enabled = False
        'desmarcaCheck()
        ContarPacas()
    End Sub
    Private Sub InsertaPaca()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla As New DataTable
        Dim VerificaDuplicado As Boolean
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPaca
        EntidadClasificacionVentaPaquetes.NumeroPaca = CInt(IIf(TbNoPaca.Text = "", 0, TbNoPaca.Text))
        EntidadClasificacionVentaPaquetes.IdPlanta = CbPlanta.SelectedValue
        EntidadClasificacionVentaPaquetes.IdPaquete = CInt(IIf(TbIdPaquete.Text = "", 0, TbIdPaquete.Text))
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            MsgBox("La paca no se encuentra en la base de datos HVI.")
        ElseIf VerificaPacaRepetida(VerificaDuplicado) = False Then
            DgvPacasClasificacion.Rows.Add(0, Tabla.Rows(0).Item("IdOrdenTrabajo"), Tabla.Rows(0).Item("IdPlantaOrigen"), Tabla.Rows(0).Item("LotID"), Tabla.Rows(0).Item("BaleID"), Tabla.Rows(0).Item("BaleGroup"), Tabla.Rows(0).Item("Operator"), Tabla.Rows(0).Item("Date"), Tabla.Rows(0).Item("Temperature"), Tabla.Rows(0).Item("Humidity"), Tabla.Rows(0).Item("Amount"), Tabla.Rows(0).Item("UHML"), Tabla.Rows(0).Item("UI"), Tabla.Rows(0).Item("Strength"), Tabla.Rows(0).Item("Elongation"), Tabla.Rows(0).Item("SFI"), Tabla.Rows(0).Item("Maturity"), Tabla.Rows(0).Item("Grade"), Tabla.Rows(0).Item("Moist"), Tabla.Rows(0).Item("Mic"), Tabla.Rows(0).Item("Rd"), Tabla.Rows(0).Item("Plusb"), Tabla.Rows(0).Item("ColorGrade"), Tabla.Rows(0).Item("TrashCount"), Tabla.Rows(0).Item("TrashArea"), Tabla.Rows(0).Item("TrashID"), Tabla.Rows(0).Item("SCI"), Tabla.Rows(0).Item("Nep"), Tabla.Rows(0).Item("UV"), Tabla.Rows(0).Item("FlagTerminado"))
        Else
            MsgBox("El numero de paca ya se encuentra registrado.")
        End If
        DgvPacasClasificacion.Sort(DgvPacasClasificacion.Columns("BaleID"), System.ComponentModel.ListSortDirection.Descending)
        ContarPacas()
        'IdentificaColor()
        GeneraPromedioUI()
    End Sub
    Public Function VerificaPacaRepetida(ByVal VerificaDuplicado As Boolean)
        VerificaDuplicado = False
        For Each row As DataGridViewRow In DgvPacasClasificacion.Rows
            Dim NoPaca As Integer = TbNoPaca.Text
            If NoPaca = row.Cells("BaleId").Value Then
                VerificaDuplicado = True
            End If
        Next row
        Return VerificaDuplicado
    End Function
    Private Sub GeneraPromedioUI()
        Dim Index As Integer
        Dim SumaUI As Double = 0
        If DgvPacasClasificacion.Rows.Count > 0 Then
            For Each row As DataGridViewRow In DgvPacasClasificacion.Rows
                Index = Convert.ToUInt64(row.Index)
                SumaUI += DgvPacasClasificacion.Rows(Index).Cells("UI").Value
            Next
            NuPromedioUI.Value = SumaUI / DgvPacasClasificacion.Rows.Count
        ElseIf DgvPacasClasificacion.Rows.Count = 0 Then
            NuPromedioUI.Value = 0
        End If
    End Sub
    Private Sub ContarPacas()
        NuCantidadPacas.Value = DgvPacasClasificacion.Rows.Count
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub Salir(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If DgvPacasClasificacion.Rows.Count > 0 Then
            Dim opc As DialogResult = MsgBox("¿Desea salir y guardar el paquete?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")
            If opc = DialogResult.Yes Then
                Guardar()
                e.Cancel = False
            ElseIf opc = DialogResult.No Then
                e.Cancel = False
            End If
        Else
            e.Cancel = False
        End If
    End Sub
    Private Sub CreaTabla()
        TablaClasificacionGrid.Columns.Clear()
        TablaClasificacionGrid.Columns.Add(New DataColumn("Sel", System.Type.GetType("System.Boolean")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("IdOrdenTrabajo", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("IdPlantaOrigen", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("LotID", System.Type.GetType("System.Int32")))
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
        TablaClasificacionGrid.Columns.Add(New DataColumn("EstatusVenta", System.Type.GetType("System.Int32")))
    End Sub
    Private Sub DataGridViewToTable()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim index As Integer
        Dim rengloninsertar As DataRow
        TablaClasificacionGrid.Clear()
        For Each row As DataGridViewRow In DgvPacasClasificacion.Rows
            index = Convert.ToUInt64(row.Index)
            rengloninsertar = TablaClasificacionGrid.NewRow()

            rengloninsertar("Sel") = DgvPacasClasificacion.Rows(index).Cells("Sel").Value
            rengloninsertar("IdOrdenTrabajo") = DgvPacasClasificacion.Rows(index).Cells("IdOrdenTrabajo").Value
            rengloninsertar("IdPlantaOrigen") = DgvPacasClasificacion.Rows(index).Cells("IdPlantaOrigen").Value
            rengloninsertar("LotID") = DgvPacasClasificacion.Rows(index).Cells("LotID").Value
            rengloninsertar("BaleID") = DgvPacasClasificacion.Rows(index).Cells("BaleID").Value
            rengloninsertar("BaleGroup") = DgvPacasClasificacion.Rows(index).Cells("BaleGroup").Value
            rengloninsertar("Operator") = DgvPacasClasificacion.Rows(index).Cells("Operator").Value
            rengloninsertar("Date") = DgvPacasClasificacion.Rows(index).Cells("Date").Value
            rengloninsertar("Temperature") = DgvPacasClasificacion.Rows(index).Cells("Temperature").Value
            rengloninsertar("Humidity") = DgvPacasClasificacion.Rows(index).Cells("Humidity").Value
            rengloninsertar("Amount") = DgvPacasClasificacion.Rows(index).Cells("Amount").Value
            rengloninsertar("UHML") = DgvPacasClasificacion.Rows(index).Cells("UHML").Value
            rengloninsertar("UI") = DgvPacasClasificacion.Rows(index).Cells("UI").Value
            rengloninsertar("Strength") = DgvPacasClasificacion.Rows(index).Cells("Strength").Value
            rengloninsertar("Elongation") = DgvPacasClasificacion.Rows(index).Cells("Elongation").Value
            rengloninsertar("SFI") = DgvPacasClasificacion.Rows(index).Cells("SFI").Value
            rengloninsertar("Maturity") = DgvPacasClasificacion.Rows(index).Cells("Maturity").Value
            rengloninsertar("Grade") = DgvPacasClasificacion.Rows(index).Cells("Grade").Value
            rengloninsertar("Moist") = DgvPacasClasificacion.Rows(index).Cells("Moist").Value
            rengloninsertar("Mic") = DgvPacasClasificacion.Rows(index).Cells("Mic").Value
            rengloninsertar("Rd") = DgvPacasClasificacion.Rows(index).Cells("Rd").Value
            rengloninsertar("Plusb") = DgvPacasClasificacion.Rows(index).Cells("Plusb").Value
            rengloninsertar("ColorGrade") = DgvPacasClasificacion.Rows(index).Cells("ColorGrade").Value
            rengloninsertar("TrashCount") = DgvPacasClasificacion.Rows(index).Cells("TrashCount").Value
            rengloninsertar("TrashArea") = DgvPacasClasificacion.Rows(index).Cells("TrashArea").Value
            rengloninsertar("TrashID") = DgvPacasClasificacion.Rows(index).Cells("TrashID").Value
            rengloninsertar("SCI") = DgvPacasClasificacion.Rows(index).Cells("SCI").Value
            rengloninsertar("Nep") = DgvPacasClasificacion.Rows(index).Cells("Nep").Value
            rengloninsertar("UV") = DgvPacasClasificacion.Rows(index).Cells("UV").Value
            rengloninsertar("FlagTerminado") = DgvPacasClasificacion.Rows(index).Cells("FlagTerminado").Value
            rengloninsertar("EstatusVenta") = 1
            TablaClasificacionGrid.Rows.Add(rengloninsertar)
        Next
        TablaClasificacionGlobal = TablaClasificacionGrid
    End Sub
    Private Sub EliminarPacasSeleccionadasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarPacasSeleccionadasToolStripMenuItem.Click
        VerificaAutorizacion.ShowDialog()
        If VerificaAutorizacion.VerificaAutorizacion = True Then
            DgvPacasClasificacion.EndEdit()
            GuardarParaEliminar()
            Consultar()
        Else
            MsgBox("El usuario " & Usuario & " no tiene privilegios para realizar esta operacion.", MsgBoxStyle.Exclamation, "Clave incorrecta.")
        End If
    End Sub
    Private Sub DgvPacasClasificacion_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPacasClasificacion.CellEndEdit
        Dim ResultadoSCI As Integer = 0
        DgvPacasClasificacion.CurrentRow.Cells("SCI").Value = CalculaSCI(ResultadoSCI)
    End Sub
    Private Function CalculaSCI(ByVal ResultadoSCI As Integer)
        ResultadoSCI = -414.67 + 2.9 * DgvPacasClasificacion.CurrentRow.Cells("Strength").Value - 9.32 * DgvPacasClasificacion.CurrentRow.Cells("Mic").Value + 49.17 * DgvPacasClasificacion.CurrentRow.Cells("UHML").Value + 4.74 * DgvPacasClasificacion.CurrentRow.Cells("UI").Value + 0.65 * DgvPacasClasificacion.CurrentRow.Cells("RD").Value + 0.36 * DgvPacasClasificacion.CurrentRow.Cells("PLUSB").Value
        Return ResultadoSCI
    End Function
    Private Sub BtSeleccionarTodo_Click(sender As Object, e As EventArgs) Handles BtSeleccionarTodo.Click
        Dim Contador As Integer
        For Contador = 0 To DgvPacasClasificacion.RowCount - 1
            DgvPacasClasificacion.Rows(Contador).Cells("Sel").Value = True
            DgvPacasClasificacion.Rows(Contador).Selected = False
        Next Contador
    End Sub
    Private Sub desmarcaCheck()
        Dim Contador As Integer
        For Contador = 0 To DgvPacasClasificacion.RowCount - 1
            DgvPacasClasificacion.Rows(Contador).Cells("Sel").Value = False
        Next Contador
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
        DesactivaCampos()
    End Sub
    Private Sub Guardar()
        If DgvPacasClasificacion.RowCount > 0 Then
            If CbPlanta.Text <> "" And CbClases.Text <> "" Then
                Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
                Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
                'If IdentificaColor() > 0 And chkfinalizado.Checked = True Then
                '    MsgBox("Por favor, verificar que los datos esten correctos.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                'Else
                Try
                    EntidadClasificacionVentaPaquetes.IdPaquete = IIf(TbIdPaquete.Text = "", 0, TbIdPaquete.Text)
                    EntidadClasificacionVentaPaquetes.LotID = 0
                    EntidadClasificacionVentaPaquetes.IdPlanta = CbPlanta.SelectedValue
                    EntidadClasificacionVentaPaquetes.IdComprador = CbComprador.SelectedValue
                    EntidadClasificacionVentaPaquetes.IdClase = CbClases.SelectedValue
                    EntidadClasificacionVentaPaquetes.CantidadPacas = VerificaCheck()
                    EntidadClasificacionVentaPaquetes.Descripcion = CbClases.Text & "-" & TbIdPaquete.Text
                    EntidadClasificacionVentaPaquetes.Entrega = TbEntrega.Text
                    EntidadClasificacionVentaPaquetes.chkrevisado = False
                    EntidadClasificacionVentaPaquetes.IdEstatus = CbEstatus.SelectedValue
                    EntidadClasificacionVentaPaquetes.IdUsuarioCreacion = 1
                    EntidadClasificacionVentaPaquetes.FechaCreacion = Now
                    EntidadClasificacionVentaPaquetes.IdUsuarioActualizacion = 1
                    EntidadClasificacionVentaPaquetes.FechaActualizacion = Now
                    DataGridViewToTable()
                    EntidadClasificacionVentaPaquetes.TablaGeneral = TablaClasificacionGlobal
                    NegocioClasificacionVentaPaquetes.GuardarTablas(EntidadClasificacionVentaPaquetes)
                    TbIdPaquete.Text = EntidadClasificacionVentaPaquetes.IdPaquete
                    TbDescripcion.Text = CbClases.Text & "-" & TbIdPaquete.Text
                    'MsgBox("Paquete guardado con exito.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Aviso")
                    'DgvPacasClasificacion11.Enabled = False
                    'End If
                Catch ex As Exception
                    MsgBox(ex)
                Finally
                    TbIdPaquete.Enabled = False
                    GeneraRegistroBitacora(Me.Text.Clone.ToString, GuardarToolStripMenuItem.Text, TbIdPaquete.Text, "CON LA CLASE " & CbClases.Text & " Y LA CANTIDAD DE " & NuCantidadPacas.Value & " PACAS.")
                    MsgBox("El paquete se guardo con exito.", MsgBoxStyle.Information, "Aviso")
                End Try
            Else
                MsgBox("Los campos Planta y Clase son requeridos para crear un paquete nuevo.")
                TbNoPaca.Select()
            End If
        Else
            MsgBox("No hay datos para guardar.", MsgBoxStyle.Exclamation)
        End If
    End Sub
    Private Function VerificaCheck()
        Dim Contador As Integer = 0
        If DgvPacasClasificacion.Rows.Count > 0 Then
            For Each Fila As DataGridViewRow In DgvPacasClasificacion.Rows
                If Fila.Cells("Sel").Value = False Then
                    Contador = Contador + 1
                End If
            Next
        End If
        Return Contador
    End Function
    Function ExistePacaHVI(ByVal IdPaca As Integer) As Boolean
        Dim Tabla As New DataTable
        Dim resultado As Boolean
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPacaExisteHVI
        EntidadClasificacionVentaPaquetes.NumeroPaca = IdPaca
        EntidadClasificacionVentaPaquetes.IdPlanta = CbPlanta.SelectedValue
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        resultado = Tabla.Rows(0).Item("ExistePaca")
        Return resultado
    End Function
    Private Function VerificaPacaPlanta(ByVal IdPaca As Integer) As String
        Dim Tabla As New DataTable
        'Dim Resultado As Boolean
        Dim vReturn(1) As String
        PlantaVerifica = ""
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPacaPlanta
        EntidadClasificacionVentaPaquetes.NumeroPaca = IdPaca
        EntidadClasificacionVentaPaquetes.IdPlanta = CbPlanta.SelectedValue
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        'If Tabla.Rows(0).Item("ExistePacaPlanta") = False Then
        'Resultado = True
        vReturn(0) = Tabla.Rows(0).Item("ExistePacaPlanta")
        vReturn(1) = Tabla.Rows(0).Item("IdPlantaOrigen")
        'Else
        '    Resultado = False
        'End If
        Return vReturn(0)
    End Function
    Function ExistePacaPaquete(ByVal IdPaca As Integer) As Boolean
        Dim Tabla As New DataTable
        Dim Resultado As Boolean
        IdPaqueteEncabezadoVerifica = 0
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPacaExistePaquete
        EntidadClasificacionVentaPaquetes.NumeroPaca = IdPaca
        EntidadClasificacionVentaPaquetes.IdPlanta = CbPlanta.SelectedValue
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        If CBool(Tabla.Rows(0).Item("ExistePaca")) = True Then
            Resultado = True
            IdPaqueteEncabezadoVerifica = Tabla.Rows(0).Item("IdPaqueteEncabezado")
        End If
        Return Resultado
    End Function
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        VerificaAutorizacion.ShowDialog()
        If VerificaAutorizacion.VerificaAutorizacion = True Then
            ActivaCampos()
            GeneraRegistroBitacora(Me.Text.Clone.ToString, ModificarToolStripMenuItem.Text, TbIdPaquete.Text)
        Else
            MsgBox("El usuario " & Usuario & " no tiene privilegios para realizar esta operacion.", MsgBoxStyle.Exclamation, "Clave incorrecta.")
        End If
    End Sub

    Private Sub ArchivoAccessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivoAccessToolStripMenuItem.Click
        Dim RutaPlantilla As String = My.Computer.FileSystem.CurrentDirectory & "\Reportes\RPT\BaseHVI.mdb"
        'Dim RutaPlantilla As String = "\\192.168.10.30\docs_sistemas\RPT_ALGODON\BaseHVI.mdb"
        Dim RutaCarpeta As String = "C:\datos\"
        Dim RutaCopiar As String = RutaCarpeta & CbPlanta.SelectedValue & "_" & "HVI_" & CbClases.Text & "_" & TbIdPaquete.Text & ".mdb"
        If DgvPacasClasificacion.RowCount > 0 Then
            If File.Exists(RutaCopiar) Then
                Dim opc As DialogResult = MsgBox("El Archivo ya existe, ¿Desea reemplazarlo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")
                If opc = DialogResult.Yes Then
                    IO.Directory.CreateDirectory(RutaCarpeta)
                    File.Copy(RutaPlantilla, RutaCopiar, True)
                    CreaExportarAccess(RutaCopiar)
                ElseIf opc = DialogResult.No Then

                End If
            Else
                IO.Directory.CreateDirectory(RutaCarpeta)
                File.Copy(RutaPlantilla, RutaCopiar, True)
                CreaExportarAccess(RutaCopiar)
            End If
        Else
            MsgBox("No hay registros para exportar.")
        End If
        'Dim RutaPlantilla As String = Application.StartupPath & "\Reportes\RPT\BaseHVI.mdb"
    End Sub
    Private Sub CreaExportarAccess(ByVal RutaCopiar As String)
        ':::Declaramos nuestra variable Sql que almacenara nuestra consuta
        Dim Sql As String = ""
        Dim Con3 As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source =" & RutaCopiar & "")
        ':::Usamos un ciclo For Each para recorrer nuestro DataGridView llamado DGTabla
        For Each Row As DataGridViewRow In DgvPacasClasificacion.Rows
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

    Private Sub ReporteHVIToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteHVIToolStripMenuItem.Click
        VarGlob2.TablaExporta = Datagridtotable(DgvPacasClasificacion)
        'VarGlob2.DgvExportaExcel.DataSource = DgvPacasClasificacion1
        If TbIdPaquete.Text <> "" Then
            Dim ReporteClasificacion As New RepClasificacion(TbIdPaquete.Text, CbPlanta.SelectedValue)
            ReporteClasificacion.ShowDialog()
        Else
            MessageBox.Show("No hay paquete seleccionado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Function Datagridtotable(ByVal DgvExporta As DataGridView)
        Dim dt As New DataTable
        Dim r As DataRow

        dt.Columns.Clear()
        dt.Columns.Add("LotID", Type.GetType("System.Int32"))
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
            r("LotID") = Val(TbIdPaquete.Text)
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

    Private Sub DgvPacasClasificacion_RowPostPaint(sender As Object, e As DataGridViewRowPostPaintEventArgs) Handles DgvPacasClasificacion.RowPostPaint
        Try
            Dim NumeroFila As String = (e.RowIndex + 1).ToString 'Obtiene el número de filas
            While NumeroFila.Length < DgvPacasClasificacion.RowCount.ToString.Length
                NumeroFila = "0" & NumeroFila 'Agrega un cero a los que tienen un dígito menos
            End While
            Dim size As SizeF = e.Graphics.MeasureString(NumeroFila, Me.Font)
            If DgvPacasClasificacion.RowHeadersWidth < CInt(size.Width + 20) Then
                DgvPacasClasificacion.RowHeadersWidth = CInt(size.Width + 20)
            End If
            Dim Obj As Brush = SystemBrushes.ControlText
            'Dibuja el número dentro del controltext
            e.Graphics.DrawString(NumeroFila, Me.Font, Obj, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2))
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error")
        End Try
    End Sub

    Private Sub ReporteDePaquetesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteDePaquetesToolStripMenuItem.Click
        RepPaquetesVenta.ShowDialog()
    End Sub

    Private Sub BtDeseleccionarTodo_Click(sender As Object, e As EventArgs) Handles BtDeseleccionarTodo.Click
        desmarcaCheck()
    End Sub
End Class