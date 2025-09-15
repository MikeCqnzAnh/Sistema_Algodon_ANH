Public Class LotesPacas
    Private origenView, destinoView As DataView
    Private dtorigen, dtdestino As DataTable
    Private Const RegistrosPorCarga = 50
    Private registrosCargadosOrigen As Integer = 0
    Private resigtrosCargadosDestino As Integer = 0
    Private ordenAscendenteorigen As Boolean
    Private ordenAscendentedestino As Boolean
    Private Sub LotesPacas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenacombo()
    End Sub

    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim consultalotes As New ConsultaLotesEnc()
        consultalotes.ShowDialog()
        If consultalotes._idlote > 0 Then
            tbidlote.Text = consultalotes._idlote
            tbidcliente.Text = consultalotes._idcomprador
            tbnombrecliente.Text = consultalotes._nombre
            tbnombrelote.Text = consultalotes._nolote
        End If
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click

    End Sub
    Private Sub guardarenc()
        Dim elotespaca As New Capa_Entidad.LotesPacas
        Dim nlotespaca As New Capa_Negocio.LotesPacas

        elotespaca.Guarda = Guardar.GuardarEncabezado
        elotespaca.idlote = IIf(tbidlote.Text = "", 0, tbidlote.Text)
        elotespaca.idcomprador = tbidcliente.Text
        elotespaca.nolote = tbnombrelote.Text

    End Sub
    Private Sub btconsultaclientes_Click(sender As Object, e As EventArgs) Handles btconsultaclientes.Click
        Dim compradores As New ConsultaCompradores()
        compradores.ShowDialog()
        If compradores.idcomprador_ > 0 Then
            tbidcliente.Text = compradores.idcomprador_
            tbnombrecliente.Text = compradores.nombre_
        End If
    End Sub
    Private Sub llenacombo()
        Dim dt As New DataTable("Tabla")
        Dim dr As DataRow

        Try
            dt.Columns.Add("Id")
            dt.Columns.Add("Descripcion")

            dr = dt.NewRow()
            dr("Id") = "0"
            dr("Descripcion") = "Inactivo"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Id") = "1"
            dr("Descripcion") = "Activo"
            dt.Rows.Add(dr)

            cbestatus.DataSource = dt
            cbestatus.ValueMember = "Id"
            cbestatus.DisplayMember = "Descripcion"
            cbestatus.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error " & ex.ToString())
        End Try
    End Sub
End Class