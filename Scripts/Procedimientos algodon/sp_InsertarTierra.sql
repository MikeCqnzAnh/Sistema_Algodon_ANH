create proc sp_InsertarTierra
@IdTierra int output,
@Lote varchar(10),
@Colonia int,
@Propietario int,
@RegistroAlterno varchar(12),
@SuperficieTotal decimal(10,2),
@SuperficieCultivable decimal(10,2),
@LatitudGrados decimal(6,2),
@LatitudHoras  decimal(6,2),
@LatitudMinutos decimal(6,2),
@LongitudGrados decimal(6,2),
@LongitudHoras decimal(6,2),
@LongitudMinutos decimal(6,2),
@NumeroRpp int,
@FolioRpp int,
@LibroRpp int,
@Fecha date,
@TituloAgua varchar(15),
@RegimenHidrico int,
@FechaTituloAgua date,
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion Datetime
as
begin
set nocount on
merge Tierras as target
using (select @IdTierra,@Lote,@Colonia,@Propietario,@RegistroAlterno,@SuperficieTotal,@SuperficieCultivable,@LatitudGrados,@LatitudHoras,@LatitudMinutos,@LongitudGrados,@LongitudHoras,@LongitudMinutos,@NumeroRpp,@FolioRpp,@LibroRpp,@Fecha,@TituloAgua,@RegimenHidrico,@FechaTituloAgua,@IdEstatus,@IdUsuarioCreacion,@FechaCreacion) 
as source (IdTierra,Lote,Colonia,Propietario,RegistroAlterno,SuperficieTotal,SuperficieCultivable,LatitudGrados,LatitudHoras,LatitudMinutos,LongitudGrados,LongitudHoras,LongitudMinutos,NumeroRpp,FolioRpp,LibroRpp,Fecha,TituloAgua,RegimenHidrico,FechaTituloAgua,IdEstatus,IdUsuarioCreacion,FechaCreacion)
ON (target.IdTierra = source.IdTierra)
WHEN MATCHED THEN
UPDATE SET Lote = source.Lote,
		   Colonia = source.Colonia,
		   Propietario = source.Propietario,
		   RegistroAlterno = source.RegistroAlterno,
		   SuperficieTotal = source.SuperficieTotal,
		   SuperficieCultivable = source.SuperficieCultivable,
		   LatitudGrados = source.LatitudGrados,
		   LatitudHoras = source.LatitudHoras,
		   LatitudMinutos = source.LatitudMinutos,
		   LongitudGrados = source.LongitudGrados,
		   LongitudHoras = source.LongitudHoras,
		   LongitudMinutos = source.LongitudMinutos,
		   NumeroRpp = source.NumeroRpp,
		   FolioRpp = source.FolioRpp,
		   LibroRpp = source.LibroRpp,
		   Fecha = source.Fecha,
		   TituloAgua = source.TituloAgua,
		   RegimenHidrico = source.RegimenHidrico,
		   FechaTituloAgua = source.FechaTituloAgua,
		   IdEstatus = source.IdEstatus,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (Lote,Colonia,Propietario,RegistroAlterno,SuperficieTotal,SuperficieCultivable,LatitudGrados,LatitudHoras,LatitudMinutos,LongitudGrados,LongitudHoras,LongitudMinutos,NumeroRpp,FolioRpp,LibroRpp,Fecha,TituloAgua,RegimenHidrico,FechaTituloAgua,IdEstatus,IdUsuarioCreacion,FechaCreacion)
VALUES (source.Lote,source.Colonia,source.Propietario,source.RegistroAlterno,source.SuperficieTotal,source.SuperficieCultivable,source.LatitudGrados,source.LatitudHoras,source.LatitudMinutos,source.LongitudGrados,source.LongitudHoras,source.LongitudMinutos,source.NumeroRpp,source.FolioRpp,source.LibroRpp,source.Fecha,source.TituloAgua,source.RegimenHidrico,source.FechaTituloAgua,source.IdEstatus,source.IdUsuarioCreacion,source.FechaCreacion);
SET @IdTierra = SCOPE_IDENTITY()
END
RETURN @IdTierra