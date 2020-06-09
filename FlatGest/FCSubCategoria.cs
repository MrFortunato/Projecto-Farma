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
    public partial class FCSubCategoria : Form
    {
        public FCSubCategoria()
        {
            InitializeComponent();
            ckActivo.Checked = true;

            if(txtCodigo.Text!= null)
            {
                lblTitulo.Text = "Editar Categoria - Sub";
                btnCadastrar.Text = "Editar";
            }
            else
            {
                lblTitulo.Text = "Registrar Categoria - Sub";
                btnCadastrar.Text = "Cadastrar";
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckActivo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckActivo.Checked == true)
            {
                ckInactivo.Checked = false;
            }
            else
            {
                ckInactivo.Checked = true;
            }
        }

        private void ckInactivo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckInactivo.Checked == true)
            {
                ckActivo.Checked = false;
            }
            else
            {
                ckActivo.Checked = true;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(btnCadastrar.Text == "Cadastrar")
            {
                if (cbCateg.Text == string.Empty)
                {
                    errorP.SetError(cbCateg, "Campo Obrigatório");
                }
                else if (cbSubCateg.Text == string.Empty)
                {
                    errorP.SetError(cbSubCateg, "Campo Obrigatório");
                }
                else if (ckActivo.Checked == false && ckInactivo.Checked == false)
                {
                    errorP.SetError(ckInactivo, "Selecionar Um dos Campos");
                }
                else
                {
                    Cadastrar();
                }

            }
            else
            {
                if (txtCodigo.Text == string.Empty)
                {
                    errorP.SetError(txtCodigo, "Campo Obrigatório");
                }
                else if (cbCateg.Text == string.Empty)
                {
                    errorP.SetError(cbCateg, "Campo Obrigatório");
                }
                else if (cbSubCateg.Text == string.Empty)
                {
                    errorP.SetError(cbSubCateg, "Campo Obrigatório");
                }
                else if (ckActivo.Checked == false && ckInactivo.Checked == false)
                {
                    errorP.SetError(ckInactivo, "Selecionar Um dos Campos");
                }
                else
                {
                    Editar();
                }
            }
           

        }

        //Método para Editar
        private void Editar()
        {
            Categ_SubCateg dto = new Categ_SubCateg();
            BllCategSubCategoria bll = new BllCategSubCategoria();
            dto.Operacao = "Editar";
            dto.CategSubId = Convert.ToInt32(txtCodigo.Text);
            dto.SubCategoriaId = Convert.ToInt32(cbSubCateg.SelectedValue);
            dto.CategoriaId = Convert.ToInt32(cbCateg.SelectedValue);

            if (ckActivo.Checked == true)
            {
                dto.Estado = true;
            }
            else
            {
                dto.Estado = false;
            }

            try
            {

                string retorno = bll.Cadastrar(dto);
                MessageBox.Show(retorno, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Carregar Combo Categoria
        private void cbCategoria()
        {
            BllCategoria bll = new BllCategoria();
            Categoria dto = new Categoria();
            try
            {
                dto.Operacao = "Listar";
                DataTable dt = bll.ListarCateg(dto);
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "- Selecionar Categoria -";
                dt.Rows.InsertAt(topItem, 0);
                cbCateg.DataSource = dt;

                cbCateg.DisplayMember = "NomeCateg";
                cbCateg.ValueMember = "CategoriaId";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Carregar Combo SubCategoria
        private void cbSubCategoria()
        {
            SubCategoria dto = new SubCategoria();
            BllSubCategoria bll = new BllSubCategoria();

            dto.Operacao = "Listar";

            try
            {
                DataTable dt = bll.Listar(dto);
                DataRow topItem = dt.NewRow();
                topItem[0] = 0;
                topItem[1] = "- Selecionar SubCategoria -";
                dt.Rows.InsertAt(topItem, 0);
                cbSubCateg.DataSource = dt;
                cbSubCateg.DisplayMember = "NomeSubCateg";
                cbSubCateg.ValueMember = "SubCategoriaId";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Listar Grid
        private void Listar()
        {
            BllCategSubCategoria bll = new BllCategSubCategoria();
            Categ_SubCateg dto = new Categ_SubCateg();
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

        // Método Limpar Campos
        private void LimparCampos()
        {
            txtCodigo.Text = "";
            cbCategoria();
            cbSubCategoria();
            ckActivo.Checked = true;
            btnCadastrar.Text = "Cadastrar";
            errorP.Clear();
        }

        //Método Cadastrar
        private void Cadastrar()
        {
            Categ_SubCateg dto = new Categ_SubCateg();
            BllCategSubCategoria bll = new BllCategSubCategoria();
            dto.Operacao = "Cadastrar";
            dto.SubCategoriaId = Convert.ToInt32(cbSubCateg.SelectedValue);
            dto.CategoriaId = Convert.ToInt32(cbCateg.SelectedValue);

            if (ckActivo.Checked == true)
            {
                dto.Estado = true;
            }
            else
            {
                dto.Estado = false;
            }

            try
            {

                string retorno = bll.Cadastrar(dto);
                MessageBox.Show(retorno, "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FCSubCategoria_Load(object sender, EventArgs e)
        {
            cbCategoria();
            Listar();
            cbSubCategoria();
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            cbCateg.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
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
    }
}
