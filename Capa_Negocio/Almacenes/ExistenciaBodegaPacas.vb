Public Class ExistenciaBodegaPacas
    Public Overridable Sub Consultar(ByRef EntidadExistenciaBodegaPacas As Capa_Entidad.ExistenciaBodegaPacas)
        Dim DatosExistenciaBodegaPacas As New Capa_Datos.ExistenciaBodegaPacas
        DatosExistenciaBodegaPacas.Consultar(EntidadExistenciaBodegaPacas)
    End Sub
    Public Overridable Sub Guardar(ByRef EntidadExistenciaBodegaPacas As Capa_Entidad.ExistenciaBodegaPacas)
        Dim EntidadExistenciaBodegaPacas1 As New Capa_Entidad.ExistenciaBodegaPacas
        Dim DatosExistenciaBodegaPacas As New Capa_Datos.ExistenciaBodegaPacas
        EntidadExistenciaBodegaPacas1 = EntidadExistenciaBodegaPacas
        DatosExistenciaBodegaPacas.Upsert(EntidadExistenciaBodegaPacas)
    End Sub
    Public Overridable Sub Actualiza(ByRef EntidadExistenciaBodegaPacas As Capa_Entidad.ExistenciaBodegaPacas)
        Dim EntidadExistenciaBodegaPacas1 As New Capa_Entidad.ExistenciaBodegaPacas
        Dim DatosExistenciaBodegaPacas As New Capa_Datos.ExistenciaBodegaPacas
        EntidadExistenciaBodegaPacas1 = EntidadExistenciaBodegaPacas
        DatosExistenciaBodegaPacas.Actualizar(EntidadExistenciaBodegaPacas)
    End Sub
End Class
