Imports Capa_Operacion.Configuracion
Public Class Monedas
    Private Sub Monedas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
        LlenaDgv()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub
    Private Sub Nuevo()
        TbAbreviacion.Text = ""
        TbNombreMoneda.Text = ""
        TbIdMoneda.Text = ""
    End Sub
    Private Sub LlenaDgv()
        Dim EntidadMonedas As New Capa_Entidad.Monedas
        Dim NegocioMonedas As New Capa_Negocio.Monedas
        Dim Tabla As New DataTable
        'EntidadClientes.IdCliente = ConsultaClientes.IdCliente
        EntidadMonedas.Consulta = Consulta.ConsultaDetallada
        NegocioMonedas.Consultar(EntidadMonedas)
        DgvMonedas.DataSource = EntidadMonedas.TablaConsulta
        PropiedadesDGV()
    End Sub
    Private Sub PropiedadesDGV()
        DgvMonedas.Columns("IdMoneda").Visible = False
        DgvMonedas.Columns("NombreMoneda").HeaderText = "Moneda"
        DgvMonedas.Columns("NombreMoneda").ReadOnly = True
        DgvMonedas.Columns("Abreviacion").ReadOnly = True
        DgvMonedas.Columns("IdEstatus").ReadOnly = True
        DgvMonedas.Columns("IdUsuarioCreacion").Visible = False
        DgvMonedas.Columns("FechaCreacion").Visible = False
        DgvMonedas.Columns("IdUsuarioActualizacion").Visible = False
        DgvMonedas.Columns("FechaActualizacion").Visible = False
    End Sub
    Private Sub Guardar()
        If TbNombreMoneda.Text = "" Or TbAbreviacion.Text = "" Then
            MessageBox.Show("No se puede guardar registro con campos en blanco, verifica!")
        Else
            Try
                Dim EntidadMonedas As New Capa_Entidad.Monedas
                Dim NegocioMonedas As New Capa_Negocio.Monedas
                EntidadMonedas.IdMoneda = IIf(TbIdMoneda.Text = "", 0, TbIdMoneda.Text)
                EntidadMonedas.NombreMoneda = TbNombreMoneda.Text
                EntidadMonedas.Abreviacion = TbAbreviacion.Text
                EntidadMonedas.IdUsuarioCreacion = 1
                EntidadMonedas.FechaCreacion = Now
                EntidadMonedas.IdUsuarioActualizacion = 1
                EntidadMonedas.FechaActualizacion = Now
                NegocioMonedas.Guardar(EntidadMonedas)
                TbIdMoneda.Text = EntidadMonedas.IdMoneda
                MsgBox("Realizado Correctamente")
                LlenaDgv()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub GuardarActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarActualizarToolStripMenuItem.Click
        Guardar()
    End Sub

    Private Sub DgvMonedas_DoubleClick(sender As Object, e As EventArgs) Handles DgvMonedas.DoubleClick
        If DgvMonedas.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvMonedas.CurrentCell.RowIndex
            TbIdMoneda.Text = DgvMonedas.Rows(index).Cells("IdMoneda").Value
            TbAbreviacion.Text = DgvMonedas.Rows(index).Cells("Abreviacion").Value
            TbNombreMoneda.Text = DgvMonedas.Rows(index).Cells("NombreMoneda").Value
        End If
    End Sub
End Class