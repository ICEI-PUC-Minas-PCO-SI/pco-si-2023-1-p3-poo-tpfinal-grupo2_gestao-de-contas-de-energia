using HW_Hidreletrica.Entidades.Connect_SQL;
using HW_Hidreletrica.Entidades.Usuario.Cliente;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Pessoa_Fisica;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Pessoa_Juridica;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HW_Hidreletrica.Services.Repository.Cliente
{
	internal class ClienteRepository : IClienteRepository
	{
		public bool getClienteByEmail(string email)
		{
			using(SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
			{
				cn.Open();
				string sql = $"select Email from Pessoa where Email = '{email}'";

				using (SqlDataAdapter da = new SqlDataAdapter(sql,cn))
				{
					DataTable dt = new DataTable();
					da.Fill(dt);
					
					if(dt.Rows.Count > 0)
						return true;
					return false;
				}
			}
		}
		public void Add<T>(T entity) where T : class
		{
			int CodTipo;
			string query;
			

			if (entity is Clientes)
			{
				
				if(entity is Pessoa_Fisica) 
				{
					Pessoa_Fisica cliente = entity as Pessoa_Fisica;
					CodTipo = 1;
					query = "insert into Pessoa(Nome, Email, senha, DtNascimento, CPF,CodTipo, Telefone) values " +
					$"(@Nome,@Email,@Senha,@DtNascimento,@Cpf,@Codtipo,@Telefone);";

					using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
					{
						cn.Open();

						using (SqlCommand cmd = new SqlCommand(query, cn))
						{
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
				}
				else
				{
					Pessoa_Juridica cliente = entity as Pessoa_Juridica;
					CodTipo = 2;
					query = "insert into Pessoa(Nome, Email, senha, DtNascimento, CNPJ,CodTipo, Telefone) values " +
					$"(@Nome,@Email,@Senha,@DtNascimento,@CNPJ,@Codtipo,@Telefone);";

					using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
					{
						cn.Open();

						using (SqlCommand cmd = new SqlCommand(query, cn))
						{
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

		public void Delete<T>(T entity) where T : class
		{
			throw new NotImplementedException();
		}
		public bool SaveChanges()
		{
			throw new NotImplementedException();
		}

		public void Update<T>(T entity) where T : class
		{
			throw new NotImplementedException();
		}
	}
}
