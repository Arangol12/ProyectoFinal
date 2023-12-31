USE [ProyectoFinal]
GO

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[sp_RecuperarContraseña]
    @correoElectronico VARCHAR(100)
AS
BEGIN
    DECLARE @nuevaContraseña NVARCHAR(50);
    
    IF EXISTS (SELECT 1 FROM Usuario_Docente WHERE correoElectronico = @correoElectronico)
    BEGIN       
        SET @nuevaContraseña = 'NuevaContraseña123'; 
           
        UPDATE Usuario_Docente SET contraseña = @nuevaContraseña WHERE correoElectronico = @correoElectronico;
       
        SELECT @nuevaContraseña AS NuevaContraseña;
    END
    ELSE
    BEGIN     
        PRINT 'El correo electrónico no está registrado en el sistema.';
    end
	end;