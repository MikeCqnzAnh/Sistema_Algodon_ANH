Create Procedure Sp_ReportePaquetesVenta
@IdPaquete int ,
@IdPlanta int ,
@CantidadPacas int ,
@IdComprador int,
@IdClase int,
@Mayor bit,
@Menor bit
as
if @IdPaquete = 0 and @IdPlanta = 0 and @IdClase = 0 and @Mayor = 0 and @Menor = 0
begin 
select pe.IdPaquete,
	   pe.CantidadPacas,
	   pe.IdPlanta,
	   clcl.ClaveCorta as Clase,
	   isnull(Comp.Nombre,'') as Nombre,
	   pe.Entrega	     
from paqueteencabezado pe right join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado
						  inner join ClasesClasificacion clcl on pe.IdClase = clcl.IdClasificacion
						  left join Compradores Comp on pe.idComprador = Comp.IdComprador
group by cc.idpaqueteencabezado,pe.cantidadpacas,pe.IdPaquete,pe.IdPlanta,clcl.ClaveCorta, Comp.Nombre,pe.Entrega
order by cc.IdPaqueteEncabezado
end 
else if @IdPaquete > 0 
begin
select pe.IdPaquete,
	   pe.CantidadPacas,
	   pe.IdPlanta,
	   clcl.ClaveCorta as Clase,
	   isnull(Comp.Nombre,'') as Nombre,
	   pe.Entrega	     
from paqueteencabezado pe right join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado
						  inner join ClasesClasificacion clcl on pe.IdClase = clcl.IdClasificacion
						  left join Compradores Comp on pe.idComprador = Comp.IdComprador
where pe.IdPaquete = @IdPaquete
group by cc.idpaqueteencabezado,pe.cantidadpacas,pe.IdPaquete,pe.IdPlanta,clcl.ClaveCorta, Comp.Nombre,pe.Entrega
--having count(cc.idpaqueteencabezado)> 125 or count(cc.idpaqueteencabezado)<125 
order by cc.IdPaqueteEncabezado
end
else if @IdPlanta > 0 and @IdClase = 0 and @Mayor = 0 and @Menor = 0
begin 
select pe.IdPaquete,
	   pe.CantidadPacas,
	   pe.IdPlanta,
	   clcl.ClaveCorta as Clase,
	   isnull(Comp.Nombre,'') as Nombre,
	   pe.Entrega	     
from paqueteencabezado pe right join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado
						  inner join ClasesClasificacion clcl on pe.IdClase = clcl.IdClasificacion
						  left join Compradores Comp on pe.idComprador = Comp.IdComprador
where pe.IdPlanta = @IdPlanta
group by cc.idpaqueteencabezado,pe.cantidadpacas,pe.IdPaquete,pe.IdPlanta,clcl.ClaveCorta, Comp.Nombre,pe.Entrega
--having count(cc.idpaqueteencabezado)> 125 or count(cc.idpaqueteencabezado)<125 
order by cc.IdPaqueteEncabezado
end 
else if @IdPlanta = 0 and @IdClase > 0 and @Mayor = 0 and @Menor = 0
begin 
select pe.IdPaquete,
	   pe.CantidadPacas,
	   pe.IdPlanta,
	   clcl.ClaveCorta as Clase,
	   isnull(Comp.Nombre,'') as Nombre,
	   pe.Entrega	     
from paqueteencabezado pe right join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado
						  inner join ClasesClasificacion clcl on pe.IdClase = clcl.IdClasificacion
						  left join Compradores Comp on pe.idComprador = Comp.IdComprador
where pe.IdClase = @IdClase
group by cc.idpaqueteencabezado,pe.cantidadpacas,pe.IdPaquete,pe.IdPlanta,clcl.ClaveCorta, Comp.Nombre,pe.Entrega
--having count(cc.idpaqueteencabezado)> 125 or count(cc.idpaqueteencabezado)<125 
order by cc.IdPaqueteEncabezado
end 
else if  @IdPlanta > 0 and @IdClase > 0 and @Mayor = 0 and @Menor = 0
begin 
select pe.IdPaquete,
	   pe.CantidadPacas,
	   pe.IdPlanta,
	   clcl.ClaveCorta as Clase,
	   isnull(Comp.Nombre,'') as Nombre,
	   pe.Entrega	     
