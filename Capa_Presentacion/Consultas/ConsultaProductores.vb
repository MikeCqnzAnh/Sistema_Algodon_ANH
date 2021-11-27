﻿Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConsultaProductores
    Private Sub ConsultaProductores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
    End Sub
    Private Sub BtSalir_Click(sender As Object, e As EventArgs) Handles BtSalir.Click
        Close()
    End Sub
    Private Sub ConsultaProductores()
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        Dim Tabla As New DataTable
        EntidadContratosAlgodon.DescripcionConsulta = TbNombre.Text
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaProductores
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        DgvConsultaProductores.DataSource = EntidadContratosAlgodon.TablaConsulta
    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        ConsultaProductores()
    End Sub

    Private Sub Limpiar()
        TbNombre.Text = ""
        DgvConsultaProductores.DataSource = Nothing
    End Sub

    Private Sub DgvConsultaProductores_DoubleClick(sender As Object, e As EventArgs) Handles DgvConsultaProductores.DoubleClick
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        Dim index As Integer
        index = DgvConsultaProductores.CurrentRow.Index
        _Id = DgvConsultaProductores.Rows(index).Cells("IdCliente").Value.ToString()
        _Nombre = DgvConsultaProductores.Rows(index).Cells("Nombre").Value.ToString()
        Close()
    End Sub

    Private Sub TbNombre_KeyDown(sender As Object, e As KeyEventArgs) Handles TbNombre.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                ConsultaProductores()
        End Select
    End Sub
End Class