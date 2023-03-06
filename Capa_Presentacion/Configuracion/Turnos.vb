Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class Turnos
    Private Sub Turnos_Load(sender As Object, e As EventArgs) Handles Me.Load
        cargacomboplanta()
        consultarturnos()
        cargacombousuario(cbrespprensa)
        cargacombousuario(cbrespturno)
    End Sub
    Private Sub consultarturnos()
        Dim EntidadTurnos As New Capa_Entidad.Turnos
        Dim NegocioTurnos As New Capa_Negocio.Turnos
        Dim Tabla As New DataTable
        EntidadTurnos.Consulta = Consulta.ConsultaEncabezado
        NegocioTurnos.Consultar(EntidadTurnos)
        Tabla = EntidadTurnos.TablaConsulta
        dgvturnos.DataSource = Tabla
        dgvpropiedad()
    End Sub
    Private Sub cargacomboplanta()
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
    Private Sub cargacombousuario(ByVal cmb As ComboBox)
        Dim EntidadUsuarios As New Capa_Entidad.Usuarios
        Dim NegocioUsuarios As New Capa_Negocio.Usuarios
        Dim Tabla As New DataTable
        Try
            EntidadUsuarios.Consulta = Consulta.ConsultaUsuario
            NegocioUsuarios.Consultar(EntidadUsuarios)
            Tabla = EntidadUsuarios.TablaConsulta
            cmb.DataSource = Tabla
            cmb.ValueMember = "idusuario"
            cmb.DisplayMember = "nombre"
            cmb.SelectedValue = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub limpiar()
        tbidturnoenc.Text = ""
        tbdescripcion.Text = ""
        dthoraentrada.Value = Now
        dthorasalida.Value = Now
        consultarturnos()
        cbrespprensa.SelectedValue = 0
        cbrespturno.SelectedValue = 0
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
            EntidadTurnos.idresponsableturno = cbrespturno.SelectedValue
            EntidadTurnos.responsableturno = cbrespturno.Text
            EntidadTurnos.idresponsableprensa = cbrespprensa.SelectedValue
            EntidadTurnos.responsableprensa = cbrespprensa.Text
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
        If tbdescripcion.Text <> "" Then
            Guardar()
            consultarturnos()
        Else
            MsgBox("No se permite campos en blanco.")
        End If
    End Sub

    Private Sub dgvturnos_DoubleClick(sender As Object, e As EventArgs) Handles dgvturnos.DoubleClick
        If dgvturnos.RowCount = 0 Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = dgvturnos.CurrentCell.RowIndex
            tbidturnoenc.Text = dgvturnos.Rows(index).Cells("idturnoenc").Value
            tbdescripcion.Text = dgvturnos.Rows(index).Cells("Descripcion").Value
            cbplanta.SelectedValue = dgvturnos.Rows(index).Cells("idplanta").Value
            cbrespturno.SelectedValue = dgvturnos.Rows(index).Cells("idresponsableturno").Value
            cbrespprensa.SelectedValue = dgvturnos.Rows(index).Cells("idresponsableprensa").Value
            dthoraentrada.Value = Now.Date + dgvturnos.Rows(index).Cells("HoraEntrada").Value
            dthorasalida.Value = Now.Date + dgvturnos.Rows(index).Cells("HoraSalida").Value
        End If
    End Sub
    Private Sub dgvpropiedad()
        dgvturnos.Columns("idturnoenc").HeaderText = "ID"
        dgvturnos.Columns("HoraEntrada").HeaderText = "HORA DE ENTRADA"
        dgvturnos.Columns("HoraSalida").HeaderText = "HORA DE SALIDA"
        dgvturnos.Columns("idplanta").Visible = False
        dgvturnos.Columns("idresponsableturno").Visible = False
        dgvturnos.Columns("idresponsableprensa").Visible = False
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiar()
    End Sub
End Class