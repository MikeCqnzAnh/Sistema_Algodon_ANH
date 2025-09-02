Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Imports System.IO
Public Class ConsultaContratoVenta
    Private _IdContratoVenta As Integer
    Private _nombre As String
    Private _PacasDispContcomp As Integer
    Private _PacasContVenta As Integer
    Public Property IdContratoVenta() As Integer
        Get
            Return _IdContratoVenta
        End Get
        Set(value As Integer)
            _IdContratoVenta = value
        End Set
    End Property
    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property PacasDispContcomp() As Integer
        Get
            Return _PacasDispContcomp
        End Get
        Set(value As Integer)
            _PacasDispContcomp = value
        End Set
    End Property
    Public Property PacasContVenta() As Integer
        Get
            Return _PacasContVenta
        End Get
        Set(value As Integer)
            _PacasContVenta = value
        End Set
    End Property
    Private Sub ConsultaContratoVenta_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbnombre.Select()
        consultar()
    End Sub
    Private Sub consultar()
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        Dim Tabla As New DataTable
        Try
            EntidadContratosAlgodon.Consulta = Consulta.ConsultaContratovta
            EntidadContratosAlgodon.NombreComprador = tbnombre.Text
            NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
            dgvcontratoventa.DataSource = EntidadContratosAlgodon.TablaConsulta
            propiedadesdgv()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub tbnombre_TextChanged(sender As Object, e As EventArgs) Handles tbnombre.TextChanged
        consultar()
    End Sub
    Private Sub propiedadesdgv()
        dgvcontratoventa.Columns("IdContratoAlgodon").HeaderText = "ID Contrato vta"
        dgvcontratoventa.Columns("IdUnidadPeso").Visible = False
        dgvcontratoventa.Columns("ValorConversion").Visible = False
        dgvcontratoventa.Columns("Puntos").Visible = False
        dgvcontratoventa.Columns("IdModalidadVenta").Visible = False
        dgvcontratoventa.Columns("Temporada").Visible = False
        dgvcontratoventa.Columns("IdComprador").Visible = False
        dgvcontratoventa.Columns("PrecioSM").Visible = False
        dgvcontratoventa.Columns("PrecioMP").Visible = False
        dgvcontratoventa.Columns("PrecioM").Visible = False
        dgvcontratoventa.Columns("PrecioSLMP").Visible = False
        dgvcontratoventa.Columns("PrecioSLM").Visible = False
        dgvcontratoventa.Columns("PrecioLMP").Visible = False
        dgvcontratoventa.Columns("PrecioLM").Visible = False
        dgvcontratoventa.Columns("PrecioSGO").Visible = False
        dgvcontratoventa.Columns("PrecioGO").Visible = False
        dgvcontratoventa.Columns("PrecioO").Visible = False

    End Sub

    Private Sub dgvcontratoventa_DoubleClick(sender As Object, e As EventArgs) Handles dgvcontratoventa.DoubleClick
        If dgvcontratoventa.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = dgvcontratoventa.CurrentCell.RowIndex
            _IdContratoVenta = dgvcontratoventa.Rows(index).Cells("IdContratoAlgodon").Value
            _nombre = dgvcontratoventa.Rows(index).Cells("Nombre").Value
            _PacasDispContcomp = dgvcontratoventa.Rows(index).Cells("PacasDispContcomp").Value
            _PacasContVenta = dgvcontratoventa.Rows(index).Cells("Pacas").Value
            Close()
        End If
    End Sub
End Class