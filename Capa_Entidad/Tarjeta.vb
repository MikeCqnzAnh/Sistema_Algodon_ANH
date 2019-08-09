Imports System.Windows.Forms

Public Class Tarjeta
    Public Property Actualiza As Capa_Operacion.Configuracion.Actuliza
    Public Property Guarda As Capa_Operacion.Configuracion.Guardar
    Public Property Consulta As Capa_Operacion.Configuracion.Consulta
    Public Property Agrega As Capa_Operacion.Configuracion.Agrega
    Public Property Reporte As Capa_Operacion.Configuracion.Reporte
    Public Property Eliminar As Capa_Operacion.Configuracion.Eliminar
    Public Property LlenaCombo As Capa_Operacion.Configuracion.LlenaCombo
    Public Property Importa As Capa_Operacion.Configuracion.Importa
    Public Property Conexion As Capa_Operacion.Configuracion.Conexion
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
End Class
