﻿using HW_Hidreletrica.Entidades.Usuario;
using HW_Hidreletrica.Services.Repository.Cliente;
using HW_Hidreletrica.Services.Repository.EMP;
using HW_Hidreletrica.Telas.Tela_cliente;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Hidreletrica.Telas.Tela_emp {
	public partial class Tela_Principal_EMP : Form {
		AdministradorRepository adminRepos = new AdministradorRepository();
		public Tela_Principal_EMP() {
			InitializeComponent();
			cbx_Filtro.SelectedIndex = 5;
			dt_Clientes.DataSource = adminRepos.getAllClientes();
			label4.Text = (dt_Clientes.RowCount).ToString();

		}

		private void cbx_Filtro_SelectedIndexChanged(object sender, EventArgs e) {
			txt_Input.Enabled = true;
			txt_Input.Text = "";

			switch (cbx_Filtro.SelectedIndex.ToString()) {

				case "0":
				txt_Input.Mask = "000,000,000-00";
				break;
				case "1":
				txt_Input.Mask = "00,000,000/0000-00";
				break;
				case "2":
				txt_Input.Mask = "000000000000";
				break;
				case "3":
				txt_Input.Mask = "000000000000";
				break;
				case "4":
				errorProvider1.Clear();
				txt_Input.Enabled = false;
				break;
				case "5":
				errorProvider1.Clear();
				txt_Input.Enabled = false;
				break;

			}

		}

		private void btn_AplicaFiltro_Click(object sender, EventArgs e) {

			if (cbx_Filtro.SelectedIndex == 0 && txt_Input.Text.Length != 14) {
				errorProvider1.SetError(txt_Input, "Favor preencher o campo de forma completa");
			} else if (cbx_Filtro.SelectedIndex == 1 && txt_Input.Text.Length != 18) {
				errorProvider1.SetError(txt_Input, "Favor preencher o campo de forma completa");

			} else if ((cbx_Filtro.SelectedIndex == 3 || cbx_Filtro.SelectedIndex == 2) && txt_Input.Text.Length < 1) {
				MessageBox.Show(txt_Input.Text.Length.ToString());
				errorProvider1.SetError(txt_Input, "Favor preencher o campo de forma completa");
			} else {
				errorProvider1.Clear();

				try
				{


					switch (cbx_Filtro.SelectedIndex.ToString())
					{
						case "0":
							dt_Clientes.DataSource = adminRepos.getClienteByCpf(txt_Input.Text);
							break;
						case "1":
							dt_Clientes.DataSource = adminRepos.getClienteByCnpj(txt_Input.Text);
							break;
						case "2":
							dt_Clientes.DataSource = adminRepos.getClienteByCIdentificador(txt_Input.Text);
							break;
						case "3":
							dt_Clientes.DataSource = adminRepos.getClienteByConsumo(double.Parse(txt_Input.Text));
							break;
						case "4":
							dt_Clientes.DataSource = adminRepos.getClienteByContaAtraso();
							break;
						case "5":
							dt_Clientes.DataSource = adminRepos.getAllClientes();
							break;

					}
					label4.Text = (dt_Clientes.RowCount).ToString();
				}
				catch(Exception ex)
				{
					MessageBox.Show("Ocorreu um problema inesperado, contate o administrador e mostre o seguinte erro: " + ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
				}
			}


		}

		private void Tela_Principal_EMP_FormClosing(object sender, FormClosingEventArgs e) {
			if (e.CloseReason == CloseReason.UserClosing) {
				if (MessageBox.Show("Você deseja fechar a aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
					Application.Exit();
				} else {
					e.Cancel = true;
				}
			}
		}

		private void btnVerCliente_Click(object sender, EventArgs e) {
			int clienteSelecionado = dt_Clientes.Rows.GetRowCount(DataGridViewElementStates.Selected);
			if (clienteSelecionado == 1) {
				foreach (DataGridViewRow row in dt_Clientes.SelectedRows) {
					int codCliente = (int)row.Cells[0].Value;        //PEGANDO CÓDIGO DA RESIDENCIA
					DadosCliente dadosCliente = new DadosCliente(codCliente);
					dadosCliente.Show();
					this.Hide();
				}
			} else {
				MessageBox.Show("Selecione apenas um cliente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void perfilToolStripMenuItem_Click(object sender, EventArgs e) {
			Perfil_EMP perfil = new Perfil_EMP();
			perfil.Show();
			this.Hide();
		}

		private void logOutToolStripMenuItem_Click(object sender, EventArgs e) {
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
	}
}
