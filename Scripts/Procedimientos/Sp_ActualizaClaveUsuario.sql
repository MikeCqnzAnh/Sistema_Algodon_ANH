Create Procedure Sp_ActualizaClaveUsuario
@BaseDeDatos varchar(30),
@Usuario varchar(15),
@Clave varchar(max)
as
exec('UPDATE ['+@BaseDeDatos+'].[dbo].[Usuarios]
	  SET CLAVE ='+@Clave+'
	  WHERE USUARIO ='+@USUARIO+'')