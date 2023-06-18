using HW_Hidreletrica.Entidades.Usuario.Cliente;
using HW_Hidreletrica.Entidades.Usuario;
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
using HW_Hidreletrica.Services.Repository.EMP;

namespace HW_Hidreletrica.Telas.Tela_emp {
	public partial class Perfil_EMP : Form {
		AdministradorRepository adm = new AdministradorRepository();
		public Perfil_EMP() {
			InitializeComponent();
		}

		private void Perfil_EMP_FormClosing(object sender, FormClosingEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				if (MessageBox.Show("Você deseja fechar a aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					Application.Exit();
				} else {
					e.Cancel = true;
				}
			}
		}

		private void Perfil_EMP_Load(object sender, EventArgs e) {
			carregaInformacoesAdministrador();
		}

		private void carregaInformacoesAdministrador() {
			TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

			try {
				DataTable sql = adm.getInformacoesAdministrador(LocalStorage.getCodigoUsuario());
				lb_nome.Text = textInfo.ToTitleCase(sql.Rows[0]["nome"].ToString());
				lb_email.Text = sql.Rows[0]["email"].ToString();

			} catch (Exception ex) {
				MessageBox.Show("Não foi possível carregar informações do cliente:" + ex.Message);
			}
		}
	}
}
