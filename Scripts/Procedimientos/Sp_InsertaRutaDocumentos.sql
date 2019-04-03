CREATE PROCEDURE Sp_InsertaRutaDocumentos
@IdUbicacion int output,
@RutaPrincipal varchar(50),
@NombreCarpetaRaiz varchar(50),
@DocumentosProductores varchar(50),
@DocumentosPersonales varchar(50),
@DocumentosLotes varchar(50),
@ContratosProductores varchar(50),
@ContratosCompradores varchar(50),
@Anexos varchar(50),
@PreRegistro varchar(50),
@ActaParticipacion varchar(50),
@Temporadas varchar(50),
@NombreAnual varchar(50)
as
begin
SET NOCOUNT ON 
MERGE [dbo].[UbicacionDocumentos] as target
using (select @IdUbicacion,@RutaPrincipal,@NombreCarpetaRaiz ,@DocumentosProductores,@DocumentosPersonales ,@DocumentosLotes ,@ContratosProductores ,@ContratosCompradores ,@Anexos ,@PreRegistro ,@ActaParticipacion ,@Temporadas ,@NombreAnual ) 
	as source( IdUbicacion, RutaPrincipal, NombreCarpetaRaiz , DocumentosProductores, DocumentosPersonales , DocumentosLotes , ContratosProductores , ContratosCompradores , Anexos , PreRegistro , ActaParticipacion , Temporadas , NombreAnual )
on (target.IdUbicacion = source.IdUbicacion)

when matched then
update set RutaPrincipal = source.RutaPrincipal,
		   NombreCarpetaRaiz = source.NombreCarpetaRaiz,
		   DocumentosProductores = source.DocumentosProductores,
		   DocumentosPersonales = source.DocumentosPersonales,
		   DocumentosLotes = source.DocumentosLotes,
		   ContratosProductores = source.ContratosProductores,
		   ContratosCompradores = source.ContratosCompradores,
		   Anexos = source.Anexos,
		   PreRegistro = source.PreRegistro,
		   ActaParticipacion = source.ActaParticipacion,
		   Temporadas = source.Temporadas,
		   NombreAnual = source.NombreAnual
when not matched then
	insert(		  RutaPrincipal,	   NombreCarpetaRaiz ,		 DocumentosProductores,		   DocumentosPersonales ,		DocumentosLotes ,		ContratosProductores ,		ContratosCompradores ,		Anexos ,PreRegistro ,ActaParticipacion ,Temporadas ,NombreAnual)
	values(source.RutaPrincipal,source.NombreCarpetaRaiz ,source.DocumentosProductores ,source.DocumentosPersonales, source.DocumentosLotes ,source.ContratosProductores ,source.ContratosCompradores ,source.Anexos ,source.PreRegistro ,source.ActaParticipacion ,source.Temporadas ,source.NombreAnual);
	set @IdUbicacion = SCOPE_IDENTITY()
end
return @IdUbicacion