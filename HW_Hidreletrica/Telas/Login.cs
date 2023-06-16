using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HW_Hidreletrica.Entidades.Usuario;
using HW_Hidreletrica.Services.Repository.Cliente;
using HW_Hidreletrica.Services.Repository.EMP;
using HW_Hidreletrica.Telas.Tela_cliente;
using HW_Hidreletrica.Telas.Tela_emp;

namespace HW_Hidreletrica.Telas {
	public partial class Login : Form {

		ClienteRepository cliente = new ClienteRepository();
		AdministradorRepository adm = new AdministradorRepository();
		public Login() {
			InitializeComponent();
		}
		private void txt_usuario_TextChanged(object sender, EventArgs e) {

		}

		private void txt_password_TextChanged(object sender, EventArgs e) {
		}

		private void btn_login(object sender, EventArgs e) {
			string email = txtEmail.Text;
			string senha = txtSenha.Text;
			string tipoUsuario = cbxTipoUsuario.Text;

			if (!string.IsNullOrEmpty(email) && !string.IsNullOrEmpty(senha) && !string.IsNullOrEmpty(tipoUsuario)) {
				mensagem.Visible = false;
				try {
					senha = Cryptography_Password.CryptographyMethod(senha);
					if (tipoUsuario == "Cliente") {
						DataTable sql = cliente.getCliente(email, senha);
						if (sql.Rows.Count != 0) {
							mensagem.Visible = false;

							string nome = sql.Rows[0]["nome"].ToString();
							int codigo = int.Parse(sql.Rows[0]["codigo"].ToString());
							LocalStorage.salvaInformacoes(nome, email, codigo, "Cliente");

							Tela_Principal_Cliente telaCliente = new Tela_Principal_Cliente();
							telaCliente.Show();
							this.Hide();
						} else {
							mensagem.Text = "Email ou senha incorretos";
							mensagem.Visible = true;
						}
					} else {
						DataTable sql = adm.getAdminitrador(email, senha);
						if (sql.Rows.Count != 0) {
							mensagem.Visible = false;

							string nome = sql.Rows[0]["nome"].ToString();
							int codigo = int.Parse(sql.Rows[0]["CodAdministrador"].ToString());
							LocalStorage.salvaInformacoes(nome, email, codigo, "Administrador");

							Tela_Principal_EMP telaAdm = new Tela_Principal_EMP();
							telaAdm.Show();
							this.Hide();
						} else {
							mensagem.Text = "Email ou senha incorretos";
							mensagem.Visible = true;
						}
					}

				} catch (Exception ex) {
					MessageBox.Show(ex.Message);
				}

			} else {
				mensagem.Text = "Preencha todos os campos";
				mensagem.Visible = true;
			}

		}

		private void pictureBox1_Click(object sender, EventArgs e) {

		}

		private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e) {

		}

		private void label2_Click(object sender, EventArgs e) {

		}

		private void label4_Click(object sender, EventArgs e) {

		}

		private void btnVoltar_Click(object sender, EventArgs e) {
			Principal principal = new Principal();
			principal.Show();
			this.Hide();
		}
	}
}
