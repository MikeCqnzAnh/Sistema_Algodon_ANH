Imports Capa_Operacion.Configuracion
Public Class VerificaAutorizacion
    Private _VerificaAutorizacion As Boolean = False

    Public Property VerificaAutorizacion() As Boolean
        Get
            Return _VerificaAutorizacion
        End Get
        Set(value As Boolean)
            _VerificaAutorizacion = value
        End Set
    End Property
    Private Sub TbClave_KeyDown(sender As Object, e As KeyEventArgs) Handles TbClave.KeyDown
        If e.KeyCode = Keys.Enter Then
            ConsultaClaveAutorizacion()
            Me.Close()
        End If
    End Sub
    Private Sub ConsultaClaveAutorizacion()
        Dim EntidadAcceso As New Capa_Entidad.Acceso
        Dim NegocioAcceso As New Capa_Negocio.Acceso
        Dim Tabla As New DataTable
        Dim Valor As Integer = Val(TbClave.Text)
        EntidadAcceso.Usuario = Usuario
        'EntidadAcceso.BaseDeDatosPerfiles = "Perfiles"
        EntidadAcceso.Consulta = Consulta.ConsultaClaveAutorizacion
        NegocioAcceso.ConsultarPerfiles(EntidadAcceso)
        Tabla = EntidadAcceso.TablaConsulta
        If Tabla.Rows(0).Item("ClaveAutorizacion").Equals(Valor) = True Then
            _VerificaAutorizacion = True
        Else
            _VerificaAutorizacion = False
        End If
    End Sub
    Private Sub VerificaAutorizacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        TbClave.Text = ""
    End Sub
    Private Sub TbClave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbClave.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub BtAccesar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        ConsultaClaveAutorizacion()
        Me.Close()
    End Sub

    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        _VerificaAutorizacion = False
        Me.Close()
    End Sub
End Class