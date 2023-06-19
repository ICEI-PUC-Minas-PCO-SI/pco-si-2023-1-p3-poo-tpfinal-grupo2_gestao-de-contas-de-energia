using HW_Hidreletrica.Entidades.Usuario;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Conta.Conta_Comercial;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Pessoa_Fisica;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Residencia;
using HW_Hidreletrica.Services.Repository.Cliente;
using HW_Hidreletrica.Services.Repository.Cliente.Conta;
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
					cmd.CommandText = "create table Administrador(\r\n\tCodAdministrador int PRIMARY KEY IDENTITY(1,1),\r\n\tNome char(30) not null,\r\n\tEmail char(30) not null,\r\n\tsenha char(15) not null\r\n);";
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
					cmd.CommandText = "create table Conta(\r\n\tCodigo int IDENTITY(1,1),\r\n\tMesReferencia double PRECISION,\r\n\tMesAnterior double PRECISION,\r\n\tConsumo double PRECISION, \r\n\tValorTotal double PRECISION,\r\n\tValorTotalSemImposto double PRECISION,\r\n\tCodPessoa int,\r\n\tCodResidencia int,\r\n\tCodTipo int not null,\r\n\tdtPagamento date,\r\n\tdtVencimento date,\r\n\tPrimary Key(Codigo, CodResidencia,CodPessoa),\r\n\tConstraint FK_TipoConta Foreign Key(CodTipo) references TipoConta,\r\n);";
					cmd.ExecuteNonQuery();

				}
				
				Connect_Server.database = "Testando";
           
                InsertItemsDatabase();
            }
           
         }
        static void InsertItemsDatabase()
        {
			using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
			{
				cn.Open();

				using (SqlCommand cmd = cn.CreateCommand())
				{
					ClienteRepository clienteRepository = new ClienteRepository();
					ResidenciaRepository residenciaRepository = new ResidenciaRepository();
					ContaRepository contaRepository = new ContaRepository();

					Residencias residencia = new Residencias();
					Pessoa_Fisica pessoa = new Pessoa_Fisica();

					cmd.CommandText = "insert into TipoPessoa(Descricao) values('Pessoa Fisica')";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "insert into TipoPessoa(Descricao) values('Pessoa Juridica')";
					cmd.ExecuteNonQuery();

					cmd.CommandText = "insert into TipoConta(Descricao) values ('Comercial')";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "insert into TipoConta(Descricao) values ('Residencial')";
					cmd.ExecuteNonQuery();

					//Para Pessoa Física todas as propriedades de menos a data de nascimento sâo strings, se atentar para colocar entre aspas " " 

					//clienteRepository.Add(new Pessoa_Fisica(_cpf:  , _telefone: , _dtNascimento: , _nome: , _email: ,
					//	_senha: Cryptography_Password.CryptographyMethod(), _codigo: ));

					// Para Residencia -- Codigo, CodPEssoa e numero sâo int, demais campos são string

					//residenciaRepository.Add(new Residencias(codigo: ,rua: , bairro: ,cidade: ,numero: ,cep: ,estado: 
					//	, descricao: ,codPessoa: ));


					clienteRepository.Add(new Pessoa_Fisica(_cpf:  "959.185.590-78", _telefone: "31 97527-5120", _dtNascimento: new DateTime(2001,10,30), _nome: "Lucas Castro Soares", _email: "lucas.castro@gmail.com",
						_senha: Cryptography_Password.CryptographyMethod("1"), _codigo: "1"));

					residenciaRepository.Add(new Residencias(codigo: 1, rua: "Rua Aderbal Lopes", bairro: "Funcionários", cidade: "contagem", numero: 20, cep: "32040-360", estado:"MG"
						, descricao: "casa", codPessoa: 1));

					pessoa.codigo = "1";
					residencia.codigo = 1;
					Conta_Comercial contaComercial = new Conta_Comercial(dtPagamento: new DateTime(2023, 06, 27), dtVencimento: new DateTime(2023, 06, 30), mesAnterior: 500, mesReferencia: 900
																		  , residencia: residencia, cliente: pessoa);
					contaRepository.Add(contaComercial);
				}
			}
		}

    }
}
