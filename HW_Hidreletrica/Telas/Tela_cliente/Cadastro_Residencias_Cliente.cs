using HW_Hidreletrica.Entidades.Usuario.Cliente.Residencia;
using HW_Hidreletrica.Services.Residencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Hidreletrica.Telas.Tela_cliente {
	public partial class Cadastro_Residencias_Cliente : Form {

		ResidenciaRepository residencia = new ResidenciaRepository();
		public bool inserir = false;
		public int codResidencia;
		public Cadastro_Residencias_Cliente(int codResidencia) {
			inserir = false;
			this.codResidencia = codResidencia;
			InitializeComponent();
			
		}

		public Cadastro_Residencias_Cliente() {
			inserir = true;
			InitializeComponent();
		}
		private void Cadastro_Residencias_Cliente_Load(object sender, EventArgs e) {
			if (!inserir) {
				getInformacoesResidencia();				//PREENCHE INFORMAÇÕES PARA EDITAR
			}
		}

		private void btnCadastro_Click(object sender, EventArgs e) {
			if (inserir) {
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
			} else {
				atualizaResidencia();
			}
		}

		public void atualizaResidencia() {
			if (!string.IsNullOrEmpty(txbApelido.Text)){
				aviso.Visible = false;
				try {
					residencia.atualizaApelido(txbApelido.Text, codResidencia);
					Form residenciasCadastradas = new Residencias_Cliente();
					residenciasCadastradas.Show();
					this.Hide();
				} catch (Exception ex) {
					MessageBox.Show("Não foi possível atualizar a residencia: " + ex.Message);
				}
				
			} else {
				aviso.Visible = true;
			}
		}

		public void getInformacoesResidencia() {
			try {
				DataTable sql = residencia.getInformacoesResidencia(codResidencia);
				txbApelido.Text = sql.Rows[0]["Descricao"].ToString();
				txbRua.Text = sql.Rows[0]["Rua"].ToString();
				txbRua.ReadOnly = true;
				txbBairro.Text = sql.Rows[0]["Bairro"].ToString();
				txbBairro.ReadOnly = true;
				txtCidade.Text = sql.Rows[0]["Cidade"].ToString();
				txtCidade.ReadOnly = true;
				txtCep.Text = sql.Rows[0]["Cep"].ToString();
				txtCep.ReadOnly = true;

				cbxUF.Items.Clear();
				cbxUF.Items.Add(sql.Rows[0]["Estado"].ToString());
				cbxUF.SelectedIndex = 0;

				cbxUF.Enabled = false;
				txtNumero.Text = sql.Rows[0]["Numero"].ToString();
				txtNumero.ReadOnly = true;
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
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
