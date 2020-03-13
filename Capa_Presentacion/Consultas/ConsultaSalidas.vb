﻿Imports Capa_Operacion.Configuracion
Public Class ConsultaSalidas
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Private Sub ConsultaSalidas_Load(sender As Object, e As EventArgs) Handles Me.Load
        _Id = 0
    End Sub
    Private Sub Limpiar()
        TbIdSalida.Text = ""
        TbNombreComprador.Text = ""
        DgvSalidas.DataSource = ""
        TbIdSalida.Select()
    End Sub
    Private Sub ConsultaSalida()
        Try
            Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
            Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
            Dim Tabla As New DataTable
            EntidadSalidaPacas.Consulta = Consulta.ConsultaSalidaPacas
            EntidadSalidaPacas.IdSalidaEncabezado = Val(TbIdSalida.Text)
            EntidadSalidaPacas.NombreComprador = TbNombreComprador.Text
            NegocioSalidaPacas.Consultar(EntidadSalidaPacas)
            DgvSalidas.DataSource = EntidadSalidaPacas.TablaConsulta
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BtConsultar_Click(sender As Object, e As EventArgs) Handles BtConsultar.Click
        ConsultaSalida()
    End Sub
    Private Sub EventoKeypress(sender As Object, e As KeyEventArgs) Handles TbIdSalida.KeyDown, TbNombreComprador.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                ConsultaSalida()
        End Select
    End Sub
    Private Sub DgvConsultaEmbarque_DoubleClick(sender As Object, e As EventArgs) Handles DgvSalidas.DoubleClick
        If DgvSalidas.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvSalidas.CurrentCell.RowIndex
            _Id = DgvSalidas.Rows(index).Cells("IdSalidaEncabezado").Value
            Close()
        End If
    End Sub
End Class