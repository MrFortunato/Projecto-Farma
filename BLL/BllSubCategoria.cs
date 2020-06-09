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
    public class BllSubCategoria
    {
        public string Cadastrar(SubCategoria dto)
        {
            AcessoDados dal = new AcessoDados();

            string retorno;
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@SubCategoriaId", dto.SubCategoriaId);
                dal.AdicionarParametro("@NomeSubCateg", dto.NomeSubCateg);
                dal.AdicionarParametro("@Estado", dto.Estado);

                return retorno = dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_SubCategoria").ToString();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Listar(SubCategoria dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                DataTable dt = new DataTable();
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@SubCategoriaId", dto.SubCategoriaId);

                return dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_SubCategoria");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        public DataTable Carregar(SubCategoria dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                DataTable dt = new DataTable();
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);              

                return dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_SubCategoria");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }



    }
}
