CREATE DATABASE ArticulosDb
GO
USE ArticulosDb
GO
CREATE TABLE Articulos
(
   ArticuloID int primary key identity(1,1),
   FechaVencimiento varchar(8),
   Descripcion varchar(max),
   precio money,
   Existencia int,
   CantidadCotizada int
);
 