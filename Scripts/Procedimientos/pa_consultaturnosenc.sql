CREATE procedure pa_consultaturnosenc
as
select te.idturnoenc,
	   te.Descripcion,
	   te.idplanta,
	   pl.Descripcion as Planta,
	   te.idresponsableturno,
	   te.Responsableturno,
	   te.idresponsableprensa,	   
	   te.responsableprensa,
	   te.HoraEntrada,
	   te.HoraSalida 
from turnosenc te inner join Plantas pl on te.idplanta = pl.IdPlanta