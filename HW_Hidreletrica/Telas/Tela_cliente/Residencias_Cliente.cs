using HW_Hidreletrica.Entidades.Connect_SQL;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Residencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Hidreletrica.Telas.Tela_cliente {
	public partial class Residencias_Cliente : Form {
		public Residencias_Cliente() {
			InitializeComponent();
		}

		private void Residencias_Cliente_Load(object sender, EventArgs e) {
			carregaResidencias();
		}

		public void carregaResidencias() {
			try {
				dataGridViewResidencias.DataSource = ResidenciaDAO.Carregar();
				dataGridViewResidencias.Columns[0].Visible = false;     //OCULTANDO O CÓDIGO DA RESIDENCIA
				dataGridViewResidencias.Columns[1].Width = 120;
				dataGridViewResidencias.Columns[2].Width = 150;
				dataGridViewResidencias.Columns[3].Width = 380;
				/*var largura = 0;
				foreach (DataGridViewColumn column in dataGridViewResidencias.Columns) {
					largura += 50;
					column.Width = largura;
					//column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
				}**/

			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}
	}
}
