Create Procedure Sp_ConsultaRegistrosTabla
@NombreTabla varchar(60)
as

exec ('select count(*) as Registros from '+@NombreTabla+'') 