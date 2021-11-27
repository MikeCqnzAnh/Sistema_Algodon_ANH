Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Web
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.CrystalReports
Public Class RepHojaProduccion
    Private Sub RepHojaProduccion_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaCombo()
    End Sub
    Private Sub TbEtiquetaActual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbcantidad.KeyPress, tbfolioinicial.KeyPress, tbfoliofinal.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub limpiar()
        tbidreporte.Clear()
        CargaCombo()
        tbcantidad.Clear()
        tbfolioinicial.Clear()
        tbfoliofinal.Clear()
        dtfecha.Value = Now
        CRVHojaProduccion.ReportSource = Nothing
        CRVHojaProduccion.Refresh()
    End Sub
    Private Sub CargaCombo()
        '---Planta Origen--
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        cbplanta.DataSource = Tabla
        cbplanta.ValueMember = "IdPlanta"
        cbplanta.DisplayMember = "Descripcion"
        cbplanta.SelectedValue = 0
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiar()
    End Sub

    Private Sub tbcantidad_TextChanged(sender As Object, e As EventArgs) Handles tbcantidad.TextChanged
        tbfoliofinal.Text = Val(tbfolioinicial.Text) + (Val(tbcantidad.Text) - 1)
    End Sub

    Private Sub tbfolioinicial_TextChanged(sender As Object, e As EventArgs) Handles tbfolioinicial.TextChanged
        tbfoliofinal.Text = Val(tbfolioinicial.Text) + (Val(tbcantidad.Text) - 1)
    End Sub
    Private Function tablaetiquetas()
        Dim dtetiqueta As New DataTable
        Dim dr As DataRow
        Dim i As Integer = 0
        Dim etiqueta As Int64 = Val(tbfolioinicial.Text)
        dtetiqueta.Columns.Add(New DataColumn("Baleid", GetType(Int64)))
        Do Until i = Val(tbcantidad.Text)
            i += 1
            dr = dtetiqueta.NewRow()
            dr("Baleid") = etiqueta + i - 1
            dtetiqueta.Rows.Add(dr)
        Loop
        Return dtetiqueta
    End Function
    Private Sub GeneraReporte()
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        If tbfolioinicial.Text <> "" And tbfoliofinal.Text <> "" And tbcantidad.Text <> "" Then
            Dim CrReport As RPTHojaProduccion = New RPTHojaProduccion
            Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTHojaProduccion.rpt"
            Tabla = tablaetiquetas()
            ds.Tables.Add(Tabla)
            CrReport.Load(Ruta)
            CrReport.SetDataSource(ds.Tables("table1"))
            CRVHojaProduccion.ReportSource = CrReport
            CRVHojaProduccion.Zoom(2)
        Else
            MsgBox("No se permiten campos en blanco.", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub
    Private Sub GenerarReporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerarReporteToolStripMenuItem.Click
        Dim cadena As String = tbfolioinicial.Text
        Dim valida As Integer
        valida = cadena.Substring(tbfolioinicial.TextLength - 1)
        If valida = 1 Then
            GeneraReporte()
        Else
            MsgBox("El Folio inicial debe comenzar en 1, revisar antes de continuar.", MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub
End Class