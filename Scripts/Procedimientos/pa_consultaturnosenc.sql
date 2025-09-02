create procedure pa_consultaturnosenc
as
select te.idturnoenc,
	   te.Descripcion,
	   te.IdPlanta,
	   pl.Descripcion as Planta,
	   te.HoraEntrada,
	   te.HoraSalida 
from turnosenc te inner join Plantas pl on te.idplanta = pl.IdPlanta