Create Procedure Pa_ConsultaCompradorPorcuenta
@IdComprador int 
as 
select idcomprador
	  ,Nombre 
from Compradores 
where IdComprador <> @IdComprador