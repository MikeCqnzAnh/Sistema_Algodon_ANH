Imports Capa_Operacion.Configuracion
Public Class ConsultaTierrasChecks
    Public TablaLotesSeleccionados As New DataTable()
    Public TablaLotesDelGrid As New DataTable()
    Private Sub BtBuscar_Click(sender As Object, e As EventArgs) Handles BtBuscar.Click
        ConsultaTierras()
    End Sub

    Private Sub ConsultaTierrasChecks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TablaLotesSeleccionados.Columns.Clear()
        TablaLotesSeleccionados.Columns.Add(New DataColumn("IdTierra", Type.GetType("System.Int32")))
        TablaLotesSeleccionados.Columns.Add(New DataColumn("Lote", Type.GetType("System.String")))
        TablaLotesSeleccionados.Columns.Add(New DataColumn("SuperficieContratada", Type.GetType("System.Double")))
        Limpiar()
    End Sub

    Private Sub ConsultaTierras()
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        Dim chk As New DataGridViewCheckBoxColumn()
        Dim Tabla As New DataTable
        EntidadContratosAlgodon.Consulta = Consulta.ConsultaTierras
        NegocioContratosAlgodon.Consultar(EntidadContratosAlgodon)
        DgvConsultaTierrasChecks.DataSource = EntidadContratosAlgodon.TablaConsulta
        TablaLotesDelGrid = EntidadContratosAlgodon.TablaConsulta
        If DgvConsultaTierrasChecks.Columns("chk") Is Nothing Then
            DgvConsultaTierrasChecks.Columns.Add(chk)
            chk.HeaderText = "Agregar"
            chk.Name = "chk"
        End If

    End Sub

    Private Sub BtAceptar_Click(sender As Object, e As EventArgs) Handles BtAceptar.Click
        Dim EntidadContratosAlgodon As New Capa_Entidad.ContratosAlgodon
        Dim NegocioContratosAlgodon As New Capa_Negocio.ContratosAlgodon
        TablaLotesSeleccionados.Clear()
        If DgvConsultaTierrasChecks.DataSource IsNot Nothing Or DgvConsultaTierrasChecks.RowCount > 0 Then
            For Contador = 0 To DgvConsultaTierrasChecks.RowCount - 1
                If DgvConsultaTierrasChecks.Rows(Contador).Cells("chk").Value = True Then
                    Dim renglonainsertar As DataRow
                    renglonainsertar = TablaLotesSeleccionados.NewRow()
                    renglonainsertar("IdTierra") = TablaLotesDelGrid.Rows(Contador).Item("IdTierra")
                    renglonainsertar("Lote") = TablaLotesDelGrid.Rows(Contador).Item("Lote")
                    renglonainsertar("SuperficieContratada") = TablaLotesDelGrid.Rows(Contador).Item("SuperficieContratada")
                    TablaLotesSeleccionados.Rows.Add(renglonainsertar)
                End If
            Next Contador
        End If
        _Tabla = TablaLotesSeleccionados
        Close()
    End Sub

    Private Sub Limpiar()
        DgvConsultaTierrasChecks.DataSource = Nothing
        DgvConsultaTierrasChecks.Columns.Clear()
    End Sub

    Private Sub DgvConsultaTierrasChecks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvConsultaTierrasChecks.CellContentClick
        Dim Contador As Integer
        For Contador = 0 To DgvConsultaTierrasChecks.RowCount - 1
            If DgvConsultaTierrasChecks.Rows(Contador).Selected Then
                If DgvConsultaTierrasChecks.Rows(Contador).Cells("chk").Value = False Then
                    DgvConsultaTierrasChecks.Rows(Contador).Cells("chk").Value = True
                ElseIf DgvConsultaTierrasChecks.Rows(Contador).Cells("chk").Value = True Then
                    DgvConsultaTierrasChecks.Rows(Contador).Cells("chk").Value = False
                End If
            End If
        Next Contador
    End Sub
End Class