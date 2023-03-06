alter Procedure Sp_ConsultaPacasSinVender
@Valor nvarchar(max),
@IdPlanta integer,
@Clase varchar(4)
as
declare @sql nvarchar(max),
		@esvacio nvarchar(1)=''
if @valor <> '' and @IdPlanta = ''
begin
set @sql =  'SELECT Pl.Descripcion as Planta
      ,isnull(cc.[Kilos],0) as Kilos
      ,hd.[LotID]
      ,hd.[BaleID]
      ,hd.[BaleGroup]
      ,hd.[Operator]
      ,hd.[Date]
      ,isnull(cc.[Temperature],0) as Temperature
      ,isnull(cc.[Humidity],0) as Humidity
      ,isnull(cc.[Amount],0) as Amount
      ,isnull(cc.[UHML],0) as UHML
      ,isnull(cc.[UI],0) as UI
      ,isnull(cc.[Strength],0) as Strength
      ,isnull(cc.[Elongation],0) as Elongation
      ,isnull(cc.[SFI],0) as SFI
      ,isnull(cc.[Maturity],0) asMaturity 
      ,isnull(cc.[Grade],'+@esvacio+') as Grade
      ,isnull(cc.[Moist],0) as Moist
      ,isnull(cc.[Mic],0) as Mic
      ,isnull(cc.[Rd],0) as Rd
      ,isnull(cc.[Plusb],0) as Plusb
      ,isnull(cc.[ColorGrade],'+@esvacio+') as ColorGrade
      ,isnull(cc.[TrashCount],0) as TrashCount
      ,isnull(cc.[TrashArea],0) as TrashArea
      ,isnull(cc.[TrashID],0) as TrashID
      ,isnull(cc.[SCI],0) as SCI
      ,isnull(cc.[Nep],0) as Nep
      ,isnull(cc.[UV],0) as UV
  FROM cc.[CalculoClasificacion] cc right join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdOrdenTrabajo = hd.idordentrabajo
								 inner join Plantas Pl on hd.IdPlantaOrigen = Pl.IdPlanta 
  WHERE cc.[IdVentaEnc] is null and cast (hd.baleid as nvarchar)  in ('+@valor+')
  ORDER BY hd.IdPlantaOrigen, hd.BaleID'
end
else if @valor = '' and @IdPlanta <> ''
begin 
set @sql =  'SELECT Pl.Descripcion as Planta
      ,isnull(cc.[Kilos],0) as Kilos
      ,hd.[LotID]
      ,hd.[BaleID]
      ,hd.[BaleGroup]
      ,hd.[Operator]
      ,hd.[Date]
      ,isnull(cc.[Temperature],0) as Temperature
      ,isnull(cc.[Humidity],0) as Humidity
      ,isnull(cc.[Amount],0) as Amount
      ,isnull(cc.[UHML],0) as UHML
      ,isnull(cc.[UI],0) as UI
      ,isnull(cc.[Strength],0) as Strength
      ,isnull(cc.[Elongation],0) as Elongation
      ,isnull(cc.[SFI],0) as SFI
      ,isnull(cc.[Maturity],0) asMaturity 
      ,isnull(cc.[Grade],'+@esvacio+') as Grade
      ,isnull(cc.[Moist],0) as Moist
      ,isnull(cc.[Mic],0) as Mic
      ,isnull(cc.[Rd],0) as Rd
      ,isnull(cc.[Plusb],0) as Plusb
      ,isnull(cc.[ColorGrade],'+@esvacio+') as ColorGrade
      ,isnull(cc.[TrashCount],0) as TrashCount
      ,isnull(cc.[TrashArea],0) as TrashArea
      ,isnull(cc.[TrashID],0) as TrashID
      ,isnull(cc.[SCI],0) as SCI
      ,isnull(cc.[Nep],0) as Nep
      ,isnull(cc.[UV],0) as UV
  FROM [CalculoClasificacion] cc right join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdOrdenTrabajo = hd.idordentrabajo
								 inner join Plantas Pl on hd.IdPlantaOrigen = Pl.IdPlanta
  WHERE cc.[IdVentaEnc] is null and hd.IdPlantaOrigen = '+cast(@IdPlanta as nvarchar)+'
  ORDER BY hd.IdPlantaOrigen, hd.BaleID'
end
else 
begin
set @sql =  'SELECT Pl.Descripcion as Planta
      ,isnull(cc.[Kilos],0) as Kilos
      ,hd.[LotID]
      ,hd.[BaleID]
      ,hd.[BaleGroup]
      ,hd.[Operator]
      ,hd.[Date]
      ,isnull(cc.[Temperature],0) as Temperature
      ,isnull(cc.[Humidity],0) as Humidity
      ,isnull(cc.[Amount],0) as Amount
      ,isnull(cc.[UHML],0) as UHML
      ,isnull(cc.[UI],0) as UI
      ,isnull(cc.[Strength],0) as Strength
      ,isnull(cc.[Elongation],0) as Elongation
      ,isnull(cc.[SFI],0) as SFI
      ,isnull(cc.[Maturity],0) asMaturity 
      ,isnull(cc.[Grade],'+@esvacio+') as Grade
      ,isnull(cc.[Moist],0) as Moist
      ,isnull(cc.[Mic],0) as Mic
      ,isnull(cc.[Rd],0) as Rd
      ,isnull(cc.[Plusb],0) as Plusb
      ,isnull(cc.[ColorGrade],'+@esvacio+') as ColorGrade
      ,isnull(cc.[TrashCount],0) as TrashCount
      ,isnull(cc.[TrashArea],0) as TrashArea
      ,isnull(cc.[TrashID],0) as TrashID
      ,isnull(cc.[SCI],0) as SCI
      ,isnull(cc.[Nep],0) as Nep
      ,isnull(cc.[UV],0) as UV
  FROM [CalculoClasificacion] cc right join HviDetalle hd on cc.BaleID = hd.BaleID and cc.IdOrdenTrabajo = hd.idordentrabajo
								 inner join Plantas Pl on hd.IdPlantaOrigen = Pl.IdPlanta
  WHERE cc.[IdVentaEnc] is null 
  ORDER BY hd.IdPlantaOrigen, hd.BaleID'
end
exec sp_executesql @sql
