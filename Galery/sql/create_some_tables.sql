USE Galeria;
GO


CREATE TABLE FelhasznaloCsoportok ( 
	CsopID INT PRIMARY KEY IDENTITY(1,1),
	CsopNev NVARCHAR(50) NOT NULL 
);

CREATE TABLE Felhasznalok (
    FelhID INT PRIMARY KEY IDENTITY(1,1),
    FelhNev NVARCHAR(50) UNIQUE NOT NULL,
    Jelszo NVARCHAR(255) NOT NULL,
    Salt NVARCHAR(255) NOT NULL,
    FelhCsopID INT NOT NULL,
    CONSTRAINT FK_Felh_Csoport FOREIGN KEY (FelhCsopID)
        REFERENCES FelhasznaloCsoportok(CsopID)
);

CREATE TABLE FelhasznaloVasarlo (
    FelhID INT PRIMARY KEY,
    VasarloID INT NOT NULL UNIQUE,
    FOREIGN KEY (FelhID) REFERENCES Felhasznalok(FelhID),
    FOREIGN KEY (VasarloID) REFERENCES Vasarlok(VasarloID)
);

CREATE TABLE FelhasznaloElado (
    FelhID INT PRIMARY KEY,
    EladoID INT NOT NULL UNIQUE,
    FOREIGN KEY (FelhID) REFERENCES Felhasznalok(FelhID),
    FOREIGN KEY (EladoID) REFERENCES Eladok(EladoID)
);