from paqueteencabezado pe right join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado
						  inner join ClasesClasificacion clcl on pe.IdClase = clcl.IdClasificacion
						  left join Compradores Comp on pe.idComprador = Comp.IdComprador
where pe.IdPlanta = @IdPlanta and pe.IdClase = @IdClase
group by cc.idpaqueteencabezado,pe.cantidadpacas,pe.IdPaquete,pe.IdPlanta,clcl.ClaveCorta, Comp.Nombre,pe.Entrega
--having count(cc.idpaqueteencabezado)> 125 or count(cc.idpaqueteencabezado)<125 
order by cc.IdPaqueteEncabezado
end 
else if  @IdPlanta = 0 and @IdClase = 0 and @Mayor = 0 and @Menor = 1
begin 
select pe.IdPaquete,
	   pe.CantidadPacas,
	   pe.IdPlanta,
	   clcl.ClaveCorta as Clase,
	   isnull(Comp.Nombre,'') as Nombre,
	   pe.Entrega	     
from paqueteencabezado pe right join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado
						  inner join ClasesClasificacion clcl on pe.IdClase = clcl.IdClasificacion
						  left join Compradores Comp on pe.idComprador = Comp.IdComprador
--where pe.IdPaquete = @IdPaquete and pe.IdPlanta = @IdPlanta and pe.IdClase = @IdClase
group by cc.idpaqueteencabezado,pe.cantidadpacas,pe.IdPaquete,pe.IdPlanta,clcl.ClaveCorta, Comp.Nombre,pe.Entrega
having pe.CantidadPacas < @CantidadPacas 
order by cc.IdPaqueteEncabezado
end 
else if @IdPlanta = 0 and @IdClase = 0 and @Mayor = 1 and @Menor = 0
begin 
select pe.IdPaquete,
	   pe.CantidadPacas,
	   pe.IdPlanta,
	   clcl.ClaveCorta as Clase,
	   isnull(Comp.Nombre,'') as Nombre,
	   pe.Entrega	     
from paqueteencabezado pe right join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado
						  inner join ClasesClasificacion clcl on pe.IdClase = clcl.IdClasificacion
						  left join Compradores Comp on pe.idComprador = Comp.IdComprador
--where pe.IdPaquete = @IdPaquete and pe.IdPlanta = @IdPlanta and pe.IdClase = @IdClase
group by cc.idpaqueteencabezado,pe.cantidadpacas,pe.IdPaquete,pe.IdPlanta,clcl.ClaveCorta, Comp.Nombre,pe.Entrega
having pe.CantidadPacas > @CantidadPacas 
order by cc.IdPaqueteEncabezado
end 
else if @IdPlanta = 0 and @IdClase = 0 and @Mayor = 1 and @Menor = 1
begin 
select pe.IdPaquete,
	   pe.CantidadPacas,
	   pe.IdPlanta,
	   clcl.ClaveCorta as Clase,
	   isnull(Comp.Nombre,'') as Nombre,
	   pe.Entrega	     
from paqueteencabezado pe right join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado
						  inner join ClasesClasificacion clcl on pe.IdClase = clcl.IdClasificacion
						  left join Compradores Comp on pe.idComprador = Comp.IdComprador
--where pe.IdPaquete = @IdPaquete and pe.IdPlanta = @IdPlanta and pe.IdClase = @IdClase
group by cc.idpaqueteencabezado,pe.cantidadpacas,pe.IdPaquete,pe.IdPlanta,clcl.ClaveCorta, Comp.Nombre,pe.Entrega
having pe.CantidadPacas > @CantidadPacas and pe.CantidadPacas < @CantidadPacas
order by cc.IdPaqueteEncabezado
end 