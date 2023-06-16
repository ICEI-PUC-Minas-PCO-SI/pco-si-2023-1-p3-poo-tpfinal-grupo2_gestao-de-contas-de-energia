using HW_Hidreletrica.Entidades.Usuario.Cliente.Residencia;
using HW_Hidreletrica.Entidades.Usuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HW_Hidreletrica.Services.Residencia;
using HW_Hidreletrica.Services.Repository.Cliente;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Globalization;

namespace HW_Hidreletrica.Telas.Tela_cliente {
	public partial class DadosCliente : Form {

		private int codigoCliente;
		ResidenciaRepository residencia = new ResidenciaRepository();
		ClienteRepository cliente = new ClienteRepository();
		public DadosCliente(int codigoCliente) {
			this.codigoCliente = codigoCliente;
			InitializeComponent();
		}


		private void DadosCliente_Load(object sender, EventArgs e) {
			carregaInformacoesCliente();
			carregaResidencias();
		}

		public void carregaInformacoesCliente() {
			TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;

			try {
				DataTable sql = cliente.getInformacoesCliente(codigoCliente);
				labelNome.Text = textInfo.ToTitleCase(sql.Rows[0]["nome"].ToString());
				labelEmail.Text = sql.Rows[0]["email"].ToString();
				labelTelefone.Text = sql.Rows[0]["telefone"].ToString();
				if (string.IsNullOrEmpty(sql.Rows[0]["CNPJ"].ToString())) {
					labelDescricao.Text = "CPF: ";
					labelIdentificador.Text = sql.Rows[0]["CPF"].ToString();

				} else {
					labelDescricao.Text = "CNPJ:";
					labelIdentificador.Text = "CNPJ:" + sql.Rows[0]["CNPJ"].ToString();
				}
			} catch (Exception ex) {
				MessageBox.Show("Não foi possível carregar informações do cliente:" + ex.Message);
			}
		}

		public void carregaResidencias() {
			try {
				DataTable dataTable = residencia.getResidencias(codigoCliente);
				if (dataTable.Rows.Count > 0) { 
					dataGridViewResidenciasCliente.DataSource = dataTable;
					dataGridViewResidenciasCliente.Visible = true;
					dataGridViewResidenciasCliente.Columns[0].Visible = false;     //OCULTANDO O CÓDIGO DA RESIDENCIA
					dataGridViewResidenciasCliente.Columns[1].Width = 120;
					dataGridViewResidenciasCliente.Columns[2].Visible = false;
					dataGridViewResidenciasCliente.Columns[3].Width = 380;
				} else {
					dataGridViewResidenciasCliente.Visible = false;
					mostraMensagem("Nenhuma residência cadastrada");
				}

			} catch (Exception ex) {
				MessageBox.Show("Não foi possível carregar residencias:" + ex.Message);
			}
		}

		private void mostraMensagem(string mensagem) {

			System.Windows.Forms.Label texto = new System.Windows.Forms.Label();
			texto.Text = mensagem;
			texto.Width = 500;
			texto.Height = 100;
			texto.ForeColor = Color.Red;
			texto.Font = new Font("Microsoft Sans Serif", 15);
			texto.Location = new System.Drawing.Point(400, 200);
			this.Controls.Add(texto);
		}
	}
}
