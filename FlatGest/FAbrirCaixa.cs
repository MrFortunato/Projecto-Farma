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
    public partial class FAbrirCaixa : Form
    {
        bool Logado = false;
  
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
        public FAbrirCaixa()
        {
            InitializeComponent();
            //FormFade.ShowAsyc(this); Exibir o Form com lentidão
        }
        private void FAbrirCaixa_Load(object sender, EventArgs e)
        {
            CarregarcbCaixa();
            txtSaldo.Text = (Convert.ToDouble(txtSaldo.Text) / 100).ToString("0.00");
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                txtSenha.Text = "Senha";
                picSenha.Visible = true;
            }
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                txtSenha.Text = "";
                picSenha.Visible = false;
                txtSenha.ForeColor = Color.LightGray;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (Logado == false)
            {
                if(cbCaixa.SelectedIndex != 0)
                {
                    AbrirCaixa();
                }
                else
                {
                    errorP.SetError(cbCaixa, "!");
                    FNotificao.AlerForm("Selecionar o Caixa", TipoNotificacao.aviso);
                }
                
            }
            else
            {
                FVenda f = FVenda.getInstancia(null);
                f.Show();
            }

        }
        
        //Método para Logar
        private void AbrirCaixa()
        {
          
            if (txtSaldo.Text == string.Empty)
            {
                errorP.SetError(txtSaldo, "Campo Obrigatório");
            }       
            else if (txtSenha.Text==string.Empty)
            {
                errorP.SetError(txtSenha, "Campo Obrigatório");
            }
            else if (_SenhaGlobal != txtSenha.Text)
            {
                errorP.SetError(txtSenha, "Senha Errada");
            }
            else
            {
                BllCaixa bll = new BllCaixa();
                Funcionario dto = new Funcionario();
                dto.Operacao = "AbrirCaixa";
                dto.CaixaId = Convert.ToInt32(cbCaixa.SelectedValue);
                dto.SaldoInicial = Convert.ToDecimal(txtSaldo.Text);
                dto.FuncionarioId = Convert.ToInt32(_IdGlobal);

                DataTable dt = bll.AbrirCaixa(dto);

                try
                {
                    if (dt.Rows.Count != 0)
                    {

                            FNotificao.AlerForm("Caixa Nº " + dto.CaixaId.ToString() + " Aberta Com Sucesso", TipoNotificacao.sucesso);                                  
                            dto = new Funcionario();
                            dto.FuncionarioId = Convert.ToInt32(_IdGlobal);
                            dto.Cargo = _CargoGlobal;
                            dto.NomeCompleto = _NomeGlobal;
                            dto.CaixaId = Convert.ToInt32(cbCaixa.SelectedValue);
                            dto.CaixaFunc = Convert.ToInt32(dt.Rows[0]["CaixaFuncionarioId"]);
                            dto.Abertura = dt.Rows[0]["Abertura"].ToString();
                            this.Hide();
                            Estoque es = new Estoque();
                            FVenda f = FVenda.getInstancia(dto);
                            f.ShowDialog();
                            
                    }
                    else
                    {
                        FNotificao.AlerForm("Erro Detalhes: " /*+ dt.Rows[0]["Retorno"].ToString()*/, TipoNotificacao.erro);
                    }

                }
                catch
                {
                    //FNotificao.AlerForm("Erro Detalhes: " /*+ dt.Rows[0]["Retorno"].ToString()*/, TipoNotificacao.erro);
                }
            }
           
        }
        //Método Para Carrgar Combo Caixa
        private void CarregarcbCaixa()
        {
            Caixa dto = new Caixa();
            BllCaixa bll = new BllCaixa();
            dto.Operacao = "Listar";
            try
            {
                DataTable dt = bll.Listar(dto);
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "-- Selecionar Caixa --";
                dt.Rows.InsertAt(topItem, 0);
                cbCaixa.DisplayMember = "Descricao";
                cbCaixa.ValueMember = "CaixaId";
                cbCaixa.DataSource = dt;
            }
            catch (Exception ex)
            {
                FNotificao.AlerForm(ex.Message, TipoNotificacao.erro);
            }
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            //if(ch==46 && txtSaldo.Text.IndexOf('.')!= -1)
            //{
            //    e.Handled = true;
            //    return;
            //}

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
            txtSaldo.Text = Convert.ToDouble(txtSaldo.Text).ToString("0.00");

        }

        private void txtSaldo_Leave(object sender, EventArgs e)
        {
            if(txtSaldo.Text == "")
            {
                txtSaldo.Text = "Saldo Inicial";
                picMoney.Visible = true;
            }
        }

        private void txtSaldo_Enter(object sender, EventArgs e)
        {
            if(txtSaldo.Text== "Saldo Inicial")
            {
                txtSaldo.Text = "";
                picMoney.Visible = false;
            }
        }

        private void txtSaldo_KeyUp(object sender, KeyEventArgs e)
        {
            //if (!string.IsNullOrEmpty(txtSaldo.Text))
            //{
            //    System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US");
            //    Double valueBefore = Int32.Parse(txtSaldo.Text, System.Globalization.NumberStyles.AllowThousands);
            //    txtSaldo.Text = String.Format(culture, "{0:N0}", valueBefore);
            //    txtSaldo.Select(txtSaldo.Text.Length, 0);
            //}
        }
    }
}
