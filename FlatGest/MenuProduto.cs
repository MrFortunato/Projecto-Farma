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

namespace FlatGest
{
    public partial class MenuProduto : Form
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
        public MenuProduto( string Nome, string Id , string Cargo)
        {
            InitializeComponent();
            _IdGlobal = Id;
            _NomeGlobal = Nome;
            _CargoGlobal = Cargo;
            lblNome.Text = _NomeGlobal + " | " + _CargoGlobal;
        }

        public void AbrirFormNoPanel(object formIn)
        {
            if (this.PanelProd.Controls.Count > 0)
                this.PanelProd.Controls.RemoveAt(0);
            Form fh = formIn as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.PanelProd.Controls.Add(fh);
            this.PanelProd.Tag = fh;
            fh.Show();
        }

        private void btnView_Click(object sender, EventArgs e)
        {      
           
            MEstoque frm = MEstoque.getInstancia(AcaoNaTela.Cadastrar);

            frm.IdGlobal = _IdGlobal;
            frm.NomeGlobal = _NomeGlobal;
            frm.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ////AbrirFormNoPanel(new MFProduto());
            //MFProduto frm = new MFProduto();
            //frm.IdGlobal = _IdGlobal;
            //frm.NomeGlobal = _NomeGlobal;
            //frm.Show();
       
        }

  
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            FCategoria frm = new FCategoria();
            frm.ShowDialog();
        }

        private void btnSubCateg_Click(object sender, EventArgs e)
        {
            FSubCategoria frm = new FSubCategoria();
            frm.ShowDialog();
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            FTipoFarmaco frm = new FTipoFarmaco();
            frm.ShowDialog();
        }

        private void btnSubCateSub_Click(object sender, EventArgs e)
        {
            FCSubCategoria frm = new FCSubCategoria();
            frm.ShowDialog();
        }
    }
}
