USE Loja
GO

CREATE PROCEDURE [dbo].[insere_cliente]
   @codigo int output,
   @nome varchar(100), 
   @email varchar(100),
   @telefone varchar(80)

AS

INSERT INTO CLIENTES (nome, email, telefone) 
VALUES (@nome,@email,@telefone)

SET @codigo = (SELECT @@IDENTITY)

