using HW_Hidreletrica.Entidades.Connect_SQL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Services.Residencia {
	public class ResidenciaRepository : IResidenciaRepository {

		public DataTable getResidencias(int codUsuario) {
			Connect_Server.database = "HW_Hidreletrica";
			using (SqlConnection conexao = new SqlConnection(Connect_Server.Connect())) {
				conexao.Open();

				var sqlQuery = $"SELECT R.Codigo, NumInstalacao AS 'Instalação', Descricao AS Apelido, CONCAT(E.RUA, ', ', E.NUMERO, ' , ', E.BAIRRO, ', ',  E.CIDADE) " +
					$"AS 'Endereço' FROM Residencia R, Endereco E WHERE R.CODENDERECO = E.CODIGO AND CODPESSOA = {codUsuario}";
				
				using (SqlDataAdapter dados = new SqlDataAdapter(sqlQuery, conexao)) {
					using (DataTable residencias = new DataTable()) {
						dados.Fill(residencias);         //EXTRAI OS DADOS	
						return residencias;
					}
				}
			}
		}

		public void excluirResidencia(int codResidencia) {
			Connect_Server.database = "HW_Hidreletrica";
			using (SqlConnection conexao = new SqlConnection(Connect_Server.Connect())) {
				conexao.Open();
				using (SqlCommand query = conexao.CreateCommand()) {
					query.CommandText = $"DELETE FROM RESIDENCIA WHERE CODIGO = {codResidencia}";
					query.ExecuteNonQuery();
				}
			}
		}

		public void Add<T>(T entity) where T : class {
			throw new NotImplementedException();
		}

		public void Delete<T>(T entity) where T : class {
			throw new NotImplementedException();
		}

		public bool SaveChanges() {
			throw new NotImplementedException();
		}

		public void Update<T>(T entity) where T : class {
			throw new NotImplementedException();
		}
	}
}
