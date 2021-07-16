Create Procedure Pa_ConsultaIntegracion
@IdIntegracion integer ,
@IdCompra integer,
@NompreProductor varchar(30)
as 
if @IdIntegracion > 0 and @IdCompra = 0 and @NompreProductor = ''
begin
	Select ic.IdIntegracionCompra,
		   ic.IdCompra,
		   ic.IdContrato AS IdContratoAlgodon,
		   ic.IdProductor as IdCliente,
		   cl.Nombre,
		   cl.Rfc,
		   cp.PrecioQuintal,
		   cp.TotalPacas ,
		   (select sum(Kilos) from HviDetalle where IdCompraEnc = cp.IdCompra) as Kilos,
		   cp.Subtotal,
		   cp.CastigoDls,
		   cp.TotalDlls,
		   ic.ImporteFacturas,
		   ic.TotalToneladasFacturas,
		   ic.TotalPacasFacturas,
		   ic.FechaCreacion,
		   ic.FechaActualizacion
	from IntegracionCompra ic inner join CompraPacas cp on ic.IdCompra = cp.IdCompra
							  inner join Clientes cl on ic.IdProductor = cl.IdCliente
	where ic.IdIntegracionCompra = @IdIntegracion
end
else if @IdIntegracion = 0 and @IdCompra > 0 and @NompreProductor = ''
begin
	Select ic.IdIntegracionCompra,
		   ic.IdCompra,
		   ic.IdContrato AS IdContratoAlgodon,
		   ic.IdProductor as IdCliente,
		   cl.Nombre,
		   cl.Rfc,
		   cp.PrecioQuintal,
		   cp.TotalPacas ,
		   (select sum(Kilos) from HviDetalle where IdCompraEnc = cp.IdCompra) as Kilos,
		   cp.Subtotal,
		   cp.CastigoDls,
		   cp.TotalDlls,
		   ic.ImporteFacturas,
		   ic.TotalToneladasFacturas,
		   ic.TotalPacasFacturas,
		   ic.FechaCreacion,
		   ic.FechaActualizacion
	from IntegracionCompra ic inner join CompraPacas cp on ic.IdCompra = cp.IdCompra
							  inner join Clientes cl on ic.IdProductor = cl.IdCliente
	where ic.IdCompra = @IdCompra
end
else if @IdIntegracion = 0 and @IdCompra = 0 and @NompreProductor <> ''
begin
	Select ic.IdIntegracionCompra,
		   ic.IdCompra,
		   ic.IdContrato AS IdContratoAlgodon,
		   ic.IdProductor as IdCliente,
		   cl.Nombre,
		   cl.Rfc,
		   cp.PrecioQuintal,
		   cp.TotalPacas ,
		   (select sum(Kilos) from HviDetalle where IdCompraEnc = cp.IdCompra) as Kilos,
		   cp.Subtotal,
		   cp.CastigoDls,
		   cp.TotalDlls,
		   ic.ImporteFacturas,
		   ic.TotalToneladasFacturas,
		   ic.TotalPacasFacturas,
		   ic.FechaCreacion,
		   ic.FechaActualizacion
	from IntegracionCompra ic inner join CompraPacas cp on ic.IdCompra = cp.IdCompra
							  inner join Clientes cl on ic.IdProductor = cl.IdCliente
	where cl.Nombre like '%'+@NompreProductor+'%'
end
else if @IdIntegracion = 0 and @IdCompra = 0 and @NompreProductor = ''
begin
	Select ic.IdIntegracionCompra,
		   ic.IdCompra,
		   ic.IdContrato AS IdContratoAlgodon,
		   ic.IdProductor as IdCliente,
		   cl.Nombre,
		   cl.Rfc,
		   cp.PrecioQuintal,
		   cp.TotalPacas ,
		   (select sum(Kilos) from HviDetalle where IdCompraEnc = cp.IdCompra) as Kilos,
		   cp.Subtotal,
		   cp.CastigoDls,
		   cp.TotalDlls,
		   ic.ImporteFacturas,
		   ic.TotalToneladasFacturas,
		   ic.TotalPacasFacturas,
		   ic.FechaCreacion,
		   ic.FechaActualizacion
	from IntegracionCompra ic inner join CompraPacas cp on ic.IdCompra = cp.IdCompra
							  inner join Clientes cl on ic.IdProductor = cl.IdCliente
end