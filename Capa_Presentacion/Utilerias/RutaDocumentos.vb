Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Imports System
Imports System.Drawing
Imports System.Windows.Forms
Imports System.IO
Public Class RutaDocumentos
    Private folderBrowserDialog1 As FolderBrowserDialog
    Private Sub RutaDocumentos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConsultarRuta()
    End Sub
    Private Sub GuardarActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarActualizarToolStripMenuItem.Click
        Guardar()
    End Sub
    Private Sub BtCarpetaTemporada_Click(sender As Object, e As EventArgs) Handles BtCarpetaTemporada.Click
        Dim Ruta As String = ""
        Ruta = TBRuta.Text & "\" & TBNombreRaiz.Text & "\" & TbTemporadas.Text & "\" '& TbNombreAnual.Text
        AbrirRutaAnual(Ruta)
    End Sub
    Private Sub BTUbicacion_Click(sender As Object, e As EventArgs) Handles BTUbicacion.Click
        Dim Ruta As String = ""
        Ruta = TBRuta.Text
        TBRuta.Text = AbrirRutaPrincipal(Ruta)
    End Sub
    Private Sub Guardar()
        If TBRuta.Text = "" Or TBNombreRaiz.Text = "" Or TBPersonas.Text = "" Or TbDocumentacionProductores.Text = "" Or TBLotes.Text = "" Or TbContratosProductores.Text = "" Or TbContratosCompradores.Text = "" Or TbAnexo.Text = "" Or TbPreregistro.Text = "" Or TbActaParticipacion.Text = "" Or TbTemporadas.Text = "" Or TbNombreAnual.Text = "" Then
            MessageBox.Show("No se puede guardar registro con campos en blanco, verifica!")
        Else
            Try
                Dim EntidadRutaDocumentos As New Capa_Entidad.RutaDocumentos
                Dim NegocioRutaDocumentos As New Capa_Negocio.RutaDocumentos
                EntidadRutaDocumentos.IdUbicacion = IIf(TBIdUbicacion.Text = "", 0, TBIdUbicacion.Text)
                EntidadRutaDocumentos.RutaPrincipal = TBRuta.Text
                EntidadRutaDocumentos.NombreCarpetaRaiz = TBNombreRaiz.Text
                EntidadRutaDocumentos.DocumentosProductores = TBPersonas.Text
                EntidadRutaDocumentos.DocumentosPersonales = TbDocumentacionProductores.Text
                EntidadRutaDocumentos.DocumentosLotes = TBLotes.Text
                EntidadRutaDocumentos.ContratosProductores = TbContratosProductores.Text
                EntidadRutaDocumentos.ContratosCompradores = TbContratosCompradores.Text
                EntidadRutaDocumentos.Anexos = TbAnexo.Text
                EntidadRutaDocumentos.PreRegistro = TbPreregistro.Text
                EntidadRutaDocumentos.ActaParticipacion = TbActaParticipacion.Text
                EntidadRutaDocumentos.Temporadas = TbTemporadas.Text
                EntidadRutaDocumentos.NombreAnual = TbNombreAnual.Text
                NegocioRutaDocumentos.InsertaRutaDocumentos(EntidadRutaDocumentos)
                TBIdUbicacion.Text = EntidadRutaDocumentos.IdUbicacion
                CrearCarpetas()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.ApplicationModal, "Aviso")
            Finally
                GeneraRegistroBitacora(Me.Text.Clone.ToString, GuardarActualizarToolStripMenuItem.Text, TBIdUbicacion.Text, TBRuta.Text)
                GbUbicacionDocumentos.Enabled = False
                MessageBox.Show("Realizado Correctamente", "Aviso")
            End Try
        End If
    End Sub
    Private Sub ConsultarRuta()
        Dim EntidadRutaDocumentos As New Capa_Entidad.RutaDocumentos
        Dim NegocioRutaDocumentos As New Capa_Negocio.RutaDocumentos
        Dim Tabla As New DataTable
        EntidadRutaDocumentos.Consulta = Consulta.ConsultaDetallada
        NegocioRutaDocumentos.Consultar(EntidadRutaDocumentos)
        Tabla = EntidadRutaDocumentos.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        Try
            TBIdUbicacion.Text = Tabla.Rows(0).Item("IdUbicacion")
            TBRuta.Text = Tabla.Rows(0).Item("RutaPrincipal")
            TBNombreRaiz.Text = Tabla.Rows(0).Item("NombreCarpetaRaiz")
            TBPersonas.Text = Tabla.Rows(0).Item("DocumentosProductores")
            TbDocumentacionProductores.Text = Tabla.Rows(0).Item("DocumentosPersonales")
            TBLotes.Text = Tabla.Rows(0).Item("DocumentosLotes")
            TbContratosProductores.Text = Tabla.Rows(0).Item("ContratosProductores")
            TbContratosCompradores.Text = Tabla.Rows(0).Item("ContratosCompradores")
            TbAnexo.Text = Tabla.Rows(0).Item("Anexos")
            TbPreregistro.Text = Tabla.Rows(0).Item("PreRegistro")
            TbActaParticipacion.Text = Tabla.Rows(0).Item("ActaParticipacion")
            TbTemporadas.Text = Tabla.Rows(0).Item("Temporadas")
            TbNombreAnual.Text = Tabla.Rows(0).Item("NombreAnual")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GbUbicacionDocumentos.Enabled = False
        End Try
    End Sub
    Private Function AbrirRutaPrincipal(ByVal Ruta As String)
        Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()

        Try
            ' Configuración del FolderBrowserDialog
            With folderBrowserDialog1

                .Reset() ' resetea

                ' leyenda
                .Description = " Seleccionar una carpeta "
                ' Path " Mis documentos "

                .SelectedPath = Ruta
                .RootFolder = Environment.SpecialFolder.Desktop
                ' deshabilita el botón " crear nueva carpeta "
                .ShowNewFolderButton = True

                '.RootFolder = Environment.SpecialFolder.Desktop
                '.RootFolder = Environment.SpecialFolder.StartMenu

                Dim ret As DialogResult = .ShowDialog ' abre el diálogo

                ' si se presionó el botón aceptar ...
                If ret = DialogResult.OK Then

                    'Dim nFiles As ObjectModel.ReadOnlyCollection(Of String)

                    'nFiles = My.Computer.FileSystem.GetFiles(.SelectedPath)

                    'MsgBox("Total de archivos: " & CStr(nFiles.Count),
                    '                        MsgBoxStyle.Information)
                    Ruta = LTrim(RTrim(folderBrowserDialog1.SelectedPath))
                End If

                .Dispose()
            End With

        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try
        Return Ruta
    End Function
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub AbrirRutaAnual(ByVal Ruta As String)
        Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Try
            ' Configuración del FolderBrowserDialog
            With folderBrowserDialog1
                .Reset() ' resetea
                ' leyenda
                .Description = " Seleccionar una carpeta "
                ' Path " Mis documentos "
                .SelectedPath = Ruta

                ' deshabilita el botón " crear nueva carpeta "
                .ShowNewFolderButton = True
                '.RootFolder = Environment.SpecialFolder.Desktop
                '.RootFolder = Environment.SpecialFolder.StartMenu
                Dim ret As DialogResult = .ShowDialog ' abre el diálogo
                ' si se presionó el botón aceptar ...
                If ret = DialogResult.OK Then
                    'Dim nFiles As ObjectModel.ReadOnlyCollection(Of String)
                    'nFiles = My.Computer.FileSystem.GetFiles(.SelectedPath)
                    'MsgBox("Total de archivos: " & CStr(nFiles.Count),
                    '                        MsgBoxStyle.Information)
                    'Ruta = folderBrowserDialog1.SelectedPath
                    TbNombreAnual.Text = LTrim(RTrim(Strings.Right(folderBrowserDialog1.SelectedPath, 7)))
                End If
                .Dispose()
            End With
        Catch oe As Exception
            MsgBox(oe.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub CrearCarpetas()
        Dim NuevaTemporada As String = TBRuta.Text & "\" & TBNombreRaiz.Text & "\" & TbTemporadas.Text & "\" & TbNombreAnual.Text
        If Not Directory.Exists(NuevaTemporada & "\" & TbContratosProductores.Text) Or Directory.Exists(NuevaTemporada) Then
            Directory.CreateDirectory(NuevaTemporada & "\" & TbContratosProductores.Text)
            Directory.CreateDirectory(NuevaTemporada & "\" & TbContratosCompradores.Text)
            Directory.CreateDirectory(NuevaTemporada & "\" & TbAnexo.Text)
            Directory.CreateDirectory(NuevaTemporada & "\" & TbPreregistro.Text)
            Directory.CreateDirectory(NuevaTemporada & "\" & TbActaParticipacion.Text)
        End If
    End Sub
    Private Sub ModificarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarToolStripMenuItem.Click
        Dim opc As DialogResult = MsgBox("¿Desea modificar campos al registro?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Salir")

        If opc = DialogResult.Yes Then

            GbUbicacionDocumentos.Enabled = True

        ElseIf opc = DialogResult.No Then

            GbUbicacionDocumentos.Enabled = False

        End If
    End Sub
End Class