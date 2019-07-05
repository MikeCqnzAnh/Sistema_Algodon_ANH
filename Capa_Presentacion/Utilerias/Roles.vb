Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class Roles
    Private Sub Roles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenaTreeView()
        TreeView1.Nodes(0).Checked = True
    End Sub
    Private Sub LlenaTreeView()
        Dim EntidadRoles As New Capa_Entidad.Roles
        Dim NegocioRoles As New Capa_Negocio.Roles
        Dim TablaEnc, TablaDet, TablaOp As New DataTable
        Dim NodeEnc, NodeDet, Nodeop As TreeNode
        EntidadRoles.Consulta = Consulta.ConsultaBasica
        NegocioRoles.Consultar(EntidadRoles)
        TablaEnc = EntidadRoles.TablaConsulta
        For Each row As DataRow In TablaEnc.Rows
            NodeEnc = TreeView1.Nodes.Add(CStr(row("Nombre")))

            EntidadRoles.IdMenuEncabezado = row("IdMenuEncabezado")
            EntidadRoles.Consulta = Consulta.ConsultaDetallada
            NegocioRoles.Consultar(EntidadRoles)
            TablaDet = EntidadRoles.TablaGeneral
            For Each rowSub As DataRow In TablaDet.Rows
                NodeDet = NodeEnc.Nodes.Add(CStr(rowSub("Nombre")))

                EntidadRoles.IdMenuDetalle = rowSub("IdMenuDetalle")
                EntidadRoles.Consulta = Consulta.ConsultaOpciones
                NegocioRoles.Consultar(EntidadRoles)
                TablaOp = EntidadRoles.TablaOpciones
                For Each RowOp As DataRow In TablaOp.Rows
                    Nodeop = NodeDet.Nodes.Add(CStr(RowOp("Nombre")))
                Next

            Next
        Next
    End Sub

    Private Sub TreeView1_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterCheck

    End Sub
End Class
