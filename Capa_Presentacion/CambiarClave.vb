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
            Dim EntidadAcceso As New Capa_Entidad.Acceso
            Dim NegocioAcceso As New Capa_Negocio.Acceso
            Dim Encriptar As New Encriptar
            Dim Tabla1 As New DataTable
            Dim Resultado As Boolean = False
            EntidadAcceso.Usuario = TbUsuario.Text
            EntidadAcceso.BaseDeDatos = Fila("name")
            EntidadAcceso.Consulta = Consulta.ConsultaUsuario
            NegocioAcceso.Consultar(EntidadAcceso)
            Tabla1 = EntidadAcceso.TablaConsulta
            If Tabla1.Rows(0).Item("Validacion") = False Then
                LbConfirmaClave.Text = "El Usuario " & TbUsuario.Text & " no existe, verifique de nuevo."
                LbConfirmaClave.ForeColor = Color.Red
                TbUsuario.ForeColor = Color.Red
                TbClaveActual.ForeColor = Color.Black
                TbClaveConfirma.ForeColor = Color.Black
                TbClaveNueva.ForeColor = Color.Black
                Exit For
            ElseIf Tabla1.Rows(0).Item("Clave").Equals(Encriptar.Encriptar(TbClaveActual.Text)) = False Then
                LbConfirmaClave.Text = "La contraseña ingresada no es correcta, verifique de nuevo."
                LbConfirmaClave.ForeColor = Color.Red
                TbClaveActual.ForeColor = Color.Red
                TbUsuario.ForeColor = Color.Black
                TbClaveConfirma.ForeColor = Color.Black
                TbClaveNueva.ForeColor = Color.Black
                Exit For
            ElseIf TbClaveNueva.Text.Equals(TbClaveConfirma.Text) = False Then
                LbConfirmaClave.Text = "Las contraseñas no coinciden, verifique de nuevo."
                LbConfirmaClave.ForeColor = Color.Red
                TbClaveNueva.ForeColor = Color.Red
                TbClaveConfirma.ForeColor = Color.Red
                TbClaveActual.ForeColor = Color.Black
                TbUsuario.ForeColor = Color.Black
                Exit For
            Else
                TbClaveActual.ForeColor = Color.Black
                TbClaveConfirma.ForeColor = Color.Black
                TbClaveNueva.ForeColor = Color.Black
                LbConfirmaClave.ForeColor = Color.Black
                LbConfirmaClave.Text = ""
            End If
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
            LbConfirmaClave.Text = "Las contraseña nueva y la confirmacion no coinciden, verifique de nuevo."
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
        If TbUsuario.Text <> "" And TbClaveActual.Text <> "" And TbClaveNueva.Text <> "" And TbClaveConfirma.Text <> "" Then
            ConsultaBDD()
        Else
            MsgBox("No se puede continuar con campos vacios, revise de nuevo!")
        End If
    End Sub
End Class