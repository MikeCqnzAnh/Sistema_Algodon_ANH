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
                da = New OleDbDataAdapter("SELECT LTRIM(RTRIM(" & Trim(NomCol) & ")) AS " & Trim(NomCol) & " FROM  [" & Trim(xSheet) & "$] WHERE " & NomCol & " > 0", conn)

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
                da = New OleDbDataAdapter("SELECT LotID	,	BaleID	,	BaleGroup	,	Operator	,	Date	,	Temperature	,	Humidity	,	Amount	,	UHML	,	UI	,	Strength	,	Elongation	,	SFI	,	Maturity	,	Grade	,	Moist	,	Mic	,	Rd	,	PlusB	,	ColorGrade	,	TrashCount	,	TrashArea	,	TrashID	,	SCI	,	Nep	,	UV, KILOS FROM  [" & xSheet & "$]", conn)
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
    Sub importarExcelExternoventa(ByVal tabla As DataGridView)
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
                da = New OleDbDataAdapter("SELECT 	BaleID	,	UHML	,	UI	,	Strength	,	Grade	,	Mic	,	ColorGrade	,	TrashCount	,	TrashArea	,	TrashID	,	KILOS FROM  [" & xSheet & "$]", conn)
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
    Sub importarExcelPacasKilos(ByVal tabla As DataGridView)
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
                da = New OleDbDataAdapter("SELECT 	BaleID	, KILOS FROM  [" & xSheet & "$]", conn)
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
    Sub importarexceltablacastigos(ByVal tabla As DataGridView)
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
            Dim conn As New OleDbConnection
            Try
                xSheet = "Tabla"
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "data source=" & ExcelFile & "; " & "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

                da = New OleDbDataAdapter("SELECT IdModoDetalle,idmodoencabezado,colorgrade,Rango1,Rango2,Castigo,idestatus FROM  [" & xSheet & "$]", conn)
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
    End Sub
    Sub importarexceltablacastequiv(ByVal tabla As DataGridView)
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
            Dim conn As New OleDbConnection
            Try
                xSheet = "Tabla"
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "data source=" & ExcelFile & "; " & "Extended Properties='Excel 12.0 Xml;HDR=Yes'")

                da = New OleDbDataAdapter("SELECT IdLargoFibraDetalle,idmodoencabezado,modocomercializacion,Rango1,Rango2,lenghtnds FROM  [" & xSheet & "$]", conn)
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
