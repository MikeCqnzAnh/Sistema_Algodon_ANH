create procedure sp_ConCasLarFib
as
select a.IdLargoFibra,
       a.Rango1,
	   a.Rango2,
	   a.ColorGrade,
	   a.castigo
from [dbo].[LargosDeFibra] a
where a.IdEstatus = 1