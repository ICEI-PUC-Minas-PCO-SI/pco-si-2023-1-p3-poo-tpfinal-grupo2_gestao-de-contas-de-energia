using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Entidades.Usuario.Cliente.Residencia
{
	public class Residencias
	{
        public int numInstalacao { get; set; }
        public string rua { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public int numero { get; set; }
        public string cep { get; set; }
        public string estado { get; set; }
        public string descricao { get; set; }
		public int codPessoa { get; set; }
        public Residencias()
        {
            
        }

		public Residencias(int numInstalacao, string rua, string bairro, string cidade, int numero, string cep, string estado, string descricao, int codPessoa)
		{
			this.numInstalacao = numInstalacao;
			this.rua = rua;
			this.bairro = bairro;
			this.cidade = cidade;
			this.numero = numero;
			this.cep = cep;
			this.estado = estado;
			this.descricao = descricao;
			this.codPessoa = codPessoa;
		}
	}
}
