Imports System.Data.SqlClient
Imports Capa_Operacion.Configuracion
Public Class Asociaciones
    Private Sub Asociaciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombos()
        Consultar()
        Limpiar()
    End Sub

    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadAsociaciones As New Capa_Entidad.Asociaciones
        Dim NegocioAsociaciones As New Capa_Negocio.Asociaciones
        If TbDescripcion.Text = "" Then
            MsgBox("Verificar los campos vacios")
            Exit Sub
        End If
        EntidadAsociaciones.IdAsociacion = IIf(TbIdAsociacion.Text = "", 0, TbIdAsociacion.Text)
        EntidadAsociaciones.Descripcion = TbDescripcion.Text
        EntidadAsociaciones.IdEstatus = CbEstatus.SelectedValue
        EntidadAsociaciones.IdUsuarioCreacion = 1
        EntidadAsociaciones.FechaCreacion = Now
        NegocioAsociaciones.Guardar(EntidadAsociaciones)
        GeneraRegistroBitacora(Me.Text.Clone.ToString, IIf(TbIdAsociacion.Text <> "", "Actualizar", "Guardar"))
        TbIdAsociacion.Text = EntidadAsociaciones.IdAsociacion
        Consultar()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Limpiar()
        TbIdAsociacion.Text = ""
        TbDescripcion.Text = ""
        CbEstatus.SelectedValue = 1
    End Sub

    Private Sub LlenarCombos()
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

    Private Sub Consultar()
        Dim EntidadAsociaciones As New Capa_Entidad.Asociaciones
        Dim NegocioAsociaciones As New Capa_Negocio.Asociaciones
        Dim Tabla As New DataTable
        EntidadAsociaciones.Consulta = Consulta.ConsultaDetallada
        NegocioAsociaciones.Consultar(EntidadAsociaciones)
        Tabla = EntidadAsociaciones.TablaConsulta
        DgvAsociaciones.Columns.Clear()
        DgvAsociaciones.DataSource = Tabla
        FormatoGridview()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        Dim EntidadAsociaciones As New Capa_Entidad.Asociaciones
        Dim NegocioAsociaciones As New Capa_Negocio.Asociaciones
        If TbIdAsociacion.Text = "" Then
            MsgBox("Por favor, seleccione un registro", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
            Exit Sub
        End If
        EntidadAsociaciones.Eliminar = Eliminar.EliminarREgistro
        EntidadAsociaciones.IdAsociacion = TbIdAsociacion.Text
        NegocioAsociaciones.Eliminar(EntidadAsociaciones)
        GeneraRegistroBitacora(Me.Text.Clone.ToString, EliminarToolStripMenuItem.Text)
        Consultar()
        Limpiar()
        MsgBox("Registro eliminado con éxito", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
    End Sub

    Private Sub DgvAsociaciones_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvAsociaciones.CellContentDoubleClick
        If DgvAsociaciones.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvAsociaciones.CurrentCell.RowIndex
            TbIdAsociacion.Text = DgvAsociaciones.Rows(index).Cells("IdAsociacion").Value
            TbDescripcion.Text = DgvAsociaciones.Rows(index).Cells("Descripcion").Value
            CbEstatus.SelectedValue = DgvAsociaciones.Rows(index).Cells("IdEstatus").Value
        End If
    End Sub

    Private Sub FormatoGridview()
        DgvAsociaciones.Columns("IdAsociacion").HeaderText = "ID"
        DgvAsociaciones.Columns("Descripcion").HeaderText = "Asociación"
        DgvAsociaciones.Columns("IdEstatus").HeaderText = "Estatus"
    End Sub
End Class