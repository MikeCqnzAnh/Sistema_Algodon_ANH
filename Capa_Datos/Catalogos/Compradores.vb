Imports System.Data.SqlClient
Public Class Compradores
    Public Overridable Sub Upsert(ByRef EntidadCompradores As Capa_Entidad.Compradores)
        Dim EntidadCompradores1 As New Capa_Entidad.Compradores
        EntidadCompradores1 = EntidadCompradores
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("sp_InsertarComprador", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdComprador", EntidadCompradores1.IdComprador))
            cmdGuardar.Parameters.Add(New SqlParameter("@Nombre", EntidadCompradores1.Nombre))
            cmdGuardar.Parameters.Add(New SqlParameter("@Rfc", EntidadCompradores1.Rfc))
            cmdGuardar.Parameters.Add(New SqlParameter("@Curp", EntidadCompradores1.Curp))
            cmdGuardar.Parameters.Add(New SqlParameter("@Domicilio", EntidadCompradores1.Domicilio))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstado", EntidadCompradores1.IdEstado))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdMunicipio", EntidadCompradores1.idMunicipio))
            cmdGuardar.Parameters.Add(New SqlParameter("@Telefono", EntidadCompradores1.Telefono))
            cmdGuardar.Parameters.Add(New SqlParameter("@Correo", EntidadCompradores1.Correo))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdUsuarioCreacion", EntidadCompradores1.IdUsuarioCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@FechaCreacion", EntidadCompradores1.FechaCreacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@IdEstatus", EntidadCompradores1.IdEstatus))
            cmdGuardar.Parameters("@IdComprador").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadCompradores1.IdComprador = 0 Then
                EntidadCompradores1.IdComprador = cmdGuardar.Parameters("@IdComprador").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCompradores = EntidadCompradores1
        End Try
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadCompradores As Capa_Entidad.Compradores)
        Dim EntidadCompradores1 = New Capa_Entidad.Compradores
        EntidadCompradores1 = EntidadCompradores
        EntidadCompradores1.TablaConsulta = New DataTable
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadCompradores1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqldat1 = New SqlDataAdapter("sp_ConsultaBasicaComprador", cnn)
                    sqldat1.Fill(EntidadCompradores1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaEstado
                    sqldat1 = New SqlDataAdapter("sp_ConsultaEstados", cnn)
                    sqldat1.Fill(EntidadCompradores1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaMunicipio
                    sqlcom1 = New SqlCommand("sp_ConsultaMunicipios", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@IdEstadoFisica", EntidadCompradores1.IdEstado))
                    sqldat1.Fill(EntidadCompradores1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadCompradores = EntidadCompradores1
        End Try
    End Sub
End Class
