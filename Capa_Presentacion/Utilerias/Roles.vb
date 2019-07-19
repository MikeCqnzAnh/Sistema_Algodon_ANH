Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports Capa_Operacion.Configuracion
Public Class Roles
    Dim TablaEnc As New DataTable
    Private Sub BtAgregar_Click(sender As Object, e As EventArgs) Handles BtAgregar.Click
        AgregaOpcion()
        llenaTablaMenuRoles()
        CrearNodosDelPadre(0, Nothing)
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
        llenaTablaMenuRoles()
        CrearNodosDelPadre(0, Nothing)
    End Sub
    Private Sub TVRoles_GotFocus(sender As Object, e As EventArgs) Handles TVRoles.MouseDoubleClick
        If TVRoles.SelectedNode IsNot Nothing Then
            Dim lineText As String = TVRoles.SelectedNode.Tag
            Dim ArrayText() As String
            ArrayText = lineText.Split(",")
            For Each s In ArrayText
                TbIdNodo.Text = ArrayText(0)
                TbNombreNodo.Text = ArrayText(1).ToString
                TbIdPadre.Text = ArrayText(2)
                CkEstatus.Checked = ArrayText(3)
            Next
        End If

    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub Limpiar()
        TbIdNodo.Text = ""
        TbNombreNodo.Text = ""
        TbIdPadre.Text = ""
        CkEstatus.Checked = True
        TbNombreNodo.Select()
    End Sub
    Private Sub llenaTablaMenuRoles()
        Dim EntidadRoles As New Capa_Entidad.Roles
        Dim NegocioRoles As New Capa_Negocio.Roles
        EntidadRoles.Consulta = Consulta.ConsultaBasica
        NegocioRoles.Consultar(EntidadRoles)
        TablaEnc = EntidadRoles.TablaConsulta
        TVRoles.Nodes.Clear()
    End Sub
    Private Sub Roles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        llenaTablaMenuRoles()
        CrearNodosDelPadre(0, Nothing)
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
                TVRoles.Nodes.Add(nuevoNodo)
            Else
                nodePadre.Nodes.Add(nuevoNodo)
            End If
            CrearNodosDelPadre(Int32.Parse(dataRowCurrent("IdMenuRoles").ToString()), nuevoNodo)
        Next dataRowCurrent
    End Sub
    Private Sub AgregaOpcion()
        Dim EntidadRoles As New Capa_Entidad.Roles
        Dim NegocioRoles As New Capa_Negocio.Roles
        Try
            EntidadRoles.IdMenuRoles = IIf(TbIdNodo.Text = "", 0, TbIdNodo.Text)
            EntidadRoles.Descripcion = TbNombreNodo.Text
            EntidadRoles.IdPadre = TbIdPadre.Text
            EntidadRoles.IdEstatus = CkEstatus.CheckState
            EntidadRoles.Agrega = Agrega.AgregOpcion
            NegocioRoles.Agregar(EntidadRoles)
            TbIdNodo.Text = EntidadRoles.IdMenuRoles
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally

            MsgBox("Realizado Correctamente")
        End Try

    End Sub
    Private Sub TVRoles_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles TVRoles.AfterCheck
        ' El código sólo se ejecutará si el usuario causó
        ' el cambio del estado de verificación del nodo.
        '
        If (e.Action = TreeViewAction.Unknown) Then Return

        If (e.Node.Nodes.Count > 0) Then
            ' Llama al método CheckAllChildNodes, pasando el valor actual
            ' Chequeado del TreeNode cuyo estado marcado ha cambiado.
            Me.CheckAllChildNodes(e.Node, e.Node.Checked)

        Else
            ' Nodo padre del nodo hijo actual.
            Dim parent As TreeNode = e.Node.Parent
            If (Not parent Is Nothing) Then
                ' El nodo tiene un nodo padre válido.
                '
                If (Not e.Node.Checked) Then
                    ' El nodo hijo no está marcado; eliminamos la marca de
                    ' de verificación de su nodo padre.
                    parent.Checked = False

                Else
                    ' El nodo hijo está marcado; comprobamos si los restantes
                    ' nodos hijos están marcados para marcar también el
                    ' nodo padre.
                    '
                    Dim items As TreeNode() = (From item As TreeNode In parent.Nodes.OfType(Of TreeNode)()
                                               Where item.Checked
                                               Select item).ToArray()

                    parent.Checked = (items.Count = parent.Nodes.Count)

                End If
            End If

        End If
    End Sub
    Private Sub CheckAllChildNodes(treeNode As TreeNode, nodeChecked As Boolean)

        ' Actualiza de forma recursiva todos los nodos hijos.
        '
        For Each node As TreeNode In treeNode.Nodes
            node.Checked = nodeChecked
            If (node.Nodes.Count > 0) Then
                ' Si el node actual tiene nodos hijos, llamar
                ' recursivamente al método CheckAllChildNodes.
                Me.CheckAllChildNodes(node, nodeChecked)
            End If
        Next

    End Sub


    Private Sub Bt_Click(sender As Object, e As EventArgs) Handles Bt.Click
        'RecorrerTV()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        TVRoles.ExpandAll()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        TVRoles.CollapseAll()
    End Sub
End Class
