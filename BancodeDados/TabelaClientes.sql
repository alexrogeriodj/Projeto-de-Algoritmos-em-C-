CREATE TABLE [CLIENTES] (
	[CODIGO] [int] IDENTITY (1, 1) NOT NULL ,
	[NOME] [varchar] (100) NULL ,
	[EMAIL] [varchar] (100) NULL ,
	[TELEFONE] [varchar] (80) NULL ,
	CONSTRAINT [PK_CLIENTES] PRIMARY KEY  CLUSTERED 
	(
		[CODIGO]
	)  ON [PRIMARY] 
) ON [PRIMARY]
GO

insert into clientes(nome,email,telefone) 
values ('Carlos Camacho','email@provedor.com.br','(11) 9999-5555')

select * from clientes

