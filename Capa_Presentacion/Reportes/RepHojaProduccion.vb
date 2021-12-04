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
        CargaComboPaquetes()
    End Sub
    Private Sub TbEtiquetaActual_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbcantidad.KeyPress, tbfolioinicial.KeyPress, tbfoliofinal.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub limpiar()
        tbidreporte.Clear()
        CargaCombo()
        CargaComboPaquetes()
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
    Private Sub CargaComboPaquetes()
        Dim dt As New DataTable
        dt = New DataTable("Tabla")

        dt.Columns.Add("Codigo")
        dt.Columns.Add("Descripcion")

        Dim dr As DataRow

        dr = dt.NewRow()
        dr("Codigo") = 1
        dr(1) = 1
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = 2
        dr(1) = 2
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = 3
        dr(1) = 3
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = 4
        dr(1) = 4
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = 5
        dr(1) = 5
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = 6
        dr(1) = 6
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = 7
        dr(1) = 7
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = 8
        dr(1) = 8
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = 9
        dr(1) = 9
        dt.Rows.Add(dr)

        dr = dt.NewRow()
        dr("Codigo") = 10
        dr(1) = 10
        dt.Rows.Add(dr)

        cbpaquetes.DataSource = dt
        cbpaquetes.ValueMember = "Codigo"
        cbpaquetes.DisplayMember = "Descripcion"
        cbpaquetes.SelectedIndex = -1
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
        If rbpaquetes.Checked = True Then
            Do Until i = 500 * CInt(cbpaquetes.Text)
                i += 1
                dr = dtetiqueta.NewRow()
                dr("Baleid") = etiqueta + i - 1
                dtetiqueta.Rows.Add(dr)
            Loop
        ElseIf rbcantidadpacas.Checked = True Then
            Do Until i = Val(tbcantidad.Text)
                i += 1
                dr = dtetiqueta.NewRow()
                dr("Baleid") = etiqueta + i - 1
                dtetiqueta.Rows.Add(dr)
            Loop
        End If
        Return dtetiqueta
    End Function
    Private Sub GeneraReporte()
        Dim Tabla As New DataTable
        Dim ds As New DataSet
        If tbfolioinicial.Text <> "" And tbfoliofinal.Text <> "" And tbcantidad.Text <> "" And rbcantidadpacas.Checked = True Then
            Dim CrReport As RPTHojaProduccion = New RPTHojaProduccion
            Dim Ruta As String = Application.StartupPath & "\Reportes\RPT\RPTHojaProduccion.rpt"
            Tabla = tablaetiquetas()
            ds.Tables.Add(Tabla)
            CrReport.Load(Ruta)
            CrReport.SetDataSource(ds.Tables("table1"))
            CRVHojaProduccion.ReportSource = CrReport
            CRVHojaProduccion.Zoom(2)
        ElseIf tbfolioinicial.Text <> "" And tbfoliofinal.Text <> "" And cbpaquetes.Text <> "" And rbpaquetes.Checked = True Then
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
        Try
            valida = cadena.Substring(tbfolioinicial.TextLength - 1)
            If valida = 1 Then
                GeneraReporte()
            Else
                MsgBox("El Folio inicial debe comenzar en 1, revisar antes de continuar.", MsgBoxStyle.Exclamation, "Aviso")
            End If
        Catch ex As Exception
            MsgBox("Error: Campos en blanco o " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cbpaquetes_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbpaquetes.SelectionChangeCommitted
        If tbfolioinicial.Text <> "" Then
            tbfoliofinal.Text = (Val(cbpaquetes.Text) * 500) + tbfolioinicial.Text - 1
        End If
    End Sub

    Private Sub rbcantidadpacas_CheckedChanged(sender As Object, e As EventArgs) Handles rbcantidadpacas.CheckedChanged
        If rbcantidadpacas.Checked = True Then
            tbcantidad.Enabled = True
            cbpaquetes.SelectedIndex = -1
            cbpaquetes.Enabled = False
            tbcantidad.Text = ""
        End If
    End Sub

    Private Sub rbpaquetes_CheckedChanged(sender As Object, e As EventArgs) Handles rbpaquetes.CheckedChanged
        If rbpaquetes.Checked = True Then
            tbcantidad.Enabled = False
            cbpaquetes.Enabled = True
            cbpaquetes.SelectedIndex = -1
            tbcantidad.Text = ""
        End If
    End Sub

    Private Sub cbpaquetes_TextChanged(sender As Object, e As EventArgs) Handles cbpaquetes.TextChanged
        If tbfolioinicial.Text <> "" Then
            tbfoliofinal.Text = (Val(cbpaquetes.Text) * 500) + tbfolioinicial.Text - 1
        End If
    End Sub
End Class