USE Loja
GO

CREATE PROCEDURE [dbo].[exclui_cliente]
   @codigo int

AS

DELETE FROM Clientes WHERE codigo = @codigo

