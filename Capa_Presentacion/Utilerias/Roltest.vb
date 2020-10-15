Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Capa_Operacion.Configuracion
Public Class Roltest
    Private m_ctlTriStateTreeView As  TriStateTreeView
    Private TablaEnc As New DataTable
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        llenaTablaMenuRoles()
        CreaTreeview()

    End Sub
    Private Sub CreaTreeview()

        Dim objTreeNodeRoot As TreeNode
        Dim objTreeNode1 As TreeNode
        Dim objTreeNode2 As TreeNode
        Dim objTreeNode11 As TreeNode
        Dim objTreeNode12 As TreeNode
        Dim objTreeNode13 As TreeNode
        Dim objTreeNode131 As TreeNode
        Dim objTreeNode21 As TreeNode
        Dim objTreeNode22 As TreeNode
        Dim objTreeNode221 As TreeNode
        Dim objTreeNode222 As TreeNode

        m_ctlTriStateTreeView = New TriStateTreeView(Me.StateImageList, True, True)

        Me.Controls.Add(m_ctlTriStateTreeView)
        m_ctlTriStateTreeView.Left = 0
        m_ctlTriStateTreeView.Top = 0
        m_ctlTriStateTreeView.Anchor = AnchorStyles.Left
        m_ctlTriStateTreeView.Anchor = AnchorStyles.Top
        m_ctlTriStateTreeView.Width = 200
        m_ctlTriStateTreeView.Height = 320
        m_ctlTriStateTreeView.Location = New System.Drawing.Point(12, 30)

        'objTreeNodeRoot = m_ctlTriStateTreeView.AddTreeNode(m_ctlTriStateTreeView.Nodes, "My Computer", CheckBoxState.None)

        CrearNodosDelPadre(0, Nothing)

        'Se Declara una colección de nodos apartir de tu Treeview
        'del que se va a recorrer
        Dim nodes As TreeNodeCollection = TvRoles.Nodes
        'Se recorren los nodos principales
        For Each n As TreeNode In nodes
            'Se Declara un metodo para que recorra los hijos de los principales
            'Y los hijos de los hijos....Recorrido Total en pocas palabras
            'Para ello se envía el nodo actual para evaluar si tiene hijos
            m_ctlTriStateTreeView.AddTreeNode(n.Nodes, n.NextNode.Text, CheckBoxState.Unchecked)
            RecorrerNodos(n)
        Next

        'objTreeNode1 = m_ctlTriStateTreeView.AddTreeNode(objTreeNodeRoot.Nodes, "Folder 1", CheckBoxState.Unchecked)
        'objTreeNode11 = m_ctlTriStateTreeView.AddTreeNode(objTreeNode1.Nodes, "File 11", CheckBoxState.Unchecked)
        'objTreeNode12 = m_ctlTriStateTreeView.AddTreeNode(objTreeNode1.Nodes, "File 12", CheckBoxState.Unchecked)
        'objTreeNode13 = m_ctlTriStateTreeView.AddTreeNode(objTreeNode1.Nodes, "Folder 13", CheckBoxState.Unchecked)
        'objTreeNode131 = m_ctlTriStateTreeView.AddTreeNode(objTreeNode13.Nodes, "File 131", CheckBoxState.Unchecked)

        'objTreeNode2 = m_ctlTriStateTreeView.AddTreeNode(objTreeNodeRoot.Nodes, "Folder 2", CheckBoxState.Unchecked)
        'objTreeNode21 = m_ctlTriStateTreeView.AddTreeNode(objTreeNode2.Nodes, "File 21", CheckBoxState.Unchecked)
        'objTreeNode22 = m_ctlTriStateTreeView.AddTreeNode(objTreeNode2.Nodes, "Folder 22", CheckBoxState.Unchecked)
        'objTreeNode221 = m_ctlTriStateTreeView.AddTreeNode(objTreeNode22.Nodes, "File 221", CheckBoxState.Unchecked)
        'objTreeNode222 = m_ctlTriStateTreeView.AddTreeNode(objTreeNode22.Nodes, "File 222", CheckBoxState.Unchecked)

        'objTreeNodeRoot.ExpandAll()

    End Sub
    Private Sub RecorrerNodos(treeNode As TreeNode)
        Try
            'Si el nodo que recibimos tiene hijos se recorrerá
            'para luego verificar si esta o no checado
            For Each tn As TreeNode In treeNode.Nodes
                'Se Verifica si esta marcado...
                If tn.Checked = False Then
                    'Si esta marcado mostramos el texto del nodo
                    'MessageBox.Show(tn.Text)
                    tn = m_ctlTriStateTreeView.AddTreeNode(tn.Nodes, tn.NextVisibleNode.Text, CheckBoxState.Unchecked)
                End If
                'Ahora hago verificacion a los hijos del nodo actual            
                'Esta iteración no acabara hasta llegar al ultimo nodo principal
                RecorrerNodos(tn)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub
    Private Sub llenaTablaMenuRoles()
        Dim EntidadRoles As New Capa_Entidad.Roles
        Dim NegocioRoles As New Capa_Negocio.Roles
        EntidadRoles.Consulta = Consulta.ConsultaBasica
        NegocioRoles.Consultar(EntidadRoles)
        TablaEnc = EntidadRoles.TablaConsulta
        'TVRoles.Nodes.Clear()
    End Sub
    Private Sub CrearNodosDelPadre(ByVal indicePadre As Integer, ByVal nodePadre As TreeNode)
        Dim dataViewHijos As DataView
        dataViewHijos = New DataView(TablaEnc)
        dataViewHijos.RowFilter = TablaEnc.Columns("IdPadre").ColumnName + " = " + indicePadre.ToString()
        For Each dataRowCurrent As DataRowView In dataViewHijos
            Dim nuevoNodo As New TreeNode
            nuevoNodo.Text = dataRowCurrent("Descripcion").ToString().Trim() & " " & dataRowCurrent("IdMenuRoles").ToString().Trim()
            nuevoNodo.Tag = dataRowCurrent("IdMenuRoles").ToString().Trim() & "," & dataRowCurrent("Descripcion").ToString().Trim() & "," & dataRowCurrent("IdPadre").ToString().Trim() & "," & dataRowCurrent("IdEstatus").ToString().Trim()
            If nodePadre Is Nothing Then
                TvRoles.Nodes.Add(nuevoNodo)
            Else
                nodePadre.Nodes.Add(nuevoNodo)
            End If
            CrearNodosDelPadre(Int32.Parse(dataRowCurrent("IdMenuRoles").ToString()), nuevoNodo)
        Next dataRowCurrent
    End Sub

    Private Sub IterateTreeNodes(ByVal originalNode As TreeNode, ByVal rootNode As TreeNode)
        Dim childNode As TreeNode
        For Each childNode In originalNode.Nodes

            Dim NewNode As TreeNode = New TreeNode(childNode.Text)
            NewNode.Tag = childNode.Tag
            Me.TreeView1.SelectedNode = rootNode
            Me.TreeView1.SelectedNode.Nodes.Add(NewNode)
            IterateTreeNodes(childNode, NewNode)
        Next
    End Sub

    'Button Click code
    Private Sub button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim originalNode As TreeNode
        For Each originalNode In Me.TvRoles.Nodes
            Dim NewNode As TreeNode = New TreeNode(originalNode.Text)
            NewNode.Tag = originalNode.Tag
            Me.TreeView1.Nodes.Add(NewNode)
            IterateTreeNodes(originalNode, NewNode)
        Next
        TreeView1.CollapseAll()
    End Sub
End Class