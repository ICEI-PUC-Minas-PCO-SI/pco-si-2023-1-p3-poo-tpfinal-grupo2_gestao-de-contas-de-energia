using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using HW_Hidreletrica.Services.Repository.Cliente;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Pessoa_Fisica;
using HW_Hidreletrica.Entidades.Usuario.Cliente;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Pessoa_Juridica;
using HW_Hidreletrica.Entidades.Usuario;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Execptions;

namespace HW_Hidreletrica.Telas.Tela_cliente
{
    public partial class Cadastro_Cliente : Form
	{
		ClienteRepository clienteRepository = new ClienteRepository();
		public Cadastro_Cliente()
		{
			InitializeComponent();
			cbx_cpf.SelectedIndex = 0;

		}

		private void cbx_cpf_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbx_cpf.SelectedIndex == 0)
			{
				txt_CNPJ_CPF.Mask = "000,000,000-00";

			}
			else
			{
				txt_CNPJ_CPF.Mask = "00,000,000/0000-00";
			}
		}

		private void txt_email_Leave(object sender, EventArgs e)
		{
			string pattern = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
							 @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
							 @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";

			if (Regex.IsMatch(txt_email.Text, pattern))
			{
				errorProvider1.Clear();

			}
			else
			{
				errorProvider1.SetError(txt_email, "Favor colocar um e-mail válido");

			}
		}

		private void txt_telefone_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != ' ' && e.KeyChar != '-')
			{
				e.Handled = true;
			}
		}

		private void btn_cadastrar_Click(object sender, EventArgs e)
		{
			Clientes cliente;

			if (string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_telefone.Text) || string.IsNullOrEmpty(txt_nome.Text) || string.IsNullOrEmpty(txt_senha.Text) || string.IsNullOrEmpty(txt_confsenha.Text) || string.IsNullOrEmpty(txt_CNPJ_CPF.Text) || string.IsNullOrEmpty(dtNascimento.Text))
			{
				MessageBox.Show("Favor preencher todos os campos do formulário para que o cadastro seja realizado", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
			else if (!string.IsNullOrEmpty(errorProvider1.GetError(txt_email)) || !string.IsNullOrEmpty(errorProvider2.GetError(txt_telefone)) || !string.IsNullOrEmpty(errorProvider4.GetError(txt_confsenha)))
			{
				MessageBox.Show("Favor preencher o formulário de forma correta para que o cadastro possa ser realizado", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
			else if (cbx_cpf.SelectedIndex == 0 && txt_CNPJ_CPF.Text.Length != 14)
			{
				errorProvider5.SetError(txt_CNPJ_CPF, "Favor preencher o campo de forma completa");
			}
			else if (cbx_cpf.SelectedIndex == 1 && txt_CNPJ_CPF.Text.Length != 18)
			{
				errorProvider5.SetError(txt_CNPJ_CPF, "Favor preencher o campo de forma completa");

			}
			else if (txt_senha.Text.Length < 8)
			{
				MessageBox.Show("A senha deve conter no mínimo 8 caracteres","ERROR",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
			}
			else
			{
				// Aqui verifica se o e-mail que esta tentando ser cadastrado já existe

				if (clienteRepository.getClienteByEmail(txt_email.Text))
				{
					MessageBox.Show("Esse cliente ja esta cadastrado", "ERRO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
				}
				else
				{
					try
					{

						if ((DateTime.Now.Year - (int.Parse(dtNascimento.Text.Substring(6))) < 16))
						{
							throw new EClienteIdadeInvalida("Cadastro de usuários somente para maiores de 16 anos");
						}
						if (cbx_cpf.SelectedIndex == 0)
						{
							cliente = new Pessoa_Fisica(_nome: txt_nome.Text, _email: txt_email.Text, _telefone: txt_telefone.Text, _senha: Cryptography_Password.CryptographyMethod(txt_senha.Text), _codigo: clienteRepository.getIdCliente(),
																			 _cpf: txt_CNPJ_CPF.Text, _dtNascimento: new DateTime(int.Parse(dtNascimento.Text.Substring(6)), int.Parse(dtNascimento.Text.Substring(3, 2)), int.Parse(dtNascimento.Text.Substring(0, 2))));

						}
						else
						{
							cliente = new Pessoa_Juridica(_nome: txt_nome.Text, _email: txt_email.Text, _telefone: txt_telefone.Text, _senha: Cryptography_Password.CryptographyMethod(txt_senha.Text), _codigo: clienteRepository.getIdCliente(),
																			 _cnpj: txt_CNPJ_CPF.Text, _dtNascimento: new DateTime(int.Parse(dtNascimento.Text.Substring(6)), int.Parse(dtNascimento.Text.Substring(3, 2)), int.Parse(dtNascimento.Text.Substring(0, 2))));
						}

						
						//Cadastrando novo Usuário
						clienteRepository.Add(cliente);
						MessageBox.Show("Usuário Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

						
						// Salvando Usuário que acabou de se cadastrar no LocalStorage
						DataTable dt = clienteRepository.getCliente(txt_email.Text, Cryptography_Password.CryptographyMethod(txt_senha.Text));
						int codigo = int.Parse(dt.Rows[0]["codigo"].ToString());
						LocalStorage.salvaInformacoes(txt_nome.Text, txt_email.Text, codigo, "Cliente");


						Tela_Principal_Cliente principalCliente = new Tela_Principal_Cliente();
						principalCliente.Show();
						this.Hide();
					}
					catch (EClienteIdadeInvalida ex)
					{
						MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
					}
					
				}
			}

		}

		private void txt_confsenha_Leave(object sender, EventArgs e)
		{
			if ((string.IsNullOrEmpty(txt_confsenha.Text) || string.IsNullOrEmpty(txt_senha.Text) || (txt_senha.Text != txt_confsenha.Text)))
			{
				string erro = "O campo não pode ser nulo ou vazio";
				errorProvider3.SetError(txt_senha, erro);
				errorProvider4.SetError(txt_confsenha, erro);
			}
			else if ((txt_senha.Text != txt_confsenha.Text))
			{
				string erro = "As senhas devem ser iguais";
				errorProvider3.SetError(txt_senha, erro);
				errorProvider4.SetError(txt_confsenha, erro);
			}
			else
			{
				errorProvider3.Clear();
				errorProvider4.Clear();
			}
		}

		private void txt_telefone_Leave_1(object sender, EventArgs e)
		{
			if (txt_telefone.Text.Length != 13)
			{
				errorProvider2.SetError(txt_telefone, "Favor inserir um telefone válido");
			}
			else
			{
				errorProvider2.Clear();
			}
		}

		private void txt_CNPJ_CPF_Leave(object sender, EventArgs e)
		{
			if (cbx_cpf.SelectedIndex == 0)
			{
				if (txt_CNPJ_CPF.Text.Length != 14)
				{
					errorProvider5.SetError(txt_CNPJ_CPF, "Favor preencher o campo de forma completa");
				}
				else
				{
					errorProvider5.Clear();
				}

			}
			else
			{
				if (txt_CNPJ_CPF.Text.Length != 18)
				{
					errorProvider5.SetError(txt_CNPJ_CPF, "Favor preencher o campo de forma completa");
				}
				else
				{
					errorProvider5.Clear();
				}
			}
		}

		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			Principal principal = new Principal();
			principal.Show();
			this.Hide();
		}

		private void Cadastro_Cliente_FormClosing(object sender, FormClosingEventArgs e)
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
