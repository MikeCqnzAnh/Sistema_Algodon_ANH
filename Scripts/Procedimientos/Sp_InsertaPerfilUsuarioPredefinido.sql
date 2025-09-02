Create Procedure Sp_InsertaPerfilUsuarioPredefinido
@IdPerfilUsuario int ,
@IdUsuario int ,
@IdNodo int ,
@IdPadre int ,
@IdTipoUsuario int ,
@IdEstatus bit 
as
begin 
set nocount on
merge PerfilUsuario as target
using (select @IdPerfilUsuario,@IdUsuario,@IdNodo,@IdPadre,@IdTipoUsuario,@IdEstatus) AS SOURCE (IdPerfilUsuario,IdUsuario,IdNodo,IdPadre,IdTipoUsuario,IdEstatus)
ON (target.IdUsuario = SOURCE.IdUsuario and target.IdTipoUsuario = SOURCE.IdTipoUsuario and target.IdNodo = SOURCE.IdNodo)
WHEN MATCHED THEN
UPDATE SET IdUsuario = Source.IdUsuario,
		   IdNodo = source.IdNodo,
		   IdPadre = source.IdPadre,
		   IdTipoUsuario = source.IdTipoUsuario,
		   IdEstatus = source.IdEstatus
WHEN NOT MATCHED THEN
INSERT (IdUsuario,IdNodo,IdPadre,IdTipoUsuario,IdEstatus)
        VALUES (source.IdUsuario,source.IdNodo,source.IdPadre,source.IdTipoUsuario,source.IdEstatus);
		SET @IdPerfilUsuario = SCOPE_IDENTITY()
		END