Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultaAlmacen
    Private _IdAlmacen As Integer
    Public Property IdAlmacen() As Integer
        Get
            Return _IdAlmacen
        End Get
        Set(value As Integer)
            _IdAlmacen = value
        End Set
    End Property
    Private Sub ConsultaAlmacen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Limpiar()
    End Sub
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        ConsultarAlmacen()
    End Sub
    Private Sub Limpiar()
        TbIdAlmacen.Text = ""
        TbAlmacen.Text = ""
        DgvAlmacenes.DataSource = Nothing
    End Sub
    Private Sub ConsultarAlmacen()
        Dim EntidadAlmacenes As New Capa_Entidad.Almacenes
        Dim NegocioAlmacenes As New Capa_Negocio.Almacenes
        Dim Tabla As New DataTable
        Try
            EntidadAlmacenes.IdAlmacenEncabezado = IIf(TbIdAlmacen.Text = "", 0, TbIdAlmacen.Text)
            EntidadAlmacenes.Descripcion = TbAlmacen.Text
            EntidadAlmacenes.Consulta = Consulta.ConsultaAlmacen
            NegocioAlmacenes.Consultar(EntidadAlmacenes)
            DgvAlmacenes.DataSource = EntidadAlmacenes.TablaConsulta
            'FormatoDatagrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub TbAlmacen_KeyDown(sender As Object, e As KeyEventArgs) Handles TbAlmacen.KeyDown, TbIdAlmacen.KeyDown
        ConsultarAlmacen()
    End Sub
    Private Sub DgvAlmacenes_DoubleClick(sender As Object, e As EventArgs) Handles DgvAlmacenes.DoubleClick
        If DgvAlmacenes.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvAlmacenes.CurrentCell.RowIndex
            _IdAlmacen = DgvAlmacenes.Rows(index).Cells("IdAlmacenEncabezado").Value
            Close()
        End If
    End Sub
End Class