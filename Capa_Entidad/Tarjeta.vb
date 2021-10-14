Imports System.Windows.Forms
Imports Capa_Operacion
Public Class Tarjeta
    Public Property Actualiza As Configuracion.Actualiza
    Public Property Guarda As Configuracion.Guardar
    Public Property Consulta As Configuracion.Consulta
    Public Property Agrega As Configuracion.Agrega
    Public Property Reporte As Configuracion.Reporte
    Public Property Eliminar As Configuracion.Eliminar
    Public Property LlenaCombo As Configuracion.LlenaCombo
    Public Property Importa As Configuracion.Importa
    Public Property Conexion As Configuracion.Conexion
    Public Property TablaConsulta As DataTable
    Public Property TablaGeneral As DataTable
    Public Property TablaOpciones As DataTable
    Public Property IdExterno As Integer
    Public Property IdUsuarioCreacion As Integer
    Public Property FechaCreacion As DateTime
    Public Property IdUsuarioActualizacion As Integer
    Public Property FechaActualizacion As DateTime
    Public Property DescripcionConsulta As String
    Public Property BaseDeDatos As String
    Public Property BaseDeDatosPerfiles As String

End Class
