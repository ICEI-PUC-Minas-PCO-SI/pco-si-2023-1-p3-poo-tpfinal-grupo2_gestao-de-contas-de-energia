﻿using HW_Hidreletrica.Entidades.Connect_SQL;
using HW_Hidreletrica.Entidades.Usuario.Cliente;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Pessoa_Fisica;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Pessoa_Juridica;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Conta;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Conta.Conta_Comercial;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HW_Hidreletrica.Services.Repository.Cliente {
	internal class ClienteRepository : IClienteRepository
	{
		string tabela;
		public bool getClienteByEmail(string email) {

			using (SqlConnection cn = new SqlConnection(Connect_Server.Connect())) {
				cn.Open();
				string sql = $"select Email from Pessoa where Email = '{email}'";

				using (SqlDataAdapter da = new SqlDataAdapter(sql, cn)) {
					DataTable dt = new DataTable();
					da.Fill(dt);

					if (dt.Rows.Count > 0)
						return true;
					return false;
				}
			}
		}
		public void Add<T>(T entity) where T : class {
			int CodTipo;
			string query;


			if (entity is Clientes) {

				if (entity is Pessoa_Fisica) {
					Pessoa_Fisica cliente = entity as Pessoa_Fisica;
					CodTipo = 1;
					query = "insert into Pessoa(Nome, Email, senha, DtNascimento, CPF,CodTipo, Telefone) values " +
					$"(@Nome,@Email,@Senha,@DtNascimento,@Cpf,@Codtipo,@Telefone);";

					using (SqlConnection cn = new SqlConnection(Connect_Server.Connect())) {
						cn.Open();

						using (SqlCommand cmd = new SqlCommand(query, cn)) {
							cmd.Parameters.AddWithValue("@Nome", cliente.getNome());
							cmd.Parameters.AddWithValue("@Email", cliente.getEmail());
							cmd.Parameters.AddWithValue("@Senha", cliente.getSenha());
							cmd.Parameters.AddWithValue("@DtNascimento", cliente.getDtNascimento());
							cmd.Parameters.AddWithValue("@Cpf", cliente.getCpf());
							cmd.Parameters.AddWithValue("@Codtipo", CodTipo);
							cmd.Parameters.AddWithValue("@Telefone", cliente.getTelefone());
							cmd.ExecuteNonQuery();
							//os parametros virao do objeto
						}
					}
				} else {
					Pessoa_Juridica cliente = entity as Pessoa_Juridica;
					CodTipo = 2;
					query = "insert into Pessoa(Nome, Email, senha, DtNascimento, CNPJ,CodTipo, Telefone) values " +
					$"(@Nome,@Email,@Senha,@DtNascimento,@CNPJ,@Codtipo,@Telefone);";

					using (SqlConnection cn = new SqlConnection(Connect_Server.Connect())) {
						cn.Open();

						using (SqlCommand cmd = new SqlCommand(query, cn)) {
							cmd.Parameters.AddWithValue("@Nome", cliente.getNome());
							cmd.Parameters.AddWithValue("@Email", cliente.getEmail());
							cmd.Parameters.AddWithValue("@Senha", cliente.getSenha());
							cmd.Parameters.AddWithValue("@DtNascimento", cliente.getDtNascimento());
							cmd.Parameters.AddWithValue("@CNPJ", cliente.getCnpj());
							cmd.Parameters.AddWithValue("@Codtipo", CodTipo);
							cmd.Parameters.AddWithValue("@Telefone", cliente.getTelefone());
							cmd.ExecuteNonQuery();
							//os parametros virao do objeto
						}
					}

				}
			}
		}

		public DataTable getCliente(string emailUsuario, string senhaUsuario) {
			using (SqlConnection conexao = new SqlConnection(Connect_Server.Connect())) {
				conexao.Open();
				string query = $"select nome,email,codigo from Pessoa where Email = '{emailUsuario}' and Senha = '{senhaUsuario}'";

				using (SqlDataAdapter dados = new SqlDataAdapter(query, conexao)) {
					DataTable datatable = new DataTable();
					dados.Fill(datatable);
					return datatable;
				}
			}
		}

		public DataTable getInformacoesCliente(int codigoCliente) {
			using (SqlConnection conexao = new SqlConnection(Connect_Server.Connect())) {
				conexao.Open();
				string query = $"select * from Pessoa where codigo = '{codigoCliente}'";

				using (SqlDataAdapter dados = new SqlDataAdapter(query, conexao)) {
					DataTable datatable = new DataTable();
					dados.Fill(datatable);
					return datatable;
				}
			}
		}

		public string getIdCliente()
		{
			//select MAX(Codigo) from Pessoa

			using(SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
			{
				cn.Open();

				string query = "select MAX(Codigo) as Codigo from Pessoa";
				using(SqlDataAdapter ad = new SqlDataAdapter(query, cn))
				{
					DataTable dt = new DataTable();
					ad.Fill(dt);

					int result = int.Parse(dt.Rows[0]["Codigo"].ToString() + 1);

					return (result.ToString());
				}

			}
		}
	}
}