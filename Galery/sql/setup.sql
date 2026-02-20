USE Galeria;
GO

DROP TABLE IF EXISTS KosarTartalma;
DROP TABLE IF EXISTS Kosarak;
DROP TABLE IF EXISTS VasaroltMualkotasok;
DROP TABLE IF EXISTS AlkotasMuvesz;
DROP TABLE IF EXISTS Vasarlasok;
DROP TABLE IF EXISTS Vasarlok;
DROP TABLE IF EXISTS Eladok;
DROP TABLE IF EXISTS Mualkotasok;
DROP TABLE IF EXISTS Muveszek;

CREATE TABLE Muveszek(
	MuveszID INT IDENTITY(1,1),
	Nev VARCHAR(100) NOT NULL,
	Stilus VARCHAR(50) DEFAULT '?',
	CONSTRAINT PK_Muveszek PRIMARY KEY(MuveszID)
);

CREATE TABLE Mualkotasok(
	MualkotasID INT IDENTITY (1,1),
	AlkotasEve INT NOT NULL,
	Cim VARCHAR(100) NOT NULL,
	Ar INT NOT NULL,
	StilusIranyzat VARCHAR(50) DEFAULT '?',
	CONSTRAINT PK_Mualkotasok PRIMARY KEY(MualkotasID)
);

CREATE TABLE Eladok(
	EladoID INT IDENTITY(1,1),
	Nev VARCHAR(100) NOT NULL,
	Fizetes INT NOT NULL,
	CONSTRAINT PK_Eladok PRIMARY KEY(EladoID)
);

CREATE TABLE Vasarlok(
	VasarloID INT IDENTITY(1,1),
	Nev VARCHAR(100) NOT NULL,
	CONSTRAINT PK_Vasarlok PRIMARY KEY(VasarloID)
);

CREATE TABLE Vasarlasok(
	VasarlasID INT IDENTITY(1,1),
	Datum DATE NOT NULL,
	Vegosszeg INT NOT NULL,
	VasarloID INT NOT NULL,
	EladoID INT NOT NULL,
	CONSTRAINT PK_Vasarlasok PRIMARY KEY(VasarlasID),
	CONSTRAINT FK_Vasarlas_Vasarlo FOREIGN KEY (VasarloID)
        REFERENCES Vasarlok(VasarloID)
        ON DELETE CASCADE
        ON UPDATE CASCADE,
    CONSTRAINT FK_Vasarlas_Elado FOREIGN KEY (EladoID)
        REFERENCES Eladok(EladoID)
        ON DELETE CASCADE
        ON UPDATE CASCADE

);

CREATE TABLE AlkotasMuvesz(
	MuveszID INT NOT NULL,
	MualkotasID INT NOT NULL,
	CONSTRAINT PK_AlkotasMuvesz PRIMARY KEY (MuveszID, MualkotasID),
	CONSTRAINT FK_MuveszID FOREIGN KEY (MuveszID)
		REFERENCES Muveszek(MuveszID)
		ON DELETE CASCADE
        ON UPDATE CASCADE,
	CONSTRAINT FK_AlkotasMuvesz_MualkotasID FOREIGN KEY (MualkotasID)
		REFERENCES Mualkotasok(MualkotasID)
		ON DELETE CASCADE
        ON UPDATE CASCADE
);

CREATE TABLE VasaroltMualkotasok(
	MualkotasID INT NOT NULL,
	VasarlasID INT NOT NULL,
	CONSTRAINT PK_VasaroltMualkotasok PRIMARY KEY(MualkotasID, VasarlasID),
	CONSTRAINT FK_VasaroltMualkotasok_MualkotasID FOREIGN KEY (MualkotasID)
		REFERENCES Mualkotasok(MualkotasID)
		ON DELETE CASCADE
        ON UPDATE CASCADE,
	CONSTRAINT FK_VasarlasID FOREIGN KEY (VasarlasID)
		REFERENCES Vasarlasok(VasarlasID)
		ON DELETE CASCADE
        ON UPDATE CASCADE
);

INSERT INTO Mualkotasok (AlkotasEve, Cim, StilusIranyzat, Ar) VALUES 
(1998, 'Csendes part', 'Impresszionizmus', 12000),
(1990, 'Szikla', 'Expresszionizmus', 3000),
(2005, 'Oszi harmonia', 'Realizmus', 9500),
(2010, 'Oszi vihar', 'Impresszionizmus', 3800),
(2015, 'Fagyott dallam', 'Szurrealizmus', 4000);

INSERT INTO Muveszek (Nev, Stilus) VALUES 
('Sophie Leclair', 'Szurrealizmus'),
('Elena Petrov', 'Realizmus'),
('Sophie Ferrante', 'Expresszionizmus'),
('Taylor Hill', 'Realizmus'),
('Sara Sampaio', 'Impresszionizmus');

INSERT INTO AlkotasMuvesz (MuveszID, MualkotasID) VALUES
(2,3),
(4,3),
(5,1),
(5,4),
(1,5),
(3,2);

INSERT INTO Eladok (Nev, Fizetes) VALUES
('Keresztes Anna', 3500),
('Boda Bence', 3600),
('Kiss Brigitta', 4000);

INSERT INTO Vasarlok (Nev) VALUES
('Boda Dorka'),
('Kulcsar Barbara'),
('Farkas Julia');

INSERT INTO Vasarlasok (Datum, Vegosszeg, VasarloID, EladoID) VALUES 
('2024-03-01', 3800, 1, 1), 
('2024-03-05', 9500, 2, 3), 
('2024-03-10', 7000, 2, 1);

INSERT INTO VasaroltMualkotasok (MualkotasID, VasarlasID) VALUES
(4,1),
(3,2),
(2,3),
(5,3);

