Public Class ClaveAutorizacion
    Private Sub ClaveAutorizacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbClave.Focus()
        ConsultaClaveAutorizacion(Usuario)
    End Sub
    Private Sub BtActualizarClave_Click(sender As Object, e As EventArgs) Handles BtActualizarClave.Click
        ActualizaClaveAutorizacion()
        ConsultaClaveAutorizacion(Usuario)
    End Sub
    Private Sub ConsultaClaveAutorizacion(ByVal Usuario As String)
        Dim EntidadAcceso As New Capa_Entidad.Acceso
        Dim NegocioAcceso As New Capa_Negocio.Acceso
        Dim Encriptar As New Encriptar
        Dim Tabla As New DataTable
        Dim Resultado As Boolean = False
        EntidadAcceso.Usuario = Usuario
        EntidadAcceso.BaseDeDatos = "Perfiles"
        EntidadAcceso.Consulta = Consulta.ConsultaClaveAutorizacion
        NegocioAcceso.ConsultarPerfiles(EntidadAcceso)
        Tabla = EntidadAcceso.TablaConsulta
        TbClave.Text = Tabla.Rows(0).Item("ClaveAutorizacion")
    End Sub
    Private Sub ActualizaClaveAutorizacion()
        Dim EntidadAcceso As New Capa_Entidad.Acceso
        Dim NegocioAcceso As New Capa_Negocio.Acceso
        Dim Encriptar As New Encriptar
        Dim Tabla As New DataTable
        Dim Resultado As Boolean = False
        EntidadAcceso.Usuario = Usuario
        EntidadAcceso.BaseDeDatos = "Perfiles"
        EntidadAcceso.Actualiza = Actuliza.ActualizaClaveAutorizacion
        NegocioAcceso.ActualizaPerfiles(EntidadAcceso)
    End Sub
    Private Sub UsuarioRegistrado()

        'If Tabla.Rows(0).Item("Validacion") = False Then
        '    MessageBox.Show("El Usuario " & TbUsuario.Text & " no existe, verifique de nuevo.", "Aviso")
        '    Resultado = False
        'Else
        'If Tabla.Rows(0).Item("ClaveAutorizacion").Equals(TbClave.Text) = False Then
        '        MessageBox.Show("La contraseña ingresada no es correcta, verifique de nuevo.", "Aviso")
        '        TbClave.Text = ""
        '        Resultado = False
        '    Else
        '        Resultado = True
        'End If
        'If Tabla.Rows(0).Item("Validacion") = 1 Then
        '_BaseDeDatos = CbBaseDeDatos.Text
        '_IdUsuario = Tabla.Rows(0).Item("IdUsuario")
        '    _Usuario = Tabla.Rows(0).Item("Usuario")
        '    _IdTipoUsuario = Tabla.Rows(0).Item("Tipo")
        '    _TipoUsuario = Tabla.Rows(0).Item("Descripcion")
        'End If
        'Return Resultado
    End Sub
    'Private Sub BtAccesar_Click_1(sender As Object, e As EventArgs) Handles BtAccesar.Click

    'End Sub
End Class