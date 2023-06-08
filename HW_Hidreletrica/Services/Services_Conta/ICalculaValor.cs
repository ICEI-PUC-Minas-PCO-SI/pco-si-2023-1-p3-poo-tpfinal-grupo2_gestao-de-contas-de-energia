using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Services.Services_Conta
{
	internal interface ICalculaValor
	{
		double CalculaValorTotal(double val1);
		double CalculaConsumo(double val1,double val2);

		double CalculaValorSemImpostos(double val1);
	}
}
