alter Procedure Sp_ConsultaOrdenEmbarqueEncabezado
@IdEmbarqueEncabezado int,
@NombreComprador varchar(30)
as
if @IdEmbarqueEncabezado <> 0 and @NombreComprador = ''
	begin
		select distinct cc.IdEmbarqueEncabezado
			  ,cc.IdComprador
			  ,co.Nombre
			  ,isnull(se.NombreChofer ,'') as NombreChofer
			  ,isnull(se.PlacaTractoCamion,'') as PlacaTractoCamion
			  ,isnull(se.NoLicencia,'') as NoLicencia
			  ,cc.NoLote
			  ,ed.CantidadPacas
		from CalculoClasificacion cc inner join embarqueencabezado ee on cc.idembarqueencabezado = ee.idembarqueencabezado and cc.idcomprador = ee.idcomprador
									 inner join Compradores co on cc.idcomprador = co.idcomprador
									 left join SalidaPacasEncabezado se on cc.IdEmbarqueEncabezado = se.IdEmbarqueEncabezado and cc.IdSalidaEncabezado = se.IdSalidaEncabezado
									 inner join Embarquedet ed on cc.idembarqueencabezado = ed.IdEmbarqueEnc and cc.NoLote = ed.NoLote
		where cc.IdEmbarqueEncabezado = @IdEmbarqueEncabezado
		order by cc.IdEmbarqueEncabezado desc
	end
else if @IdEmbarqueEncabezado = 0 and @NombreComprador <> ''
	begin
		select distinct cc.IdEmbarqueEncabezado
			  ,cc.IdComprador
			  ,co.Nombre
			  ,isnull(se.NombreChofer ,'') as NombreChofer
			  ,isnull(se.PlacaTractoCamion,'') as PlacaTractoCamion
			  ,isnull(se.NoLicencia,'') as NoLicencia
			  ,cc.NoLote
			  ,ed.CantidadPacas
		from CalculoClasificacion cc inner join embarqueencabezado ee on cc.idembarqueencabezado = ee.idembarqueencabezado and cc.idcomprador = ee.idcomprador
									 inner join Compradores co on cc.idcomprador = co.idcomprador
									 left join SalidaPacasEncabezado se on cc.IdEmbarqueEncabezado = se.IdEmbarqueEncabezado and cc.IdSalidaEncabezado = se.IdSalidaEncabezado
									 inner join Embarquedet ed on cc.idembarqueencabezado = ed.IdEmbarqueEnc and cc.NoLote = ed.NoLote
		where co.Nombre like '%'+@NombreComprador+'%'
		order by cc.IdEmbarqueEncabezado desc
	end
else 
	begin
		select distinct cc.IdEmbarqueEncabezado
			  ,cc.IdComprador
			  ,co.Nombre
			  ,isnull(se.NombreChofer ,'') as NombreChofer
			  ,isnull(se.PlacaTractoCamion,'') as PlacaTractoCamion
			  ,isnull(se.NoLicencia,'') as NoLicencia
			  ,cc.NoLote
			  ,ed.CantidadPacas
		from CalculoClasificacion cc inner join embarqueencabezado ee on cc.idembarqueencabezado = ee.idembarqueencabezado and cc.idcomprador = ee.idcomprador
									 inner join Compradores co on cc.idcomprador = co.idcomprador
									 left join SalidaPacasEncabezado se on cc.IdEmbarqueEncabezado = se.IdEmbarqueEncabezado and cc.IdSalidaEncabezado = se.IdSalidaEncabezado
									 inner join Embarquedet ed on cc.idembarqueencabezado = ed.IdEmbarqueEnc and cc.NoLote = ed.NoLote
		order by cc.IdEmbarqueEncabezado desc
	end