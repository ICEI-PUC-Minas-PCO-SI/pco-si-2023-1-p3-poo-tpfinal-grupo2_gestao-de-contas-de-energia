using HW_Hidreletrica.Entidades.Connect_SQL;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Conta;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Conta.Conta_Comercial;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Services.Repository.Cliente
{
	public class ClienteRepository : IAdministradorRepository
	{
		string tabela;

        public ClienteRepository()
        {
            
        }
        public DataTable getCliente(string emailUsuario, string senhaUsuario)
		{
			using (SqlConnection conexao = new SqlConnection(Connect_Server.Connect()))
			{
				conexao.Open();
				string query = $"select nome,email,codigo from Pessoa where Email = '{emailUsuario}' and Senha = '{senhaUsuario}'";

				using (SqlDataAdapter dados = new SqlDataAdapter(query, conexao))
				{
					DataTable datatable = new DataTable();
					dados.Fill(datatable);
					return datatable;
				}
			}
		}

		public void Add<T>(T entity) where T : class
		{
			throw new NotImplementedException();
		}

		void IRepository.Delete<T>(T entity)
		{
			throw new NotImplementedException();
		}

		bool IRepository.SaveChanges()
		{
			throw new NotImplementedException();
		}

		void IRepository.Update<T>(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
