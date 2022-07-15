Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class Turnos
    Private Sub Turnos_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarCombos()
        consultarturnos()
    End Sub
    Private Sub consultarturnos()
        Dim EntidadTurnos As New Capa_Entidad.Turnos
        Dim NegocioTurnos As New Capa_Negocio.Turnos
        Dim Tabla As New DataTable
        EntidadTurnos.Consulta = Consulta.ConsultaEncabezado
        NegocioTurnos.Consultar(EntidadTurnos)
        Tabla = EntidadTurnos.TablaConsulta
        dgvturnos.DataSource = Tabla
    End Sub
    Private Sub CargarCombos()
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
    Private Sub Guardar()
        Dim EntidadTurnos As New Capa_Entidad.Turnos
        Dim NegocioTurnos As New Capa_Negocio.Turnos
        Dim Tabla As New DataTable
        Try
            EntidadTurnos.Guarda = Capa_Operacion.Configuracion.Guardar.GuardarEncabezado
            EntidadTurnos.idturnoenc = IIf(Val(tbidturnoenc.Text) = 0, 0, tbidturnoenc.Text)
            EntidadTurnos.descripcion = tbdescripcion.Text
            EntidadTurnos.idplanta = cbplanta.SelectedValue
            EntidadTurnos.horaentrada = dthoraentrada.Value.TimeOfDay
            EntidadTurnos.horasalida = dthorasalida.Value.TimeOfDay
            NegocioTurnos.Guardar(EntidadTurnos)
            tbidturnoenc.Text = EntidadTurnos.idturnoenc
            MsgBox("Guardado con exito")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
        consultarturnos()
    End Sub

    Private Sub dgvturnos_DoubleClick(sender As Object, e As EventArgs) Handles dgvturnos.DoubleClick
        If dgvturnos.RowCount = 0 Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = dgvturnos.CurrentCell.RowIndex
            tbidturnoenc.Text = dgvturnos.Rows(index).Cells("idturnoenc").Value
            tbdescripcion.Text = dgvturnos.Rows(index).Cells("Descripcion").Value
            cbplanta.SelectedValue = dgvturnos.Rows(index).Cells("IdPlanta").Value
            dthoraentrada.Value = Now.Date + dgvturnos.Rows(index).Cells("HoraEntrada").Value
            dthorasalida.Value = Now.Date + dgvturnos.Rows(index).Cells("HoraSalida").Value
        End If
    End Sub
End Class