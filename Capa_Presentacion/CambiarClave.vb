Imports Capa_Operacion.Configuracion
Public Class CambiarClave
    Private Sub CambiarClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub ConsultaBDD()
        Dim tabla As New DataTable
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        EntidadConfiguracionParametros.Consulta = Consulta.ConsultaBaseDatos
        NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
        tabla = EntidadConfiguracionParametros.TablaConsulta
        For Each Fila As DataRow In tabla.Rows
            UsuarioRegistrado(TbUsuario.Text, Fila("name"), TbClaveActual.Text, TbClaveNueva.Text, TbClaveConfirma.Text)
        Next
    End Sub
    Private Function UsuarioRegistrado(ByVal Usuario As String, ByVal BaseDeDatos As String, ByVal Clave As String, ByVal claveNueva As String, ByVal claveConfirma As String) As String
        Dim EntidadAcceso As New Capa_Entidad.Acceso
        Dim NegocioAcceso As New Capa_Negocio.Acceso
        Dim Encriptar As New Encriptar
        Dim Tabla As New DataTable
        Dim Resultado As Boolean = False
        EntidadAcceso.Usuario = Usuario
        EntidadAcceso.BaseDeDatos = BaseDeDatos
        EntidadAcceso.Consulta = Consulta.ConsultaUsuario
        NegocioAcceso.Consultar(EntidadAcceso)
        Tabla = EntidadAcceso.TablaConsulta
        If Tabla.Rows(0).Item("Validacion") = False Then
            'MessageBox.Show("El Usuario " & TbUsuario.Text & " no existe, verifique de nuevo.", "Aviso")
            LbConfirmaClave.Text = "El Usuario " & TbUsuario.Text & " no existe, verifique de nuevo."
            LbConfirmaClave.ForeColor = Color.Red
            Resultado = False
        ElseIf Tabla.Rows(0).Item("Clave").Equals(Encriptar.Encriptar(Clave)) = False Then
            'MessageBox.Show("La contraseña ingresada no es correcta, verifique de nuevo.", "Aviso")
            LbConfirmaClave.Text = "La contraseña ingresada no es correcta, verifique de nuevo."
            LbConfirmaClave.ForeColor = Color.Red
            Resultado = False
        ElseIf claveNueva.Equals(ClaveConfirma) = False Then
            'MessageBox.Show("Las contraseñas no coinciden, verifique de nuevo.", "Aviso")
            LbConfirmaClave.Text = "Las contraseñas no coinciden, verifique de nuevo."
            LbConfirmaClave.ForeColor = Color.Red
            Resultado = False
        Else
            Resultado = True
        End If
        Return Resultado
    End Function
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Close()
    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        ConsultaBDD()
    End Sub
End Class