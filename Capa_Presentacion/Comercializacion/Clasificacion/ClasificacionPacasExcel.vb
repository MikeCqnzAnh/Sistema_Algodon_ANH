Imports Capa_Operacion.Configuracion
Imports System.IO
Imports System.Data.OleDb
Imports System.Data
Public Class ClasificacionPacasExcel
    Public TablaClasificacionGlobal As New DataTable
    Public TablaClasificacionGrid As New DataTable
    Public Tabla As New DataTable
    Private Sub ClasificacionPacasExcel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombos()
        TablaClasificacionGrid.Columns.Clear()
        TablaClasificacionGrid.Columns.Add(New DataColumn("BaleId", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Mic", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("ColorGrade", System.Type.GetType("System.String")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("TrashId", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Clase", System.Type.GetType("System.String")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("UHML", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("Strength", System.Type.GetType("System.Double")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("SCI", System.Type.GetType("System.Int32")))
        TablaClasificacionGrid.Columns.Add(New DataColumn("IdHviDetalle", System.Type.GetType("System.Int32")))
    End Sub
    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar.Click
        importarExcel(DgvClasificacionPacasExcel)
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Inhabilitar()
        TbPaquete.Enabled = False
    End Sub

    Private Sub Habilitar()
        TbPaquete.Enabled = True
        BtSeleccionar.Enabled = True
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        TbIdClasificacionPaquete.Text = ""
        DtpFecha.Value = Now
        TbPaquete.Text = ""
        TbRuta.Text = ""
        Habilitar()
        DgvClasificacionPacasExcel.DataSource = Nothing
    End Sub

    Private Sub ConsultarPacasBaleID(ByVal TablaBaleID As DataTable)
        Dim chk As New DataGridViewCheckBoxColumn
        Dim EntidadClasificacionPacasExcel As New Capa_Entidad.ClasificacionPacasExcel
        Dim NegocioClasificacionPacasExcel As New Capa_Negocio.ClasificacionPacasExcel
        EntidadClasificacionPacasExcel.Consulta = Consulta.ConsultaPorId
        EntidadClasificacionPacasExcel.TablaBaleID = TablaBaleID
        NegocioClasificacionPacasExcel.Consultar(EntidadClasificacionPacasExcel)
        Tabla = EntidadClasificacionPacasExcel.TablaConsulta
        DgvClasificacionPacasExcel.DataSource = Tabla
        'Dim chk As DataGridViewCheckBoxColumn = New DataGridViewCheckBoxColumn()
        'chk.Name = "chk"
        'chk.Selected = False
        'DgvClasificacionPacasExcel.Columns.Add(chk)
        DgvClasificacionPacasExcel.Columns.Add(chk)
        chk.HeaderText = "Eliminar"
        chk.Name = "chk"
        PropiedadesDGV()
        IdentificaColor()
    End Sub

    Sub importarExcel(ByVal tabla As DataGridView)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""
        With myFileDialog
            .Filter = "Excel Files |*.xlsx"
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
                tabla.DataSource = ds
                tabla.DataMember = "MyData"
                ConsultarPacasBaleID(dt)
            Catch ex As Exception
                MsgBox("Inserte un nombre valido de la hoja que desea importar", MsgBoxStyle.Information, "Información")
            Finally
                conn.Close()
            End Try
        End If
        MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")
    End Sub

    Private Sub PropiedadesDGV()
        DgvClasificacionPacasExcel.Columns("BaleID").ReadOnly = True
        DgvClasificacionPacasExcel.Columns("Clase").ReadOnly = True
        DgvClasificacionPacasExcel.Columns("SCI").ReadOnly = True
        DgvClasificacionPacasExcel.Columns("IdHviDet").ReadOnly = True
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        If DgvClasificacionPacasExcel.DataSource IsNot Nothing Then
            Guardar()
            MsgBox("Guardado con éxito.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Aviso")
        Else
            MsgBox("Por favor, cargar la base de datos de excel.", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Aviso")
        End If
    End Sub

    Private Sub Guardar()
        DataGridViewToTable()
        Dim EntidadClasificacionPacasExcel As New Capa_Entidad.ClasificacionPacasExcel
        Dim NegocioClasificacionPacasExcel As New Capa_Negocio.ClasificacionPacasExcel
        EntidadClasificacionPacasExcel.TablaGeneral = TablaClasificacionGlobal
        NegocioClasificacionPacasExcel.Guardar(EntidadClasificacionPacasExcel)
    End Sub

    Private Sub DataGridViewToTable()
        Dim EntidadClasificacionPacasExcel As New Capa_Entidad.ClasificacionPacasExcel
        Dim NegocioClasificacionPacasExcel As New Capa_Negocio.ClasificacionPacasExcel
        Dim index As Integer
        Dim rengloninsertar As DataRow
        TablaClasificacionGrid.Clear()
        For Each row As DataGridViewRow In DgvClasificacionPacasExcel.Rows
            index = Convert.ToUInt64(row.Index)
            rengloninsertar = TablaClasificacionGrid.NewRow()
            rengloninsertar("BaleId") = DgvClasificacionPacasExcel.Rows(index).Cells("BaleId").Value
            rengloninsertar("Mic") = DgvClasificacionPacasExcel.Rows(index).Cells("Mic").Value
            rengloninsertar("ColorGrade") = DgvClasificacionPacasExcel.Rows(index).Cells("ColorGrade").Value
            rengloninsertar("TrashId") = DgvClasificacionPacasExcel.Rows(index).Cells("TrashId").Value
            rengloninsertar("Clase") = DgvClasificacionPacasExcel.Rows(index).Cells("Clase").Value
            rengloninsertar("UHML") = DgvClasificacionPacasExcel.Rows(index).Cells("LargoFibra").Value
            rengloninsertar("Strength") = DgvClasificacionPacasExcel.Rows(index).Cells("ResistenciaFibra").Value
            rengloninsertar("SCI") = DgvClasificacionPacasExcel.Rows(index).Cells("SCI").Value
            rengloninsertar("IdHviDetalle") = DgvClasificacionPacasExcel.Rows(index).Cells("IdHviDet").Value
            TablaClasificacionGrid.Rows.Add(rengloninsertar)
        Next
        TablaClasificacionGlobal = TablaClasificacionGrid
    End Sub
    Private Sub IdentificaColor()
        For Each fila As DataGridViewRow In DgvClasificacionPacasExcel.Rows
            If fila.Cells(4).Value.ToString <> CbClases.Text Then
                fila.DefaultCellStyle.BackColor = Color.Red
            Else
                fila.DefaultCellStyle.BackColor = Color.White
            End If
        Next
    End Sub
    Private Sub LlenarCombos()
        Dim EntidadClasificacionPacasExcel As New Capa_Entidad.ClasificacionPacasExcel
        Dim NegocioClasificacionPacasExcel As New Capa_Negocio.ClasificacionPacasExcel
        Dim Tabla As New DataTable
        EntidadClasificacionPacasExcel.Consulta = Consulta.ConsultaClases
        NegocioClasificacionPacasExcel.Consultar(EntidadClasificacionPacasExcel)
        Tabla = EntidadClasificacionPacasExcel.TablaConsulta
        CbClases.DataSource = Tabla
        CbClases.ValueMember = "IdClasificacion"
        CbClases.DisplayMember = "ClaveCorta"
        CbClases.SelectedValue = 1
    End Sub

    Private Sub CbClases_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbClases.SelectedIndexChanged
        IdentificaColor()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        'Se puso dos veces el metodo porque en la primer pasada no eliminaba todos los registros
        MetodoEliminar()
        MetodoEliminar()
    End Sub

    Private Sub MetodoEliminar()
        Dim index As Integer
        For Each row As DataGridViewRow In DgvClasificacionPacasExcel.Rows
            index = Convert.ToUInt64(row.Index)
            If DgvClasificacionPacasExcel.Rows(index).Cells("chk").Value = True Then
                ' Eliminamos la fila.
                Tabla.Rows.RemoveAt(index)
            End If
        Next
        DgvClasificacionPacasExcel.DataSource = Tabla
    End Sub
End Class