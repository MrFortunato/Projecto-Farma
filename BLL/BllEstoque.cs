using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;

namespace BLL
{
    public class BllEstoque
    {
        public DataTable Listar(Estoque dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);


                DataTable dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Estoque");

                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string Cadastrar(Estoque dto)
        {
            AcessoDados dal = new AcessoDados();

            string retorno;

            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@ProdutoId", dto.ProdutoId);
                dal.AdicionarParametro("@Descricao", dto.Descricao);
                dal.AdicionarParametro("@Quantidade", dto.Quantidade);
                dal.AdicionarParametro("@PrecoVenda", dto.PrecoVenda);
                dal.AdicionarParametro("@PrecoCompra", dto.PrecoCompra);
                dal.AdicionarParametro("@DataFabrico", dto.DataFabrico);
                dal.AdicionarParametro("@DataExp", dto.DataExp);
                dal.AdicionarParametro("@FuncionarioId", dto.FuncionarioId);
                dal.AdicionarParametro("@Estado", dto.Estado);
                dal.AdicionarParametro("@EstoqueId", dto.EstoqueId);
                dal.AdicionarParametro("@Lote", dto.Lote);

                return retorno = dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_Estoque").ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public string Editar(Estoque dto)
        {
            AcessoDados dal = new AcessoDados();

            string retorno;

            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                //dal.AdicionarParametro("@ProdutoId", dto.ProdutoId);
                dal.AdicionarParametro("@Descricao", dto.Descricao);
                dal.AdicionarParametro("@Quantidade", dto.Quantidade);
                dal.AdicionarParametro("@PrecoVenda", dto.PrecoVenda);
                dal.AdicionarParametro("@PrecoCompra", dto.PrecoCompra);
                dal.AdicionarParametro("@DataFabrico", dto.DataFabrico);
                dal.AdicionarParametro("@DataExp", dto.DataExp);
                dal.AdicionarParametro("@FuncionarioId", dto.FuncionarioId);
                dal.AdicionarParametro("@Estado", dto.Estado);
                dal.AdicionarParametro("@EstoqueId", dto.EstoqueId);
                dal.AdicionarParametro("@Lote", dto.Lote);

                return retorno = dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_Estoque").ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        // Método para Atualizar e Cadastar Estoque Reservado
        public string Atualizar(Estoque dto)
        {
            AcessoDados dal = new AcessoDados();

            string retorno;

            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);         
                dal.AdicionarParametro("@Quantidade", dto.Quantidade);
                dal.AdicionarParametro("@FuncionarioId", dto.FuncionarioId);
                dal.AdicionarParametro("@EstoqueId", dto.EstoqueId);


                return retorno = dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_Estoque").ToString();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Pesquisar(Estoque dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@ProdutoId", dto.ProdutoId);
                dal.AdicionarParametro("@NomeCateg", dto.NomeCateg);
                dal.AdicionarParametro("@PrecoVenda", dto.PrecoVenda);
                dal.AdicionarParametro("@Lote", dto.Lote);
                dal.AdicionarParametro("@NomeProduto", dto.NomeProduto);
                dal.AdicionarParametro("@NomeTipoFarmaco", dto.NomeTipoFarmaco);


                DataTable dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Estoque");

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
