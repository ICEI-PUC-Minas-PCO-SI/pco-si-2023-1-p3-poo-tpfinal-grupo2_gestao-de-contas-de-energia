using HW_Hidreletrica.Entidades.Usuario.Cliente.Residencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Entidades.Usuario.Cliente.Conta.Conta_Residencial
{
	internal class Conta_Residencial : Contas
	{
        public Conta_Residencial()
        {
            
        }

		public Conta_Residencial( double mesReferencia, double mesAnterior, Clientes cliente, Residencias residencia, DateTime dtPagamento,DateTime dtVencimento) : base( mesReferencia, mesAnterior, cliente, residencia,dtPagamento,dtVencimento)
		{

		}

		public override double CalculaConsumo(double val1, double val2)
		{
			this.consumo = (val1 - val2);
			return this.consumo;
		}

		public override double CalculaValorSemImpostos(double val1)
		{
			double tarifa = 0.40;
			double contribuicaoAdicional = 9.25;
			double soma = (this.consumo * tarifa) + contribuicaoAdicional;

			return  soma;
		}

		public override double CalculaValorTotal(double val1)
		{
			double tarifa = 0.40;
			double contribuicaoAdicional = 9.25;
			double imposto = 0.30;
			double soma = (this.consumo * tarifa) + contribuicaoAdicional;

			return (soma * imposto) + soma;
			
		}
	}
}
