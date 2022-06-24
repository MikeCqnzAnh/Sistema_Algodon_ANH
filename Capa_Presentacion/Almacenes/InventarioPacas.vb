Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Imports System.IO
Imports Microsoft.Office.Interop

Public Class InventarioPacas
    Private Sub InventarioPacas_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConsultaLotes()
        ConsultaPacas()
        CargaCombos()
    End Sub
    Private Sub ConsultaLotes()
        Dim EntidadInventarioPacas As New Capa_Entidad.InventarioPacas
        Dim NegocioInventarioPacas As New Capa_Negocio.InventarioPacas
        Try
            Dim tabla As New DataTable
            EntidadInventarioPacas.Consulta = Consulta.ConsultaEncabezado
            EntidadInventarioPacas.IdComprador = Val(tbidcomprador.Text)
            EntidadInventarioPacas.NoLote = cblotes.Text
            EntidadInventarioPacas.IdPlanta = cbplantas.SelectedValue
            EntidadInventarioPacas.SinComprador = cksincomprador.Checked
            EntidadInventarioPacas.SinLote = ckSinlote.Checked
            NegocioInventarioPacas.Consultar(EntidadInventarioPacas)
            dgvlotes.DataSource = EntidadInventarioPacas.TablaConsulta
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultaPacas()
        Dim EntidadInventarioPacas As New Capa_Entidad.InventarioPacas
        Dim NegocioInventarioPacas As New Capa_Negocio.InventarioPacas
        Try
            Dim tabla As New DataTable
            EntidadInventarioPacas.Consulta = Consulta.ConsultaDetallada
            EntidadInventarioPacas.IdComprador = Val(tbidcomprador.Text)
            EntidadInventarioPacas.NoLote = cblotes.Text
            EntidadInventarioPacas.IdPlanta = cbplantas.SelectedValue
            EntidadInventarioPacas.SinComprador = cksincomprador.Checked
            EntidadInventarioPacas.SinLote = ckSinlote.Checked
            NegocioInventarioPacas.Consultar(EntidadInventarioPacas)
            dgvpacas.DataSource = EntidadInventarioPacas.TablaConsulta
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultaCombo()
        Dim EntidadInventarioPacas As New Capa_Entidad.InventarioPacas
        Dim NegocioInventarioPacas As New Capa_Negocio.InventarioPacas
        Try
            Dim tabla As New DataTable
            EntidadInventarioPacas.Consulta = Consulta.ConsultaComboLotes
            EntidadInventarioPacas.IdComprador = Val(tbidcomprador.Text)
            NegocioInventarioPacas.Consultar(EntidadInventarioPacas)
            tabla = EntidadInventarioPacas.TablaConsulta
            CbLotes.DataSource = tabla
            cblotes.ValueMember = "Nolote"
            cblotes.DisplayMember = "Nolote"
            CbLotes.SelectedIndex = -1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ExportarToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem1.Click
        If dgvlotes.Rows.Count > 0 Then
            exportdgvtoexcel(dgvlotes, "Export Lotes")
        Else
            MsgBox("No hay datos para exportar.")
        End If
    End Sub
    Private Sub ExportarToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ExportarToolStripMenuItem2.Click
        If DgvPacas.Rows.Count > 0 Then
            exportdgvtoexcel(DgvPacas, "Export Pacas")
        Else
            MsgBox("No hay datos para exportar.")
        End If
    End Sub
    Private Sub tbconsultarcomprador_Click(sender As Object, e As EventArgs) Handles tbconsultarcomprador.Click
        Dim consultacomprador As New ConsultaCompradoresSalidas
        consultacomprador.ShowDialog()
        If consultacomprador.Id > 0 Then
            tbidcomprador.Text = consultacomprador.Id
            tbcomprador.Text = consultacomprador.Nombre
            ConsultaCombo()
        End If
    End Sub

    Private Sub btbuscar_Click(sender As Object, e As EventArgs) Handles btbuscar.Click
        ConsultaLotes()
        ConsultaPacas()
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
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        tbcomprador.Clear()
        tbidcomprador.Clear()
        cksincomprador.Checked = False
        ckSinlote.Checked = False
        cblotes.DataSource = Nothing
        cblotes.Items.Clear()
        CargaCombos()
        ConsultaLotes()
        ConsultaPacas()
    End Sub
    Private Sub FormatoInventarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormatoInventarioToolStripMenuItem.Click
        Dim repinv As New ReporteInventarioPatios
        repinv.ShowDialog()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub


End Class
