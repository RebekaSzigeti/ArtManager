USE Galeria;
GO

CREATE OR ALTER TRIGGER Delete_Trigger
ON Mualkotasok
INSTEAD OF DELETE
AS BEGIN

	DELETE k
	FROM KosarTartalma k
	JOIN deleted d ON d.MualkotasID = k.TermekKod;

	DELETE v
	FROM VasaroltMualkotasok v
	JOIN deleted d ON d.MualkotasID = v.MualkotasID;


	DELETE a
	FROM AlkotasMuvesz a
	JOIN deleted d ON d.MualkotasID = a.MualkotasID;

	DELETE m
	FROM Mualkotasok m
	JOIN deleted d ON d.MualkotasID = m.MualkotasID;


END;
GO