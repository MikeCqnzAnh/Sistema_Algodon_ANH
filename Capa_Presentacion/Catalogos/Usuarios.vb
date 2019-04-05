Imports Capa_Operacion.Configuracion
Public Class Usuarios
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaCombo()
        Nuevo()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub
    Private Sub LlenaCombo()
        Dim tabla As New DataTable
        Dim EntidadUsuarios As New Capa_Entidad.Usuarios
        Dim NegocioUsuarios As New Capa_Negocio.Usuarios
        EntidadUsuarios.Consulta = Consulta.ConsultaUsuario
        NegocioUsuarios.Consultar(EntidadUsuarios)
        tabla = EntidadUsuarios.TablaConsulta
        CbTipoUsuario.DataSource = tabla
        CbTipoUsuario.ValueMember = "IdTipo"
        CbTipoUsuario.DisplayMember = "Descripcion"
        CbTipoUsuario.SelectedValue = -1
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
    End Sub
    Private Sub Guardar()
        Dim Encriptar As New Encriptar
        Dim EntidadUsuarios As New Capa_Entidad.Usuarios
        Dim NegocioUsuarios As New Capa_Negocio.Usuarios
        If TbNombre.Text = "" Or TbPassword.Text = "" Or TbUsuario.Text = "" Or CbTipoUsuario.Text = "" Then
            MsgBox("Verificar los campos vacios")
            Exit Sub
        End If
        Try
            EntidadUsuarios.IdUsuario = IIf(TbIdUsuario.Text = "", 0, TbIdUsuario.Text)
            EntidadUsuarios.Nombre = TbNombre.Text
            EntidadUsuarios.Usuario = TbUsuario.Text
            EntidadUsuarios.Password = Encriptar.Encriptar(TbPassword.Text)
            EntidadUsuarios.Tipo = CbTipoUsuario.SelectedValue
            NegocioUsuarios.Guardar(EntidadUsuarios)
            TbIdUsuario.Text = EntidadUsuarios.IdUsuario
            Consultar()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GeneraRegistroBitacora(Me.Text.Clone.ToString, GuardarToolStripMenuItem.Text, TbIdUsuario.Text, TbNombre.Text)
            MessageBox.Show("Se realizo el proceso correctamente!")
        End Try
    End Sub
    Private Sub Consultar()
        Dim EntidadUsuarios As New Capa_Entidad.Usuarios
        Dim NegocioUsuarios As New Capa_Negocio.Usuarios
        Dim Tabla As New DataTable
        Try
            EntidadUsuarios.Consulta = Consulta.ConsultaBasica
            NegocioUsuarios.Consultar(EntidadUsuarios)
            Tabla = EntidadUsuarios.TablaConsulta
            DgvUsuarios.Columns.Clear()
            DgvUsuarios.DataSource = Tabla
            FortmatoDGV()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub FortmatoDGV()
        DgvUsuarios.Columns("Tipo").Visible = False
    End Sub
    Private Sub Nuevo()
        TbIdUsuario.Text = ""
        TbNombre.Text = ""
        TbUsuario.Text = ""
        TbPassword.Text = ""
        CbTipoUsuario.SelectedIndex = -1
        CbEstatus.SelectedIndex = -1
        Consultar()
    End Sub
    Private Sub DgvUsuarios_DoubleClick(sender As Object, e As EventArgs) Handles DgvUsuarios.DoubleClick
        If DgvUsuarios.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            TbIdUsuario.Text = ""
            TbNombre.Text = ""
            TbUsuario.Text = ""
            TbPassword.Text = ""
            CbTipoUsuario.SelectedIndex = -1
            CbEstatus.SelectedIndex = -1
            Dim index As Integer
            index = DgvUsuarios.CurrentCell.RowIndex
            TbIdUsuario.Text = DgvUsuarios.Rows(index).Cells("IdUsuario").Value
            TbNombre.Text = DgvUsuarios.Rows(index).Cells("Nombre").Value
            TbUsuario.Text = DgvUsuarios.Rows(index).Cells("Usuario").Value
            CbTipoUsuario.SelectedValue = DgvUsuarios.Rows(index).Cells("Tipo").Value
        End If
    End Sub
End Class