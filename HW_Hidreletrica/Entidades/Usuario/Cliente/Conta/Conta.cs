using HW_Hidreletrica.Entidades.Usuario.Cliente;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Residencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Entidades.Usuario.Cliente.Conta
{
	abstract class Contas
	{
        public int codigo { get; set; }
        public double mesReferencia { get; set; }
        public double mesAnterior { get; set; }
        public double consumo { get; set; }
        public double valorTotal { get; set; }
        public double valorTotalSemImpostos { get; set; }
        public Clientes cliente { get; set; }
        public Residencias residencia { get; set; }
        public int codigoTipo { get; set; }
        public DateTime dtPagamento { get; set; }
        public DateTime dtVencimento { get; set; }
        public Contas()
        {
            
        }

		public Contas(int codigo, double mesReferencia, double mesAnterior, double consumo, Clientes cliente, Residencias residencia, int codigoTipo, double valorTotalSemImpostos, DateTime dtPagamento, DateTime dtVencimento)
		{
			this.codigo = codigo;
			this.mesReferencia = mesReferencia;
			this.mesAnterior = mesAnterior;
			this.consumo = consumo;
			this.cliente = cliente;
			this.residencia = residencia;
			this.codigoTipo = codigoTipo;
			this.valorTotalSemImpostos = valorTotalSemImpostos;
			this.dtPagamento = dtPagamento;
			this.dtVencimento = dtVencimento;
		}
		public abstract double CalculaValorTotal(double val1);
		public abstract double CalculaConsumo(double val1, double val2);

		public abstract double CalculaValorSemImpostos(double val1);
	}
}
