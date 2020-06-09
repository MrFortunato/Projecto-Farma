using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace FlatGest
{
    public partial class FFinalizar : Form
    {
        private string _CaixaId;
        private string _ValorTotal;
        public string CaixaId
        {
            get { return _CaixaId; }
            set { _CaixaId = value; }
        }
        public string ValorTotal
        {
            get { return _ValorTotal; }
            set { _ValorTotal = value; }
        }

        private static FFinalizar instancia;

        // Função Estática  que pode ser herdada em outros formulários
        public static FFinalizar getInstancia(string Caixa, string Valor)
        {

            if (instancia == null || instancia.IsDisposed)
                instancia = new FFinalizar(Caixa, Valor);

            else
                instancia.BringToFront();
            return instancia;
        }
        public FFinalizar(string Caixa, string Valor)
        {
            InitializeComponent();
            //FormFade.ShowAsyc(this);
            _CaixaId = Caixa;
            _ValorTotal = Valor;
            lblV.Text = Convert.ToDecimal(_ValorTotal).ToString("C");
            txtEntregou.Enabled = false;   //Desativar campo Entregou
            txtTroco.Enabled = false;      //Desativar campo Troco
        }

        private void FFinalizar_Load(object sender, EventArgs e)
        {
            cbTipoPagam.SelectedIndex = 0;
            dataPagam.Enabled = false;
        }
 

        //Método para Cadastrar Venda
        private void CadastrarVenda()
        {
            Venda dto = new Venda();
            BllVenda bll = new BllVenda();
            dto.Operacao = "Venda";
            dto.CaixaFunc = Convert.ToInt32(_CaixaId);
            dto.ClienteId = Convert.ToInt32(txtCodigo.Text);
            dto.ValorTotal = Convert.ToDecimal(ValorTotal);
            if (cbTipoPagam.SelectedIndex == 1)
            {
                dto.TipoPagamento = 1;
            }
            else if(cbTipoPagam.SelectedIndex == 2)
            {
                dto.TipoPagamento = 2;
            }
            else if (cbTipoPagam.SelectedIndex == 3)
            {
                dto.TipoPagamento = 3;
                dataPagam.Enabled = true;
            }
            else
            {
                FNotificao.AlerForm("Tipo de Pagamento Inválido", TipoNotificacao.aviso);
            }
        

            string retorno = bll.Cadastrar(dto);
            try
            {

                int id = Convert.ToInt32(retorno);
                FNotificao.AlerForm("Venda Efetuada Com Sucesso!!!", TipoNotificacao.sucesso);
                FVenda f = FVenda.getInstancia(null);
                f.CadastrarPedido();
                LimparCampos();
                this.Close();

            }
            catch
            {
                FNotificao.AlerForm("Erro Ao Registrar a Venda " + retorno.ToString(), TipoNotificacao.erro);
            }
        }

        //Método para Limpar os Campos
        private void LimparCampos()
        {
            lblV.Text = "0, 00 Kz";
            txtCodigo.Text = "";
            txtCliente.Text = "";
            cbTipoPagam.SelectedIndex = 0;
            txtEntregou.Text = "0, 00 Kz";
            txtTroco.Text = "0, 00 Kz";
        }

        //Método Pesquisar Cliente
        private void ProcurarCliente()
        {
            BllCliente bll = new BllCliente();
            Cliente dto = new Cliente();

            dto.ClienteId = Convert.ToInt32(txtCodigo.Text);
            dto.Operacao = "ListarPor";
            DataTable dt = bll.ListarPorCodigo(dto);
            try
            {
                if (dt.Rows.Count != 0)
                {
                    txtCliente.Text = dt.Rows[0]["NomeCompleto"].ToString();
                }
                else
                {
                    FNotificao.AlerForm("Cliente não encontrado",TipoNotificacao.info);
                    txtCodigo.Text = "";
                }
            }
            catch(Exception ex)
            {
                FNotificao.AlerForm(ex.Message,TipoNotificacao.erro);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
        
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                FNotificao.AlerForm("este campo aceita somente numero e virgula",TipoNotificacao.info);
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                FNotificao.AlerForm("este campo aceita somente uma virgula",TipoNotificacao.info);
            }
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty)
            {
                if (txtCodigo.Text.Length > 0)
                {
                    ProcurarCliente();
                }

            }
            else
            {
                txtCliente.Text = "";
            }
        }

        private void txtEntregou_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
                FNotificao.AlerForm("este campo aceita somente numero e virgula",TipoNotificacao.info);
            }
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
                FNotificao.AlerForm("este campo aceita somente uma virgula",TipoNotificacao.info);
            }
        }

        //Método para calcular troco
        private void CalcularTroco()
        {
            try
            {
                decimal T, E;
                E = Convert.ToDecimal(txtEntregou.Text);
                T = E - Convert.ToDecimal(_ValorTotal); 
                txtTroco.Text = T.ToString("C");
            }
            catch(Exception ex)
            {
                FNotificao.AlerForm(ex.Message,TipoNotificacao.erro);
            }
        }

        // Método para ativar os campos para calcular
        private void AtivarCalculo()
        {
            if(cbTipoPagam.SelectedIndex == 1)
            {
                txtEntregou.Enabled = true;
                txtTroco.Enabled = true;
                dataPagam.Enabled = false;
            }
            else if (cbTipoPagam.SelectedIndex == 3)
            {
                dataPagam.Enabled = true;
            }
            else
            {
                txtEntregou.Enabled = false; ;
                txtTroco.Enabled = false;
                dataPagam.Enabled = false;
            }
        }

        private void txtEntregou_TextChanged(object sender, EventArgs e)
        {
            if(txtEntregou.Text!= string.Empty)
            {
                if(txtEntregou.TextLength > 0 && txtEntregou.Text != "0, 00 Kz")
                {
                    CalcularTroco();
                }
                else
                {
                    errorP.SetError(txtEntregou, "Caracteres Inválidos");
                }
              
            }
            
        }

        private void txtEntregou_Enter(object sender, EventArgs e)
        {
            txtEntregou.Text = "";
        }

        private void cbTipoPagam_TextChanged(object sender, EventArgs e)
        {
            AtivarCalculo();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if(cbTipoPagam.SelectedIndex == 0)
            {
                FNotificao.AlerForm("Selecionar o tipo de Pagamento", TipoNotificacao.aviso);
            }
            else
            {
                if(txtCodigo.Text == string.Empty)
                {
                    errorP.SetError(txtCodigo, "Informe o Código do Cliente");
                    //txtCodigo.BorderStyle = Color.FromArgb(191, 205, 219);
                }
                else
                {
                    CadastrarVenda();
                }       
            }
            
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

     
    }
}
