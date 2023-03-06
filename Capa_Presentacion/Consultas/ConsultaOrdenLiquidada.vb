Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultaOrdenLiquidada
    Private _IdConsulta As Integer
    Public Property IdConsulta() As Integer
        Get
            Return _IdConsulta
        End Get
        Set(value As Integer)
            _IdConsulta = value
        End Set
    End Property

    Private Sub ConsultaOrdenLiquidada_Load(sender As Object, e As EventArgs) Handles Me.Load
        limpiar()
        ConsultaOrdenTrabajo()
    End Sub
    Private Sub limpiar()
        TbIdEmbarque.Text = ""
        TbNombreComprador.Text = ""
    End Sub
    Private Sub ConsultaOrdenTrabajo()
        Dim EntidadLiquidacionesPorRomaneaje As New Capa_Entidad.LiquidacionesPorRomaneaje
        Dim NegocioLiquidacionesPorRomaneaje As New Capa_Negocio.LiquidacionesPorRomaneaje
        Dim Tabla As New DataTable
        Try
            EntidadLiquidacionesPorRomaneaje.IdOrdenTrabajo = IIf(TbIdEmbarque.Text = "", 0, TbIdEmbarque.Text)
            EntidadLiquidacionesPorRomaneaje.nombre = TbNombreComprador.Text
            EntidadLiquidacionesPorRomaneaje.Consulta = Consulta.ConsultaOrdenLiquidada
            NegocioLiquidacionesPorRomaneaje.Consultar(EntidadLiquidacionesPorRomaneaje)
            DgvConsultaEmbarque.DataSource = EntidadLiquidacionesPorRomaneaje.TablaConsulta
            'PropiedadesDgv()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub BtConsulta_Click(sender As Object, e As EventArgs) Handles BtConsulta.Click
        ConsultaOrdenTrabajo()
    End Sub

    Private Sub TbIdEmbarque_KeyDown(sender As Object, e As KeyEventArgs) Handles TbIdEmbarque.KeyDown, TbNombreComprador.KeyDown
        If e.KeyCode = Keys.Enter Then
            ConsultaOrdenTrabajo()
        End If
    End Sub

    Private Sub DgvConsultaEmbarque_DoubleClick(sender As Object, e As EventArgs) Handles DgvConsultaEmbarque.DoubleClick
        If DgvConsultaEmbarque.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles.")
        Else
            Dim index As Integer
            index = DgvConsultaEmbarque.CurrentRow.Index
            _IdConsulta = DgvConsultaEmbarque.Rows(index).Cells("IdOrdenTrabajo").Value
            Close()
        End If
    End Sub
End Class