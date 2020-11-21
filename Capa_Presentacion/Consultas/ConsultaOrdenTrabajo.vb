Imports Capa_Operacion.Configuracion
Public Class ConsultaOrdenTrabajo
    Private _IdConsulta As Integer
    Public Property IdConsulta() As Integer
        Get
            Return _IdConsulta
        End Get
        Set(value As Integer)
            _IdConsulta = value
        End Set
    End Property
    Private Sub ConsultaOrdenTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbOrden.Select()
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
    Private Sub Consultar()
        Dim EntidadOrdenTrabajo As New Capa_Entidad.OrdenTrabajo
        Dim NegocioOrdenTrabajo As New Capa_Negocio.OrdenTrabajo
        Dim Tabla As New DataTable
        Try
            EntidadOrdenTrabajo.Consulta = Consulta.ConsultaOrdenEmbarqueEncabezado
            EntidadOrdenTrabajo.IdOrdenTrabajo = Val(TbOrden.Text)
            NegocioOrdenTrabajo.Consultar(EntidadOrdenTrabajo)
            DgvConsultaOrden.DataSource = EntidadOrdenTrabajo.TablaConsulta
            PropiedadesDgv()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PropiedadesDgv()
        DgvConsultaOrden.Columns("IdPlanta").Visible = False
        DgvConsultaOrden.Columns("IdProductor").Visible = False
        DgvConsultaOrden.Columns("PesoModulos").Visible = False
        DgvConsultaOrden.Columns("IdVariedadAlgodon").Visible = False
        DgvConsultaOrden.Columns("IdEstatus").Visible = False
        DgvConsultaOrden.Columns("IdColonia").Visible = False
        DgvConsultaOrden.Columns("IdUsuarioCreacion").Visible = False
        DgvConsultaOrden.Columns("IdUsuarioActualizacion").Visible = False
        DgvConsultaOrden.Columns("FechaActualizacion").Visible = False
    End Sub
    Private Sub DgvConsultaOrden_DoubleClick(sender As Object, e As EventArgs) Handles DgvConsultaOrden.DoubleClick
        If DgvConsultaOrden.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles.")
        Else
            Dim index As Integer
            index = DgvConsultaOrden.CurrentRow.Index
            _IdConsulta = DgvConsultaOrden.Rows(index).Cells("IdOrdenTrabajo").Value
            Close()
        End If
    End Sub
    Private Sub Limpiar()
        TbOrden.Text = ""
        _IdConsulta = 0
        DgvConsultaOrden.DataSource = Nothing
    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        'ConsultaOrdenTrabajo()
        Consultar()
    End Sub

    Private Sub TbOrden_KeyDown(sender As Object, e As KeyEventArgs) Handles TbOrden.KeyDown
        If e.KeyCode = Keys.Enter Then
            Consultar()
        End If
    End Sub
End Class