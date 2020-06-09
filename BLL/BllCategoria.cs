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
    public class BllCategoria
    {

        public DataTable ListarCateg(Categoria dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                DataTable dt = new DataTable();            
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
               
                return dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Categoria");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }

        //Listar SubCategoria
        public DataTable ListarSubCateg(Categoria dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                DataTable dt = new DataTable();
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@CategoriaId", dto.CategoriaId);

                return dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Categoria");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListarTipoFarmaco(TipoFarmaco dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                DataTable dt = new DataTable();
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@SubCategoriaId", dto.SubCategoriaId);

                return dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Categoria");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
        public string Cadastrar(Categoria dto)
        {
            AcessoDados dal = new AcessoDados();

            string retorno;
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@CategoriaId", dto.CategoriaId);
                dal.AdicionarParametro("@NomeCateg", dto.NomeCateg);
                dal.AdicionarParametro("@Estado", dto.Estado);

                return retorno = dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_Categoria").ToString();
                
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable PesquisarPor(Categoria dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                DataTable dt = new DataTable();
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@NomeCateg", dto.NomeCateg);
                dal.AdicionarParametro("@CategoriaId", dto.CategoriaId);


                return dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Categoria");

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
