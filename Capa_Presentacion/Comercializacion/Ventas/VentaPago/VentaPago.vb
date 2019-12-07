Imports Capa_Operacion.Configuracion
Public Class VentaPago
    Dim IdModalidadVenta, IdunidadPeso As Integer
    Dim ValorConversion As Double
    Private Sub CompraPago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarControles()
        TbIdComprador.Text = VarGlob2.IdComprador
        TbNombreComprador.Text = VarGlob2.NombreComprador
        TbPrecioQuintal.Text = VarGlob2.PrecioQuintal
        TbIdContrato.Text = VarGlob2.IdContrato
        TbIdVenta.Text = VarGlob2.IdVenta
        IdModalidadVenta = VarGlob2.IdModalidadVenta
        IdunidadPeso = VarGlob2.IdUnidadPeso
        ValorConversion = VarGlob2.ValorConversion

        DgvResumenPagoPacas.Columns.Clear()
        DgvResumenPagoPacas.DataSource = _Tabla
        SumasTotales()
        Formatos()
    End Sub
    Private Sub PropiedadesDgv()
        DgvResumenPagoPacas.Columns(4).Visible = False
        DgvResumenPagoPacas.Columns(5).Visible = False
        DgvResumenPagoPacas.Columns(6).Visible = False
        DgvResumenPagoPacas.Columns(7).Visible = False
        DgvResumenPagoPacas.Columns(8).Visible = False
    End Sub
    Private Sub LimpiarControles()
        TbPrecioQuintal.Text = 0
        TbIdComprador.Text = ""
        TbNombreComprador.Text = ""
        DgvResumenPagoPacas.DataSource = ""
        DgvResumenPagoPacas.Columns.Clear()
        TbTipoCambio.Text = 0
        TbSubtotal.Text = 0
        TbTotalMxn.Text = 0
        TbTotalPacas.Text = 0
        TbTotalKilos.Text = 0
        TbCastigoxlargo.Text = 0
        TbCastigoxmicro.Text = 0
        TbCastigoxresistencia.Text = 0
        TbCastigoxUI.Text = 0
    End Sub
    Private Sub SumasTotales()
        Dim Word As String = "Total"
        For Each row As DataGridViewRow In DgvResumenPagoPacas.Rows
            Dim Index As Integer = Convert.ToUInt64(row.Index)
            If (row.Cells("Clase").Value).ToString.Contains(Word) Then
                TbTotalPacas.Text = Val(CInt(TbTotalPacas.Text) + CDbl(row.Cells("Cantidad").Value))
                TbTotalKilos.Text = Val(TbTotalKilos.Text + CDbl(row.Cells("Kilos").Value))
                row.DefaultCellStyle.BackColor = Color.Gray
                Dim font = DgvResumenPagoPacas.DefaultCellStyle.Font
                row.DefaultCellStyle.Font = New Font(font, font.Style Or FontStyle.Bold)
            End If
        Next
    End Sub

    Private Sub Formatos()
        Dim TotalKilos As Double
        TotalKilos = TbTotalKilos.Text
        TbTotalKilos.Text = String.Format("{0:N0}", TotalKilos)
        TbEfectivo.Text = FormatCurrency(TbEfectivo.Text)
        TbSubtotal.Text = FormatCurrency(TbSubtotal.Text)
        TbDescuento.Text = FormatCurrency(TbDescuento.Text)
        TbTotal.Text = FormatCurrency(TbTotal.Text)
        TbTipoCambio.Text = FormatCurrency(TbTipoCambio.Text)
        DgvResumenPagoPacas.Columns("Clase").ReadOnly = True
    End Sub

    Private Sub PagarItem_Click(sender As Object, e As EventArgs)
        Dim opc = MessageBox.Show("¿Estas seguro de cerrar esta compra?", "", MessageBoxButtons.YesNo)
        If opc = DialogResult.Yes Then

        Else
            Exit Sub
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Close()
    End Sub
End Class