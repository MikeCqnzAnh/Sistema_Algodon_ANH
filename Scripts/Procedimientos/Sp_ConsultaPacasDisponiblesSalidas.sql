alter Procedure Sp_ConsultaPacasDisponiblesSalidas
@Seleccionar bit = 0 ,
@IdEmbarqueEncabezado int ,
@NoLote varchar(15)
as
if @NoLote = ''
begin
select cc.IdPaqueteEncabezado
	  ,cc.IdVentaEnc
	  ,cc.IdPlantaOrigen
	  ,cc.BaleID
	  ,cc.NoLote
	  ,Pl.Descripcion
	  ,cc.Kilos
	  ,@Seleccionar as Seleccionar
from PaqueteEncabezado pe inner join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado and pe.IdPlanta = cc.idPlantaOrigen
						  inner join Plantas Pl on cc.IdPlantaOrigen = pl.IdPlanta
						  inner join ventapacas vp on cc.IdVentaenc = vp.Idventa  
where cc.EstatusEmbarque = 1  and cc.IdEmbarqueEncabezado = @IdEmbarqueEncabezado
order by cc.IdPaqueteEncabezado, cc.BaleID
end
else if @NoLote <> '' 
begin 
select cc.IdPaqueteEncabezado
	  ,cc.IdVentaEnc
	  ,cc.IdPlantaOrigen
	  ,cc.BaleID
	  ,cc.NoLote
	  ,Pl.Descripcion
	  ,cc.Kilos
	  ,@Seleccionar as Seleccionar
from PaqueteEncabezado pe inner join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado and pe.IdPlanta = cc.idPlantaOrigen
						  inner join Plantas Pl on cc.IdPlantaOrigen = pl.IdPlanta
						  inner join ventapacas vp on cc.IdVentaenc = vp.Idventa  
where cc.EstatusEmbarque = 1  and cc.IdEmbarqueEncabezado = @IdEmbarqueEncabezado and cc.NoLote = @NoLote
order by cc.IdPaqueteEncabezado, cc.BaleID
end