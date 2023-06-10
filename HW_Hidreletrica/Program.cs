<<<<<<< HEAD
using HW_Hidreletrica.Entidades.Usuario.Cliente.Conta;
=======
>>>>>>> Gustavo-Alves
using HW_Hidreletrica.Telas.Tela_cliente;

namespace HW_Hidreletrica
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
<<<<<<< HEAD
            Application.Run(new Contas_Clientes());
=======
            Application.Run(new Cadastro_Cliente());
>>>>>>> Gustavo-Alves
        }
    }
}