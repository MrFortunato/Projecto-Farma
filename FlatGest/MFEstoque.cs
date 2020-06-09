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
    public partial class MFEstoque : Form
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
        public MFEstoque(string Nome, string Id, string Cargo, AcaoNaTela acaoNaTela)
        {
            InitializeComponent();
            _NomeGlobal = Nome;
            _IdGlobal = Id;
            _CargoGlobal = Cargo;

            lblNome.Text = _NomeGlobal + " | " + _CargoGlobal;

            // abrir o Form Estoque  dentro do Painel 
            if(acaoNaTela == AcaoNaTela.Cadastrar)
            {
                AbrirFormNoPanel(new MEstoque(_NomeGlobal, Id, _CargoGlobal, AcaoNaTela.Cadastrar));
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MFEstoque_Load(object sender, EventArgs e)
        {

        }

        // Método para receber Formulário Dentro do Panel
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
    }
}
