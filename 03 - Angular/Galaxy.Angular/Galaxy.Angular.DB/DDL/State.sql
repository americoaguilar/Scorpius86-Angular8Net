CREATE TABLE [dbo].[State]
(
	StateId INT NOT NULL PRIMARY KEY IDENTITY,
	UUID VARCHAR(250) DEFAULT NEWID(),	
	Name VARCHAR(250),
	Abbreviation VARCHAR(250)
)
