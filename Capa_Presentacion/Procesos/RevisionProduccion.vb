Imports Capa_Operacion.Configuracion
Public Class RevisionProduccion
    Private Sub RevisionProduccion_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarCombos()
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        ConsultarOrden()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub CargarCombos()
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
    Private Sub ConsultarOrden()
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        Dim Tabla As New DataTable
        Dim ConsultaProduccion As New ConsultaProduccionRevision()
        ConsultaProduccion.ShowDialog()
        Try
            EntidadOrdenTrabajo.Consulta = Consulta.ConsultaOrdenRevision
            EntidadOrdenTrabajo.IdOrdenTrabajo = ConsultaProduccion.IdProduccion
            NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
            Tabla = EntidadOrdenTrabajo.TablaConsulta
            If Tabla.Rows.Count = 0 Then
                Exit Sub
            Else
                TbIdOrdenTrabajo.Text = Tabla.Rows(0).Item("IdOrdenTrabajo")
                TbIdProduccion.Text = Tabla.Rows(0).Item("IdProduccion")
                CbPlanta.SelectedValue = Tabla.Rows(0).Item("IdplantaOrigen")
                TbPrimerPaca.Text = Tabla.Rows(0).Item("PrimerPaca")
                TbUltimaPaca.Text = Tabla.Rows(0).Item("UltimaPaca")
                TbPacasProducidas.Text = Tabla.Rows(0).Item("PacasProducidas")
                TbPesoPromedio.Text = Tabla.Rows(0).Item("PesoPromedio")
                TbPacaLigera.Text = Tabla.Rows(0).Item("EtiquetaPacaLigera")
                TbPesoLigero.Text = Tabla.Rows(0).Item("PacaLigera")
                TbPacaPesada.Text = Tabla.Rows(0).Item("EtiquetaPacaPesada")
                TbPesoPesado.Text = Tabla.Rows(0).Item("PacaPesada")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


End Class