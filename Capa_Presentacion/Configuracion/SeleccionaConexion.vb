Imports System.Net
Imports System.Net.NetworkInformation
Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
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

    Private Sub GuardarActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarActualizarToolStripMenuItem.Click
        SeleccionaConexion()
        _BaseDeDatos = CbBaseDatos.Text
    End Sub
    Private Sub SeleccionaConexion()
        Try
            Dim EntidadSeleccionaConexion As New Capa_Entidad.SeleccionaConexion
            Dim NegocioSeleccionaConexion As New Capa_Negocio.SeleccionaConexion
            EntidadSeleccionaConexion.BaseDeDatos = CbBaseDatos.Text
            EntidadSeleccionaConexion.Conexion = Conexion.ConexionDataBase
            NegocioSeleccionaConexion.Conexion(EntidadSeleccionaConexion)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MsgBox("Base de datos actualizada con exito.", MsgBoxStyle.Information, "Aviso")
        End Try
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class