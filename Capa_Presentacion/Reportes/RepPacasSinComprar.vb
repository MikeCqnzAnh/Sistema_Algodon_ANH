Imports Capa_Operacion.Configuracion
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Management
Imports Microsoft.Office.Interop
Public Class RepPacasSinComprar
    Private Sub RepPacasSinComprar_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaCombos()
        Limpiar()
    End Sub
    Private Sub Limpiar()
        DgvPacasSinComprar.DataSource = ""
        CbClase.SelectedIndex = -1
        CbPlanta.SelectedIndex = -1
        TbCantidadPacas.Text = ""
        TbRangoInicio.Text = ""
        TbRangoFin.Text = ""
    End Sub
    Private Sub CargaCombos()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbPlanta.DataSource = Tabla
        CbPlanta.ValueMember = "IdPlanta"
        CbPlanta.DisplayMember = "Descripcion"
        CbPlanta.SelectedValue = 0
        '-----------------------------------------------
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla2 As New DataTable
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaClases
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla2 = EntidadClasificacionVentaPaquetes.TablaConsulta
        CbClase.DataSource = Tabla2
        CbClase.ValueMember = "IdClasificacion"
        CbClase.DisplayMember = "ClaveCorta"
        CbClase.SelectedValue = 0
    End Sub
End Class