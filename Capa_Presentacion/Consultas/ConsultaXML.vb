Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Imports System.Xml
Imports System.ComponentModel
Imports System.Web.UI.HtmlControls

Public Class ConsultaXML
    Private dsxml_ As DataSet
    Public Property dsxml As DataSet
        Get
            Return dsxml_
        End Get
        Set(value As DataSet)
            dsxml_ = value
        End Set
    End Property
    Private Sub ConsultaXML_Load(sender As Object, e As EventArgs) Handles Me.Load
        abreXML()
    End Sub
    Private Sub listarXML(ByVal ruta As String)
        propiedadesDgvFactura()
        Dim increment As Integer = 0
        ProgressBar.Refresh()
        Try
            ':::Contamos cuanto archivos de texto hay en la carpeta
            Dim Total = My.Computer.FileSystem.GetFiles(ruta, FileIO.SearchOption.SearchAllSubDirectories, "*.xml")
            'LblTotal.Text = "Total Archivos de Texto: " + CStr(Total.Count)
            ProgressBar.Value = increment
            ProgressBar.Minimum = increment
            ProgressBar.Maximum = Total.Count
            ':::Realizamos la búsqueda de la ruta de cada archivo de texto y los agregamos al ListBox
            For Each archivos As String In My.Computer.FileSystem.GetFiles(ruta, FileIO.SearchOption.SearchAllSubDirectories, "*.xml")
                ExtraerXML(archivos, TbFiltro.Text)
                ProgressBar.Value += 1
            Next
        Catch ex As Exception
            MsgBox("No se realizó la operación por: " & ex.Message)
        End Try
    End Sub
    Private Sub BtSeleccionarXML_Click(sender As Object, e As EventArgs) Handles BtSeleccionarXML.Click
        If DgvFacturas.RowCount > 0 Then
            dsxml_ = DgvSeleccion(DgvFacturas)
            Me.Close()
        Else
            MsgBox("No hay registros para seleccionar.")
        End If
    End Sub
    Private Sub filtrarDgv(ByVal DgvFiltrado As DataGridView)
        Dim ds As New DataSet
        ds.Tables.Add("RegistroXML")
        Try
            Dim col As New DataColumn
            'Dim colsel As New DataColumn
            For Each dgvcol As DataGridViewColumn In DgvFiltrado.Columns
                'If dgvcol.Name <> "Sel" Then
                col = New DataColumn(dgvcol.Name)
                    ds.Tables("RegistroXML").Columns.Add(col)
                'Else
                '    col = New DataColumn(dgvcol.Name)
                '    ds.Tables("RegistroXML").Columns.Add(col, Type.GetType("System.Bool"))
                'End If

            Next
            Dim row As DataRow
            Dim colcount As Integer = DgvFiltrado.Columns.Count - 1
            For i As Integer = 0 To DgvFiltrado.Rows.Count - 1
                DgvFiltrado.Rows.Item(i).Cells("Sel").Value = False
                row = ds.Tables("RegistroXML").Rows.Add
                For Each column As DataGridViewColumn In DgvFiltrado.Columns
                    row.Item(column.Index) = DgvFiltrado.Rows.Item(i).Cells(column.Index).Value
                Next
            Next
            Dim table = ds.Tables("RegistroXML")
            'datos = ds.Tables("RegistroXML").DefaultView
            DgvFacturas.Columns.Clear()
            '
            table.DefaultView.RowFilter = "Emisor LIKE '%" & Trim(TbFiltro.Text) & "%'"
            DgvFacturas.DataSource = table
            propiedadesDgvFactura()
            'table.DefaultView.RowFilter = "[Emisor] like " & TbFiltro.Text

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Function DgvSeleccion(ByVal dgv As DataGridView) As DataSet
        Dim ds As New DataSet
        Try
            ds.Tables.Add("RegistroXML")
            Dim col As DataColumn
            For Each dgvcol As DataGridViewColumn In dgv.Columns
                col = New DataColumn(dgvcol.Name)
                ds.Tables("RegistroXML").Columns.Add(col)
            Next
            Dim row As DataRow
            Dim colcount As Integer = dgv.Columns.Count - 1
            For i As Integer = 0 To dgv.Rows.Count - 1
                If dgv.Rows.Item(i).Cells("Sel").Value = True Then
                    dgv.Rows.Item(i).Cells("Sel").Value = False
                    row = ds.Tables("RegistroXML").Rows.Add
                    For Each column As DataGridViewColumn In dgv.Columns
                        row.Item(column.Index) = dgv.Rows.Item(i).Cells(column.Index).Value
                    Next
                End If
            Next
            Return ds
        Catch ex As Exception
            MsgBox("ERROR CRITICO : Se detectó una excepción al convertir dataGridView a DataSet (DgvFacturas).. " & Chr(10) & ex.Message)
            Return Nothing
        End Try
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtSeleccionarCarpeta.Click
        abreXML()
    End Sub
    Private Sub abreXML()
        Dim rutafolder As String
        FolderBrowserDialog1.SelectedPath = "\\servidor\Scanner\Miguel\XML"
        If (FolderBrowserDialog1.ShowDialog() = DialogResult.OK) Then
            TbRuta.Text = FolderBrowserDialog1.SelectedPath
            rutafolder = TbRuta.Text
            DgvFacturas.Rows.Clear()
            listarXML(rutafolder)
            DgvFacturas.Sort(DgvFacturas.Columns("Emisor"), ListSortDirection.Ascending)
        End If

        Label3.Text = DgvFacturas.RowCount

    End Sub
    Private Sub propiedadesDgvFactura()
        'DgvData.Columns.Clear()
        If DgvFacturas.Columns("UUID") Is Nothing Then

            Dim colEmisor As New DataGridViewTextBoxColumn
            colEmisor.Name = "Emisor"
            'colIdHviDetalle.HeaderText = "No Paca"
            colEmisor.ReadOnly = True
            DgvFacturas.Columns.Insert(0, colEmisor)

            Dim colRfcEmisor As New DataGridViewTextBoxColumn
            colRfcEmisor.Name = "RFC"
            'colIdHviDetalle.HeaderText = "No Paca"
            colRfcEmisor.ReadOnly = True
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

            Dim colSubTotal As New DataGridViewTextBoxColumn
            colSubTotal.Name = "Subtotal"
            'colIdHviDetalle.HeaderText = "No Paca"
            colSubTotal.DefaultCellStyle.Format = "C2"
            colSubTotal.ReadOnly = True
            DgvFacturas.Columns.Insert(4, colSubTotal)

            Dim colTotal As New DataGridViewTextBoxColumn
            colTotal.Name = "Total"
            colTotal.HeaderText = "Total"
            colTotal.DefaultCellStyle.Format = "C2"
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
            colTipoCambio.DefaultCellStyle.Format = "C2"
            colTipoCambio.ReadOnly = True
            DgvFacturas.Columns.Insert(7, colTipoCambio)

            Dim colSello As New DataGridViewTextBoxColumn
            colSello.Name = "Sello"
            'colSello.DefaultCellStyle.Format = "C2"
            'colIdHviDetalle.HeaderText = "No Paca"
            colSello.Visible = False
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
    Private Sub ExtraerXML(ByVal Cadena As String, Optional ByVal filtro As String = "")
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
                If node.attributes("ClaveProdServ").value = TbClaveProducto.Text And node.attributes("ClaveUnidad").value = TbUnidad.Text Then
                    If filtro <> "" Then
                        If ConsultarXML(UUID) = False And Emisor_Nombre.Contains(filtro) Then
                            DgvFacturas.Rows.Add(Emisor_Nombre, Emisor_Rfc, UUID, Fecha, Subtotal, total, Moneda, TipoCambio, sello, Cadena)
                            Exit For
                        End If
                    Else
                        If ConsultarXML(UUID) = False Then
                            DgvFacturas.Rows.Add(Emisor_Nombre, Emisor_Rfc, UUID, Fecha, Subtotal, total, Moneda, TipoCambio, sello, Cadena)
                            Exit For
                        End If
                    End If
                ElseIf node.attributes("ClaveProdServ").value = TbClaveProducto.Text And TbUnidad.Text = "" Then
                    If filtro <> "" Then
                        If ConsultarXML(UUID) = False And Emisor_Nombre.Contains(filtro) Then
                            DgvFacturas.Rows.Add(Emisor_Nombre, Emisor_Rfc, UUID, Fecha, Subtotal, total, Moneda, TipoCambio, sello, Cadena)
                            Exit For
                        End If
                    Else
                        If ConsultarXML(UUID) = False Then
                            DgvFacturas.Rows.Add(Emisor_Nombre, Emisor_Rfc, UUID, Fecha, Subtotal, total, Moneda, TipoCambio, sello, Cadena)
                            Exit For
                        End If
                    End If
                End If
            Next
        Else
            MsgBox("Archivo XML no es una factura version 3.3")
        End If
    End Sub
    Private Function ConsultarXML(ByVal UUIDc As String)
        Dim EntidadIntegraciondeCompras As New Capa_Entidad.IntegraciondeCompras
        Dim NegocioIntegraciondeCompras As New Capa_Negocio.IntegraciondeCompras
        Dim Tabla As New DataTable
        Dim Existe As Boolean = False
        Try
            EntidadIntegraciondeCompras.Consulta = Consulta.ConsultaBasica
            EntidadIntegraciondeCompras.UUID = UUIDc
            NegocioIntegraciondeCompras.Consultar(EntidadIntegraciondeCompras)
            Tabla = EntidadIntegraciondeCompras.TablaConsulta
            If Tabla.Rows.Count > 0 Then
                Dim row As DataRow = Tabla.Rows(Tabla.Rows.Count - 1)
                If CStr(row("UUID")) = UUIDc Then Existe = True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return Existe
    End Function
    Private Sub TbFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles TbFiltro.KeyDown
        If e.KeyCode = Keys.Enter Then
            'abreXML()
            filtrarDgv(DgvFacturas)
        End If
    End Sub
    Private Sub BtMarcar_Click(sender As Object, e As EventArgs) Handles BtMarcar.Click
        For Each dgv As DataGridViewRow In DgvFacturas.Rows
            If dgv.Cells("Sel").Value = False Then
                dgv.Cells("Sel").Value = True
            End If
        Next
    End Sub
    Private Sub BtDesmarcar_Click(sender As Object, e As EventArgs) Handles BtDesmarcar.Click
        For Each dgv As DataGridViewRow In DgvFacturas.Rows
            If dgv.Cells("Sel").Value = True Then
                dgv.Cells("Sel").Value = False
            End If
        Next
    End Sub
End Class