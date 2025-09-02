Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ReporteInventarioPatios
    Private folderBrowserDialog1 As FolderBrowserDialog
    Private Sub btimportaexcel_Click(sender As Object, e As EventArgs) Handles btimportaexcel.Click
        importarDoc(dgvPacas)
        tbcantidadpcas.Text = dgvPacas.RowCount
        If dgvPacas.Rows.Count = 0 Then
            MsgBox("No hay registros, revise para continuar", MsgBoxStyle.Information, "Aviso")
        Else
            cargaTabla()
            'Me.Close()
        End If
    End Sub
    Private Sub CargaExcel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Limpiar()
        CargaCombos()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpirToolStripMenuItem.Click
        Limpiar()
        CargaCombos()
    End Sub
    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        ImprimirReporte()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dispose()
        Close()
    End Sub
    Private Sub Limpiar()
        dgvPacas.DataSource = Nothing
        tbcantidadpcas.Text = ""
    End Sub
    Private Sub cargaTabla()
        TablaExcel.Columns.Clear()
        TablaExcel.Rows.Clear()
        Dim r As DataRow
        Try
            TablaExcel.Columns.Add("BaleID", Type.GetType("System.Int64"))
            For i = 0 To dgvPacas.Rows.Count - 1
                r = TablaExcel.NewRow
                r("BaleID") = dgvPacas.Item(0, i).Value
                TablaExcel.Rows.Add(r)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub CargaCombos()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        cbplantas.DataSource = Tabla
        cbplantas.ValueMember = "IdPlanta"
        cbplantas.DisplayMember = "Descripcion"
        cbplantas.SelectedValue = 0
    End Sub
    'Private Sub BtConfirma_Click(sender As Object, e As EventArgs) Handles BtConfirma.Click
    '    If dgvPacas.Rows.Count = 0 Then
    '        MsgBox("No hay registros, revise para continuar", MsgBoxStyle.Information, "Aviso")
    '    Else
    '        cargaTabla()
    '        Me.Close()
    '    End If
    'End Sub
    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btimportaexcel.Click
    '    Dim importexcel As New CargaExcel
    '    importexcel.ShowDialog()
    '    Try
    '        If TablaExcel.Rows.Count > 0 Then
    '            'For Each rowTabla As DataRow In TablaExcel.Rows
    '            '    For Each rowGrid As DataGridViewRow In dgvPacas.Rows
    '            '        If rowTabla.Item(0) = rowGrid.Cells("BaleID").Value.ToString Then
    '            '            rowGrid.Cells("Seleccionar").Value = True
    '            '        End If
    '            '    Next
    '            'Next
    '            dgvPacas.DataSource = TablaExcel
    '        End If
    '        tbcantidadpcas.Text = dgvPacas.RowCount
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    '    If TablaExcel.Rows.Count > 0 Then TablaExcel.Clear()
    'End Sub
    Private Sub ImprimirReporte()
        If dgvPacas.Rows.Count > 0 Then
            Dim RepInvPacas As New RepInventarioPacas(dgvPacas, cbplantas.Text)
            RepInvPacas.ShowDialog()
        Else
            MsgBox("No hay registros para imprimir")
        End If
    End Sub

End Class