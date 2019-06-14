Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class Respaldos
    Public Overridable Sub Generar(ByRef EntidadRespaldos As Capa_Entidad.Respaldos)
        Dim EntidadRespaldos1 As New Capa_Entidad.Respaldos
        EntidadRespaldos1 = EntidadRespaldos
        Dim sBackup As String = "BACKUP DATABASE " & EntidadRespaldos1.BaseDedatosOrigen & " TO DISK = N'" & EntidadRespaldos1.RutaRespaldo & "\" & EntidadRespaldos1.NombreRespaldo & "'  With NOFORMAT, NOINIT, NAME =N'" & EntidadRespaldos1.BaseDedatosOrigen & "-Full Database Backup',SKIP, STATS = 10"

        Using cnn As New SqlConnection(conexionPrincipal)
            Try
                cnn.Open()

                Dim cmdBackUp As New SqlCommand(sBackup, cnn)

                cmdBackUp.ExecuteNonQuery()

                MsgBox("Se ha creado un BackUp de La base de datos satisfactoria Copia de seguridad de base de datos")

                cnn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub
End Class
