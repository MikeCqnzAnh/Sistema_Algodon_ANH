Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultarSalidasPacas
    Private _IdSalida
    Public Property IdSalida() As Integer
        Get
            Return _IdSalida
        End Get
        Set(value As Integer)
            _IdSalida = value
        End Set
    End Property
    Private _Idembarque
    Public Property IdEmbarque As Integer
        Get
            Return _Idembarque
        End Get
        Set(value As Integer)
            _Idembarque = value
        End Set
    End Property
    Private _IdComprador
    Public Property IdComprador
        Get
            Return _IdComprador
        End Get
        Set(value)
            _IdComprador = value
        End Set
    End Property
    Private _IdCompradorAcuenta
    Public Property IdCompradorAcuenta As Integer
        Get
            Return _IdCompradorAcuenta
        End Get
        Set(value As Integer)
            _IdCompradorAcuenta = value
        End Set
    End Property
    Private _NombreChofer
    Public Property NombreChofer As String
        Get
            Return _NombreChofer
        End Get
        Set(value As String)
            _NombreChofer = value
        End Set
    End Property
    Private _PlacaTractoCamion
    Public Property PlacaTractoCamion As String
        Get
            Return _PlacaTractoCamion
        End Get
        Set(value As String)
            _PlacaTractoCamion = value
        End Set
    End Property
    Private _NoLicencia
    Public Property NoLicencia As String
        Get
            Return _NoLicencia
        End Get
        Set(value As String)
            _NoLicencia = value
        End Set
    End Property
    Private _Telefono
    Public Property Telefono As String
        Get
            Return _Telefono
        End Get
        Set(value As String)
            _Telefono = value
        End Set
    End Property
    Private _PesoBruto
    Public Property PesoBruto As Decimal
        Get
            Return _PesoBruto
        End Get
        Set(value As Decimal)
            _PesoBruto = value
        End Set
    End Property
    Private _PesoTara
    Public Property PesoTara As Decimal
        Get
            Return _PesoTara
        End Get
        Set(value As Decimal)
            _PesoTara = value
        End Set
    End Property
    Private _PesoNeto
    Public Property PesoNeto As Decimal
        Get
            Return _PesoNeto
        End Get
        Set(value As Decimal)
            _PesoNeto = value
        End Set
    End Property
    Private _Destino
    Public Property Destino As String
        Get
            Return _Destino
        End Get
        Set(value As String)
            _Destino = value
        End Set
    End Property
    Private _FolioSalida
    Public Property FolioSalida As Integer
        Get
            Return _FolioSalida
        End Get
        Set(value As Integer)
            _FolioSalida = value
        End Set
    End Property
    Private _NoFactura
    Public Property NoFactura As String
        Get
            Return _NoFactura
        End Get
        Set(value As String)
            _NoFactura = value
        End Set
    End Property
    Private _CantidadPacas
    Public Property CantidadPacas As Integer
        Get
            Return _CantidadPacas
        End Get
        Set(value As Integer)
            _CantidadPacas = value
        End Set
    End Property
    Private _FechaEntrada
    Public Property FechaEntrada As DateTime
        Get
            Return _FechaEntrada
        End Get
        Set(value As DateTime)
            _FechaEntrada = value
        End Set
    End Property
    Private _FechaSalida
    Public Property FechaSalida As DateTime
        Get
            Return _FechaSalida
        End Get
        Set(value As DateTime)
            _FechaSalida = value
        End Set
    End Property
    Private _Observaciones
    Public Property Observaciones
        Get
            Return _Observaciones
        End Get
        Set(value)
            _Observaciones = value
        End Set
    End Property
    Private _EstatusSalida
    Public Property EstatusSalida As Integer
        Get
            Return _EstatusSalida
        End Get
        Set(value As Integer)
            _EstatusSalida = value
        End Set
    End Property
    Private _NombreComprador
    Public Property NombreComprador
        Get
            Return _NombreComprador
        End Get
        Set(value)
            _NombreComprador = value
        End Set
    End Property
    Private Sub ConsultarSalidasPacas_Load(sender As Object, e As EventArgs) Handles Me.Load
        Id = 0
        DgvSalidas.DataSource = ""
    End Sub
    Private Sub ConsultaSalida()
        Try
            Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
            Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
            Dim Tabla As New DataTable
            EntidadSalidaPacas.Consulta = Consulta.ConsultaSalidaEncabezado
            EntidadSalidaPacas.IdSalidaEncabezado = Val(TbIdSalida.Text)
            EntidadSalidaPacas.NombreComprador = TbComprador.Text
            NegocioSalidaPacas.Consultar(EntidadSalidaPacas)
            DgvSalidas.DataSource = EntidadSalidaPacas.TablaConsulta
            PropiedadesDgv()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PropiedadesDgv()
        DgvSalidas.Columns("IdSalidaEncabezado").HeaderText = "ID Salida"
        'DgvSalidas.Columns("IdEmbarqueEncabezado").HeaderText = "ID Embarque"
        DgvSalidas.Columns("IdComprador").Visible = False
        DgvSalidas.Columns("Comprador").HeaderText = "Comprador"
        DgvSalidas.Columns("NombreChofer").HeaderText = "Chofer"
        DgvSalidas.Columns("PlacaTractoCamion").HeaderText = "Placas Camion"
        DgvSalidas.Columns("NoLicencia").Visible = False
        DgvSalidas.Columns("Telefono").Visible = False
        DgvSalidas.Columns("Destino").Visible = False
        DgvSalidas.Columns("NoFactura").Visible = False
        DgvSalidas.Columns("FechaSalida").Visible = False
        DgvSalidas.Columns("FechaEntrada").HeaderText = "Fecha Entrada"
        DgvSalidas.Columns("Observaciones").Visible = False
        DgvSalidas.Columns("PesoBruto").Visible = False
        DgvSalidas.Columns("PesoTara").Visible = False
        DgvSalidas.Columns("PesoNeto").Visible = False
        DgvSalidas.Columns("EstatusSalida").Visible = False
    End Sub
    Private Sub EventoKeypress(sender As Object, e As KeyEventArgs) Handles TbIdSalida.KeyDown, TbComprador.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                ConsultaSalida()
        End Select
    End Sub
    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        ConsultaSalida()
    End Sub

    Private Sub DgvSalidas_DoubleClick(sender As Object, e As EventArgs) Handles DgvSalidas.DoubleClick
        If DgvSalidas.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvSalidas.CurrentCell.RowIndex
            _IdSalida = DgvSalidas.Rows(index).Cells("IdSalidaEncabezado").Value
            _Idembarque = DgvSalidas.Rows(index).Cells("IdEmbarqueEncabezado").Value
            _IdComprador = DgvSalidas.Rows(index).Cells("IdComprador").Value
            _NombreComprador = DgvSalidas.Rows(index).Cells("Comprador").Value
            _NombreChofer = DgvSalidas.Rows(index).Cells("NombreChofer").Value
            _PlacaTractoCamion = DgvSalidas.Rows(index).Cells("PlacaTractoCamion").Value
            _NoLicencia = DgvSalidas.Rows(index).Cells("NoLicencia").Value
            _Telefono = DgvSalidas.Rows(index).Cells("Telefono").Value
            _PesoBruto = DgvSalidas.Rows(index).Cells("PesoBruto").Value
            _PesoTara = DgvSalidas.Rows(index).Cells("PesoTara").Value
            _PesoNeto = DgvSalidas.Rows(index).Cells("PesoNeto").Value
            _Destino = DgvSalidas.Rows(index).Cells("Destino").Value
            _FolioSalida = DgvSalidas.Rows(index).Cells("FolioSalida").Value
            _NoFactura = DgvSalidas.Rows(index).Cells("NoFactura").Value
            _FechaSalida = IIf(IsDBNull(DgvSalidas.Rows(index).Cells("FechaSalida").Value), Now, DgvSalidas.Rows(index).Cells("FechaSalida").Value)
            _FechaEntrada = DgvSalidas.Rows(index).Cells("FechaEntrada").Value
            _Observaciones = DgvSalidas.Rows(index).Cells("Observaciones").Value
            _IdCompradorAcuenta = DgvSalidas.Rows(index).Cells("IdCompradorPorCuentaDe").Value
            _EstatusSalida = DgvSalidas.Rows(index).Cells("EstatusSalida").Value

            Close()
        End If
    End Sub
End Class