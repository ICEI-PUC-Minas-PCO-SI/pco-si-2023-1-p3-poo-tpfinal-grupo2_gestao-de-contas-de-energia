using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Entidades.Usuario
{
	abstract class Usuario
	{
        public string codigo;
        private string nome;
        private string email;
        private string senha;

        public Usuario()
        {
            
        }
        public Usuario(string _nome,string _email,string _senha,string _codigo)
        {
            this.codigo = _codigo;
            this.nome = _nome;
            this.email = _email;
            this.senha = _senha;
        }
        public string getNome()
        {
            return nome;
        }public string getEmail()
        {
            return email;
        }public string getSenha()
        {
            return senha;
        }
        public string getCodigo()
        {
            return codigo;
        }
    }
}
