create procedure Pa_RestauraParametrosCastigoVta
@IdVenta int
as
update cc
set cc.Mic = hd.Mic,
	cc.UHML = hd.UHML,
	cc.Strength = hd.Strength,
	cc.UI = hd.UI
from hvidetalle hd inner join calculoclasificacion cc on hd.baleid = cc.BaleID and hd.IdOrdenTrabajo = cc.IdOrdenTrabajo
where idventaenc = @IdVenta