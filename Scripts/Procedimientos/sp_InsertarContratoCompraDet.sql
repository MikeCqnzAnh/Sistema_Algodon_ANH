alter procedure sp_InsertarContratoCompraDet
@IdContratoAlgodonDetalle int,
@IdContratoAlgodon int,
@IdLote int,
@SuperficieContratada float
as
begin
set nocount on
merge [dbo].[ContratoCompraDetalle] as target
using (select @IdContratoAlgodonDetalle,@IdContratoAlgodon,@IdLote,@SuperficieContratada) as source (IdContratoAlgodonDetalle,IdContratoAlgodon,IdLote,SuperficieContratada)
ON (target.IdContratoAlgodon = source.IdContratoAlgodon AND target.IdLote = source.IdLote)
WHEN MATCHED THEN
UPDATE SET IdContratoAlgodon = source.IdContratoAlgodon,
		   IdLote = source.IdLote,
		   SuperficieContratada = source.SuperficieContratada		   
WHEN NOT MATCHED THEN
INSERT (IdContratoAlgodon,IdLote,SuperficieContratada)
VALUES (source.IdContratoAlgodon,source.IdLote,source.SuperficieContratada);
DECLARE
@VariableSupRest float = (select SuperficieRestante from dbo.TierraDetalle a where a.IdTierraDetalle = @IdLote) 
IF @VariableSupRest >= 0
BEGIN
UPDATE [dbo].[TierraDetalle]
SET    SuperficieRestante = SuperficieRestante - @SuperficieContratada
WHERE  IdTierraDetalle = @IdLote
END
END