using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace FlatGest
{
    public partial class FFCliente : Form
    {
        bool focus;
        public FFCliente(AcaoNaTela acaoNaTela)
        {
            InitializeComponent();

            if(acaoNaTela == AcaoNaTela.Editar)
            {
                lbltitulo.Text = "Editar Cliente";
                btnCadastrar.Text = "Editar";
            }
            else
            {
                lbltitulo.Text = "Registrar Cliente";
                btnCadastrar.Text = "Cadastrar";
                txtCodigo.Text = "Novo";
            }
            cbEstado.SelectedIndex = 0;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(btnCadastrar.Text == "Cadastrar")
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
                    errorP.SetError(txtNome, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (txtNome.TextLength < 3)
                {
                    errorP.SetError(txtNome, "!");
                    FNotificao.AlerForm("No mínino 3 caracteres e no máximo 50 caracteres", TipoNotificacao.aviso);
                }
                else if (txtTelf.Text == string.Empty)
                {
                    errorP.SetError(txtTelf, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (txtNome.TextLength < 8)
                {
                    errorP.SetError(txtNome, "!");
                    FNotificao.AlerForm("No mínino 9 caracteres e no máximo 20 caracteres", TipoNotificacao.aviso);
                }
                else if (txtEmail.Text == string.Empty)
                {
                    errorP.SetError(txtTelf, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (txtNome.TextLength < 6)
                {
                    errorP.SetError(txtNome, "!");
                    FNotificao.AlerForm("No mínino 9 caracteres e no máximo 20 caracteres", TipoNotificacao.aviso);
                }
                else if (cbEstado.SelectedIndex == 0)
                {
                    errorP.SetError(cbEstado, "!");
                    FNotificao.AlerForm("Selecionar o Estado", TipoNotificacao.aviso);
                }
                else
                {
                    Cadastrar();
                }
            }
            else
            {
                if (txtCodigo.Text == string.Empty)
                {
                    errorP.SetError(txtCodigo, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (txtNome.Text == string.Empty)
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
                    errorP.SetError(txtNome, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (txtNome.TextLength < 3)
                {
                    errorP.SetError(txtNome, "!");
                    FNotificao.AlerForm("No mínino 3 caracteres e no máximo 50 caracteres", TipoNotificacao.aviso);
                }
                else if (txtTelf.Text == string.Empty)
                {
                    errorP.SetError(txtTelf, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (txtNome.TextLength < 8)
                {
                    errorP.SetError(txtNome, "!");
                    FNotificao.AlerForm("No mínino 9 caracteres e no máximo 20 caracteres", TipoNotificacao.aviso);
                }
                else if (txtEmail.Text == string.Empty)
                {
                    errorP.SetError(txtTelf, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (txtNome.TextLength < 6)
                {
                    errorP.SetError(txtNome, "!");
                    FNotificao.AlerForm("No mínino 9 caracteres e no máximo 20 caracteres", TipoNotificacao.aviso);
                }
                else if (cbEstado.SelectedIndex == 0)
                {
                    errorP.SetError(cbEstado, "!");
                    FNotificao.AlerForm("Selecionar o Estado", TipoNotificacao.aviso);
                }
                else
                {
                    Editar();
                }
            }
            
        }
        //Método para Editar
        private void Editar()
        {
            Cliente dto = new Cliente();
            BllCliente bll = new BllCliente();
            dto.Operacao = "Editar";
            dto.ClienteId = int.Parse(txtCodigo.Text);
            dto.NomeCompleto = txtNome.Text;
            dto.Endereco = txtEndereco.Text;
            dto.Telf = txtTelf.Text;
            dto.Email = txtEmail.Text;
            if (cbEstado.SelectedIndex == 1)
            {
                dto.Estado = true;
            }
            else
            {
                dto.Estado = false;
            }
            string retorno = bll.Editar(dto);
            try
            {
                int id = Convert.ToInt32(retorno);
                FNotificao.AlerForm("Dados do Cliente Editado Com Sucesso", TipoNotificacao.sucesso);
                this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                FNotificao.AlerForm(retorno, TipoNotificacao.erro);
                this.DialogResult = DialogResult.No;
            }
        }
        //Método para Cadastrar
        private void Cadastrar()
        {
            Cliente dto = new Cliente();
            BllCliente bll = new BllCliente();
            dto.Operacao = "Cadastrar";
            dto.NomeCompleto = txtNome.Text;
            dto.Endereco = txtEndereco.Text;
            dto.Telf = txtTelf.Text;
            dto.Email = txtEmail.Text;
            if(cbEstado.SelectedIndex == 1)
            {
                dto.Estado = true;
            }
            else
            {
                dto.Estado = false;
            }
                string retorno = bll.Cadastrar(dto);
            try
            {
                int id = Convert.ToInt32(retorno);
                FNotificao.AlerForm("Cliente Cadastrado Com Sucesso", TipoNotificacao.sucesso);
                this.DialogResult = DialogResult.Yes;
            }
            catch
            {
                FNotificao.AlerForm(retorno, TipoNotificacao.erro);
                this.DialogResult = DialogResult.No;
            }
        }
        // Mecanismo para movimentar o formular
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void FFCliente_Paint(object sender, PaintEventArgs e)
        {
            if (focus)
            {
                txtCodigo.BorderStyle = BorderStyle.None;
                Pen p = new Pen(Color.Red);
                Graphics g = e.Graphics;
                int variance = 3;
                g.DrawRectangle(p, new Rectangle(txtCodigo.Location.X - variance, txtCodigo.Location.Y - variance, txtCodigo.Width + variance, txtCodigo.Height + variance));
            }
            else
            {
                txtCodigo.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            focus = true;
            this.Refresh();
        }

        private void txtCodigo_Enter(object sender, EventArgs e)
        {
            focus = true;
            this.Refresh();
        }
    }
}
