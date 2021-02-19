Imports System.ComponentModel
Imports System.Xml
Public Class IntegraciondeCompras
    Private Sub GuardarIntegracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarIntegracionToolStripMenuItem.Click
        GuardarEncabezado()
    End Sub
    Private Sub GuardarEncabezado()
        Dim EntidadIntegraciondeCompras As New Capa_Entidad.IntegraciondeCompras
        Dim NegocioIntegraciondeCompras As New Capa_Negocio.IntegraciondeCompras
        Try
            EntidadIntegraciondeCompras.Guarda = Guardar.GuardarEncabezado
            EntidadIntegraciondeCompras.IdIntegracion = IIf(TbIdIntegracion.Text = "", 0, TbIdIntegracion.Text)
            EntidadIntegraciondeCompras.IdContrato = TbIdContratoCompra.Text
            EntidadIntegraciondeCompras.IdCompra = TbIdCompra.Text
            EntidadIntegraciondeCompras.IdProductor = TbIDCliente.Text
            EntidadIntegraciondeCompras.ImporteFacturas = CDec(TbImporteTotalFacturas.Text)
            EntidadIntegraciondeCompras.TotalToneladas = CDec(TbTotalToneladasFacturas.Text)
            EntidadIntegraciondeCompras.TotalPacas = Val(TbTotalPacasFacturas.Text)
            EntidadIntegraciondeCompras.FechaCreacion = Now
            EntidadIntegraciondeCompras.FechaActualizacion = Now
            NegocioIntegraciondeCompras.Guardar(EntidadIntegraciondeCompras)
            TbIdIntegracion.Text = EntidadIntegraciondeCompras.IdIntegracion

            GuardarFacturas()
            MsgBox("Realizado Correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub GuardarFacturas()
        Dim EntidadIntegraciondeCompras As New Capa_Entidad.IntegraciondeCompras
        Dim NegocioIntegraciondeCompras As New Capa_Negocio.IntegraciondeCompras
        Dim IdFacturaEncabezado As Integer = 0
        If DgvFacturas.RowCount > 0 Then
            Try
                For Each row As DataGridViewRow In DgvFacturas.Rows
                    EntidadIntegraciondeCompras.Guarda = Guardar.GuardarFactura
                    EntidadIntegraciondeCompras.IdFacturaEncabezado = IdFacturaEncabezado
                    EntidadIntegraciondeCompras.IdIntegracion = Val(TbIdIntegracion.Text)
                    EntidadIntegraciondeCompras.NombreProductor = row.Cells("Emisor").Value.ToString
                    EntidadIntegraciondeCompras.RFC = row.Cells("RFC").Value.ToString
                    EntidadIntegraciondeCompras.UUID = row.Cells("UUID").Value.ToString
                    EntidadIntegraciondeCompras.Fecha = row.Cells("Fecha").Value
                    EntidadIntegraciondeCompras.TotalToneladas = row.Cells("TotalToneladas").Value
                    EntidadIntegraciondeCompras.TotalPacas = row.Cells("TotalPacas").Value
                    EntidadIntegraciondeCompras.Subtotal = row.Cells("Subtotal").Value
                    EntidadIntegraciondeCompras.Total = row.Cells("Total").Value
                    EntidadIntegraciondeCompras.Moneda = row.Cells("Moneda").Value.ToString
                    EntidadIntegraciondeCompras.TipoCambio = row.Cells("TipoCambio").Value
                    EntidadIntegraciondeCompras.sello = row.Cells("sello").Value.ToString
                    EntidadIntegraciondeCompras.ruta = row.Cells("ruta").Value.ToString
                    EntidadIntegraciondeCompras.FechaCreacion = Now
                    EntidadIntegraciondeCompras.FechaActualizacion = Now
                    NegocioIntegraciondeCompras.Guardar(EntidadIntegraciondeCompras)
                    TbIdIntegracion.Text = EntidadIntegraciondeCompras.IdFacturaEncabezado

                    GuardarDetalleFacturas(row.Cells("ruta").Value.ToString, 2)
                Next
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub
    Private Sub GuardarDetalleFacturas(ByVal Cadena As String, ByVal detalle As Integer)
        Dim EntidadIntegraciondeCompras As New Capa_Entidad.IntegraciondeCompras
        Dim NegocioIntegraciondeCompras As New Capa_Negocio.IntegraciondeCompras
        Dim Version_xml As String
        Dim Subtotal As Decimal
        Dim ClaveUnidad As String
        Dim Unidad As String
        Dim ClaveProdServ As String
        Dim valor_noIdentificacion As String
        Dim preciounitarioxml As Decimal
        Dim importeconcepto As Decimal
        Dim cantidadvendida As Decimal
        Dim subtotalclave As Decimal = 0
        Dim descripcionxml As String
        Dim VarConceptos As XmlNodeList
        Dim VarDocumentoXML As XmlDocument = New XmlDocument()
        Dim VarManager As XmlNamespaceManager = New XmlNamespaceManager(VarDocumentoXML.NameTable)
        VarDocumentoXML.Load(Cadena)  'Aqui puedes definir la ruta del archivo mediante un OpenFileDialog o  algun otro metodo para especificar la ubicacion del XML
        VarManager.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
        VarManager.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
        VarManager.AddNamespace("implocal", "http://www.sat.gob.mx/implocal")
        Version_xml = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Version", VarManager).InnerText
        If Version_xml = "3.3" Then
            If detalle = 2 Then
                VarConceptos = VarDocumentoXML.SelectNodes("/cfdi:Comprobante/cfdi:Conceptos/cfdi:Concepto", VarManager)
                propiedadesDgvData()

                For Each node In VarConceptos
                    Unidad = node.attributes("Unidad").value
                    ClaveUnidad = node.attributes("ClaveUnidad").value
                    valor_noIdentificacion = node.attributes("NoIdentificacion").value
                    ClaveProdServ = node.attributes("ClaveProdServ").value
                    valor_noIdentificacion = node.attributes("NoIdentificacion").value
                    preciounitarioxml = node.attributes("ValorUnitario").value
                    importeconcepto = node.attributes("Importe").value
                    cantidadvendida = node.attributes("Cantidad").value
                    subtotalclave = node.attributes("SubTotal").value
                    descripcionxml = node.attributes("Descripcion").value

                    DgvData.Rows.Add(ClaveProdServ, valor_noIdentificacion, cantidadvendida, ClaveUnidad, Unidad, descripcionxml, preciounitarioxml, Subtotal, importeconcepto)

                Next
            End If

        Else
            MsgBox("Archivo XML no es una factura version 3.3")
        End If
        Try


            EntidadIntegraciondeCompras.Guarda = Guardar.GuardarDetalleFactura
            EntidadIntegraciondeCompras.IdIntegracion = IIf(TbIdIntegracion.Text = "", 0, TbIdIntegracion.Text)
            EntidadIntegraciondeCompras.IdContrato = TbIdContratoCompra.Text
            EntidadIntegraciondeCompras.IdCompra = TbIdCompra.Text
            EntidadIntegraciondeCompras.IdProductor = TbIDCliente.Text
            EntidadIntegraciondeCompras.ImporteFacturas = CDec(TbImporteTotalFacturas.Text)
            EntidadIntegraciondeCompras.TotalToneladas = CDec(TbTotalToneladasFacturas.Text)
            EntidadIntegraciondeCompras.TotalPacas = TbTotalPacasFacturas.Text
            EntidadIntegraciondeCompras.FechaCreacion = Now
            EntidadIntegraciondeCompras.FechaActualizacion = Now
            NegocioIntegraciondeCompras.Guardar(EntidadIntegraciondeCompras)
            TbIdIntegracion.Text = EntidadIntegraciondeCompras.IdIntegracion
            MsgBox("Realizado Correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub BuscarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuscarToolStripMenuItem.Click
        Dim ConsultaCompra As New ConsultaCompraIntegracion
        ConsultaCompra.ShowDialog()
        If ConsultaCompra.IdCompra > 0 Then
            limpiar()
            TbIdCompra.Text = ConsultaCompra.IdCompra
            TbIDCliente.Text = ConsultaCompra.IdCliente
            TbNombre.Text = ConsultaCompra.NombreProductor
            TbRfcEmisor.Text = ConsultaCompra.Rfc
            TbPacasCompra.Text = Format(ConsultaCompra.TotalPacas, " #,##0")
            TbSubTotalDls.Text = Format(ConsultaCompra.SubTotal, "$ #,##0.000")
            TbCastigoDls.Text = Format(ConsultaCompra.CastigoDls, "$ #,##0.000")
            TbImporteDls.Text = Format(ConsultaCompra.TotalDls, "$ #,##0.000")
            TbIdContratoCompra.Text = ConsultaCompra.IdContrato
            TbPrecioCompra.Text = Format(ConsultaCompra.PrecioQuintal, "$ #,##0.00")
            DtFechaCreacion.Value = ConsultaCompra.Fecha
            TbTotalKilos.Text = Format(ConsultaCompra.TotalKilos / 1000, " #,##0.0000")
            BtSeleccionaXML.Enabled = True
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub ExtraerXML(ByVal Cadena As String, ByVal detalle As Integer)
        Dim Version_xml As String
        Dim implocaltraladados As Decimal
        Dim implocalretenidos As Decimal
        Dim retenidos As Decimal
        Dim trasladados As Decimal
        Dim Subtotal As Decimal
        Dim ClaveUnidad As String
        Dim Fecha As DateTime
        Dim TipoCambio As Decimal
        Dim Moneda As String
        Dim sello As String
        Dim totaltoneladas As Decimal
        Dim Unidad As String
        Dim ClaveProdServ As String
        Dim valor_noIdentificacion As String
        Dim preciounitarioxml As Decimal
        Dim importeconcepto As Decimal
        Dim cantidadvendida As Decimal
        Dim subtotalclave As Decimal = 0
        Dim descripcionxml As String
        Dim Emisor_Nombre As String
        Dim Emisor_Rfc As String
        Dim total As Decimal
        Dim UUID As String
        Dim VarConceptos As XmlNodeList
        On Error Resume Next
        Dim VarDocumentoXML As XmlDocument = New XmlDocument()
        Dim VarManager As XmlNamespaceManager = New XmlNamespaceManager(VarDocumentoXML.NameTable)
        VarDocumentoXML.Load(Cadena)  'Aqui puedes definir la ruta del archivo mediante un OpenFileDialog o  algun otro metodo para especificar la ubicacion del XML
        VarManager.AddNamespace("cfdi", "http://www.sat.gob.mx/cfd/3")
        VarManager.AddNamespace("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
        VarManager.AddNamespace("implocal", "http://www.sat.gob.mx/implocal")
        Version_xml = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Version", VarManager).InnerText
        If Version_xml = "3.3" Then
            If detalle = 1 Then
                propiedadesDgvFactura()
                total = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Total", VarManager).InnerText
                Fecha = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Fecha", VarManager).InnerText
                Moneda = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@Moneda", VarManager).InnerText
                TipoCambio = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@TipoCambio", VarManager).InnerText
                Emisor_Nombre = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Emisor/@Nombre", VarManager).InnerText
                Emisor_Rfc = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Emisor/@Rfc", VarManager).InnerText
                UUID = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Complemento/tfd:TimbreFiscalDigital/@UUID", VarManager).InnerText
                sello = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Complemento/tfd:TimbreFiscalDigital/@SelloCFD", VarManager).InnerText
                implocalretenidos = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Complemento/implocal:ImpuestosLocales/@TotaldeRetenciones", VarManager).InnerText
                implocaltraladados = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Complemento/implocal:ImpuestosLocales/@TotaldeTraslados", VarManager).InnerText
                retenidos = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Impuestos/@TotalImpuestosRetenidos", VarManager).InnerText
                trasladados = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/cfdi:Impuestos/@TotalImpuestosTrasladados", VarManager).InnerText
                Subtotal = VarDocumentoXML.SelectSingleNode("/cfdi:Comprobante/@SubTotal", VarManager).InnerText
                VarConceptos = VarDocumentoXML.SelectNodes("/cfdi:Comprobante/cfdi:Conceptos/cfdi:Concepto", VarManager)

                For Each node In VarConceptos
                    totaltoneladas += node.attributes("Cantidad").value
                Next
                DgvFacturas.Rows.Add(IIf(Emisor_Nombre Is Nothing, "", Emisor_Nombre), Emisor_Rfc, UUID, Fecha, totaltoneladas, 0, Subtotal, total, Moneda, TipoCambio, sello, Cadena)

            ElseIf detalle = 2 Then
                VarConceptos = VarDocumentoXML.SelectNodes("/cfdi:Comprobante/cfdi:Conceptos/cfdi:Concepto", VarManager)
                propiedadesDgvData()

                For Each node In VarConceptos
                    Unidad = node.attributes("Unidad").value
                    ClaveUnidad = node.attributes("ClaveUnidad").value
                    valor_noIdentificacion = node.attributes("NoIdentificacion").value
                    ClaveProdServ = node.attributes("ClaveProdServ").value
                    valor_noIdentificacion = node.attributes("NoIdentificacion").value
                    preciounitarioxml = node.attributes("ValorUnitario").value
                    importeconcepto = node.attributes("Importe").value
                    cantidadvendida = node.attributes("Cantidad").value
                    subtotalclave = node.attributes("SubTotal").value
                    descripcionxml = node.attributes("Descripcion").value

                    DgvData.Rows.Add(ClaveProdServ, valor_noIdentificacion, cantidadvendida, ClaveUnidad, Unidad, descripcionxml, preciounitarioxml, Subtotal, importeconcepto)

                Next
            End If

        Else
            MsgBox("Archivo XML no es una factura version 3.3")
        End If
    End Sub
    Private Sub Sumar()
        Dim totalA As Decimal = 0
        Dim totalB As Decimal = 0
        For Each fila As DataGridViewRow In DgvFacturas.Rows
            If fila.Cells("Total").Value Is Nothing Then
                Exit Sub
            Else
                totalA += Convert.ToDecimal(fila.Cells("Total").Value)
                totalB += Convert.ToDecimal(fila.Cells("TotalToneladas").Value)
            End If
        Next
        TbTotalToneladasFacturas.Text = Format(totalB, "#,##0.0000")
        TbImporteTotalFacturas.Text = Format(totalA, "$ #,##0.000")
    End Sub

    Private Sub propiedadesDgvFactura()
        'DgvData.Columns.Clear()
        If DgvFacturas.Columns("UUID") Is Nothing Then

            Dim colEmisor As New DataGridViewTextBoxColumn
            colEmisor.Name = "Emisor"
            colEmisor.HeaderText = "Emisor"
            colEmisor.ReadOnly = True
            DgvFacturas.Columns.Insert(0, colEmisor)

            Dim colRfcEmisor As New DataGridViewTextBoxColumn
            colRfcEmisor.Name = "RFC"
            'colIdHviDetalle.HeaderText = "No Paca"
            colRfcEmisor.Visible = False
            DgvFacturas.Columns.Insert(1, colRfcEmisor)

            Dim colUUID As New DataGridViewTextBoxColumn
            colUUID.Name = "UUID"
            colUUID.HeaderText = "UUID"
            'colCantidad.DefaultCellStyle.Format = "C2"
            colUUID.Visible = False
            DgvFacturas.Columns.Insert(2, colUUID)

            Dim colFecha As New DataGridViewTextBoxColumn
            colFecha.Name = "Fecha"
            'colIdHviDetalle.HeaderText = "No Paca"
            colFecha.ReadOnly = True
            DgvFacturas.Columns.Insert(3, colFecha)

            Dim colTotalToneladas As New DataGridViewTextBoxColumn
            colTotalToneladas.Name = "TotalToneladas"
            colTotalToneladas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            colTotalToneladas.ReadOnly = True
            DgvFacturas.Columns.Insert(4, colTotalToneladas)

            Dim colTotalPacas As New DataGridViewTextBoxColumn
            colTotalPacas.Name = "TotalPacas"
            colTotalPacas.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            colTotalPacas.ReadOnly = False
            DgvFacturas.Columns.Insert(5, colTotalPacas)

            Dim colSubTotal As New DataGridViewTextBoxColumn
            colSubTotal.Name = "Subtotal"
            colSubTotal.DefaultCellStyle.Format = "C2"
            colSubTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            colSubTotal.Visible = False
            DgvFacturas.Columns.Insert(6, colSubTotal)

            Dim colTotal As New DataGridViewTextBoxColumn
            colTotal.Name = "Total"
            colTotal.HeaderText = "Total"
            colTotal.DefaultCellStyle.Format = "C2"
            colTotal.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            colTotal.ReadOnly = True
            DgvFacturas.Columns.Insert(7, colTotal)

            Dim colMoneda As New DataGridViewTextBoxColumn
            colMoneda.Name = "Moneda"
            colMoneda.HeaderText = "Moneda"
            'colMoneda.DefaultCellStyle.Format = "C2"
            colMoneda.Visible = False
            DgvFacturas.Columns.Insert(8, colMoneda)

            Dim colTipoCambio As New DataGridViewTextBoxColumn
            colTipoCambio.Name = "TipoCambio"
            colTipoCambio.HeaderText = "TipoCambio"
            colTipoCambio.DefaultCellStyle.Format = "C2"
            colTipoCambio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            colTipoCambio.Visible = False
            DgvFacturas.Columns.Insert(9, colTipoCambio)

            Dim colSello As New DataGridViewTextBoxColumn
            colSello.Name = "Sello"
            'colSello.DefaultCellStyle.Format = "C2"
            'colIdHviDetalle.HeaderText = "No Paca"
            colSello.Visible = False
            DgvFacturas.Columns.Insert(10, colSello)

            Dim colRutaXML As New DataGridViewTextBoxColumn
            colRutaXML.Name = "Ruta"
            'colSello.DefaultCellStyle.Format = "C2"
            'colIdHviDetalle.HeaderText = "No Paca"
            colRutaXML.Visible = False
            DgvFacturas.Columns.Insert(11, colRutaXML)

            Dim colSel As New DataGridViewCheckBoxColumn()
            colSel.Name = "Sel"
            colSel.FalseValue = False
            'colSel.TrueValue = True
            colSel.ReadOnly = False
            colSel.IndeterminateValue = False
            DgvFacturas.Columns.Insert(12, colSel)
        End If
    End Sub
    Private Sub propiedadesDgvData()
        'DgvData.Columns.Clear()
        If DgvData.Columns("NoIdentificacion") Is Nothing Then

            Dim colClaveProdServ As New DataGridViewTextBoxColumn
            colClaveProdServ.Name = "ClaveProdServ"
            'colIdHviDetalle.HeaderText = "No Paca"
            'colNoIdentificacion.Visible = False
            DgvData.Columns.Insert(0, colClaveProdServ)

            Dim colNoIdentificacion As New DataGridViewTextBoxColumn
            colNoIdentificacion.Name = "NoIdentificacion"
            'colIdHviDetalle.HeaderText = "No Paca"
            'colNoIdentificacion.Visible = False
            DgvData.Columns.Insert(1, colNoIdentificacion)

            Dim colCantidad As New DataGridViewTextBoxColumn
            colCantidad.Name = "Cantidad"
            colCantidad.HeaderText = "Cantidad"
            'colCantidad.DefaultCellStyle.Format = "C2"
            'colCantidad.Visible = False
            DgvData.Columns.Insert(2, colCantidad)

            Dim colClaveUnidad As New DataGridViewTextBoxColumn
            colClaveUnidad.Name = "ClaveUnidad"
            'colIdHviDetalle.HeaderText = "No Paca"
            'colNoIdentificacion.Visible = False
            DgvData.Columns.Insert(3, colClaveUnidad)

            Dim colUnidad As New DataGridViewTextBoxColumn
            colUnidad.Name = "Unidad"
            'colIdHviDetalle.HeaderText = "No Paca"
            'colNoIdentificacion.Visible = False
            DgvData.Columns.Insert(4, colUnidad)

            Dim colDescripcion As New DataGridViewTextBoxColumn
            colDescripcion.Name = "Descripcion"
            colDescripcion.HeaderText = "Descripcion"
            colDescripcion.DefaultCellStyle.WrapMode = DataGridViewTriState.True
            DgvData.Columns.Insert(5, colDescripcion)

            Dim colValorUnitario As New DataGridViewTextBoxColumn
            colValorUnitario.Name = "ValorUnitario"
            colValorUnitario.DefaultCellStyle.Format = "C2"
            'colIdHviDetalle.HeaderText = "No Paca"
            'colValorUnitario.Visible = False
            DgvData.Columns.Insert(6, colValorUnitario)

            Dim colSubTotal As New DataGridViewTextBoxColumn
            colSubTotal.Name = "SubTotal"
            colSubTotal.HeaderText = "SubTotal"
            colSubTotal.DefaultCellStyle.Format = "C2"
            'colImporte.Visible = False
            DgvData.Columns.Insert(7, colSubTotal)

            Dim colImporte As New DataGridViewTextBoxColumn
            colImporte.Name = "Importe"
            colImporte.HeaderText = "Importe"
            colImporte.DefaultCellStyle.Format = "C2"
            'colImporte.Visible = False
            DgvData.Columns.Insert(8, colImporte)

        End If
    End Sub

    Private Sub BtQuitarXML_Click(sender As Object, e As EventArgs) Handles BtQuitarXML.Click
        DgvFacturas.EndEdit()
        DgvData.Rows.Clear()
        Dim i As Integer = (DgvFacturas.Rows.Count - 1)
        Do While (i >= 0)
            i = (i - 1)
            For Each dr As DataGridViewRow In DgvFacturas.Rows
                If dr.Cells("sel").Value = True Then
                    DgvFacturas.Rows.Remove(dr)
                End If
            Next
        Loop
        TbCantidadFacturas.Text = DgvFacturas.RowCount
        Sumar()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtSeleccionaXML.Click
        Dim cargaxml As New ConsultaXML
        cargaxml.ShowDialog()
        If cargaxml.dsxml IsNot Nothing Then
            For Each dr As DataRow In cargaxml.dsxml.Tables("RegistroXML").Rows
                If ValidaExiste(dr("UUID").ToString) = False Then
                    ExtraerXML(dr("ruta").ToString, 1)
                End If
            Next
            DgvFacturas.Sort(DgvFacturas.Columns("Emisor"), ListSortDirection.Ascending)
            TbCantidadFacturas.Text = DgvFacturas.RowCount
        End If

        Sumar()
    End Sub
    Private Function ValidaExiste(ByVal UUID As String) As Boolean
        Dim valor As Boolean = False
        For Each dgvrow As DataGridViewRow In DgvFacturas.Rows
            If UUID = dgvrow.Cells("UUID").Value.ToString Then
                valor = True
            End If
        Next
        Return valor
    End Function
    Private Sub DgvFacturas_Click(sender As Object, e As EventArgs) Handles DgvFacturas.Click
        DgvData.Rows.Clear()
        If DgvFacturas.RowCount > 0 Then
            Dim index As Integer
            index = DgvFacturas.CurrentCell.RowIndex
            ExtraerXML(DgvFacturas.Rows(index).Cells("Ruta").Value.ToString, 2)
        Else
            MsgBox("No hay registros para validar.")
        End If
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        TbIdCompra.Clear()
        TbIdContratoCompra.Clear()
        TbNombre.Clear()
        TbIDCliente.Clear()
        TbRfcEmisor.Clear()
        TbPrecioCompra.Clear()
        TbPacasCompra.Clear()
        TbTotalKilos.Clear()
        TbSubTotalDls.Clear()
        TbCastigoDls.Clear()
        TbImporteDls.Clear()
        DtFechaCreacion.Value = Now
        DtFechaActualizacion.Value = Now
        TbImporteTotalFacturas.Clear()
        TbTotalToneladasFacturas.Clear()
        TbTotalPacasFacturas.Clear()
        DgvFacturas.Columns.Clear()
        DgvData.Columns.Clear()
        BtSeleccionaXML.Enabled = False
        TbCantidadFacturas.Clear()
        TbIdIntegracion.Clear()
    End Sub
    Private Sub DgvFacturas_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DgvFacturas.CellEndEdit
        Dim totalA As Integer = 0
        Dim TotalB As Decimal = 0

        For Each fila As DataGridViewRow In DgvFacturas.Rows
            If fila.Cells("TotalPacas").Value Is Nothing Then
                Exit Sub
            Else
                totalA += Convert.ToInt32(fila.Cells("TotalPacas").Value)
            End If
            TbTotalPacasFacturas.Text = Format(totalA, "#,##0")
        Next
        extraedetallexml()
    End Sub
    Private Sub extraedetallexml()
        DgvData.Rows.Clear()
        If DgvFacturas.RowCount > 0 Then
            Dim index As Integer
            index = DgvFacturas.CurrentCell.RowIndex
            ExtraerXML(DgvFacturas.Rows(index).Cells("Ruta").Value.ToString, 2)
        Else
            MsgBox("No hay registros para validar.")
        End If
    End Sub

    Private Sub BtSeleccionar_Click(sender As Object, e As EventArgs) Handles BtSeleccionar.Click
        For Each dgv As DataGridViewRow In DgvFacturas.Rows
            If dgv.Cells("sel").Value = False Then
                dgv.Cells("sel").Value = True
            End If
        Next
    End Sub
    Private Sub BtQuitar_Click(sender As Object, e As EventArgs) Handles BtQuitar.Click
        For Each dgv As DataGridViewRow In DgvFacturas.Rows
            If dgv.Cells("sel").Value = True Then
                dgv.Cells("sel").Value = False
            End If
        Next
    End Sub
    Private Sub DgvFacturas_KeyUp(sender As Object, e As KeyEventArgs) Handles DgvFacturas.KeyUp
        extraedetallexml()
    End Sub
End Class