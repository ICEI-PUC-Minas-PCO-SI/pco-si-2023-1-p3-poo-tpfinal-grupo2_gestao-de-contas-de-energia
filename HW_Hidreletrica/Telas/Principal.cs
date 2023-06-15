using HW_Hidreletrica.Telas;
using HW_Hidreletrica.Telas.Tela_cliente;

namespace HW_Hidreletrica {
	public partial class Principal : Form {
		public Principal() {
			InitializeComponent();
		}

		private void btn_login_Click(object sender, EventArgs e) {
			Login login = new Login();
			login.Show();
			this.Hide();
		}

		private void btn_cadastro_Click(object sender, EventArgs e) {
			Cadastro_Cliente cadastro = new Cadastro_Cliente();
			cadastro.Show();
			this.Hide();
		}
	}
}