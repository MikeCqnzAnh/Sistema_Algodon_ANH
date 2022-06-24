Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class ConfiguracionParametrosContratos
    Private Sub ConfiguracionParametrosContratos_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cargacombomes(cbmes1compra)
        Cargacombomes(cbmes2compra)
        Cargacombomes(cbmes3compra)
        cargacombodia(cbdia1compra)
        ConsultaParametros()
    End Sub
    Private Sub LimpiarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarToolStripMenuItem.Click
        Cargacombomes(cbmes1compra)
        Cargacombomes(cbmes2compra)
        Cargacombomes(cbmes3compra)
        cargacombodia(cbdia1compra)
        ConsultaParametros()
    End Sub
    Private Sub GuardarActualizarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GuardarActualizarToolStripMenuItem.Click
        Guardar()
    End Sub
    Private Sub Guardar()
        Dim EntidadConfiguracionParametrosContratos As New Capa_Entidad.ConfiguracionParametrosContratos
        Dim NegocioConfiguracionParametrosContratos As New Capa_Negocio.ConfiguracionParametrosContratos
        Try
            EntidadConfiguracionParametrosContratos.IdConfiguracion = IIf(tbidparametrocompra.Text = "", 0, tbidparametrocompra.Text)
            EntidadConfiguracionParametrosContratos.Paramdia1 = cbdia1compra.Text
            EntidadConfiguracionParametrosContratos.ParamMes1 = cbmes1compra.Text
            EntidadConfiguracionParametrosContratos.ParamTemp1 = tbtemporada1compra.Text
            EntidadConfiguracionParametrosContratos.ParamMes2 = cbmes2compra.Text
            EntidadConfiguracionParametrosContratos.ParamTemp2 = tbtemporada2compra.Text
            EntidadConfiguracionParametrosContratos.ParamMes3 = cbmes3compra.Text
            EntidadConfiguracionParametrosContratos.paramprompesomin = nuprommin.Value
            EntidadConfiguracionParametrosContratos.paramprompesomax = nuprommax.Value
            EntidadConfiguracionParametrosContratos.parampesomin = nupesomin.Value
            EntidadConfiguracionParametrosContratos.temporadaanual = tbtemporadapv.Text
            EntidadConfiguracionParametrosContratos.FechaCreacion = Now
            EntidadConfiguracionParametrosContratos.FechaActualizacion = Now
            NegocioConfiguracionParametrosContratos.Guardar(EntidadConfiguracionParametrosContratos)
            tbidparametrocompra.Text = EntidadConfiguracionParametrosContratos.IdConfiguracion
            MsgBox("Realizado Correctamente")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cargacombomes(ByVal cmb As ComboBox)
        '---------------------------COMBO ESTATUS
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("Id")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("Id") = "1"
        dr("Descripcion") = "enero"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "2"
        dr("Descripcion") = "febrero"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "3"
        dr("Descripcion") = "marzo"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "4"
        dr("Descripcion") = "abril"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "5"
        dr("Descripcion") = "mayo"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "6"
        dr("Descripcion") = "junio"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "7"
        dr("Descripcion") = "julio"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "8"
        dr("Descripcion") = "agosto"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "9"
        dr("Descripcion") = "septiembre"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "10"
        dr("Descripcion") = "octubre"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "11"
        dr("Descripcion") = "noviembre"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "12"
        dr("Descripcion") = "diciembre"
        dt.Rows.Add(dr)
        cmb.DataSource = dt
        cmb.ValueMember = "Id"
        cmb.DisplayMember = "Descripcion"
        cmb.SelectedValue = 1
    End Sub
    Private Sub cargacombodia(ByVal cmb As ComboBox)
        '---------------------------COMBO ESTATUS
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("Id")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        Dim x As Integer
        Do
            x = x + 1

            dr = dt.NewRow()
            dr("Id") = x
            dr("Descripcion") = x
            dt.Rows.Add(dr)
        Loop Until (x = 31)

        cmb.DataSource = dt
        cmb.ValueMember = "Id"
        cmb.DisplayMember = "Descripcion"
        cmb.SelectedValue = 1
    End Sub
    Private Sub ConsultaParametros()
        Dim EntidadConfiguracionParametrosContratos As New Capa_Entidad.ConfiguracionParametrosContratos
        Dim NegocioConfiguracionParametrosContratos As New Capa_Negocio.ConfiguracionParametrosContratos
        Dim Tabla As New DataTable
        Try
            EntidadConfiguracionParametrosContratos.Consulta = Consulta.ConsultaBasica
            NegocioConfiguracionParametrosContratos.Consultar(EntidadConfiguracionParametrosContratos)
            Tabla = EntidadConfiguracionParametrosContratos.TablaConsulta
            If Tabla.Rows.Count = 0 Then
                Exit Sub
            End If
            tbidparametrocompra.Text = Tabla.Rows(0).Item("IdConfiguracion")
            cbdia1compra.Text = Tabla.Rows(0).Item("ParamDia1")
            cbmes1compra.Text = Tabla.Rows(0).Item("ParamMes1")
            tbtemporada1compra.Text = Tabla.Rows(0).Item("ParamTemp1")
            cbmes2compra.Text = Tabla.Rows(0).Item("ParamMes2")
            tbtemporada2compra.Text = Tabla.Rows(0).Item("ParamTemp2")
            cbmes3compra.Text = Tabla.Rows(0).Item("ParamMes3")
            nuprommin.Value = Tabla.Rows(0).Item("ParamPrompesomin")
            nuprommax.Value = Tabla.Rows(0).Item("ParamPrompesomax")
            nupesomin.Value = Tabla.Rows(0).Item("ParamPesomin")
            tbtemporadapv.Text = Tabla.Rows(0).Item("TemporadaAnual")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub SoloNumeros_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbtemporada1compra.KeyPress, tbtemporada2compra.KeyPress, tbtemporada1compra.KeyPress, tbtemporadapv.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dispose()
        Close()
    End Sub
End Class