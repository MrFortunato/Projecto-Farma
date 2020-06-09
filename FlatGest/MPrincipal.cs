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
using DTO;

namespace FlatGest
{
    public partial class Form1 : Form
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
        public Form1(Permissao permissao)
        {
            InitializeComponent();
            //FormFade.ShowAsyc(this); Exibir o Form com lentidão
            if (this.WindowState == FormWindowState.Maximized)
            {
                btnRestaurar.Visible = true;
                btnMaximizar.Visible = false;
                
            }
            if(permissao == Permissao.Gerente)
            {
          
                btnPerfil.Visible = false;
                btnRelatorio.Text = "Relatórios";
       
            }
            else
            {
                pnSubMenu1.Visible = false;
                btnRvenda.Visible = false;
                btnRetorioInd.Visible = false;
                panel7.Visible = false;
                panel11.Visible = false;
                btnFuncionario.Visible = false;
                btnRelatorio.Text = "Relatório";
            }

            pnSubMenu.Visible = false;
            pnMenu.Location = new Point(0, 155);
         
        }

        private void btnEncerrar_Click(object sender, EventArgs e)
        {
            string resultado = FNotificao.AlertConfirm("Deseja Encerrar Aplicação?", TipoNotificacao.pergunta);

            if (resultado.Equals("2"))
            {
                return;
            }
            else
            {
                Application.Exit();
            }
        }
      
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
          
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
                 
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            pnSubMenu.Visible = true;
            pnMenu.Location = new Point(0, 277);
        }

        // Método para a brir novo Formulário dentro do PanelContainer
        public void AbrirFormNoPanel(object formIn)
        {
            if (this.PanelContainer.Controls.Count > 0)
                this.PanelContainer.Controls.RemoveAt(0);
            Form fh = formIn as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelContainer.Controls.Add(fh);
            this.PanelContainer.Tag = fh;
            fh.Show();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

       
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012,0);
        }

        private void btnRCompras_Click(object sender, EventArgs e)
        {
            pnSubMenu1.Visible = false;
        }

        private void btnRpagamento_Click(object sender, EventArgs e)
        {
            pnSubMenu1.Visible = false;
            AbrirFormNoPanel(new FRelatorio(_NomeGlobal, _IdGlobal, _CargoGlobal, AcaoNaTela.Pesquisar));
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            string resultado = FNotificao.AlertConfirm("Deseja Encerrar Aplicação?", TipoNotificacao.pergunta);

            if (resultado.Equals("1"))
            {

                Application.Exit();
            }
            else
            {
                return;
            }

        }

        private void Masx()
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                btnRestaurar.Visible = true;
                btnMaximizar.Visible = false;
                
            }
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            pnSubMenu1.Visible = true;
            AbrirFormNoPanel(new FRelatorio(_NomeGlobal, _IdGlobal, _CargoGlobal,AcaoNaTela.Pesquisar));
          
        } 
        private void btnFarmaco_Click(object sender, EventArgs e)
        {
            pnSubMenu.Visible = false;
            pnMenu.Location = new Point(0, 155);
            AbrirFormNoPanel(new MFProduto(_NomeGlobal, _IdGlobal, _CargoGlobal, AcaoNaTela.Cadastrar));
        }

        private void btnRelatorio_MouseHover(object sender, EventArgs e)
        {
         
            pnSubMenu1.Visible = true;
            if (btnRelatorio.Text == "Relatório")
            {
                AbrirFormNoPanel(new FRelatorio(_NomeGlobal, _IdGlobal, _CargoGlobal,AcaoNaTela.Pesquisar));
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            pnSubMenu1.Visible = true;
            if (btnRelatorio.Text == "Relatório")
            {
                AbrirFormNoPanel(new FRelatorio(_NomeGlobal, _IdGlobal, _CargoGlobal,AcaoNaTela.Pesquisar));
            }
        }

        private void btnRvenda_Click(object sender, EventArgs e)
        {
            pnSubMenu1.Visible = false;
            AbrirFormNoPanel(new FFluxoCaixa(_NomeGlobal, _CargoGlobal, _IdGlobal));
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new FFuncionarios(_NomeGlobal, _IdGlobal, _CargoGlobal));
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new FCliente(_NomeGlobal, _IdGlobal, _CargoGlobal));
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new FFornecedor(_NomeGlobal, _IdGlobal, _CargoGlobal));
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new FPerfil(_NomeGlobal, _IdGlobal, _CargoGlobal));
        }

        private void pnSubMenu1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnRetorioInd_MouseLeave(object sender, EventArgs e)
        {
            pnSubMenu1.Visible = false;
        }

        private void btnProduto_MouseHover(object sender, EventArgs e)
        {
            pnSubMenu.Visible = true;
            pnMenu.Location = new Point(0, 277);
        }

        private void btnCategoria_MouseLeave(object sender, EventArgs e)
        {
            pnSubMenu.Visible = false;
            pnMenu.Location = new Point(0, 155);
        }

        private void btnRetorioInd_Click(object sender, EventArgs e)
        {
            pnSubMenu1.Visible = false;
            AbrirFormNoPanel(new FRelatorio(_NomeGlobal, _IdGlobal, _CargoGlobal, AcaoNaTela.Gerente));
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            
            AbrirFormNoPanel(new MFEstoque(_NomeGlobal, _IdGlobal, _CargoGlobal, AcaoNaTela.Cadastrar));
        }

        private void btnCaixa_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["FVenda"] == null)
            {

                FAbrirCaixa frm = new FAbrirCaixa();
                frm.NomeGlobal = _NomeGlobal;
                frm.CargoGlobal = _CargoGlobal;
                frm.SenhaGlobal = _SenhaGlobal;
                frm.IdGlobal = _IdGlobal;
                frm.ShowDialog();
            }
            else
            {
                Funcionario dto = new Funcionario();
                FVenda f = FVenda.getInstancia(dto);
                f.Show();
            }
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            AbrirFormNoPanel(new MenuProduto(_NomeGlobal, _IdGlobal, _CargoGlobal));
        }
    }
}