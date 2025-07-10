CREATE TABLE korisnik (
    idK INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    ime TEXT NOT NULL,
    sifra TEXT NOT NULL
);

CREATE TABLE sto (
    idS INTEGER PRIMARY KEY NOT NULL,
    ime TEXT,
    x INTEGER NOT NULL,
    y INTEGER NOT NULL,
    mesto INTEGER NOT NULL
);

CREATE TABLE vrsta (
    idV INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    ime TEXT NOT NULL
);

CREATE TABLE proizvodi (
    idP INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    ime TEXT NOT NULL,
    idV INTEGER,
    cena REAL,
    kolicina INTEGER,
    FOREIGN KEY (idV) REFERENCES vrsta(idV)
);

CREATE TABLE kasa (
    idK INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    stanje INTEGER NOT NULL
);

CREATE TABLE pazar (
    idPa INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL,
    proizvod TEXT,
    kolicina INTEGER NOT NULL,
    datum TEXT
);

-- Inserti
INSERT INTO kasa (stanje) VALUES (0);

INSERT INTO korisnik (ime, sifra) VALUES ('a', 'a');
INSERT INTO korisnik (ime, sifra) VALUES ('admin', 'admin');

INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 1', 1204, 209, 0);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 2', 942, 235, 0);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 3', 680, 197, 0);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 4', 1216, 592, 0);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 5', 946, 493, 0);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 6', 681, 585, 0);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 7', 470, 692, 0);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 8', 279, 690, 0);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 9', 99, 692, 0);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 10', 474, 101, 0);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 11', 287, 100, 0);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 12', 100, 100, 0);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 13', 1286, 527, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 14', 1289, 342, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 15', 1144, 498, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 16', 1186, 296, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 17', 1087, 254, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 18', 979, 241, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 19', 875, 233, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 20', 773, 217, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 21', 688, 341, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 22', 989, 468, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 23', 670, 192, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 24', 584, 134, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 25', 477, 118, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 26', 379, 108, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 27', 277, 100, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 28', 43, 143, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 29', 43, 259, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 30', 70, 692, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 31', 301, 692, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 32', 1, 559, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 33', 148, 558, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 34', 326, 557, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 35', 325, 416, 2);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 36', 1184, 101, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 37', 949, 100, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 38', 731, 100, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 39', 526, 100, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 40', 308, 100, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 41', 1185, 229, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 42', 950, 224, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 43', 731, 221, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 44', 523, 221, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 45', 307, 222, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 46', 1189, 380, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 47', 952, 380, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 48', 736, 377, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 49', 525, 373, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 50', 308, 373, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 51', 1191, 530, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 52', 953, 529, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 53', 735, 528, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 54', 522, 529, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 55', 306, 523, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 56', 1192, 689, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 57', 959, 692, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 58', 735, 692, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 59', 520, 692, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 60', 305, 692, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 61', 101, 692, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 62', 104, 524, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 63', 105, 375, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 64', 109, 222, 1);
INSERT INTO sto (ime, x, y, mesto) VALUES ('Sto 65', 116, 101, 1);

insert into vrsta (ime) values ('Kafe');
insert into vrsta (ime) values ('Vode');
insert into vrsta (ime) values ('Sokovi');
insert into vrsta (ime) values ('Vina');
insert into vrsta (ime) values ('Piva');
insert into vrsta (ime) values ('Žestoka pića');
insert into vrsta (ime) values ('Kokteli');
insert into vrsta (ime) values ('Energetska pića');
insert into vrsta (ime) values ('Poslastice');
insert into vrsta (ime) values ('Hrana');

insert into proizvodi (ime, idV, cena, kolicina) values ('Domaća kafa', 1, 180, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Espresso', 1, 180, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Nes', 1, 180, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Ice kafa', 1, 250, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Rosa 0.33', 2, 190, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Knjaz 0.25', 2, 220, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Rosa 0.7', 2, 500, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Knjaz 0.7', 2, 500, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Limunska trava', 2, 260, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Cedevita', 3, 250, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Sokici', 3, 290, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Sola', 3, 250, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Orangina', 3, 250, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Coca-Cola', 3, 250, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Fanta', 3, 250, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Sprite', 3, 250, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Schweppes', 3, 250, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Cockta', 3, 250, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Bravo sok', 3, 230, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Limunada', 3, 260, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Ceđena narandža', 3, 280, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Ceđena jabuka', 3, 250, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('MIX', 3, 370, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Crno vino', 4, 420, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Belo vino', 4, 420, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Rose vino', 4, 420, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Sangria', 4, 350, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Zaječarsko', 5, 330, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Zaječarsko crno', 5, 330, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Kapuziner', 5, 580, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Heiniken 0.2', 5, 390, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Heiniken 0.4', 5, 350, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Birra Moretti', 5, 330, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Laško', 5, 400, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Blanc', 5, 380, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Somersby', 5, 390, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Smirnoff Ice', 5, 380, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Pivo ukus', 5, 270, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Jack Daniels', 6, 380, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Džin', 6, 380, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Tekila', 6, 380, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Jagermeister', 6, 330, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Viljamovka', 6, 460, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Kajsija rakija', 6, 460, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Dunja rakija', 6, 460, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Gorki list', 6, 330, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Aperol', 6, 350, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Koktel', 7, 450, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Guarana', 8, 280, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Ultra', 8, 280, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Red Bull', 8, 280, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Sladoled', 9, 460, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Krofne', 9, 200, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Desert u časi', 9, 350, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Plazma šejk', 9, 390, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Trilece', 9, 380, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Ćevapi', 10, 1300, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Belo meso', 10, 1000, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Nagetsi', 10, 1000, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Kobasice', 10, 1000, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Ražnjici', 10, 1000, 100);
insert into proizvodi (ime, idV, cena, kolicina) values ('Šopska salata', 10, 360, 100);