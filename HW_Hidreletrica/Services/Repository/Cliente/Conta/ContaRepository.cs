using HW_Hidreletrica.Entidades.Connect_SQL;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Conta;
using HW_Hidreletrica.Entidades.Usuario.Cliente.Conta.Conta_Comercial;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Hidreletrica.Services.Repository.Cliente.Conta
{
	public class ContaRepository : IContaRepository
	{
		string tabela;

        public ContaRepository()
        {
            
        }
        public DataTable getContaMes(int mesReferencia, int codigoResidencia)
		{
			using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
			{
				cn.Open();
				string query = $"select Codigo, MesReferencia as 'Mês Referência kW/h', MesAnterior as 'Mês Anterior kW/h', Consumo, ValorTotal as 'Valor Total', ValorTotalSemImposto as 'Valor Total sem Imposto' ,dtPagamento as 'Data de Pagamento', dtVencimento as 'Data de Vencimento' from Conta where month(dtVencimento) = month(getdate()) - { mesReferencia} and CodResidencia = {codigoResidencia}; ";

				using (SqlDataAdapter da = new SqlDataAdapter(query,cn))
				{
					DataTable dt = new DataTable();
					da.Fill(dt);
					return dt;
				}
			}
		}

		public void Add<T>(T entity) where T : class
		{
			int codTipo;
			if(entity is Contas)
			{
				Contas conta = entity as Contas;
				conta.consumo = conta.CalculaConsumo(conta.mesReferencia, conta.mesAnterior);
				conta.valorTotal = conta.CalculaValorTotal(conta.consumo);
				conta.valorTotalSemImpostos = conta.CalculaValorSemImpostos(conta.consumo);
				if(conta is Conta_Comercial)
				{
					conta.codigoTipo = 1;
				}
				else
				{
					conta.codigoTipo = 2;
				}
				using (SqlConnection cn = new SqlConnection(Connect_Server.Connect()))
				{
					cn.Open();
					string query = $"insert into Conta (MesReferencia,MesAnterior,Consumo,ValorTotal,ValorTotalSemImposto,CodTipo,dtPagamento,dtVencimento,CodResidencia,CodPessoa) values " +
						           $"(@MesReferencia,@MesAnterior,@Consumo,@ValorTotal,@ValorTotalSemImposto,@Codtipo,@dtPagamento,@dtVencimento,@CodResidencia,@CodPessoa);";
					//adicionar os paramatros aqui por @
					using (SqlCommand cmd = new SqlCommand(query,cn))
					{
						cmd.Parameters.AddWithValue("@MesReferencia", conta.mesReferencia);
						cmd.Parameters.AddWithValue("@MesAnterior", conta.mesAnterior);
						cmd.Parameters.AddWithValue("@Consumo", conta.consumo);
						cmd.Parameters.AddWithValue("@ValorTotal", conta.valorTotal);
						cmd.Parameters.AddWithValue("@ValorTotalSemImposto", conta.valorTotalSemImpostos);
						cmd.Parameters.AddWithValue("@Codtipo", conta.codigoTipo);
						cmd.Parameters.AddWithValue("@dtPagamento", conta.dtPagamento);
						cmd.Parameters.AddWithValue("@dtVencimento", conta.dtVencimento);
						cmd.Parameters.AddWithValue("@CodResidencia", conta.residencia.codigo);
						cmd.Parameters.AddWithValue("@CodPessoa", conta.cliente.getCodigo());
						cmd.ExecuteNonQuery();
						//os parametros virao do objeto
					}
				}
			}
		}

		void IRepository.Delete<T>(T entity)
		{
			throw new NotImplementedException();
		}

		bool IRepository.SaveChanges()
		{
			throw new NotImplementedException();
		}

		void IRepository.Update<T>(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
