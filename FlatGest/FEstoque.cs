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
using System.Runtime.InteropServices;

namespace FlatGest
{
    public partial class FEstoque : Form
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

        public FEstoque(string Nome, string Id, string Cargo,AcaoNaTela acaoNatela)
        {
            InitializeComponent();
            
            if(acaoNatela == AcaoNaTela.Cadastrar)
            {
                btnCadastrar.Text = "Cadastrar";
                lblTitulo.Text = "Registrar Novo Estoque";
                txtEstoqueId.Visible = false;
            }
            else if(acaoNatela == AcaoNaTela.Atualizar)
            {
                btnCadastrar.Text = "Adicionar";
                lblCodigo.Text = "Código Estoque";
                lblTitulo.Text = "Adicionar Estoque";
                txtEstoqueId.Visible = false;
                txtPrecoCompra.ReadOnly = true;
                txtPrecoCompra.BackColor = Color.FromArgb(191, 205, 219);
                txtPrecoVenda.ReadOnly = true;
                txtPrecoVenda.BackColor = Color.FromArgb(191, 205, 219);
                txtLote.ReadOnly = true;
                txtLote.BackColor = Color.FromArgb(191, 205, 219);
                ckActivo.Enabled = false;
                ckInactivo.Enabled = false;
                ckActivo.ForeColor = Color.White;
                dataExp.Enabled = false;
                dataProducao.Enabled = false;
                txtDescricao.Enabled = false;
                             
            }
            else 
            {
                btnCadastrar.Text = "Editar";
                lblCodigo.Text = "Código Estoque";
                txtEstoqueId.Visible = false;
                lblTitulo.Text = "Editar Estoque";
                txtEstoq.Enabled = false;
                                                
            }
        

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(btnCadastrar.Text == "Cadastrar")
            {
                if(txtDescr.Text == string.Empty)
                {
                    errorP.SetError(txtDescr, "Campo Obrigatório");
                }            
                else if (txtFarmaco.Text == string.Empty)
                {
                    errorP.SetError(txtFarmaco, "Campo Obrigatório");
                }
                else if (txtDescricao.Text == string.Empty)
                {
                    errorP.SetError(txtDescricao, "Campo Obrigatório");
                }
                else if ((txtDescricao.TextLength < 6) || (txtDescricao.TextLength > 200))
                {
                    errorP.SetError(txtDescricao, "Mínimo 6 e máximo 200 caracteres");
                }
                else if (txtPrecoCompra.Text == string.Empty)
                {
                    errorP.SetError(txtPrecoCompra, "Campo Obrigatório");
                }
                else if ((txtPrecoCompra.TextLength < 2) || (txtPrecoCompra.TextLength > 10))
                {
                    errorP.SetError(txtPrecoCompra, "Mínimo 2 e máximo 10 dígitos");
                }
                else if (txtPrecoVenda.Text == string.Empty)
                {
                    errorP.SetError(txtPrecoVenda, "Campo Obrigatório");
                }
                else if ((txtPrecoVenda.TextLength < 2) || (txtPrecoVenda.TextLength > 10))
                {
                    errorP.SetError(txtPrecoVenda, "Mínimo 2 e máximo 10 dígitos");
                }
                else if (txtEstoq.Text == string.Empty)
                {
                    errorP.SetError(txtEstoq, "Campo Obrigatório");
                }
                else if (txtEstoq.TextLength > 4)
                {
                    errorP.SetError(txtPrecoVenda, "Mínimo 1 e máximo 4 dígitos");
                }
                else if (txtLote.Text == string.Empty)
                {
                    errorP.SetError(txtLote, "Campo Obrigatório");
                }
                else if ((txtLote.TextLength < 2) || (txtLote.TextLength > 10))
                {
                    errorP.SetError(txtLote, "Mínimo 2 e máximo 10 dígitos");
                }
                else if (dataProducao.Text == string.Empty)
                {
                    errorP.SetError(dataProducao, "Campo Obrigatório");
                }
                else if (dataExp.Text == string.Empty)
                {
                    errorP.SetError(dataExp, "Campo Obrigatório");
                }
                else if (ckActivo.Checked == false &&  ckInactivo.Checked == false)
                {
                    errorP.SetError(ckInactivo, "Selecionana Um dos Campo");
                }
                
                else
                {
                    Cadastrar();
                }
                
            }
            else if(btnCadastrar.Text == "Editar")
            {
                if (txtCodigo.Text == string.Empty)
                {
                    errorP.SetError(txtCodigo, "Campo Obrigatório");
                }
                else if (txtDescr.Text == string.Empty)
                {
                    errorP.SetError(txtDescr, "Campo Obrigatório");
                }
                else if (txtFarmaco.Text == string.Empty)
                {
                    errorP.SetError(txtFarmaco, "Campo Obrigatório");
                }
                else if (txtDescricao.Text == string.Empty)
                {
                    errorP.SetError(txtDescricao, "Campo Obrigatório");
                }
                else if ((txtDescricao.TextLength < 6) || (txtDescricao.TextLength > 200))
                {
                    errorP.SetError(txtDescricao, "Mínimo 6 e máximo 200 caracteres");
                }
                else if (txtPrecoCompra.Text == string.Empty)
                {
                    errorP.SetError(txtPrecoCompra, "Campo Obrigatório");
                }
                else if ((txtPrecoCompra.TextLength < 2) || (txtPrecoCompra.TextLength > 10))
                {
                    errorP.SetError(txtPrecoCompra, "Mínimo 2 e máximo 10 dígitos");
                }
                else if (txtPrecoVenda.Text == string.Empty)
                {
                    errorP.SetError(txtPrecoVenda, "Campo Obrigatório");
                }
                else if ((txtPrecoVenda.TextLength < 2) || (txtPrecoVenda.TextLength > 10))
                {
                    errorP.SetError(txtPrecoVenda, "Mínimo 2 e máximo 10 dígitos");
                }
                else if (txtEstoq.Text == string.Empty)
                {
                    errorP.SetError(txtEstoq, "Campo Obrigatório");
                }
                else if (txtEstoq.TextLength > 4)
                {
                    errorP.SetError(txtPrecoVenda, "Mínimo 1 e máximo 4 dígitos");
                }
                else if (txtLote.Text == string.Empty)
                {
                    errorP.SetError(txtLote, "Campo Obrigatório");
                }
                else if ((txtLote.TextLength < 2) || (txtLote.TextLength > 10))
                {
                    errorP.SetError(txtLote, "Mínimo 2 e máximo 10 dígitos");
                }
                else if (dataProducao.Text == string.Empty)
                {
                    errorP.SetError(dataProducao, "Campo Obrigatório");
                }
                else if (dataExp.Text == string.Empty)
                {
                    errorP.SetError(dataExp, "Campo Obrigatório");
                }
                else if (ckActivo.Checked == false && ckInactivo.Checked == false)
                {
                    errorP.SetError(ckInactivo, "Selecionana Um dos Campo");
                }
                else
                {
                    Editar(); 
                }

            }
            else
            {
                if (txtCodigo.Text == string.Empty)
                {
                    errorP.SetError(txtCodigo, "Campo Obrigatório");
                }
                else if (txtDescr.Text == string.Empty)
                {
                    errorP.SetError(txtDescr, "Campo Obrigatório");
                }
                else if (txtFarmaco.Text == string.Empty)
                {
                    errorP.SetError(txtFarmaco, "Campo Obrigatório");
                }
                else if (txtDescricao.Text == string.Empty)
                {
                    errorP.SetError(txtDescricao, "Campo Obrigatório");
                }
                else if ((txtDescricao.TextLength < 6) || (txtDescricao.TextLength > 200))
                {
                    errorP.SetError(txtDescricao, "Mínimo 6 e máximo 200 caracteres");
                }
                else if (txtPrecoCompra.Text == string.Empty)
                {
                    errorP.SetError(txtPrecoCompra, "Campo Obrigatório");
                }
                else if ((txtPrecoCompra.TextLength < 2) || (txtPrecoCompra.TextLength > 10))
                {
                    errorP.SetError(txtPrecoCompra, "Mínimo 2 e máximo 10 dígitos");
                }
                else if (txtPrecoVenda.Text == string.Empty)
                {
                    errorP.SetError(txtPrecoVenda, "Campo Obrigatório");
                }
                else if ((txtPrecoVenda.TextLength < 2) || (txtPrecoVenda.TextLength > 10))
                {
                    errorP.SetError(txtPrecoVenda, "Mínimo 2 e máximo 10 dígitos");
                }
                else if (txtEstoq.Text == string.Empty)
                {
                    errorP.SetError(txtEstoq, "Campo Obrigatório");
                }
                else if (txtEstoq.TextLength > 4)
                {
                    errorP.SetError(txtPrecoVenda, "Mínimo 1 e máximo 4 dígitos");
                }
                else if (txtLote.Text == string.Empty)
                {
                    errorP.SetError(txtLote, "Campo Obrigatório");
                }
                else if ((txtLote.TextLength < 2) || (txtLote.TextLength > 10))
                {
                    errorP.SetError(txtLote, "Mínimo 2 e máximo 10 dígitos");
                }
                else if (dataProducao.Text == string.Empty)
                {
                    errorP.SetError(dataProducao, "Campo Obrigatório");
                }
                else if (dataExp.Text == string.Empty)
                {
                    errorP.SetError(dataExp, "Campo Obrigatório");
                }
                else if (ckActivo.Checked == false && ckInactivo.Checked == false)
                {
                    errorP.SetError(ckInactivo, "Selecionana Um dos Campo");
                }
                else
                {
                    Atualizar();
                }
            }
        }
        //Método para editar 
        private void Editar()
        {
            Estoque dto = new Estoque();
            BllEstoque bll = new BllEstoque();


            dto.Operacao = "Editar";
            dto.EstoqueId = Convert.ToInt32(txtCodigo.Text); 
            dto.Quantidade = Convert.ToInt32(txtEstoq.Text);
            dto.FuncionarioId = Convert.ToInt32(_IdGlobal);
            dto.DataExp = dataExp.Value;
            dto.Descricao = txtDescricao.Text;
            dto.DataFabrico = dataProducao.Value;
            dto.Quantidade = Convert.ToInt32(txtEstoq.Text);
            dto.Lote = txtLote.Text;
            dto.PrecoCompra = Convert.ToDecimal(txtPrecoCompra.Text);
            dto.PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text);

