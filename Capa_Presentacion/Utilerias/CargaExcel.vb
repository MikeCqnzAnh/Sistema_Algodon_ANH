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
        Tabla.Columns.Clear()
        Dim r As DataRow
        Try
            Tabla.Columns.Add("etiquetas", Type.GetType("System.Int32"))
            For i = 0 To DgvPacas.Rows.Count - 1
                r = Tabla.NewRow
                r("etiquetas") = DgvPacas.Item(0, i).Value
                Tabla.Rows.Add(r)
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