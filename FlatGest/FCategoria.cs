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
    public partial class FCategoria : Form
    {
        private BindingSource bsGrid = new BindingSource();
        public FCategoria()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FCategoria_Load(object sender, EventArgs e)
        {
            Listar();
            ckActivo.Checked = true;
            Checkbuttons();



        }

        //Método Carregar DatagridView
        private void Listar()
        {
            Categoria dto = new Categoria();
            BllCategoria bll = new BllCategoria();

            try
            {
                dto.Operacao = "Listar";
                DataTable dt = bll.ListarCateg(dto);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgv.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCategoria.Text = dgv.Rows[e.RowIndex].Cells[1].Value.ToString();
            

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(btnCadastrar.Text == "Cadastrar")
            {
                if (txtCategoria.Text == string.Empty)
                {
                    errorP.SetError(txtCategoria, "Campo Obrigatório");
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
                if (txtCategoria.Text == String.Empty)
                {
                    errorP.SetError(txtCategoria, "Campo Obrigatório");
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

        //Método para Atualizar 
        private void Editar()
        {
            Categoria dto = new Categoria();
            BllCategoria bll = new BllCategoria();

            dto.CategoriaId = Convert.ToInt32(txtCodigo.Text);
            dto.Operacao = "Editar";
            dto.NomeCateg = txtCategoria.Text;

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

        private void PesquisarPor()
        {
            Categoria dto = new Categoria();
            BllCategoria bll = new BllCategoria();
            DataTable dt = new DataTable();

           
            int Codig;
            try
            {
                if(int.TryParse(txtPesquisar.Text, out Codig) == true)
                {
                    dto.Operacao = "ListarPor";
                    dto.CategoriaId = Codig;
                  
                }
                else
                {
                    dto.Operacao = "ListarPorNome";
                    dto.NomeCateg = txtPesquisar.Text;                
                }

                dt = bll.PesquisarPor(dto);
                bsGrid.DataSource = dt;
                dgv.DataSource = bsGrid;
                dgv.Update();
                dgv.Refresh();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount == 0)
            {

                MessageBox.Show("Não Existe Nenhum Item na Tela", "Atenção");

            }
            else
            {
                DialogResult result = MessageBox.Show("Deseja Eliminar o Item Selecionado?", "Aviso",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    //RemoverIten();
                    //SomarTotal();
                }
            }
        }

        //Método para Cadastrar
        private void Cadastrar()
        {
            Categoria dto = new Categoria();
            BllCategoria bll = new BllCategoria();

            dto.Operacao = "Cadastrar";
            dto.NomeCateg = txtCategoria.Text;

            if(ckActivo.Checked == true)
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
                MessageBox.Show(retorno,"Informação", MessageBoxButtons.OK,MessageBoxIcon.Information);
                LimparCampos();
                Listar();

            }
            catch
            {
                MessageBox.Show("Erro ao Cadastrar. Detalhes: " + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Método limpar campos
        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtCategoria.Text = "";
            ckActivo.Checked = true;
            btnCadastrar.Text = "Cadastrar";
            errorP.Clear();
        }

        // Validações CheckBox
        private void Checkbuttons()
        {
            if(ckActivo.Checked == true)
            {
                ckInactivo.Checked = false;
            }
            else
            {
                ckActivo.Checked = false;
            }
          
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

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            btnCadastrar.Text = "Editar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            if(txtPesquisar.Text == "Procurar...")
            {
                txtPesquisar.Text = "";
                ImgPesq.Visible = false;
            }
        }

        private void txtPesquisar_Leave(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "")
            {
                txtPesquisar.Text = "Procurar...";
                ImgPesq.Visible = true;
            }
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(txtPesquisar.Text!= string.Empty)
            {
                PesquisarPor();
            }
            else
            {
                Listar();
            }
        }

        private void txtCodigo_TextChanged_1(object sender, EventArgs e)
        {
            btnCadastrar.Text = "Editar";
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

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {

        }
    }
}
