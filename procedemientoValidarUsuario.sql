USE [ProyectoFinal]
go
 ALTER proc [dbo].[validar_Usuario]
 @dni int,
 @correoElectronico varchar (50)
 as
 select nombre from Usuario_Docente
 where dni=@dni or correoElectronico=@correoElectronico;
