using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Entidades.Usuario.EMP
{
    internal class Administradores : Usuario
    {
        public Administradores()
        {
            
        }
        public Administradores(string _nome, string _email, string _senha) : base (_nome,_email,_senha)
        {
            
        }
    }
}
