'Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Capa_Operacion.Configuracion
Public Class Clientes
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombos()
        Limpiar()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        Dim Tabla As New DataTable
        ConsultaClientes.ShowDialog()
        EntidadClientes.IdCliente = ConsultaClientes.IdCliente
        EntidadClientes.Consulta = Consulta.ConsultaDetallada
        NegocioClientes.Consultar(EntidadClientes)
        Tabla = EntidadClientes.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        Try
            TbIdCliente.Text = Tabla.Rows(0).Item("IdCliente")
            TbSocio.Text = Tabla.Rows(0).Item("Socio")
            TbNombre.Text = Tabla.Rows(0).Item("Nombre")
            CbTipoPersona.SelectedValue = Tabla.Rows(0).Item("IdTipoPersona")
            CbEstatus.SelectedValue = Tabla.Rows(0).Item("IdEstatus")
            TbRfcFis.Text = Tabla.Rows(0).Item("RfcFisica")
            TbCurpFis.Text = Tabla.Rows(0).Item("CurpFisica")
            TbCalleFis.Text = Tabla.Rows(0).Item("CalleFisica")
            TbNumeroFis.Text = Tabla.Rows(0).Item("NumeroFisica")
            CbEstadoFis.SelectedValue = Tabla.Rows(0).Item("IdEstadoFisica")
            CbMunicipioFis.SelectedValue = Tabla.Rows(0).Item("IdMunicipioFisica")
            TbColoniaFis.Text = Tabla.Rows(0).Item("ColoniaFisica")
            TbCelularFis.Text = Tabla.Rows(0).Item("CelularFisica")
            TbTelefonoFis.Text = Tabla.Rows(0).Item("TelefonoFisica")
            TbCorreoFis.Text = Tabla.Rows(0).Item("CorreoFisica")
            TbApoderadoFis.Text = Tabla.Rows(0).Item("ApoderadoFisica")
            TbFolioActa.Text = Tabla.Rows(0).Item("FolioActa")
            CbEstadoActa.SelectedValue = Tabla.Rows(0).Item("IdEstadoActa")
            DtpFechaActa.Value = Tabla.Rows(0).Item("FechaActa")
            TbNotarioActa.Text = Tabla.Rows(0).Item("NotarioActa")
            TbRegPubActa.Text = Tabla.Rows(0).Item("RegistroPublicoActa")
            TbNumeroActa.Text = Tabla.Rows(0).Item("NumeroActa")
            TbLibroActa.Text = Tabla.Rows(0).Item("LibroActa")
            TbRfcApoderado.Text = Tabla.Rows(0).Item("RfcApoderado")
            TbCurpApoderado.Text = Tabla.Rows(0).Item("CurpApoderado")
            TbIneApoderado.Text = Tabla.Rows(0).Item("IneApoderado")
            TbCalleApoderado.Text = Tabla.Rows(0).Item("CalleApoderado")
            CbEstadoApoderado.SelectedValue = Tabla.Rows(0).Item("IdEstadoApoderado")
            CbMunicipioApoderado.SelectedValue = Tabla.Rows(0).Item("IdMunicipioApoderado")
            TbTelefonoApoderado.Text = Tabla.Rows(0).Item("TelefonoApoderado")
            TbCelularApoderado.Text = Tabla.Rows(0).Item("CelularApoderado")
            CbEstadoMovilizacion.SelectedValue = Tabla.Rows(0).Item("IdEstadoMovilizacion")
            CbMunicipioMovilizacion.SelectedValue = Tabla.Rows(0).Item("IdMunicipioMovilizacion")
            TbCertificado.Text = Tabla.Rows(0).Item("Certificado")
            TbSuperficie.Text = Tabla.Rows(0).Item("Superficie")
            TbPredio.Text = Tabla.Rows(0).Item("Predio")
            CbCuentaDe.SelectedValue = Tabla.Rows(0).Item("IdCuentaDe")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GeneraRegistroBitacora(Me.Text.Clone.ToString, ConsultarToolStripMenuItem.Text, TbIdCliente.Text, TbNombre.Text)
            Pestañas()
        End Try
    End Sub
    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        Try
            EntidadClientes.IdCliente = IIf(TbIdCliente.Text = "", 0, TbIdCliente.Text)
            EntidadClientes.Socio = TbSocio.Text
            EntidadClientes.Nombre = TbNombre.Text
            EntidadClientes.IdTipoPersona = CbTipoPersona.SelectedValue
            EntidadClientes.RfcFisica = TbRfcFis.Text
            EntidadClientes.CurpFisica = TbCurpFis.Text
            EntidadClientes.CalleFisica = TbCalleFis.Text
            EntidadClientes.NumeroFisica = TbNumeroFis.Text
            EntidadClientes.IdEstadoFisica = CbEstadoFis.SelectedValue
            EntidadClientes.IdMunicipioFisica = CbMunicipioFis.SelectedValue
            EntidadClientes.ColoniaFisica = TbColoniaFis.Text
            EntidadClientes.CelularFisica = TbCelularFis.Text
            EntidadClientes.TelefonoFisica = TbTelefonoFis.Text
            EntidadClientes.CorreoFisica = TbCorreoFis.Text
            EntidadClientes.ApoderadoFisica = TbApoderadoFis.Text
            EntidadClientes.FolioActa = TbFolioActa.Text
            EntidadClientes.IdEstadoActa = CbEstadoActa.SelectedValue
            EntidadClientes.FechaActa = DtpFechaActa.Value
            EntidadClientes.NotarioActa = TbNotarioActa.Text
            EntidadClientes.RegistroPublicoActa = TbRegPubActa.Text
            EntidadClientes.NumeroActa = TbNumeroActa.Text
            EntidadClientes.LibroActa = TbLibroActa.Text
            EntidadClientes.FolioMercantial = TbFolioMercantil.Text
            EntidadClientes.RfcApoderado = TbRfcApoderado.Text
            EntidadClientes.CurpApoderado = TbCurpApoderado.Text
            EntidadClientes.IneApoderado = TbIneApoderado.Text
            EntidadClientes.CalleApoderado = TbCalleApoderado.Text
            EntidadClientes.IdEstadoApoderado = CbEstadoApoderado.SelectedValue
            EntidadClientes.IdMunicipioApoderado = CbMunicipioApoderado.SelectedValue
            EntidadClientes.TelefonoApoderado = TbTelefonoApoderado.Text
            EntidadClientes.CelularApoderado = TbCelularApoderado.Text
            EntidadClientes.CorreoApoderado = TbCorreoApoderado.Text
            EntidadClientes.IdEstadoMovilizacion = CbEstadoMovilizacion.SelectedValue
            EntidadClientes.IdMunicipioMovilizacion = CbMunicipioMovilizacion.SelectedValue
            EntidadClientes.Certificado = TbCertificado.Text
            EntidadClientes.Superficie = TbSuperficie.Text
            EntidadClientes.Predio = TbPredio.Text
            EntidadClientes.IdCuentaDe = CbCuentaDe.SelectedValue
            EntidadClientes.IdUsuarioCreacion = 1
            EntidadClientes.FechaCreacion = Now
            EntidadClientes.IdEstatus = CbEstatus.SelectedValue
            NegocioClientes.Guardar(EntidadClientes)
            TbIdCliente.Text = EntidadClientes.IdCliente
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            GeneraRegistroBitacora(Me.Text.Clone.ToString, IIf(TbIdCliente.Text <> "", "Actualizar", "Guardar"), TbIdCliente.Text, TbNombre.Text)
            MsgBox("Realizado Correctamente")
        End Try
    End Sub
    Private Sub Limpiar()
        TbIdCliente.Text = ""
        TbSocio.Text = ""
        TbNombre.Text = ""
        CbTipoPersona.SelectedValue = 1
        TbRfcFis.Text = ""
        TbCurpFis.Text = ""
        TbCalleFis.Text = ""
        TbNumeroFis.Text = ""
        CbEstadoFis.SelectedValue = 6
        CbMunicipioFis.SelectedValue = 1
        TbColoniaFis.Text = ""
        TbCelularFis.Text = ""
        TbTelefonoFis.Text = ""
        TbCorreoFis.Text = ""
        TbApoderadoFis.Text = ""
        TbFolioActa.Text = ""
        CbEstadoActa.SelectedValue = 6
        DtpFechaActa.Value = Now
        TbNotarioActa.Text = ""
        TbRegPubActa.Text = ""
        TbNumeroActa.Text = ""
        TbLibroActa.Text = ""
        TbFolioMercantil.Text = ""
        TbRfcApoderado.Text = ""
        TbCurpApoderado.Text = ""
        TbIneApoderado.Text = ""
        TbCalleApoderado.Text = ""
        CbEstadoApoderado.SelectedValue = 6
        CbMunicipioApoderado.SelectedValue = 1
        TbTelefonoApoderado.Text = ""
        TbCelularApoderado.Text = ""
        TbCorreoApoderado.Text = ""
        CbEstadoMovilizacion.SelectedValue = 6
        CbMunicipioMovilizacion.SelectedValue = 1
        TbCertificado.Text = ""
        TbSuperficie.Text = ""
        TbPredio.Text = ""
        TPPersonaMoral.Enabled = False
        CbCuentaDe.SelectedValue = 1
        TPPersonaFisica.Enabled = True
        TPPersonaMoral.Enabled = False
        TCTipoPersona.SelectedIndex = 0
    End Sub
    Private Sub LlenarCombos()
        '---------------------------CONSULTA ESTADOS
        Dim tabla As New DataTable
        Dim EntidadClientes As New Capa_Entidad.Clientes
        Dim NegocioClientes As New Capa_Negocio.Clientes
        EntidadClientes.Consulta = Consulta.ConsultaEstado
        NegocioClientes.Consultar(EntidadClientes)
        tabla = EntidadClientes.TablaConsulta
        CbEstadoFis.DataSource = tabla
        CbEstadoFis.ValueMember = "IdEstado"
        CbEstadoFis.DisplayMember = "Descripcion"
        CbEstadoFis.SelectedValue = 6
        '---------------------------CONSULTA MUNICIPIOS       
        Dim tabla2 As New DataTable
        EntidadClientes.IdEstadoFisica = CbEstadoFis.SelectedValue
        EntidadClientes.Consulta = Consulta.ConsultaMunicipio
        NegocioClientes.Consultar(EntidadClientes)
        tabla2 = EntidadClientes.TablaConsulta
        CbMunicipioFis.DataSource = tabla2
        CbMunicipioFis.ValueMember = "IdMunicipio"
        CbMunicipioFis.DisplayMember = "Descripcion"
        CbMunicipioFis.SelectedValue = 1
        '---------------------------CONSULTA TIPO PERSONA
        Dim tabla3 As New DataTable
        EntidadClientes.Consulta = Consulta.ConsultaTipoPersona
        NegocioClientes.Consultar(EntidadClientes)
        tabla3 = EntidadClientes.TablaConsulta
        CbTipoPersona.DataSource = tabla3
        CbTipoPersona.ValueMember = "IdTipoPersona"
        CbTipoPersona.DisplayMember = "Descripcion"
        CbTipoPersona.SelectedValue = 1
        '---------------------------CONSULTA ESTADOS MOVILIZACION
        Dim tabla4 As New DataTable
        EntidadClientes.Consulta = Consulta.ConsultaEstado
        NegocioClientes.Consultar(EntidadClientes)
        tabla4 = EntidadClientes.TablaConsulta
        CbEstadoMovilizacion.DataSource = tabla4
        CbEstadoMovilizacion.ValueMember = "IdEstado"
        CbEstadoMovilizacion.DisplayMember = "Descripcion"
        CbEstadoMovilizacion.SelectedValue = 6
        '---------------------------CONSULTA MUNICIPIOS MOVILIZACION       
        Dim tabla5 As New DataTable
        EntidadClientes.IdEstadoMovilizacion = CbEstadoMovilizacion.SelectedValue
        EntidadClientes.Consulta = Consulta.ConsultaMunicipio
        NegocioClientes.Consultar(EntidadClientes)
        tabla2 = EntidadClientes.TablaConsulta
        CbMunicipioMovilizacion.DataSource = tabla2
        CbMunicipioMovilizacion.ValueMember = "IdMunicipio"
        CbMunicipioMovilizacion.DisplayMember = "Descripcion"
        CbMunicipioMovilizacion.SelectedValue = 1
        '---------------------------CONSULTA ESTADOS MORAL
        Dim tabla6 As New DataTable
        EntidadClientes.Consulta = Consulta.ConsultaEstadoMoral
        NegocioClientes.Consultar(EntidadClientes)
        tabla6 = EntidadClientes.TablaConsulta
        CbEstadoActa.DataSource = tabla6
        CbEstadoActa.ValueMember = "IdEstado"
        CbEstadoActa.DisplayMember = "Descripcion"
        CbEstadoActa.SelectedValue = 6
        '---------------------------CONSULTA ESTADO APODERADO
        Dim tabla7 As New DataTable
        EntidadClientes.Consulta = Consulta.ConsultaEstadoApoderado
        NegocioClientes.Consultar(EntidadClientes)
        tabla7 = EntidadClientes.TablaConsulta
        CbEstadoApoderado.DataSource = tabla7
        CbEstadoApoderado.ValueMember = "IdEstado"
        CbEstadoApoderado.DisplayMember = "Descripcion"
        CbEstadoApoderado.SelectedValue = 6
        '---------------------------CONSULTA MUNICIPIO APODERADO     
        Dim tabla8 As New DataTable
        EntidadClientes.IdEstadoApoderado = CbEstadoApoderado.SelectedValue
        EntidadClientes.Consulta = Consulta.ConsultaMunicipioApoderado
        NegocioClientes.Consultar(EntidadClientes)
        tabla8 = EntidadClientes.TablaConsulta
        CbMunicipioApoderado.DataSource = tabla8
        CbMunicipioApoderado.ValueMember = "IdMunicipio"
        CbMunicipioApoderado.DisplayMember = "Descripcion"
        CbMunicipioApoderado.SelectedValue = 1
        '---------------------------COMBO ESTATUS
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("Id")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("Id") = "1"
        dr("Descripcion") = "Activo"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "2"
        dr("Descripcion") = "Inactivo"
        dt.Rows.Add(dr)
        CbEstatus.DataSource = dt
        CbEstatus.ValueMember = "Id"
        CbEstatus.DisplayMember = "Descripcion"
        CbEstatus.SelectedValue = 1
        '---------------------------CONSULTA ASOCIACIONES   
        Dim tabla9 As New DataTable
        'EntidadClientes.IdEstadoApoderado = CbEstadoApoderado.SelectedValue
        EntidadClientes.Consulta = Consulta.ConsultaAsociaciones
        NegocioClientes.Consultar(EntidadClientes)
        tabla9 = EntidadClientes.TablaConsulta
        CbCuentaDe.DataSource = tabla9
        CbCuentaDe.ValueMember = "IdAsociacion"
        CbCuentaDe.DisplayMember = "Descripcion"
        CbCuentaDe.SelectedValue = 1
    End Sub
    Private Sub CbTipoPersona_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CbTipoPersona.SelectionChangeCommitted
        Pestañas()
    End Sub
    Private Sub Pestañas()
        If CbTipoPersona.SelectedValue = 2 Then
            TPPersonaFisica.Enabled = False
            TPPersonaMoral.Enabled = True
            TCTipoPersona.SelectedIndex = 1
        Else
            TPPersonaFisica.Enabled = True
            TPPersonaMoral.Enabled = False
            TCTipoPersona.SelectedIndex = 0
        End If
    End Sub
    Private Sub TbRfcFis_Leave(sender As Object, e As EventArgs) Handles TbRfcFis.Leave

        If TbRfcFis.Text <> String.Empty Or TbRfcFis.Text = String.Empty Then
            If Regex.IsMatch(TbRfcFis.Text.Trim, "^([A-Z\s]{4})\d{6}([A-Z\w]{3})$") = False Then
                MsgBox("El RFC No es Valido")
                Me.TbRfcFis.Focus()

            End If
        End If
    End Sub

    Private Sub TbCurpFis_Leave(sender As Object, e As EventArgs) Handles TbCurpFis.Leave
        If TbCurpFis.Text <> String.Empty Or TbCurpFis.Text = String.Empty Then
            If Regex.IsMatch(TbCurpFis.Text.Trim, "^[a-zA-Z]{4,4}[0-9]{6}[a-zA-Z]{6,6}[0-9]{2}$") = False Then
                MsgBox("La CURP no es Valida")
                Me.TbCurpFis.Focus()

            End If
        End If
    End Sub

    Private Sub TbCorreoFis_Leave(sender As Object, e As EventArgs) Handles TbCorreoFis.Leave
        If TbCorreoFis.Text <> String.Empty Or TbCorreoFis.Text = String.Empty Then
            If Regex.IsMatch(TbCorreoFis.Text.Trim, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$") = False Then
                MsgBox("Email no Valido")
                Me.TbCorreoFis.Focus()

            End If
        End If
    End Sub

    Private Sub TbNumeroFis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbNumeroFis.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TbCalleFis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbCalleFis.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TbColoniaFis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbColoniaFis.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TbCelularFis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbCelularFis.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TbTelefonoFis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbTelefonoFis.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TbApoderadoFis_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbApoderadoFis.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TbRfcApoderado_Leave(sender As Object, e As EventArgs) Handles TbRfcApoderado.Leave
        If TbRfcApoderado.Text <> String.Empty Or TbRfcApoderado.Text = String.Empty Then
            If Regex.IsMatch(TbRfcApoderado.Text.Trim, "^([A-Z\s]{4})\d{6}([A-Z\w]{3})$") = False Then
                MsgBox("El RFC No es Valido")
                Me.TbRfcApoderado.Focus()

            End If
        End If
    End Sub

    Private Sub TbCurpApoderado_Leave(sender As Object, e As EventArgs) Handles TbCurpApoderado.Leave
        If TbCurpApoderado.Text <> String.Empty Or TbCurpApoderado.Text = String.Empty Then
            If Regex.IsMatch(TbCurpApoderado.Text.Trim, "^[a-zA-Z]{4,4}[0-9]{6}[a-zA-Z]{6,6}[0-9]{2}$") = False Then
                MsgBox("La CURP no es Valida")
                Me.TbCurpApoderado.Focus()

            End If
        End If
    End Sub

    Private Sub TbCorreoApoderado_Leave(sender As Object, e As EventArgs) Handles TbCorreoApoderado.Leave
        If TbCorreoApoderado.Text <> String.Empty Or TbCorreoApoderado.Text = String.Empty Then
            If Regex.IsMatch(TbCorreoApoderado.Text.Trim, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$") = False Then
                MsgBox("Email no Valido")
                Me.TbCorreoApoderado.Focus()
            End If
        End If
    End Sub
End Class