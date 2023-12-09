use ProyectoFinal
go
CREATE PROCEDURE sp_ObtenerDistrito
AS
    SELECT Distrito
    FROM ubigeo_reniec$
go

create procedure sp_obtenerProvincia
as
select provincia
from ubigeo_reniec$;
go
create procedure sp_Obtener_Departamento
as 
select Departamento
from ubigeo_reniec$;
go