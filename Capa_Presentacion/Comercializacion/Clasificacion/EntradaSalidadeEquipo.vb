Imports Capa_Operacion.Configuracion
Imports Capa_Entidad
Imports Capa_Negocio
Public Class EntradaSalidadeEquipo
    Private Sub CbEstatus_SelectedValueChanged(sender As Object, e As EventArgs) Handles CbEstatus.SelectionChangeCommitted
        If CbEstatus.SelectedValue = 1 Then
            tbrecibe.Enabled = True
            tbsolicitante.Enabled = True
            tbentrega.Enabled = True
            tbautoriza.Enabled = False
        ElseIf CbEstatus.SelectedValue = 2 Then
            tbautoriza.Enabled = True
            tbentrega.Enabled = True
            tbsolicitante.Enabled = True
            tbrecibe.Enabled = False
        End If
    End Sub

    Private Sub EntradaSalidadeEquipo_Load(sender As Object, e As EventArgs) Handles Me.Load
        tbautoriza.Enabled = False
        tbentrega.Enabled = False
        tbsolicitante.Enabled = False
        tbrecibe.Enabled = False
        Llenacombos()
    End Sub
    Private Sub Llenacombos()
        Dim dt As DataTable = New DataTable("Tabla")
        dt.Columns.Add("Id")
        dt.Columns.Add("Descripcion")
        Dim dr As DataRow
        dr = dt.NewRow()
        dr("Id") = "1"
        dr("Descripcion") = "ENTRADA"
        dt.Rows.Add(dr)
        dr = dt.NewRow()
        dr("Id") = "2"
        dr("Descripcion") = "SALIDA"
        dt.Rows.Add(dr)
        CbEstatus.DataSource = dt
        CbEstatus.ValueMember = "Id"
        CbEstatus.DisplayMember = "Descripcion"
        CbEstatus.SelectedIndex = -1
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Close()
    End Sub
End Class