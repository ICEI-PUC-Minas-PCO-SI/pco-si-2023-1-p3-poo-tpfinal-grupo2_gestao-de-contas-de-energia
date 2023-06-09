﻿using HW_Hidreletrica.Entidades.Usuario;
using HW_Hidreletrica.Entidades.Usuario.EMP;
using HW_Hidreletrica.Services.Repository.Cliente;
using HW_Hidreletrica.Services.Repository.EMP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW_Hidreletrica.Telas.Tela_emp
{
	public partial class Cadastro_Administrador : Form
	{

		//AdministradorRepository administradorRepository = new AdministradorRepository();
		AdministradorRepository administradorRepository = new AdministradorRepository();
		public Cadastro_Administrador()
		{
			InitializeComponent();
		}

		private void txt_email_Leave_1(object sender, EventArgs e)
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
				errorProvider1.SetError(txt_email, "Favor inserir um e-mail válido");

			}
		}

		private void btn_cadastrar_Click(object sender, EventArgs e)
		{
			Administradores administrador;

			if (string.IsNullOrEmpty(txt_email.Text) || string.IsNullOrEmpty(txt_nome.Text) || string.IsNullOrEmpty(txt_senha.Text) || string.IsNullOrEmpty(txt_confsenha.Text))
			{
				MessageBox.Show("Favor preencher todos os campos do formulário para que o cadastro seja realizado", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}
			else if (!string.IsNullOrEmpty(errorProvider1.GetError(txt_email)) || !string.IsNullOrEmpty(errorProvider3.GetError(txt_confsenha)))
			{
				MessageBox.Show("Favor preencher o formulário de forma correta para que o cadastro possa ser realizado", "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
			}

			else
			{
				try
				{


					if (administradorRepository.getAdministradorByEmail(txt_email.Text))
					{
						MessageBox.Show("Esse administrador ja esta cadastrado", "ERRO", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
					}
					else
					{
						
						administrador = new Administradores(_nome: txt_nome.Text, _email: txt_email.Text, _senha: Cryptography_Password.CryptographyMethod(txt_senha.Text), administradorRepository.getIdAdministrador());

						administradorRepository.Add(administrador);
						//MessageBox.Show("Usuário Cadastrado com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

						LocalStorage.logOut();
						DataTable dt = administradorRepository.getAdminitrador(txt_email.Text, Cryptography_Password.CryptographyMethod(txt_senha.Text));
						int codigo = int.Parse(dt.Rows[0]["CodAdministrador"].ToString());
						LocalStorage.salvaInformacoes(txt_nome.Text, txt_email.Text, codigo, "Administrador");

						Tela_Principal_EMP principal_EMP = new Tela_Principal_EMP();
						principal_EMP.Show();
						this.Hide();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Ocorreu um problema inesperado e não foi possível realizar o cadastro do administrador, contate o administrador e mostre o seguinte erro: " + ex.Message, "ERROR", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

				}
			}
		}

		private void txt_confsenha_Leave(object sender, EventArgs e)
		{
			if ((string.IsNullOrEmpty(txt_confsenha.Text) || string.IsNullOrEmpty(txt_senha.Text) || (txt_senha.Text != txt_confsenha.Text)))
			{
				string erro = "O campo não pode ser nulo ou vazio";
				errorProvider2.SetError(txt_senha, erro);
				errorProvider3.SetError(txt_confsenha, erro);
			}
			else if ((txt_senha.Text != txt_confsenha.Text))
			{
				string erro = "Senhas não compatíveis";
				errorProvider2.SetError(txt_senha, erro);
				errorProvider3.SetError(txt_confsenha, erro);
			}
			else if(txt_senha.Text.Length < 8)
			{
				string erro = "Senhas devem ter no mínimo 8 caracteres";
				errorProvider2.SetError(txt_senha, erro);
				errorProvider3.SetError(txt_confsenha, erro);
			}
			else
			{
				errorProvider2.Clear();
				errorProvider3.Clear();
			}
		}

		private void Cadastro_Administrador_Load(object sender, EventArgs e)
		{

		}

		private void btn_cancelar_Click(object sender, EventArgs e)
		{
			Perfil_EMP perfil = new Perfil_EMP();
			perfil.Show();
			this.Hide();
		}
	}
}