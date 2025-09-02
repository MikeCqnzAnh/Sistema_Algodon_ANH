Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO

Public Class DatosEmpresa
    Private Sub DatosEmpresa_load(sender As Object, e As EventArgs) Handles MyBase.Load
        Limpiar()
        ConsultaEmpresa()
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Guardar()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub Limpiar()
        TbID.Text = ""
        TbRazonSocial.Text = ""
        TbRfc.Text = ""
        TbRepresentante.Text = ""
        TbRFCRepresentante.Text = ""
        TbCalle.Text = ""
        TbNumExt.Text = ""
        TbNumInt.Text = ""
        TbEntreCalle1.Text = ""
        TbEntreCalle2.Text = ""
        TbColonia.Text = ""
        TbReferencia.Text = ""
        TbPoblacion.Text = ""
        TbCodigoPostal.Text = ""
        TbPais.Text = ""
        TbEstado.Text = ""
        TbMunicipio.Text = ""
        TbLugarExpedicion.Text = ""
    End Sub
    Private Sub Guardar()
        Dim EntidadDatosEmpresa As New Capa_Entidad.DatosEmpresa
        Dim NegocioDatosEmpresa As New Capa_Negocio.DatosEmpresa
        Dim tabla As New DataTable
        Dim EntidadConfiguracionParametros As New Capa_Entidad.ConfiguracionParametros
        Dim NegocioConfiguracionParametros As New Capa_Negocio.ConfiguracionParametros
        EntidadConfiguracionParametros.Consulta = Consulta.ConsultaBaseDatos
        NegocioConfiguracionParametros.Consultar(EntidadConfiguracionParametros)
        tabla = EntidadConfiguracionParametros.TablaConsulta
        If pblogo.Image Is Nothing Then
            MessageBox.Show("No hay imagen para guardar.")
            Return
        Else
            Dim wmfBytes As Byte()
            wmfBytes = ConvertToWMF(pblogo)
            ' wmfBytes = ImageToByteArray(pblogo)

            ' Dim m As New System.IO.MemoryStream()
            ' pblogo.Image.Save(m, pblogo.Image.RawFormat)
            ' Dim data As Byte() = m.GetBuffer()
            For Each Fila As DataRow In tabla.Rows
                EntidadDatosEmpresa.IdDatosEmpresa = IIf(TbID.Text = "", 0, TbID.Text)
                EntidadDatosEmpresa.RazonSocial = TbRazonSocial.Text
                EntidadDatosEmpresa.RfcEmpresa = TbRfc.Text
                EntidadDatosEmpresa.RepresentanteLegal = TbRepresentante.Text
                EntidadDatosEmpresa.RfcRepresentante = TbRFCRepresentante.Text
                EntidadDatosEmpresa.Calle = TbCalle.Text
                EntidadDatosEmpresa.NumExt = TbNumExt.Text
                EntidadDatosEmpresa.NumInt = TbNumInt.Text
                EntidadDatosEmpresa.EntreCalle1 = TbEntreCalle1.Text
                EntidadDatosEmpresa.EntreCalle2 = TbEntreCalle2.Text
                EntidadDatosEmpresa.Colonia = TbColonia.Text
                EntidadDatosEmpresa.Referencia = TbReferencia.Text
                EntidadDatosEmpresa.Poblacion = TbPoblacion.Text
                EntidadDatosEmpresa.CodigoPostal = TbCodigoPostal.Text
                EntidadDatosEmpresa.Pais = TbPais.Text
                EntidadDatosEmpresa.Estado = TbEstado.Text
                EntidadDatosEmpresa.Municipio = TbMunicipio.Text
                EntidadDatosEmpresa.LugarExpedicion = TbLugarExpedicion.Text
                EntidadDatosEmpresa.BaseDeDatos = Fila("name")
                EntidadDatosEmpresa.logoempresa = wmfBytes
                NegocioDatosEmpresa.Guardar(EntidadDatosEmpresa)
                TbID.Text = EntidadDatosEmpresa.IdDatosEmpresa
            Next
            MsgBox("Realizado Correctamente")
            DesabilitaControles()
        End If
    End Sub
    Private Sub HabilitaControles()
        GbDatosEmpresa.Enabled = True
        GbNombreEmpresa.Enabled = True
    End Sub
    Private Sub DesabilitaControles()
        GbDatosEmpresa.Enabled = False
        GbNombreEmpresa.Enabled = False
    End Sub
    Public Shared Function ConvertToWMF(logo As PictureBox) As Byte()
        If logo.Image Is Nothing Then
            Throw New InvalidOperationException("El PictureBox no contiene ninguna imagen.")
        End If

        Using bitmap As New Bitmap(logo.Image)
            ' Crear un Metafile usando un MemoryStream
            Using stream As New MemoryStream()
                Using gRef As Graphics = Graphics.FromImage(bitmap)
                    Dim hdc As IntPtr = gRef.GetHdc()
                    Try
                        Using metafile As New Metafile(stream, hdc)
                            Using g As Graphics = Graphics.FromImage(metafile)
                                g.DrawImage(bitmap, New Rectangle(0, 0, bitmap.Width, bitmap.Height))
                            End Using
                        End Using
                    Finally
                        gRef.ReleaseHdc(hdc)
                    End Try
                End Using

                ' Convertir el Metafile a un array de bytes
                Return stream.ToArray()
            End Using
        End Using
    End Function

    Private Sub ConsultaEmpresa()
        Dim EntidadDatosEmpresa As New Capa_Entidad.DatosEmpresa
        Dim NegocioDatosEmpresa As New Capa_Negocio.DatosEmpresa
        Dim Tabla As New DataTable
        EntidadDatosEmpresa.Consulta = Consulta.ConsultaBasica
        NegocioDatosEmpresa.Consultar(EntidadDatosEmpresa)
        Tabla = EntidadDatosEmpresa.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        Try
            DesabilitaControles()
            Dim ImgStream As New System.IO.MemoryStream(CType(Tabla.Rows(0)("logoempresa"), Byte()))
            TbID.Text = Tabla.Rows(0).Item("IdDatosEmpresa")
            TbRazonSocial.Text = Tabla.Rows(0).Item("RazonSocial")
            TbRfc.Text = Tabla.Rows(0).Item("RFCEmpresa")
            TbRepresentante.Text = Tabla.Rows(0).Item("RepresentanteLegal")
            TbRFCRepresentante.Text = Tabla.Rows(0).Item("RFCRepresentante")
            TbCalle.Text = Tabla.Rows(0).Item("Calle")
            TbNumExt.Text = Tabla.Rows(0).Item("NumExt")
            TbNumInt.Text = Tabla.Rows(0).Item("NumInt")
            TbEntreCalle1.Text = Tabla.Rows(0).Item("EntreCalle1")
            TbEntreCalle2.Text = Tabla.Rows(0).Item("EntreCalle2")
            TbColonia.Text = Tabla.Rows(0).Item("Colonia")
            TbReferencia.Text = Tabla.Rows(0).Item("Referencia")
            TbPoblacion.Text = Tabla.Rows(0).Item("Poblacion")
            TbCodigoPostal.Text = Tabla.Rows(0).Item("CodigoPostal")
            TbPais.Text = Tabla.Rows(0).Item("Pais")
            TbEstado.Text = Tabla.Rows(0).Item("Estado")
            TbMunicipio.Text = Tabla.Rows(0).Item("Municipio")
            TbLugarExpedicion.Text = Tabla.Rows(0).Item("LugarExpedicion")
            pblogo.Image = Image.FromStream(ImgStream)
            pblogo.SizeMode = PictureBoxSizeMode.StretchImage
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        HabilitaControles()
    End Sub

    Private Sub btcargalogo_Click(sender As Object, e As EventArgs) Handles btcargalogo.Click
        With ofdlogo
            .InitialDirectory = "C:\"
            .Filter = "JPEGs|*.jpg|PNGs|*.png|Todos los Archivos|*.*"
            .FilterIndex = 1
        End With

        If ofdlogo.ShowDialog() = DialogResult.OK Then
            With pblogo
                .Image = Image.FromFile(ofdlogo.FileName)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .ImageLocation = ofdlogo.FileName
            End With
        End If

    End Sub
End Class