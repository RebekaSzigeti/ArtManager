USE Galeria;
GO

INSERT INTO FelhasznaloCsoportok (CsopNev) VALUES
('Vasarlo'),
('Elado'),
('Admin');

INSERT INTO Felhasznalok (FelhNev, Jelszo, Salt, FelhCsopID) VALUES
('kulcsar.barbara', 'pw', 'salt', 1),
('farkas.julia', 'pw', 'salt', 1),
('basil.hallward', 'pw', 'salt', 1),
('sybil.vane', 'pw', 'salt', 1),
('adrian.singleton', 'pw', 'salt', 1),
('john.w', 'pw', 'salt', 1),
('tom.hartigan', 'pw', 'salt', 1);

INSERT INTO FelhasznaloVasarlo (FelhID, VasarloID) VALUES
(1, 2),
(2, 3),
(3, 4),
(4, 5),
(5, 6),
(6, 7),
(7, 8);

INSERT INTO Felhasznalok (FelhNev, Jelszo, Salt, FelhCsopID) VALUES
('keresztes.anna', 'pw', 'salt', 2),
('boda.bence', 'pw', 'salt', 2),
('kiss.brigitta', 'pw', 'salt', 2),
('meredith.dardenne', 'pw', 'salt', 2),
('james.vane', 'pw', 'salt', 2);


INSERT INTO Felhasznalok (FelhNev, Jelszo, Salt, FelhCsopID) VALUES
('henry.winter', 'pw', 'salt', 3),
('dorian.gray', 'pw', 'salt', 3);

INSERT INTO FelhasznaloElado (FelhID, EladoID) VALUES
(8, 1),   -- keresztes.anna
(9, 2),   -- boda.bence
(10, 3),  -- kiss.brigitta
(13, 4),  -- henry.winter (ADMIN)
(11, 5),  -- meredith.dardenne
(12, 6),  -- james.vane
(14, 7);  -- dorian.gray (ADMIN)

 

