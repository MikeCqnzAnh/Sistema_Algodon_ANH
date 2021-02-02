Imports System.Xml
Public Class IntegraciondeCompras
    Private Sub ExtraerXML(ByVal Cadena As String)
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
            TbEmisorNombre.Text = Emisor_Nombre
            TbRfcEmisor.Text = Emisor_Rfc
            TbUUID.Text = UUID
            TbTotal.Text = total.ToString("c")

            DgvFacturas.Rows.Add(Emisor_Nombre, Emisor_Rfc, UUID, Fecha, Subtotal, total, Moneda, TipoCambio, sello, Cadena)

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
            'DgvData.DataSource = dt
        Else
            MsgBox("Archivo XML no es una factura version 3.3")
        End If
    End Sub
    Private Sub Sumar()
        Dim totalA As Double = 0
        Dim totalB As Double = 0
        For Each fila As DataGridViewRow In DgvFacturas.Rows
            If fila.Cells("Total").Value Is Nothing Then
                Exit Sub
            Else
                totalA += Convert.ToDouble(fila.Cells("Total").Value)
                'ElseIf fila.Cells("MARCA").Value = "B" Then
                '    totalB += Convert.ToDouble(fila.Cells("SUBTOTAL").Value)
            End If
        Next
        TbTotalFacturas.Text = Format(totalA, "$ #,##0.000")
        'lblB.Text = Format(totalB, "$ #,##0.000")
    End Sub
    Private Sub propiedadesDgvFactura()
        'DgvData.Columns.Clear()
        If DgvFacturas.Columns("UUID") Is Nothing Then

            Dim colEmisor As New DataGridViewTextBoxColumn
            colEmisor.Name = "Emisor"
            'colIdHviDetalle.HeaderText = "No Paca"
            colEmisor.Visible = False
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
            colUUID.ReadOnly = True
            DgvFacturas.Columns.Insert(2, colUUID)

            Dim colFecha As New DataGridViewTextBoxColumn
            colFecha.Name = "Fecha"
            'colIdHviDetalle.HeaderText = "No Paca"
            colFecha.ReadOnly = True
            DgvFacturas.Columns.Insert(3, colFecha)

            Dim colSubTotal As New DataGridViewTextBoxColumn
            colSubTotal.Name = "Subtotal"
            'colIdHviDetalle.HeaderText = "No Paca"
            colSubTotal.ReadOnly = True
            DgvFacturas.Columns.Insert(4, colSubTotal)

            Dim colTotal As New DataGridViewTextBoxColumn
            colTotal.Name = "Total"
            colTotal.HeaderText = "Total"
            colTotal.ReadOnly = True
            DgvFacturas.Columns.Insert(5, colTotal)

            Dim colMoneda As New DataGridViewTextBoxColumn
            colMoneda.Name = "Moneda"
            colMoneda.HeaderText = "Moneda"
            'colMoneda.DefaultCellStyle.Format = "C2"
            colMoneda.ReadOnly = True
            DgvFacturas.Columns.Insert(6, colMoneda)

            Dim colTipoCambio As New DataGridViewTextBoxColumn
            colTipoCambio.Name = "TipoCambio"
            colTipoCambio.HeaderText = "TipoCambio"
            'colTipoCambio.DefaultCellStyle.Format = "C2"
            colTipoCambio.ReadOnly = True
            DgvFacturas.Columns.Insert(7, colTipoCambio)

            Dim colSello As New DataGridViewTextBoxColumn
            colSello.Name = "Sello"
            'colSello.DefaultCellStyle.Format = "C2"
            'colIdHviDetalle.HeaderText = "No Paca"
            colSello.ReadOnly = True
            DgvFacturas.Columns.Insert(8, colSello)

            Dim colRutaXML As New DataGridViewTextBoxColumn
            colRutaXML.Name = "Ruta"
            'colSello.DefaultCellStyle.Format = "C2"
            'colIdHviDetalle.HeaderText = "No Paca"
            colRutaXML.ReadOnly = True
            DgvFacturas.Columns.Insert(9, colRutaXML)

            Dim colSel As New DataGridViewCheckBoxColumn()
            colSel.Name = "Sel"
            colSel.FalseValue = False
            'colSel.TrueValue = True
            colSel.ReadOnly = False
            colSel.IndeterminateValue = False
            DgvFacturas.Columns.Insert(10, colSel)
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
            'colDescripcion.ReadOnly = True
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
    Private Sub BtAgregaXML_Click(sender As Object, e As EventArgs) Handles BtAgregaXML.Click
        Dim myFileDialog As New OpenFileDialog()
        With myFileDialog
            .Filter = "XML Files|*.xml"
            .Title = "Open File"
            .ShowDialog()
        End With
        If myFileDialog.FileName.ToString <> "" Then
            Dim XmlFile As String = myFileDialog.FileName.ToString
            ExtraerXML(XmlFile)
            'Else
            '    MsgBox("No hay un archivo XML seleccionado")
        End If
        Sumar()
    End Sub
    Private Sub BtQuitarXML_Click(sender As Object, e As EventArgs) Handles BtQuitarXML.Click
        DgvFacturas.EndEdit()

        For Each row As DataGridViewRow In DgvFacturas.SelectedRows
            If row.Cells("sel").Value = True Then
                DgvFacturas.Rows.Remove(row)
            End If
        Next
        Sumar()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cargaxml As New ConsultaXML
        cargaxml.ShowDialog()
    End Sub
End Class