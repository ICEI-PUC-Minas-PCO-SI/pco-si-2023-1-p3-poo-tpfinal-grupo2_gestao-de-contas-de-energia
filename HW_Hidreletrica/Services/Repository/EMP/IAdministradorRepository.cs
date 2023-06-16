using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Services.Repository.EMP
{
	public interface IAdministradorRepository : IRepository
	{
		DataTable getAdminitrador(string email, string senha);
	}
}
