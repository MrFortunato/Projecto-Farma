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
    public partial class MEstoque : Form
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
        public class MEstoqueOpera
        {
            public void Lis()
            {
                instancia.Listar();
            }

            public void FecharMEstoque()
            {
                if (instancia != null)
                {
                    instancia.Fechar();
                }
                
            }

        }

        private static MEstoque instancia;
        public static MEstoque getInstancia(AcaoNaTela acaoNaTela)
        {


            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new MEstoque(null, null, null,acaoNaTela);
            }
            else
            {
                instancia.BringToFront();

            }

            return instancia;
        }

        public MEstoque(string Nome, string Id, string Cargo,AcaoNaTela acaoNaTela)
        {
            InitializeComponent();
            this.dgv.Columns["PrecoV"].DefaultCellStyle.Format = "C";
            this.dgv.Columns["PrecoC"].DefaultCellStyle.Format = "C";
            Estoque dto = new Estoque();

            if(acaoNaTela == AcaoNaTela.Pesquisar)
            {
                btnAtualizar.Visible = false;
                btnEdit.Visible = false;
                btnNovo.Visible = false;
                pN.Visible = false;
                pA.Visible = false;
                pE.Visible = false;
                pS.Visible = true;
                btnSelecionar.Visible = true;

            }
      
            else
            {
                pS.Visible = false;
                btnSelecionar.Visible = false;
                btnFechar.Visible = false;
                btnMinimizar.Visible = false;
                btnMaximizar.Visible = false;
                btnRestaurar.Visible = false;
            }
            _NomeGlobal = Nome;
            _IdGlobal = Id;
            _CargoGlobal = Cargo;

            //lblNome.Text = _NomeGlobal + " | " + _CargoGlobal;
        } 
        private void FEstoque_Load(object sender, EventArgs e)
        {
            Listar();
            //ValidarBotoesOperacao();
        }

        //Método para listar no grid
        private void Listar()
        {
            BllEstoque bll = new BllEstoque();
            Estoque dto = new Estoque();

            dto.Operacao = "Listar";
            try
            {
                DataTable dt = bll.Listar(dto);
                bsGrid.DataSource = dt;
                dgv.DataSource = bsGrid;
                dgv.Update();
                dgv.Refresh();
            }
            catch (Exception ex)
            {
                FNotificao.AlerForm(ex.Message,TipoNotificacao.erro);
            }
        }

        public void Fechar()
        {
            this.Close();
        }

        //Método para Pesquisar no grid por condição
        private void PesquisarPor()
        {
            BllEstoque bll = new BllEstoque();
            Estoque dto = new Estoque();
            DataTable dt = new DataTable();
            

            try
            {
               // Pesquisar Por Código do Produto ou Preço
                int Codig;
                if (int.TryParse(txtPesquisar.Text, out Codig) == true)
                {
                    dto.Operacao = "PesquisarPorN";
                    dto.ProdutoId = Codig;
                    dto.PrecoVenda = Codig;
                }
                else
                {
                    //Pesquisar pelo Fármaco, Categoria, Lote, e Tipo de Fármaco
                    dto.Operacao = "PesquisarPorL";
                    dto.NomeCateg = txtPesquisar.Text;
                    dto.NomeProduto = txtPesquisar.Text;
                    dto.Lote = txtPesquisar.Text;
                    dto.NomeTipoFarmaco = txtPesquisar.Text;
                }
                dt = bll.Pesquisar(dto);
                bsGrid.DataSource = dt;
                dgv.DataSource = bsGrid;
                dgv.Update();
                dgv.Refresh();

            }
            catch(Exception ex)
            {
                FNotificao.AlerForm(ex.Message,TipoNotificacao.erro);
            }
        }
        private void ValidarBotoesOperacao()
        {
            if (dgv.RowCount != 0)
            {
                btnNovo.Enabled = false;
                btnNovo.BackColor = Color.Green;

                btnEdit.Enabled = true;
                btnEdit.BackColor = Color.FromArgb(26, 32, 40);

                btnAtualizar.Enabled = true;
                btnAtualizar.BackColor = Color.FromArgb(26, 32, 40);
            }

        }
      
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount == 0)
            {
                FNotificao.AlerForm("Não Nenhum Fármaco Selecionado", TipoNotificacao.info);
            }
            else
            {
                if (dgv.CurrentRow.Cells[13].Value.ToString() == "Disponível")
                {
                    Estoque es = new Estoque();

                    // txtPrijs textbox está Invisível no Formulario Venda
                    //f.txtPrijs.Text = dgv.CurrentRow.Cells[10].Value.ToString();
                    if (dgv.CurrentRow.Cells[11].Value.ToString() == "")
                    {
                        es.Descricao = "Sem Descrição";
                    }
                    else
                    {
                        es.Descricao = dgv.CurrentRow.Cells[11].Value.ToString();
                    }
                    Funcionario dto = new Funcionario();
                    FVenda f = FVenda.getInstancia(dto);
                    f.txtCod.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                    f.txtDescri.Text = dgv.CurrentRow.Cells[11].Value.ToString();
                    f.txtPreco.Text = dgv.CurrentRow.Cells[10].Value.ToString();
                    f.txtPrijs.Text = dgv.CurrentRow.Cells[10].Value.ToString();
                    f.txtEstok.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                    f.txtProd.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                    if (dgv.CurrentRow.Cells[12].Value.ToString() == "")
                    {
                        f.picBox.Image = new Bitmap(Application.StartupPath + "\\Imagens\\image_100px.png");
                    }
                    else
                    {
                        f.picBox.Image = new Bitmap(Application.StartupPath + "\\Imagens\\" + dgv.CurrentRow.Cells[12].Value.ToString());
                        f.picBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    }

                    f.Show();
                    Listar();

                }
                else
                    FNotificao.AlerForm("O Fármaco Selecionaro Não Encontra-se DISPONÍVEL",TipoNotificacao.aviso);
            }

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount == 0)
            {
                FNotificao.AlerForm("Não Nenhum Fármaco Selecionado",TipoNotificacao.aviso);
            }
            else
            {
                string resultado = FNotificao.AlertConfirm("Deseja Cadastrar Novo estoque do Fármaco " + dgv.CurrentRow.Cells[3].Value.ToString() + " ?",TipoNotificacao.pergunta);
                if (resultado == "1")
                {

                    FEstoque f = new FEstoque(_NomeGlobal, _IdGlobal, _CargoGlobal, AcaoNaTela.Cadastrar);
                    f.IdGlobal = _IdGlobal;
                    f.txtCodigo.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                    f.txtDescr.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                    f.txtFarmaco.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                    f.txtTipoFarmaco.Text = dgv.CurrentRow.Cells[1].Value.ToString();

                    if (dgv.CurrentRow.Cells[12].Value.ToString() == "Disponível")
                    {
                        f.ckActivo.Checked = true;
                    }
                    else
                    {
                        f.ckActivo.Checked = false;
                    }

                    DialogResult DialogResult = f.ShowDialog();

                    if (DialogResult == DialogResult.Yes)
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount == 0)
            {
                 FNotificao.AlerForm("Não Nenhum Farmaco Selecionado", TipoNotificacao.aviso);
            }
            else
            {
                string resultado = FNotificao.AlertConfirm("Deseja Adicionar Estoque do Fármaco #" + dgv.CurrentRow.Cells[3].Value.ToString() + "# ?", TipoNotificacao.pergunta);
                
                if (resultado == "1")
                {
                    FEstoque frm = new FEstoque(_NomeGlobal, _IdGlobal, _CargoGlobal, AcaoNaTela.Atualizar);
                    frm.IdGlobal = _IdGlobal;
                    frm.txtCodigo.Text = dgv.CurrentRow.Cells["EstoqueId"].Value.ToString();
                    frm.txtDescr.Text = dgv.CurrentRow.Cells[2].Value.ToString();

                    frm.txtPrecoCompra.Text = dgv.CurrentRow.Cells[9].Value.ToString();
                    frm.txtPrecoVenda.Text = dgv.CurrentRow.Cells[10].Value.ToString();
                    frm.txtLote.Text = dgv.CurrentRow.Cells[8].Value.ToString();
                    //frm.txtEstoq.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                    frm.dataProducao.Text = dgv.CurrentRow.Cells[6].Value.ToString();
                    frm.dataExp.Text = dgv.CurrentRow.Cells[7].Value.ToString();


                    frm.txtFarmaco.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                    frm.txtTipoFarmaco.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    frm.txtDescricao.Text = dgv.CurrentRow.Cells[11].Value.ToString();

                    if (dgv.CurrentRow.Cells[13].Value.ToString() == "Disponível")
                    {
                        frm.ckActivo.Checked = true;
                    }
                    else
                    {
                        frm.ckActivo.Checked = false;
                    }
                    DialogResult DialogResult = frm.ShowDialog();

                    if (DialogResult == DialogResult.Yes)
                    {
                        Listar();
                    }
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            if (dgv.RowCount == 0)
            {
                FNotificao.AlerForm("Não Nenhum Farmaco Selecionado",TipoNotificacao.pergunta);
            }
            else
            {
                string resultado = FNotificao.AlertConfirm("Deseja Editar o Estoque do Fármaco #" + dgv.CurrentRow.Cells[3].Value.ToString() + "# ?", TipoNotificacao.pergunta);
                if (resultado == "1")
                {
                    FEstoque frm = new FEstoque(_NomeGlobal, _IdGlobal, _CargoGlobal, AcaoNaTela.Editar);
                    frm.IdGlobal = _IdGlobal;
                    frm.txtCodigo.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                    frm.txtDescr.Text = dgv.CurrentRow.Cells[2].Value.ToString();

                    frm.txtPrecoCompra.Text = dgv.CurrentRow.Cells[9].Value.ToString();
                    frm.txtPrecoVenda.Text = dgv.CurrentRow.Cells[10].Value.ToString();
                    frm.txtLote.Text = dgv.CurrentRow.Cells[8].Value.ToString();
                    frm.txtEstoq.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                    frm.dataProducao.Text = dgv.CurrentRow.Cells[6].Value.ToString();
                    frm.dataExp.Text = dgv.CurrentRow.Cells[7].Value.ToString();


                    frm.txtFarmaco.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                    frm.txtTipoFarmaco.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    frm.txtDescricao.Text = dgv.CurrentRow.Cells[11].Value.ToString();

                    if (dgv.CurrentRow.Cells[13].Value.ToString() == "Disponível")
                    {
                        frm.ckActivo.Checked = true;
                    }
                    else
                    {
                        frm.ckActivo.Checked = false;
                    }
                    DialogResult DialogResult = frm.ShowDialog();

                    if (DialogResult == DialogResult.Yes)
                    {
                        Listar();
                    }

                }
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnRestaurar.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dgv.Columns[e.ColumnIndex].Name == "EstoqDisp")
            {
                if (Convert.ToInt32(e.Value) <= 9)
                {
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.BackColor = Color.Orange;
                }

            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {
            if (txtPesquisar.Text != string.Empty && txtPesquisar.Text != "Procurar...")
            {
                PesquisarPor();
            }
            else
            {
                Listar();
            }
        }
    }
}
