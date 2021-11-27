Imports Capa_Entidad
Imports Capa_Datos
Public Class CapturaBoletasPorLotes
    Public Overridable Sub Guardar(ByRef EntidadCapturaBoletasPorLotes As Capa_Entidad.CapturaBoletasPorLotes)
        Dim EntidadCapturaBoletasPorLotes1 As New Capa_Entidad.CapturaBoletasPorLotes
        Dim DatosCapturaBoletasPorLotes As New Capa_Datos.CapturaBoletasPorLotes
        EntidadCapturaBoletasPorLotes1 = EntidadCapturaBoletasPorLotes
        ' DatosCapturaBoletasPorLotes.Upsert(EntidadCapturaBoletasPorLotes1)
    End Sub

    Public Overridable Sub Consultar(ByRef EntidadCapturaBoletasPorLotes As Capa_Entidad.CapturaBoletasPorLotes)
        Dim DatosCapturaBoletasPorLotes As New Capa_Datos.CapturaBoletasPorLotes
        DatosCapturaBoletasPorLotes.Consultar(EntidadCapturaBoletasPorLotes)
    End Sub
    Public Overridable Sub upsert(ByRef EntidadCapturaBoletasPorLotes As Capa_Entidad.CapturaBoletasPorLotes)
        Dim DatosCapturaBoletasPorLotes As New Capa_Datos.CapturaBoletasPorLotes
        DatosCapturaBoletasPorLotes.Upsert(EntidadCapturaBoletasPorLotes)
    End Sub
    Public Overridable Sub upsertAuto(ByRef EntidadCapturaBoletasPorLotes As Capa_Entidad.CapturaBoletasPorLotes)
        Dim DatosCapturaBoletasPorLotes As New Capa_Datos.CapturaBoletasPorLotes
        DatosCapturaBoletasPorLotes.UpsertAuto(EntidadCapturaBoletasPorLotes)
    End Sub
    Public Overridable Sub ActualizaPesoOrden(ByRef EntidadCapturaBoletasPorLotes As Capa_Entidad.CapturaBoletasPorLotes)
        Dim DatosCapturaBoletasPorLotes As New Capa_Datos.CapturaBoletasPorLotes
        DatosCapturaBoletasPorLotes.ActualizaPesoOrden(EntidadCapturaBoletasPorLotes)
    End Sub
End Class
