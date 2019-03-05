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
        Me.Hide()
        MenuPrincipal.ShowDialog()
    End Sub
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        End
    End Sub
End Class