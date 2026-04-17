CREATE PROCEDURE ListarPets
AS
BEGIN
    SELECT id, Nome, Especie, Raca, Idade 
    FROM pets 
    ORDER BY Nome ASC;
END
GO