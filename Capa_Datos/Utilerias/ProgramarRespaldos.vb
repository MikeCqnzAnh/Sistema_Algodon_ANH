Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Imports Microsoft.SqlServer
Public Class ProgramarRespaldos
    Public Overridable Sub Consultar(ByRef EntidadProgramarRespaldos As Capa_Entidad.ProgramarRespaldos)
        Dim EntidadProgramarRespaldos1 As New Capa_Entidad.ProgramarRespaldos()
        EntidadProgramarRespaldos1 = EntidadProgramarRespaldos
        Dim cnn As New SqlConnection(conexionPrincipal)
        EntidadProgramarRespaldos1.TablaConsulta = New DataTable()
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadProgramarRespaldos1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqlcom1 = New SqlCommand("Sp_JobsActivos", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqldat1.Fill(EntidadProgramarRespaldos1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadProgramarRespaldos = EntidadProgramarRespaldos1
        End Try
    End Sub
End Class
