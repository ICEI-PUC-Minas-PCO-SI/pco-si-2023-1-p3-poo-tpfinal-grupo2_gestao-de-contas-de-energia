using HW_Hidreletrica.Entidades.Usuario.Cliente.Residencia;
using HW_Hidreletrica.Services.Residencia;
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
	public partial class Cadastro_Residencias_Cliente : Form {

		ResidenciaRepository residencia = new ResidenciaRepository();
		public Cadastro_Residencias_Cliente() {
			InitializeComponent();
		}

		private void btnCadastro_Click(object sender, EventArgs e) {
			string apelido = txbApelido.Text;
			string rua = txbRua.Text;
			string bairro = txbBairro.Text;
			string cidade = txtCidade.Text;
			string cep = txtCep.Text;
			string uf = cbxUF.Text;

			if (!string.IsNullOrEmpty(apelido) && !string.IsNullOrEmpty(rua) && !string.IsNullOrEmpty(bairro) && !string.IsNullOrEmpty(cidade) && !string.IsNullOrEmpty(cep) && !string.IsNullOrEmpty(uf) && !string.IsNullOrEmpty(txtNumero.Text)) {
				int numero = int.Parse(txtNumero.Text);
				aviso.Visible = false;
				try {
					int instalacao = this.residencia.getMaxIntalacao() + 1;
					Residencias novaResidencia = new Residencias(instalacao, rua, bairro, cidade, numero, cep, uf, apelido, 3);
					residencia.Add(novaResidencia);

					Form residenciasCadastradas = new Residencias_Cliente();
					residenciasCadastradas.Show();
					this.Hide();

				} catch (Exception ex) {
					MessageBox.Show("Não foi possível adicionar a residencia: " + ex.Message);
				}
			} else {
				aviso.Visible = true;
			}

		}

		//FUNCAO PARA PERMITIR APENAS NÚMEROS NO LABEL 
		private void txtNumero_KeyPress(object sender, KeyPressEventArgs e) {
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
				e.Handled = true;
			}
		}

		private void txtCep_KeyPress(object sender, KeyPressEventArgs e) {
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
				e.Handled = true;
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e) {
			Form residenciasCadastradas = new Residencias_Cliente();
			residenciasCadastradas.Show();
			this.Hide();
		}
	}
}
