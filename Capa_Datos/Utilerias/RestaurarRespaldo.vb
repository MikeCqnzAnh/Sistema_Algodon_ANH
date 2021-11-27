Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class RestaurarRespaldo
    Public Overridable Sub Restaurar(ByRef EntidadRestaurarRespaldo As Capa_Entidad.RestaurarRespaldo)
        Dim EntidadRestaurarRespaldo1 As New Capa_Entidad.RestaurarRespaldo
        EntidadRestaurarRespaldo1 = EntidadRestaurarRespaldo
        Dim sBackup As String = "ALTER DATABASE " & EntidadRestaurarRespaldo1.BaseDedatosOrigen & " SET SINGLE_USER WITH ROLLBACK IMMEDIATE; RESTORE DATABASE " & EntidadRestaurarRespaldo1.BaseDedatosOrigen & " FROM DISK = '" & EntidadRestaurarRespaldo1.RutaArchivoRespaldo & "'" & " WITH REPLACE; ALTER DATABASE " & EntidadRestaurarRespaldo1.BaseDedatosOrigen & " SET MULTI_USER "
        Using cnn As New SqlConnection(conexionMasterRestaurar)
            Try
                cnn.Open()

                Dim cmdBackUp As New SqlCommand(sBackup, cnn)

                cmdBackUp.ExecuteNonQuery()

                MsgBox("Se ha restaurado la copia de la base de datos.")

                cnn.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Using
    End Sub
End Class
