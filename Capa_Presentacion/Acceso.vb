Imports System.Drawing.Drawing2D
Imports Capa_Operacion.Configuracion
Public Class Acceso
    Private Sub Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbUsuario.Select()
        llenaCombos()
    End Sub
    Private Sub llenaCombos()
        Dim tabla As New DataTable
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        EntidadConfiguracionParametros.Consulta = Consulta.ConsultaBaseDatos
        NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
        tabla = EntidadConfiguracionParametros.TablaConsulta
        CbBaseDeDatos.DataSource = tabla
        CbBaseDeDatos.ValueMember = "database_id"
        CbBaseDeDatos.DisplayMember = "name"
        CbBaseDeDatos.SelectedIndex = 0
    End Sub
    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAccesar.Click
        Login()
    End Sub
    Private Sub TbClave_keydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            Login()
        End If
    End Sub
    Private Sub Login()
        Try
            If UsuarioRegistrado(TbUsuario.Text) = True Then
                GeneraRegistroBitacora(Me.Text.Clone.ToString, BtAccesar.Text)
                Me.Hide()
                MenuPrincipal.ShowDialog()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        End
    End Sub
    Private Function UsuarioRegistrado(ByVal Usuario As String) As String
        Dim EntidadAcceso As New Capa_Entidad.Acceso
        Dim NegocioAcceso As New Capa_Negocio.Acceso
        Dim Tabla As New DataTable
        Dim Resultado As Boolean = False
        EntidadAcceso.Usuario = Usuario
        EntidadAcceso.BaseDeDatos = CbBaseDeDatos.Text
        EntidadAcceso.Consulta = Consulta.ConsultaUsuario
        NegocioAcceso.Consultar(EntidadAcceso)
        Tabla = EntidadAcceso.TablaConsulta
        If Tabla.Rows(0).Item("Validacion") = False Then
            MessageBox.Show("El Usuario " & TbUsuario.Text & " no existe, verifique de nuevo.", "Aviso")
            Resultado = False
        ElseIf Tabla.Rows(0).Item("Clave").Equals(TbClave.Text) = False Then
            MessageBox.Show("La contraseña ingresada no es correcta, verifique de nuevo.", "Aviso")
            TbClave.Text = ""
            Resultado = False
        Else
            Resultado = True
        End If

        _BaseDeDatos = CbBaseDeDatos.Text
        _IdUsuario = Tabla.Rows(0).Item("IdUsuario")
        _Usuario = Tabla.Rows(0).Item("Usuario")
        _IdTipoUsuario = Tabla.Rows(0).Item("Tipo")
        _TipoUsuario = Tabla.Rows(0).Item("Descripcion")

        Return Resultado
    End Function

    Private Sub LkCambiarClave_Click(sender As Object, e As EventArgs) Handles LkCambiarClave.Click
        CambiarClave.ShowDialog()
    End Sub
End Class