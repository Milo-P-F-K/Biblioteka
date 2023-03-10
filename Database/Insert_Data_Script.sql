USE [db_a8b501_biblioteka]
GO
SET IDENTITY_INSERT [dbo].[Autorzy] ON 

INSERT [dbo].[Autorzy] ([id_autor], [imie], [nazwisko]) VALUES (1, N'Bernadette', N'Paris')
INSERT [dbo].[Autorzy] ([id_autor], [imie], [nazwisko]) VALUES (2, N'Clare', N'Mackintosh')
INSERT [dbo].[Autorzy] ([id_autor], [imie], [nazwisko]) VALUES (3, N'Sophie', N'Hannah')
INSERT [dbo].[Autorzy] ([id_autor], [imie], [nazwisko]) VALUES (4, N'Holly', N'Brown')
INSERT [dbo].[Autorzy] ([id_autor], [imie], [nazwisko]) VALUES (5, N'Andrzej', N'Sapkowski')
INSERT [dbo].[Autorzy] ([id_autor], [imie], [nazwisko]) VALUES (6, N'Remigiusz', N'Mróz')
INSERT [dbo].[Autorzy] ([id_autor], [imie], [nazwisko]) VALUES (7, N'James', N'El')
INSERT [dbo].[Autorzy] ([id_autor], [imie], [nazwisko]) VALUES (8, N'Ed', N'Warren')
INSERT [dbo].[Autorzy] ([id_autor], [imie], [nazwisko]) VALUES (9, N'Lorraine', N'Warren')
INSERT [dbo].[Autorzy] ([id_autor], [imie], [nazwisko]) VALUES (10, N'Nicholas', N'Sparks')
INSERT [dbo].[Autorzy] ([id_autor], [imie], [nazwisko]) VALUES (11, N'Thorpe', N' Gav')
INSERT [dbo].[Autorzy] ([id_autor], [imie], [nazwisko]) VALUES (12, N'Jo', N'Nesbo')
INSERT [dbo].[Autorzy] ([id_autor], [imie], [nazwisko]) VALUES (14, N'J.K', N'Rowling')
INSERT [dbo].[Autorzy] ([id_autor], [imie], [nazwisko]) VALUES (15, N'William', N'Shakespeare')
INSERT [dbo].[Autorzy] ([id_autor], [imie], [nazwisko]) VALUES (16, N'Lee', N'Child')
SET IDENTITY_INSERT [dbo].[Autorzy] OFF
GO
SET IDENTITY_INSERT [dbo].[Kategorie] ON 

INSERT [dbo].[Kategorie] ([id_kategoria], [nazwa]) VALUES (1, N'Fantasy')
INSERT [dbo].[Kategorie] ([id_kategoria], [nazwa]) VALUES (2, N'Kryminał')
INSERT [dbo].[Kategorie] ([id_kategoria], [nazwa]) VALUES (3, N'Romans')
INSERT [dbo].[Kategorie] ([id_kategoria], [nazwa]) VALUES (4, N'Horror')
INSERT [dbo].[Kategorie] ([id_kategoria], [nazwa]) VALUES (5, N'Thriller')
INSERT [dbo].[Kategorie] ([id_kategoria], [nazwa]) VALUES (6, N'Literatura Obyczajowa')
INSERT [dbo].[Kategorie] ([id_kategoria], [nazwa]) VALUES (7, N'Sci-Fi')
INSERT [dbo].[Kategorie] ([id_kategoria], [nazwa]) VALUES (8, N'Przygodowe')
INSERT [dbo].[Kategorie] ([id_kategoria], [nazwa]) VALUES (9, N'Psychologiczne')
SET IDENTITY_INSERT [dbo].[Kategorie] OFF
GO
SET IDENTITY_INSERT [dbo].[Wydawnictwa] ON 

