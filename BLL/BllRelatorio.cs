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
    public class BllRelatorio
    {
        public DataTable RelatorioAnual(Relatorio dto)
        {
            try
            {
                AcessoDados dal = new AcessoDados();
                dal.LimparParametros();

                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@Ano", dto.Ano);

                DataTable dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Relatorios");

                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
