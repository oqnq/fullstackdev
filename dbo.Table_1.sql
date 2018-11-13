CREATE TABLE [dbo].[product_categories]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] NCHAR(10) NOT NULL, 
    CONSTRAINT [FK_product_categories_ToTable] FOREIGN KEY ([Column]) REFERENCES [ToTable]([ToTableColumn])
)
