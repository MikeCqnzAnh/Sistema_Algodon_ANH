Imports System.Data.SqlClient
Imports System.Drawing.Drawing2D
Imports Capa_Operacion.Configuracion
Public Class Acceso
    Private Sub Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TbUsuario.Select()
        LlenaCombos()
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
    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        Try
            If UsuarioRegistrado(TbUsuario.Text) = True Then
                Me.Hide()
                MenuPrincipal.ShowDialog()
            End If

        Catch ex As Exception

        End Try

    End Sub
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        End
    End Sub
    Private Function UsuarioRegistrado(ByVal Usuario As String) As String
        Dim EntidadAcceso As New Capa_Entidad.Acceso
        Dim NegocioAcceso As New Capa_Negocio.Acceso
        Dim Tabla As New DataTable
        EntidadAcceso.Usuario = Usuario
        EntidadAcceso.Consulta = Consulta.ConsultaUsuario
        NegocioAcceso.Consultar(EntidadAcceso)
        Tabla = EntidadAcceso.TablaGeneral
        If Tabla.Rows.Count = 0 Then
            Exit Function
        End If
        Tabla.Rows(0).Item("Usuario")
        Tabla.Rows(0).Item("Password")
        Tabla.Rows(0).Item("Validacion")
        Return Usuario
    End Function
End Class