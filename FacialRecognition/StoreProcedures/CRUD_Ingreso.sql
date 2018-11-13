id_ingreso	        int	
faceid	            int	
nombre	            nvarchar(255)	
depto	            nvarchar(50)	
horadetectada	    datetime	


USE [dbprod]
CREATE PROCEDURE [dbo].[insRegistro]
@nombre nvarchar(255),
@faceid int,
@depto nvarchar(50),
@horadetectada datetime

AS
Insert into dbo.tbingreso(nombre,faceid,depto,horadetectada)
values(@nombre,@faceid, @depto,@horadetectada)