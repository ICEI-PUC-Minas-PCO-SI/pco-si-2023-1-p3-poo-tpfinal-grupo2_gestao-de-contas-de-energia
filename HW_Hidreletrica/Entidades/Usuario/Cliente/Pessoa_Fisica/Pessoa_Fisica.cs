using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Entidades.Usuario.Cliente.Pessoa_Fisica
{
	internal class Pessoa_Fisica : Clientes
	{
		private string cpf;

        public Pessoa_Fisica()
        {
            
        }
        public Pessoa_Fisica(string _cpf, string _telefone, DateTime _dtNascimento, string _nome, string _email, string _senha) : base(_telefone, _dtNascimento,_nome,_email, _senha)
        {
            this.cpf = _cpf;
        }
        public string getCpf()
        {
            return cpf;
        }
    }
}
