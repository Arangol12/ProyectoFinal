USE [ProyectoFinal]

GO
ALTER proc [dbo].[sp_agregar_Usuario_Docente] 
 @nombreUsuario varchar(50),
 @contraseña varchar (50),
 @nombre varchar (50),
 @apellido varchar (50),
 @dni int,
 @tipoDocumento varchar (50),
 @correoElectronico varchar (50)
 as 
 insert Usuario_Docente (nombreUsuario,contraseña,nombre,apellido,dni,tipoDocumento,correoElectronico)
 values (@nombreUsuario,@contraseña,@nombre,@apellido,@dni,@tipoDocumento,@correoElectronico)
