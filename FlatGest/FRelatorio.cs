using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using System.Globalization;

namespace FlatGest
{
    public partial class FRelatorio : Form
    {
        private string _IdGlobal;
        private string _NomeGlobal;
        private string _CargoGlobal;
        private string _SenhaGlobal;
        public string IdGlobal
        {
            get { return _IdGlobal; }
            set { _IdGlobal = value; }
        }
        public string NomeGlobal
        {
            get { return _NomeGlobal; }
            set { _NomeGlobal = value; }
        }
        public string CargoGlobal
        {
            get { return _CargoGlobal; }
            set { _CargoGlobal = value; }
        }
        public string SenhaGlobal
        {
            get { return _SenhaGlobal; }
            set { _SenhaGlobal = value; }
        }
        public FRelatorio(string Nome, string Id, string Cargo, AcaoNaTela acaoNaTela)
        {
            InitializeComponent();
            _IdGlobal = Id;
            _NomeGlobal = Nome;
            _CargoGlobal = Cargo;
           
            lblNome.Text = _NomeGlobal + " | "+ _CargoGlobal;            

            DataInicio.Value = DateTime.Now.AddYears(-1);
            ListarFuncionario();

            if (acaoNaTela == AcaoNaTela.Gerente)
            {
                pnCbF.Visible = true;
                
            }
            else
            {
                pnCbF.Visible = false;
            }
        }

        //Exibir Relatorio
        private void PesquisarPor()
        {
            BllFuncionario bll = new BllFuncionario();
            Relatorio dto = new Relatorio();

            dto.Operacao = "Relatorio";
            dto.FuncionarioId = Convert.ToInt32(cbFuncionario.SelectedValue);
            dto.DataInicio = DataInicio.Value;
            dto.DataFim = DataFim.Value.AddDays(1);

            try
            {
                DataTable dt = bll.Relatorio(dto);

                if(dt.Rows.Count!= 0)
                {
                    lblV.Text = dt.Rows[0]["TotalVenda"].ToString();
                    lblC.Text = dt.Rows[0]["TotalCartao"].ToString();
                    lblR.Text = dt.Rows[0]["TotalRetorna"].ToString();
                    lblP.Text = dt.Rows[0]["TotalPrazo"].ToString();
                    lblD.Text = dt.Rows[0]["TotalReceber"].ToString();
                    lblH.Text = dt.Rows[0]["TotalHoras"].ToString();

                    lblC.Text = Convert.ToDecimal(lblC.Text).ToString("C2");
                    lblP.Text = Convert.ToDecimal(lblP.Text).ToString("C2");
                    lblD.Text = Convert.ToDecimal(lblD.Text).ToString("C2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Pesquisar()
        {
            BllFuncionario bll = new BllFuncionario();
            Relatorio dto = new Relatorio();

            dto.Operacao = "Relatorio";
            dto.FuncionarioId = Convert.ToInt32(_IdGlobal);
            dto.DataInicio = DataInicio.Value;
            dto.DataFim = DataFim.Value.AddDays(1);

            try
            {
                DataTable dt = bll.Relatorio(dto);

                if (dt.Rows.Count != 0)
                {
                    lblV.Text = dt.Rows[0]["TotalVenda"].ToString();
                    lblC.Text = dt.Rows[0]["TotalCartao"].ToString();
                    lblR.Text = dt.Rows[0]["TotalRetorna"].ToString();
                    lblP.Text = dt.Rows[0]["TotalPrazo"].ToString();
                    lblD.Text = dt.Rows[0]["TotalReceber"].ToString();
                    lblH.Text = dt.Rows[0]["TotalHoras"].ToString();

                    lblC.Text = Convert.ToDecimal(lblC.Text).ToString("C2");
                    lblP.Text = Convert.ToDecimal(lblP.Text).ToString("C2");
                    lblD.Text = Convert.ToDecimal(lblD.Text).ToString("C2");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Listar Funcionario
        private void ListarFuncionario()
        {
            Funcionario dto = new Funcionario();
            BllFuncionario bll = new BllFuncionario();

            dto.Operacao = "ListarFuncionario";
            try
            {
                DataTable dt = bll.ListarFuncionarios(dto);
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "-- Selecionar --";
                dt.Rows.InsertAt(topItem, 0);
                Cbguna.DataSource = dt;

                //cbFuncionario.DataSource = dt;

                Cbguna.DisplayMember = "NomeCompleto";
                Cbguna.ValueMember = "FuncionarioId";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FRelatorio_Load(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void DataFim_ValueChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void DataInicio_ValueChanged(object sender, EventArgs e)
        {
            Pesquisar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbFuncionario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            PesquisarPor();
        }

      
    }
}
