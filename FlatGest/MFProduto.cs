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
    public partial class MFProduto : Form
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

        private BindingSource bsGrid = new BindingSource();
        public MFProduto(string Nome, string Id, string Cargo,AcaoNaTela acaoNaTela)
        {
            InitializeComponent();
            _NomeGlobal = Nome;
            _IdGlobal = Id;
            _CargoGlobal = Cargo;

            lblNome.Text = _NomeGlobal + " | " + _CargoGlobal;

            //Condição para os botoes na barra de titulo
            if(acaoNaTela == AcaoNaTela.Cadastrar)
            {
                btnFechar.Visible = false;
                btnMaximizar.Visible = false;
                btnRestaurar.Visible = false;
                btnMinimizar.Visible = false;
            }
        } 

        private void MFProduto_Load(object sender, EventArgs e)
        {
            Listar();
        }
        // Mecanismo para movimentar o formular
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);    

        //Método Listar no grid
        private void Listar()
        {
            Produto dto = new Produto();
            BllProduto bll = new BllProduto();

            try
            {
                dto.Operacao = "ListarPro";
                DataTable dt = bll.Listar(dto);         
                bsGrid.DataSource = dt;       
                dgv.DataSource = bsGrid;
                dgv.Update();
                dgv.Refresh();
            }
            catch(Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FFProduto f = new FFProduto(AcaoNaTela.Cadastrar);
            DialogResult dialogResultado = f.ShowDialog();
            if (dialogResultado == DialogResult.Yes)
            {
                Listar();
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMinimizar.Visible = true;
            btnMaximizar.Visible = false;
        }

        // Mecanismo para movimentar o formular
        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount == 0)
            {
                MessageBox.Show("Não Nenhum Fármaco Selecionado", "Atenção");
            }
            else
            {
                DialogResult result = MessageBox.Show("Deseja Editar os Dados Fármaco #" + dgv.CurrentRow.Cells[0].Value.ToString() + "# ?", "Pergunta!!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {

                    FFProduto f = new FFProduto(AcaoNaTela.Editar);
                    f.txtCodigo.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                    f.txtProduto.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    //f.cbCateg.Text = dgv.CurrentRow.Cells[6].Value.ToString();
                    if (dgv.CurrentRow.Cells[3].Value.ToString() == "")
                    {
                        f.picBox.Image = new Bitmap(Application.StartupPath + "\\Imagens\\photo-camera.png");
                        f.picBox.SizeMode = PictureBoxSizeMode.CenterImage;
                    }
                    else
                    {
                        f.picBox.Image = new Bitmap(Application.StartupPath + "\\Imagens\\" + dgv.CurrentRow.Cells[3].Value.ToString());
                        f.picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    DialogResult Resultado = f.ShowDialog();
                    if (Resultado == DialogResult.Yes)
                    {
                        Listar();
                    }
                }
            }
        }

        private void btnStock_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount == 0)
            {
                MessageBox.Show("Não Nenhum Farmaco Selecionado", "Atenção");
            }
            else
            {
                DialogResult result = MessageBox.Show("Deseja Adicionar " + "Novo" + " Estoque do Fármaco #" + dgv.CurrentRow.Cells[0].Value.ToString() + "# ?", "Pergunta!!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    FEstoque f = new FEstoque(_NomeGlobal, IdGlobal, _CargoGlobal,AcaoNaTela.Cadastrar);
                    f.IdGlobal = _IdGlobal;
                    f.txtCodigo.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                    f.txtFarmaco.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    f.txtDescr.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                    f.txtTipoFarmaco.Text = dgv.CurrentRow.Cells[4].Value.ToString();


                    DialogResult Resultado = f.ShowDialog();
                    if (Resultado == DialogResult.Yes)
                    {
                        Listar();
                    }
                }
            }
        }

        private void txtPesquisar_Leave(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "")
            {
                txtPesquisar.Text = "Procurar...";
                ImgPesq.Visible = true;
            }
        }

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "Procurar...")
            {
                txtPesquisar.Text = "";
                ImgPesq.Visible = false; ;
            }
        }
    }
}
