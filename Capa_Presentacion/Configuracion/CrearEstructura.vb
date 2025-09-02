Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class CrearEstructura
    Private TablaExportar As New DataTable
    Private _baseDatos As String
    Public Property BaseDatos() As String
        Get
            Return _baseDatos
        End Get
        Set(value As String)
            _baseDatos = value
        End Set
    End Property
    Private _Instancia As String
    Public Property Instancia() As String
        Get
            Return _Instancia
        End Get
        Set(value As String)
            _Instancia = value
        End Set
    End Property
    Private Sub CrearEstructura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        Nuevo()
    End Sub
    Private Sub BtCrearDB_Click(sender As Object, e As EventArgs) Handles BtCrearDB.Click
        CrearBDD()
    End Sub
    Private Sub BtCrearTablas_Click(sender As Object, e As EventArgs) Handles BtCrearTablas.Click
        CreaTablas(CbDestinoInstancia.Text, CbDestinoDB.Text, TbDestinoUsuario.Text, TbDestinoPassword.Text)
    End Sub
    Private Sub BtCrearProcedimientos_Click(sender As Object, e As EventArgs) Handles BtCrearProcedimientos.Click
        CreaProcedimientos(CbDestinoInstancia.Text, CbDestinoDB.Text, TbDestinoUsuario.Text, TbDestinoPassword.Text)
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
    Private Sub BaseReciente()
        Dim EntidadCrearEstructura As New Capa_Entidad.CrearEstructura
        Dim NegocioCrearEstructura As New Capa_Negocio.CrearEstructura
        Dim Tabla As New DataTable
        EntidadCrearEstructura.Consulta = Consulta.ConsultaBaseDatosReciente
        NegocioCrearEstructura.Consultar(EntidadCrearEstructura)
        Tabla = EntidadCrearEstructura.TablaConsulta
        If Tabla.Rows.Count = 0 Then
            Exit Sub
        End If
        TbReciente.Text = Tabla.Rows(0).Item("name")
    End Sub
    Private Sub CrearBDD()
        Dim BaseDeDatos As String = TbAlgodon.Text & TbYear.Text

        Dim EntidadCrearEstructura As New Capa_Entidad.CrearEstructura
        Dim NegocioCrearEstructura As New Capa_Negocio.CrearEstructura
        EntidadCrearEstructura.BaseDeDatos = BaseDeDatos
        NegocioCrearEstructura.Guardar(EntidadCrearEstructura)
        MsgBox("Realizado Correctamente")
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
    Private Sub CreaBDD(ByVal Table As String, ByVal instancia As String, ByVal BaseDeDatos As String, ByVal usuario As String, ByVal password As String)
        Dim tabla As New DataTable
        Dim EntidadCrearEstructura As New Capa_Entidad.CrearEstructura
        Dim NegocioCrearEstructura As New Capa_Negocio.CrearEstructura
        EntidadCrearEstructura.Table = Table
        EntidadCrearEstructura.Instancia = instancia
        EntidadCrearEstructura.BaseDeDatos = BaseDeDatos
        EntidadCrearEstructura.Usuario = usuario
        EntidadCrearEstructura.Password = password
        NegocioCrearEstructura.GuardarTablasEstructura(EntidadCrearEstructura)
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
        Dim ii As Integer = 0
        For Each Fila As DataGridViewRow In DgvTablas.Rows
            EntidadCrearEstructura.Table = Fila.Cells(0).Value
            EntidadCrearEstructura.Consulta = Consulta.ConsultaCreateTable
            NegocioCrearEstructura.Consultar(EntidadCrearEstructura)
            Tabla1 = EntidadCrearEstructura.TablaGeneral
            DgvTablas.Item(1, DgvTablas.Rows(ii).Index).Value = Tabla1.Rows(0).Item("Rutina")
            ii = ii + 1
        Next
    End Sub
    Private Sub CargaProcedimientos()
        DgvProcedimientos.Rows.Clear()
        Dim EntidadCrearEstructura As New Capa_Entidad.CrearEstructura
        Dim NegocioCrearEstructura As New Capa_Negocio.CrearEstructura
        Dim Tabla, Tabla1 As New DataTable
        EntidadCrearEstructura.Consulta = Consulta.ConsultaProcedimientos
        NegocioCrearEstructura.Consultar(EntidadCrearEstructura)
        Tabla = EntidadCrearEstructura.TablaConsulta
        For i As Integer = 0 To Tabla.Rows.Count - 1
            DgvProcedimientos.Rows.Add(Tabla.Rows(i).Item("NombreProcedimiento"))
        Next
        Dim ii As Integer = 0
        For Each Fila As DataGridViewRow In DgvProcedimientos.Rows
            EntidadCrearEstructura.Procedimiento = Fila.Cells(0).Value
            EntidadCrearEstructura.Consulta = Consulta.ConsultaCreateProcedure
            NegocioCrearEstructura.Consultar(EntidadCrearEstructura)
            Tabla1 = EntidadCrearEstructura.TablaGeneral
            DgvProcedimientos.Item(1, DgvProcedimientos.Rows(ii).Index).Value = Tabla1.Rows(0).Item("Rutina")
            ii = ii + 1
        Next
    End Sub
    Private Sub PropiedadesDGV()
        DgvTablas.Columns.Clear()
        DgvProcedimientos.Columns.Clear()

        If DgvTablas.Columns("NombreTabla") Is Nothing Then

            Dim colNombreTabla As New DataGridViewTextBoxColumn
            colNombreTabla.Name = "NombreTabla"
            colNombreTabla.HeaderText = "Nombre de tabla"
            DgvTablas.Columns.Insert(0, colNombreTabla)

            Dim colRutina As New DataGridViewTextBoxColumn
            colRutina.Name = "Rutina"
            DgvTablas.Columns.Insert(1, colRutina)

            Dim colSel As New DataGridViewCheckBoxColumn()
            colSel.Name = "Sel"
            colSel.HeaderText = ""
            colSel.Width = 40
            DgvTablas.Columns.Insert(2, colSel)
        End If
        If DgvProcedimientos.Columns("NombreProcedimiento") Is Nothing Then

            Dim colNombreProcedimiento As New DataGridViewTextBoxColumn
            colNombreProcedimiento.Name = "NombreProcedimiento"
            colNombreProcedimiento.HeaderText = "Nombre de procedimiento"
            DgvProcedimientos.Columns.Insert(0, colNombreProcedimiento)

            Dim colRutina As New DataGridViewTextBoxColumn
            colRutina.Name = "Rutina"
            DgvProcedimientos.Columns.Insert(1, colRutina)

            Dim colSel As New DataGridViewCheckBoxColumn()
            colSel.Name = "Sel"
            colSel.HeaderText = ""
            colSel.Width = 40
            DgvProcedimientos.Columns.Insert(2, colSel)
        End If
    End Sub
    Private Sub CreaTablas(ByVal instancia As String, ByVal BaseDeDatos As String, ByVal usuario As String, ByVal password As String)
        Dim EntidadCrearEstructura As New Capa_Entidad.CrearEstructura
        Dim NegocioCrearEstructura As New Capa_Negocio.CrearEstructura
        Try
            For Each Fila As DataGridViewRow In DgvTablas.Rows
                If Fila.Cells(2).Value = True Then
                    EntidadCrearEstructura.Instancia = instancia
                    EntidadCrearEstructura.BaseDeDatos = BaseDeDatos
                    EntidadCrearEstructura.Usuario = usuario
                    EntidadCrearEstructura.Password = password
                    EntidadCrearEstructura.Table = Fila.Cells("NombreTabla").Value
                    EntidadCrearEstructura.Rutina = Fila.Cells("Rutina").Value
                    EntidadCrearEstructura.Importa = Importa.ImportaTabla
                    NegocioCrearEstructura.Importa(EntidadCrearEstructura)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MsgBox("Realizado Correctamente")
        End Try
    End Sub
    Private Sub CreaProcedimientos(ByVal instancia As String, ByVal BaseDeDatos As String, ByVal usuario As String, ByVal password As String)
        Dim EntidadCrearEstructura As New Capa_Entidad.CrearEstructura
        Dim NegocioCrearEstructura As New Capa_Negocio.CrearEstructura
        Try
            For Each Fila As DataGridViewRow In DgvProcedimientos.Rows
                If Fila.Cells(2).Value = True Then
                    EntidadCrearEstructura.Instancia = instancia
                    EntidadCrearEstructura.BaseDeDatos = BaseDeDatos
                    EntidadCrearEstructura.Usuario = usuario
                    EntidadCrearEstructura.Password = password
                    EntidadCrearEstructura.Procedimiento = Fila.Cells("NombreProcedimiento").Value
                    EntidadCrearEstructura.Rutina = Fila.Cells("Rutina").Value
                    EntidadCrearEstructura.Importa = Importa.ImportaProcedimiento
                    NegocioCrearEstructura.Importa(EntidadCrearEstructura)
                End If
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MsgBox("Realizado Correctamente")
        End Try
    End Sub
    Private Sub Nuevo()
        TbAlgodon.Text = ""
        TbReciente.Text = ""
        TbYear.Text = ""
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
        DgvTablas.Columns.Clear()
        DgvProcedimientos.Columns.Clear()
        TbYear.Text = Now.Year + 1
        TbAlgodon.Text = "ALGODON"
        BaseReciente()
        PropiedadesDGV()
        CargaTabla()
        CargaProcedimientos()
    End Sub
    Private Sub BtSeleccionTablas_Click(sender As Object, e As EventArgs) Handles BtSeleccionTablas.Click
        For Each Fila As DataGridViewRow In DgvTablas.Rows
            If Fila.Cells(2).Value = False Then
                Fila.Cells(2).Value = True
            End If
        Next
    End Sub
    Private Sub BtDeseleccionTablas_Click(sender As Object, e As EventArgs) Handles BtDeseleccionTablas.Click
        For Each Fila As DataGridViewRow In DgvTablas.Rows
            If Fila.Cells(2).Value = True Then
                Fila.Cells(2).Value = False
            End If
        Next
    End Sub
    Private Sub BtSeleccionProcedimientos_Click(sender As Object, e As EventArgs) Handles BtSeleccionProcedimientos.Click
        For Each Fila As DataGridViewRow In DgvProcedimientos.Rows
            If Fila.Cells(2).Value = False Then
                Fila.Cells(2).Value = True
            End If
        Next
    End Sub
    Private Sub BtDeseleccionProcedimientos_Click(sender As Object, e As EventArgs) Handles BtDeseleccionProcedimientos.Click
        For Each Fila As DataGridViewRow In DgvProcedimientos.Rows
            If Fila.Cells(2).Value = True Then
                Fila.Cells(2).Value = False
            End If
        Next
    End Sub

    Private Sub GbCreaBdd_Enter(sender As Object, e As EventArgs) Handles GbCreaBdd.Enter

    End Sub
End Class