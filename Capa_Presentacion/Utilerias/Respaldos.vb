Public Class Respaldos
    Private folderBrowserDialog1 As FolderBrowserDialog
    Private Sub BtGenerarRespaldo_Click(sender As Object, e As EventArgs) Handles BtGenerarRespaldo.Click
        GeneraRespaldo()
    End Sub
    Private Sub Nuevo()
        TbBDD.Text = BaseDeDatos
        TbNombreRespaldo.Clear()
        TbRutaRespaldo.Clear()
    End Sub
    Private Sub GeneraRespaldo()
        Dim EntidadRespaldos As New Capa_Entidad.Respaldos
        Dim NegocioRespaldos As New Capa_Negocio.Respaldos
        If TbBDD.Text = "" And TbRutaRespaldo.Text = "" And TbNombreRespaldo.Text = "" Then
            MsgBox("Verificar los campos vacios")
            Exit Sub
        End If
        Try
            EntidadRespaldos.BaseDedatosOrigen = TbBDD.Text
            EntidadRespaldos.RutaRespaldo = TbRutaRespaldo.Text
            EntidadRespaldos.NombreRespaldo = TbNombreRespaldo.Text & "-" & Now.Day & "_" & Now.Month & "_" & Now.Year & "_" & Now.Hour & "_" & Now.Minute & "_" & Now.Second & ".bak"
            NegocioRespaldos.Generar(EntidadRespaldos)
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'GeneraRegistroBitacora(Me.Text.Clone.ToString, BtGenerarRespaldo.Text, TbIdAsociacion.Text, TbDescripcion.Text)
            'Consultar()
        End Try
    End Sub
    Private Sub BtCancelar_Click(sender As Object, e As EventArgs) Handles BtCancelar.Click
        Close()
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
    Private Sub BtSeleccionaRuta_Click(sender As Object, e As EventArgs) Handles BtSeleccionaRuta.Click
        Dim Ruta As String = ""
        Ruta = TbRutaRespaldo.Text
        TbRutaRespaldo.Text = AbrirRutaPrincipal(Ruta)
    End Sub

    Private Sub Respaldos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
    End Sub
End Class