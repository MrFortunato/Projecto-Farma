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

namespace FlatGest
{
    public partial class FLogin : Form
    {
        public FLogin()
        {
            InitializeComponent();
            //FormFade.ShowAsyc(this);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                picUser.Visible = true;
                txtUsuario.Text = "Username";
            }
        }

        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Username")
            {
                picUser.Visible = false;
                txtUsuario.Text = "";
            }
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                picSenha.Visible = true;
                txtSenha.Text = "Senha";
            }

        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            if (txtSenha.Text == "Senha")
            {
                picSenha.Visible = false;
                txtSenha.Text = "";
            }

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            Login();
        } 
        //Método para Logar
        private void Login()
        {
            BllFuncionario bll = new BllFuncionario();
            Funcionario dto = new Funcionario();
            dto.Operacao = "Login";
            dto.NomeUsuario = "Maninho10" /*txtUsuario.Text*/;
            dto.Senha = "1234" /*txtSenha.Text*/;
            DataTable dt = bll.Logar(dto);
            
            try
            {
                if (dt.Rows.Count != 0)
                {
                    if(Convert.ToInt32(dt.Rows[0]["Cargo"]) == 1)
                    {
                        Form1 frm = new Form1(Permissao.Gerente);

                        frm.NomeGlobal = dt.Rows[0]["NomeCompleto"].ToString();
                        frm.IdGlobal = dt.Rows[0]["FuncionarioId"].ToString();
                        if (Convert.ToInt32(dt.Rows[0]["Cargo"]) == 1)
                        {
                            frm.CargoGlobal = "Gerente";
                        }
                        else
                        {
                            frm.CargoGlobal = "Farmacêutico";
                        }
                        frm.SenhaGlobal = txtSenha.Text;
                        this.Hide();
                        frm.Show();
                    }
                    else
                    {
                        Form1 frm = new Form1(Permissao.Farmaceutico);

                        frm.NomeGlobal = dt.Rows[0]["NomeCompleto"].ToString();
                        frm.IdGlobal = dt.Rows[0]["FuncionarioId"].ToString();
                        if (Convert.ToInt32(dt.Rows[0]["Cargo"]) == 1)
                        {
                            frm.CargoGlobal = "Gerente";
                        }
                        else
                        {
                            frm.CargoGlobal = "Farmacêutico";
                        }
                        frm.SenhaGlobal = txtSenha.Text;
                        this.Hide();
                        frm.Show();
                    }
                 
                }
                else
                {                    
                    FNotificao.AlerForm("Username Ou Senha Errada", TipoNotificacao.erro);                    
                }
            }
            catch (Exception ex)
            {
                FNotificao.AlerForm(ex.Message, TipoNotificacao.erro);
            }
        }
    }
}
