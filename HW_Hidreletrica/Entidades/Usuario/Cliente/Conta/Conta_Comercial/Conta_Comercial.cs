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

		public Conta_Comercial(int codigo, double mesReferencia, double mesAnterior, double consumo, Cliente cliente, Residencias residencia, int codigoTipo, double valorTotalSemImpostos,DateTime dtPagamento,DateTime dtVencimento) : base(codigo, mesReferencia, mesAnterior, consumo, cliente, residencia, codigoTipo, valorTotalSemImpostos,dtPagamento,dtVencimento)
		{

		}

		public override double CalculaConsumo(double val1, double val2)
		{
			
			return (val1 - val2);
		}

		public override double CalculaValorSemImpostos(double val1)
		{

			double tarifa = 0.35;
			double contribuicaoAdicional = 9.25;
			double soma = (this.consumo * tarifa) + contribuicaoAdicional;

			return soma;
		}

		public override double CalculaValorTotal(double val1)
		{
			double tarifa = 0.35;
			double contribuicaoAdicional = 9.25;
			double imposto = 0.18;
			double soma = (this.consumo * tarifa) + contribuicaoAdicional;

			return (soma * imposto) + soma;
		}
	}
}
