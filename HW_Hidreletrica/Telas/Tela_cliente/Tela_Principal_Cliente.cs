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

namespace HW_Hidreletrica.Telas.Tela_cliente {
	public partial class Tela_Principal_Cliente : Form {
		public Tela_Principal_Cliente() {
			InitializeComponent();
		}

		private void perfilToolStripMenuItem_Click(object sender, EventArgs e) {

		}

		private void Tela_Principal_Cliente_Load(object sender, EventArgs e) {

		}

		private void menu_perfil(object sender, EventArgs e) {
			Perfil_Cliente perfil = new Perfil_Cliente();
			perfil.Show();
			this.Hide();
		}

		private void menu_logout(object sender, EventArgs e) {
			var confirmaLogOut = MessageBox.Show("Tem certeza que deseja sair? ", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			if (confirmaLogOut == DialogResult.Yes) {
				try {
					LocalStorage.logOut();
					Principal principal = new Principal();
					principal.Show();
					this.Hide();
				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}
			}
		}

		private void menu_residencia(object sender, EventArgs e) {
			Residencias_Cliente residencias = new Residencias_Cliente();
			residencias.Show();
			this.Hide();
		}

		private void Tela_Principal_Cliente_FormClosing(object sender, FormClosingEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				if (MessageBox.Show("Você deseja fechar a aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					Application.Exit();
				} else {
					e.Cancel = true;
				}
			}
		}
	}
}
