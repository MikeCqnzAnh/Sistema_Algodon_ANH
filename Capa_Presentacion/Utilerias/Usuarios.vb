Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Capa_Operacion.Configuracion
Public Class Usuarios
    Dim TablaEnc As New DataTable
    Private Sub Usuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaCombo()
        Nuevo()
        llenaTablaMenuRoles()
        CrearNodosDelPadre(0, Nothing)
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
        EntidadUsuarios.Consulta = Consulta.ConsultaTipoUsuario
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
            Dim tabla As New DataTable
            Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
            Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
            EntidadConfiguracionParametros.Consulta = Consulta.ConsultaBaseDatos
            NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
            tabla = EntidadConfiguracionParametros.TablaConsulta
            For Each Fila As DataRow In tabla.Rows
                EntidadUsuarios.Actualiza = Actuliza.ActualizaUsuario
                EntidadUsuarios.IdUsuario = IIf(TbIdUsuario.Text = "", 0, TbIdUsuario.Text)
                EntidadUsuarios.Nombre = TbNombre.Text
                EntidadUsuarios.Usuario = TbUsuario.Text
                EntidadUsuarios.Password = Encriptar.Encriptar(TbPassword.Text)
                EntidadUsuarios.Tipo = CbTipoUsuario.SelectedValue
                EntidadUsuarios.Estatus = CbEstatus.SelectedValue
                EntidadUsuarios.BaseDeDatos = Fila("name")
                NegocioUsuarios.Guardar(EntidadUsuarios)
                TbIdUsuario.Text = EntidadUsuarios.IdUsuario
            Next
            actualizaVariableDbb()
            Consultar()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GeneraRegistroBitacora(Me.Text.Clone.ToString, GuardarToolStripMenuItem.Text, TbIdUsuario.Text, TbNombre.Text)
            MessageBox.Show("Se realizo el proceso correctamente!")
        End Try
    End Sub
    Private Sub actualizaVariableDbb()
        Dim EntidadUsuarios As New Capa_Entidad.Usuarios
        Dim NegocioUsuarios As New Capa_Negocio.Usuarios
        EntidadUsuarios.BaseDeDatos = TbBddActual.Text
        NegocioUsuarios.ActualizaVariableBdd(EntidadUsuarios)
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
        TbBddActual.Text = BaseDeDatos
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
            CbEstatus.SelectedValue = DgvUsuarios.Rows(index).Cells("Estatus").Value
        End If
    End Sub
    Private Sub llenaTablaMenuRoles()
        Dim EntidadRoles As New Capa_Entidad.Roles
        Dim NegocioRoles As New Capa_Negocio.Roles
        EntidadRoles.Consulta = Consulta.ConsultaBasica
        NegocioRoles.Consultar(EntidadRoles)
        TablaEnc = EntidadRoles.TablaConsulta
        TvRoles.Nodes.Clear()
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
                TvRoles.Nodes.Add(nuevoNodo)
            Else
                nodePadre.Nodes.Add(nuevoNodo)
            End If
            CrearNodosDelPadre(Int32.Parse(dataRowCurrent("IdMenuRoles").ToString()), nuevoNodo)
        Next dataRowCurrent
    End Sub
    Private Sub TipoUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoUsuarioToolStripMenuItem.Click
        TiposUsuario.ShowDialog()
        LlenaCombo()
    End Sub
    Private Sub TVRoles_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles TVRoles.AfterCheck
        If (e.Action = TreeViewAction.Unknown) Then Return
        If (e.Node.Nodes.Count > 0) Then
            Me.CheckAllChildNodes(e.Node, e.Node.Checked)
        Else
            Dim parent As TreeNode = e.Node.Parent
            If (Not parent Is Nothing) Then
                If (Not e.Node.Checked) Then
                    parent.Checked = False
                Else
                    Dim items As TreeNode() = (From item As TreeNode In parent.Nodes.OfType(Of TreeNode)()
                                               Where item.Checked
                                               Select item).ToArray()
                    parent.Checked = (items.Count = parent.Nodes.Count)
                End If
            End If
        End If
    End Sub
    Private Sub CheckAllChildNodes(treeNode As TreeNode, nodeChecked As Boolean)
        For Each node As TreeNode In treeNode.Nodes
            node.Checked = nodeChecked
            If (node.Nodes.Count > 0) Then
                Me.CheckAllChildNodes(node, nodeChecked)
            End If
        Next
    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        TVRoles.ExpandAll()
    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        TVRoles.CollapseAll()
    End Sub
    Private Sub CbTipoUsuario_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbTipoUsuario.SelectionChangeCommitted

    End Sub
    Private Sub RecorrerTV()
        'Se Declara una colección de nodos apartir de tu Treeview
        'del que se va a recorrer
        Dim nodes As TreeNodeCollection = TVRoles.Nodes
        'Se recorren los nodos principales
        For Each n As TreeNode In nodes
            'Se Declara un metodo para que recorra los hijos de los principales
            'Y los hijos de los hijos....Recorrido Total en pocas palabras
            'Para ello se envía el nodo actual para evaluar si tiene hijos
            RecorrerNodos(n)
        Next
    End Sub
    Private Sub RecorrerNodos(treeNode As TreeNode)
        Try
            'Si el nodo que recibimos tiene hijos se recorrerá
            'para luego verificar si esta o no checado
            For Each tn As TreeNode In treeNode.Nodes
                'Se Verifica si esta marcado...
                'If tn.Checked = True Then
                'Si esta marcado mostramos el texto del nodo
                MessageBox.Show(tn.Tag)
                'End If
                'Ahora hago verificacion a los hijos del nodo actual            
                'Esta iteración no acabara hasta llegar al ultimo nodo principal
                RecorrerNodos(tn)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub PrintRecursive(ByVal n As TreeNode)
        Dim EntidadRoles As New Capa_Entidad.Roles
        Dim NegocioRoles As New Capa_Negocio.Roles
        'System.Diagnostics.Debug.WriteLine(n.Tag) 'Muestra el texto del nodo en la ventana de inmediato
        'MessageBox.Show(n.Tag) 'Muestra el mismo mensaje por pantalla
        Dim lineText As String = n.Tag
        Dim ArrayText() As String
        ArrayText = lineText.Split(",")
        Try
            For Each s In ArrayText
                EntidadRoles.IdPerfilUsuario = 0
                EntidadRoles.IdUsuario = 0 'TbIdUsuario.Text
                EntidadRoles.IdNodo = ArrayText(0)
                EntidadRoles.IdPadre = ArrayText(2)
                EntidadRoles.IdTipoUsuario = CbTipoUsuario.SelectedValue
                EntidadRoles.IdEstatus = n.Checked
                EntidadRoles.Agrega = Agrega.AgregaRol
                NegocioRoles.Agregar(EntidadRoles)
                Exit For
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CallRecursive(TVRoles)
    End Sub
End Class