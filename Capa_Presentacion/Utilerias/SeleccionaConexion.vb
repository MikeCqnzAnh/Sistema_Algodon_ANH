Imports System.Net
Imports System.Net.NetworkInformation
Imports Capa_Operacion.Configuracion
Imports System.IO.Ports
Public Class SeleccionaConexion
    Private Sub SeleccionaConexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenaCombos()
        ConsultaInstancia()
    End Sub
    Private Sub llenaCombos()
        Dim tabla As New DataTable
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        EntidadConfiguracionParametros.Consulta = Consulta.ConsultaBaseDatos
        NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
        tabla = EntidadConfiguracionParametros.TablaConsulta
        CbBaseDatos.DataSource = tabla
        CbBaseDatos.ValueMember = "database_id"
        CbBaseDatos.DisplayMember = "name"
        CbBaseDatos.SelectedIndex = -1
    End Sub
    Private Sub ConsultaInstancia()
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        Dim Tabla As New DataTable
        EntidadConfiguracionParametros.Consulta = Consulta.ConsultaInstancia
        NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
        Tabla = EntidadConfiguracionParametros.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        TbNombreInstancia.Text = Tabla.Rows(0).Item("NombreInstancia")
    End Sub
End Class