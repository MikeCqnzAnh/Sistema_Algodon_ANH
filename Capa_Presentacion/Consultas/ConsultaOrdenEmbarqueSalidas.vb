﻿Imports Capa_Operacion.Configuracion
Public Class ConsultaOrdenEmbarqueSalidas
    Public Property Id() As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property
    Public Property NoContenedor() As String
        Get
            Return _NoContenedor
        End Get
        Set(value As String)
            _NoContenedor = value
        End Set
    End Property
    Public Property NombreComprador() As String
        Get
            Return _NombreComprador
        End Get
        Set(value As String)
            _NombreComprador = value
        End Set
    End Property
    Private Sub ConsultaOrdenEmbarque_Load(sender As Object, e As EventArgs) Handles Me.Load
        Id = 0
        NoContenedor = ""
        Limpiar()
    End Sub
    Private Sub Limpiar()
        TbIdEmbarque.Text = ""
        TbNombreComprador.Text = ""
        TbNoContenedor.Text = ""
        DgvConsultaEmbarque.DataSource = ""
        TbIdEmbarque.Select()
    End Sub
    Private Sub ConsultaEmbarqueEncabezado()
        Try
            Dim EntidadOrdenEmbarquePacas As New Capa_Entidad.OrdenEmbarquePacas
            Dim NegocioOrdenEmbarquePacas As New Capa_Negocio.OrdenEmbarquePacas
            Dim Tabla As New DataTable
            EntidadOrdenEmbarquePacas.Consulta = Consulta.ConsultaEmbarqueParaSalidaSinSelecionar
            EntidadOrdenEmbarquePacas.IdEmbarqueEncabezado = Val(TbIdEmbarque.Text)
            EntidadOrdenEmbarquePacas.NombreComprador = TbNombreComprador.Text
            EntidadOrdenEmbarquePacas.NoContenedorInd = TbNoContenedor.Text
            NegocioOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
            DgvConsultaEmbarque.DataSource = EntidadOrdenEmbarquePacas.TablaConsulta
            PropiedadesDgvEmbarqueEncabezado()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PropiedadesDgvEmbarqueEncabezado()
        'DgvConsultaEmbarque.Columns("IdEmbarqueEncabezado").HeaderText = "ID Embarque"
        'DgvConsultaEmbarque.Columns("NombreChofer").HeaderText = "Chofer"
        'DgvConsultaEmbarque.Columns("Nombre").HeaderText = "Comprador"
        'DgvConsultaEmbarque.Columns("PlacaTractoCamion").HeaderText = "Placa Tracto-Camion"
        'DgvConsultaEmbarque.Columns("NoLicencia").HeaderText = "No. Licencia"
        'DgvConsultaEmbarque.Columns("NoLote1").HeaderText = "No. Lote 1"
        'DgvConsultaEmbarque.Columns("NoLote2").HeaderText = "No. Lote 2"
        'DgvConsultaEmbarque.Columns("NoContenedorCaja1").HeaderText = "Contenedor 1"
        'DgvConsultaEmbarque.Columns("NoContenedorCaja2").HeaderText = "Contenedor 2"
        'DgvConsultaEmbarque.Columns("PlacaCaja1").HeaderText = "Placa de Caja 1"
        'DgvConsultaEmbarque.Columns("PlacaCaja2").HeaderText = "Placa de Caja 2"
        'DgvConsultaEmbarque.Columns("CantidadCajas").HeaderText = "Numero de Cajas"

        'DgvConsultaEmbarque.Columns("IdComprador").Visible = False
        'DgvConsultaEmbarque.Columns("Telefono").Visible = False
        'DgvConsultaEmbarque.Columns("CantidadPacas").Visible = False
        'DgvConsultaEmbarque.Columns("Observaciones").Visible = False
    End Sub
    Private Sub BtConsulta_Click(sender As Object, e As EventArgs) Handles BtConsulta.Click
        ConsultaEmbarqueEncabezado()
    End Sub
    Private Sub EventoKeypress(sender As Object, e As KeyEventArgs) Handles TbIdEmbarque.KeyDown, TbNombreComprador.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                ConsultaEmbarqueEncabezado()
        End Select
    End Sub
    Private Sub DgvConsultaEmbarque_DoubleClick(sender As Object, e As EventArgs) Handles DgvConsultaEmbarque.DoubleClick
        If DgvConsultaEmbarque.DataSource Is Nothing Then
            MsgBox("No hay registros disponibles")
        Else
            Dim index As Integer
            index = DgvConsultaEmbarque.CurrentCell.RowIndex
            _Id = DgvConsultaEmbarque.Rows(index).Cells("IdEmbarqueEncabezado").Value
            _NombreComprador = DgvConsultaEmbarque.Rows(index).Cells("Nombre").Value
            _NoContenedor = DgvConsultaEmbarque.Rows(index).Cells("NoContenedor").Value
            Close()
        End If
    End Sub
End Class