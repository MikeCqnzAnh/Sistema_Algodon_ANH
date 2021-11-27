Imports Capa_Entidad
Imports Capa_Operacion
Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Text
Imports Microsoft.Office.Interop
Imports Microsoft.SqlServer

Public Class Bitacora
    Public Overridable Sub Consultar(ByRef EntidadBitacora As Capa_Entidad.Bitacora)
        Dim EntidadBitacora1 As New Capa_Entidad.Bitacora()
        EntidadBitacora1 = EntidadBitacora
        Dim cnn As New SqlConnection(conexionPerfiles)
        EntidadBitacora1.TablaConsulta = New DataTable()
        EntidadBitacora1.TablaGeneral = New DataTable()
        Dim sqlcom1 As SqlCommand
        Dim sqldat1 As SqlDataAdapter
        Try
            cnn.Open()
            Select Case EntidadBitacora1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaDetallada
                    sqlcom1 = New SqlCommand("Sp_ConsultaBitacora", cnn)
                    sqldat1 = New SqlDataAdapter(sqlcom1)
                    sqlcom1.CommandType = CommandType.StoredProcedure
                    sqlcom1.Parameters.Clear()
                    sqlcom1.Parameters.Add(New SqlParameter("@Fechainicio", EntidadBitacora1.FechaInicio))
                    sqlcom1.Parameters.Add(New SqlParameter("@FechaFin", EntidadBitacora1.FechaFin))
                    sqlcom1.Parameters.Add(New SqlParameter("@Usuario", EntidadBitacora1.Usuario))
                    sqlcom1.Parameters.Add(New SqlParameter("@Modulo", EntidadBitacora1.Modulo))
                    sqlcom1.Parameters.Add(New SqlParameter("@Operacion", EntidadBitacora1.Operacion))
                    sqldat1.Fill(EntidadBitacora1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaUsuario
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaBitacoraUsuario", cnn)
                    sqldat1.Fill(EntidadBitacora1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaBitacoraModulo", cnn)
                    sqldat1.Fill(EntidadBitacora1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaExterna
                    sqldat1 = New SqlDataAdapter("Sp_ConsultaBitacoraOperacion", cnn)
                    sqldat1.Fill(EntidadBitacora1.TablaConsulta)
                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaInstancia
                    '    Dim servidores As SqlDataSourceEnumerator
                    '    servidores = SqlDataSourceEnumerator.Instance
                    '    EntidadBitacora1.TablaConsulta = servidores.GetDataSources()

                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaProcedimientos
                    '    sqldat1 = New SqlDataAdapter("sp_listaProcedimientos", cnn)
                    '    sqldat1.Fill(EntidadBitacora1.TablaConsulta)

                    'Case Capa_Operacion.Configuracion.Consulta.ConsultaCreateProcedure
                    '    sqlcom1 = New SqlCommand("sp_GeneraCreateProcedure", cnn)
                    '    sqldat1 = New SqlDataAdapter(sqlcom1)
                    '    sqlcom1.CommandType = CommandType.StoredProcedure
                    '    sqlcom1.Parameters.Clear()
                    '    sqlcom1.Parameters.Add(New SqlParameter("@NombreProcedimiento", EntidadBitacora1.Procedimiento))
                    '    sqldat1.Fill(EntidadBitacora1.TablaGeneral)
            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cnn.Close()
            EntidadBitacora = EntidadBitacora1
        End Try
    End Sub
    Public Overridable Sub InsertaBitacora(ByRef EntidadBitacora As Capa_Entidad.Bitacora)
        Dim EntidadBitacora1 As New Capa_Entidad.Bitacora()
        EntidadBitacora1 = EntidadBitacora
        Dim cnn As New SqlConnection(conexionPerfiles)
        Dim cmdGuardar As SqlCommand
        Try
            cnn.Open()
            cmdGuardar = New SqlCommand("Sp_InsertaBitacora", cnn)
            cmdGuardar.CommandType = CommandType.StoredProcedure
            cmdGuardar.Parameters.Add(New SqlParameter("@fecha", EntidadBitacora1.Fecha))
            cmdGuardar.Parameters.Add(New SqlParameter("@computadora", EntidadBitacora1.Computadora))
            cmdGuardar.Parameters.Add(New SqlParameter("@direccionip", EntidadBitacora1.DireccionIP))
            cmdGuardar.Parameters.Add(New SqlParameter("@idusuario", EntidadBitacora1.IdUsuario))
            cmdGuardar.Parameters.Add(New SqlParameter("@usuario", EntidadBitacora1.Usuario))
            cmdGuardar.Parameters.Add(New SqlParameter("@modulo", EntidadBitacora1.Modulo))
            cmdGuardar.Parameters.Add(New SqlParameter("@opcion", EntidadBitacora1.Opcion))
            cmdGuardar.Parameters.Add(New SqlParameter("@operacion", EntidadBitacora1.Operacion))
            cmdGuardar.Parameters.Add(New SqlParameter("@Observaciones", EntidadBitacora1.Observaciones))
            cmdGuardar.Parameters.Add(New SqlParameter("@BaseDeDatos", IIf(EntidadBitacora1.BaseDeDatos = Nothing, "Perfiles", EntidadBitacora1.BaseDeDatos)))
            cmdGuardar.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cnn.Close()
            EntidadBitacora = EntidadBitacora1
        End Try
    End Sub
End Class