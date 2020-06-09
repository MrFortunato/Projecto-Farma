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
    public class BllCaixa
    {

        public DataTable Listar(Caixa dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                DataTable dt = new DataTable();
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);

                return dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Caixa");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable AbrirCaixa(Funcionario dto)
        {
            AcessoDados dal = new AcessoDados();
            DataTable dt = new DataTable(); ;
     
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@CaixaId", dto.CaixaId);
                dal.AdicionarParametro("@SaldoInicial", dto.SaldoInicial);
                dal.AdicionarParametro("@FuncionarioId", dto.FuncionarioId);

                return dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Caixa");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string FecharCaixa(Funcionario dto)
        {
            AcessoDados dal = new AcessoDados();
            string retorno;
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@CaixaId", dto.CaixaId);
                dal.AdicionarParametro("@FuncionarioId", dto.FuncionarioId);
                dal.AdicionarParametro("@CaixaFunc", dto.CaixaFunc);



                return retorno = dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_Caixa").ToString();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
