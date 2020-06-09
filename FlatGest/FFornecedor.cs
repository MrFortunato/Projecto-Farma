using DTO;
using System;
using System.Windows.Forms;
using BLL;
using System.Data;

namespace FlatGest
{
    public partial class FFornecedor : Form
    {
        private BindingSource bsGrid = new BindingSource();
        public FFornecedor(string Nome, string Id, string Cargo)
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
            FFFornecedor frm = new FFFornecedor(AcaoNaTela.Cadastrar);
            DialogResult dialogResult = frm.ShowDialog();
            if(dialogResult == DialogResult.Yes)
            {
                Listar();
            }
        }
        //Método Listar Fornecedor
        private void Listar()
        {
            Fornecedor dto = new Fornecedor();
            BllFornecedor bll = new BllFornecedor();
            dto.Operacao = "ListarFornecedor";
            try
            {
                DataTable dt = bll.Listar(dto);
                bsGrid.DataSource = dt;
                dgv.DataSource = bsGrid;
                dgv.Update();
                dgv.Refresh();
            }
            catch(Exception ex)
            {
                FNotificao.AlerForm(ex.Message, TipoNotificacao.erro);
            }
        }

        private void FFornecedor_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(dgv.Rows.Count == 0)
            {
                FNotificao.AlerForm("Nenhum Item Selecionado", TipoNotificacao.aviso);
            }
            else
            {
                FFFornecedor frm = new FFFornecedor(AcaoNaTela.Editar);

                string resultado = FNotificao.AlertConfirm("Deseja Editar os dados do Fornecedor "
                    + dgv.CurrentRow.Cells["NomeFornecedor"].Value.ToString()+"?", TipoNotificacao.pergunta);

                if (resultado.Equals("1"))
                {
                    frm.txtCodigo.Text = dgv.CurrentRow.Cells["FornecedorId"].Value.ToString();
                    frm.txtNome.Text = dgv.CurrentRow.Cells["NomeFornecedor"].Value.ToString();
                    frm.txtEndereco.Text = dgv.CurrentRow.Cells["Endereco"].Value.ToString();
                    frm.txtTelf.Text = dgv.CurrentRow.Cells["Telf"].Value.ToString();
                    frm.txtEmail.Text= dgv.CurrentRow.Cells["Email"].Value.ToString();

                    DialogResult dialogResult = frm.ShowDialog(); ;

                }
            }
        }
    }
}