INSERT [dbo].[Wydawnictwa] ([id_wydawnictwo], [nazwa]) VALUES (2, N'Supernowa')
INSERT [dbo].[Wydawnictwa] ([id_wydawnictwo], [nazwa]) VALUES (3, N'Wydawnictwo Sonia Draga')
INSERT [dbo].[Wydawnictwa] ([id_wydawnictwo], [nazwa]) VALUES (4, N'Replika')
INSERT [dbo].[Wydawnictwa] ([id_wydawnictwo], [nazwa]) VALUES (5, N'Wydawnictwo Albatros')
INSERT [dbo].[Wydawnictwa] ([id_wydawnictwo], [nazwa]) VALUES (6, N'Fox Games')
INSERT [dbo].[Wydawnictwa] ([id_wydawnictwo], [nazwa]) VALUES (7, N'Copernicus Corporation')
INSERT [dbo].[Wydawnictwa] ([id_wydawnictwo], [nazwa]) VALUES (8, N'Czwarta Strona')
INSERT [dbo].[Wydawnictwa] ([id_wydawnictwo], [nazwa]) VALUES (9, N'WSiP')
INSERT [dbo].[Wydawnictwa] ([id_wydawnictwo], [nazwa]) VALUES (10, N'Testowe')
SET IDENTITY_INSERT [dbo].[Wydawnictwa] OFF
GO
SET IDENTITY_INSERT [dbo].[Ksiazki] ON 

INSERT [dbo].[Ksiazki] ([id_ksiazka], [isbn], [id_kategoria], [tytul], [opis], [id_wydawnictwo], [rok_wydania], [ilosc]) VALUES (6, N'9788375780635', 1, N'Wiedźmin - Ostatnie Życzenie', N'Zbiór opowiadań fantasy z 1993 roku, napisanych przez Andrzeja Sapkowskiego i stanowiących wstęp do cyklu o wiedźminie Geralcie.', 2, 1993, 2)
INSERT [dbo].[Ksiazki] ([id_ksiazka], [isbn], [id_kategoria], [tytul], [opis], [id_wydawnictwo], [rok_wydania], [ilosc]) VALUES (8, N'9788382301106', 3, N'50 twarzy Greya', N'Ona marzy o romantycznej miłości. On jest gotów dać jej wszystko oprócz tego. Poznaj "Pięćdziesiąt twarzy Greya" i wejdź do świata porywającego romansu, erotycznych fantazji i tajemnicy, która może zniszczyć wszystko.', 3, 2011, 1)
INSERT [dbo].[Ksiazki] ([id_ksiazka], [isbn], [id_kategoria], [tytul], [opis], [id_wydawnictwo], [rok_wydania], [ilosc]) VALUES (10, N'9788382320138', 7, N'Indomitus', N'Ultramarines stają przed dylematem: podjąć nierówną, desperacką walkę z xenos albo oddać armii Milczącego Króla cały sektor i uciec, żeby poinformować o ekspansji nekronów jedyną istotę, która mogłaby ją zatrzymać – lorda Prymarchę Roboute’a Guillimana.', 7, 2021, 2)
INSERT [dbo].[Ksiazki] ([id_ksiazka], [isbn], [id_kategoria], [tytul], [opis], [id_wydawnictwo], [rok_wydania], [ilosc]) VALUES (11, N'9788366790728', 4, N'Obecność. Historia Opętania', N'Tym razem najbardziej znani na świecie badacze zjawisk paranormalnych opisują sytuację chłopca, Billa Ramseya, którego życie pewnego dnia zupełnie się zmieniło. Niestety, na gorsze.', 4, 2021, 6)
INSERT [dbo].[Ksiazki] ([id_ksiazka], [isbn], [id_kategoria], [tytul], [opis], [id_wydawnictwo], [rok_wydania], [ilosc]) VALUES (12, N'9788382150766', 5, N'Dublerka', N'"Dublerka" to niezwykły thriller psychologiczny stworzony przez cztery bestsellerowe autorki! Sprawdź, jak daleko można się posunąć, by ochronić własne dziecko.', 5, 2020, 13)
SET IDENTITY_INSERT [dbo].[Ksiazki] OFF
GO
SET IDENTITY_INSERT [dbo].[Autorzy_Ksiazki] ON 

