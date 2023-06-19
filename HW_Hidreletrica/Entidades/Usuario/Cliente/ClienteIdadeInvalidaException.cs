using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Entidades.Usuario.Cliente
{
	internal class ClienteIdadeInvalidaException : Exception
	{
        public ClienteIdadeInvalidaException(string message): base(message)
        {
            
        }
    }
}
