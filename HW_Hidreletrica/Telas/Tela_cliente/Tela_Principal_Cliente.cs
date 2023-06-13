using HW_Hidreletrica.Entidades.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Hidreletrica.Telas.Tela_cliente
{
    public partial class Tela_Principal_Cliente : Form
    {
        public Tela_Principal_Cliente()
        {
            InitializeComponent();
        }

        private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Tela_Principal_Cliente_Load(object sender, EventArgs e)
        {

        }

        private void menu_perfil(object sender, EventArgs e)
        {

        }

        private void menu_logout(object sender, EventArgs e)
        {
			LocalStorage.logOut();
			Form1 principal = new Form1();
			principal.Show();
			this.Hide();
		}

        private void menu_residencia(object sender, EventArgs e)
        {
            
        }
    }
}
