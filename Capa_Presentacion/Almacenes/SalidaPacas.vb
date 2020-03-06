Imports Capa_Operacion.Configuracion
Public Class SalidaPacas
    Implements IForm1
    Private Sub SalidaPacas_Load(sender As Object, e As EventArgs) Handles Me.Load
        CargaCombos()
        CargaPaquetesDisponibles()
        CargaPacasDisponibles()
    End Sub
    Private Sub Nuevo()
        TbIdSalida.Text = ""
        TbNoPacas.Text = ""
        CargaCombos()
        TbIdComprador.Text = ""
        TbNombreComprador.Text = ""
        DtpFecha.Value = Now
    End Sub
    Private Sub CargaCombos()

    End Sub
    Private Sub CargaPaquetesDisponibles()
        Try
            Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
            Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
            Dim Tabla As New DataTable
            EntidadSalidaPacas.Consulta = Consulta.ConsultaBasica
            NegocioSalidaPacas.Consultar(EntidadSalidaPacas)
            DgvPaquetesDisponibles.DataSource = EntidadSalidaPacas.TablaConsulta
            PropiedadesDgvPaquetesDisponibles()
            'FormatoDatagrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CargaPacasDisponibles()
        Try
            Dim EntidadSalidaPacas As New Capa_Entidad.SalidaPacas
            Dim NegocioSalidaPacas As New Capa_Negocio.SalidaPacas
            Dim Tabla As New DataTable
            EntidadSalidaPacas.Consulta = Consulta.ConsultaAlmacen
            NegocioSalidaPacas.Consultar(EntidadSalidaPacas)
            DgvPacasDisponibles.DataSource = EntidadSalidaPacas.TablaConsulta
            PropiedadesDgvPacasDisponibles()
            'FormatoDatagrid()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PropiedadesDgvPaquetesDisponibles()
        DgvPaquetesDisponibles.Columns("IdPaqueteEncabezado").HeaderText = "ID Paquete"
        DgvPaquetesDisponibles.Columns("IdPaqueteEncabezado").ReadOnly = True
        DgvPaquetesDisponibles.Columns("Cantidad").ReadOnly = True
        DgvPaquetesDisponibles.Columns("Kilos").ReadOnly = True
    End Sub
    Private Sub PropiedadesDgvPacasDisponibles()
        DgvPacasDisponibles.Columns("IdPaqueteEncabezado").HeaderText = "ID Paquete"
        DgvPacasDisponibles.Columns("BaleID").HeaderText = "Etiqueta"
        DgvPacasDisponibles.Columns("Descripcion").HeaderText = "Planta"

        DgvPacasDisponibles.Columns("IdPaqueteEncabezado").ReadOnly = True
        DgvPacasDisponibles.Columns("BaleID").ReadOnly = True
        DgvPacasDisponibles.Columns("Descripcion").ReadOnly = True
        DgvPacasDisponibles.Columns("Kilos").ReadOnly = True
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        CargaPaquetesDisponibles()
        CargaPacasDisponibles()
    End Sub
    Private Sub DgvPaquetesDisponibles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPaquetesDisponibles.CellContentClick
        DgvPacasDisponibles.EndEdit()
        DgvPaquetesDisponibles.EndEdit()
        Dim filaSeleccionada As Integer = DgvPaquetesDisponibles.CurrentRow.Index
        Dim chkSel As Boolean = CType(Me.DgvPaquetesDisponibles.Rows(filaSeleccionada).Cells("Seleccionar").EditedFormattedValue, Boolean)
        Dim IdPaquete As Integer
        IdPaquete = DgvPaquetesDisponibles.Rows(filaSeleccionada).Cells("IdPaqueteEncabezado").Value
        For Each row As DataGridViewRow In DgvPacasDisponibles.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = True Then
                row.Cells("Seleccionar").Value = True
            ElseIf row.Cells("IdPaqueteEncabezado").Value = IdPaquete And chkSel = False Then
                row.Cells("Seleccionar").Value = False
            End If
        Next
        MarcaSeleccionDisponibles()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dispose()
        Close()
    End Sub
    Private Sub MarcaSeleccionDisponibles()
        Dim Contador As Integer = 0
        Dim Kilos As Integer = 0
        For i As Integer = 0 To DgvPacasDisponibles.Rows.Count - 1
            Dim Seleccion As Boolean = CType(Me.DgvPacasDisponibles.Rows(i).Cells("Seleccionar").EditedFormattedValue, Boolean)
            If Seleccion = True Then
                Contador = Contador + 1
                Kilos = Kilos + DgvPacasDisponibles.Rows(i).Cells("Kilos").Value
            End If
        Next
        TbPacasMarc.Text = Contador
    End Sub
    Private Sub DgvPacasDisponibles_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvPacasDisponibles.CellContentClick
        MarcaSeleccionDisponibles()
    End Sub

    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar.Click

    End Sub

    Private Sub BtSeleccionar2_Click(sender As Object, e As EventArgs) Handles BtSeleccionar2.Click

    End Sub

    Private Sub BtnBuscarProd_Click(sender As Object, e As EventArgs) Handles BtnBuscarProd.Click
        Dim _ConsultaCompradores As New ConsultaCompradores
        Nuevo()
        _ConsultaCompradores.MdiParent = Me.MdiParent
        _ConsultaCompradores.Opener = CType(Me, IForm1)
        _ConsultaCompradores.ShowDialog()
        'ConsultaDatosCompra()
    End Sub
    Public Function LoadIdComprador(ByVal DatatableParam As DataTable) As Boolean Implements IForm1.LoadIdComprador
        For Each row As DataRow In DatatableParam.Rows
            TbIdComprador.Text = row("IdComprador")
            TbNombreComprador.Text = row("Nombre")
        Next
        Return True
    End Function

    Public Function LoadIdVenta(_DataTable As DataTable) As Boolean Implements IForm1.LoadIdVenta
        Throw New NotImplementedException()
    End Function
End Class