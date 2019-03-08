Imports Capa_Operacion.Configuracion
Public Class ImportarCatalogos
    Private Sub ImportarCatalogos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub
    Private Sub BtIniciar_Click(sender As Object, e As EventArgs) Handles BtIniciar.Click
        ImportarRegistros(CbOrigenInstancia.Text, CbOrigenDB.Text, TbOrigenUsuario.Text, TbOrigenPassword.Text, CbDestinoInstancia.Text, CbDestinoDB.Text, TbDestinoUsuario.Text, TbDestinoPassword.Text)
    End Sub
    Private Sub CbOrigenDB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbOrigenInstancia.SelectedIndexChanged
        cargar_listabd(CbOrigenDB, sender, CbOrigenInstancia.Text, TbOrigenUsuario.Text, TbOrigenPassword.Text)
    End Sub
    Private Sub CbDestinoDB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CbDestinoInstancia.SelectedIndexChanged
        cargar_listabd(CbDestinoDB, sender, CbDestinoInstancia.Text, TbDestinoUsuario.Text, TbDestinoPassword.Text)
    End Sub
    Private Sub BtOrigenLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtOrigenLogin.Click
        LLenaComboInstancias(CbOrigenInstancia)
    End Sub
    Private Sub BtDestinoLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtDestinoLogin.Click
        LLenaComboInstancias(CbDestinoInstancia)
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub CargaTabla()
        DgvTablas.Rows.Clear()
        Dim EntidadCrearEstructura As New Capa_Entidad.CrearEstructura
        Dim NegocioCrearEstructura As New Capa_Negocio.CrearEstructura
        Dim Tabla, Tabla1 As New DataTable
        EntidadCrearEstructura.Consulta = Consulta.ConsultaTablas
        NegocioCrearEstructura.Consultar(EntidadCrearEstructura)
        Tabla = EntidadCrearEstructura.TablaConsulta
        For i As Integer = 0 To Tabla.Rows.Count - 1
            DgvTablas.Rows.Add(Tabla.Rows(i).Item("NombreTabla"))
        Next
    End Sub
    Private Sub PropiedadesDGV()
        DgvTablas.Columns.Clear()
        If DgvTablas.Columns("NombreTabla") Is Nothing Then

            Dim colNombreTabla As New DataGridViewTextBoxColumn
            colNombreTabla.Name = "NombreTabla"
            colNombreTabla.HeaderText = "Nombre de tabla"
            colNombreTabla.ReadOnly = True
            colNombreTabla.Width = 380
            DgvTablas.Columns.Insert(0, colNombreTabla)

            Dim colSel As New DataGridViewCheckBoxColumn()
            colSel.Name = "Sel"
            colSel.HeaderText = ""
            colSel.Width = 40
            DgvTablas.Columns.Insert(1, colSel)
        End If
    End Sub
    Private Sub cargar_listabd(ByVal cmb As ComboBox, ByVal cmb_server As ComboBox, ByVal instancia As String, ByVal usuario As String, ByVal password As String)
        cmb.Items.Clear()
        Dim tabla As New DataTable
        Dim EntidadCrearEstructura As New Capa_Entidad.CrearEstructura
        Dim NegocioCrearEstructura As New Capa_Negocio.CrearEstructura
        EntidadCrearEstructura.Instancia = instancia
        EntidadCrearEstructura.Usuario = usuario
        EntidadCrearEstructura.Password = password
        EntidadCrearEstructura.Consulta = Consulta.ConsultaInstancia
        NegocioCrearEstructura.ConsultarDB(EntidadCrearEstructura)
        tabla = EntidadCrearEstructura.TablaConsulta
        For Each rowServidor In tabla.Rows
            If String.IsNullOrEmpty(rowServidor(“Name”).ToString()) Then
                cmb.Items.Add(rowServidor(“Name”).ToString())
            Else
                cmb.Items.Add(rowServidor(“Name”).ToString())
            End If
        Next
    End Sub
    Private Sub LLenaComboInstancias(ByVal cmb As ComboBox)
        cmb.Items.Clear()
        Dim tabla As New DataTable
        Dim EntidadCrearEstructura As New Capa_Entidad.CrearEstructura
        Dim NegocioCrearEstructura As New Capa_Negocio.CrearEstructura
        EntidadCrearEstructura.Consulta = Consulta.ConsultaInstancia
        NegocioCrearEstructura.Consultar(EntidadCrearEstructura)
        tabla = EntidadCrearEstructura.TablaConsulta
        For Each rowServidor In tabla.Rows
            If String.IsNullOrEmpty(rowServidor(“InstanceName”).ToString()) Then
                cmb.Items.Add(rowServidor(“ServerName”).ToString())
            Else
                cmb.Items.Add(rowServidor(“ServerName”) & “\” & rowServidor(“InstanceName”))
            End If
        Next
    End Sub
    Private Sub Nuevo()
        DgvTablas.Columns.Clear()
        TbOrigenUsuario.Text = ""
        TbOrigenPassword.Text = ""
        CbOrigenInstancia.Text = ""
        CbOrigenInstancia.Items.Clear()
        CbOrigenDB.Text = ""
        CbOrigenDB.Items.Clear()
        TbDestinoUsuario.Text = ""
        TbDestinoPassword.Text = ""
        CbDestinoInstancia.Text = ""
        CbDestinoInstancia.Items.Clear()
        CbDestinoDB.Text = ""
        CbDestinoDB.Items.Clear()
        PropiedadesDGV()
        CargaTabla()
    End Sub
    Private Sub ImportarRegistros(ByVal InstanciaOrigen As String, ByVal BaseDedatosOrigen As String, ByVal UsuarioOrigen As String, ByVal PasswordOrigen As String, ByVal InstanciaDestino As String, ByVal BaseDeDatosDestino As String, ByVal UsuarioDestino As String, ByVal PasswordDestino As String)
        Dim EntidadImportarCatalogos As New Capa_Entidad.ImportarCatalogos
        Dim NegocioImportarCatalogos As New Capa_Negocio.ImportarCatalogos
        Dim tabla As New DataTable
        For Each Fila As DataGridViewRow In DgvTablas.Rows
            If Fila.Cells(1).Value = True And ValidaRegistrosTabla(Fila.Cells(0).Value, InstanciaDestino, BaseDeDatosDestino, UsuarioDestino, PasswordDestino) = 0 Then
                EntidadImportarCatalogos.Campos = GeneraCadenaCampos(Fila.Cells(0).Value)
                EntidadImportarCatalogos.Table = Fila.Cells(0).Value
                EntidadImportarCatalogos.InstanciaDestino = InstanciaDestino
                EntidadImportarCatalogos.InstanciaOrigen = InstanciaOrigen
                EntidadImportarCatalogos.BaseDeDatosOrigen = BaseDedatosOrigen
                EntidadImportarCatalogos.BaseDeDatosDestino = BaseDeDatosDestino
                EntidadImportarCatalogos.PasswordDestino = PasswordDestino
                EntidadImportarCatalogos.UsuarioDestino = UsuarioDestino
                EntidadImportarCatalogos.Importa = Importa.ImportaRegistros
                NegocioImportarCatalogos.Importar(EntidadImportarCatalogos)
            ElseIf Fila.Cells(1).Value = True And ValidaRegistrosTabla(Fila.Cells(0).Value, InstanciaDestino, BaseDeDatosDestino, UsuarioDestino, PasswordDestino) > 0 Then
                Fila.DefaultCellStyle.BackColor = Color.Yellow
            End If
        Next
    End Sub
    Private Function ValidaRegistrosTabla(ByVal NombreTabla As String, ByVal InstanciaDestino As String, ByVal BaseDeDatosDestino As String, ByVal UsuarioDestino As String, ByVal PasswordDestino As String)
        Dim Resultado As Integer
        Dim tabla As New DataTable
        Dim EntidadImportarCatalogos As New Capa_Entidad.ImportarCatalogos
        Dim NegocioImportarCatalogos As New Capa_Negocio.ImportarCatalogos
        EntidadImportarCatalogos.Table = NombreTabla
        EntidadImportarCatalogos.InstanciaDestino = InstanciaDestino
        EntidadImportarCatalogos.BaseDeDatosDestino = BaseDeDatosDestino
        EntidadImportarCatalogos.PasswordDestino = PasswordDestino
        EntidadImportarCatalogos.UsuarioDestino = UsuarioDestino
        EntidadImportarCatalogos.Consulta = Consulta.ConsultaTablas
        NegocioImportarCatalogos.ConsultarBaseExterna(EntidadImportarCatalogos)
        tabla = EntidadImportarCatalogos.TablaConsulta
        Resultado = tabla.Rows(0).Item("Registros")
        Return Resultado
    End Function
    Private Function GeneraCadenaCampos(ByVal NombreTabla As String)
        Dim Resultado As String
        Dim tabla As New DataTable
        Dim EntidadImportarCatalogos As New Capa_Entidad.ImportarCatalogos
        Dim NegocioImportarCatalogos As New Capa_Negocio.ImportarCatalogos

        EntidadImportarCatalogos.Table = NombreTabla
        EntidadImportarCatalogos.Consulta = Consulta.ConsultaTablas
        NegocioImportarCatalogos.Consultar(EntidadImportarCatalogos)
        tabla = EntidadImportarCatalogos.TablaConsulta
        Resultado = tabla.Rows(0).Item("CadenaCampos")
        Return Resultado
    End Function
    Private Sub BtMarcarCheck_Click(sender As Object, e As EventArgs) Handles BtMarcarCheck.Click
        For Each Fila As DataGridViewRow In DgvTablas.Rows
            If Fila.Cells(1).Value = False Then
                Fila.Cells(1).Value = True
            End If
        Next
    End Sub
    Private Sub BtDesmarcar_Click(sender As Object, e As EventArgs) Handles BtDesmarcar.Click
        For Each Fila As DataGridViewRow In DgvTablas.Rows
            If Fila.Cells(1).Value = True Then
                Fila.Cells(1).Value = False
            End If
        Next
    End Sub
End Class