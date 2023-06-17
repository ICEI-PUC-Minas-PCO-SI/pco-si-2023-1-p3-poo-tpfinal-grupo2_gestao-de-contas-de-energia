using HW_Hidreletrica.Services.Repository.Cliente;
using HW_Hidreletrica.Services.Repository.EMP;
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

namespace HW_Hidreletrica.Telas.Tela_emp
{
	public partial class Tela_Principal_EMP : Form
	{
		AdministradorRepository adminRepos = new AdministradorRepository();
		public Tela_Principal_EMP()
		{
			InitializeComponent();
			cbx_Filtro.SelectedIndex = 0;
			dt_Clientes.DataSource = adminRepos.getAllClientes();
			label4.Text = (dt_Clientes.RowCount - 1).ToString();

		}

		private void cbx_Filtro_SelectedIndexChanged(object sender, EventArgs e)
		{
			txt_Input.Enabled = true;
			txt_Input.Text = "";

			switch (cbx_Filtro.SelectedIndex.ToString())
			{

				case "0": txt_Input.Mask = "000,000,000-00"; break;
				case "1": txt_Input.Mask = "00,000,000/0000-00"; break;
				case "2": txt_Input.Mask = "000000000000"; break;
				case "3": txt_Input.Mask = "000000000000"; break;
				case "4": errorProvider1.Clear(); txt_Input.Enabled = false; break;


			}

		}

		private void btn_AplicaFiltro_Click(object sender, EventArgs e)
		{

			if (cbx_Filtro.SelectedIndex == 0 && txt_Input.Text.Length != 14)
			{
				errorProvider1.SetError(txt_Input, "Favor preencher o campo de forma completa");
			}
			else if (cbx_Filtro.SelectedIndex == 1 && txt_Input.Text.Length != 18)
			{
				errorProvider1.SetError(txt_Input, "Favor preencher o campo de forma completa");

			}
			else if ((cbx_Filtro.SelectedIndex == 3 || cbx_Filtro.SelectedIndex == 2) && txt_Input.Text.Length < 1)
			{
				MessageBox.Show(txt_Input.Text.Length.ToString());
				errorProvider1.SetError(txt_Input, "Favor preencher o campo de forma completa");
			}
			else
			{
				errorProvider1.Clear();

				switch (cbx_Filtro.SelectedIndex.ToString())
				{
					case "0": dt_Clientes.DataSource = adminRepos.getClienteByCpf(txt_Input.Text); break;
					case "1": dt_Clientes.DataSource = adminRepos.getClienteByCnpj(txt_Input.Text); break;
					case "2": dt_Clientes.DataSource = adminRepos.getClienteByCIdentificador(txt_Input.Text); break;
					case "3": dt_Clientes.DataSource = adminRepos.getClienteByConsumo(double.Parse(txt_Input.Text)); break;
					case "4": dt_Clientes.DataSource = adminRepos.getClienteByContaAtraso(); break;
				}
				label4.Text = (dt_Clientes.RowCount - 1).ToString();
			}


		}

		private void Tela_Principal_EMP_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (e.CloseReason == CloseReason.UserClosing)
			{
				if (MessageBox.Show("Você deseja fechar a aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
				{
					Application.Exit();
				}
				else
				{
					e.Cancel = true;
				}
			}
		}
	}
}
