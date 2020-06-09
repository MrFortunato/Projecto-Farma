using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BllVenda
    {

        public string Cadastrar(Venda dto)
        {
            AcessoDados dal = new AcessoDados();

            string retorno;
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@CaixaFunc", dto.CaixaFunc);
                dal.AdicionarParametro("@ValorTotal", dto.ValorTotal);
                dal.AdicionarParametro("@ClienteId", dto.ClienteId);
                dal.AdicionarParametro("@TipoPagamento", dto.TipoPagamento);

                return retorno = dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_Venda").ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string CadastrarPedido(Pedido dto)
        {
            AcessoDados dal = new AcessoDados();
            string retorno;
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@Quantidade", dto.Quantidade);
                dal.AdicionarParametro("@EstoqueId", dto.EstoqueId);
                dal.AdicionarParametro("@PrecoVenda", dto.PrecoVenda); 


                return retorno = dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_Venda").ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string GerarNrVenda(Venda dto)
        {
            AcessoDados dal = new AcessoDados();
            string retorno;
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@CaixaFunc", dto.CaixaFunc);

                return retorno = dal.ExecutarContar(CommandType.StoredProcedure, "Sp_Venda").ToString(); ;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}

