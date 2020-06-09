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
    public class BllCategSubCategoria
    {
        public string Cadastrar(Categ_SubCateg dto)
        {
            AcessoDados dal = new AcessoDados();

            string retorno;

            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@CategSubId", dto.CategSubId);
                dal.AdicionarParametro("@SubCategoriaId", dto.SubCategoriaId);
                dal.AdicionarParametro("@CategoriaId", dto.CategoriaId);
                dal.AdicionarParametro("@Estado", dto.Estado);

                return retorno = dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_Categ_SubCategoria").ToString();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //Listar Categ_SubCategoria
        public DataTable Listar(Categ_SubCateg dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                DataTable dt = new DataTable();
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);

                return dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Categ_SubCategoria");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public DataTable Carregar(Categ_SubCateg dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                DataTable dt = new DataTable();
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@CategoriaId", dto.CategoriaId);

                return dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Categ_SubCategoria");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
