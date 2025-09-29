Public Class Acercade
    Private Sub Acercade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerversion()
    End Sub
    Private Sub obtenerversion()
        lbversion.Text = lbversion.Text & String.Format("Version: {0}", Application.ProductVersion)
    End Sub

End Class