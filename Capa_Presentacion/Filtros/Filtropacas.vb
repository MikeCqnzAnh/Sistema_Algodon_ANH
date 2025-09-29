Imports Capa_Operacion

Public Class Filtropacas
    Public Property _idplanta As String
    Public Property _idlogistica As String
    Public Property _idcv As String
    Public Property _predio As String
    Public Property _grade As String
    Public Property _colorgrade As String
    Public Property _baleidinicio As String
    Public Property _baleidfin As String
    Public Property _r1mic As Decimal
    Public Property _r2mic As Decimal
    Public Property _r1strength As Decimal
    Public Property _r2strength As Decimal
    Public Property _r1uhml As Decimal
    Public Property _r2uhml As Decimal
    Public Property _r1ui As Decimal
    Public Property _r2ui As Decimal
    Public Sub New(idlogistica As Integer, idcv As Integer, activactrl As Boolean)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        lbnolote.Visible = activactrl
        cblote.Visible = activactrl
        _idcv = idcv
        _idlogistica = idlogistica
        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
    Private Sub Filtropacas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargacombogins()
        cargacombolotes()
        'cargacombotemporadas()
        'cargacombozonas()
        cargacombogrados()
    End Sub
    Private Sub btaceptar_Click(sender As Object, e As EventArgs) Handles btaceptar.Click
        Try
            If ValidateRange(numicr1, numicr2) AndAlso ValidateRange(nustrr1, nustrr2) AndAlso ValidateRange(nuuhmlr1, nuuhmlr2) AndAlso ValidateRange(nuuir1, nuuir2) Then
                _idplanta = IIf(cbgin.Text = "", 0, cbgin.SelectedValue)
                _grade = cbgrade.Text
                _colorgrade = cbcolorgrade.Text
                _predio = tbpredio.Text
                _baleidinicio = tbbaleidinicio.Text
                _baleidfin = tbbaleidfin.Text
                _r1mic = numicr1.Value
                _r2mic = numicr2.Value
                _r1strength = nustrr1.Value
                _r2strength = nustrr2.Value
                _r1uhml = nuuhmlr1.Value
                _r2uhml = nuuhmlr2.Value
                _r1ui = nuuir1.Value
                _r2ui = nuuir2.Value
                Me.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btcancelar_Click(sender As Object, e As EventArgs) Handles btcancelar.Click
        Me.Close()
    End Sub

    Private Sub cargacombozonas()
        'Dim ecatalogos As New E_Catalogos()
        'Dim ncatalogos As New N_Catalogos()
        'ecatalogos.Consultar = Configuracion.Consulta.consultacmbzonas
        'ncatalogos.Consultar(ecatalogos)
        'If ecatalogos.TablaConsulta.Rows.Count > 0 Then
        '    cbzona.DataSource = ecatalogos.TablaConsulta
        '    cbzona.ValueMember = "Idzona"
        '    cbzona.DisplayMember = "Descripcion"
        '    cbzona.SelectedIndex = -1
        'End If
    End Sub

    Private Sub cargacombogins()
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        cbgin.DataSource = Tabla
        cbgin.ValueMember = "IdPlanta"
        cbgin.DisplayMember = "Descripcion"
        cbgin.SelectedValue = 0
    End Sub

    Private Sub cargacombolotes()
        'If cblote.Visible = True Then
        '    Dim elogistica As New E_Logistica()
        '    Dim nlogistica As New N_Logistica()
        '    elogistica.Consultar = O_Configuracion.Consultar.consultacmblote
        '    elogistica.idembarque = _idembarque
        '    elogistica.idcliente = _idcliente
        '    nlogistica.Consultar(elogistica)
        '    If elogistica.TablaConsulta.Rows.Count > 0 Then
        '        cblote.DataSource = elogistica.TablaConsulta
        '        cblote.ValueMember = "idlote"
        '        cblote.DisplayMember = "nolote"
        '        cblote.SelectedIndex = -1
        '    End If
        'End If
    End Sub

    Private Sub cargacombogrados()
        '---Clasificacion--
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla2 As New DataTable
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaClases
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla2 = EntidadClasificacionVentaPaquetes.TablaConsulta
        cbgrade.DataSource = Tabla2
        cbgrade.ValueMember = "IdClasificacion"
        cbgrade.DisplayMember = "ClaveCorta"
        cbgrade.SelectedValue = 0
    End Sub

    Private Sub cargacombocolorgrade()
        Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        Dim Tabla2 As New DataTable
        EntidadClasificacionVentaPaquetes.Consulta = Consulta.consultacolorgrade
        EntidadClasificacionVentaPaquetes.IdClase = cbgrade.SelectedValue
        NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        Tabla2 = EntidadClasificacionVentaPaquetes.TablaConsulta
        If Tabla2.Rows.Count > 0 Then
            cbcolorgrade.DataSource = Tabla2
            cbcolorgrade.ValueMember = "gradocolor"
            cbcolorgrade.DisplayMember = "gradocolor"
            cbcolorgrade.SelectedValue = 0
        End If
    End Sub

    Private Sub cbgrade_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbgrade.SelectionChangeCommitted
        cargacombocolorgrade()
    End Sub

    ' Método genérico para validar el rango entre dos NumericUpDown
    Private Function ValidateRange(num1 As NumericUpDown, num2 As NumericUpDown) As Boolean
        Dim retorna As Boolean = False

        If num1.Value > num2.Value Then
            MessageBox.Show("El rango 1 no puede ser mayor que el rango 2")
            num1.Value = num2.Value
            retorna = False
        Else
            retorna = True
        End If
        Return retorna
    End Function

    ' Método para conectar eventos de validación de rango a un par de NumericUpDown
    Private Sub ConnectRangeValidationEvents(num1 As NumericUpDown, num2 As NumericUpDown)
        AddHandler num1.ValueChanged, Sub(sender, e) ValidateRange(num1, num2)
        AddHandler num2.ValueChanged, Sub(sender, e) ValidateRange(num1, num2)
    End Sub

    Private Sub solonumeros(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btconsultapredio_Click(sender As Object, e As EventArgs) Handles btconsultapredio.Click
        'Dim _predios As New FrmConsultaPredios()
        '_predios.ShowDialog()
        'If _predios._idpredio > 0 Then
        '    tbpredio.Text = _predios._descripcion.ToString()
        'End If
    End Sub

    Private Sub tbbaleidfin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbbaleidinicio.KeyPress, tbbaleidfin.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class