Imports System.Data.SqlClient
Public Class DatosEmpresa
    Public Overridable Sub Upsert(ByRef EntidadDatosEmpresa As Capa_Entidad.DatosEmpresa)
        Dim EntidadDatosEmpresa1 As New Capa_Entidad.DatosEmpresa
        EntidadDatosEmpresa1 = EntidadDatosEmpresa
        DataBase = EntidadDatosEmpresa1.BaseDeDatos
        Dim cnn As New SqlConnection(conexionPrincipal)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Sp_InsertaDatosEmpresa", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@IdDatosEmpresa", EntidadDatosEmpresa1.IdDatosEmpresa))
            cmdGuardar.Parameters.Add(New SqlParameter("@RazonSocial", EntidadDatosEmpresa1.RazonSocial))
            cmdGuardar.Parameters.Add(New SqlParameter("@RFCEmpresa", EntidadDatosEmpresa1.RfcEmpresa))
            cmdGuardar.Parameters.Add(New SqlParameter("@RepresentanteLegal", EntidadDatosEmpresa1.RepresentanteLegal))
            cmdGuardar.Parameters.Add(New SqlParameter("@RFCRepresentante", EntidadDatosEmpresa1.RfcRepresentante))
            cmdGuardar.Parameters.Add(New SqlParameter("@Calle", EntidadDatosEmpresa1.Calle))
            cmdGuardar.Parameters.Add(New SqlParameter("@NumExt", EntidadDatosEmpresa1.NumExt))
            cmdGuardar.Parameters.Add(New SqlParameter("@NumInt", EntidadDatosEmpresa1.NumInt))
            cmdGuardar.Parameters.Add(New SqlParameter("@EntreCalle1", EntidadDatosEmpresa1.EntreCalle1))
            cmdGuardar.Parameters.Add(New SqlParameter("@EntreCalle2", EntidadDatosEmpresa1.EntreCalle2))
            cmdGuardar.Parameters.Add(New SqlParameter("@Colonia", EntidadDatosEmpresa1.Colonia))
            cmdGuardar.Parameters.Add(New SqlParameter("@Referencia", EntidadDatosEmpresa1.Referencia))
            cmdGuardar.Parameters.Add(New SqlParameter("@Poblacion", EntidadDatosEmpresa1.Poblacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@CodigoPostal", EntidadDatosEmpresa1.CodigoPostal))
            cmdGuardar.Parameters.Add(New SqlParameter("@Pais", EntidadDatosEmpresa1.Pais))
            cmdGuardar.Parameters.Add(New SqlParameter("@Estado", EntidadDatosEmpresa1.Estado))
            cmdGuardar.Parameters.Add(New SqlParameter("@Municipio", EntidadDatosEmpresa1.Municipio))
            cmdGuardar.Parameters.Add(New SqlParameter("@LugarExpedicion", EntidadDatosEmpresa1.LugarExpedicion))

            cmdGuardar.Parameters("@IdDatosEmpresa").Direction = ParameterDirection.InputOutput
            cmdGuardar.ExecuteNonQuery()
            If EntidadDatosEmpresa1.IdDatosEmpresa = 0 Then
                EntidadDatosEmpresa1.IdDatosEmpresa = cmdGuardar.Parameters("@IdDatosEmpresa").Value
            End If
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadDatosEmpresa = EntidadDatosEmpresa1
        End Try
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadDatosEmpresa As Capa_Entidad.DatosEmpresa)
        Dim EntidadDatosEmpresa1 As New Capa_Entidad.DatosEmpresa()
        EntidadDatosEmpresa1 = EntidadDatosEmpresa
        Dim cnn As New SqlConnection(conexionPrincipal)
        EntidadDatosEmpresa1.TablaConsulta = New DataTable()
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadDatosEmpresa1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBaseDatos
                    sqldat1 = New SqlDataAdapter("SELECT database_id, name FROM sys.databases where name like '%Algodon%'", cnn)
                    sqldat1.Fill(EntidadDatosEmpresa1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqlcom1 = New SqlCommand("Sp_ConsultaDatosEmpresa", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    'sqlcom1.Parameters.Add(New SqlParameter("@IdConfiguracion", EntidadDatosEmpresa1.IdConfiguracion))
                    'sqlcom1.Parameters.Add(New SqlParameter("@DireccionIP", EntidadDatosEmpresa1.DireccionIP))
                    sqldat1.Fill(EntidadDatosEmpresa1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaInstancia
                    sqldat1 = New SqlDataAdapter("Sp_obtieneNombreInstancia", cnn)
                    sqldat1.Fill(EntidadDatosEmpresa1.TablaConsulta)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadDatosEmpresa = EntidadDatosEmpresa1
        End Try
    End Sub
End Class
