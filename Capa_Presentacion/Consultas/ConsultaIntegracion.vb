Imports Capa_Operacion.Configuracion
Public Class ConsultaIntegracion
    Private _IdIntegracion As Integer
    Private _IdCompra As Integer
    Private _IdContrato As Integer
    Private _IdCliente As Integer
    Private _NombreProductor As String
    Private _Rfc As String
    Private _PrecioQuintal As Decimal
    Private _TotalPacas As Integer
    Private _Kilos As Decimal
    Private _Subtotal As Decimal
    Private _CastigoDls As Decimal
    Private _TotalDls As Decimal
    Private _ImporteFacturas As Decimal
    Private _TotalToneladasFacturas As Decimal
    Private _TotalPacasFacturas As Integer
    Private _FechaCreacion As DateTime
    Private _FechaActualizacion As DateTime

    Public Property IdIntegracion As Integer
        Get
            Return _IdIntegracion
        End Get
        Set(value As Integer)
            _IdIntegracion = value
        End Set
    End Property
    Public Property IdCompra As Integer
        Get
            Return _IdCompra
        End Get
        Set(value As Integer)
            _IdCompra = value
        End Set
    End Property
    Public Property IdContrato As Integer
        Get
            Return _IdContrato
        End Get
        Set(value As Integer)
            _IdContrato = value
        End Set
    End Property
    Public Property IdCliente As Integer
        Get
            Return _IdCliente
        End Get
        Set(value As Integer)
            _IdCliente = value
        End Set
    End Property
    Public Property NombreProductor As String
        Get
            Return _NombreProductor
        End Get
        Set(value As String)
            _NombreProductor = value
        End Set
    End Property
    Public Property Rfc As String
        Get
            Return _Rfc
        End Get
        Set(value As String)
            _Rfc = value
        End Set
    End Property
    Public Property PrecioQuintal As Decimal
        Get
            Return _PrecioQuintal
        End Get
        Set(value As Decimal)
            _PrecioQuintal = value
        End Set
    End Property
    Public Property TotalPacas As Decimal
        Get
            Return _TotalPacas
        End Get
        Set(value As Decimal)
            _TotalPacas = value
        End Set
    End Property
    Public Property Kilos As Decimal
        Get
            Return _Kilos
        End Get
        Set(value As Decimal)
            _Kilos = value
        End Set
    End Property
    Public Property SubTotal As Decimal
        Get
            Return _Subtotal
        End Get
        Set(value As Decimal)
            _Subtotal = value
        End Set
    End Property
    Public Property CastigoDls As Decimal
        Get
            Return _CastigoDls
        End Get
        Set(value As Decimal)
            _CastigoDls = value
        End Set
    End Property
    Public Property TotalDls As Decimal
        Get
            Return _TotalDls
        End Get
        Set(value As Decimal)
            _TotalDls = value
        End Set
    End Property
    Public Property ImporteFacturas As Decimal
        Get
            Return _ImporteFacturas
        End Get
        Set(value As Decimal)
            _ImporteFacturas = value
        End Set
    End Property
    Public Property TotalToneladasFacturas As Decimal
        Get
            Return _TotalToneladasFacturas
        End Get
        Set(value As Decimal)
            _TotalToneladasFacturas = value
        End Set
    End Property
    Public Property TotalPacasFacturas As Integer
        Get
            Return _TotalPacasFacturas
        End Get
        Set(value As Integer)
            _TotalPacasFacturas = value
        End Set
    End Property
    Public Property FechaCreacion As DateTime
        Get
            Return _FechaCreacion
        End Get
        Set(value As DateTime)
            _FechaCreacion = value
        End Set
    End Property
    Public Property FechaActualizacion As DateTime
        Get
            Return _FechaActualizacion
        End Get
        Set(value As DateTime)
            _FechaActualizacion = value
        End Set
    End Property

    Private Sub ConsultaIntegracion_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConsultaIntegracion()
    End Sub
    Private Sub ConsultaIntegracion()
        Dim EntidadIntegraciondeCompras As New Capa_Entidad.IntegraciondeCompras
        Dim NegocioIntegraciondeCompras As New Capa_Negocio.IntegraciondeCompras
        EntidadIntegraciondeCompras.Consulta = Consulta.ConsultaIntegracion
        EntidadIntegraciondeCompras.IdIntegracion = Val(TbIdIntegracion.Text)
        EntidadIntegraciondeCompras.IdCompra = Val(TbIdCompra.Text)
        EntidadIntegraciondeCompras.NombreProductor = TbNombre.Text
        NegocioIntegraciondeCompras.Consultar(EntidadIntegraciondeCompras)
        Tabla = EntidadIntegraciondeCompras.TablaConsulta
        DgvIntegracion.Columns.Clear()
        DgvIntegracion.DataSource = Tabla
        PropiedadesDGV()
        DgvIntegracion.CurrentCell = Nothing
    End Sub

    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        ConsultaIntegracion()
    End Sub
    Private Sub PropiedadesDGV()
        DgvIntegracion.Columns("IdCliente").Visible = False
        DgvIntegracion.Columns("IdContratoAlgodon").Visible = False
        DgvIntegracion.Columns("Rfc").Visible = False
        DgvIntegracion.Columns("FechaActualizacion").Visible = False

        DgvIntegracion.Columns("IdIntegracionCompra").HeaderText = "ID Integracion"
        DgvIntegracion.Columns("IdCompra").HeaderText = "ID Compra"
        DgvIntegracion.Columns("PrecioQuintal").HeaderText = "Precio Quintal"
        DgvIntegracion.Columns("TotalPacas").HeaderText = "Pacas de Compra"
        DgvIntegracion.Columns("Kilos").HeaderText = "Kilos de Compra"
        DgvIntegracion.Columns("Subtotal").HeaderText = "Subtotal de Compra"
        DgvIntegracion.Columns("CastigoDls").HeaderText = "Castigo de Compra"
        DgvIntegracion.Columns("TotalDlls").HeaderText = "Importe de Compra"
        DgvIntegracion.Columns("ImporteFacturas").HeaderText = "Importe de Factura"
        DgvIntegracion.Columns("TotalToneladasFacturas").HeaderText = "Toneladas de Factura"
        DgvIntegracion.Columns("TotalPacasFacturas").HeaderText = "Pacas de Factura"
        DgvIntegracion.Columns("FechaCreacion").HeaderText = "Fecha de Creacion"

        DgvIntegracion.Columns("Subtotal").DefaultCellStyle.Format = "C2"
        DgvIntegracion.Columns("Subtotal").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DgvIntegracion.Columns("CastigoDls").DefaultCellStyle.Format = "C2"
        DgvIntegracion.Columns("CastigoDls").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DgvIntegracion.Columns("TotalDlls").DefaultCellStyle.Format = "C2"
        DgvIntegracion.Columns("TotalDlls").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DgvIntegracion.Columns("ImporteFacturas").DefaultCellStyle.Format = "C2"
        DgvIntegracion.Columns("ImporteFacturas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DgvIntegracion.Columns("TotalToneladasFacturas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

        DgvIntegracion.Columns("TotalPacasFacturas").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub
    Private Sub DgvIntegracion_DoubleClick(sender As Object, e As EventArgs) Handles DgvIntegracion.DoubleClick
        If DgvIntegracion.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvIntegracion.CurrentCell.RowIndex
            _IdIntegracion = DgvIntegracion.Rows(index).Cells("IdIntegracionCompra").Value
            _IdCompra = DgvIntegracion.Rows(index).Cells("IdCompra").Value
            _IdContrato = DgvIntegracion.Rows(index).Cells("IdContratoAlgodon").Value
            _IdCliente = DgvIntegracion.Rows(index).Cells("IdCliente").Value
            _NombreProductor = DgvIntegracion.Rows(index).Cells("Nombre").Value
            _Rfc = DgvIntegracion.Rows(index).Cells("Rfc").Value
            _PrecioQuintal = DgvIntegracion.Rows(index).Cells("PrecioQuintal").Value
            _TotalPacas = DgvIntegracion.Rows(index).Cells("TotalPacas").Value
            _Kilos = DgvIntegracion.Rows(index).Cells("Kilos").Value
            _Subtotal = DgvIntegracion.Rows(index).Cells("Subtotal").Value
            _CastigoDls = DgvIntegracion.Rows(index).Cells("CastigoDls").Value
            _TotalDls = DgvIntegracion.Rows(index).Cells("TotalDlls").Value
            _ImporteFacturas = DgvIntegracion.Rows(index).Cells("ImporteFacturas").Value
            _TotalToneladasFacturas = DgvIntegracion.Rows(index).Cells("TotalToneladasFacturas").Value
            _TotalPacasFacturas = DgvIntegracion.Rows(index).Cells("TotalPacasFacturas").Value
            _FechaCreacion = DgvIntegracion.Rows(index).Cells("FechaCreacion").Value
            _FechaActualizacion = DgvIntegracion.Rows(index).Cells("FechaActualizacion").Value
            Close()
        End If
    End Sub
End Class
