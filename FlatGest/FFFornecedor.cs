using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BLL;
using DTO;

namespace FlatGest
{
    public partial class FFFornecedor : Form
    {
        public FFFornecedor(AcaoNaTela acaoNaTela)
        {
            InitializeComponent();
            if(acaoNaTela == AcaoNaTela.Cadastrar)
            {
                txtCodigo.Text = "Novo";
            }
            else
            {
                btnCadastrar.Text = "Editar";
                lblTitulo.Text = "Editar Fornecedor";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (btnCadastrar.Text == "Cadastrar")
            {
                if (txtNome.Text == string.Empty)
                {
                    errorP.SetError(txtNome, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (txtNome.TextLength < 3)
                {
                    errorP.SetError(txtNome, "!");
                    FNotificao.AlerForm("No mínino 3 caracteres e no máximo 50 caracteres", TipoNotificacao.aviso);
                }
                else if (txtEndereco.Text == string.Empty)
                {
                    errorP.SetError(txtEndereco, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (txtEndereco.TextLength < 3)
                {
                    errorP.SetError(txtEndereco, "!");
                    FNotificao.AlerForm("No mínino 3 caracteres e no máximo 50 caracteres", TipoNotificacao.aviso);
                }
                else if (txtTelf.Text == string.Empty)
                {
                    errorP.SetError(txtTelf, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (txtTelf.TextLength < 8)
                {
                    errorP.SetError(txtTelf, "!");
                    FNotificao.AlerForm("No mínino 9 caracteres e no máximo 20 caracteres", TipoNotificacao.aviso);
                }
                else if (txtEmail.Text == string.Empty)
                {
                    errorP.SetError(txtEmail, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (txtEmail.TextLength < 6)
                {
                    errorP.SetError(txtEmail, "!");
                    FNotificao.AlerForm("No mínino 9 caracteres e no máximo 20 caracteres", TipoNotificacao.aviso);
                }
                //else if (cbEstado.SelectedIndex == 0)
                //{
                //    errorP.SetError(cbEstado, "!");
                //    FNotificao.AlerForm("Selecionar o Estado", TipoNotificacao.aviso);
                //}
                else
                {
                    Cadastrar();
                }
            }
        }

        //Método para Cadastrar
        private void Cadastrar()
        {
            Fornecedor dto = new Fornecedor();
            BllFornecedor bll = new BllFornecedor();
            dto.Operacao = "Cadastrar";
            dto.NomeFornecedor = txtNome.Text;
            dto.Endereco = txtEndereco.Text;
            dto.Telf = txtTelf.Text;
            dto.Email = txtEmail.Text;
            string retorno = bll.Cadastrar(dto);
            try
            {
                int id = Convert.ToInt32(retorno);
                FNotificao.AlerForm("Fornecedor Cadastrado Com Sucesso", TipoNotificacao.sucesso);
                this.DialogResult = DialogResult.Yes;
                LimparCampos();
            }
            catch
            {
                FNotificao.AlerForm(retorno, TipoNotificacao.aviso);
                //this.DialogResult = DialogResult.No;
            }
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEndereco.Text = "";
            txtTelf.Text = "";
            txtEmail.Text = "";
            errorP.Clear();
        }

        // Mecanismo para movimentar o formular
        //[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        //private extern static void ReleaseCapture();
        //[DllImport("user32.DLL", EntryPoint = "SendMessage")]
        //private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {       
            //ReleaseCapture();
            //SendMessage(this.Handle, 0x112, 0xf012, 0);      
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
    }
}
