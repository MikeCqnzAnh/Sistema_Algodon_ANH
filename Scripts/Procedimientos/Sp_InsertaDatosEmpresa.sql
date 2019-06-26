Create Procedure Sp_InsertaDatosEmpresa
@IdDatosEmpresa int output
,@RazonSocial varchar(60)
,@RFCEmpresa varchar(13)
,@RepresentanteLegal varchar(50)
,@RFCRepresentante varchar(13)
,@Calle varchar(40)
,@NumExt varchar(10)
,@NumInt varchar(10)
,@EntreCalle1 varchar(40)
,@EntreCalle2 varchar(40)
,@Colonia varchar(40)
,@Referencia varchar(40)
,@Poblacion varchar(40)
,@CodigoPostal varchar(6)
,@Pais varchar(25)
,@Estado varchar(25)
,@Municipio varchar(25)
,@LugarExpedicion varchar(40)
as
begin
set nocount on
merge DatosEmpresa as target
using (select @IdDatosEmpresa,@RazonSocial,@RFCEmpresa,@RepresentanteLegal,@RFCRepresentante,@Calle,@NumExt,@NumInt,@EntreCalle1,@EntreCalle2,@Colonia,@Referencia,@Poblacion,@CodigoPostal,@Pais,@Estado,@Municipio,@LugarExpedicion)
as source(IdDatosEmpresa,RazonSocial,RFCEmpresa,RepresentanteLegal,RFCRepresentante,Calle,NumExt,NumInt,EntreCalle1,EntreCalle2,Colonia,Referencia,Poblacion,CodigoPostal,Pais,Estado,Municipio,LugarExpedicion)
on (target.IdDatosEmpresa = source.IdDatosEmpresa)
when matched then 
update set	   RazonSocial = source.RazonSocial
			  ,RFCEmpresa= source.RFCEmpresa
			  ,RepresentanteLegal= source.RepresentanteLegal
			  ,RFCRepresentante= source.RFCRepresentante
			  ,Calle= source.Calle
			  ,NumExt= source.NumExt
			  ,NumInt= source.NumInt
			  ,EntreCalle1= source.EntreCalle1
			  ,EntreCalle2= source.EntreCalle2
			  ,Colonia= source.Colonia
			  ,Referencia= source.Referencia
			  ,Poblacion= source.Poblacion
			  ,CodigoPostal= source.CodigoPostal
			  ,Pais= source.Pais
			  ,Estado= source.Estado
			  ,Municipio= source.Municipio
			  ,LugarExpedicion= source.LugarExpedicion
when not matched then
insert(RazonSocial,RFCEmpresa,RepresentanteLegal,RFCRepresentante,Calle,NumExt,NumInt,EntreCalle1,EntreCalle2,Colonia,Referencia,Poblacion,CodigoPostal,Pais,Estado,Municipio,LugarExpedicion)
values(source.RazonSocial,source.RFCEmpresa,source.RepresentanteLegal,source.RFCRepresentante,source.Calle,source.NumExt,source.NumInt,source.EntreCalle1,source.EntreCalle2,source.Colonia,source.Referencia,source.Poblacion,source.CodigoPostal,source.Pais,source.Estado,source.Municipio,source.LugarExpedicion);
set @IdDatosEmpresa = SCOPE_IDENTITY()
end
return @IdDatosEmpresa