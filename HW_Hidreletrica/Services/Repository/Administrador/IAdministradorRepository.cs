using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Services.Repository.Administrador
{
	internal interface IAdministradorRepository : IRepository
	{
		Boolean getAdministradorByEmail(string email);
	}
}
