USE master
GO
IF NOT EXISTS(
	SELECT name
	FROM sys.databases
	WHERE name = N'TuutorialLDB'
)

CREATE DATABASE [TuutorialLDB]
Go