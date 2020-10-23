Imports System.IO 'esta libreria nos va a servir para poder activar el commandialog
Imports Microsoft.Office.Interop
Imports System.Data
Imports System.Data.OleDb
Imports System
Imports Microsoft.VisualBasic
Module ImportarExcel
    Sub importarDoc(ByVal tabla As DataGridView)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""
        Dim NomCol As String = ""
        With myFileDialog
            .Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
            .Title = "Open File"
            .ShowDialog()
        End With
        If myFileDialog.FileName.ToString <> "" Then
            Dim ExcelFile As String = myFileDialog.FileName.ToString

            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection

            xSheet = InputBox("Digite el nombre de la Hoja que desea importar", "Complete")
            NomCol = InputBox("Digite el nombre de la Columna que desea importar", "Complete")

            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "data source=" & ExcelFile & "; " & "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

            Try
                da = New OleDbDataAdapter("SELECT LTRIM(RTRIM(" & NomCol & ")) AS " & NomCol & " FROM  [" & xSheet & "$] WHERE " & NomCol & " > 0", conn)

                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                tabla.DataSource = ds
                tabla.DataMember = "MyData"
            Catch ex As Exception
                MsgBox("Inserte un nombre valido de la Hoja que desea importar." & vbCrLf & "DETALLES:" & ex.Message, MsgBoxStyle.Information, "Informacion")
            Finally
                'MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")
                conn.Close()
            End Try
        End If
    End Sub
    Function importarDocPacas(ByVal dt As DataTable)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""
        Dim NomCol As String = ""
        With myFileDialog
            .Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
            .Title = "Open File"
            .ShowDialog()
        End With
        If myFileDialog.FileName.ToString <> "" Then
            Dim ExcelFile As String = myFileDialog.FileName.ToString

            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            'Dim dt As DataTable
            Dim conn As OleDbConnection

            xSheet = InputBox("Digite el nombre de la Hoja que desea importar", "Complete")
            NomCol = InputBox("Digite el nombre de la Columna que desea importar", "Complete")

            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "data source=" & ExcelFile & "; " & "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

            Try
                da = New OleDbDataAdapter("SELECT LTRIM(RTRIM(" & NomCol & ")) AS " & NomCol & " FROM  [" & xSheet & "$] WHERE " & NomCol & " > 0", conn)

                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                'Tabla.DataSource = ds
                'Tabla.DataMember = "MyData"
            Catch ex As Exception
                MsgBox("Inserte un nombre valido de la Hoja que desea importar." & vbCrLf & "DETALLES:" & ex.Message, MsgBoxStyle.Information, "Informacion")
            Finally
                'MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")
                conn.Close()
            End Try
        End If
        Return dt
    End Function
    Sub importarExcelExterno(ByVal tabla As DataGridView)
        Dim myFileDialog As New OpenFileDialog()
        Dim xSheet As String = ""
        With myFileDialog
            .Filter = "Excel Files|*.xls;*.xlsx;*.xlsm"
            .Title = "Open File"
            .ShowDialog()
        End With
        If myFileDialog.FileName.ToString <> "" Then
            Dim ExcelFile As String = myFileDialog.FileName.ToString
            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection
            xSheet = InputBox("Digite el nombre de la Hoja que desea importar", "Complete")
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "data source=" & ExcelFile & "; " & "Extended Properties='Excel 12.0 Xml;HDR=Yes'")
            Try
                da = New OleDbDataAdapter("SELECT * FROM  [" & xSheet & "$]", conn)
                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                tabla.DataSource = ds
                tabla.DataMember = "MyData"
            Catch ex As Exception
                MsgBox("Inserte un nombre valido de la Hoja que desea importar " & ex.Message, MsgBoxStyle.Information, "Informacion")
            Finally
                conn.Close()
            End Try
        End If
        'MsgBox("Se ha cargado la importacion correctamente", MsgBoxStyle.Information, "Importado con exito")
    End Sub
    Sub importarAccessExterno(ByVal tabla As DataGridView)
        Dim myFileDialog As New OpenFileDialog()
        Dim dbAccess As String = ""
        With myFileDialog
            .Filter = "Access Database (*.mdb)|*.mdb| & All Files|*.*"
            .Title = "Open File"
            .ShowDialog()
        End With
        If myFileDialog.FileName.ToString <> "" Then
            Dim AccessFile As String = myFileDialog.FileName.ToString
            Dim ds As New DataSet
            Dim da As OleDbDataAdapter
            Dim dt As DataTable
            Dim conn As OleDbConnection
            dbAccess = InputBox("Digite el nombre de la tabla que desea importar", "Complete", "SystemTestData")
            conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & AccessFile)
            Try
                da = New OleDbDataAdapter("SELECT * FROM " & dbAccess, conn)
                conn.Open()
                da.Fill(ds, "MyData")
                dt = ds.Tables("MyData")
                tabla.DataSource = ds
                tabla.DataMember = "MyData"
            Catch ex As Exception
                MsgBox("Inserte un nombre valido de la tabla que desea importar " & ex.Message, MsgBoxStyle.Information, "Informacion")
            Finally
                conn.Close()
            End Try
        End If
    End Sub
End Module
