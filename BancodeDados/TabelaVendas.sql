CREATE TABLE [VENDAS] (
	[CODIGO] [int] IDENTITY (1, 1) NOT NULL ,
	[DATA] [datetime],
	[QUANTIDADE] [int],
	[FATURADO] bit, 
        [CODIGOCLIENTE] [int],
        [CODIGOPRODUTO] [int],
	CONSTRAINT [PK_VENDAS] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY],
        CONSTRAINT [FK_Codigo_Cliente] FOREIGN KEY 
	(
		[CODIGOCLIENTE]
	) REFERENCES [Clientes] (
		[Codigo]
	),
	CONSTRAINT [FK_Codigo_Produto] FOREIGN KEY 
	(
		[CODIGOPRODUTO]
	) REFERENCES [Produtos] (
		[Codigo]
	)

) ON [PRIMARY]
GO

