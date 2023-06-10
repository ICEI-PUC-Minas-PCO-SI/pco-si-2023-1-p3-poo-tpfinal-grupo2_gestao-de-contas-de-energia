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
        static void CreateDatabase()
        {

            using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
            {
                cn.Open();

				using (SqlCommand cmd = cn.CreateCommand())
				{
					cmd.CommandText = "create database HW_Hidreletrica";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "use HW_Hidreletrica";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "create table Administrador(\r\n\tCodAdministrador int PRIMARY KEY IDENTITY(1,1),\r\n\tNome char(30) not null,\r\n\tEmail char(30) not null,\r\n\tsenha char(15) not null\r\n);";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "create table TipoPessoa(\r\n\tCodigo int PRIMARY KEY IDENTITY(1,1),\r\n\tDescricao char(30) not null\r\n);";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "create table Pessoa(\r\n\tCodigo int PRIMARY KEY IDENTITY(1,1),\r\n\tNome varchar(30) not null,\r\n\tEmail varchar(30) not null,\r\n\tsenha varchar(15) not null,\r\n\tDtNascimento date not null,\r\n\tCPF varchar(15),\r\n\tCNPJ varchar(15),\r\n\tCodTipo int not null,\r\n\tTelefone varchar(15),\r\n\tConstraint FK_CodTipo Foreign Key(CodTipo) references TipoPessoa\r\n);";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "create table Endereco(\r\n\tCodigo int PRIMARY KEY IDENTITY(1,1),\r\n\tNumero int  not null,\r\n\tRua varchar(100) not null,\r\n\tBairro varchar(40) not null,\r\n\tCidade varchar(30) not null,\r\n\tEstado varchar(30)  not null,\r\n\tCep varchar(30) not null\r\n);";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "create table Residencia(\r\n\tCodigo int PRIMARY KEY IDENTITY(1,1),\r\n\tNumInstalacao int not null,\r\n\tDescricao char(30) not null,\r\n\tCodPessoa int not null,\r\n\tCodEndereco int not null,\r\n\tConstraint FK_CodPessoa Foreign Key(CodPessoa) references Pessoa,\r\n\tConstraint FK_CodEndereco Foreign Key(CodEndereco) references Endereco\r\n);";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "create table TipoConta(\r\n\tCodigo int PRIMARY KEY IDENTITY(1,1),\r\n\tDescricao varchar(60) not null\r\n);";
					cmd.ExecuteNonQuery();
					cmd.CommandText = "create table Conta(\r\n\tCodigo int IDENTITY(1,1),\r\n\tMesReferencia double PRECISION,\r\n\tMesAnterior double PRECISION,\r\n\tConsumo double PRECISION, \r\n\tValorTotal double PRECISION, \r\n\tCodTipo int,\r\n\tdtPagamento date,\r\n\tdtVencimento date,\r\n\tPrimary Key(Codigo)\r\n\t\r\n);";
					cmd.ExecuteNonQuery();

				}
				
				Connect_Server.database = "HW_Hidreletrica";
           
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
					// todo o script dos inserts estarão aqui
					cmd.ExecuteNonQuery();
					
				}
			}
		}

    }
}
