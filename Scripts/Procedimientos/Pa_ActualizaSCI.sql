Create Procedure Pa_ActualizaSCI
as
update HviDetalle
set SCI = round((-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB),0);

update CalculoClasificacion
set SCI = round((-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB),0);