Public Class ProfesionalesFitosanitarios
    Public Overridable Sub Guardar(ByRef EntidadProfesionalesFitosanitarios As Capa_Entidad.ProfesionalesFitosanitarios)
        Dim EntidadProfesionalesFitosanitarios1 As New Capa_Entidad.ProfesionalesFitosanitarios
        Dim DatosProfesionalesFitosanitarios As New Capa_Datos.ProfesionalesFitosanitarios
        EntidadProfesionalesFitosanitarios1 = EntidadProfesionalesFitosanitarios
        DatosProfesionalesFitosanitarios.Upsert(EntidadProfesionalesFitosanitarios1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadProfesionalesFitosanitarios As Capa_Entidad.ProfesionalesFitosanitarios)
        Dim DatosProfesionalesFitosanitarios As New Capa_Datos.ProfesionalesFitosanitarios
        DatosProfesionalesFitosanitarios.Consultar(EntidadProfesionalesFitosanitarios)
    End Sub
End Class
