using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace HW_Hidreletrica.Entidades.Usuario.Cliente
{
     abstract class Clientes : Usuario
    {
        private string telefone;
        private DateTime dtNascimento;
		public Clientes()
		{
		}
        public Clientes(string _telefone,DateTime _dtNascimento,string _nome, string _email, string _senha,string _codigo) : base (_nome,_email,_senha,_codigo)
        {
            this.telefone = _telefone;
            this.dtNascimento = _dtNascimento;
        }
        public string getTelefone()
        {
            return telefone;
        }
        public DateTime getDtNascimento()
        {
            return dtNascimento;
        }
    }

}
