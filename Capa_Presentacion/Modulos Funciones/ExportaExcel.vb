Imports Microsoft.Office.Interop
Module ExportaExcel
    Public Sub ExportExcel(ByVal obj As Object)
        Dim rowsTotal, colsTotal As Integer
        Dim I, j, iC As Integer
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim xlApp As New Excel.Application
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)

            rowsTotal = obj.RowCount
            colsTotal = obj.Columns.Count - 1
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                .Cells.NumberFormat = "@"
                For iC = 0 To colsTotal
                    .Cells(1, iC + 1).Value = obj.Columns(iC).HeaderText
                Next
                For I = 0 To rowsTotal - 1
                    For j = 0 To colsTotal
                        .Cells(I + 2, j + 1).value = obj.Rows(I).Cells(j).Value
                    Next j
                Next I
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12


                .Cells.Columns.AutoFit()
                .Cells.Select()
                .Cells.EntireColumn.AutoFit()
                .Cells(1, 1).Select()
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            'RELEASE ALLOACTED RESOURCES
            xlApp.Visible = True
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub
    Public Sub newexportexcel(dt As DataTable, Optional ByVal tabname As String = "Export")
        Dim arr(dt.Rows.Count, dt.Columns.Count) As Object
        Dim xlApp As New Excel.Application
        Dim r As Integer, c As Integer
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            With excelWorksheet
                .Cells.Select()
                .Cells.Delete()
                .Cells.NumberFormat = "@"
                For r = 0 To dt.Rows.Count
                    For c = 0 To dt.Columns.Count - 1
                        arr(r, c) = dt.Rows(r).Item(c)
                    Next
                Next
                c = 0
                For Each column As DataColumn In dt.Columns
                    excelWorksheet.Cells(1, c + 1) = column.ColumnName
                    c += 1
                Next
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12
                .Name = tabname
                .Cells(1, 1).Select()
            End With
            excelWorksheet.Range(excelWorksheet.Cells(2, 1), excelWorksheet.Cells(dt.Rows.Count, dt.Columns.Count)).Value = arr
            excelWorksheet.Cells.Columns.AutoFit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            xlApp.WindowState = Excel.XlWindowState.xlMaximized
            xlApp.Visible = True

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub
    Public Sub exportdgvtoexcel(dgv As DataGridView, Optional ByVal tabname As String = "Export")
        Dim arr(dgv.Rows.Count, dgv.Columns.Count) As Object
        Dim xlApp As New Excel.Application
        Dim r As Integer, c As Integer
        Try
            Dim excelBook As Excel.Workbook = xlApp.Workbooks.Add
            Dim excelWorksheet As Excel.Worksheet = CType(excelBook.Worksheets(1), Excel.Worksheet)
            With excelWorksheet
                .Cells.Select()
                '.Cells.NumberFormat = "@"
                For r = 0 To dgv.Rows.Count - 1
                    For c = 0 To dgv.Columns.Count - 1
                        arr(r, c) = dgv.Rows(r).Cells(c).Value
                    Next
                Next
                c = 0
                For Each column As DataGridViewColumn In dgv.Columns
                    excelWorksheet.Cells(1, c + 1) = column.HeaderText
                    c += 1
                Next
                .Rows("1:1").Font.FontStyle = "Bold"
                .Rows("1:1").Font.Size = 12
                .Name = tabname
                .Cells(1, 1).Select()
            End With
            excelWorksheet.Range(excelWorksheet.Cells(2, 1), excelWorksheet.Cells(dgv.Rows.Count + 1, dgv.Columns.Count + 1)).Value = arr
            excelWorksheet.Cells.Columns.AutoFit()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            xlApp.WindowState = Excel.XlWindowState.xlMaximized
            xlApp.Visible = True

            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
            xlApp = Nothing
        End Try
    End Sub
End Module
