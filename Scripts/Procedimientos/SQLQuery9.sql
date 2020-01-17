/****** Script para el comando SelectTopNRows de SSMS  ******/
SELECT CACL.[BaleID]
	  ,CACL.[SCI]
      ,CACL.[Moist]
      ,CACL.[Mic]
      ,CACL.[Maturity]
      ,CACL.[UHML]
      ,CACL.[UI]
      ,CACL.[SFI]
      ,CACL.[Strength]
      ,CACL.[Elongation]
      ,CACL.[Rd]
      ,CACL.[Plusb]
      ,''''+CACL.[ColorGrade]+'''' as ColorGrade
      ,CACL.[TrashCount]
      ,CACL.[TrashArea]
      ,CACL.[TrashID]
	  ,GRCL.[TrashId]
      ,CACL.[Amount]
      ,CACL.[Grade]    
	  ,CLCL.ClaveCorta AS GradeNew 
	  ,CACL.[Kilos]
	  ,CACL.[IdVentaEnc]
  FROM [ALGODON2019].[dbo].[CalculoClasificacion] CACL left join GradosClasificacion GRCL on CACL.ColorGrade = GRCL.GradoColor and CACL.TrashID = GRCL.TrashId
					left join ClasesClasificacion CLCL on GRCL.IdClase = CLCL.IdClasificacion
  where idpaqueteencabezado in (152,154,155,157,205,194,199,209,211,215,151,188,189,190,191,192,194,196,293)
  order by baleid


  SELECT * FROM ClasesClasificacion
  SELECT * FROM GradosClasificacion