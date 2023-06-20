using HW_Hidreletrica.Entidades.Usuario.Cliente.Residencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Entidades.Usuario.Cliente.Conta.Conta_Comercial
{
	internal class Conta_Comercial : Contas
	{
        public Conta_Comercial()
        {
            
        }

		public Conta_Comercial(double mesReferencia, double mesAnterior, Clientes cliente, Residencias residencia, DateTime dtPagamento,DateTime dtVencimento) : base(mesReferencia, mesAnterior,  cliente, residencia, dtPagamento,dtVencimento)
		{

		}

		public override double CalculaConsumo(double val1, double val2)
		{
			
			return Math.Abs(val1 - val2);
		}

		public override double CalculaValorSemImpostos(double val1)
		{

			double tarifa = 0.35;
			double contribuicaoAdicional = 9.25;
			double soma = (this.consumo * tarifa) + contribuicaoAdicional;

			return Math.Round(soma, 0);
		}

		public override double CalculaValorTotal(double val1)
		{
			double tarifa = 0.35;
			double contribuicaoAdicional = 9.25;
			double imposto = 0.18;
			double soma = (this.consumo * tarifa) + contribuicaoAdicional;

			return Math.Round((soma * imposto) + soma,2);
		}
	}
}
