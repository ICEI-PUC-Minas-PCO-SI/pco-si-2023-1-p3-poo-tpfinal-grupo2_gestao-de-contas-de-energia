using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Services.Residencia {
	public interface IResidenciaRepository : IRepository {

		public DataTable getResidencias(int codUsuario);
		public void excluirResidencia(int codigoResidencia);

		public int getMaxIntalacao();
		public DataTable getInformacoesResidencia(int codResidencia);

		public void atualizaApelido(string apelido, int codresidencia);
	}
}
