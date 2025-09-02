Imports System.Runtime.InteropServices

Friend Enum CheckBoxState
    None = 0
    Unchecked = 1
    Checked = 2
    Indeterminate = 3
    Path = 4
End Enum

Friend Class TriStateTreeView
    Inherits System.Windows.Forms.TreeView

    Private m_SelectPath As Boolean
    Private m_SelectChildren As Boolean

    <StructLayout(LayoutKind.Sequential)>
    Private Structure TVITEM
        Public mask As Integer
        Public hItem As IntPtr
        Public state As Integer
        Public stateMask As Integer
        Public pszText As Integer
        Public cchTextMax As Integer
        Public iImage As Integer
        Public iSelectedImage As Integer
        Public cChildren As Integer
        Public lParam As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Private Structure POINTAPI
        Public x As Integer
        Public y As Integer
    End Structure

    <StructLayout(LayoutKind.Sequential)>
    Private Structure TVHITTESTINFO
        Public pt As POINTAPI
        Public flags As Integer
        Public hItem As IntPtr
    End Structure

    ' Messages
    Private Const TV_FIRST As Integer = &H1100
    Private Const TVM_SETIMAGELIST As Integer = TV_FIRST + 9
    Private Const TVM_GETITEM As Integer = TV_FIRST + 12
    Private Const TVM_SETITEM As Integer = TV_FIRST + 13
    Private Const TVM_HITTEST As Integer = TV_FIRST + 17

    ' TVM_SETIMAGELIST image list kind
    Private Const TVSIL_STATE As Integer = 2

    'TVITEM.mask flags
    Private Const TVIF_STATE As Integer = &H8
    Private Const TVIF_HANDLE As Integer = &H10

    'TVITEM.state flags
    Public Const TVIS_STATEIMAGEMASK As Integer = &HF000

    'TVHITTESTINFO.flags flags
    Public Const TVHT_ONITEMSTATEICON As Integer = &H40

    ' ImageList Images Indexes
    Private Const m_IMG_CHECKBOX_NONE As Integer = 0
    Private Const m_IMG_CHECKBOX_UNCHECKED As Integer = 1
    Private Const m_IMG_CHECKBOX_CHECKED As Integer = 2
    Private Const m_IMG_CHECKBOX_INDETERMINATE As Integer = 3
    Private Const m_IMG_CHECKBOX_PATH As Integer = 4

    Private Overloads Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As IntPtr) As Integer
    Private Overloads Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As TVITEM) As Integer
    Private Overloads Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As TVHITTESTINFO) As Integer

    Friend Sub New(ByVal ctlStateImageList As ImageList, ByVal selectPath As Boolean, ByVal selectChildren As Boolean)

        m_SelectPath = selectPath
        m_SelectChildren = selectChildren
        Dim iResult As Integer

        ' Set the state image list
        iResult = SendMessage(Me.Handle, TVM_SETIMAGELIST, TVSIL_STATE, ctlStateImageList.Handle)

    End Sub

    Private Sub SetTreeNodeAndChildrenStateRecursively(ByVal objTreeNode As TreeNode, ByVal eCheckBoxState As CheckBoxState)

        Dim objChildTreeNode As TreeNode

        If Not (objTreeNode Is Nothing) Then

            SetTreeNodeState(objTreeNode, eCheckBoxState)

            If m_SelectChildren Then
                For Each objChildTreeNode In objTreeNode.Nodes
                    SetTreeNodeAndChildrenStateRecursively(objChildTreeNode, eCheckBoxState)
                Next
            End If

        End If

    End Sub

    Private Sub SetParentTreeNodeStateRecursively(ByVal objParentTreeNode As TreeNode)

        Dim objTreeNode As TreeNode
        Dim eCheckBoxState As CheckBoxState
        Dim bAllChildrenChecked As Boolean = True
        Dim bAllChildrenUnchecked As Boolean = True


        If Not (objParentTreeNode Is Nothing) Then

            If GetTreeNodeState(objParentTreeNode) <> CheckBoxState.None Then

                For Each objTreeNode In objParentTreeNode.Nodes

                    eCheckBoxState = GetTreeNodeState(objTreeNode)

                    Select Case eCheckBoxState

                        Case CheckBoxState.Checked
                            bAllChildrenUnchecked = False

                        Case CheckBoxState.Indeterminate
                            bAllChildrenUnchecked = False
                            bAllChildrenChecked = False

                        Case CheckBoxState.Unchecked
                            bAllChildrenChecked = False

                        Case CheckBoxState.Path
                            bAllChildrenUnchecked = False

                    End Select

                    If bAllChildrenChecked = False And bAllChildrenUnchecked = False Then
                        ' This is an optimization
                        Exit For
                    End If

                Next

                If bAllChildrenChecked Then
                    SetTreeNodeState(objParentTreeNode, CheckBoxState.Path)
                ElseIf bAllChildrenUnchecked Then
                    SetTreeNodeState(objParentTreeNode, CheckBoxState.Unchecked)
                Else
                    SetTreeNodeState(objParentTreeNode, CheckBoxState.Path)
                End If

                ' Enter in recursion
                If Not (objParentTreeNode.Parent Is Nothing) Then
                    SetParentTreeNodeStateRecursively(objParentTreeNode.Parent)
                End If

            End If

        End If

    End Sub

    Friend Function GetTreeNodeState(ByVal objTreeNode As TreeNode) As CheckBoxState

        Dim eCheckBoxState As CheckBoxState = CheckBoxState.None

        Dim tTVITEM As TVITEM
        Dim iState As Integer
        Dim iResult As Integer

        tTVITEM.mask = TVIF_HANDLE Or TVIF_STATE
        tTVITEM.hItem = objTreeNode.Handle
        tTVITEM.stateMask = TVIS_STATEIMAGEMASK
        tTVITEM.state = 0

        iResult = SendMessage(Me.Handle, TVM_GETITEM, 0, tTVITEM)

        If iResult <> 0 Then

            iState = tTVITEM.state

            ' State image index in bits 12..15
            iState = iState \ &HFFF

            Select Case iState

                Case m_IMG_CHECKBOX_NONE
                    eCheckBoxState = CheckBoxState.None

                Case m_IMG_CHECKBOX_UNCHECKED
                    eCheckBoxState = CheckBoxState.Unchecked

                Case m_IMG_CHECKBOX_CHECKED
                    eCheckBoxState = CheckBoxState.Checked

                Case m_IMG_CHECKBOX_INDETERMINATE
                    eCheckBoxState = CheckBoxState.Indeterminate

                Case m_IMG_CHECKBOX_PATH
                    eCheckBoxState = CheckBoxState.Path

            End Select

        End If

        Return eCheckBoxState

    End Function

    Friend Sub SetTreeNodeState(ByVal objTreeNode As TreeNode, ByVal eCheckBoxState As CheckBoxState)

        Dim iImageIndex As Integer
        Dim tTVITEM As TVITEM
        Dim iResult As Integer

        If Not (objTreeNode Is Nothing) Then

            Select Case eCheckBoxState

                Case CheckBoxState.None
                    iImageIndex = m_IMG_CHECKBOX_NONE

                Case CheckBoxState.Unchecked
                    iImageIndex = m_IMG_CHECKBOX_UNCHECKED

                Case CheckBoxState.Checked
                    iImageIndex = m_IMG_CHECKBOX_CHECKED

                Case CheckBoxState.Indeterminate
                    iImageIndex = m_IMG_CHECKBOX_INDETERMINATE

                Case CheckBoxState.Path
                    iImageIndex = m_IMG_CHECKBOX_PATH

            End Select

            tTVITEM.mask = TVIF_HANDLE Or TVIF_STATE
            tTVITEM.hItem = objTreeNode.Handle
            tTVITEM.stateMask = TVIS_STATEIMAGEMASK
            ' State image index in bits 12..15
            tTVITEM.state = iImageIndex * &H1000

            iResult = SendMessage(Me.Handle, TVM_SETITEM, 0, tTVITEM)

        End If

    End Sub

    Private Sub ToggleTreeNodeState(ByVal objTreeNode As TreeNode)

        Dim eCheckBoxState As CheckBoxState

        eCheckBoxState = GetTreeNodeState(objTreeNode)

        Me.BeginUpdate()

        Select Case eCheckBoxState

            Case CheckBoxState.Unchecked

                SetTreeNodeAndChildrenStateRecursively(objTreeNode, CheckBoxState.Checked)
                If m_SelectPath Then
                    SetParentTreeNodeStateRecursively(objTreeNode.Parent)
                End If

            Case CheckBoxState.Checked

                SetTreeNodeAndChildrenStateRecursively(objTreeNode, CheckBoxState.Indeterminate)
                If m_SelectPath Then
                    SetParentTreeNodeStateRecursively(objTreeNode.Parent)
                End If

            Case CheckBoxState.Indeterminate

                SetTreeNodeAndChildrenStateRecursively(objTreeNode, CheckBoxState.Unchecked)
                If m_SelectPath Then
                    SetParentTreeNodeStateRecursively(objTreeNode.Parent)
                End If

        End Select

        Me.EndUpdate()

    End Sub

    Private Function GetTreeNodeHitAtCheckBoxByScreenPosition(ByVal iXScreenPos As Integer, ByVal iYScreenPos As Integer) As TreeNode

        Dim objClientPoint As Point
        Dim objTreeNode As TreeNode

        objClientPoint = Me.PointToClient(New Point(iXScreenPos, iYScreenPos))

        objTreeNode = GetTreeNodeHitAtCheckBoxByClientPosition(objClientPoint.X, objClientPoint.Y)

        Return objTreeNode

    End Function

    Private Function GetTreeNodeHitAtCheckBoxByClientPosition(ByVal iXClientPos As Integer, ByVal iYClientPos As Integer) As TreeNode

        Dim objTreeNode As TreeNode = Nothing
        Dim iTreeNodeHandle As Integer
        Dim tTVHITTESTINFO As TVHITTESTINFO

        ' Get the hit info
        tTVHITTESTINFO.pt.x = iXClientPos
        tTVHITTESTINFO.pt.y = iYClientPos
        iTreeNodeHandle = SendMessage(Me.Handle, TVM_HITTEST, 0, tTVHITTESTINFO)

        ' Check if it has clicked on an item
        If iTreeNodeHandle <> 0 Then

            ' Check if it has clicked on the state image of the item
            If (tTVHITTESTINFO.flags And TVHT_ONITEMSTATEICON) <> 0 Then

                objTreeNode = TreeNode.FromHandle(Me, New IntPtr(iTreeNodeHandle))

            End If

        End If

        Return objTreeNode

    End Function

    Protected Overrides Sub OnMouseUp(ByVal e As System.Windows.Forms.MouseEventArgs)

        Dim objTreeNode As TreeNode

        MyBase.OnMouseUp(e)

        objTreeNode = GetTreeNodeHitAtCheckBoxByClientPosition(e.X, e.Y)
        If Not (objTreeNode Is Nothing) Then

            ToggleTreeNodeState(objTreeNode)

        End If

    End Sub

    Protected Overrides Sub OnKeyUp(ByVal e As System.Windows.Forms.KeyEventArgs)

        MyBase.OnKeyUp(e)

        If e.KeyCode = Keys.Space Then

            If Not (Me.SelectedNode Is Nothing) Then
                ToggleTreeNodeState(Me.SelectedNode)
            End If

        End If

    End Sub

    Protected Overrides Sub OnBeforeExpand(ByVal e As System.Windows.Forms.TreeViewCancelEventArgs)

        ' PATCH: if the node is being expanded by a double click at the state image, cancel it
        If Not (GetTreeNodeHitAtCheckBoxByScreenPosition(Control.MousePosition.X, Control.MousePosition.Y) Is Nothing) Then
            e.Cancel = True
        End If

    End Sub

    Protected Overrides Sub OnBeforeCollapse(ByVal e As System.Windows.Forms.TreeViewCancelEventArgs)

        ' PATCH: if the node is being collapsed by a double click at the state image, cancel it
        If Not (GetTreeNodeHitAtCheckBoxByScreenPosition(Control.MousePosition.X, Control.MousePosition.Y) Is Nothing) Then
            e.Cancel = True
        End If

    End Sub

    Friend Function AddTreeNode(ByVal colNodes As TreeNodeCollection, ByVal sNodeText As String, ByVal iImageIndex As Integer, ByVal eCheckBoxState As CheckBoxState) As TreeNode

        Dim objTreeNode As TreeNode

        objTreeNode = New TreeNode(sNodeText)

        objTreeNode.ImageIndex = iImageIndex
        objTreeNode.SelectedImageIndex = iImageIndex

        colNodes.Add(objTreeNode)

        Me.SetTreeNodeState(objTreeNode, eCheckBoxState)

        Return objTreeNode

    End Function

    Friend Function AddTreeNode(ByVal colNodes As TreeNodeCollection, ByVal sNodeText As String, ByVal eCheckBoxState As CheckBoxState) As TreeNode

        Dim objTreeNode As TreeNode

        objTreeNode = New TreeNode(sNodeText)

        colNodes.Add(objTreeNode)

        Me.SetTreeNodeState(objTreeNode, eCheckBoxState)

        Return objTreeNode

    End Function

End Class
