Imports System.Data.SqlClient
Imports Capa_Operacion.Configuracion
Imports System.Text.RegularExpressions
Public Class Compradores
    Private Sub Compradores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarCombos()
        ConsultaBasicaComprador()
    End Sub

    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Limpiar()
    End Sub

    Private Sub GuardarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarToolStripMenuItem.Click
        Dim EntidadCompradores As New Capa_Entidad.Compradores
        Dim NegocioCompradores As New Capa_Negocio.Compradores
        EntidadCompradores.IdComprador = IIf(TbIdComprador.Text = "", 0, TbIdComprador.Text)
        EntidadCompradores.Nombre = TbNombre.Text
        EntidadCompradores.Rfc = TbRfc.Text
        EntidadCompradores.Curp = TbCurp.Text
        EntidadCompradores.Domicilio = TbDomicilio.Text
        EntidadCompradores.IdEstado = CbEstado.SelectedValue
        EntidadCompradores.idMunicipio = CbMunicipio.SelectedValue
        EntidadCompradores.Telefono = TbTelefono.Text
        EntidadCompradores.Correo = TbCorreo.Text
        EntidadCompradores.IdEstatus = CbEstatus.SelectedValue
        EntidadCompradores.IdUsuarioCreacion = 1
        EntidadCompradores.FechaCreacion = Now
        NegocioCompradores.Guardar(EntidadCompradores)
        TbIdComprador.Text = EntidadCompradores.IdComprador
        MsgBox("Realizado Correctamente")
        ConsultaBasicaComprador()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Limpiar()
        TbIdComprador.Text = ""
        TbNombre.Text = ""
        TbRfc.Text = ""
        TbCurp.Text = ""
        TbDomicilio.Text = ""
        CbEstado.SelectedValue = 6
        CbMunicipio.SelectedValue = 1
        TbTelefono.Text = ""
        TbCorreo.Text = ""
        CbEstatus.SelectedValue = 1
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click

    End Sub

    Private Sub ConsultaBasicaComprador()
        Dim EntidadCompradores As New Capa_Entidad.Compradores
        Dim NegocioCompradores As New Capa_Negocio.Compradores
        Dim Tabla As New DataTable
        'EntidadClientes.IdCliente = ConsultaClientes.IdCliente
        EntidadCompradores.Consulta = Consulta.ConsultaBasica
        NegocioCompradores.Consultar(EntidadCompradores)
        DgvCompradores.DataSource = EntidadCompradores.TablaConsulta
    End Sub

    Private Sub DgvCompradores_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvCompradores.CellContentDoubleClick

    End Sub

    Private Sub LlenarCombos()
        '---------------------------CONSULTA ESTADOS
        Dim tabla As New DataTable
        Dim EntidadCompradores As New Capa_Entidad.Compradores
        Dim NegocioCompradores As New Capa_Negocio.Compradores
        EntidadCompradores.Consulta = Consulta.ConsultaEstado
        NegocioCompradores.Consultar(EntidadCompradores)
        tabla = EntidadCompradores.TablaConsulta
        CbEstado.DataSource = tabla
        CbEstado.ValueMember = "IdEstado"
        CbEstado.DisplayMember = "Descripcion"
        CbEstado.SelectedValue = 6
        '---------------------------CONSULTA MUNICIPIOS       
        Dim tabla2 As New DataTable
        EntidadCompradores.IdEstado = CbEstado.SelectedValue
        EntidadCompradores.Consulta = Consulta.ConsultaMunicipio
        NegocioCompradores.Consultar(EntidadCompradores)
        tabla2 = EntidadCompradores.TablaConsulta
        CbMunicipio.DataSource = tabla2
        CbMunicipio.ValueMember = "IdMunicipio"
        CbMunicipio.DisplayMember = "Descripcion"
        CbMunicipio.SelectedValue = 1
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
    End Sub

    Private Sub TbNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TbTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbTelefono.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub TbRfc_Leave(sender As Object, e As EventArgs) Handles TbRfc.Leave
        If TbRfc.Text <> String.Empty Or TbRfc.Text = String.Empty Then
            If Regex.IsMatch(TbRfc.Text.Trim, "^([A-Z\s]{4})\d{6}([A-Z\w]{3})$") = False Then
                MsgBox("El RFC No es Valido")
                Me.TbRfc.Focus()

            End If
        End If
    End Sub

    Private Sub TbCurp_Leave(sender As Object, e As EventArgs) Handles TbCurp.Leave
        If TbCurp.Text <> String.Empty Or TbCurp.Text = String.Empty Then
            If Regex.IsMatch(TbCurp.Text.Trim, "^[a-zA-Z]{4,4}[0-9]{6}[a-zA-Z]{6,6}[0-9]{2}$") = False Then
                MsgBox("La CURP no es Valida")
                Me.TbCurp.Focus()

            End If
        End If
    End Sub



    Private Sub TbCorreo_Leave(sender As Object, e As EventArgs) Handles TbCorreo.Leave
        If TbCorreo.Text <> String.Empty Or TbCorreo.Text = String.Empty Then
            If Regex.IsMatch(TbCorreo.Text.Trim, "^[_a-z0-9-]+(\.[_a-z0-9-]+)*@[a-z0-9-]+(\.[a-z0-9-]+)*(\.[a-z]{2,4})$") = False Then
                MsgBox("Email no Valido")
                Me.TbCorreo.Focus()
            End If
        End If
    End Sub
End Class