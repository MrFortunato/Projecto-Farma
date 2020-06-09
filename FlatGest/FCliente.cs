using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace FlatGest
{
    public partial class FCliente : Form
    {
        private BindingSource bsGrid = new BindingSource();
        public FCliente(string Nome, string Id, string Cargo)
        {
            InitializeComponent();
            lblNome.Text = Nome + " | " + Cargo;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            FFCliente frm = new FFCliente(AcaoNaTela.Cadastrar);
            DialogResult DialogResult =  frm.ShowDialog();
            if(DialogResult== DialogResult.Yes)
            {
                ListarCliente();
            }


        }
        //------------------Método para Listar Clientes -----------------------
        private void ListarCliente()
        {
            Cliente dto = new Cliente();
            BllCliente bll = new BllCliente();
            dto.Operacao = "ListarCliente";

            try
            {
                DataTable dt = bll.ListarCliente(dto);
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

        private void FCliente_Load(object sender, EventArgs e)
        {
            ListarCliente();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            if (dgv.RowCount == 0)
            {
                FNotificao.AlerForm(" Nenhum Selecionado", TipoNotificacao.aviso);
            }
            else
            {
                string resultado = FNotificao.AlertConfirm("Deseja Editar os Dados do Cliente #" + dgv.CurrentRow.Cells["NomeCompleto"].Value.ToString() + "# ?", TipoNotificacao.pergunta);
                if (resultado == "1")
                {
                    FFCliente frm = new FFCliente(AcaoNaTela.Editar);
                    frm.txtCodigo.Text = dgv.CurrentRow.Cells["ClienteId"].Value.ToString();
                    frm.txtNome.Text = dgv.CurrentRow.Cells["NomeCompleto"].Value.ToString();
                    frm.txtTelf.Text = dgv.CurrentRow.Cells["Telf"].Value.ToString();
                    frm.txtEmail.Text = dgv.CurrentRow.Cells["Email"].Value.ToString();
                    frm.txtEndereco.Text = dgv.CurrentRow.Cells["Endereco"].Value.ToString();
                    if( dgv.CurrentRow.Cells["Estad"].Value.ToString() == "Activo")
                    {
                        frm.cbEstado.SelectedIndex = 1;
                    }
                    else
                    {
                        frm.cbEstado.SelectedIndex = 2;
                    }

                    DialogResult dialogResult = frm.ShowDialog();
                    if (dialogResult == DialogResult.Yes)
                    {
                        ListarCliente();
                    }

                }
            }
        }
    }
}
