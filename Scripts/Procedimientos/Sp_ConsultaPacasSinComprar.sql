CREATE Procedure Sp_ConsultaPacasSinComprar
@Valor nvarchar(max),
@IdPlanta integer,
@Clase varchar(4)
as
declare @sql nvarchar(max)
if @valor <> '' and @IdPlanta = ''
begin
set @sql =  'SELECT Pl.Descripcion as Planta
      ,[Kilos]
      ,[LotID]
      ,[BaleID]
      ,[BaleGroup]
      ,[Operator]
      ,[Date]
      ,[Temperature]
      ,[Humidity]
      ,[Amount]
      ,[UHML]
      ,[UI]
      ,[Strength]
      ,[Elongation]
      ,[SFI]
      ,[Maturity]
      ,[Grade]
      ,[Moist]
      ,[Mic]
      ,[Rd]
      ,[Plusb]
      ,[ColorGrade]
      ,[TrashCount]
      ,[TrashArea]
      ,[TrashID]
      ,[SCI]
      ,isnull([Nep],0) as Nep
      ,isnull([UV],0) as UV
  FROM [hvidetalle] cc inner join Plantas Pl on cc.IdPlantaOrigen = Pl.IdPlanta 
  WHERE [IdCompraEnc] is null and cast (baleid as nvarchar)  in ('+@valor+')
  ORDER BY IdPlantaOrigen, BaleID'
end
else if @valor = '' and @IdPlanta <> ''
begin 
set @sql =  'SELECT Pl.Descripcion as Planta
      ,[Kilos]
      ,[LotID]
      ,[BaleID]
      ,[BaleGroup]
      ,[Operator]
      ,[Date]
      ,[Temperature]
      ,[Humidity]
      ,[Amount]
      ,[UHML]
      ,[UI]
      ,[Strength]
      ,[Elongation]
      ,[SFI]
      ,[Maturity]
      ,[Grade]
      ,[Moist]
      ,[Mic]
      ,[Rd]
      ,[Plusb]
      ,[ColorGrade]
      ,[TrashCount]
      ,[TrashArea]
      ,[TrashID]
      ,[SCI]
      ,isnull([Nep],0) as Nep
      ,isnull([UV],0) as UV
  FROM [hvidetalle] cc inner join Plantas Pl on cc.IdPlantaOrigen = Pl.IdPlanta
  WHERE [IdCompraEnc] is null and IdPlantaOrigen = '+cast(@IdPlanta as nvarchar)+'
  ORDER BY IdPlantaOrigen, BaleID'
end
else 
begin
set @sql =  'SELECT Pl.Descripcion as Planta
      ,[Kilos]
      ,[LotID]
      ,[BaleID]
      ,[BaleGroup]
      ,[Operator]
      ,[Date]
      ,[Temperature]
      ,[Humidity]
      ,[Amount]
      ,[UHML]
      ,[UI]
      ,[Strength]
      ,[Elongation]
      ,[SFI]
      ,[Maturity]
      ,[Grade]
      ,[Moist]
      ,[Mic]
      ,[Rd]
      ,[Plusb]
      ,[ColorGrade]
      ,[TrashCount]
      ,[TrashArea]
      ,[TrashID]
      ,[SCI]
      ,isnull([Nep],0) as Nep
      ,isnull([UV],0) as UV
  FROM [hvidetalle] cc inner join Plantas Pl on cc.IdPlantaOrigen = Pl.IdPlanta
  WHERE [IdCompraEnc] is null 
  ORDER BY IdPlantaOrigen, BaleID'
end
exec sp_executesql @sql
