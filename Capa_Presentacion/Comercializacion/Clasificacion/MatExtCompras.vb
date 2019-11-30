Imports Capa_Operacion.Configuracion
Public Class MatExtCompras
    Private Sub MatExtCompras_Load(sender As Object, e As EventArgs) Handles Me.Load
        limpiar()
        CastigosMatExt()
        CargaCombos()
    End Sub
    Private Sub NuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoToolStripMenuItem.Click
        limpiar()
    End Sub
    Private Sub CastigosMatExt()
        Dim EntidadCompraPacasContrato As New Capa_Entidad.CompraPacasContrato
        Dim NegocioCompraPacasContrato As New Capa_Negocio.CompraPacasContrato
        Dim Tabla As New DataTable
        EntidadCompraPacasContrato.Consulta = Consulta.ConsultaCastigoMatExtCompra
        NegocioCompraPacasContrato.Consultar(EntidadCompraPacasContrato)
        Tabla = EntidadCompraPacasContrato.TablaConsulta
        NuBarkLevel1.Value = Tabla.Rows(0).Item("Nivel1").ToString
        NuPrepLevel1.Value = Tabla.Rows(1).Item("Nivel1").ToString
        NuOtherLevel1.Value = Tabla.Rows(2).Item("Nivel1").ToString
        NuPlasticLevel1.Value = Tabla.Rows(3).Item("Nivel1").ToString
        NuBarkLevel2.Value = Tabla.Rows(0).Item("Nivel2").ToString
        NuPrepLevel2.Value = Tabla.Rows(1).Item("Nivel2").ToString
        NuOtherLevel2.Value = Tabla.Rows(2).Item("Nivel2").ToString
        NuPlasticLevel2.Value = Tabla.Rows(3).Item("Nivel2").ToString
    End Sub
    Private Sub limpiar()
        RbSinCastigoLevel1.Checked = True
        RbSinCastigoLevel2.Checked = True
        'NuBarkLevel1.Value = 0
        'NuBarkLevel2.Value = 0
        'NuPrepLevel1.Value = 0
        'NuPrepLevel2.Value = 0
        'NuOtherLevel1.Value = 0
        'NuOtherLevel2.Value = 0
        'NuPlasticLevel1.Value = 0
        'NuPlasticLevel2.Value = 0
        TbNoPaca.Text = ""
        CbPlanta.SelectedValue = -1
    End Sub
    Private Sub CargaCombos()
        '---Planta Origen--
        Dim EntidadProduccion As New Capa_Entidad.Produccion
        Dim NegocioProduccion As New Capa_Negocio.Produccion
        Dim Tabla As New DataTable
        EntidadProduccion.Consulta = Consulta.ConsultaExterna
        NegocioProduccion.Consultar(EntidadProduccion)
        Tabla = EntidadProduccion.TablaConsulta
        CbPlanta.DataSource = Tabla
        CbPlanta.ValueMember = "IdPlanta"
        CbPlanta.DisplayMember = "Descripcion"
        CbPlanta.SelectedValue = -1
    End Sub
    Private Sub InsertaPaca()
        'Dim EntidadClasificacionVentaPaquetes As New Capa_Entidad.ClasificacionVentaPaquetes
        'Dim NegocioClasificacionVentaPaquetes As New Capa_Negocio.ClasificacionVentaPaquetes
        'Dim Tabla As New DataTable
        'Dim VerificaDuplicado As Boolean
        'EntidadClasificacionVentaPaquetes.Consulta = Consulta.ConsultaPaca
        'EntidadClasificacionVentaPaquetes.NumeroPaca = CInt(IIf(TbNoPaca.Text = "", 0, TbNoPaca.Text))
        'EntidadClasificacionVentaPaquetes.IdPlanta = CbPlanta.SelectedValue
        'EntidadClasificacionVentaPaquetes.IdPaquete = CInt(IIf(TbIdPaquete.Text = "", 0, TbIdPaquete.Text))
        'NegocioClasificacionVentaPaquetes.Consultar(EntidadClasificacionVentaPaquetes)
        'Tabla = EntidadClasificacionVentaPaquetes.TablaConsulta
        'If Tabla.Rows.Count = 0 Then
        '    MsgBox("La paca no se encuentra en la base de datos HVI.")
        'ElseIf VerificaPacaRepetida(VerificaDuplicado) = False Then
        '    DgvPacas.Rows.Add(0, Tabla.Rows(0).Item("IdOrdenTrabajo"), Tabla.Rows(0).Item("IdPlantaOrigen"), Tabla.Rows(0).Item("LotID"), Tabla.Rows(0).Item("BaleID"), Tabla.Rows(0).Item("BaleGroup"), Tabla.Rows(0).Item("Operator"), Tabla.Rows(0).Item("Date"), Tabla.Rows(0).Item("Temperature"), Tabla.Rows(0).Item("Humidity"), Tabla.Rows(0).Item("Amount"), Tabla.Rows(0).Item("UHML"), Tabla.Rows(0).Item("UI"), Tabla.Rows(0).Item("Strength"), Tabla.Rows(0).Item("Elongation"), Tabla.Rows(0).Item("SFI"), Tabla.Rows(0).Item("Maturity"), Tabla.Rows(0).Item("Grade"), Tabla.Rows(0).Item("Moist"), Tabla.Rows(0).Item("Mic"), Tabla.Rows(0).Item("Rd"), Tabla.Rows(0).Item("Plusb"), Tabla.Rows(0).Item("ColorGrade"), Tabla.Rows(0).Item("TrashCount"), Tabla.Rows(0).Item("TrashArea"), Tabla.Rows(0).Item("TrashID"), Tabla.Rows(0).Item("SCI"), Tabla.Rows(0).Item("Nep"), Tabla.Rows(0).Item("UV"), Tabla.Rows(0).Item("FlagTerminado"))
        'Else
        '    MsgBox("El numero de paca ya se encuentra registrado.")
        'End If
        'DgvPacas.Sort(DgvPacas.Columns("BaleID"), System.ComponentModel.ListSortDirection.Descending)
        'ContarPacas()
        ''IdentificaColor()
        'GeneraPromedioUI()
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class