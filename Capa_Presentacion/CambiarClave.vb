Imports Capa_Operacion.Configuracion
Public Class CambiarClave
    Private Sub CambiarClave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
    End Sub
    Private Sub ConsultaBDD()
        Dim tabla As New DataTable
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        Dim EntidadAcceso As New Capa_Entidad.Acceso
        Dim NegocioAcceso As New Capa_Negocio.Acceso
        Dim Encriptar As New Encriptar
        Dim Tabla1 As New DataTable
        Dim Resultado As Boolean = False
        'EntidadConfiguracionParametros.Consulta = Consulta.ConsultaBaseDatos
        '    NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
        '    tabla = EntidadConfiguracionParametros.TablaConsulta
        Try
            'For Each Fila As DataRow In tabla.Rows
            EntidadAcceso.Usuario = TbUsuario.Text
            'EntidadAcceso.BaseDeDatos = Fila("name")
            EntidadAcceso.Consulta = Consulta.ConsultaUsuario
            NegocioAcceso.ConsultarPerfiles(EntidadAcceso)
            Tabla1 = EntidadAcceso.TablaConsulta
                If Tabla1.Rows(0).Item("Validacion") = False Then
                    LbConfirmaClave.Text = "El Usuario " & TbUsuario.Text & " no existe, verifique de nuevo."
                    LbConfirmaClave.ForeColor = Color.Red
                    TbUsuario.ForeColor = Color.Red
                    TbClaveActual.ForeColor = Color.Black
                    TbClaveConfirma.ForeColor = Color.Black
                    TbClaveNueva.ForeColor = Color.Black
                    Exit Sub
                ElseIf Tabla1.Rows(0).Item("Clave").Equals(Encriptar.Encriptar(TbClaveActual.Text)) = False Then
                    LbConfirmaClave.Text = "La contraseña ingresada no es correcta, verifique de nuevo."
                    LbConfirmaClave.ForeColor = Color.Red
                    TbClaveActual.ForeColor = Color.Red
                    TbUsuario.ForeColor = Color.Black
                    TbClaveConfirma.ForeColor = Color.Black
                    TbClaveNueva.ForeColor = Color.Black
                    Exit Sub
                ElseIf TbClaveNueva.Text.Equals(TbClaveConfirma.Text) = False Then
                    LbConfirmaClave.Text = "Las contraseñas no coinciden, verifique de nuevo."
                    LbConfirmaClave.ForeColor = Color.Red
                    TbClaveNueva.ForeColor = Color.Red
                    TbClaveConfirma.ForeColor = Color.Red
                    TbClaveActual.ForeColor = Color.Black
                    TbUsuario.ForeColor = Color.Black
                    Exit Sub
                Else
                    TbClaveActual.ForeColor = Color.Black
                    TbClaveConfirma.ForeColor = Color.Black
                    TbClaveNueva.ForeColor = Color.Black
                    LbConfirmaClave.ForeColor = Color.Black
                    LbConfirmaClave.Text = ""
                ActualizarClave(Tabla1.Rows(0).Item("IdUsuario"), Tabla1.Rows(0).Item("Nombre").ToString, Tabla1.Rows(0).Item("Usuario").ToString, TbClaveConfirma.Text, Tabla1.Rows(0).Item("Tipo").ToString)
            End If
            'Next
            MessageBox.Show("Se realizo el proceso correctamente!")
            Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Nuevo()
        TbUsuario.Text = ""
        TbClaveActual.Text = ""
        TbClaveNueva.Text = ""
        TbClaveConfirma.Text = ""
        LbConfirmaClave.Text = ""
        TbClaveActual.ForeColor = Color.Black
        TbClaveConfirma.ForeColor = Color.Black
        TbClaveNueva.ForeColor = Color.Black
        LbConfirmaClave.ForeColor = Color.Black
        TbUsuario.ForeColor = Color.Black
    End Sub
    Private Sub ActualizarClave(ByVal IdUsuario As Integer, ByVal Nombre As String, ByVal Usuario As String, ByVal Password As String, ByVal Tipo As Integer)
        Dim Encriptar As New Encriptar
        Dim EntidadUsuarios As New Capa_Entidad.Usuarios
        Dim NegocioUsuarios As New Capa_Negocio.Usuarios
        Try
            _IdUsuario = IdUsuario
            _Usuario = Usuario
            _IdTipoUsuario = Tipo
            EntidadUsuarios.IdUsuario = IdUsuario
            EntidadUsuarios.Nombre = Nombre
            EntidadUsuarios.Usuario = Usuario
            EntidadUsuarios.Password = Encriptar.Encriptar(Password)
            EntidadUsuarios.Tipo = Tipo
            'EntidadUsuarios.BaseDeDatos = BaseDeDatos
            EntidadUsuarios.Actualiza = Actualiza.ActualizaUsuario
            NegocioUsuarios.Guardar(EntidadUsuarios)
            GeneraRegistroBitacora(Me.Text.Clone.ToString, "Actualizar", IdUsuario, Usuario)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        If TbUsuario.Text <> "" And TbClaveActual.Text <> "" And TbClaveNueva.Text <> "" And TbClaveConfirma.Text <> "" Then
            ConsultaBDD()
        Else
            MsgBox("No se puede continuar con campos vacios, revise de nuevo!")
        End If
    End Sub
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Close()
    End Sub
End Class