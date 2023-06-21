USE HW_Hidreletrica

create table Administrador(
	CodAdministrador int PRIMARY KEY IDENTITY(1,1),
	Nome char(30) not null,
	Email char(30) not null,
	senha varchar(64) not null
);

create table TipoPessoa(
	Codigo int PRIMARY KEY IDENTITY(1,1),
	Descricao char(30) not null
);

create table Pessoa(
	Codigo int PRIMARY KEY IDENTITY(1,1),
	Nome varchar(80) not null,
	Email varchar(256) not null,
	senha varchar(64) not null,
	DtNascimento datetime not null,
	CPF varchar(20),
	CNPJ varchar(30),
	CodTipo int not null,
	Telefone varchar(15),
	Constraint FK_CodTipo Foreign Key(CodTipo) references TipoPessoa
);

create table Endereco(
	Codigo int PRIMARY KEY IDENTITY(1,1),
	Numero int  not null,
	Rua varchar(100) not null,
	Bairro varchar(40) not null,
	Cidade varchar(30) not null,
	Estado varchar(30)  not null,
	Cep varchar(30) not null
);

create table Residencia(
	Codigo int PRIMARY KEY IDENTITY(1,1),
	NumInstalacao int not null,
	Descricao char(30) not null,
	CodPessoa int not null,
	CodEndereco int not null,
	Constraint FK_CodPessoa Foreign Key(CodPessoa) references Pessoa,
	Constraint FK_CodEndereco Foreign Key(CodEndereco) references Endereco
);

create table TipoConta(
	Codigo int PRIMARY KEY IDENTITY(1,1),
	Descricao varchar(60) not null
);

create table Conta(
	Codigo int IDENTITY(1,1),
	MesReferencia double PRECISION,
	MesAnterior double PRECISION,
	Consumo double PRECISION, 
	ValorTotal double PRECISION, 
	CodPessoa int,
	CodResidencia int,
	CodTipo int not null,
	dtPagamento date,
	dtVencimento date,
	Primary Key(Codigo, CodResidencia,CodPessoa),
	Constraint FK_TipoConta Foreign Key(CodTipo) references TipoConta,
);