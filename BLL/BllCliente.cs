using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    public class BllCliente
    {
        public DataTable ListarCliente(Cliente dto)
        {
            AcessoDados dal = new AcessoDados();
            
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);

                DataTable dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Cliente");

                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        // Método procurar por Código
        public DataTable ListarPorCodigo(Cliente dto)
        {
            AcessoDados dal = new AcessoDados();

            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@ClienteId", dto.ClienteId);

                DataTable dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Cliente");

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Cadastrar(Cliente dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@NomeCompleto", dto.NomeCompleto);
                dal.AdicionarParametro("@Telf", dto.Telf);
                dal.AdicionarParametro("@Email", dto.Email);
                dal.AdicionarParametro("@Endereco", dto.Endereco);
                dal.AdicionarParametro("@Estado", dto.Estado);

                string retorno = dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_Cliente").ToString();

                return retorno;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public string Editar(Cliente dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@ClienteId", dto.ClienteId);
                dal.AdicionarParametro("@NomeCompleto", dto.NomeCompleto);
                dal.AdicionarParametro("@Telf", dto.Telf);
                dal.AdicionarParametro("@Email", dto.Email);
                dal.AdicionarParametro("@Endereco", dto.Endereco);
                dal.AdicionarParametro("@Estado", dto.Estado);

                string retorno = dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_Cliente").ToString();

                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
