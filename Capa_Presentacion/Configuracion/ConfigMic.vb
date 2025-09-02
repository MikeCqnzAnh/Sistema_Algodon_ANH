Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Imports Microsoft.Office.Interop

Public Class ConfigMic
    Private TablaClases As New DataTable()
    Private Sub ConfigMic_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarCombos()
    End Sub
    Private Sub CargarCombos()
        '---------------------------COMBO ESTATUS
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("Id")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("Id") = "1"
        dr("Descripcion") = "Activo"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "2"
        dr("Descripcion") = "Inactivo"
        dt.Rows.Add(dr)
        CbEstatus.DataSource = dt
        CbEstatus.ValueMember = "Id"
        CbEstatus.DisplayMember = "Descripcion"
        CbEstatus.SelectedValue = 1
        '-------------------------COMBO TIPO CONTRATO
        Dim dt1 As DataTable = New DataTable("Tabla")
        dt1.Columns.Add("Id")
        dt1.Columns.Add("Descripcion")
        Dim dr1 As DataRow
        dr1 = dt1.NewRow()
        dr1("Id") = "1"
        dr1("Descripcion") = "Compra"
        dt1.Rows.Add(dr1)
        dr1 = dt1.NewRow()
        dr1("Id") = "2"
        dr1("Descripcion") = "Venta"
        dt1.Rows.Add(dr1)
        CbTipoContrato.DataSource = dt1
        CbTipoContrato.ValueMember = "Id"
        CbTipoContrato.DisplayMember = "Descripcion"
        CbTipoContrato.SelectedValue = 2
    End Sub
    Private Sub AgregaCamposTablaClases()
        TablaClases.Columns.Clear()
        TablaClases.Columns.Add(New DataColumn("IdModoDetalle", Type.GetType("System.Int32")))
        TablaClases.Columns.Add(New DataColumn("IdModoEncabezado", Type.GetType("System.Int32")))
        TablaClases.Columns.Add(New DataColumn("Rango1", Type.GetType("System.Decimal")))
        TablaClases.Columns.Add(New DataColumn("Rango2", Type.GetType("System.Decimal")))
        TablaClases.Columns.Add(New DataColumn("Castigo", Type.GetType("System.Decimal")))
        TablaClases.Columns.Add(New DataColumn("IdEstatus", Type.GetType("System.Int32")))
    End Sub
    Private Sub AgregarClasesATabla()
        Dim index As Integer
        Dim rengloninsertar As DataRow
        TablaClases.Clear()
        DgvMicrosDetalle.EndEdit()

        For Each row As DataGridViewRow In DgvMicrosDetalle.Rows
            index = Convert.ToUInt64(row.Index)
            If DgvMicrosDetalle.Rows(index).Cells("Rango1").Value IsNot Nothing Or DgvMicrosDetalle.Rows(index).Cells("Rango2").Value IsNot Nothing Then
                rengloninsertar = TablaClases.NewRow()
                rengloninsertar("IdModoDetalle") = IIf(DgvMicrosDetalle.Rows(index).Cells("IdModoDetalle").Value Is Nothing, 0, DgvMicrosDetalle.Rows(index).Cells("IdModoDetalle").Value)
                rengloninsertar("IdModoEncabezado") = Val(TbIdMicroEncabezado.Text)
                rengloninsertar("Rango1") = DgvMicrosDetalle.Rows(index).Cells("Rango1").Value
                rengloninsertar("Rango2") = DgvMicrosDetalle.Rows(index).Cells("Rango2").Value
                rengloninsertar("Castigo") = DgvMicrosDetalle.Rows(index).Cells("Castigo").Value
                rengloninsertar("IdEstatus") = 1
                TablaClases.Rows.Add(rengloninsertar)
            End If
        Next
    End Sub
    Private Sub ConsultaModosMicros()
        Dim EntidadCastigoMicros As New Capa_Entidad.CastigoMicros
        Dim NegocioCastigoMicros As New Capa_Negocio.CastigoMicros
        Dim Tabla As New DataTable
        EntidadCastigoMicros.Consulta = Consulta.ConsultaEncabezado
        NegocioCastigoMicros.Consultar(EntidadCastigoMicros)
        DgvMicrosEncabezado.DataSource = EntidadCastigoMicros.TablaConsulta
        PropiedadesDgModos()
    End Sub
    Private Sub PropiedadesDgModos()
        DgvMicrosEncabezado.Columns("ModoComercializacion").Visible = False
    End Sub
    Private Sub ConsultaClasesClasificacionDetalle(ByVal Id As Integer)
        DgvMicrosDetalle.DataSource = Nothing
        Dim EntidadCastigoMicros As New Capa_Entidad.CastigoMicros
        Dim NegocioCastigoMicros As New Capa_Negocio.CastigoMicros
        Dim Tabla As New DataTable
        EntidadCastigoMicros.IdMicrosEncabezado = Id
        EntidadCastigoMicros.Consulta = Consulta.ConsultaDetallada
        NegocioCastigoMicros.Consultar(EntidadCastigoMicros)
        DgvMicrosDetalle.DataSource = EntidadCastigoMicros.TablaConsulta
        PropiedadesDgvDetalle()
    End Sub
    Private Sub PropiedadesDgvDetalle()
        DgvMicrosDetalle.Columns("IdModoDetalle").Visible = False
        DgvMicrosDetalle.Columns("IdModoEncabezado").Visible = False
        DgvMicrosDetalle.Columns("IdEstatus").Visible = False
    End Sub
    Private Sub Guardar()
        Dim EntidadConfigMic As New Capa_Entidad.ConfigMic
        Dim NegocioConfigMic As New Capa_Negocio.ConfigMic
        AgregarClasesATabla()
        EntidadConfigMic.IdMicrosEncabezado = IIf(TbIdMicroEncabezado.Text = "", 0, TbIdMicroEncabezado.Text)
        EntidadConfigMic.Descripcion = TbDescripcion.Text
        EntidadConfigMic.IdModoComercializacion = CbTipoContrato.SelectedValue
        EntidadConfigMic.IdEstatus = CbEstatus.SelectedValue
        EntidadConfigMic.TablaModosDetalle = TablaClases
        NegocioConfigMic.Guardar(EntidadConfigMic)
        TbIdMicroEncabezado.Text = EntidadConfigMic.IdMicrosEncabezado
        MsgBox("Realizado Correctamente")
        ConsultaModosMicros()
        ConsultaClasesClasificacionDetalle(TbIdMicroEncabezado.Text)
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If TbDescripcion.Text = "" Or CbTipoContrato.Text = "" Then
            MsgBox("No se permite guardar con campos vacios.")
        Else
            Guardar()
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub BtAgregar_Click(sender As Object, e As EventArgs) Handles BtCargaExcel.Click
        'Dim SumaKilos As Integer = 0
        importarexceltablacastigos(DgvMicrosDetalle)
        'TbTotalPacas.Text = DgvPacas.Rows.Count()
        'If DgvMicrosDetalle.Rows.Count > 0 Then
        '    For Each Fila As DataGridViewRow In DgvMicrosDetalle.Rows
        '        If Not Fila Is Nothing Then
        '            SumaKilos = SumaKilos + Fila.Cells(1).Value
        '        End If
        '    Next
        'End If
        'TbTotalKilos.Text = SumaKilos
    End Sub

    Private Sub PlantillaExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PlantillaExcelToolStripMenuItem.Click
        Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\MicConfig.xltx"
        Dim xlApp As Excel.Application
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Try
            xlApp = New Excel.Application
            'xlWorkBook = xlApp.Workbooks.Open(Application.StartupPath & "\Libro2.xlsx")
            xlWorkBook = xlApp.Workbooks.Open(Ruta)
            xlWorkSheet = xlWorkBook.Worksheets("Tabla")
            xlWorkSheet = CType(xlWorkBook.Worksheets("Tabla"), Excel.Worksheet)
            xlApp.Visible = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class