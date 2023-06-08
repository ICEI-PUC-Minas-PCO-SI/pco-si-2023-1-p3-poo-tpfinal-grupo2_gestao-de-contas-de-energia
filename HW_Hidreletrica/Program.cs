using HW_Hidreletrica.Entidades.Connect_SQL;
using HW_Hidreletrica.Telas.Tela_cliente;

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
			Application.Run(new Residencias_Cliente());
			/*try {
				Script_Server.CreateDatabase();
				Application.Run(new Form1());
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
            }*/



		}
    }
}