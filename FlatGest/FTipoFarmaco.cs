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
using BLL;
using DTO;

namespace FlatGest
{
    public partial class FTipoFarmaco : Form
    {
        public FTipoFarmaco()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FTipoFarmaco_Load(object sender, EventArgs e)
        {
            Listar();
            Carregar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(btnCadastrar.Text == "Cadastrar")
            {
                if (txtTipoFarmaco.Text == string.Empty)
                {
                    errorP.SetError(txtTipoFarmaco, "Campo Obrigatório");
                }
                else if (cbSubCateg.Text == string.Empty)
                {
                    errorP.SetError(cbSubCateg, "Campo Obrigatório");
                }
                else
                {
                    Cadastrar();
                }
            }
            else
            {
                if(txtCodigo.Text == string.Empty)
                {
                    errorP.SetError(txtCodigo, "Campo Obrigatório");
                }
                else if (txtTipoFarmaco.Text == string.Empty)
                {
                    errorP.SetError(txtTipoFarmaco, "Campo Obrigatório");
                }
                else if (cbSubCateg.Text == string.Empty)
                {
                    errorP.SetError(cbSubCateg, "Campo Obrigatório");
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

            TipoFarmaco dto = new TipoFarmaco();
            BllTipoFarmaco bll = new BllTipoFarmaco();

            dto.Operacao = "Editar";
            dto.TipoFarmacoId = Convert.ToInt32(txtCodigo.Text);
            dto.SubCategoriaId = Convert.ToInt32(cbSubCateg.SelectedValue);
            dto.NomeTipoFarmaco = txtTipoFarmaco.Text;

            string retorno = bll.Cadastrar(dto);
            try
            {
                //int CategoriaId = Convert.ToInt32(retorno);
                MessageBox.Show(retorno, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                Listar();

            }
            catch
            {
                MessageBox.Show("Erro ao Cadastrar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método Cadastrar Tipo de Farmaco
        private void Cadastrar()
        {
            TipoFarmaco dto = new TipoFarmaco();
            BllTipoFarmaco bll = new BllTipoFarmaco() ;

            dto.Operacao = "Cadastrar";
            dto.SubCategoriaId = Convert.ToInt32(cbSubCateg.SelectedValue);
            dto.NomeTipoFarmaco = txtTipoFarmaco.Text;     

            string retorno = bll.Cadastrar(dto);
            try
            {
                //int CategoriaId = Convert.ToInt32(retorno);
                MessageBox.Show(retorno, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                Listar();

            }
            catch
            {
                MessageBox.Show("Erro ao Cadastrar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Método Listar Grid
        private void Listar()
        {
            BllTipoFarmaco bll = new BllTipoFarmaco();
            TipoFarmaco dto = new TipoFarmaco();
            try
            {
                dto.Operacao = "Listar";
                DataTable dt = bll.Listar(dto);

                dgv.DataSource = dt;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Método Carregar Combo SubCategoria
        private void Carregar()
        {
            SubCategoria dto = new SubCategoria();
            BllSubCategoria  bll = new BllSubCategoria();
            try
            {
                dto.Operacao = "ListarCombo";
                DataTable dt = bll.Carregar(dto);
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "- Selecionar SubCategoria -";
                dt.Rows.InsertAt(topItem, 0);
                cbSubCateg.DataSource = dt;
                cbSubCateg.DisplayMember = "NomeSubCateg";
                cbSubCateg.ValueMember = "SubCategoriaId";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Método Limpar campos
        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtTipoFarmaco.Text = "";
            btnCadastrar.Text = "Cadastrar";
            errorP.Clear();

        }

        // Mecanismo para movimentar o formular
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        // Mecanismo para movimentar o formular
        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtTipoFarmaco.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbSubCateg.Text = dgv.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            btnCadastrar.Text = "Editar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {

        }

        private void barraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
