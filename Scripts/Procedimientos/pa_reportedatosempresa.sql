create procedure pa_reportedatosempresa
as
SELECT top 1 iddatosempresa,
		razonsocial,
		rfcempresa,
		representantelegal,
		rfcrepresentante,
		calle,
		numext,
		numint,
		entrecalle1,
		entrecalle2,
		colonia,
		referencia,
		poblacion,
		codigopostal,
		pais,
		estado,
		municipio,
		lugarexpedicion,
		logoempresa
  FROM DatosEmpresa
