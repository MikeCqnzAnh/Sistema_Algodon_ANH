Public Class ProgramarRespaldos
    Public Overridable Sub Consultar(ByRef EntidadProgramarRespaldos As Capa_Entidad.ProgramarRespaldos)
        Dim EntidadProgramarRespaldos1 As New Capa_Entidad.ProgramarRespaldos()
        Dim DatosProgramarRespaldos As New Capa_Datos.ProgramarRespaldos()
        EntidadProgramarRespaldos1 = EntidadProgramarRespaldos
        DatosProgramarRespaldos.Consultar(EntidadProgramarRespaldos1)
    End Sub
End Class
