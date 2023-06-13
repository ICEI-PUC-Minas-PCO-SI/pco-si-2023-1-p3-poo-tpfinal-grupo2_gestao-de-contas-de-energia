using HW_Hidreletrica.Entidades.Usuario;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Conta;
using HW_Hidreletrica.Telas;
using HW_Hidreletrica.Telas.Tela_cliente;
using HW_Hidreletrica.Telas.Tela_emp;

namespace HW_Hidreletrica
{
    public static class Program
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

            if (LocalStorage.verificaUsuarioLogado()) {
                string tipoUsuario= LocalStorage.getTipoUsuario();
                if(tipoUsuario == "Cliente") {
                    Application.Run(new Tela_Principal_Cliente());
                }if (tipoUsuario == "Administrador") {
					Application.Run(new Tela_Principal_EMP());
                } else {
					Application.Run(new Principal());
				}
            } else {
				Application.Run(new Principal());
			}
		}
    }
}