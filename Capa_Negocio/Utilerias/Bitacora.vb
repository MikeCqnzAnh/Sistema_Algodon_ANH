Imports Capa_Entidad
Imports Capa_Datos
Public Class Bitacora
    Public Overridable Sub Consultar(ByRef EntidadBitacora As Capa_Entidad.Bitacora)
        Dim EntidadBitacora1 As New Capa_Entidad.Bitacora()
        Dim DatosBitacora As New Capa_Datos.Bitacora()
        EntidadBitacora1 = EntidadBitacora
        DatosBitacora.Consultar(EntidadBitacora1)
    End Sub
    Public Overridable Sub InsertaBitacora(ByRef EntidadBitacora As Capa_Entidad.Bitacora)
        Dim EntidadBitacora1 As New Capa_Entidad.Bitacora()
        Dim DatosBitacora As New Capa_Datos.Bitacora()
        EntidadBitacora1 = EntidadBitacora
        DatosBitacora.InsertaBitacora(EntidadBitacora1)
    End Sub
End Class
