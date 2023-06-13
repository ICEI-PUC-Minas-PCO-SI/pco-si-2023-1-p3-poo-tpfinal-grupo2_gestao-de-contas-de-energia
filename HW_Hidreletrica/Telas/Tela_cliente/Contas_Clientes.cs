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

		public Contas_Clientes(int codigoResidencia) {
			this.codigoResidencia = codigoResidencia;
			InitializeComponent();


			dtContaAtual.DataSource = contaRepository.getContaMes(0);
			dtContaMesAnterior.DataSource = contaRepository.getContaMes(1);
			dtConta2MesesAnterior.DataSource = contaRepository.getContaMes(2);



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

	}
}
