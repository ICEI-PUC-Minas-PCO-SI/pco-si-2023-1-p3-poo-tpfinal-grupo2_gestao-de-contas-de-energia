using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Services.Repository.Cliente
{
	internal interface IClienteRepository : IRepository
	{
		Boolean getClienteByEmail(string email);
	}
}
