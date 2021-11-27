Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Data.SqlClient
Public Class RutaDocumentos
    Public Overridable Sub Consultar(ByRef EntidadRutaDocumentos As Capa_Entidad.RutaDocumentos)
        Dim EntidadRutaDocumentos1 As New Capa_Entidad.RutaDocumentos()
        EntidadRutaDocumentos1 = EntidadRutaDocumentos
        Dim cnn As New SqlConnection(conexionPrincipal)
        EntidadRutaDocumentos1.TablaConsulta = New DataTable()
        EntidadRutaDocumentos1.TablaGeneral = New DataTable()
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadRutaDocumentos1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("Sp_ConsultaRutaDocumentos", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqldat1.Fill(EntidadRutaDocumentos1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadRutaDocumentos = EntidadRutaDocumentos1
        End Try
    End Sub
    Public Overridable Sub InsertaRutaDocumentos(ByRef EntidadRutaDocumentos As Capa_Entidad.RutaDocumentos)
        Dim EntidadRutaDocumentos1 As New Capa_Entidad.RutaDocumentos()
        EntidadRutaDocumentos1 = EntidadRutaDocumentos
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Sp_InsertaRutaDocumentos", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUbicacion", EntidadRutaDocumentos1.IdUbicacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@RutaPrincipal", EntidadRutaDocumentos1.RutaPrincipal))
            cmdGuardar.Parameters.Add(New SqlParameter("@NombreCarpetaRaiz", EntidadRutaDocumentos1.NombreCarpetaRaiz))
            cmdGuardar.Parameters.Add(New SqlParameter("@DocumentosProductores", EntidadRutaDocumentos1.DocumentosProductores))
            cmdGuardar.Parameters.Add(New SqlParameter("@DocumentosPersonales", EntidadRutaDocumentos1.DocumentosPersonales))
            cmdGuardar.Parameters.Add(New SqlParameter("@DocumentosLotes", EntidadRutaDocumentos1.DocumentosLotes))
            cmdGuardar.Parameters.Add(New SqlParameter("@ContratosProductores", EntidadRutaDocumentos1.ContratosProductores))
            cmdGuardar.Parameters.Add(New SqlParameter("@ContratosCompradores", EntidadRutaDocumentos1.ContratosCompradores))
            cmdGuardar.Parameters.Add(New SqlParameter("@Anexos", EntidadRutaDocumentos1.Anexos))
            cmdGuardar.Parameters.Add(New SqlParameter("@PreRegistro", EntidadRutaDocumentos1.PreRegistro))
            cmdGuardar.Parameters.Add(New SqlParameter("@ActaParticipacion", EntidadRutaDocumentos1.ActaParticipacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@Temporadas", EntidadRutaDocumentos1.Temporadas))
            cmdGuardar.Parameters.Add(New SqlParameter("@NombreAnual", EntidadRutaDocumentos1.NombreAnual))
            cmdGuardar.Parameters("@IdUbicacion").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadRutaDocumentos1.IdUbicacion = 0 Then
                EntidadRutaDocumentos1.IdUbicacion = cmdGuardar.Parameters("@IdUbicacion").Value
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnn.Close()
            EntidadRutaDocumentos = EntidadRutaDocumentos1
        End Try
    End Sub
End Class
