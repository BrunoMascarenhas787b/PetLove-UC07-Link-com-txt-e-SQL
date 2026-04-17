USE PetLoveDB3;
GO

CREATE PROCEDURE spInserirPet
    @Nome VARCHAR(100),
    @Especie VARCHAR(50),
    @Raca VARCHAR(50),
    @Idade INT
AS
BEGIN
    INSERT INTO pets (Nome, Especie, Raca, Idade)
    VALUES (@Nome, @Especie, @Raca, @Idade);
END
GO