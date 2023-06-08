using HW_Hidreletrica.Entidades.Usuario.Cliente;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Residencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Entidades.Usuario.Cliente.Conta
{
	internal class Conta
	{
        public int codigo { get; set; }
        public double mesReferencia { get; set; }
        public double mesAnterior { get; set; }
        public double Consumo { get; set; }
        public double valorTotal { get; set; }
        public Cliente cliente { get; set; }
        public Residencias residencia { get; set; }
        public int codigoTipo { get; set; }
        public Conta()
        {
            
        }

		public Conta(int codigo, double mesReferencia, double mesAnterior, double consumo, Cliente cliente, Residencias residencia, int codigoTipo)
		{
			this.codigo = codigo;
			this.mesReferencia = mesReferencia;
			this.mesAnterior = mesAnterior;
			Consumo = consumo;
			this.cliente = cliente;
			this.residencia = residencia;
			this.codigoTipo = codigoTipo;
		}
	}
}
