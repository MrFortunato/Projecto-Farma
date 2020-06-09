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
    public partial class FSubCategoria : Form
    {
        public FSubCategoria()
        {
            InitializeComponent();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckActivo_CheckedChanged(object sender, EventArgs e)
        {
            if(ckActivo.Checked == true)
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

        private void FSubCategoria_Load(object sender, EventArgs e)
        {
            Listar();
            ckActivo.Checked = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }
        //Método Limpar campos
        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtSubCateg.Text = "";
            ckActivo.Checked = true;
            btnCadastrar.Text = "Cadastrar";
            errorP.Clear();

        }

   
  

        // Mecanismo para movimentar o formular
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void Cadastrar()
        {
            SubCategoria dto = new SubCategoria();
            BllSubCategoria bll = new BllSubCategoria();

            dto.Operacao = "Cadastrar";
            dto.NomeSubCateg = txtSubCateg.Text;

            if (ckActivo.Checked == true)
            {
                dto.Estado = true;
            }
            else
            {
                dto.Estado = false;
            }

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

        private void Listar()
        {
            SubCategoria dto = new SubCategoria();
            BllSubCategoria bll = new BllSubCategoria();

            dto.Operacao = "Listar";
            
            try
            {
                DataTable dt = bll.Listar(dto);
              
                dgv.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (btnCadastrar.Text == "Cadastrar")
            {
                if (txtSubCateg.Text == String.Empty)
                {
                    errorP.SetError(txtSubCateg, "Campo Obrigatório");
                }
                else if (ckActivo.Checked == false && ckInactivo.Checked == false)
                {
                    errorP.SetError(ckInactivo, "Campo Obrigatório");
                }
                else
                {
                    Cadastrar();
                }

            }
            else
            {
                if (txtSubCateg.Text == String.Empty)
                {
                    errorP.SetError(txtSubCateg, "Campo Obrigatório");
                }
                else if (ckActivo.Checked == false && ckInactivo.Checked == false)
                {
                    errorP.SetError(ckInactivo, "Campo Obrigatório");
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
            SubCategoria dto = new SubCategoria();
            BllSubCategoria bll = new BllSubCategoria();

            dto.SubCategoriaId = Convert.ToInt32(txtCodigo.Text);
            dto.Operacao = "Editar";
            dto.NomeSubCateg = txtSubCateg.Text;

            if (ckActivo.Checked == true)
            {
                dto.Estado = true;
            }
            else
            {
                dto.Estado = false;
            }

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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            btnCadastrar.Text = "Editar";
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtSubCateg.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();

            if (dgv.Rows[e.RowIndex].Cells[2].Value.ToString() == "Activo")
            {
                ckActivo.Checked = true;
                ckInactivo.Checked = false;
            }
            else
            {
                ckInactivo.Checked = true;
                ckActivo.Checked = false;
            }
        }

        private void barraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
