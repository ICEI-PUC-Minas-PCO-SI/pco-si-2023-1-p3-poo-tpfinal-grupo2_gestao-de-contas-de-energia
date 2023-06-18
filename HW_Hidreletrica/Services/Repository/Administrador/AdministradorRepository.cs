using HW_Hidreletrica.Entidades.Connect_SQL;
using HW_Hidreletrica.Entidades.Usuario.Cliente;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Pessoa_Fisica;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Pessoa_Juridica;
using HW_Hidreletrica.Entidades.Usuario.EMP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HW_Hidreletrica.Services.Repository.Administrador
{
	internal class AdministradorRepository : IAdministradorRepository
	{
		public bool getAdministradorByEmail(string email)
		{
			using(SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
			{
				cn.Open();
				string sql = $"select Email from Administrador where Email = '{email}'";

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
			string query;

			if (entity is Administradores)
			{
				Administradores administrador = entity as Administradores;
				query = "insert into Administrador(Nome, Email, senha) values " +
				$"(@Nome,@Email,@Senha);";

				using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
				{
					cn.Open();

					using (SqlCommand cmd = new SqlCommand(query, cn))
					{
						cmd.Parameters.AddWithValue("@Nome", administrador.getNome());
						cmd.Parameters.AddWithValue("@Email", administrador.getEmail());
						cmd.Parameters.AddWithValue("@Senha", administrador.getSenha());
						cmd.ExecuteNonQuery();
						//os parametros virao do objeto
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
