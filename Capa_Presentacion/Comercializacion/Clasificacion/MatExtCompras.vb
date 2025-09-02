Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class MatExtCompras
    Private TablaClasificacionGrid, TablaClasificacionGlobal As New DataTable
    Private Sub MatExtCompras_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaCombos()
        CreaTabla()
        limpiar()
        CastigosMatExt()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiar()
    End Sub
    Private Sub CreaTabla()
        TablaClasificacionGrid.Columns.Clear()
        TablaClasificacionGrid.Columns.Add(New DataColumn("Sel", System.Type.GetType("System.Boolean")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("IdPaquete", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("IdOrdenTrabajo", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("LotID", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("BaleID", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("BarkLevel1", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("CastigoBarkLevel1Compra", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("PrepLevel1", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("CastigoPrepLevel1Compra", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("OtherLevel1", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("CastigoOtherLevel1Compra", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("PlasticLevel1", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("CastigoPlasticLevel1Compra", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("BarkLevel2", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("CastigoBarkLevel2Compra", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("PrepLevel2", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("CastigoPrepLevel2Compra", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("OtherLevel2", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("CastigoOtherLevel2Compra", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("PlasticLevel2", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("CastigoPlasticLevel2Compra", System.Type.GetType("System.Double")))
    End Sub
    Private Sub DataGridViewToTable()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim index As Integer
        Dim rengloninsertar As DataRow
        TablaClasificacionGrid.Clear()
        For Each row As DataGridViewRow In DgvPacas.Rows
            index = Convert.ToUInt64(row.Index)
            rengloninsertar = TablaClasificacionGrid.NewRow()

            rengloninsertar("Sel") = DgvPacas.Rows(index).Cells("Sel").Value
            rengloninsertar("IdPaquete") = DgvPacas.Rows(index).Cells("IdPaquete").Value
            rengloninsertar("IdOrdenTrabajo") = DgvPacas.Rows(index).Cells("IdOrdenTrabajo").Value
            rengloninsertar("LotID") = DgvPacas.Rows(index).Cells("LotID").Value
            rengloninsertar("BaleID") = DgvPacas.Rows(index).Cells("BaleID").Value
            rengloninsertar("BarkLevel1") = DgvPacas.Rows(index).Cells("BarkLevel1").Value
            rengloninsertar("CastigoBarkLevel1Compra") = DgvPacas.Rows(index).Cells("CastigoBarkLevel1Compra").Value
            rengloninsertar("PrepLevel1") = DgvPacas.Rows(index).Cells("PrepLevel1").Value
            rengloninsertar("CastigoPrepLevel1Compra") = DgvPacas.Rows(index).Cells("CastigoPrepLevel1Compra").Value
            rengloninsertar("OtherLevel1") = DgvPacas.Rows(index).Cells("OtherLevel1").Value
            rengloninsertar("CastigoOtherLevel1Compra") = DgvPacas.Rows(index).Cells("CastigoOtherLevel1Compra").Value
            rengloninsertar("PlasticLevel1") = DgvPacas.Rows(index).Cells("PlasticLevel1").Value
            rengloninsertar("CastigoPlasticLevel1Compra") = DgvPacas.Rows(index).Cells("CastigoPlasticLevel1Compra").Value
            rengloninsertar("BarkLevel2") = DgvPacas.Rows(index).Cells("BarkLevel2").Value
            rengloninsertar("CastigoBarkLevel2Compra") = DgvPacas.Rows(index).Cells("CastigoBarkLevel2Compra").Value
            rengloninsertar("PrepLevel2") = DgvPacas.Rows(index).Cells("PrepLevel2").Value
            rengloninsertar("CastigoPrepLevel2Compra") = DgvPacas.Rows(index).Cells("CastigoPrepLevel2Compra").Value
            rengloninsertar("OtherLevel2") = DgvPacas.Rows(index).Cells("OtherLevel2").Value
            rengloninsertar("CastigoOtherLevel2Compra") = DgvPacas.Rows(index).Cells("CastigoOtherLevel2Compra").Value
            rengloninsertar("PlasticLevel2") = DgvPacas.Rows(index).Cells("PlasticLevel2").Value
            rengloninsertar("CastigoPlasticLevel2Compra") = DgvPacas.Rows(index).Cells("CastigoPlasticLevel2Compra").Value
            TablaClasificacionGrid.Rows.Add(rengloninsertar)
        Next
        TablaClasificacionGlobal = TablaClasificacionGrid
    End Sub
    Private Sub propiedadesDgv()
        DgvPacas.Columns.Clear()
        If DgvPacas.Columns("BaleId") Is Nothing Then

            Dim colSel As New DataGridViewCheckBoxColumn()
            colSel.Name = "Sel"
            colSel.FalseValue = False
            colSel.TrueValue = True
            colSel.IndeterminateValue = False
            DgvPacas.Columns.Insert(0, colSel)

            Dim colIdPaquete As New DataGridViewTextBoxColumn
            colIdPaquete.Name = "IdPaquete"
            colIdPaquete.HeaderText = "Paquete"
            colIdPaquete.Visible = False
            DgvPacas.Columns.Insert(1, colIdPaquete)

            Dim colIdOrdenTrabajo As New DataGridViewTextBoxColumn
            colIdOrdenTrabajo.Name = "IdOrdenTrabajo"
            colIdOrdenTrabajo.HeaderText = "No Orden Trabajo"
            colIdOrdenTrabajo.ReadOnly = True
            DgvPacas.Columns.Insert(2, colIdOrdenTrabajo)

            Dim colLotID As New DataGridViewTextBoxColumn
            colLotID.Name = "LotID"
            colLotID.HeaderText = "LotID"
            colLotID.ReadOnly = True
            DgvPacas.Columns.Insert(3, colLotID)

            Dim colBaleID As New DataGridViewTextBoxColumn
            colBaleID.Name = "BaleID"
            colBaleID.HeaderText = "BaleID"
            colBaleID.ReadOnly = True
            DgvPacas.Columns.Insert(4, colBaleID)

            Dim colBarkLevel1 As New DataGridViewTextBoxColumn
            colBarkLevel1.Name = "BarkLevel1"
            colBarkLevel1.HeaderText = "Bark Level1"
            colBarkLevel1.ReadOnly = True
            DgvPacas.Columns.Insert(5, colBarkLevel1)

            Dim colCastigoBaLe1 As New DataGridViewTextBoxColumn
            colCastigoBaLe1.Name = "CastigoBarkLevel1Compra"
            colCastigoBaLe1.HeaderText = "Castigo Bark Level1"
            colCastigoBaLe1.Visible = False
            DgvPacas.Columns.Insert(6, colCastigoBaLe1)

            Dim colPrepLeveL1 As New DataGridViewTextBoxColumn
            colPrepLeveL1.Name = "PrepLevel1"
            colPrepLevel1.HeaderText = "Prep Level1"
            colPrepLevel1.ReadOnly = True
            DgvPacas.Columns.Insert(7, colPrepLevel1)

            Dim colCastigoPrLe1 As New DataGridViewTextBoxColumn
            colCastigoPrLe1.Name = "CastigoPrepLevel1"
            colCastigoPrLe1.HeaderText = "Castigo Prep Level1"
            colCastigoPrLe1.Visible = False
            DgvPacas.Columns.Insert(8, colCastigoPrLe1)

            Dim colOtherLevel1 As New DataGridViewTextBoxColumn
            colOtherLevel1.Name = "OtherLevel1"
            colOtherLevel1.HeaderText = "Other Level1"
            colOtherLevel1.ReadOnly = True
            DgvPacas.Columns.Insert(9, colOtherLevel1)

            Dim colCastigoOtL1 As New DataGridViewTextBoxColumn
            colCastigoOtL1.Name = "CastigoOtherLevel1"
            colCastigoOtL1.HeaderText = "Castigo Other Level1"
            colCastigoOtL1.Visible = False
            DgvPacas.Columns.Insert(10, colCastigoOtL1)

            Dim colPlasticLevel1 As New DataGridViewTextBoxColumn
            colPlasticLevel1.Name = "PlasticLevel1"
            colPlasticLevel1.HeaderText = "Plastic Level1"
            colPlasticLevel1.ReadOnly = True
            DgvPacas.Columns.Insert(11, colPlasticLevel1)

            Dim colCastigoPlL1 As New DataGridViewTextBoxColumn
            colCastigoPlL1.Name = "CastigoPlasticLevel1"
            colCastigoPlL1.HeaderText = "Castigo Plastic Level1"
            colCastigoPlL1.Visible = False
            DgvPacas.Columns.Insert(12, colCastigoPlL1)

            Dim colBarkLevel2 As New DataGridViewTextBoxColumn
            colBarkLevel2.Name = "BarkLevel2"
            colBarkLevel2.HeaderText = "Bark Level2"
            colBarkLevel2.ReadOnly = True
            DgvPacas.Columns.Insert(13, colBarkLevel2)

            Dim colCastigoBaLe2 As New DataGridViewTextBoxColumn
            colCastigoBaLe2.Name = "CastigoBarkLevel2Compra"
            colCastigoBaLe2.HeaderText = "Castigo Bark Level2"
            colCastigoBaLe2.Visible = False
            DgvPacas.Columns.Insert(14, colCastigoBaLe2)

            Dim colPrepLeveL2 As New DataGridViewTextBoxColumn
            colPrepLeveL2.Name = "PrepLevel2"
            colPrepLeveL2.HeaderText = "Prep Level2"
            colPrepLeveL2.ReadOnly = True
            DgvPacas.Columns.Insert(15, colPrepLeveL2)

            Dim colCastigoPrLe2 As New DataGridViewTextBoxColumn
            colCastigoPrLe2.Name = "CastigoPrepLevel2"
            colCastigoPrLe2.HeaderText = "Castigo Prep Level2"
            colCastigoPrLe2.Visible = False
            DgvPacas.Columns.Insert(16, colCastigoPrLe2)

            Dim colOtherLevel2 As New DataGridViewTextBoxColumn
            colOtherLevel2.Name = "OtherLevel2"
            colOtherLevel2.HeaderText = "Other Level2"
            colOtherLevel2.ReadOnly = True
            DgvPacas.Columns.Insert(17, colOtherLevel2)

            Dim colCastigoOtL2 As New DataGridViewTextBoxColumn
            colCastigoOtL2.Name = "CastigoOtherLevel2"
            colCastigoOtL2.HeaderText = "Castigo Other Level2"
            colCastigoOtL2.Visible = False
            DgvPacas.Columns.Insert(18, colCastigoOtL2)

            Dim colPlasticLevel2 As New DataGridViewTextBoxColumn
            colPlasticLevel2.Name = "PlasticLevel2"
            colPlasticLevel2.HeaderText = "Plastic Level2"
            colPlasticLevel2.ReadOnly = True
            DgvPacas.Columns.Insert(19, colPlasticLevel2)

            Dim colCastigoPlL2 As New DataGridViewTextBoxColumn
            colCastigoPlL2.Name = "CastigoPlasticLevel2"
            colCastigoPlL2.HeaderText = "Castigo Plastic Level2"
            colCastigoPlL2.Visible = False
            DgvPacas.Columns.Insert(20, colCastigoPlL2)

        End If
    End Sub
    Private Sub Guardar()
        If DgvPacas.RowCount > 0 Then
            'If CbPlanta.Text <> "" And CbClases.Text <> "" Then
            Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
            Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
            Try
                DataGridViewToTable()
                EntidadClasificacionVentaPaquetes.TablaGeneral = TablaClasificacionGlobal
                NegocioClasificacionVentaPaquetes.GuardarTablasMatExt(EntidadClasificacionVentaPaquetes)
                TbIdPaquete.Text = EntidadClasificacionVentaPaquetes.IdPaquete
            Catch ex As Exception
                TablaClasificacionGlobal.Clear()
                MsgBox(ex)
            Finally
                TablaClasificacionGlobal.Clear()
                TbIdPaquete.Enabled = False
                GeneraRegistroBitacora(Me.Text.Clone.ToString, GuardarToolStripMenuItem.Text, TbIdPaquete.Text, ".")
                MsgBox("El paquete se guardo con exito.", MsgBoxStyle.Information, "Aviso")
            End Try
        Else
            MsgBox("Los campos Planta y Clase son requeridos para crear un paquete nuevo.")
            TbNoPaca.Select()
        End If
    End Sub
    Private Sub TbLotID_TextChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbIdPaquete.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                Dim vReturn(1) As String
                If TbIdPaquete.Text <> "" Then
                    vReturn = ExistePaqueteHVI(TbIdPaquete.Text)
                    If vReturn(0) = False And vReturn(1) = False Then
                        MsgBox("El paquete consultado no se encuentra registrado!", MsgBoxStyle.Information, "Aviso")
                    Else
                        Dim EntidadPaquetesHVI As New Capa_Entidad.PaquetesHVI
                        Dim NegocioPaquetesHVI As New Capa_Negocio.PaquetesHVI
                        Dim Tabla As New DataTable
                        EntidadPaquetesHVI.Consulta = Consulta.ConsultaEncabezadoMatExt
                        EntidadPaquetesHVI.LotId = Val(TbIdPaquete.Text)
                        NegocioPaquetesHVI.Consultar(EntidadPaquetesHVI)
                        Tabla = EntidadPaquetesHVI.TablaConsulta
                        CbPlanta.SelectedValue = Tabla.Rows(0).Item("IdPlanta")
                        'DgvPacas.DataSource = TablaPaquetesHVIGlobal
                        TbIdPaquete.Enabled = False
                        TbNoPaca.Text = ""
                        TbNoPaca.Focus()
                    End If
                Else
                    MsgBox("El campo Paquete no puede ir vacios.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                    Exit Sub
                End If
        End Select
    End Sub
    Private Sub TbNoPaca_KeyDown(sender As Object, e As KeyEventArgs) Handles TbNoPaca.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                If TbNoPaca.Text <> "" And CbPlanta.Text <> "" Then
                    'If ExistePacaHVI(TbNoPaca.Text) = False Then
                    '    MsgBox("Paca " & TbNoPaca.Text & " no existe en HVI o en la planta seleccionada, revisa el ID capturado.")
                    '    TbNoPaca.Text = ""
                    'ElseIf VerificaPacaPlanta(TbNoPaca.Text) = False Then
                    '    MessageBox.Show("Paca No " & TbNoPaca.Text & " no pertenece a planta " & CbPlanta.Text & ".", "Aviso")
                    'ElseIf ExistePacaPaquete(TbNoPaca.Text) = True And Val(TbIdPaquete.Text) <> IdPaqueteEncabezadoVerifica Then
                    '    MessageBox.Show("Paca " & TbNoPaca.Text & " existe en paquete " & IdPaqueteEncabezadoVerifica & ".", "Aviso")
                    '    TbNoPaca.Text = ""
                    'ElseIf ExistePacaPaquete(TbNoPaca.Text) = True And Val(TbIdPaquete.Text) = IdPaqueteEncabezadoVerifica Then
                    '    MessageBox.Show("La Paca No " & TbNoPaca.Text & " ya existe en el paquete actual.")
                    '    TbNoPaca.Text = ""
                    'Else
                    InsertaPaca()
                        TbNoPaca.Text = ""
                    'End If
                Else
                    MsgBox("Ingrese el campo Planta y Clase para continuar...")
                    TbNoPaca.Text = ""
                    Exit Sub
                End If
        End Select
    End Sub
    Private Function ExistePaqueteHVI(ByVal LotID As String)
        Dim Tabla As New DataTable
        'Dim Resultado As Boolean
        Dim vReturn(1) As String
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPaqueteExisteHVI
        EntidadClasificacionVentaPaquetes.LotID = LotID
        EntidadClasificacionVentaPaquetes.IdPlanta = CbPlanta.SelectedValue
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        vReturn(0) = Tabla.Rows(0).Item("ExistePaquete")
        vReturn(1) = Tabla.Rows(0).Item("IdHviEnc")
        Return vReturn
    End Function
    Private Sub CastigosMatExt()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        Dim Tabla As New DataTable
        Try
            EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCastigoMatExtCompra
            NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
            Tabla = EntidadCompraPacasContrato.TablaConsulta
            NuBarkLevel1.Value = Tabla.Rows(0).Item("Nivel1").ToString
            NuPrepLevel1.Value = Tabla.Rows(1).Item("Nivel1").ToString
            NuOtherLevel1.Value = Tabla.Rows(2).Item("Nivel1").ToString
            NuPlasticLevel1.Value = Tabla.Rows(3).Item("Nivel1").ToString
            NuBarkLevel2.Value = Tabla.Rows(0).Item("Nivel2").ToString
            NuPrepLevel2.Value = Tabla.Rows(1).Item("Nivel2").ToString
            NuOtherLevel2.Value = Tabla.Rows(2).Item("Nivel2").ToString
            NuPlasticLevel2.Value = Tabla.Rows(3).Item("Nivel2").ToString
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub limpiar()
        DgvPacas.Columns.Clear()
        propiedadesDgv()
        RbSinCastigoLevel1.Checked = True
        RbSinCastigoLevel2.Checked = True
        TbIdPaquete.Enabled = True
        TbIdPaquete.Text = ""
        TbIdPaquete.Select()
        TbNoPaca.Text = ""
        CbPlanta.SelectedValue = -1
        NuCantidadPacas.Value = 0
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
        CbPlanta.SelectedValue = -1
    End Sub
    Private Sub Consultar()
        DgvPacas.Rows.Clear()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        If TbIdPaquete.Text <> "" Then
            EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaEncabezadoMatExt
            EntidadClasificacionVentaPaquetes.LotID = CInt(TbIdPaquete.Text)
            NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
            Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
            If Tabla.Rows.Count <> 0 Then
                TbIdPaquete.Text = Tabla.Rows(0).Item("LotID")
                CbPlanta.SelectedValue = Tabla.Rows(0).Item("IdPlanta")
                EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPacaMatExt
                EntidadClasificacionVentaPaquetes.LotID = CInt(TbIdPaquete.Text)
                NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
                Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
                'DgvPacas.DataSource = Tabla
                For i As Integer = 0 To Tabla.Rows.Count - 1
                    DgvPacas.Rows.Add(0, Tabla.Rows(i).Item("IdPaquete"), Tabla.Rows(i).Item("IdOrdenTrabajo"), Tabla.Rows(i).Item("LotId"), Tabla.Rows(i).Item("BaleId"), Tabla.Rows(i).Item("BarkLevel1"), Tabla.Rows(i).Item("CastigoBarkLevel1Compra"), Tabla.Rows(i).Item("PrepLevel1"), Tabla.Rows(i).Item("CastigoPrepLevel1Compra"), Tabla.Rows(i).Item("OtherLevel1"), Tabla.Rows(i).Item("CastigoOtherLevel1Compra"), Tabla.Rows(i).Item("PlasticLevel1"), Tabla.Rows(i).Item("CastigoPlasticLevel1Compra"), Tabla.Rows(i).Item("BarkLevel2"), Tabla.Rows(i).Item("CastigoBarkLevel2Compra"), Tabla.Rows(i).Item("PrepLevel2"), Tabla.Rows(i).Item("CastigoPrepLevel2Compra"), Tabla.Rows(i).Item("OtherLevel2"), Tabla.Rows(i).Item("CastigoOtherLevel2Compra"), Tabla.Rows(i).Item("PlasticLevel2"), Tabla.Rows(i).Item("CastigoPlasticLevel2Compra"))
                Next
            Else
                MsgBox("No se encontraron registros con esos criterios.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
                TbIdPaquete.Enabled = True
                TbIdPaquete.Text = ""
            End If
        Else
            MsgBox("Por favor, verificar que los datos esten correctos.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
        End If
        DgvPacas.Sort(DgvPacas.Columns("BaleID"), System.ComponentModel.ListSortDirection.Descending)
        ContarPacas()
    End Sub
    Private Sub InsertaPaca()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla As New DataTable
        Dim VerificaDuplicado As Boolean
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPacaMatExtDet
        EntidadClasificacionVentaPaquetes.BaleID = CInt(IIf(TbNoPaca.Text = "", 0, TbNoPaca.Text))
        EntidadClasificacionVentaPaquetes.LotID = CInt(IIf(TbIdPaquete.Text = "", 0, TbIdPaquete.Text))
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            MsgBox("La paca no se encuentra en la base de datos HVI.")
        ElseIf VerificaPacaRepetida(VerificaDuplicado) = False Then
            DgvPacas.Rows.Add(0, Tabla.Rows(0).Item("IdPaquete"), Tabla.Rows(0).Item("IdOrdenTrabajo"), Tabla.Rows(0).Item("LotId"), Tabla.Rows(0).Item("BaleId"), IIf(RbBark1.Checked = True, NuBarkLevel1.Value, 0), Tabla.Rows(0).Item("CastigoBarkLevel1Compra"), IIf(RbPrep1.Checked = True, NuPrepLevel1.Value, 0), Tabla.Rows(0).Item("CastigoPrepLevel1Compra"), IIf(RbOther1.Checked = True, NuOtherLevel1.Value, 0), Tabla.Rows(0).Item("CastigoOtherLevel1Compra"), IIf(RbPlastic1.Checked = True, NuPlasticLevel1.Value, 0), Tabla.Rows(0).Item("CastigoPlasticLevel1Compra"), IIf(RbBark2.Checked = True, NuBarkLevel2.Value, 0), Tabla.Rows(0).Item("CastigoBarkLevel2Compra"), IIf(RbPrep2.Checked = True, NuPrepLevel2.Value, 0), Tabla.Rows(0).Item("CastigoPrepLevel2Compra"), IIf(RbOther2.Checked = True, NuOtherLevel2.Value, 0), Tabla.Rows(0).Item("CastigoOtherLevel2Compra"), IIf(RbPlastic2.Checked = True, NuPlasticLevel2.Value, 0), Tabla.Rows(0).Item("CastigoPlasticLevel2Compra"))
        Else
            MsgBox("El numero de paca ya se encuentra registrado.")
        End If
        DgvPacas.Sort(DgvPacas.Columns("BaleID"), System.ComponentModel.ListSortDirection.Descending)
        ContarPacas()
    End Sub
    Private Sub ContarPacas()
        NuCantidadPacas.Value = DgvPacas.Rows.Count
    End Sub
    Public Function VerificaPacaRepetida(ByVal VerificaDuplicado As Boolean)
        VerificaDuplicado = False
        For Each row As DataGridViewRow In DgvPacas.Rows
            Dim NoPaca As Integer = TbNoPaca.Text
            If NoPaca = row.Cells("BaleId").Value Then
                VerificaDuplicado = True
            End If
        Next row
        Return VerificaDuplicado
    End Function

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class