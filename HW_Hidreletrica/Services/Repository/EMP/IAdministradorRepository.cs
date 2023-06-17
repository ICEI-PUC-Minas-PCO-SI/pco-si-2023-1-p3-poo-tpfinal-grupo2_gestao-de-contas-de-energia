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

		DataTable getAllClientes();

		DataTable getClienteByCpf(string cpf);
		DataTable getClienteByCnpj(string cnpj);

		DataTable getClienteByCIdentificador(int identificador);

		DataTable getClienteByConsumo(double consumo);

		DataTable getClienteByContaAtraso();
	}
}
