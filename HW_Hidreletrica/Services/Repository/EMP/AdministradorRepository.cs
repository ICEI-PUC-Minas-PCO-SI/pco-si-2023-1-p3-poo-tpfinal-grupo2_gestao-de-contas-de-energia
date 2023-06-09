﻿using HW_Hidreletrica.Entidades.Connect_SQL;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Conta;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Conta.Conta_Comercial;
using HW_Hidreletrica.Entidades.Usuario.EMP;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Services.Repository.EMP
{
	public class AdministradorRepository : IAdministradorRepository
	{
		string tabela;

        public AdministradorRepository()
        {
            
        }
        public DataTable getAdminitrador(string emailUsuario, string senhaUsuario)
		{
			using (SqlConnection conexao = new SqlConnection(Connect_Server.Connect()))
			{
				conexao.Open();
				string query = $"select nome,email,CodAdministrador from Administrador where Email = '{emailUsuario}' and Senha = '{senhaUsuario}'";

				using (SqlDataAdapter dados = new SqlDataAdapter(query, conexao))
				{
					DataTable datatable = new DataTable();
					dados.Fill(datatable);
					return datatable;
				}
			}
		}

		public DataTable getInformacoesAdministrador(int codigoAdm) {
			using (SqlConnection conexao = new SqlConnection(Connect_Server.Connect())) {
				conexao.Open();
				string query = $"select * from Administrador where CodAdministrador = '{codigoAdm}'";

				using (SqlDataAdapter dados = new SqlDataAdapter(query, conexao)) {
					DataTable datatable = new DataTable();
					dados.Fill(datatable);
					return datatable;
				}
			}
		}
		public DataTable getAllClientes()
		{
			using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
			{
				cn.Open();

				string query = "select P.Codigo as 'Identificador', Nome, Email, Telefone,DtNascimento as 'Data de Nascimento', T.Descricao as 'Descrição',CPF, CNPJ,R.NumInstalacao as 'Número da Instalação', R.Descricao ,E.Cidade,E.Estado,\r\nC.MesReferencia as 'Mês Referência kW/h', C.MesAnterior as 'Mês Anterior kW/h', C.Consumo as 'Consumo em kW/h' , C.ValorTotal as 'Valor Total em R$', TC.Descricao as 'Tipo da Conta'\r\nfrom" +
					" Pessoa P, TipoPessoa T, Residencia R, Endereco E, Conta C, TipoConta TC\r\nwhere P.CodTipo = T.Codigo\r\nand E.Codigo = R.CodEndereco\r\nand R.CodPessoa = P.Codigo\r\nand C.CodPessoa = P.Codigo\r\nand C.CodResidencia = R.Codigo\r\nand C.CodTipo = TC.Codigo\r\n\r\n";
				using (SqlDataAdapter ad = new SqlDataAdapter(query, cn))
				{
					DataTable dt = new DataTable();
					ad.Fill(dt);
					return dt;
				}
			}
		}

		public DataTable getClienteByCpf(string cpf)
		{

			using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
			{
				cn.Open();

				string query = $"select P.Codigo as 'Identificador' ,Nome, Email, Telefone,DtNascimento as 'Data de Nascimento', T.Descricao as 'Descrição',CPF, CNPJ,R.NumInstalacao as 'Número da Instalação', R.Descricao ,E.Cidade,E.Estado,\r\nC.MesReferencia as 'Mês Referência kW/h', C.MesAnterior as 'Mês Anterior kW/h', C.Consumo as 'Consumo em kW/h', C.ValorTotal as 'Valor Total em R$', TC.Descricao as 'Tipo da Conta'\r\nfrom " +
					$"Pessoa P, TipoPessoa T, Residencia R, Endereco E, Conta C, TipoConta TC\r\nwhere P.CodTipo = T.Codigo\r\nand E.Codigo = R.CodEndereco\r\nand R.CodPessoa = P.Codigo\r\nand C.CodPessoa = P.Codigo\r\nand C.CodResidencia = R.Codigo\r\nand C.CodTipo = TC.Codigo\r\nand P.CPF = '{cpf}'";
				using (SqlDataAdapter ad = new SqlDataAdapter(query, cn))
				{
					DataTable dt = new DataTable();
					ad.Fill(dt);
					return dt;
				}
			}
			
			
		}

		public DataTable getClienteByCnpj(string cnpj)
		{
			using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
			{
				cn.Open();

				string query = $"select P.Codigo as 'Identificador' ,Nome, Email, Telefone,DtNascimento as 'Data de Nascimento', T.Descricao as 'Descrição',CPF, CNPJ,R.NumInstalacao as 'Número da Instalação', R.Descricao ,E.Cidade,E.Estado,\r\nC.MesReferencia as 'Mês Referência kW/h', C.MesAnterior as 'Mês Anterior kW/h', C.Consumo as 'Consumo em kW/h', C.ValorTotal as 'Valor Total em R$', TC.Descricao as 'Tipo da Conta'\r\nfrom " +
					$"Pessoa P, TipoPessoa T, Residencia R, Endereco E, Conta C, TipoConta TC\r\nwhere P.CodTipo = T.Codigo\r\nand E.Codigo = R.CodEndereco\r\nand R.CodPessoa = P.Codigo\r\nand C.CodPessoa = P.Codigo\r\nand C.CodResidencia = R.Codigo\r\nand C.CodTipo = TC.Codigo\r\nand P.CNPJ = '{cnpj}'";
				using (SqlDataAdapter ad = new SqlDataAdapter(query, cn))
				{
					DataTable dt = new DataTable();
					ad.Fill(dt);
					return dt;
				}
			}
		}

		public DataTable getClienteByCIdentificador(string identificador)
		{
			using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
			{
				cn.Open();

				string query = $"select P.Codigo as 'Identificador' ,Nome, Email, Telefone,DtNascimento as 'Data de Nascimento', T.Descricao as 'Descrição',CPF, CNPJ,R.NumInstalacao as 'Número da Instalação', R.Descricao ,E.Cidade,E.Estado,\r\nC.MesReferencia as 'Mês Referência kW/h', C.MesAnterior as 'Mês Anterior kW/h', C.Consumo as 'Consumo em kW/h', C.ValorTotal as 'Valor Total em R$', TC.Descricao as 'Tipo da Conta'\r\nfrom" +
					$" Pessoa P, TipoPessoa T, Residencia R, Endereco E, Conta C, TipoConta TC\r\nwhere P.CodTipo = T.Codigo\r\nand E.Codigo = R.CodEndereco\r\nand R.CodPessoa = P.Codigo\r\nand C.CodPessoa = P.Codigo\r\nand C.CodResidencia = R.Codigo\r\nand C.CodTipo = TC.Codigo\r\nand P.Codigo = {identificador}";
				using (SqlDataAdapter ad = new SqlDataAdapter(query, cn))
				{
					DataTable dt = new DataTable();
					ad.Fill(dt);
					return dt;
				}
			}
		}

		public DataTable getClienteByConsumo(double consumo)
		{
			using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
			{
				cn.Open();

				string query = $"select P.Codigo as 'Identificador' ,Nome, Email, Telefone,DtNascimento as 'Data de Nascimento', T.Descricao as 'Descrição',CPF, CNPJ,R.NumInstalacao as 'Número da Instalação', R.Descricao ,E.Cidade,E.Estado,\r\nC.MesReferencia as 'Mês Referência kW/h', C.MesAnterior as 'Mês Anterior kW/h', C.Consumo as 'Consumo em kW/h', C.ValorTotal as 'Valor Total em R$', TC.Descricao as 'Tipo da Conta'\r\nfrom" +
					$" Pessoa P, TipoPessoa T, Residencia R, Endereco E, Conta C, TipoConta TC\r\nwhere P.CodTipo = T.Codigo\r\nand E.Codigo = R.CodEndereco\r\nand R.CodPessoa = P.Codigo\r\nand C.CodPessoa = P.Codigo\r\nand C.CodResidencia = R.Codigo\r\nand C.CodTipo = TC.Codigo\r\nand C.Consumo > {consumo}";
				using (SqlDataAdapter ad = new SqlDataAdapter(query, cn))
				{
					DataTable dt = new DataTable();
					ad.Fill(dt);
					return dt;
				}
			}
		}
		public DataTable getClienteByContaAtraso()
		{
			using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
			{
				cn.Open();

				string query = $"select P.Codigo as 'Identificador' ,Nome, Email, Telefone,DtNascimento as 'Data de Nascimento', T.Descricao  as 'Descrição',CPF, CNPJ,R.NumInstalacao as 'Número da Instalação', R.Descricao ,E.Cidade,E.Estado,\r\nC.MesReferencia as 'Mês Referência kW/h', C.MesAnterior as 'Mês Anterior kW/h', Consumo as 'Consumo em kW/h', C.ValorTotal as 'Valor Total em R$', TC.Descricao as 'Tipo da Conta'\r\nfrom" +
					$" Pessoa P, TipoPessoa T, Residencia R, Endereco E, Conta C, TipoConta TC\r\nwhere P.CodTipo = T.Codigo\r\nand E.Codigo = R.CodEndereco\r\nand R.CodPessoa = P.Codigo\r\nand C.CodPessoa = P.Codigo\r\nand C.CodResidencia = R.Codigo\r\nand C.CodTipo = TC.Codigo\r\n and C.dtVencimento < getdate()\r\nand year(dtPagamento) = 1754";
				using (SqlDataAdapter ad = new SqlDataAdapter(query, cn))
				{
					DataTable dt = new DataTable();
					ad.Fill(dt);
					return dt;
				}
			}
		}

		public string getIdAdministrador()
		{
			using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
			{
				cn.Open();

				string query = "select MAX(CodAdministrador) as Codigo from Administrador";
				using (SqlDataAdapter ad = new SqlDataAdapter(query, cn))
				{
					DataTable dt = new DataTable();
					ad.Fill(dt);

					int result = int.Parse(dt.Rows[0]["Codigo"].ToString() + 1);

					return (result.ToString());
				}

			}
		}
		public bool getAdministradorByEmail(string email)
		{
			using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
			{
				cn.Open();
				string sql = $"select Email from Administrador where Email = '{email}'";

				using (SqlDataAdapter da = new SqlDataAdapter(sql, cn))
				{
					DataTable dt = new DataTable();
					da.Fill(dt);

					if (dt.Rows.Count > 0)
						return true;
					return false;
				}
			}
		}

		public void Add<T>(T entity) where T : class
		{
			string query;

			if (entity is Administradores)
			{
				Administradores administrador = entity as Administradores;
				query = "insert into Administrador(Nome, Email, senha) values " +
				$"(@Nome,@Email,@Senha);";

				using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
				{
					cn.Open();

					using (SqlCommand cmd = new SqlCommand(query, cn))
					{
						cmd.Parameters.AddWithValue("@Nome", administrador.getNome());
						cmd.Parameters.AddWithValue("@Email", administrador.getEmail());
						cmd.Parameters.AddWithValue("@Senha", administrador.getSenha());
						cmd.ExecuteNonQuery();
						//os parametros virao do objeto
					}
				}
			}
		}

	}
}
