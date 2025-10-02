Imports System.Data.SqlClient
Imports Capa_Entidad
Imports Capa_Operacion.Configuracion
Imports MySql.Data.MySqlClient

Public Class RegistroLicencia
    Public Overridable Sub Consultar(ByRef EntidadRegistroLicencia As Capa_Entidad.RegistroLicencia)
        Dim EntidadRegistroLicencia1 = New Capa_Entidad.RegistroLicencia
        EntidadRegistroLicencia1 = EntidadRegistroLicencia
        EntidadRegistroLicencia1.TablaConsulta = New DataTable
        Dim cnn As New MySqlConnection(conexionPrincipal)
        Dim sqlcom1 As MySqlCommand
        Dim sqldat1 As MySqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadRegistroLicencia1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqlcom1 = New MySqlCommand("SELECT * FROM Registro_serialsw WHERE serialencriptado ='" & EntidadRegistroLicencia1.serialencryp & "'", cnn)
                    sqldat1 = New MySqlDataAdapter(sqlcom1)
                    sqldat1.Fill(EntidadRegistroLicencia1.TablaConsulta)
                    cnn.Close()
                Case Capa_Operacion.Configuracion.Consulta.consultalicencia
                    sqlcom1 = New MySqlCommand("SELECT idperiodo, cantidad, NOW() AS fecha, idestatusserial FROM registro_serialsw WHERE serialorig ='" & EntidadRegistroLicencia1.serialplano & "' AND idestatusserial = 0", cnn)
                    sqldat1 = New MySqlDataAdapter(sqlcom1)
                    sqldat1.Fill(EntidadRegistroLicencia1.TablaConsulta)
                    cnn.Close()
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadRegistroLicencia = EntidadRegistroLicencia1
        End Try
    End Sub
End Class
