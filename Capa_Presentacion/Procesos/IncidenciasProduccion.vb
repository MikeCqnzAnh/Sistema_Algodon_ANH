Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class IncidenciasProduccion
    Private _IdTurno As Integer
    Private _IdPlanta As Integer
    Public Sub New(ByVal idturno As Integer, ByVal idplanta As Integer)
        InitializeComponent()
        _IdTurno = idturno
        _IdPlanta = idplanta
    End Sub
    Private Sub IncidenciasProduccion_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarCombos()
        CbPlantaOrigen.SelectedValue = _IdPlanta
    End Sub
    Private Sub CargarCombos()
        '---Planta Origen--
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbPlantaOrigen.DataSource = Tabla
        CbPlantaOrigen.ValueMember = "IdPlanta"
        CbPlantaOrigen.DisplayMember = "Descripcion"
        CbPlantaOrigen.SelectedValue = 0
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImprimirToolStripMenuItem.Click
        Dim _reporte As New RepDiarioOperacionPlanta
        _reporte.ShowDialog()
    End Sub
End Class