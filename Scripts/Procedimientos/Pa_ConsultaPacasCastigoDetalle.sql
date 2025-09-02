Create Procedure Pa_ConsultaPacasCastigoDetalle
@IdVenta int ,
@IdModoMicEnc int ,
@IdModoResEnc int ,
@IdModoUIEnc int  ,
@IdModoLargoEnc int  ,
@UnidadPeso int,
@CkMic bit ,
@CkRes bit ,
@CkUI  bit ,
@CkLargo bit 
as
if @UnidadPeso = 1
begin
select Baleid as 'Etiqueta',
	   Kilos,
	   Quintales,
	   Grade,
	  CASE @CkMic
	  WHEN 0 THEN 0
	  ELSE round(Mic,2,1) END as Mic,

	   CASE @CkMic
	  WHEN 0 THEN 0
	  ELSE (select castigo from microsdetalle where idmodoencabezado = @IdModoMicEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'Micro Castigo',

	   CASE @CkMic
	  WHEN 0 THEN 0
	  ELSE round(isnull(castigomicventa,0),2) END as 'Mic Resultado Castigo',

	   CASE @CkMic
	  WHEN 0 THEN 0
	  ELSE (select Rango1 from microsdetalle where idmodoencabezado = @IdModoMicEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'Mic Rango 1',
	   
	    CASE @CkMic
	  WHEN 0 THEN 0
	  ELSE (select Rango2 from microsdetalle where idmodoencabezado = @IdModoMicEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'Mic Rango 2',

	   CASE @CkRes
	  WHEN 0 THEN 0
	  ELSE ROUND(Strength,2,1) END as Resistencia,

	   CASE @CkRes
	  WHEN 0 THEN 0
	  ELSE (select castigo from ResistenciaDetalle where idmodoencabezado = @IdModoResEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'Resistencia Castigo',

	   CASE @CkRes
	  WHEN 0 THEN 0
	  ELSE round(isnull(CastigoResistenciaFibraVenta,0),2) END as 'Res Resultado Castigo',

	   CASE @CkRes
	  WHEN 0 THEN 0
	  ELSE (select Rango1 from ResistenciaDetalle where idmodoencabezado = @IdModoResEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'Res Rango 1', 

	   CASE @CkRes
	  WHEN 0 THEN 0
	  ELSE (select Rango2 from ResistenciaDetalle where idmodoencabezado = @IdModoResEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'Res Rango 2',

	   CASE @CkUI
	  WHEN 0 THEN 0
	  ELSE ROUND(UI,2,1) END as Uniformidad,

	   CASE @CkUI
	  WHEN 0 THEN 0
	  ELSE (select castigo from UniformidadDetalle where idmodoencabezado = @IdModoUIEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'UI Castigo',

	   CASE @CkUI
	  WHEN 0 THEN 0
	  ELSE round(isnull(CastigoUIVenta,0),2) END as 'UI Resultado Castigo',

	   CASE @CkUI
	  WHEN 0 THEN 0
	  ELSE (select Rango1 from UniformidadDetalle where idmodoencabezado = @IdModoUIEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'UI Rango 1', 

	   CASE @CkUI
	  WHEN 0 THEN 0
	  ELSE (select Rango2 from UniformidadDetalle where idmodoencabezado = @IdModoUIEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'UI Rango 2',

	   CASE @CkLargo
	  WHEN 0 THEN 0
	  ELSE ROUND(UHML,2,1) END as 'Largo de Fibra',

	   CASE @CkLargo
	  WHEN 0 THEN 0
	  ELSE (select castigo from LargosFibraDetalle where (select LenghtNDS from LargosFibraEquivalenteDetalle where round(UHML,2,1) between  Rango1 and Rango2 and IdModoEncabezado = @IdModoLargoEnc) between  Rango1 and Rango2 and IdModoEncabezado = @IdModoLargoEnc) END as 'Largo Castigo',

	   CASE @CkLargo
	  WHEN 0 THEN 0
	  ELSE ROUND(isnull(CastigoLargoFibraVenta,0),2) END as 'Largo Resultado Castigo',	
	     
	   CASE @CkLargo
	  WHEN 0 THEN 0
	  ELSE (select Rango1 from LargosFibraDetalle where (select LenghtNDS from LargosFibraEquivalenteDetalle where round(UHML,2,1) between  Rango1 and Rango2 and IdModoEncabezado = @IdModoLargoEnc) between  Rango1 and Rango2 and IdModoEncabezado = @IdModoLargoEnc) END as 'Largo Rango 1',

	   CASE @CkLargo
	  WHEN 0 THEN 0
	  ELSE (select Rango2 from LargosFibraDetalle where (select LenghtNDS from LargosFibraEquivalenteDetalle where round(UHML,2,1) between  Rango1 and Rango2 and IdModoEncabezado = @IdModoLargoEnc) between  Rango1 and Rango2 and IdModoEncabezado = @IdModoLargoEnc) END as 'Largo Rango 2'
		from calculoclasificacion 
		where idventaenc=@IdVenta
		order by baleid
end
else if @UnidadPeso = 2
begin
select BaleID as 'Etiqueta',
	   Kilos,
	   quintales as Libras,
	   Grade,
	  CASE @CkMic
	  WHEN 0 THEN 0
	  ELSE round(Mic,2,1) END as Mic,

	   CASE @CkMic
	  WHEN 0 THEN 0
	  ELSE (select castigo from microsdetalle where idmodoencabezado = @IdModoMicEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'Micro Castigo',

	   CASE @CkMic
	  WHEN 0 THEN 0
	  ELSE round(isnull(castigomicventa,0),2) END as 'Mic Resultado Castigo',

	   CASE @CkMic
	  WHEN 0 THEN 0
	  ELSE (select Rango1 from microsdetalle where idmodoencabezado = @IdModoMicEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'Mic Rango 1',
	   
	    CASE @CkMic
	  WHEN 0 THEN 0
	  ELSE (select Rango2 from microsdetalle where idmodoencabezado = @IdModoMicEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'Mic Rango 2',

	   CASE @CkRes
	  WHEN 0 THEN 0
	  ELSE ROUND(Strength,2,1) END as Resistencia,

	   CASE @CkRes
	  WHEN 0 THEN 0
	  ELSE (select castigo from ResistenciaDetalle where idmodoencabezado = @IdModoResEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'Resistencia Castigo',

	   CASE @CkRes
	  WHEN 0 THEN 0
	  ELSE round(isnull(CastigoResistenciaFibraVenta,0),2) END as 'Res Resultado Castigo',

	   CASE @CkRes
	  WHEN 0 THEN 0
	  ELSE (select Rango1 from ResistenciaDetalle where idmodoencabezado = @IdModoResEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'Res Rango 1', 

	   CASE @CkRes
	  WHEN 0 THEN 0
	  ELSE (select Rango2 from ResistenciaDetalle where idmodoencabezado = @IdModoResEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'Res Rango 2',

	   CASE @CkUI
	  WHEN 0 THEN 0
	  ELSE ROUND(UI,2,1) END as Uniformidad,

	   CASE @CkUI
	  WHEN 0 THEN 0
	  ELSE (select castigo from UniformidadDetalle where idmodoencabezado = @IdModoUIEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'UI Castigo',

	   CASE @CkUI
	  WHEN 0 THEN 0
	  ELSE round(isnull(CastigoUIVenta,0),2) END as 'UI Resultado Castigo',

	   CASE @CkUI
	  WHEN 0 THEN 0
	  ELSE (select Rango1 from UniformidadDetalle where idmodoencabezado = @IdModoUIEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'UI Rango 1', 

	   CASE @CkUI
	  WHEN 0 THEN 0
	  ELSE (select Rango2 from UniformidadDetalle where idmodoencabezado = @IdModoUIEnc and round(Mic,2,1) between Rango1 and Rango2 ) END as 'UI Rango 2',

	   CASE @CkLargo
	  WHEN 0 THEN 0
	  ELSE ROUND(UHML,2,1) END as 'Largo de Fibra',

	   CASE @CkLargo
	  WHEN 0 THEN 0
	  ELSE (select castigo from LargosFibraDetalle where (select LenghtNDS from LargosFibraEquivalenteDetalle where round(UHML,2,1) between  Rango1 and Rango2 and IdModoEncabezado = @IdModoLargoEnc) between  Rango1 and Rango2 and IdModoEncabezado = @IdModoLargoEnc) END as 'Largo Castigo',

	   CASE @CkLargo
	  WHEN 0 THEN 0
	  ELSE ROUND(isnull(CastigoLargoFibraVenta,0),2) END as 'Largo Resultado Castigo',	
	     
	   CASE @CkLargo
	  WHEN 0 THEN 0
	  ELSE (select Rango1 from LargosFibraDetalle where (select LenghtNDS from LargosFibraEquivalenteDetalle where round(UHML,2,1) between  Rango1 and Rango2 and IdModoEncabezado = @IdModoLargoEnc) between  Rango1 and Rango2 and IdModoEncabezado = @IdModoLargoEnc) END as 'Largo Rango 1',

	   CASE @CkLargo
	  WHEN 0 THEN 0
	  ELSE (select Rango2 from LargosFibraDetalle where (select LenghtNDS from LargosFibraEquivalenteDetalle where round(UHML,2,1) between  Rango1 and Rango2 and IdModoEncabezado = @IdModoLargoEnc) between  Rango1 and Rango2 and IdModoEncabezado = @IdModoLargoEnc) END as 'Largo Rango 2'
		from calculoclasificacion 
		where idventaenc=@IdVenta
		order by baleid
end