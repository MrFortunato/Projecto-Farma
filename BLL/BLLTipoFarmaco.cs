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
    public class BllTipoFarmaco
    {
        public DataTable Listar(TipoFarmaco dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);

                DataTable dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_TipoFarmaco");

                return dt;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string Cadastrar(TipoFarmaco dto)
        {
            string retorno;
            AcessoDados dal = new AcessoDados();
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@TipoFarmacoId", dto.TipoFarmacoId);
                dal.AdicionarParametro("@NomeTipoFarmaco", dto.NomeTipoFarmaco);
                dal.AdicionarParametro("@SubCategoriaId", dto.SubCategoriaId);

               return retorno =  dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_TipoFarmaco").ToString();

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
