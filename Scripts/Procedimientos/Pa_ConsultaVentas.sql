alter procedure Pa_ConsultaVentas
as
select vp.IdVenta
	  ,vp.IdContratoAlgodon
	  ,Co.Nombre
	  --,pl.Descripcion as Planta
	  ,vp.TotalPacas
	  ,vp.Subtotal
	  ,vp.CastigoDls 
	  ,vp.TotalDlls
	  ,vp.Fecha
	  ,pc.EstatusPesoNeto
	  ,pc.KilosNeto as Tara
from VentaPacas vp inner join Compradores Co on vp.IdComprador = Co.IdComprador
					--inner join Plantas pl on vp.IdPlanta = pl.IdPlanta
					inner join ParametrosContratoVenta pc on vp.IdContratoAlgodon = pc.IdContratoVenta
where (select count(baleid) from CalculoClasificacion where vp.IdVenta = IdVentaEnc)>0
order by vp.idventa


