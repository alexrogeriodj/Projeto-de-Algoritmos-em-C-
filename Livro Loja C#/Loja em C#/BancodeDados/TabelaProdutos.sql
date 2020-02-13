CREATE TABLE [PRODUTOS] (
	[CODIGO] [int] IDENTITY (1, 1) NOT NULL ,
	[NOME] [varchar] (100) NULL,
	[PRECO] decimal(10,2) NULL,
	[ESTOQUE] [int] NULL,
	CONSTRAINT [PK_PRODUTOS] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
) ON [PRIMARY]
GO

insert into produtos (nome, preco, estoque) 
values ('Computador Pentium Dual Core','1500.00','15')
insert into produtos (nome, preco, estoque) 
values ('Impressora Deskjet HP','599.90','150')

select * from produtos

