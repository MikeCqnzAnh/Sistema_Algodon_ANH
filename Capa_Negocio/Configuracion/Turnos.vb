Imports Capa_Entidad
Imports Capa_Datos
Public Class Turnos
    Public Overridable Sub Guardar(ByRef EntidadTurnos As Capa_Entidad.Turnos)
        Dim EntidadTurnos1 As New Capa_Entidad.Turnos
        Dim DatosTurnos As New Capa_Datos.Turnos
        EntidadTurnos1 = EntidadTurnos
        DatosTurnos.Upsert(EntidadTurnos1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadTurnos As Capa_Entidad.Turnos)
        Dim DatosTurnos As New Capa_Datos.Turnos
        DatosTurnos.Consultar(EntidadTurnos)
    End Sub
End Class
