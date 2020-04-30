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
        Id = 0
        DgvSalidas.DataSource = ""
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
            PropiedadesDgv()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub PropiedadesDgv()
        DgvSalidas.Columns("IdSalidaEncabezado").HeaderText = "ID Salida"
        DgvSalidas.Columns("IdEmbarqueEncabezado").HeaderText = "ID Embarque"
        DgvSalidas.Columns("IdComprador").Visible = False
        DgvSalidas.Columns("Nombre").HeaderText = "Comprador"
        DgvSalidas.Columns("NombreChofer").HeaderText = "Chofer"
        DgvSalidas.Columns("PlacaTractoCamion").HeaderText = "Placas Camion"
        DgvSalidas.Columns("NoLicencia").Visible = False
        DgvSalidas.Columns("Telefono").Visible = False
        DgvSalidas.Columns("Destino").Visible = False
        DgvSalidas.Columns("NoFactura").Visible = False
        DgvSalidas.Columns("FechaSalida").Visible = False
        DgvSalidas.Columns("FechaEntrada").HeaderText = "Fecha Entrada"
        DgvSalidas.Columns("Observaciones").Visible = False
        DgvSalidas.Columns("NoContenedorCaja1").Visible = False
        DgvSalidas.Columns("NoContenedorCaja2").Visible = False
        DgvSalidas.Columns("PlacaCaja1").Visible = False
        DgvSalidas.Columns("PlacaCaja2").Visible = False
        DgvSalidas.Columns("NoLote1").Visible = False
        DgvSalidas.Columns("NoLote2").Visible = False
        DgvSalidas.Columns("PesoBruto").Visible = False
        DgvSalidas.Columns("PesoTara").Visible = False
        DgvSalidas.Columns("PesoNeto").Visible = False
        DgvSalidas.Columns("EstatusSalida").Visible = False
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