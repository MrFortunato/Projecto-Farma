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

namespace FlatGest
{
    public partial class FFluxoCaixa : Form
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
        public FFluxoCaixa(string Nome, string Cargo,string Id)
        {
            InitializeComponent();
            _IdGlobal = Id;
            _NomeGlobal = Nome;
            _CargoGlobal = Cargo;
            lblNome.Text = _NomeGlobal + " | " + Cargo;
         
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        //Método para Listar Ano
        private void CarregarAno()
        {
            try
            {
                //clear all data from combobox
                cbAno.Items.Clear();
                //add default item
                //cbAno.Items.Add("-- Ano -- ");
                //loop array for add items
                for (int i = 2015; i < DateTime.Now.Year + 1 ; i++)
                {
                    cbAno.Items.Add(i);
                }
                //set selected item for display on startup
                cbAno.Text = DateTime.Now.Year.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        // Método para Relatório
        private void CarregarRelatorio()
        {
            BllRelatorio bll = new BllRelatorio();
            Relatorio dto = new Relatorio();
            dto.Operacao = "RelatorioAnual";
            dto.Ano = cbAno.Text;
            try
            {
                DataTable dt = bll.RelatorioAnual(dto);

                if (dt.Rows.Count != 0)
                {
                    custoJan.Text = Convert.ToDecimal(dt.Rows[0]["CustoJan"]).ToString("C");
                    custoFev.Text = Convert.ToDecimal(dt.Rows[0]["CustoFev"]).ToString("C");
                    custoMar.Text = Convert.ToDecimal(dt.Rows[0]["CustoMar"]).ToString("C");
                    custoAbri.Text = Convert.ToDecimal(dt.Rows[0]["CustoAbri"]).ToString("C");
                    custoMaio.Text = Convert.ToDecimal(dt.Rows[0]["CustoMaio"]).ToString("C");
                    custoJun.Text = Convert.ToDecimal(dt.Rows[0]["CustoJun"]).ToString("C");
                    custoJul.Text = Convert.ToDecimal(dt.Rows[0]["CustoJul"]).ToString("C");
                    custoAgo.Text = Convert.ToDecimal(dt.Rows[0]["CustoAgo"]).ToString("C");
                    custoSet.Text = Convert.ToDecimal(dt.Rows[0]["CustoSet"]).ToString("C");
                    custoOut.Text = Convert.ToDecimal(dt.Rows[0]["CustoOut"]).ToString("C");
                    custoNov.Text = Convert.ToDecimal(dt.Rows[0]["CustoNov"]).ToString("C");
                    custoDez.Text = Convert.ToDecimal(dt.Rows[0]["CustoDez"]).ToString("C");

                    lucroJan.Text = Convert.ToDecimal(dt.Rows[0]["LucroJan"]).ToString("C");
                    lucroFev.Text = Convert.ToDecimal(dt.Rows[0]["LucroFev"]).ToString("C");
                    lucroMar.Text = Convert.ToDecimal(dt.Rows[0]["LucroMar"]).ToString("C");
                    lucroAbri.Text = Convert.ToDecimal(dt.Rows[0]["LucroAbri"]).ToString("C");
                    lucroMaio.Text = Convert.ToDecimal(dt.Rows[0]["LucroMaio"]).ToString("C");
                    lucroJun.Text = Convert.ToDecimal(dt.Rows[0]["LucroJun"]).ToString("C");
                    lucroJul.Text = Convert.ToDecimal(dt.Rows[0]["LucroJul"]).ToString("C");
                    lucroAgo.Text = Convert.ToDecimal(dt.Rows[0]["LucroAgo"]).ToString("C");
                    label17.Text = Convert.ToDecimal(dt.Rows[0]["CustoAgo"]).ToString("C");
                    lucroSet.Text = Convert.ToDecimal(dt.Rows[0]["LucroSet"]).ToString("C");
                    LucroOut.Text = Convert.ToDecimal(dt.Rows[0]["LucroOut"]).ToString("C");
                    LucroNov.Text = Convert.ToDecimal(dt.Rows[0]["LucroNov"]).ToString("C");
                    lucroDez.Text = Convert.ToDecimal(dt.Rows[0]["LucroDez"]).ToString("C");

                    custoTotal.Text = Convert.ToDecimal(dt.Rows[0]["TOTALCUSTO"]).ToString("C");
                    lucroTotal.Text = Convert.ToDecimal(dt.Rows[0]["TOTALLUCRO"]).ToString("C");

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FFluxoCaixa_Load(object sender, EventArgs e)
        {
            CarregarAno();
            CarregarRelatorio();
        }

        private void cbAno_TextChanged(object sender, EventArgs e)
        {
            CarregarRelatorio();
        }
    }
}
