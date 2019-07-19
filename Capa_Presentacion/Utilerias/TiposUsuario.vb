Imports Capa_Operacion.Configuracion
Public Class TiposUsuario
    Dim TablaEnc As New DataTable
    Private Sub TiposUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
        Consultar()
        llenaTablaMenuRoles()
        CrearNodosDelPadre(0, Nothing)
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
        Consultar()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
        RecorreTv(TVRoles)
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Salir()
    End Sub
    Private Sub Nuevo()
        TbIdTipo.Text = ""
        TbDescripcion.Text = ""
        'ConsultaRolPredefinido()
        'CallRecursive(TVRoles)
    End Sub
    Private Sub llenaTablaMenuRoles()
        Dim EntidadRoles As New Capa_Entidad.Roles
        Dim NegocioRoles As New Capa_Negocio.Roles
        EntidadRoles.Consulta = Consulta.ConsultaBasica
        NegocioRoles.Consultar(EntidadRoles)
        TablaEnc = EntidadRoles.TablaConsulta
        TVRoles.Nodes.Clear()
    End Sub
    Private Sub CrearNodosDelPadre(ByVal indicePadre As Integer, ByVal nodePadre As TreeNode)
        Dim dataViewHijos As DataView
        dataViewHijos = New DataView(TablaEnc)
        dataViewHijos.RowFilter = TablaEnc.Columns("IdPadre").ColumnName + " = " + indicePadre.ToString()
        For Each dataRowCurrent As DataRowView In dataViewHijos
            Dim nuevoNodo As New TreeNode
            nuevoNodo.Text = dataRowCurrent("Descripcion").ToString().Trim()
            nuevoNodo.Tag = dataRowCurrent("IdMenuRoles").ToString().Trim() & "," & dataRowCurrent("Descripcion").ToString().Trim() & "," & dataRowCurrent("IdPadre").ToString().Trim() & "," & dataRowCurrent("IdEstatus").ToString().Trim()
            If nodePadre Is Nothing Then
                TVRoles.Nodes.Add(nuevoNodo)
            Else
                nodePadre.Nodes.Add(nuevoNodo)
            End If
            CrearNodosDelPadre(Int32.Parse(dataRowCurrent("IdMenuRoles").ToString()), nuevoNodo)
        Next dataRowCurrent
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
            ConsultaRolPredefinido()
            CallRecursive(TVRoles)
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
    Private Sub ConsultaRolPredefinido()
        Dim EntidadRoles As New Capa_Entidad.Roles
        Dim NegocioRoles As New Capa_Negocio.Roles
        EntidadRoles.IdTipoUsuario = TbIdTipo.Text
        EntidadRoles.Consulta = Consulta.ConsultaDetallada
        NegocioRoles.Consultar(EntidadRoles)
        TablaEnc = EntidadRoles.TablaConsulta
    End Sub
    Private Sub PrintRecursive(ByVal n As TreeNode)
        'Dim EntidadRoles As New Capa_Entidad.Roles
        'Dim NegocioRoles As New Capa_Negocio.Roles
        ''System.Diagnostics.Debug.WriteLine(n.Tag) 'Muestra el texto del nodo en la ventana de inmediato
        ''MessageBox.Show(n.Tag) 'Muestra el mismo mensaje por pantalla
        Dim lineText As String = n.Tag
        Dim ArrayText() As String
        ArrayText = lineText.Split(",")
        Try
            Dim te As Integer
            For Each Tb As DataRow In TablaEnc.Rows
                If ArrayText(0) = Tb("IdNodo") Then
                    n.Checked = Tb("IdEstatus")
                End If

            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
        Dim aNode As TreeNode
        'Por cada nodo de la raíz
        For Each aNode In n.Nodes
            PrintRecursive(aNode)
        Next
    End Sub

    Private Sub CallRecursive(ByVal aTreeView As TreeView)
        Dim n As TreeNode
        'Por cada raíz
        For Each n In aTreeView.Nodes
            PrintRecursive(n)
        Next
    End Sub
    Private Sub RecorreTv(ByVal ATreeView As TreeView)
        Dim n As TreeNode
        'Por cada raíz
        For Each n In ATreeView.Nodes
            Recursive(n)
        Next
    End Sub
    Private Sub Recursive(ByVal n As TreeNode)
        Dim lineText As String = n.Tag
        Dim ArrayText() As String
        ArrayText = lineText.Split(",")
        Try

            AgregaOpcion(ArrayText(0), ArrayText(2), ArrayText(3))

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
        Dim aNode As TreeNode
        'Por cada nodo de la raíz
        For Each aNode In n.Nodes
            Recursive(aNode)
        Next
    End Sub
    Private Sub AgregaOpcion(ByVal Nodo As Integer, ByVal NodoPadre As Integer, ByVal Estatus As Boolean)

        Dim EntidadRoles As New Capa_Entidad.Roles
        Dim NegocioRoles As New Capa_Negocio.Roles
        Try
            EntidadRoles.IdPerfilUsuario = 0
            EntidadRoles.IdUsuario = 0
            EntidadRoles.IdNodo = Nodo
            EntidadRoles.IdPadre = NodoPadre
            EntidadRoles.IdTipoUsuario = TbIdTipo.Text
            EntidadRoles.IdEstatus = Estatus
            EntidadRoles.Agrega = Agrega.AgregaRolPredefinido
            NegocioRoles.Agregar(EntidadRoles)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            'MsgBox("Realizado Correctamente")
        End Try

    End Sub
    Private Sub Salir()
        Close()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        TVRoles.ExpandAll()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        TVRoles.CollapseAll()
    End Sub
End Class