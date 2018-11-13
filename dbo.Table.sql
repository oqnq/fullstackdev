CREATE TABLE [dbo].products
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [category] INT NOT NULL DEFAULT 0, 
    [name] NCHAR(10) NOT NULL, 
    [description] NCHAR(10) NULL, 
    [price] MONEY NOT NULL, 
    [owner_name] NCHAR(10) NOT NULL, 
    [email] NCHAR(10) NOT NULL, 
    [created_on] TIMESTAMP NOT NULL, 
    [updated_on] DATETIME NOT NULL 
)
