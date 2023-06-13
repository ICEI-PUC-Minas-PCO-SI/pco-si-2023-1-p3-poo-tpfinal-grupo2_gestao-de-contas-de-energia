using HW_Hidreletrica.Entidades.Connect_SQL;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Residencia;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Services.Residencia {
	public class ResidenciaRepository : IResidenciaRepository {

		public ResidenciaRepository() {
			Connect_Server.database = "HW_Hidreletrica";
		}

		public DataTable getResidencias(int codUsuario) {
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

			using (SqlConnection conexao = new SqlConnection(Connect_Server.Connect())) {
				conexao.Open();
				using (SqlCommand query = conexao.CreateCommand()) {
					query.CommandText = $"DELETE FROM RESIDENCIA WHERE CODIGO = {codResidencia}";
					query.ExecuteNonQuery();
				}
			}
		}

		public int getMaxIntalacao() {
			using (SqlConnection conexao = new SqlConnection(Connect_Server.Connect())) {
				conexao.Open();
				using (SqlCommand query = conexao.CreateCommand()) {
					query.CommandText = "Select max(NumInstalacao) from Residencia";
					object result = query.ExecuteScalar();
					int instalacao;
					try {
						instalacao = Convert.ToInt32(query.ExecuteScalar());
						return instalacao;
					} catch (Exception ex) {
						return 0000;
					}
				}
			}
		}

		public void Add<T>(T entity) where T : class {
			if (entity is Residencias) {
				Residencias residencia = entity as Residencias;

				using (SqlConnection conexao = new SqlConnection(Connect_Server.Connect())) {
					conexao.Open();
					using (SqlCommand query = conexao.CreateCommand()) {
						query.CommandText = "INSERT INTO ENDERECO (NUMERO, RUA, BAIRRO, CIDADE, ESTADO, CEP) VALUES(@NUMERO, @RUA, @BAIRRO, @CIDADE, @ESTADO, @CEP)";
						query.Parameters.AddWithValue("@NUMERO", residencia.numero);
						query.Parameters.AddWithValue("@RUA", residencia.rua);
						query.Parameters.AddWithValue("@BAIRRO", residencia.bairro);
						query.Parameters.AddWithValue("@CIDADE", residencia.cidade);
						query.Parameters.AddWithValue("@ESTADO", residencia.estado);
						query.Parameters.AddWithValue("@CEP", residencia.cep);
						query.ExecuteNonQuery();

						query.CommandText = "INSERT INTO RESIDENCIA (NUMINSTALACAO, DESCRICAO, CODPESSOA, CODENDERECO) VALUES(@NUMINSTALACAO, @DESCRICAO, @CODPESSOA, (SELECT MAX(CODIGO) FROM ENDERECO))";
						query.Parameters.AddWithValue("@NUMINSTALACAO", residencia.numInstalacao);
						query.Parameters.AddWithValue("@DESCRICAO", residencia.descricao);
						query.Parameters.AddWithValue("@CODPESSOA", residencia.codPessoa);
						query.ExecuteNonQuery();
					}
				}
			}
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

		public DataTable getInformacoesResidencia(int codResidencia) {
			using (SqlConnection conexao = new SqlConnection(Connect_Server.Connect())) {
					conexao.Open();
				var sqlQuery = $"SELECT * FROM RESIDENCIA R, ENDERECO E WHERE R.CODIGO = {codResidencia} AND E.CODIGO = R.CODENDERECO";
				using (SqlDataAdapter dados = new SqlDataAdapter(sqlQuery, conexao)) {
					using (DataTable residencias = new DataTable()) {
						dados.Fill(residencias);         //EXTRAI OS DADOS	
						return residencias;
					}
				}
			}
		}

		public void atualizaApelido(string apelido, int codresidencia) {
			using(SqlConnection conexao = new SqlConnection(Connect_Server.Connect())) {
				conexao.Open();
				using (SqlCommand query = conexao.CreateCommand()) {
					query.CommandText = "UPDATE RESIDENCIA SET DESCRICAO = @DESCRICAO WHERE CODIGO = @CODIGO";
					query.Parameters.AddWithValue("@DESCRICAO", apelido);
					query.Parameters.AddWithValue("@CODIGO", codresidencia);
					query.ExecuteNonQuery();
				}
			}
		}
	}
}