INSERT [dbo].[Autorzy_Ksiazki] ([id_autorzy_ksiazki], [id_ksiazka], [id_autor]) VALUES (1, 12, 1)
INSERT [dbo].[Autorzy_Ksiazki] ([id_autorzy_ksiazki], [id_ksiazka], [id_autor]) VALUES (2, 12, 2)
INSERT [dbo].[Autorzy_Ksiazki] ([id_autorzy_ksiazki], [id_ksiazka], [id_autor]) VALUES (3, 12, 3)
INSERT [dbo].[Autorzy_Ksiazki] ([id_autorzy_ksiazki], [id_ksiazka], [id_autor]) VALUES (4, 12, 4)
INSERT [dbo].[Autorzy_Ksiazki] ([id_autorzy_ksiazki], [id_ksiazka], [id_autor]) VALUES (5, 10, 11)
INSERT [dbo].[Autorzy_Ksiazki] ([id_autorzy_ksiazki], [id_ksiazka], [id_autor]) VALUES (7, 8, 7)
INSERT [dbo].[Autorzy_Ksiazki] ([id_autorzy_ksiazki], [id_ksiazka], [id_autor]) VALUES (9, 11, 8)
INSERT [dbo].[Autorzy_Ksiazki] ([id_autorzy_ksiazki], [id_ksiazka], [id_autor]) VALUES (10, 11, 9)
INSERT [dbo].[Autorzy_Ksiazki] ([id_autorzy_ksiazki], [id_ksiazka], [id_autor]) VALUES (30, 6, 5)
SET IDENTITY_INSERT [dbo].[Autorzy_Ksiazki] OFF
GO
SET IDENTITY_INSERT [dbo].[Czytelnicy] ON 

INSERT [dbo].[Czytelnicy] ([id_czytelnik], [email], [telefon], [data_urodzenia], [ile_wypozyczonych], [imie], [nazwisko]) VALUES (1, N'eencki@wp.pl', N'369852147', CAST(N'1991-01-01' AS Date), 1, N'Edward', N'Encki')
INSERT [dbo].[Czytelnicy] ([id_czytelnik], [email], [telefon], [data_urodzenia], [ile_wypozyczonych], [imie], [nazwisko]) VALUES (2, N'ffajny@gmail.com', N'123456987', CAST(N'1992-02-02' AS Date), 0, N'Feliks', N'Fajny')
INSERT [dbo].[Czytelnicy] ([id_czytelnik], [email], [telefon], [data_urodzenia], [ile_wypozyczonych], [imie], [nazwisko]) VALUES (3, N'ggrze@outlook.com', N'753951456', CAST(N'1993-03-03' AS Date), 0, N'Grazyna', N'Grzeczna')
INSERT [dbo].[Czytelnicy] ([id_czytelnik], [email], [telefon], [data_urodzenia], [ile_wypozyczonych], [imie], [nazwisko]) VALUES (4, N'hhonor@yahoo.com', N'813976451', CAST(N'1994-04-04' AS Date), 0, N'Horacy', N'Honorowy')
SET IDENTITY_INSERT [dbo].[Czytelnicy] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([id_rola], [nazwa]) VALUES (1, N'Bibliotekarz')
INSERT [dbo].[Role] ([id_rola], [nazwa]) VALUES (2, N'Starszy Bibliotekarz')
INSERT [dbo].[Role] ([id_rola], [nazwa]) VALUES (3, N'Praktykant')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[Pracownicy] ON 

INSERT [dbo].[Pracownicy] ([id_pracownik], [id_rola], [imie], [nazwisko]) VALUES (1, 1, N'Adam', N'Arbuzowski')
INSERT [dbo].[Pracownicy] ([id_pracownik], [id_rola], [imie], [nazwisko]) VALUES (2, 2, N'Beata', N'Brawura')
INSERT [dbo].[Pracownicy] ([id_pracownik], [id_rola], [imie], [nazwisko]) VALUES (3, 1, N'Jan', N'Nowak')
INSERT [dbo].[Pracownicy] ([id_pracownik], [id_rola], [imie], [nazwisko]) VALUES (4, 2, N'Celina', N'Celnik')
INSERT [dbo].[Pracownicy] ([id_pracownik], [id_rola], [imie], [nazwisko]) VALUES (5, 1, N'Dariusz', N'Dobry')
INSERT [dbo].[Pracownicy] ([id_pracownik], [id_rola], [imie], [nazwisko]) VALUES (6, 3, N'Edward', N'Eureka')
SET IDENTITY_INSERT [dbo].[Pracownicy] OFF
GO
SET IDENTITY_INSERT [dbo].[Wypozyczenia] ON 

INSERT [dbo].[Wypozyczenia] ([id_wypozyczenie], [id_czytelnik], [id_ksiazka], [data_wypozyczenia], [id_pracownik], [termin_oddania], [data_zwrotu], [status_zwrotu]) VALUES (14, 1, 6, CAST(N'2021-06-24' AS Date), 1, CAST(N'2021-07-31' AS Date), NULL, NULL)
SET IDENTITY_INSERT [dbo].[Wypozyczenia] OFF
GO
