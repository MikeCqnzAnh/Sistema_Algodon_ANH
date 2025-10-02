Public Class Acercade
    Private Sub Acercade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        obtenerversion()
        CargarAcercaDe()
    End Sub
    Private Sub obtenerversion()
        lbversion.Text = lbversion.Text & String.Format("Version: {0}", Application.ProductVersion)
    End Sub
    Private Sub CargarAcercaDe()
        Dim texto As String = ""
        texto &= "Calcula Cotton "
        texto &= "es una aplicación diseñada para el sector algodonero que facilita el control integral de la producción y comercialización. Con esta herramienta podrás gestionar:" & vbCrLf & vbCrLf
        texto &= "• Productores y la compra de su producción." & vbCrLf
        texto &= "• Empresas compradoras de algodón." & vbCrLf
        texto &= "• Contratos de compra y venta." & vbCrLf
        texto &= "• Perfiles de deducción." & vbCrLf
        texto &= "• Procesos de compra y venta." & vbCrLf
        texto &= "• Lotes y órdenes de embarque." & vbCrLf
        texto &= "• Control de salidas." & vbCrLf
        texto &= "• Reportes detallados para la toma de decisiones." & vbCrLf & vbCrLf
        texto &= "Desarrollador: Ing. Miguel Carrillo" & vbCrLf
        texto &= "Contacto: calculacotton@gmail.com" & vbCrLf
        texto &= "Registro de marca: Sistema registrado en el IMPI con marca protegida." & vbCrLf

        ' Cargar el texto en el RichTextBox
        RichTextBox1.Text = texto

        ' Solo poner en negritas la PRIMERA aparición de "Calcula Cotton"
        Dim palabra As String = "Calcula Cotton"
        Dim idx As Integer = RichTextBox1.Text.IndexOf(palabra)

        If idx >= 0 Then
            RichTextBox1.Select(idx, palabra.Length)
            RichTextBox1.SelectionFont = New Font(RichTextBox1.Font, FontStyle.Bold)
            RichTextBox1.Select(0, 0) ' Quitar selección
        End If
    End Sub
End Class