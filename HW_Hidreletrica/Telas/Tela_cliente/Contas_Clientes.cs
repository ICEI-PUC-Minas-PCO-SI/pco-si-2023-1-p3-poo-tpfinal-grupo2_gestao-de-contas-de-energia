using HW_Hidreletrica.Entidades.Usuario.Cliente.Conta.Conta_Comercial;
using HW_Hidreletrica.Services.Repository.Cliente.Conta;
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
	public partial class Contas_Clientes : Form
	{
		ContaRepository contaRepository = new ContaRepository();
		int codigoResidencia;

		public Contas_Clientes(int codigoResidencia)
		{
			this.codigoResidencia = codigoResidencia;
			InitializeComponent();

			try
			{
				dtContaAtual.DataSource = contaRepository.getContaMes(0, codigoResidencia);
				dtContaMesAnterior.DataSource = contaRepository.getContaMes(1, codigoResidencia);
				dtConta2MesesAnterior.DataSource = contaRepository.getContaMes(2, codigoResidencia);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ocorreu um problema inesperado, contate o administrador e mostre o seguinte erro: " + ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
			
			cb_FiltroMes.SelectedIndex = 0;
			this.codigoResidencia = codigoResidencia;
		}

		private void cbFiltroMes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cb_FiltroMes.SelectedIndex == 1)
			{

				lb_MesAnterior.Visible = true;
				dtContaMesAnterior.Visible = true;

				lb_2MesesAnteriores.Visible = false;
				dtConta2MesesAnterior.Visible = false;

			}
			else if (cb_FiltroMes.SelectedIndex == 2)
			{
				lb_MesAnterior.Visible = true;
				dtContaMesAnterior.Visible = true;

				lb_2MesesAnteriores.Visible = true;
				dtConta2MesesAnterior.Visible = true;
			}
			else
			{
				lb_MesAnterior.Visible = false;
				dtContaMesAnterior.Visible = false;

				lb_2MesesAnteriores.Visible = false;
				dtConta2MesesAnterior.Visible = false;
			}
		}

		private void btnVoltar_Click(object sender, EventArgs e)
		{
			Tela_Principal_Cliente principal_Cliente = new Tela_Principal_Cliente();
			principal_Cliente.Show();
			this.Hide();
		}

		private void Contas_Clientes_FormClosing(object sender, FormClosingEventArgs e)
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
