Public Class DatosEmpresa
    Public Overridable Sub Guardar(ByRef EntidadDatosEmpresa As Capa_Entidad.DatosEmpresa)
        Dim EntidadDatosEmpresa1 As New Capa_Entidad.DatosEmpresa
        Dim DatosDatosEmpresa As New Capa_Datos.DatosEmpresa
        EntidadDatosEmpresa1 = EntidadDatosEmpresa
        DatosDatosEmpresa.Upsert(EntidadDatosEmpresa1)
    End Sub
    Public Overridable Sub Consultar(ByRef EntidadDatosEmpresa As Capa_Entidad.DatosEmpresa)
        Dim EntidadDatosEmpresa1 As New Capa_Entidad.DatosEmpresa()
        Dim DatosDatosEmpresa As New Capa_Datos.DatosEmpresa()
        EntidadDatosEmpresa1 = EntidadDatosEmpresa
        DatosDatosEmpresa.Consultar(EntidadDatosEmpresa1)
    End Sub
End Class
