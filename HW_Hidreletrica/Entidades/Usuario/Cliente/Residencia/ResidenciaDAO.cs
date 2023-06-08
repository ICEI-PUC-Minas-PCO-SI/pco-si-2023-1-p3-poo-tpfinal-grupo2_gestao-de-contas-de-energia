using HW_Hidreletrica.Entidades.Connect_SQL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Hidreletrica.Entidades.Usuario.Cliente.Residencia {
	public static class ResidenciaDAO {

		public static DataTable Carregar() {
			Connect_Server.database = "HW_Hidreletrica";
			using (SqlConnection conexao = new SqlConnection(Connect_Server.Connect())) {
				conexao.Open();

				var sqlQuery = "" +
					"Select R.Codigo, NumInstalacao as 'Instalação', Descricao as Apelido, CONCAT(E.RUA, ', ', E.NUMERO, ' , ', E.BAIRRO, ', ',  E.CIDADE) " +
					"AS 'Endereço' From Residencia R, Endereco E " +
					"WHERE R.CODENDERECO = E.CODIGO";

				using (SqlDataAdapter dados = new SqlDataAdapter(sqlQuery, conexao)) {
					using (DataTable residencias = new DataTable()) {
						dados.Fill(residencias);         //EXTRAI OS DADOS	
						return residencias;	
					}
				}
			}
		}
	}
}
