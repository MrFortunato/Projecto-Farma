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
    public partial class FFuncionarios : Form
    {
        private BindingSource bsGrid = new BindingSource();
        public FFuncionarios(string Nome, string Id, string Cargo)
        {
            InitializeComponent();
            lblNome.Text = Nome + " | " + Cargo;           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
            FFFuncionario frm = new FFFuncionario(AcaoNaTela.Cadastrar);      
            DialogResult dialogResultado = frm.ShowDialog();
            if (dialogResultado == DialogResult.Yes)
            {
                ListarFuncionario();
            }
        }
        //Método para Listar Funcionários 
        private void ListarFuncionario()
        {
            Funcionario dto = new Funcionario();
            BllFuncionario bll = new BllFuncionario();

            dto.Operacao = "ListarFuncionario";
            try
            {
                DataTable dt = bll.ListarFuncionarios(dto);
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

        private void FFuncionarios_Load(object sender, EventArgs e)
        {  
           
            ListarFuncionario();
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
                string result = FNotificao.AlertConfirm("Deseja Editar os dados do Funcionário #" + 
                    dgv.CurrentRow.Cells["NomeCompleto"].Value.ToString() + "# ?", TipoNotificacao.pergunta);
                if (result.Equals("1"))
                {
                    FFFuncionario frm = new FFFuncionario(AcaoNaTela.Editar);
                    frm.txtCodigo.Text = dgv.CurrentRow.Cells["FuncionarioId"].Value.ToString();
                    frm.txtNome.Text = dgv.CurrentRow.Cells["NomeCompleto"].Value.ToString();
                    frm.txtUsername.Text = dgv.CurrentRow.Cells["NomeUsuario"].Value.ToString();
                    frm.txtTelf.Text = dgv.CurrentRow.Cells["Telf"].Value.ToString();
                    frm.txtEmail.Text = dgv.CurrentRow.Cells["Email"].Value.ToString();
                    frm.txtEndereco.Text = dgv.CurrentRow.Cells["Endereco"].Value.ToString();
                    
                    if (dgv.CurrentRow.Cells["Cargo"].Value.ToString() == "Gerente")
                    {
                        frm.cbCargo.SelectedIndex = 1;
                    }
                    else
                    {
                        frm.cbCargo.SelectedIndex = 2;
                    }

                    if (dgv.CurrentRow.Cells["Estado"].Value.ToString() == "Activo")
                    {
                        frm.cbEstado.SelectedIndex = 1;
                    }
                    else
                    {
                        frm.cbEstado.SelectedIndex = 2;
                    }

                    DialogResult DialogResult = frm.ShowDialog();
                    if (DialogResult == DialogResult.Yes)
                    {
                        ListarFuncionario();
                    }

                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
