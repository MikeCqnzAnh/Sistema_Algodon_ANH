Public Class RestaurarRespaldo
    Private Sub btnRestore_Click(ByVal sender As Object, ByVal e As EventArgs) Handles BtRestaurar.Click
        Me.BtRestaurar.Enabled = False
        Me.BtRestaurar.Text = "Restaurando..."
        Me.BtRestaurar.Refresh()

        RestaurarRespaldo()

        Me.BtRestaurar.Text = "Restaurar copia"
        Me.BtRestaurar.Enabled = True
        Me.BtRestaurar.Refresh()

    End Sub
    Private Sub RestaurarRespaldo()
        Dim EntidadRestaurarRespaldo As New Capa_Entidad.RestaurarRespaldo
        Dim NegocioRestaurarRespaldo As New Capa_Negocio.RestaurarRespaldo
        If TbBDD.Text = "" And TbRutaArchivoRespaldo.Text = "" Then
            MsgBox("Verificar los campos vacios")
            Exit Sub
        End If
        Try
            EntidadRestaurarRespaldo.BaseDedatosOrigen = TbBDD.Text
            EntidadRestaurarRespaldo.RutaArchivoRespaldo = TbRutaArchivoRespaldo.Text
            NegocioRestaurarRespaldo.Restaurar(EntidadRestaurarRespaldo)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtSeleccionaRuta_Click(sender As System.Object, e As System.EventArgs) Handles BtSeleccionaRuta.Click
        If OfArchivoRestaurar.ShowDialog = DialogResult.OK Then
            TbRutaArchivoRespaldo.Text = OfArchivoRestaurar.FileName
        End If
    End Sub
    Private Sub RestaurarRespaldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbBDD.Text = BaseDeDatos
        TbRutaArchivoRespaldo.Text = ""
    End Sub
End Class