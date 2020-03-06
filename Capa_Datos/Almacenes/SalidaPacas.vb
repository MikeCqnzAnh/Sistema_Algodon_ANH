Imports System.Data.SqlClient
Public Class SalidaPacas
    Public Overridable Sub Consultar(ByRef EntidadSalidaPacas As Capa_Entidad.SalidaPacas)
        Dim EntidadSalidaPacas1 = New Capa_Entidad.SalidaPacas
        EntidadSalidaPacas1 = EntidadSalidaPacas
        EntidadSalidaPacas1.TablaConsulta = New DataTable
        Dim cnn As New SqlConnection(conexionPrincipal)
        Try
            cnn.Open()
            Select Case EntidadSalidaPacas1.Consulta
                Case Capa_Operacion.Configuracion.Consulta.ConsultaBasica
                    Dim sqldat1 As New SqlDataAdapter("Sp_ConsultaPaquetesDisponiblesEmbarques", cnn)
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
                Case Capa_Operacion.Configuracion.Consulta.ConsultaAlmacen
                    Dim sqldat1 As New SqlDataAdapter("Sp_ConsultaPacasDisponiblesEmbarques", cnn)
                    sqldat1.Fill(EntidadSalidaPacas1.TablaConsulta)
            End Select
        Catch ex As Exception
        Finally
            cnn.Close()
            EntidadSalidaPacas = EntidadSalidaPacas1
        End Try
    End Sub
End Class
