Create Procedure Sp_InsertaPerfilUsuario
@IdPerfilUsuario int,
@IdUsuario int,
@IdNodo int,
@IdPadre int,
@IdTipo int,
@IdEstatus bit
as
begin 
set nocount on
merge PerfilUsuario as target
using (select @IdPerfilUsuario,@IdUsuario,@IdNodo,@IdPadre,@IdTipo,@IdEstatus) AS SOURCE (IdPerfilUsuario,IdUsuario,IdNodo,IdPadre,IdTipo,IdEstatus)
ON (target.IdPerfilUsuario = SOURCE.IdPerfilUsuario)
WHEN MATCHED THEN
UPDATE SET IdUsuario = Source.IdUsuario,
		   IdNodo = source.IdNodo,
		   IdPadre = source.IdPadre,
		   IdTipo = source.IdTipo,
		   IdEstatus = source.IdEstatus
WHEN NOT MATCHED THEN
INSERT (IdUsuario,IdNodo,IdPadre,IdTipo,IdEstatus)
        VALUES (source.IdUsuario,source.IdNodo,source.IdPadre,source.IdTipo,source.IdEstatus);
		SET @IdPerfilUsuario = SCOPE_IDENTITY()
		END