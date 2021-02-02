Imports System.Data.OleDb
Imports System.IO
Public Class CargaExcel
    Private folderBrowserDialog1 As FolderBrowserDialog
    Private Sub BtCargaExcel_Click(sender As Object, e As EventArgs) Handles BtCargaExcel.Click
        importarDoc(DgvPacas)
        TbCantidadPacas.Text = DgvPacas.RowCount
    End Sub
    Private Sub CargaExcel_Load(sender As Object, e As EventArgs) Handles Me.Load
        Limpiar()
    End Sub
    Private Sub Limpiar()
        DgvPacas.DataSource = Nothing
        TbCantidadPacas.Text = ""
    End Sub
    Private Sub cargaTabla()
        TablaExcel.Columns.Clear()
        TablaExcel.Rows.Clear()
        Dim r As DataRow
        Try
            TablaExcel.Columns.Add("BaleID", Type.GetType("System.Int64"))
            For i = 0 To DgvPacas.Rows.Count - 1
                r = TablaExcel.NewRow
                r("BaleID") = DgvPacas.Item(0, i).Value
                TablaExcel.Rows.Add(r)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub BtConfirma_Click(sender As Object, e As EventArgs) Handles BtConfirma.Click
        If DgvPacas.Rows.Count = 0 Then
            MsgBox("No hay registros, revise para continuar", MsgBoxStyle.Information, "Aviso")
        Else
            cargaTabla()
            Me.Close()
        End If
    End Sub
End Class