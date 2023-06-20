using HW_Hidreletrica.Entidades.Usuario;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Conta.Conta_Comercial;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Conta.Conta_Residencial;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Pessoa_Fisica;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Residencia;
using HW_Hidreletrica.Entidades.Usuario.EMP;
using HW_Hidreletrica.Services.Repository.Cliente;
using HW_Hidreletrica.Services.Repository.Cliente.Conta;
using HW_Hidreletrica.Services.Repository.EMP;
using HW_Hidreletrica.Services.Residencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Entidades.Connect_SQL
{
    public static class Script_Server
    {
        public static void CreateDatabase()
        {

            using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
            {
                cn.Open();

				using (SqlCommand cmd = cn.CreateCommand())
				{
					cmd.CommandText = "create database Testando";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "use Testando";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "create table Administrador(\r\n\tCodAdministrador int PRIMARY KEY IDENTITY(1,1),\r\n\tNome char(80) not null,\r\n\tEmail char(256) not null,\r\n\tsenha char(64) not null\r\n);";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "create table TipoPessoa(\r\n\tCodigo int PRIMARY KEY IDENTITY(1,1),\r\n\tDescricao char(30) not null\r\n);";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "create table Pessoa(\r\n\tCodigo int PRIMARY KEY IDENTITY(1,1),\r\n\tNome varchar(80) not null,\r\n\tEmail varchar(256) not null,\r\n\tsenha varchar(64) not null,\r\n\tDtNascimento datetime not null,\r\n\tCPF varchar(20),\r\n\tCNPJ varchar(30),\r\n\tCodTipo int not null,\r\n\tTelefone varchar(15),\r\n\tConstraint FK_CodTipo Foreign Key(CodTipo) references TipoPessoa\r\n);";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "create table Endereco(\r\n\tCodigo int PRIMARY KEY IDENTITY(1,1),\r\n\tNumero int  not null,\r\n\tRua varchar(100) not null,\r\n\tBairro varchar(40) not null,\r\n\tCidade varchar(30) not null,\r\n\tEstado varchar(30)  not null,\r\n\tCep varchar(30) not null\r\n);";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "create table Residencia(\r\n\tCodigo int PRIMARY KEY IDENTITY(1,1),\r\n\tNumInstalacao int not null,\r\n\tDescricao char(30) not null,\r\n\tCodPessoa int not null,\r\n\tCodEndereco int not null,\r\n\tConstraint FK_CodPessoa Foreign Key(CodPessoa) references Pessoa,\r\n\tConstraint FK_CodEndereco Foreign Key(CodEndereco) references Endereco\r\n);";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "create table TipoConta(\r\n\tCodigo int PRIMARY KEY IDENTITY(1,1),\r\n\tDescricao varchar(60) not null\r\n);";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "create table Conta(\r\n\tCodigo int IDENTITY(1,1),\r\n\tMesReferencia double PRECISION,\r\n\tMesAnterior double PRECISION,\r\n\tConsumo double PRECISION, \r\n\tValorTotal double PRECISION, \r\n\tValorTotalSemImposto double PRECISION,\r\n\tCodPessoa int,\r\n\tCodResidencia int,\r\n\tCodTipo int not null,\r\n\tdtPagamento date,\r\n\tdtVencimento date,\r\n\tPrimary Key(Codigo, CodResidencia,CodPessoa),\r\n\tConstraint FK_TipoConta Foreign Key(CodTipo) references TipoConta\r\n);";
					cmd.ExecuteNonQuery();

				}
				
				Connect_Server.database = "Testando";
           
                InsertItemsDatabase();
            }
           
         }
        public static void InsertItemsDatabase()
        {
			Connect_Server.database = "Testando";
			using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
			{
				cn.Open();

				using (SqlCommand cmd = cn.CreateCommand())
				{
					ClienteRepository clienteRepository = new ClienteRepository();
					ResidenciaRepository residenciaRepository = new ResidenciaRepository();
					ContaRepository contaRepository = new ContaRepository();


					Conta_Comercial contaComercial = new Conta_Comercial();
					Conta_Residencial contaResidencial = new Conta_Residencial();

					Residencias residencia = new Residencias();
					Pessoa_Fisica pessoa = new Pessoa_Fisica();

					Administradores adm = new Administradores(_nome: "Adm", _email: "adm@gmail.com",_codigo: "1", _senha: "123");
					AdministradorRepository administradorRepository = new AdministradorRepository();
					administradorRepository.Add(adm);


					cmd.CommandText = "insert into TipoPessoa(Descricao) values('Pessoa Fisica')";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "insert into TipoPessoa(Descricao) values('Pessoa Juridica')";
					cmd.ExecuteNonQuery();

					cmd.CommandText = "insert into TipoConta(Descricao) values ('Comercial')";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "insert into TipoConta(Descricao) values ('Residencial')";
					cmd.ExecuteNonQuery();



					clienteRepository.Add(new Pessoa_Fisica(_cpf:  "959.185.590-78", _telefone: "31 98527-5829", _dtNascimento: new DateTime(2001,10,30), _nome: "Lucas Castro Soares", _email: "lucas.castro@gmail.com",
						_senha: Cryptography_Password.CryptographyMethod("1"), _codigo: "1"));

					residenciaRepository.Add(new Residencias(codigo: 1, rua: "Rua Aderbal Lopes", bairro: "Funcionários", cidade: "contagem", numero: 20, cep: "32040-360", estado:"MG"
						, descricao: "casa", codPessoa: 1));

					pessoa.codigo = "1";
					residencia.codigo = 1;

					contaResidencial = new Conta_Residencial(dtPagamento: new DateTime(2023, 06, 27), dtVencimento: new DateTime(2023, 06, 30), mesAnterior: 600, mesReferencia: 900
																		  , residencia: residencia, cliente: pessoa);

					contaRepository.Add(contaResidencial);

					contaResidencial = new Conta_Residencial(dtPagamento: new DateTime(2023, 05, 20), dtVencimento: new DateTime(2023, 05, 30), mesAnterior: 700, mesReferencia: 600
																		  , residencia: residencia, cliente: pessoa);

					contaRepository.Add(contaResidencial);

					//Simbolizar uma Conta em Atraso
					contaResidencial = new Conta_Residencial(dtPagamento: new DateTime(1754,01,01), dtVencimento: new DateTime(2023, 04, 30), mesAnterior: 950, mesReferencia: 700
																		  , residencia: residencia, cliente: pessoa);

					contaRepository.Add(contaResidencial);


					/////////////////


					// Esta cliente possui duas residencias e duas contas em cada
					// Ela também possui uma conta Comercial para a sua segunda residencia

					clienteRepository.Add(new Pessoa_Fisica(_cpf: "689.835.160-54", _telefone: "31 97587-5124", _dtNascimento: new DateTime(1970, 04, 04), _nome: "Abigail Lucia Matins", _email: "abigail.soares@gmail.com",
						_senha: Cryptography_Password.CryptographyMethod("1"), _codigo: "2"));

					residenciaRepository.Add(new Residencias(codigo: 2, rua: "Rua Retiro São José", bairro: "Retiro", cidade: "Contagem", numero: 20, cep: "32050-580", estado: "MG"
						, descricao: "casa", codPessoa: 2));

					pessoa.codigo = "2";
					residencia.codigo = 2;

					contaResidencial = new Conta_Residencial(dtPagamento: new DateTime(2023, 06, 04), dtVencimento: new DateTime(2023, 06, 30), mesAnterior: 300, mesReferencia: 800
																	   , residencia: residencia, cliente: pessoa);
					contaRepository.Add(contaResidencial);

					contaResidencial = new Conta_Residencial(dtPagamento: new DateTime(2023, 05, 12), dtVencimento: new DateTime(2023, 05, 30), mesAnterior: 600, mesReferencia: 300
																	   , residencia: residencia, cliente: pessoa);
					contaRepository.Add(contaResidencial);


					residenciaRepository.Add(new Residencias(codigo: 3, rua: "Rua da Luz", bairro: "Vila Paris", cidade: "Contagem", numero: 120, cep: "32372-130", estado: "MG"
						, descricao: "casa", codPessoa: 2));

					pessoa.codigo = "2";
					residencia.codigo = 3;


					contaComercial = new Conta_Comercial(dtPagamento: new DateTime(2023, 06, 04), dtVencimento: new DateTime(2023, 06, 30), mesAnterior: 1800, mesReferencia: 800
																	   , residencia: residencia, cliente: pessoa);

					contaRepository.Add(contaComercial);


					contaComercial = new Conta_Comercial(dtPagamento: new DateTime(2023, 05, 04), dtVencimento: new DateTime(2023, 05, 30), mesAnterior: 1100, mesReferencia: 1800
																	   , residencia: residencia, cliente: pessoa);

					contaRepository.Add(contaComercial);



					///////////////////////////////////////



					clienteRepository.Add(new Pessoa_Fisica(_cpf: "910.588.020-38", _telefone: "31 97527-5120", _dtNascimento: new DateTime(1999, 01, 01), _nome: "Fernando Fenandes Ferraz", _email: "fernando@gmail.com",
						_senha: Cryptography_Password.CryptographyMethod("1"), _codigo: "3"));

					residenciaRepository.Add(new Residencias(codigo: 4, rua: "Beco Vila Nova", bairro: "Vila Renascer", cidade: "Contagem", numero: 200, cep: "32052-044", estado: "MG"
						, descricao: "casa", codPessoa: 3));

					pessoa.codigo = "3";
					residencia.codigo = 4;

					contaResidencial = new Conta_Residencial(dtPagamento: new DateTime(1754, 01, 01), dtVencimento: new DateTime(2023, 06, 30), mesAnterior: 600, mesReferencia: 900
																		  , residencia: residencia, cliente: pessoa);

					contaRepository.Add(contaResidencial);

					contaResidencial = new Conta_Residencial(dtPagamento: new DateTime(1754, 01, 01), dtVencimento: new DateTime(2023, 05, 30), mesAnterior: 700, mesReferencia: 600
																		  , residencia: residencia, cliente: pessoa);

					contaRepository.Add(contaResidencial);

					
					contaResidencial = new Conta_Residencial(dtPagamento: new DateTime(1754, 01, 01), dtVencimento: new DateTime(2023, 04, 30), mesAnterior: 950, mesReferencia: 700
																		  , residencia: residencia, cliente: pessoa);

					contaRepository.Add(contaResidencial);



				}
			}
		}

    }
}
