Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultaProduccionRevision
    Private _IdOrdenTrabajo As Integer
    Public Property IdOrdenTrabajo() As Integer
        Get
            Return _IdOrdenTrabajo
        End Get
        Set(value As Integer)
            _IdOrdenTrabajo = value
        End Set
    End Property
    Private Sub ConsultaClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbIdOrdenTrabajo.Select()
        Consultar()
    End Sub
    Private Sub Consultar()
        Dim tabla2 As New DataTable
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        EntidadProduccion.Consulta = Consulta.ConsultaProduccionRevision
        EntidadProduccion.NombreProductor = TbProductor.Text
        EntidadProduccion.IdOrdenTrabajo = Val(TbIdOrdenTrabajo.Text)
        EntidadProduccion.IdProduccion = Val(TbIdProduccion.Text)
        NegocioProduccion.Consultar(EntidadProduccion)
        tabla2 = EntidadProduccion.TablaConsulta
        DgvProducciones.DataSource = tabla2
    End Sub

    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        Consultar()
    End Sub
    Private Sub DgvConsultaClientes_DoubleClick(sender As Object, e As EventArgs) Handles DgvProducciones.DoubleClick
        If DgvProducciones.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvProducciones.CurrentCell.RowIndex
            _IdOrdenTrabajo = DgvProducciones.Rows(index).Cells("IdOrdenTrabajo").Value
            Close()
        End If
    End Sub

    Private Sub TbNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TbIdOrdenTrabajo.KeyDown, TbIdProduccion.KeyDown, TbProductor.KeyDown
        If e.KeyCode = Keys.Enter Then
            Consultar()
        End If
    End Sub

    Private Sub ExportarExcelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportarExcelToolStripMenuItem.Click
        If DgvProducciones.RowCount > 0 Then
            ExportExcel(DgvProducciones)
        End If
    End Sub

    Private Sub ConsultaProduccionRevision_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If _IdOrdenTrabajo = 0 Then
            _IdOrdenTrabajo = 0
        End If
    End Sub
End Class