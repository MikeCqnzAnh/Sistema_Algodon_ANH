Public Class OrdenEmbarquePacas
    Public Overridable Sub Consultar(ByRef EntidadOrdenEmbarquePacas As Capa_Entidad.OrdenEmbarquePacas)
        Dim DatosOrdenEmbarquePacas As New Capa_Datos.OrdenEmbarquePacas
        DatosOrdenEmbarquePacas.Consultar(EntidadOrdenEmbarquePacas)
    End Sub
    Public Overridable Sub Guardar(ByRef EntidadOrdenEmbarquePacas As Capa_Entidad.OrdenEmbarquePacas)
        Dim EntidadOrdenEmbarquePacas1 As New Capa_Entidad.OrdenEmbarquePacas
        Dim DatosOrdenEmbarquePacas As New Capa_Datos.OrdenEmbarquePacas
        DatosOrdenEmbarquePacas.Upsert(EntidadOrdenEmbarquePacas)
    End Sub
    Public Overridable Sub Eliminar(ByRef EntidadOrdenEmbarquePacas As Capa_Entidad.OrdenEmbarquePacas)
        Dim EntidadOrdenEmbarquePacas1 As New Capa_Entidad.OrdenEmbarquePacas
        Dim DatosOrdenEmbarquePacas As New Capa_Datos.OrdenEmbarquePacas
        DatosOrdenEmbarquePacas.EliminarPacas(EntidadOrdenEmbarquePacas)
    End Sub
End Class
