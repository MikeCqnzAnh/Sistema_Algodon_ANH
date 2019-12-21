Imports Capa_Operacion.Configuracion
Imports System.IO
Imports System.Data.OleDb
Imports System.Data
Public Class ComparacionVentaVsCliente
    Private Sub ComparacionVentaVsCliente_Load(sender As Object, e As EventArgs) Handles Me.Load
        Limpiar()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub Limpiar()
        TbContadorRegistros.Text = ""
        TbRuta.Text = ""
        DgvPacasComprador.DataSource = Nothing
        DgvPacasVenta.DataSource = Nothing
    End Sub
    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar.Click
        ImportarExcel()
    End Sub
    Private Sub ImportarExcel()
        'Dim Tabla As DataTable
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""
        With myFileDialog
            .Filter = "Excel Files |*.xlsx ;*.xls"
            .Title = "Open File"
            .ShowDialog()
        End With
        If myFileDialog.FileName.ToString <> "" Then
            Dim ExcelFile As String = myFileDialog.FileName.ToString
            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection
            xSheet = InputBox("Digite el nombre de la hoja que desea importar", "Complete")
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "data source=" & ExcelFile & "; " & "Extended Properties='Excel 12.0 Xml;HDR=Yes'")
            Try
                da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)
                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                DgvPacasComprador.DataSource = ds
                DgvPacasComprador.DataMember = "MyData"
                'ConsultarPacasBaleID(dt)
            Catch ex As Exception
                conn.Close()
                MsgBox(ex.Message, MsgBoxStyle.Information, "Información")
            Finally
                conn.Close()
                TbContadorRegistros.Text = DgvPacasComprador.Rows.Count
                MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")
            End Try
        End If
    End Sub
End Class