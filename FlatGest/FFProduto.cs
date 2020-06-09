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
using System.IO;
using System.Runtime.InteropServices;
using Bunifu;


namespace FlatGest
{
    public partial class FFProduto : Form
    {
        OpenFileDialog open = new OpenFileDialog();
        bool ImagemPadrao = true;
        string ImagemPrevious = "";
        int Id;
        public FFProduto(AcaoNaTela acaoNaTela)
        {
          
            InitializeComponent();
            cbCategoria();
          
            if (acaoNaTela == AcaoNaTela.Editar)
            {
                lblTitulo.Text = "Editar Fármaco";
                btnCadastrar.Text = "Editar";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //  Método carregar Categoria
        public void cbCategoria()
        {
            Categoria dto = new Categoria();
            BllCategoria bll = new BllCategoria();

            dto.Operacao = "ListarCombo";
            try
            {
                DataTable dt = bll.ListarCateg(dto);
                
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "-- Selecionar --";
                dt.Rows.InsertAt(topItem, 0);
                cbCateg.DataSource = dt;
                cbCateg.DisplayMember = "NomeCateg";
                cbCateg.ValueMember = "CategoriaId";
               

            }
            catch (Exception ex)
            {
                FNotificao.AlerForm(ex.Message, TipoNotificacao.erro);
            }
        }

        //Carregar SubCategoria
        private void cbSubCategoria()
        {
           
            Categ_SubCateg dto = new Categ_SubCateg();
            BllCategSubCategoria bll = new BllCategSubCategoria();

            dto.Operacao = "ListarCombo";
           
            try
            {

                dto.CategoriaId = Convert.ToInt32(cbCateg.SelectedValue);
                DataTable dt = bll.Carregar(dto);      
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "-- Selecionar --";
                dt.Rows.InsertAt(topItem, 0);
                cbSubCateg.DisplayMember = "NomeSubCateg";
                cbSubCateg.ValueMember = "SubCategoriaId";
                cbSubCateg.DataSource = dt;


            }
            catch (Exception ex)
            {
                FNotificao.AlerForm(ex.Message,TipoNotificacao.erro);
            }
        }

        //Carregar Combo TipoFarmaco
        private void cbTipoFarmaco()
        {
            TipoFarmaco dto = new TipoFarmaco();
            BllCategoria bll = new BllCategoria();
            dto.Operacao = "ListarTipoFarmaco";

            try
            {

                dto.SubCategoriaId = Convert.ToInt32(cbSubCateg.SelectedValue.ToString());
                DataTable dt = bll.ListarTipoFarmaco(dto);      
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "-- Selecionar --";
                dt.Rows.InsertAt(topItem, 0);
                cbTipoFarmco.DisplayMember = "NomeTipoFarmaco";
                cbTipoFarmco.ValueMember = "TipoFarmacoId";
                cbTipoFarmco.DataSource = dt;
            }
            catch (Exception ex)
            {
                FNotificao.AlerForm(ex.Message,TipoNotificacao.erro);
            }
        }

        //Método para Cadastrar
        private void Cadastrar()
        {
            Produto dto = new Produto();
            BllProduto bll = new BllProduto();

            dto.Operacao = "Cadastrar";
            dto.NomeProduto = txtProduto.Text;
            dto.TipoFarmacoId = Convert.ToInt32(cbTipoFarmco.SelectedValue);
            dto.CategoriaId = Convert.ToInt32(cbCateg.SelectedValue);
            dto.Medida = 1;
            dto.PaisOrigem = Convert.ToInt32(cbPais.SelectedValue);
            dto.UrlImg = SalvarImg(open.FileName) ;
            try
            {
                string retorno = bll.Cadastrar(dto);
                FNotificao.AlerForm(retorno, TipoNotificacao.sucesso);
                this.DialogResult = DialogResult.Yes;
                LimparCampos();
               
            }
            catch(Exception ex)
            {
                FNotificao.AlerForm(ex.Message, TipoNotificacao.erro);
                this.DialogResult = DialogResult.No;
            }
        }

        //Método para limpar campos
        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtProduto.Text = "";
            picBox.SizeMode = PictureBoxSizeMode.CenterImage;
            picBox.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\image_100px.png");
            ImagemPadrao = true;
            cbCategoria();
            cbSubCateg.DataSource = null;
            cbTipoFarmco.DataSource = null;
            cbMedida.DataSource = null;
            cbPais.DataSource = null;
        
        }
        //Método para carregar país
        private void CarregarCbPais()
        {
            BllProduto bll = new BllProduto();
            Produto dto = new Produto();
            dto.Operacao = "CarregarPais";
            try
            {

                //var dropdown = new Bunifu.Framework.UI.BunifuDropdown();
                DataTable dt = bll.CarregarPais(dto);
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "-- Selecionar --";
                dt.Rows.InsertAt(topItem, 0);
                cbPais.DisplayMember = "NomePais";
                cbPais.ValueMember = "PaisId";
                cbPais.DataSource = dt;

            }
            catch(Exception ex)
            {
                FNotificao.AlerForm(ex.Message,TipoNotificacao.erro);
            }
        }

        private void FFProduto_Load(object sender, EventArgs e)
        {    
           
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            if(btnCadastrar.Text == "Cadastrar")
            {
                if (txtProduto.Text == string.Empty)
                {
                    errorP.SetError(txtProduto, "Campo Obrigatório");
                }
                else if ((txtProduto.TextLength < 6) || (txtProduto.TextLength>  50))
                {
                    errorP.SetError(txtProduto, "Mínimo 6 e no máximo 50 caracteres");
                }
                else if (cbCateg.Text == string.Empty)
                {
                    errorP.SetError(cbCateg, "Campo Obrigatório");
                }
                else if (cbTipoFarmco.Text == string.Empty)
                {
                    errorP.SetError(cbTipoFarmco, "Campo Obrigatório");
                }
                else if (cbMedida.Text == string.Empty)
                {
                    errorP.SetError(cbMedida, "Campo Obrigatório");
                }
                else if (cbPais.Text == string.Empty)
                {
                    errorP.SetError(cbPais, "Campo Obrigatório");
                }
                else
                {
                    Cadastrar();
                }
            }
            else
            {
                if (txtCodigo.Text ==string.Empty)
                {
                    errorP.SetError(txtCodigo, "Campo Obrigatório");
                }
                else if (txtProduto.Text == string.Empty)
                {
                    errorP.SetError(txtProduto, "Campo Obrigatório");
                }
               
                else if (cbCateg.Text == string.Empty)
                {
                    errorP.SetError(cbCateg, "Campo Obrigatório");
                }
                else if (cbTipoFarmco.Text == string.Empty)
                {
                    errorP.SetError(cbTipoFarmco, "Campo Obrigatório");
                }
                else if (cbMedida.Text == string.Empty)
                {
                    errorP.SetError(cbMedida, "Campo Obrigatório");
                }
                else if (cbPais.Text == string.Empty)
                {
                    errorP.SetError(cbPais, "Campo Obrigatório");
                }
                else
                {
                    Editar();
                }
               
            }
           
        }

        //Método Editar
        private void Editar()
        {
            Produto dto = new Produto();
            BllProduto bll = new BllProduto();

            dto.Operacao = "Editar";
            dto.ProdutoId = Convert.ToInt32(txtCodigo.Text);        
            dto.NomeProduto = txtProduto.Text;
            dto.TipoFarmacoId = Convert.ToInt32(cbTipoFarmco.SelectedValue);
            dto.CategoriaId = Convert.ToInt32(cbCateg.SelectedValue);
            dto.Medida = 1;
            dto.PaisOrigem = Convert.ToInt32(cbPais.SelectedValue);
            dto.UrlImg = SalvarImg(open.FileName);
        
            try
            {
                string retorno = bll.Cadastrar(dto);
                FNotificao.AlerForm(retorno, TipoNotificacao.sucesso);
                this.DialogResult = DialogResult.Yes;
                LimparCampos();

            }
            catch (Exception ex)
            {
                FNotificao.AlerForm(ex.Message, TipoNotificacao.erro);
                this.DialogResult = DialogResult.No;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            btnCadastrar.Text = "Editar";
        }

        private void btnImg_Click(object sender, EventArgs e)
        {
            
            open.Filter = "(*.jpg;*.Jpeg;*.bmp;)|*.jpg;*.Jpeg;*.bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {
                picBox.Image = new Bitmap(open.FileName);
                ImagemPadrao = false;
                ImagemPrevious = "";
                picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        // Método para copiar a imagem na pasta de Imagens
        string SalvarImg(string _ImagPath)
        {
            string fileName = Path.GetFileNameWithoutExtension(_ImagPath); //Pegar no Nome da imagem sem a Extensão
            string extension = Path.GetExtension(_ImagPath); //Pegar a Extensão
            fileName = fileName.Length <= 15 ? fileName : fileName.Substring(0, 15); //Pegar apenas 15 caracter para no nome da Imagem
            fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;// Adicionar no Nome a data mais a Extensão
            picBox.Image.Save(Application.StartupPath + "\\Imagens\\" +fileName); // copiar na pastar
            return fileName;
        }

        private void cbSubCateg_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cbSubCateg.SelectedValue.ToString() != null)
            {
           
                cbTipoFarmaco();
            }
        }
        private void cbCateg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cbCateg.SelectedIndex)> 0)
            {
                cbSubCategoria();
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

        private void cbMedida_SelectionChangeCommitted(object sender, EventArgs e)
        {
            CarregarCbPais();
        }

        //private void Carrega()
        //{
        //    string[] items = { "Male", "Female", "Other" };
        //    foreach (var item in items)
        //    {
        //        bunifucb.AddItem(item);
        //    }

        //}

    }
}