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
    public class BllProduto
    {
        public string Cadastrar(Produto dto)
        {
           
            string retorno;

            try
            {
                AcessoDados dal = new AcessoDados();
                dal.LimparParametros();
                //-----------------Produto-------------------///////////////
                dal.AdicionarParametro("@Operacao",dto.Operacao);
                dal.AdicionarParametro("@ProdutoId", dto.ProdutoId);
                dal.AdicionarParametro("@NomeProduto", dto.NomeProduto);
                dal.AdicionarParametro("@Descricao", dto.Descricao);
                dal.AdicionarParametro("@Medida ", dto.Medida);
                dal.AdicionarParametro("@PaisOrigem", dto.PaisOrigem);
                dal.AdicionarParametro("@TipoFarmacoId", dto.@TipoFarmacoId);
                dal.AdicionarParametro("@CategoriaId", dto.CategoriaId);
                dal.AdicionarParametro("@UrlImg", dto.UrlImg);

       

                //--------------Estoque--------------------////////////////////

                //dal.AdicionarParametro("@Quantidade", dto.@Quantidade);
                ////dal.AdicionarParametro("@DataFabrico", dto.DataFabrico);
                ////dal.AdicionarParametro("@DataExp", dto.DataExp);
                //dal.AdicionarParametro("@FuncionarioId ", dto.FuncionarioId);
                //dal.AdicionarParametro("@Lote", dto.Lote);
                //dal.AdicionarParametro("@PrecoCompra ", dto.PrecoCompra);
                //dal.AdicionarParametro("@PrecoVenda", dto.PrecoVenda);

                return retorno = dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_Produto").ToString();
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

           
        }

        public DataTable Listar(Produto dto)
        {
            try
            {
                AcessoDados dal = new AcessoDados();
                dal.LimparParametros();

                dal.AdicionarParametro("@Operacao", dto.Operacao);

                DataTable dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Produto");

                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public DataTable CarregarPais(Produto dto)
        {
            try
            {
                AcessoDados dal = new AcessoDados();
                dal.LimparParametros();

                dal.AdicionarParametro("@Operacao", dto.Operacao);

                DataTable dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Produto");

                return dt;

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


    }
}