ALTER TABLE Mualkotasok
ADD Elkelt BIT NOT NULL DEFAULT 0; 

INSERT INTO Mualkotasok (AlkotasEve, Cim, Ar, StilusIranyzat, Elkelt) VALUES
(2018, 'Havazas', 18700, 'Impresszionizmus', 0),
(1503, 'Mona Lisa', 120000, 'Reneszansz', 0),
(1495, 'Az utolso vacsora', 180000, 'Reneszansz', 0),
(1490, 'Vitruvius-tanulmany', 95000, 'Reneszansz', 0),
(1504, 'David szobor', 160000, 'Reneszansz', 0),
(1499, 'Pieta', 140000, 'Reneszansz', 0),
(1889, 'Csillagos ej', 135000, 'Postimpresszionizmus', 0),
(1888, 'Napraforgok', 110000, 'Postimpresszionizmus', 0),
(1889, 'Az agy', 90000, 'Postimpresszionizmus', 0),
(1937, 'Guernica', 200000, 'Kubizmus', 0),
(1907, 'Avignoni kisasszonyok', 180000, 'Kubizmus', 0),
(1901, 'A kek korszak festmenyei', 120000, 'Kubizmus', 0),
(1642, 'Ejjelijorjarat', 150000, 'Barokk', 0),
(1665, 'Onarckep', 95000, 'Barokk', 0),
(1636, 'Danae', 105000, 'Barokk', 0),
(1899, 'Vizililiomok', 125000, 'Impresszionizmus', 0),
(1872, 'Impresszio, Napkelte', 140000, 'Impresszionizmus', 0),
(1892, 'Roueni katedralis sorozat', 160000, 'Impresszionizmus', 0),
(1931, 'Az emlekezet allandossaga', 180000, 'Szurrealizmus', 0),
(1940, 'Ebredo lany', 110000, 'Szurrealizmus', 0),
(1936, 'Metamorfoszisok', 135000, 'Szurrealizmus', 0),
(2015, 'Viragok a kertben', 12000, 'Impresszionizmus', 0),
(2022, 'Naplemente', 3000, 'Expresszionizmus', 0),
(2014, 'Holdfeny', 9500, 'Realizmus', 0),
(2019, 'Vizililiom a toban', 3800, 'Impresszionizmus', 0),
(2017, 'Ballerina', 4000, 'Szurrealizmus', 0);

INSERT INTO Muveszek (Nev, Stilus) VALUES
('Emily Carter', 'Impresszionizmus'),
('Leonardo da Vinci', 'Reneszansz'),
('Michelangelo', 'Reneszansz'),
('Vincent van Gogh', 'Posztimpresszionizmus'),
('Pablo Picasso', 'Kubizmus'),
('Salvador Dali', 'Szurrealizmus'),
('Rembrandt', 'Barokk'),
('Claude Monet', 'Impresszionizmus'),
('Emily Nelson', 'Szurrealizmus'),
('Sean Townsend', 'Realizmus'),
('Stephanie Smothers', 'Expresszionizmus');

INSERT INTO Eladok (Nev, Fizetes) VALUES
('Henry Winter', 5500),
('Meredith Dardenne', 3600),
('James Vane', 3400);


INSERT INTO AlkotasMuvesz (MuveszID, MualkotasID) VALUES
(1,29),
(2,3),
(2,30),
(3,2),
(3,30),
(4,3),
(4,28),
(4,31),
(5,1),
(5,4),
(5,28),
(5,29),
(6,6),
(6,29),
(7,7),
(7,8),
(7,9),
(8,10),
(8,11),
(9,12),
(9,13),
(9,14),
(10,15),
(10,16),
(10,17),
(11,24),
(11,25),
(11,26),
(12,18),
(12,19),
(12,20),
(13,21),
(13,22),
(13,23),
(14,27),
(14,28),
(14,31),
(15,27),
(16,27);




CREATE TABLE Kosarak (
	KosarID INT IDENTITY (1,1),
	VevoKod INT,

	CONSTRAINT PK_KosarID PRIMARY KEY(KosarID),
	CONSTRAINT FK_VevoKod FOREIGN KEY(VevoKod)
		REFERENCES Vasarlok(VasarloID)

);


CREATE TABLE KosarTartalma (
	KosarID INT,
	TermekKod INT,

	CONSTRAINT PK_KosarTartalma PRIMARY KEY(KosarID, TermekKod),
	CONSTRAINT FK_KosarID_KosarTartalma FOREIGN KEY (KosarID)
		REFERENCES Kosarak(KosarID),
	CONSTRAINT FK_TermekKod_KosarTartalma FOREIGN KEY (TermekKod)
		REFERENCES Mualkotasok(MualkotasID)
		

);


ALTER TABLE Vasarlasok
ADD TVAsVegosszeg FLOAT NULL;

ALTER TABLE VasaroltMualkotasok
ADD MualkotasAra INT NULL,
    TVAsMualkotasAra FLOAT NULL;

	
UPDATE vm
SET vm.MualkotasAra = m.Ar,
    vm.TVAsMualkotasAra = m.Ar * 1.055
FROM VasaroltMualkotasok vm
JOIN Mualkotasok m ON vm.MualkotasID = m.MualkotasID;

UPDATE v
SET v.TVAsVegosszeg = (
    SELECT SUM(vm.TVAsMualkotasAra)
    FROM VasaroltMualkotasok vm
    WHERE vm.VasarlasID = v.VasarlasID
)
FROM Vasarlasok v;

INSERT INTO Kosarak(VevoKod) VALUES
(4),
(5),
(6);

INSERT INTO KosarTartalma(KosarID, TermekKod) VALUES
(1,3),
(1,4),
(1,13),
(2,15),
(2,17),
(3,18),
(3,19),
(3,23),
(3,25);






