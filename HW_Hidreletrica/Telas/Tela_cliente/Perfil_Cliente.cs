using HW_Hidreletrica.Entidades.Usuario;
using HW_Hidreletrica.Entidades.Usuario.Cliente;
using HW_Hidreletrica.Services.Repository.Cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Hidreletrica.Telas.Tela_cliente {
	public partial class Perfil_Cliente : Form {

		ClienteRepository cliente = new ClienteRepository();
		public Perfil_Cliente() {
			InitializeComponent();
		}

		private void Perfil_Cliente_Load(object sender, EventArgs e) {
			carregaInformacoesUsuario();
		}

		private void carregaInformacoesUsuario() {
			TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

			try {
				DataTable sql = cliente.getInformacoesCliente(LocalStorage.getCodigoUsuario());
				lb_nome.Text = textInfo.ToTitleCase(sql.Rows[0]["nome"].ToString());
				lb_email.Text = sql.Rows[0]["email"].ToString();
				lb_telefone.Text = sql.Rows[0]["telefone"].ToString();
				string[] dataNascimento = sql.Rows[0]["DtNascimento"].ToString().Split(" ");

				lb_data.Text = dataNascimento[0];

			} catch (Exception ex) {
				MessageBox.Show("Não foi possível carregar informações do cliente:" + ex.Message);
			}
		}

		private void btn_sair_Click(object sender, EventArgs e) {
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

		private void btn_voltar_Click(object sender, EventArgs e) {
			Tela_Principal_Cliente principalCliente = new Tela_Principal_Cliente();
			principalCliente.Show();
			this.Hide();
		}
	}
}
