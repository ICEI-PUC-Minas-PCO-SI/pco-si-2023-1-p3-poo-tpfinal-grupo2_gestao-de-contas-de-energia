using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Services.Repository.Cliente
{
	public interface IAdministradorRepository : IRepository
	{
		DataTable getCliente(string email, string senha);
	}
}
