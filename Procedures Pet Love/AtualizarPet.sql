CREATE PROCEDURE AtualizarPet
    @id INT,
    @Nome VARCHAR(100),
    @Especie VARCHAR(50),
    @Raca VARCHAR(50),
    @Idade INT
AS
BEGIN
    UPDATE pets
    SET Nome = @Nome,
        Especie = @Especie,
        Raca = @Raca,
        Idade = @Idade
    WHERE id = @id;
END
GO