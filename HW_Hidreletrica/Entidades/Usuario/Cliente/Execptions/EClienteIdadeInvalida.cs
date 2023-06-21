using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Entidades.Usuario.Cliente.Execptions
{
    internal class EClienteIdadeInvalida : ApplicationException
    {
        public EClienteIdadeInvalida(string message) : base(message)
        {

        }
    }
}
