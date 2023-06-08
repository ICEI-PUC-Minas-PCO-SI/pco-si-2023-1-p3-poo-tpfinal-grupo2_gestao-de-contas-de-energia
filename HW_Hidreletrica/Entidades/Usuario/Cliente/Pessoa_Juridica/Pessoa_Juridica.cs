using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Entidades.Usuario.Cliente.Pessoa_Juridica
{
	internal class Pessoa_Juridica : Cliente
	{
		private string cnpj;

        public Pessoa_Juridica()
        {
            
        }
        public Pessoa_Juridica(string _cnpj, string _telefone, DateTime _dtNascimento, string _nome, string _email, string _senha) : base(_telefone, _dtNascimento, _nome, _email, _senha)
        {
            this.cnpj = _cnpj;
        }
        public string getCnpj()
        {
            return cnpj;
        }

    }
}
