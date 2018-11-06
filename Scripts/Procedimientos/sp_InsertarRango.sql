create procedure sp_InsertarRango
@IdRango int output,
@RangoInicial float,
@RangoFinal float,
@DentroLimite bit,
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime
as
begin
set nocount on
merge [dbo].[RangoTemperatura] as target
using (select @IdRango,@RangoInicial,@RangoFinal,@DentroLimite,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion) as source (IdRango,RangoInicial,RangoFinal,DentroLimite,IdEstatus,IdUsuarioCreacion,FechaCreacion)
ON (target.IdRango = source.IdRango)
WHEN MATCHED THEN
UPDATE SET RangoInicial = source.RangoInicial,
		   RangoFinal = source.RangoFinal,
		   DentroLimite = source.DentroLimite,
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (RangoInicial,RangoFinal,DentroLimite,IdEstatus,IdUsuarioCreacion,FechaCreacion)
VALUES (source.RangoInicial,source.RangoFinal,source.DentroLimite,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion);
SET @IdRango = SCOPE_IDENTITY()
END
RETURN @IdRango