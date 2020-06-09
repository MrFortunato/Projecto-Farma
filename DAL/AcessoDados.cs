using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AcessoDados
    {

        DataTable dt;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;



        //Colecção de parametro para ir a base de dados 
        private SqlParameterCollection ColeccaoParametros = new SqlCommand().Parameters;

        public void LimparParametros()//Método para limpar Parametros
        {
            ColeccaoParametros.Clear();
        }

        public void AdicionarParametro(string NomeParametro, object dadosParametro)
        {
            ColeccaoParametros.Add(new SqlParameter(NomeParametro, dadosParametro));
        }

        //Função para Gravar, Atualizar e Apagar
        public object ExecutarOperacao(CommandType TipodeComando, string NomeStoredProcedure)
        {
            try
            {

                cmd = new SqlCommand();
                con = Conexao.obterConexao();
                cmd = con.CreateCommand();
                cmd.CommandType = TipodeComando;
                cmd.CommandText = NomeStoredProcedure;
                cmd.CommandTimeout = 7200;


                //Percorrer o Colecção de para executar
                foreach (SqlParameter item in ColeccaoParametros)
                {
                    cmd.Parameters.Add(new SqlParameter(item.ParameterName, item.Value));
                }
                // Executar o Comando
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //finally
            //{
            //    cmd.Dispose();
            //    con.Close();
            //}

        }
        // Função Consultar 
        public DataTable ExecutarConsulta(CommandType TipodeComando, string NomeStoredProcedure)
        {
            try
            {

                cmd = new SqlCommand();
                da = new SqlDataAdapter();
                dt = new DataTable();

                con = Conexao.obterConexao();
                cmd = con.CreateCommand();
                cmd.CommandType = TipodeComando;
                cmd.CommandText = NomeStoredProcedure;
                cmd.CommandTimeout = 7200;

                //Percorrer o Colecção de para executar
                foreach (SqlParameter item in ColeccaoParametros)
                {
                    cmd.Parameters.Add(new SqlParameter(item.ParameterName, item.Value));
                }
                // Criar Adaptador

                da.SelectCommand = cmd;
                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            //finally
            //{
            //    cmd.Dispose();
            //    con.Close();

            //}
        }

        public int ExecutarContar(CommandType TipodeComando, string NomeStoredProcedure)
        {
            int Resultado = 0;

            try
            {
                cmd = new SqlCommand();
                SqlConnection con = Conexao.obterConexao();
                cmd = con.CreateCommand();
                cmd.CommandType = TipodeComando;
                cmd.CommandText = NomeStoredProcedure;
                cmd.CommandTimeout = 7200;

                //Percorrer o Colecção de para executar
                foreach (SqlParameter item in ColeccaoParametros)
                {
                    cmd.Parameters.Add(new SqlParameter(item.ParameterName, item.Value));
                }
                // Executar o Comando
                Resultado = (Int32)cmd.ExecuteScalar();

                return (int)Resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

        }
    }
}
