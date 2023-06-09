using HW_Hidreletrica.Entidades.Connect_SQL;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Residencia;
using HW_Hidreletrica.Services.Residencia;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace HW_Hidreletrica.Telas.Tela_cliente {
	public partial class Residencias_Cliente : Form {

		ResidenciaRepository residencia = new ResidenciaRepository();
		public Residencias_Cliente() {
			InitializeComponent();
		}

		private void Residencias_Cliente_Load(object sender, EventArgs e) {
			carregaResidencias();
		}

		public void carregaResidencias() {
			try {
				dataGridViewResidencias.DataSource = residencia.getResidencias(3);
				if (dataGridViewResidencias.RowCount > 0) {
					dataGridViewResidencias.Columns[0].Visible = false;     //OCULTANDO O CÓDIGO DA RESIDENCIA
					dataGridViewResidencias.Columns[1].Width = 120;
					dataGridViewResidencias.Columns[2].Width = 150;
					dataGridViewResidencias.Columns[3].Width = 380;
					btnDeletar.Visible = true;
					btnContas.Visible = true;
					btnEditar.Visible = true;
				} else {
					btnDeletar.Visible = false;
					btnContas.Visible = false;
					btnEditar.Visible = false;
					dataGridViewResidencias.Visible = false;
					mostraMensagem("Nenhuma residência cadastrada");
				}

			} catch (Exception ex) {
				MessageBox.Show("Não foi possível carregar residencias:" + ex.Message);
			}
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) {

		}

		private void btnDeletar_Click(object sender, EventArgs e) {
			int residenciasSelecionadas = dataGridViewResidencias.Rows.GetRowCount(DataGridViewElementStates.Selected);
			if (residenciasSelecionadas > 0) {
				var confirmaExclusao = MessageBox.Show("Tem certeza que deseja excluir as residências selecionadas? ", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);

				if (confirmaExclusao == DialogResult.OK) {
					try {
						foreach (DataGridViewRow row in dataGridViewResidencias.SelectedRows) {
							int codResidencia = (int)row.Cells[0].Value;        //PEGANDO CÓDIGO DA RESIDENCIA
							residencia.excluirResidencia(codResidencia);
						}
						carregaResidencias();
					} catch (Exception ex) {
						MessageBox.Show("Não foi possível excluir residencia: " + ex.Message);
					}
				}
			} else {
				MessageBox.Show("Escolha uma residência para excluir!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void mostraMensagem(string mensagem) {

			System.Windows.Forms.Label texto = new System.Windows.Forms.Label();
			texto.Text = mensagem;
			texto.Width = 500;
			texto.Height = 100;
			texto.ForeColor = Color.Red;
			texto.Font = new Font("Microsoft Sans Serif", 15);
			texto.Location = new System.Drawing.Point(250, 200);
			this.Controls.Add(texto);
		}

		private void textoResidencias_Click(object sender, EventArgs e) {

		}

		private void btnAdicionar_Click(object sender, EventArgs e) {
			Form residenciasCadastradas = new Cadastro_Residencias_Cliente();
			residenciasCadastradas.Show();
			this.Hide();
		}
	}
}
