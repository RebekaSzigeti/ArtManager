USE Galeria;
GO

CREATE OR ALTER PROCEDURE FelhasznaloBeszurasa (@pfelhasznaloNev VARCHAR(100), @pVasarloNev VARCHAR(100), @pJelszo VARCHAR(250), @pSalt VARCHAR(250))
AS
BEGIN

SET TRANSACTION ISOLATION LEVEL SERIALIZABLE
BEGIN TRANSACTION

INSERT INTO Felhasznalok (FelhNev, Jelszo, Salt, FelhCsopID)
VALUES (@pfelhasznaloNev, @pJelszo, @pSalt, 1);

IF @@ERROR <>0
	BEGIN
		ROLLBACK
		RAISERROR('Sikertelen beszuras - Felhasznalok',12,1)
		RETURN 1
	END

DECLARE @FelhasznaloID INT = SCOPE_IDENTITY();

INSERT INTO Vasarlok (Nev)
VALUES (@pVasarloNev);

IF @@ERROR <>0
	BEGIN
		ROLLBACK
		RAISERROR('Sikertelen beszuras - Vasarlok',12,1)
		RETURN 1
	END


DECLARE @VasarloID INT = SCOPE_IDENTITY();


INSERT INTO FelhasznaloVasarlo (FelhID, VasarloID)
VALUES (@FelhasznaloID, @VasarloID);
IF @@ERROR <>0
	BEGIN
		ROLLBACK
		RAISERROR('Sikertelen beszuras - FelhasznaloVasarlo',12,1)
		RETURN 1
	END

COMMIT


END;
GO
