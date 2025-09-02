Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultaCompraIntegracion
    Private _IdCompra As Integer
    Private _IdCliente As Integer
    Private _NombreProductor As String
    Private _Rfc As String
    Private _Planta As String
    Private _TotalPacas As Integer
    Private _Subtotal As Decimal
    Private _CastigoDls As Decimal
    Private _TotalDls As Decimal
    Private _Fecha As DateTime
    Private _IdContrato As Integer
    Private _PrecioQuintal As Decimal
    Private _TotalKilos As Decimal
    Public Property IdCompra As Integer
        Get
            Return _IdCompra
        End Get
        Set(value As Integer)
            _IdCompra = value
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
    Public Property Planta As String
        Get
            Return _Planta
        End Get
        Set(value As String)
            _Planta = value
        End Set
    End Property
    Public Property TotalPacas As Decimal
        Get
            Return _TotalPacas
        End Get
        Set(value As Decimal)
            _Planta = value
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
    Public Property Fecha As DateTime
        Get
            Return _Fecha
        End Get
        Set(value As DateTime)
            _Fecha = value
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
    Public Property PrecioQuintal As Decimal
        Get
            Return _PrecioQuintal
        End Get
        Set(value As Decimal)
            _PrecioQuintal = value
        End Set
    End Property
    Public Property TotalKilos As Decimal
        Get
            Return _TotalKilos
        End Get
        Set(value As Decimal)
            _TotalKilos = value
        End Set
    End Property
    Private Sub ConsultaCompraIntegracion_Load(sender As Object, e As EventArgs) Handles Me.Load
        ConsultaCompra()
    End Sub
    Private Sub ConsultaCompra()
        Dim EntidadIntegraciondeCompras As New Capa_Entidad.IntegraciondeCompras
        Dim NegocioIntegraciondeCompras As New Capa_Negocio.IntegraciondeCompras
        EntidadIntegraciondeCompras.Consulta = Consulta.ConsultaCompraPorNombre
        EntidadIntegraciondeCompras.IdCompra = IIf(TbIdCompra.Text = "", 0, TbIdCompra.Text)
        EntidadIntegraciondeCompras.NombreProductor = TbNombre.Text
        NegocioIntegraciondeCompras.Consultar(EntidadIntegraciondeCompras)
        Tabla = EntidadIntegraciondeCompras.TablaConsulta
        DgvCompras.Columns.Clear()
        DgvCompras.DataSource = Tabla
        'Dim colSelCon As New DataGridViewCheckBoxColumn()
        'colSelCon.Name = "Seleccionar"
        'colSelCon.FalseValue = False
        'colSelCon.Visible = True
        'DgvCompras.Columns.Insert(21, colSelCon)
        'PropiedadesDgvCompras()
        DgvCompras.CurrentCell = Nothing
    End Sub
    Private Sub TbFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles TbIdCompra.KeyDown, TbNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            ConsultaCompra()
        End If
    End Sub

    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        ConsultaCompra()
    End Sub
    Private Sub DgvCompras_DoubleClick(sender As Object, e As EventArgs) Handles DgvCompras.DoubleClick
        If DgvCompras.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvCompras.CurrentCell.RowIndex
            _IdCompra = DgvCompras.Rows(index).Cells("IdCompra").Value
            _IdContrato = DgvCompras.Rows(index).Cells("IdContratoAlgodon").Value
            _IdCliente = DgvCompras.Rows(index).Cells("Idcliente").Value
            _NombreProductor = DgvCompras.Rows(index).Cells("Nombre").Value
            _Rfc = DgvCompras.Rows(index).Cells("Rfc").Value
            _PrecioQuintal = DgvCompras.Rows(index).Cells("PrecioQuintal").Value
            _TotalPacas = DgvCompras.Rows(index).Cells("TotalPacas").Value
            _Subtotal = DgvCompras.Rows(index).Cells("Subtotal").Value
            _CastigoDls = DgvCompras.Rows(index).Cells("CastigoDls").Value
            _TotalDls = DgvCompras.Rows(index).Cells("TotalDlls").Value
            _Fecha = DgvCompras.Rows(index).Cells("Fecha").Value
            _TotalKilos = DgvCompras.Rows(index).Cells("Kilos").Value
            Close()
        End If
    End Sub
End Class