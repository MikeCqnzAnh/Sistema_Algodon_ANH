Imports Capa_Operacion.Configuracion
Public Class ConsultaTierras
    Private _IdTierra As Integer
    Public Property IdTierra() As Integer
        Get
            Return _IdTierra
        End Get
        Set(value As Integer)
            _IdTierra = value
        End Set
    End Property
    Private Sub ConsultarTierras()
        Dim tabla2 As New DataTable
        Dim EntidadTierras As New Capa_Entidad.Tierras
        Dim NegocioTierras As New Capa_Negocio.Tierras
        EntidadTierras.Consulta = Consulta.ConsultaBasica
        EntidadTierras.Lote = TbNombreLote.Text
        NegocioTierras.Consultar(EntidadTierras)
        tabla2 = EntidadTierras.TablaConsulta
        DgvConsultaTierras.DataSource = tabla2
    End Sub

    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        ConsultarTierras()
        PropiedadesDgv()
    End Sub

    Private Sub DgvConsultaTierras_DoubleClick() Handles DgvConsultaTierras.DoubleClick
        If DgvConsultaTierras.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvConsultaTierras.CurrentCell.RowIndex
            _IdTierra = DgvConsultaTierras.Rows(index).Cells("IdTierra").Value
            Close()
        End If
    End Sub
    Private Sub Limpiar()
        TbNombreLote.Text = ""
        DgvConsultaTierras.DataSource = ""
    End Sub
    Private Sub PropiedadesDgv()
        DgvConsultaTierras.Columns("IdTierra").Visible = False
        DgvConsultaTierras.Columns("SuperficieTotal").Visible = False
        DgvConsultaTierras.Columns("RegistroAlterno").Visible = False
        DgvConsultaTierras.Columns("LatitudGrados").Visible = False
        DgvConsultaTierras.Columns("LatitudMinutos").Visible = False
        DgvConsultaTierras.Columns("LatitudHoras").Visible = False
        DgvConsultaTierras.Columns("LongitudGrados").Visible = False
        DgvConsultaTierras.Columns("LongitudHoras").Visible = False
        DgvConsultaTierras.Columns("LongitudMinutos").Visible = False
        DgvConsultaTierras.Columns("NumeroRpp").Visible = False
        DgvConsultaTierras.Columns("FolioRpp").Visible = False
        DgvConsultaTierras.Columns("LibroRpp").Visible = False
        DgvConsultaTierras.Columns("Fecha").Visible = False
        DgvConsultaTierras.Columns("TituloAgua").Visible = False
        DgvConsultaTierras.Columns("RegimenHidrico").Visible = False
        DgvConsultaTierras.Columns("FechaTituloAgua").Visible = False
        DgvConsultaTierras.Columns("IdEstatus").Visible = False
        DgvConsultaTierras.Columns("IdUsuarioCreacion").Visible = False
        DgvConsultaTierras.Columns("FechaCreacion").Visible = False
    End Sub
    Private Sub ConsultaTierras_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub
End Class