using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BLL
{
    public class BllFornecedor
    {
        public DataTable Listar(Fornecedor dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                DataTable dt = new DataTable();
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);

                return dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Fornecedor");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public string Cadastrar(Fornecedor dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@NomeFornecedor", dto.NomeFornecedor);
                dal.AdicionarParametro("@Telf", dto.Telf);
                dal.AdicionarParametro("@Email", dto.Email);
                dal.AdicionarParametro("@Endereco", dto.Endereco);

                string retorno = dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_Fornecedor").ToString();

                return retorno;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
