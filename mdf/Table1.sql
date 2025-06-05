CREATE TABLE [dbo].[pracownicy]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Imie] NVARCHAR(50) NOT NULL, 
    [Nazwisko] NVARCHAR(50) NOT NULL, 
    [Stanowisko] INT NOT NULL, 
    [Dniurlopowe] INT NOT NULL
)
