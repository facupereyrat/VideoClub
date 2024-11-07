USE [Video Club]

--Se pide ingresar a la BD la información del pdf:

INSERT INTO Calificacion(IdCalificacion, NomCalificacion) VALUES
(1, 'ATP'),
(2, 'PG+13'),
(3, 'PG+16'),
(4, 'R+16');

INSERT INTO Genero (IdGenero, NomGenero)
VALUES
(1, 'Accion'),
(2, 'Comedia'),
(3, 'Drama'),
(4, 'Ciencia Ficcion'),
(5, 'Suspenso'),
(6, 'Terror');

INSERT INTO Pelicula (IdPelicula, Titutlo, Duracion, Anio, Precio, IdGenero, IdCalificacion, IdSucursal)
VALUES
(1, 'Los juegos del hambre', 121, 2012, 50, 1, 2, 1),
(2, 'Django', 110, 2018, 65, 1, 2, 2),
(3, 'Mision imposible', 105, 2018, 35, 1, 2, 3),
(4, 'Hombres de negro', 96, 2019, 35, 2, 1, 1),
(5, 'El futbol o yo', 85, 2017, 45, 2, 1, 2),
(6, 'El camino', 103, 2019, 100, 3, 2, 1),
(7, 'Secreta obsesion', 98, 2019, 85, 3, 3, 3),
(8, 'Los vengadores', 125, 2015, 100, 4, 1, 3),
(9, 'Transformers', 115, 2013, 90, 4, 1, 3),
(10, 'Jurassic park', 112, 1993, 75, 4, 1, 1),
(11, 'Los inquilinos', 90, 1998, 45, 5, 2, 2),
(12, 'Tiburon', 95, 1975, 75, 5, 2, 3),
(13, 'Mama', 100, 2008, 50, 6, 3, 1),
(14, 'La llorona', 92, 2018, 80, 6, 3, 2),
(15, 'El conjuro', 98, 2014, 95, 6, 4, 2);


INSERT INTO Sucursal (IdSucursal, NomSucursal)
VALUES
(1, 'Calera'),
(2, 'Cosquin'),
(3, 'Cordoba');

-- Cambiar la calificación de la película Mamá a PG+13

UPDATE Pelicula
SET IdCalificacion = (SELECT IdCalificacion FROM Calificacion WHERE NomCalificacion = 'PG+13')
WHERE Titutlo = 'Mama';

--Llegó al Vídeo Club una actualización tarifaria del 15.5% en los precios.

UPDATE Pelicula
SET Precio = ROUND(Precio * 1.155, 0);

--Como el dueño del Vídeo Club es muy quisquilloso, solicita se pongan acento a todos los títulos, géneros y sucursales que no los tengan.


UPDATE Pelicula
SET Titutlo = REPLACE(Titutlo, 'Mama', 'Mamá'), 'La llorona', 'La Llorona'), 'Hombres de negro', 'Hombres de Negro')  
WHERE Titutlo IN ('Mama', 'La llorona', 'Hombres de negro');  


UPDATE Genero
SET NomGenero = REPLACE(NomGenero, 'Accion', 'Acción')
WHERE NomGenero = 'Accion';


UPDATE Sucursal
SET NomSucursal = REPLACE(NomSucursal, 'Calera', 'Calera') 
WHERE NomSucursal IN ('Calera', 'Cosquin', 'Cordoba');  
 
