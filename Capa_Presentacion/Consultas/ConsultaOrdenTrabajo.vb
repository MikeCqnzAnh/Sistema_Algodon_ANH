Imports Capa_Operacion.Configuracion
Public Class ConsultaOrdenTrabajo
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property
    Private Sub ConsultaOrdenTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbOrden.Focus()
        Limpiar()
    End Sub
    Private Sub ConsultaOrdenTrabajo()
        Dim EntidadLiquidacionesPorRomaneaje As New Capa_Entidad.LiquidacionesPorRomaneaje
        Dim NegocioLiquidacionesPorRomaneaje As New Capa_Negocio.LiquidacionesPorRomaneaje
        Dim Tabla As New DataTable
        EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo = IIf(TbOrden.Text = "", 0, TbOrden.Text)
        EntidadLiquidacionesPorRomaneaje.Consulta = Consulta.ConsultaOrden
        NegocioLiquidacionesPorRomaneaje.Consultar(EntidadLiquidacionesPorRomaneaje)
        DgvConsultaOrden.DataSource = EntidadLiquidacionesPorRomaneaje.TablaConsulta
        PropiedadesDgv()
    End Sub
    Private Sub PropiedadesDgv()
        DgvConsultaOrden.Columns("IdPlantaOrigen").Visible = False
        DgvConsultaOrden.Columns("TotalHueso").Visible = False
        DgvConsultaOrden.Columns("Pluma").Visible = False
        DgvConsultaOrden.Columns("IdCliente").Visible = False
        DgvConsultaOrden.Columns("IdPorCuenta").Visible = False
    End Sub
    Private Sub DgvConsultaOrden_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvConsultaOrden.CellContentDoubleClick
        Dim EntidadConsultaOrdenTrabajo As New Capa_Entidad.LiquidacionesPorRomaneaje
        Dim NegocioConsultaOrdenTrabajo As New Capa_Negocio.LiquidacionesPorRomaneaje
        Dim index As Integer
        index = DgvConsultaOrden.CurrentRow.Index
        _Id = DgvConsultaOrden.Rows(index).Cells("IdOrdenTrabajo").Value.ToString()
        Close()
    End Sub
    Private Sub Limpiar()
        TbOrden.Text = ""
        DgvConsultaOrden.DataSource = Nothing
    End Sub
    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        ConsultaOrdenTrabajo()
    End Sub
End Class