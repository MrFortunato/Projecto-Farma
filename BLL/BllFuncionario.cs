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
    public class BllFuncionario
    {
        public DataTable Logar(Funcionario dto)
        {
            AcessoDados dal = new AcessoDados();


            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@Username", dto.NomeUsuario);
                dal.AdicionarParametro("@Senha", dto.Senha);
                dal.AdicionarParametro("@CaixaId", dto.CaixaId);
                dal.AdicionarParametro("@SaldoInicial", dto.SaldoInicial);


                DataTable dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Funcionario");

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable Relatorio(Relatorio dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@DataInicio", dto.DataInicio);
                dal.AdicionarParametro("@DataFim", dto.DataFim);
                dal.AdicionarParametro("@FuncionarioId", dto.FuncionarioId);


                DataTable dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Relatorios");

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable DetalhesContacto(Funcionario dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@FuncionarioId", dto.FuncionarioId);


                DataTable dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Funcionario");

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public DataTable ListarFuncionarios(Funcionario dto)
        {
            AcessoDados dal = new AcessoDados();

            try
            {
                dal.LimparParametros();
                dal.AdicionarParametro("@Operacao", dto.Operacao);

                DataTable dt = dal.ExecutarConsulta(CommandType.StoredProcedure, "Sp_Funcionario");

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Cadastrar(Funcionario dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                dal.LimparParametros();
                
                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@NomeUsuario", dto.NomeUsuario);
                dal.AdicionarParametro("@Senha", dto.Senha);
                dal.AdicionarParametro("@Cargo", dto.CargoId);
                dal.AdicionarParametro("@Estado", dto.Estado);

                dal.AdicionarParametro("@NomeCompleto", dto.NomeCompleto);
     
                dal.AdicionarParametro("@Telf", dto.Telf);
                dal.AdicionarParametro("@Endereco", dto.Endereco);
                dal.AdicionarParametro("@Email", dto.Email);

                string retorno = dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_Funcionario").ToString();

                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public string Editar(Funcionario dto)
        {
            AcessoDados dal = new AcessoDados();
            try
            {
                dal.LimparParametros();

                dal.AdicionarParametro("@Operacao", dto.Operacao);
                dal.AdicionarParametro("@FuncionarioId", dto.FuncionarioId);
                dal.AdicionarParametro("@NomeUsuario", dto.NomeUsuario);
                dal.AdicionarParametro("@Senha", dto.Senha);
                dal.AdicionarParametro("@Cargo", dto.CargoId);
                dal.AdicionarParametro("@Estado", dto.Estado);

                dal.AdicionarParametro("@NomeCompleto", dto.NomeCompleto);

                dal.AdicionarParametro("@Telf", dto.Telf);
                dal.AdicionarParametro("@Endereco", dto.Endereco);
                dal.AdicionarParametro("@Email", dto.Email);

                string retorno = dal.ExecutarOperacao(CommandType.StoredProcedure, "Sp_Funcionario").ToString();

                return retorno;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
