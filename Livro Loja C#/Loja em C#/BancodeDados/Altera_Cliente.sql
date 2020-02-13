USE Loja
GO

CREATE PROCEDURE [dbo].[altera_cliente]
   @codigo int,
   @nome varchar(100), 
   @email varchar(100),
   @telefone varchar(80)

AS

UPDATE Clientes SET nome = @nome, email = @email, telefone = @telefone where codigo = @codigo

