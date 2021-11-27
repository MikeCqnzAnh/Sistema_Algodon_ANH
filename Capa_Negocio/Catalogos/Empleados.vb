Imports Capa_Entidad
Imports Capa_Datos
Public Class Empleados
    Public Overridable Sub Guardar(ByRef EntidadEmpleados As Capa_Entidad.Empleados)
        Dim EntidadEmpleados1 As New Capa_Entidad.Empleados
        Dim DatosEmpleados As New Capa_Datos.Empleados
        EntidadEmpleados1 = EntidadEmpleados
        DatosEmpleados.Upsert(EntidadEmpleados1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadEmpleados As Capa_Entidad.Empleados)
        Dim DatosEmpleados As New Capa_Datos.Empleados
        DatosEmpleados.Consultar(EntidadEmpleados)
    End Sub
End Class
