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
using System.Collections;

namespace FlatGest
{
    public partial class FFFuncionario : Form
    {
        public FFFuncionario(AcaoNaTela acaoNaTela)
        {
            InitializeComponent();
            if(acaoNaTela == AcaoNaTela.Editar)
            {
                lblTitulo.Text = "Editar Funcionario";
                txtUsername.Enabled = false;
                txtSenha.Enabled = false;
                txtConfirmSenha.Enabled = false;
                btnCadastrar.Text = "Editar";
            }
            else
            {
                txtCodigo.Text = "Novo";
                cbCargo.SelectedIndex = 0;
                cbEstado.SelectedIndex = 0;
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
                if (txtNome.Text == string.Empty)
                {
                    validar.SetHighlightColor(txtNome, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                }
                else if (txtNome.TextLength < 3 )
                {
                    //errorP.SetError(txtNome, "!");
                    //FNotificao.AlerForm("No mínino 3 caracteres e no máximo 50 caracteres", TipoNotificacao.aviso);
                    validar.SetHighlightColor(txtNome, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                }
                else if (txtEndereco.Text == string.Empty)
                {
                    //errorP.SetError(txtEndereco, "!");
                    //FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                    validar.SetHighlightColor(txtEndereco, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                }
                else if (txtTelf.Text == string.Empty)
                {
                    //errorP.SetError(txtTelf, "!");
                    //FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                    validar.SetHighlightColor(txtTelf, DevComponents.DotNetBar.Validator.eHighlightColor.Red);

                }
                else if (cbEstado.SelectedIndex == 0)
                {
                    errorP.SetError(cbEstado, "!");
                    validar.SetHighlightColor(cbEstado, DevComponents.DotNetBar.Validator.eHighlightColor.Red);

                }
                else if (txtEmail.Text == string.Empty)
                {
                    errorP.SetError(txtEmail, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (cbCargo.SelectedIndex == 0)
                {
                    errorP.SetError(cbCargo, "!");
                    FNotificao.AlerForm("Selecionar o Cargo", TipoNotificacao.aviso);
                }      
                else if (txtUsername.Text == string.Empty)
                {
                    errorP.SetError(txtUsername, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if ((txtSenha.Text == string.Empty) || (txtSenha.Text != txtConfirmSenha.Text))
                {
                    errorP.SetError(txtSenha, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else
                {
                    Cadastrar();
                }
            }
            else
            {
                if (txtNome.Text == string.Empty)
                {
                    errorP.SetError(txtNome, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (txtEndereco.Text == string.Empty)
                {
                    errorP.SetError(txtEndereco, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (txtTelf.Text == string.Empty)
                {
                    errorP.SetError(txtTelf, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (txtEmail.Text == string.Empty)
                {
                    errorP.SetError(txtEmail, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                else if (cbCargo.SelectedIndex == 0)
                {
                    errorP.SetError(cbCargo, "!");
                    FNotificao.AlerForm("Selecionar o Cargo", TipoNotificacao.aviso);
                }
                else if (cbEstado.SelectedIndex == 0)
                {
                    errorP.SetError(cbEstado, "!");
                    FNotificao.AlerForm("Selecionar o Cargo", TipoNotificacao.aviso);
                }
                else if (txtUsername.Text == string.Empty)
                {
                    errorP.SetError(txtUsername, "!");
                    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                }
                //else if ((txtSenha.Text == string.Empty) || (txtSenha.Text != txtConfirmSenha.Text))
                //{
                //    errorP.SetError(txtSenha, "!");
                //    FNotificao.AlerForm("Campo Obrigatório", TipoNotificacao.aviso);
                //}
                else
                {
                    Editar();
                }
            }       
        }

        //Método para Limpar Campos
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtEmail.Text = "";
            validar.SetHighlightColor(txtNome, DevComponents.DotNetBar.Validator.eHighlightColor.None);

        }

        //Método para Cadastrar
        private void Cadastrar()
        {
            BllFuncionario bll = new BllFuncionario();
            Funcionario dto = new Funcionario();

            dto.Operacao = "Cadastrar";
            dto.NomeCompleto = txtNome.Text;
            dto.NomeUsuario = txtUsername.Text;
            dto.Senha = txtSenha.Text;
                      
            dto.Endereco = txtEndereco.Text;
            dto.Telf = txtTelf.Text;
            dto.Email = txtEmail.Text;

            if (cbCargo.SelectedIndex == 1)
            {
                dto.CargoId = 1;
            }
            else
            {
                dto.CargoId = 2;
            }
            if (cbEstado.SelectedIndex == 1)
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

                //if (id > 0)
                //{
                    FNotificao.AlerForm("Funcionário Cadastrado Com Sucesso", TipoNotificacao.sucesso);
                    this.DialogResult = DialogResult.Yes;
                //}

            }
            catch 
            {
                FNotificao.AlerForm(retorno, TipoNotificacao.aviso);

                //this.DialogResult = DialogResult.No;
            }
        }

        //Método para Editar
        private void Editar()
        {
            BllFuncionario bll = new BllFuncionario();
            Funcionario dto = new Funcionario();

            dto.Operacao = "Editar";
            dto.FuncionarioId = Convert.ToInt32(txtCodigo.Text);
            dto.NomeCompleto = txtNome.Text;
            dto.NomeUsuario = txtUsername.Text;
            dto.Senha = txtSenha.Text;

            dto.Endereco = txtEndereco.Text;
            dto.Telf = txtTelf.Text;
            dto.Email = txtEmail.Text;

            if (cbCargo.SelectedIndex == 1)
            {
                dto.CargoId = 1;
            }
            else
            {
                dto.CargoId = 2;
            }
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
                
                    FNotificao.AlerForm("Dados do Funcionário Editar Com Sucesso", TipoNotificacao.sucesso);
                    this.DialogResult = DialogResult.Yes;
            }
            catch 
            {
                FNotificao.AlerForm(retorno, TipoNotificacao.erro);
                this.DialogResult = DialogResult.No;
            }
        }

        private void FFFuncionario_Load(object sender, EventArgs e)
        {
           
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.TextLength > 3)
            {
                validar.SetHighlightColor(txtNome, DevComponents.DotNetBar.Validator.eHighlightColor.Green);
            }
            else
            {       
                validar.SetHighlightColor(txtNome, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
            }
        }

        private void txtEndereco_TextChanged(object sender, EventArgs e)
        {
            if (txtEndereco.TextLength > 4)
            {
                validar.SetHighlightColor(txtEndereco, DevComponents.DotNetBar.Validator.eHighlightColor.Green);
            }
            else
            {
                validar.SetHighlightColor(txtEndereco, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
            }
        }

        private void txtTelf_TextChanged(object sender, EventArgs e)
        {
            if (txtTelf.TextLength > 8)
            {
                validar.SetHighlightColor(txtTelf, DevComponents.DotNetBar.Validator.eHighlightColor.Green);
            }
            else
            {
                validar.SetHighlightColor(txtTelf, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
            }
        }

        private void cbEstado_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbEstado.SelectedIndex == 0)
            {
                validar.SetHighlightColor(cbEstado, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
            }
            else
            {
                validar.SetHighlightColor(cbEstado, DevComponents.DotNetBar.Validator.eHighlightColor.Green);
            }
        }

        private void cbCargo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbCargo.SelectedIndex == 0)
            {
                validar.SetHighlightColor(cbCargo, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
            }
            else
            {
                validar.SetHighlightColor(cbCargo, DevComponents.DotNetBar.Validator.eHighlightColor.Green);
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtEmail.TextLength > 4)
            {
                validar.SetHighlightColor(txtEmail, DevComponents.DotNetBar.Validator.eHighlightColor.Green);
            }
            else
            {
                validar.SetHighlightColor(txtEmail, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if(btnCadastrar.Text == "Cadastrar")
            {
                if (txtUsername.TextLength > 4)
                {
                    validar.SetHighlightColor(txtUsername, DevComponents.DotNetBar.Validator.eHighlightColor.Green);
                }
                else
                {
                    validar.SetHighlightColor(txtUsername, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                }
            }
            
        }

        private void txtConfirmSenha_TextChanged(object sender, EventArgs e)
        {
            if ((txtConfirmSenha.TextLength != txtSenha.TextLength)|| (txtConfirmSenha.Text != txtSenha.Text))
            {
                validar.SetHighlightColor(txtSenha, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
                validar.SetHighlightColor(txtConfirmSenha, DevComponents.DotNetBar.Validator.eHighlightColor.Red);
            }
            else
            {
                validar.SetHighlightColor(txtSenha, DevComponents.DotNetBar.Validator.eHighlightColor.Green);
                validar.SetHighlightColor(txtConfirmSenha, DevComponents.DotNetBar.Validator.eHighlightColor.Green);
            }
        }
    }
}
