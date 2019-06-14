Imports Capa_Operacion.Configuracion
Public Class TiposUsuario
    Private Sub TiposUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
        Consultar()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
        Consultar()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Salir()
    End Sub
    Private Sub Nuevo()
        TbIdTipo.Text = ""
        TbDescripcion.Text = ""
    End Sub
    Private Sub Guardar()
        Try
            If TbDescripcion.Text <> "" Then
                Dim EntidadUsuarios As New Capa_Entidad.Usuarios
                Dim NegocioUsuarios As New Capa_Negocio.Usuarios

                Dim tabla As New DataTable
                Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
                Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
                EntidadConfiguracionParametros.Consulta = Consulta.ConsultaBaseDatos
                NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
                tabla = EntidadConfiguracionParametros.TablaConsulta
                For Each Fila As DataRow In tabla.Rows
                    EntidadUsuarios.Tipo = IIf(TbIdTipo.Text = "", 0, TbIdTipo.Text)
                    EntidadUsuarios.Descripcion = TbDescripcion.Text
                    EntidadUsuarios.BaseDeDatos = Fila("name")
                    EntidadUsuarios.Actualiza = Actuliza.ActualizaTipoUsuario
                    NegocioUsuarios.Guardar(EntidadUsuarios)
                    TbIdTipo.Text = EntidadUsuarios.Tipo
                Next
                Consultar()
            Else
                MessageBox.Show("El campo descripcion no puede estar vacio.", "Aviso")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub DgvTipoUsuario_DoubleClick(sender As Object, e As EventArgs) Handles DgvTipoUsuario.DoubleClick
        If DgvTipoUsuario.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            TbIdTipo.Text = ""
            TbDescripcion.Text = ""
            Dim index As Integer
            index = DgvTipoUsuario.CurrentCell.RowIndex
            TbIdTipo.Text = DgvTipoUsuario.Rows(index).Cells("IdTipo").Value
            TbDescripcion.Text = DgvTipoUsuario.Rows(index).Cells("Descripcion").Value
        End If
    End Sub
    Private Sub Consultar()
        Dim tabla As New DataTable
        Dim EntidadUsuarios As New Capa_Entidad.Usuarios
        Dim NegocioUsuarios As New Capa_Negocio.Usuarios
        EntidadUsuarios.Consulta = Consulta.ConsultaTipoUsuario
        NegocioUsuarios.Consultar(EntidadUsuarios)
        DgvTipoUsuario.DataSource = EntidadUsuarios.TablaConsulta
    End Sub
    Private Sub Salir()
        Close()
    End Sub
End Class