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

namespace FlatGest
{
    public partial class FPerfil : Form
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
        public FPerfil(string Nome, string Id, string Cargo)
        {
            InitializeComponent();

            _IdGlobal = Id;
            _NomeGlobal = Nome;
            _CargoGlobal= Cargo;
            lblNome.Text = _NomeGlobal + " | " + _CargoGlobal;
            
        }

        private void pnPerfil_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FPerfil_Load(object sender, EventArgs e)
        {
            DetalhesPerfil();
        }

        private void DetalhesPerfil()
        {
            Funcionario dto = new Funcionario();
            BllFuncionario bll = new BllFuncionario();

            dto.Operacao = "Perfil";
            dto.FuncionarioId = Convert.ToInt32(_IdGlobal);
            DataTable dt = bll.DetalhesContacto(dto);
            try
            {
                if(dt.Rows.Count!= 0)
                {
                    lbltelf.Text = "+ 244 " + dt.Rows[0]["Telf"].ToString();
                    lblEmail.Text = "Email: " + dt.Rows[0]["Email"].ToString();
                    lblEndereco.Text = "Endereço: " + dt.Rows[0]["Endereco"].ToString();
                    //lblEstado
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
