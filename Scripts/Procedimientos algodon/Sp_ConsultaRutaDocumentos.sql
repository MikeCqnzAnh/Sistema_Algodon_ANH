create procedure Sp_ConsultaRutaDocumentos
as
select top 1 
[IdUbicacion],
[RutaPrincipal],
[NombreCarpetaRaiz],
[DocumentosProductores],
[DocumentosPersonales],
[DocumentosLotes],
[ContratosProductores],
[ContratosCompradores],
[Anexos],
[PreRegistro],
[ActaParticipacion],
[Temporadas],
[NombreAnual]
from UbicacionDocumentos