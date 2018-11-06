Public Class Compradores
    Public Overridable Sub Guardar(ByRef EntidadCompradores As Capa_Entidad.Compradores)
        Dim EntidadCompradores1 As New Capa_Entidad.Compradores
        Dim DatosCompradores As New Capa_Datos.Compradores
        EntidadCompradores1 = EntidadCompradores
        DatosCompradores.Upsert(EntidadCompradores1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadCompradores As Capa_Entidad.Compradores)
        Dim DatosCompradores As New Capa_Datos.Compradores
        DatosCompradores.Consultar(EntidadCompradores)
    End Sub
End Class
