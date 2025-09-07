create procedure pa_reportedatosempresa
as
SELECT top 1 [IdDatosEmpresa]
      ,[RazonSocial]
      ,[RFCEmpresa]
      ,[Calle]
      ,[NumExt]
      ,[Colonia]
      ,[CodigoPostal]
      ,[Municipio]
      ,[Estado]
      ,[Pais]
	  ,[logoempresa]
  FROM [dbo].[DatosEmpresa]