            if (ckActivo.Checked == true)
            {
                dto.Estado = true;
            }
            else
            {
                dto.Estado = false;
            }
            try
            {
                string retorno = bll.Editar(dto);
                MessageBox.Show(retorno, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Yes;
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.No;
            }

        }

        //Método Atualizar Quantidade Estoque
        private void Atualizar()
        {
            Estoque dto = new Estoque();
            BllEstoque bll = new BllEstoque();


            dto.Operacao = "Atualizar";
            dto.EstoqueId = Convert.ToInt32(txtCodigo.Text);
            dto.FuncionarioId = Convert.ToInt32(_IdGlobal);
            dto.Quantidade = Convert.ToInt32(txtEstoq.Text);
    
        
            try
            {
                string retorno = bll.Atualizar(dto);
                MessageBox.Show(retorno, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.Yes;
                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.DialogResult = DialogResult.No;
            }

        }

        //Método para Cadastrar, Editar e Atualizar Estoque
        private void Cadastrar()
        {
                Estoque dto = new Estoque();
                BllEstoque bll = new BllEstoque();
                

                dto.Operacao = "Cadastrar";          
                dto.ProdutoId = Convert.ToInt32(txtCodigo.Text);
                dto.FuncionarioId =Convert.ToInt32(_IdGlobal);
                dto.DataExp = dataExp.Value;
                dto.DataFabrico = dataProducao.Value;
                dto.Quantidade = Convert.ToInt32(txtEstoq.Text);
                dto.Descricao = txtDescricao.Text;
                dto.Lote = txtLote.Text;
                dto.PrecoCompra = Convert.ToDecimal(txtPrecoCompra.Text);
                dto.PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text);

                if(ckActivo.Checked == true)
                {
                    dto.Estado = true;
                }
                else
                {
                    dto.Estado = false;
                }
            
            try
            {
                string retorno = bll.Cadastrar(dto);
                FNotificao.AlerForm(retorno,TipoNotificacao.sucesso);
                this.DialogResult = DialogResult.Yes;
                LimparCampos();
            }
            catch(Exception ex)
            {
                FNotificao.AlerForm(ex.Message, TipoNotificacao.erro);
                this.DialogResult = DialogResult.No;
            }
          

        }

        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtDescricao.Text = "";
            txtFarmaco.Text = "";
            txtDescr.Text = "";
            txtEstoq.Text = "";
            txtLote.Text = "";
            txtPrecoVenda.Text = "";
            txtPrecoCompra.Text = "";
            txtTipoFarmaco.Text = "";
            lblCodigo.Text = "Código Fármaco";
        }

        private void txtPrecoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtPrecoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void txtEstoq_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckActivo.Checked == true)
            {
                ckInactivo.Checked = false;
            }
            else
            {
                ckInactivo.Checked = true;
            }
        }

        private void ckInactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckInactivo.Checked == true)
            {
                ckActivo.Checked = false;
            }
            else
            {
                ckActivo.Checked = true;
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {

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
    }
}
