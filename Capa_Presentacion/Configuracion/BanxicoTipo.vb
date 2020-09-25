Imports System.IO
Imports Capa_Operacion.Configuracion
Public Class ParametrosBanxico
    Private Sub ParametrosBanxico_Load(sender As Object, e As EventArgs) Handles Me.Load
        Nuevo()
        ConsultaParametrosBanxico()
        ValidaCampos()
    End Sub
    Private Sub Nuevo()
        TbSerie.Text = ""
        TbSitio.Text = ""
        TbToken.Text = ""
        LbMensajeValidacion.Text = ""
    End Sub
    Private Sub ValidaCampos()
        If TbSerie.Text <> "" OrElse TbSitio.Text <> "" OrElse TbToken.Text = "" Then
            TbSerie.ReadOnly = True
            TbSitio.ReadOnly = True
            TbToken.ReadOnly = True
        Else
            TbSerie.ReadOnly = False
            TbSitio.ReadOnly = False
            TbToken.ReadOnly = False
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start(LinkLabel1.Text)
    End Sub
    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start(LinkLabel2.Text)
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        GuardarConfiguracionParametrosBanxico()
        ValidaCampos()
    End Sub
    Private Sub GuardarConfiguracionParametrosBanxico()
        Try
            Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
            Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
            EntidadConfiguracionParametros.IdConfiguracion = IIf(TbIdConfiguracionBanxico.Text = "", 0, TbIdConfiguracionBanxico.Text)
            EntidadConfiguracionParametros.SitioBanxico = TbSitio.Text
            EntidadConfiguracionParametros.IdSerieBanxico = TbSerie.Text
            EntidadConfiguracionParametros.TokenBanxico = TbToken.Text
            NegocioConfiguracionParametros.GuardarBanxico(EntidadConfiguracionParametros)
            'TsIdConfiguracion.Text = EntidadConfiguracionParametros.IdConfiguracion
            MsgBox("Realizado Correctamente")
            ConsultaParametrosBanxico()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub ConsultaParametrosBanxico()
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        Dim Tabla As New DataTable
        EntidadConfiguracionParametros.Consulta = Consulta.ConsultaExterna
        NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
        Tabla = EntidadConfiguracionParametros.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        TbIdConfiguracionBanxico.Text = Tabla.Rows(0).Item("IdConfiguracionBanxico")
        TbSitio.Text = Tabla.Rows(0).Item("Sitio")
        TbSerie.Text = Tabla.Rows(0).Item("Serie")
        TbToken.Text = Tabla.Rows(0).Item("Token")
    End Sub
    Private Function ObtenerValor(ByVal cadena As String)
        Dim Resultado As String
        Dim ArregloCadena() As String = Split(cadena, "=")
        Resultado = ArregloCadena(1)
        Return Resultado
    End Function

    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        TbSerie.ReadOnly = False
        TbSitio.ReadOnly = False
        TbToken.ReadOnly = False
    End Sub
    Private Sub TbValidar_Click(sender As Object, e As EventArgs) Handles TbValidar.Click
        Dim Resultado As String = String.Empty
        If TbSitio.Text <> "" And TbSerie.Text <> "" And TbToken.Text <> "" Then
            Resultado = TipoDeCambioFIX(TbSerie.Text, Now, Now, TbToken.Text, TbSitio.Text)
            If Resultado <> "" Then MsgBox("Tipo de Cambio: " & Resultado & vbCrLf & "A la fecha actual: " & Now.Date, MsgBoxStyle.Information)
        Else
            MsgBox("No se permiten campos en blanco, todos son requeridos!", MsgBoxStyle.Critical, "Error!")
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class