Imports System.Configuration
Imports System.IO
Imports Capa_Operacion
Imports Newtonsoft.Json

Public Class Registrolicencia
    Inherits Form

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FrmRegistrolicencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenacombo()
        llenacomboestatus()
        obtenerlicencia()
        controles()
    End Sub
    Private Sub controles()
        If cbestatuslicencia.SelectedValue = 0 Then
            tbnombre.Enabled = True
            tbemail.Enabled = True
            tbnombrecontacto.Enabled = True
            tbtelefono.Enabled = True
            btactivar.Enabled = True
            btlimpiar.Enabled = True
            btpegar.Enabled = True
        Else
            tbnombre.Enabled = False
            tbemail.Enabled = False
            tbnombrecontacto.Enabled = False
            tbtelefono.Enabled = False
            btactivar.Enabled = False
            btlimpiar.Enabled = False
            btpegar.Enabled = False
        End If

    End Sub
    Private Sub llenacombo()
        Dim dt As New DataTable("Tabla")
        Dim dr As DataRow
        Try
            dt.Columns.Add("Id")
            dt.Columns.Add("Descripcion")

            dr = dt.NewRow()
            dr("Id") = "0"
            dr("Descripcion") = "Dias de Prueba"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Id") = "1"
            dr("Descripcion") = "Mes"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Id") = "2"
            dr("Descripcion") = "Año"
            dt.Rows.Add(dr)

            cbperiodo.DataSource = dt
            cbperiodo.ValueMember = "Id"
            cbperiodo.DisplayMember = "Descripcion"
            cbperiodo.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
    End Sub

    Private Sub llenacomboestatus()
        Dim dt As New DataTable("Tabla")
        Dim dr As DataRow
        Try
            dt.Columns.Add("Id")
            dt.Columns.Add("Descripcion")

            dr = dt.NewRow()
            dr("Id") = "0"
            dr("Descripcion") = "Inactiva"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Id") = "1"
            dr("Descripcion") = "Activa"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Id") = "2"
            dr("Descripcion") = "Vencida"
            dt.Rows.Add(dr)

            dr = dt.NewRow()
            dr("Id") = "3"
            dr("Descripcion") = "Suspendida"
            dt.Rows.Add(dr)

            cbestatuslicencia.DataSource = dt
            cbestatuslicencia.ValueMember = "Id"
            cbestatuslicencia.DisplayMember = "Descripcion"
            cbestatuslicencia.SelectedIndex = -1
        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
    End Sub

    Private Sub btaceptar_Click(sender As Object, e As EventArgs) Handles btactivar.Click
        Try
            IIf(cbestatuslicencia.SelectedValue = 0, cbestatuslicencia.SelectedValue = 1, cbestatuslicencia.SelectedValue = 0)
            'Dim helper As New LicenciaHelper()
            'Dim lic As New LicenciaHelper.Licencia With {
            '                .cpuid = configseriales.CpuId(),
            '.nombrerazonsocial = tbnombre.Text,
            '.email = tbemail.Text,
            '.nombrecontacto = tbnombrecontacto.Text,
            '.telfonocontacto = tbtelefono.Text,
            '.idestatusserial = cbestatuslicencia.SelectedValue,
            '.fechavencimientoserial = DateTime.Now.AddMonths(12),
            '.serialencryp = configseriales.encriptaserial(tblicencia.Text)
            '    }

            'Dim eregistrolicencia As New E_Registrolicencia()
            'Dim nregistrolicencia As New N_Registrolicencia()

            'eregistrolicencia.Guardar = O_Configuracion.Guardar.guardarencabezado
            'eregistrolicencia.cpuid = configseriales.CpuId()
            'eregistrolicencia.nombre = tbnombre.Text
            'eregistrolicencia.email = tbemail.Text
            'eregistrolicencia.nombrecontacto = tbnombrecontacto.Text
            'eregistrolicencia.telefonocontacto = tbtelefono.Text
            'eregistrolicencia.serialencryp = configseriales.encriptaserial(tblicencia.Text)
            'eregistrolicencia.idestatusserial = Convert.ToInt32(cbestatuslicencia.SelectedValue)
            'eregistrolicencia.fechavencimiento = dtfechavencimiento.Value

            'nregistrolicencia.Guardar(eregistrolicencia)
            creajson()

        Catch ex As Exception
            MessageBox.Show("Error " & ex.Message)
        End Try
    End Sub

    Private Async Sub creajson()
        Try
            Dim licencia As New LicenciaHelper.Licencia With {
                    .nombrerazonsocial = tbnombre.Text.Trim(),
                    .email = tbemail.Text.Trim(),
                    .licencia = tblicencia.Text.Trim(),
                    .cpuid = configseriales.CpuId(),
                    .serialencryp = configseriales.encriptaserial(tblicencia.Text),
                    .idperiodo = Convert.ToInt32(cbperiodo.SelectedValue),
                    .cantidad = Convert.ToInt32(nucantidad.Value),
                    .fechaactivacionserial = DateTime.Now,
                    .fechavencimientoserial = dtfechavencimiento.Value,
                    .idestatusserial = Convert.ToInt32(cbestatuslicencia.SelectedValue),
                    .nombrecontacto = tbnombrecontacto.Text.Trim(),
                    .telfonocontacto = tbtelefono.Text.Trim()
                }
            Dim Actualizado = Await LicenciaHelper.ActualizarLicenciaAsync(licencia)
            If Actualizado Then
                LicenciaHelper.GuardarLicenciaCifrada(licencia)
                btactivar.Text = "LICENCIA ACTIVADA"
                MessageBox.Show("Licencia Activada con exito.", "Activacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information)
                tbnombre.Enabled = False
                tbemail.Enabled = False
                tbnombrecontacto.Enabled = False
                tbtelefono.Enabled = False
                btactivar.Enabled = False
            End If
            'MessageBox.Show("Licencia cifrada generada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error al generar la licencia cifrada:" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub obtenerlicencia()
        Try
            'Dim rutaArchivo As String = Path.Combine(Application.StartupPath, "licencia_cifrada.dat")
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            ConfigurationManager.RefreshSection("AppSettings")

            'Dim rutaArchivo As String = Path.Combine(Application.StartupPath, "licencia_cifrada.dat")
            Dim rutaArchivo As String = config.AppSettings.Settings("RutaLc").Value.ToString()
            If Not File.Exists(rutaArchivo) Then Return

            Dim jsonEnvoltura As String = File.ReadAllText(rutaArchivo)
            Dim objetoCifrado = JsonConvert.DeserializeObject(Of LicenciaHelper.LicenciaCifrada)(jsonEnvoltura)

            If objetoCifrado Is Nothing OrElse String.IsNullOrWhiteSpace(objetoCifrado.datos) Then
                MessageBox.Show("El archivo de licencia está corrupto o inválido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Dim jsonDesencriptado As String = LicenciaHelper.Desencriptar(objetoCifrado.datos)
            Dim licencia = JsonConvert.DeserializeObject(Of LicenciaHelper.Licencia)(jsonDesencriptado)

            If licencia Is Nothing Then
                MessageBox.Show("No se pudo cargar la licencia.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            tbnombre.Text = licencia.nombrerazonsocial
            tbemail.Text = licencia.email
            tblicencia.Text = licencia.licencia
            cbperiodo.SelectedValue = licencia.idperiodo
            nucantidad.Value = licencia.cantidad

            If licencia.fechavencimientoserial.HasValue Then
                dtfechavencimiento.Value = licencia.fechavencimientoserial.Value
            End If

            cbestatuslicencia.SelectedValue = licencia.idestatusserial
            tbnombrecontacto.Text = licencia.nombrecontacto
            tbtelefono.Text = licencia.telfonocontacto

            Select Case licencia.idestatusserial
                Case 0
                    btactivar.Text = "ACTIVAR LICENCIA"
                Case 1
                    btactivar.Text = "LICENCIA ACTIVADA"
                Case 2
                    btactivar.Text = "LICENCIA VENCIDA"
                Case 3
                    btactivar.Text = "LICENCIA SUSPENDIDA"
                Case Else
                    btactivar.Text = "ACTIVAR LICENCIA"
            End Select

        Catch ex As Exception
            MessageBox.Show("Error al cargar licencia:" & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = Keys.Space AndAlso Me.ActiveControl Is tblicencia Then
            Return True
        End If

        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub tblicencia_KeyPress(sender As Object, e As KeyPressEventArgs)
        ' tblicencia.Text = tblicencia.Text.ToUpper()
    End Sub

    Private Async Sub btpegar_Click(sender As Object, e As EventArgs) Handles btpegar.Click
        tblicencia.Text = Clipboard.GetText()
        Dim resultado = Await LicenciaHelper.datoslicencia(tblicencia.Text)

        If resultado IsNot Nothing AndAlso resultado.estado = "encontrada" Then
            cbperiodo.SelectedValue = resultado.info.idperiodo
            nucantidad.Value = resultado.info.cantidad
            cbestatuslicencia.SelectedValue = resultado.info.idestatuserial

            Select Case Convert.ToInt32(cbperiodo.SelectedValue)
                Case 0
                    dtfechavencimiento.Value = dtfechavencimiento.Value.AddDays(Convert.ToInt32(nucantidad.Value))
                Case 1
                    dtfechavencimiento.Value = dtfechavencimiento.Value.AddMonths(Convert.ToInt32(nucantidad.Value))
                Case 2
                    dtfechavencimiento.Value = dtfechavencimiento.Value.AddYears(Convert.ToInt32(nucantidad.Value))
            End Select
        Else
            MessageBox.Show("Licencia no encontrada, verifique que la licencia proporcionada es correcta.", "Error de licencia.", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btlimpiar_Click(sender As Object, e As EventArgs) Handles btlimpiar.Click
        tblicencia.Text = ""
        dtfechavencimiento.Value = DateTime.Now
        cbperiodo.SelectedIndex = -1
        nucantidad.Value = 0
    End Sub

    Private Sub FrmRegistrolicencia_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'Dim rutaArchivo As String = Path.Combine(Application.StartupPath, "licencia_cifrada.dat")
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
        ConfigurationManager.RefreshSection("AppSettings")

        'Dim rutaArchivo As String = Path.Combine(Application.StartupPath, "licencia_cifrada.dat")
        Dim rutaArchivo As String = config.AppSettings.Settings("RutaLc").Value.ToString()
        If Not File.Exists(rutaArchivo) Then
            Dim result As DialogResult = MessageBox.Show("El Sistema aun no cuenta con una licencia activa, desea salir?", "Licencia sin activar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Environment.Exit(0)
            ElseIf result = DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

End Class