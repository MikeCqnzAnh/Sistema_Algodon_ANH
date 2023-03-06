Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class IncidenciasProduccion
    Private _IdTurno As Integer
    Private _IdPlanta As Integer
    Private _encargadoprensa As String
    Private _encargadoturno As String
    Public Sub New(ByVal idturno As Integer, ByVal idplanta As Integer)
        InitializeComponent()
        _IdTurno = idturno
        _IdPlanta = idplanta
        '_encargadoprensa = encargadoprensa
        '_encargadoturno = encargadoturno
    End Sub
    Private Sub IncidenciasProduccion_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargarCombos()
        cargacombousuario(cbencargadoprensa)
        cargacombousuario(cbencargadoturno)
        cargacomboturnos()
        CbPlantaOrigen.SelectedValue = _IdPlanta
        'tbencargadoprensa.Text = _encargadoprensa
        'tbencargadoturno.Text = _encargadoturno
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
    Private Sub cargacomboturnos()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaTurnos
        EntidadProduccion.IdPlantaOrigen = _IdPlanta
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        For Each dtrow As DataRow In Tabla.Rows
            If Now.TimeOfDay >= dtrow("Horaentrada") And Now.TimeOfDay <= dtrow("Horasalida") Then
                CbTurno.DataSource = Tabla
                CbTurno.ValueMember = "IdTurnoenc"
                CbTurno.DisplayMember = "Descripcion"
                CbTurno.SelectedValue = dtrow("idturnoenc")
                cbencargadoturno.SelectedValue = dtrow("idresponsableturno")
                cbencargadoprensa.SelectedValue = dtrow("idresponsableprensa")
            End If
        Next
    End Sub
    Private Sub cargacombousuario(ByVal cmb As ComboBox)
        Dim EntidadUsuarios As New Capa_Entidad.Usuarios
        Dim NegocioUsuarios As New Capa_Negocio.Usuarios
        Dim Tabla As New DataTable
        Try
            EntidadUsuarios.Consulta = Consulta.ConsultaUsuario
            NegocioUsuarios.Consultar(EntidadUsuarios)
            Tabla = EntidadUsuarios.TablaConsulta
            cmb.DataSource = Tabla
            cmb.ValueMember = "idusuario"
            cmb.DisplayMember = "nombre"
            cmb.SelectedValue = 0
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class