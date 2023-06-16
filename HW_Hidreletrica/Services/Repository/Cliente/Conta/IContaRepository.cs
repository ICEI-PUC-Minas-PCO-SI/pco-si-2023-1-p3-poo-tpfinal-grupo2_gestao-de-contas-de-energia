using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Services.Repository.Cliente.Conta
{
	public interface IContaRepository : IRepository
	{
		DataTable getContaMes(int mesReferencia,int codigoResidencia);
	}
}
