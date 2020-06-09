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
using static FlatGest.MEstoque;

namespace FlatGest
{
    public partial class FVenda : Form
    {

        private string _IdGlobal;
        private string _NomeGlobal;
        private string _CargoGlobal;
        private string _SenhaGlobal;

        private string _CaixaId;
        private string _ValorTotal;
        
        public string CaixaId
        {
            get { return _CaixaId; }
            set { _CaixaId = value; }
        }
        public string ValorTotal
        {
            get { return _ValorTotal; }
            set { _ValorTotal = value; }
        }
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

        private static FVenda instancia;

        // Função Estática  que pode ser herdada em outros formulários
        public static FVenda getInstancia(Funcionario dto)
        {

            if (instancia == null || instancia.IsDisposed)
                instancia = new FVenda(dto);
       
            else
                instancia.BringToFront();
            return instancia;
        }
        int Qt;

        Double precoV;
        public FVenda(Funcionario dto)
        {
            InitializeComponent();
            //FormFade.ShowAsyc(this); Exibir Form com lentidão
            this.dgv.Columns["Preco"].DefaultCellStyle.Format =  "C";
            this.dgv.Columns["Subtotal"].DefaultCellStyle.Format = "C";

            //lblNome.Text = dto.NomeCompleto;
            lblCaixaNr.Text = Convert.ToInt32(dto.CaixaId).ToString();
            lblCargo.Text = "Cargo: " + dto.Cargo;
            _IdGlobal = dto.FuncionarioId.ToString();
            lblCaixaFunc.Text = Convert.ToInt32(dto.CaixaFunc).ToString();
            lblAbertura.Text = dto.Abertura;
            lblId.Visible = false;
            lblCaixaFunc.Visible = false;
            lblValor.Visible = false;
            lblVenda.Text = Convert.ToInt32(dto.NrVenda).ToString();
            btnPlay.Visible = false;

        }

        private void FVenda_Load(object sender, EventArgs e)
        {            
            SomarItens();
            NrVenda();
            SomarTotal();        
        }

        private void txtPre()
        {
            if(txtPreco.Text!= "")
            {

                precoV = double.Parse(txtPreco.Text);
                txtPreco.Text = precoV.ToString(); ;
            }
            
        }

         //Método adicionar farmaco no carrinho
        private void AddCarrinho()
        {
            bool ok = false;

            if (dgv.Rows.Count > 0)
            {
                foreach (DataGridViewRow item in dgv.Rows)
                {
                    if (Convert.ToString(item.Cells[0].Value) == txtCod.Text)
                    {
                        item.Cells[4].Value = Convert.ToString(Convert.ToInt32(item.Cells[4].Value) + int.Parse(txtQtd.Text));
                        ok = true;
                    }
                }
                if (!ok)
                {
                    dgv.Rows.Add(txtCod.Text, txtProd.Text, txtDescri.Text, txtPrijs.Text, txtQtd.Text);
                    dgv.Refresh();

                    LimparCampos();
                }
            }
            else
            {
                dgv.Rows.Add(txtCod.Text, txtProd.Text, txtDescri.Text, txtPrijs.Text, txtQtd.Text);

                LimparCampos();

            }
            //Calculo do Subtotal
            foreach (DataGridViewRow item in dgv.Rows)
            {
                item.Cells[dgv.Columns["SubTotal"].Index].Value = Convert.ToString(
                    Convert.ToDouble(item.Cells[dgv.Columns["Preco"].Index].Value) * Convert.ToDouble(item.Cells[dgv.Columns["Qty"].Index].Value));
            }
        }

        // Método para Somar Total dos Produtos Adicionados
        private void SomarTotal() 
        {
            decimal valorTotal = 0;

            if(dgv.Rows.Count == 0)
            {
                lblTotal.Text = "0,00 Kz";
            }
            else
            {
                foreach (DataGridViewRow item in dgv.Rows)
                {
                    valorTotal = valorTotal + Convert.ToDecimal(item.Cells[6].Value);
                }

                //Formatação do Valor Total em Valor Monetário
                lblTotal.Text = valorTotal.ToString("C");
                lblValor.Text = valorTotal.ToString();

            }
           
                
        }
        // Método para Somar Total dos Produtos Adicionados
        private void SomarItens()
        {
            int TotalItens = 0;

            foreach (DataGridViewRow item in dgv.Rows)
            {
                TotalItens = TotalItens + Convert.ToInt32(item.Cells[4].Value);
            }
            if(TotalItens > 1)
            {
                lblItens.Text = TotalItens.ToString() + " Itens";
                //Convert.ToString(valorTotal);
            }
            else if(TotalItens == 1)
            {
                lblItens.Text = TotalItens.ToString() + " Item";
            }
            else
            {
                lblItens.Text = TotalItens.ToString()+ " Item";
            }

        }
        
        // Metodo ReserverPedido
        private void ReservarEstoque()
        {
            if(Convert.ToInt32(txtEstok.Text) < 1)
            {
                errorP.SetError(txtEstok, "Estoque Insuficiente");
            }
            else
            {
                if ((txtQtd.Text != string.Empty)&& Convert.ToInt32(txtEstok.Text) < 1)
                {

                    errorP.SetError(txtEstok, "Estoque Insuficiente");
                   
                }
                else
                {
                    BllEstoque bll = new BllEstoque();
                    Estoque dto = new Estoque();

                    dto.Operacao = "ReservarEstoque";
                    dto.Quantidade = Convert.ToInt32(txtQtd.Text);
                    dto.EstoqueId = Convert.ToInt32(txtCod.Text);
                    dto.FuncionarioId = Convert.ToInt32(_IdGlobal); //ID do funcionário

                    string retorno = bll.Atualizar(dto);
                    try
                    {
                        int id = Convert.ToInt32(retorno);
                        if ((id > 0) && (dto.FuncionarioId > 0))
                        {
                            AddCarrinho();
                            MEstoque f = new MEstoque(null,null, null,AcaoNaTela.Pesquisar);
                            MEstoqueOpera m = new MEstoqueOpera(); //
                            m.Lis();
                        }
                    }
                    catch
                    {
                        FNotificao.AlerForm(" Erro Ao Adicionar o Fármaco Nº: " + retorno.ToString(), TipoNotificacao.erro);
                    }
                }

            }

        }
        // Metodo Cancelar Pedido
        private void RetornoEstoque()
        {
            BllEstoque bll = new BllEstoque();
            Estoque dto = new Estoque();

            dto.Operacao = "RetornoEstoque";
            dto.Quantidade = Convert.ToInt32(dgv.CurrentRow.Cells[4].Value);
            dto.EstoqueId = Convert.ToInt32(dgv.CurrentRow.Cells[0].Value);
            dto.FuncionarioId = Convert.ToInt32(_IdGlobal); //Código do Funcionario
            string retorno = bll.Atualizar(dto);
            try
            {
                int id = Convert.ToInt32(retorno);
                if ((id > 0) && (dto.FuncionarioId > 0))
                {
                    RemoverIten();
                }
                
            }
            catch
            {
                FNotificao.AlerForm(retorno.ToString(),TipoNotificacao.erro);
            }
        }

        //Método para aumentar a quantidade
        private void MaisQtd()
        {
            if ((txtPreco.Text != "") && (txtQtd.Text != ""))
            {
                Qt = int.Parse(txtQtd.Text);

                int Stok = int.Parse(txtEstok.Text);

                if ((Qt == Stok - 1) || (Qt > Stok))
                {
                    Qt = Stok - 1;
                    txtQtd.Text = Qt.ToString();
                    //Subtotal();
                }
                else
                {
                    Qt = int.Parse(txtQtd.Text) + 1;
                    txtQtd.Text = Qt.ToString();
                    //Subtotal();
                }
            }


        }

        // Método para remover item no Carrinho
        private void RemoverIten() 
        {
            foreach (DataGridViewRow item in dgv.SelectedRows)
            {
                dgv.Rows.RemoveAt(item.Index);
            }
        }

        //Método Limpar Campos
        private void LimparCampos()
        {
            txtCod.Text = "";
            txtEstok.Text = "";
            txtQtd.Text = "1";
            txtProd.Text = "";
            txtDescri.Text = "";
            txtPreco.Text = "";
            errorP.Clear();
            picBox.SizeMode = PictureBoxSizeMode.CenterImage;
            picBox.Image = Image.FromFile(Application.StartupPath + "\\Imagens\\image_100px.png");
        }

        //Método Fechar Caixa
        private void FecharCaixa()
        {
            Funcionario dto = new Funcionario();
            BllCaixa bll = new BllCaixa();
            dto.Operacao = "FecharCaixa";
            dto.CaixaId = Convert.ToInt32(lblCaixaNr.Text);
            dto.FuncionarioId = Convert.ToInt32(_IdGlobal);
            dto.CaixaFunc = Convert.ToInt32(lblCaixaFunc.Text);
            string retorno = bll.FecharCaixa(dto);

            try
            {
                int CaixaId = Convert.ToInt32(retorno);
                FNotificao.AlerForm("Caixa Nº" + CaixaId.ToString() + " Encerrada Com Sucesso", TipoNotificacao.sucesso);
                this.Close();
            }
            catch
            {
                FNotificao.AlerForm("Erro Detalhes: " + retorno, TipoNotificacao.erro);
            }
        }

        // Método para Contar o Nr de Venda feita po Caixa
        private void NrVenda()
        {
            Venda dto = new Venda();
            BllVenda bll = new BllVenda();
            dto.Operacao = "IdVenda";
            dto.CaixaFunc = Convert.ToInt32(lblCaixaFunc.Text);
            string NrVenda = bll.GerarNrVenda(dto);
            try
            {
                int NrV = Convert.ToInt32(NrVenda);
              
                lblVenda.Text = NrV.ToString();


            }
            catch
            {
                FNotificao.AlerForm("Erro Ao Gerar Nr de Venda", TipoNotificacao.erro);
            }
        }

        //Método para Cadastrar Pedido
        public void CadastrarPedido()
        {
            try
            {
                Pedido dto = new Pedido();
                BllVenda bll = new BllVenda();
                dto.Operacao = "Pedido";
                int id;
                foreach (DataGridViewRow item in dgv.Rows)
                {
                    dto.EstoqueId = Convert.ToInt32(item.Cells[0].Value);
                    dto.PrecoVenda = Convert.ToDecimal(item.Cells[3].Value); ;
                    dto.Quantidade = Convert.ToInt32(item.Cells[4].Value);
            
                    string retorno = bll.CadastrarPedido(dto);

                   id = Convert.ToInt32(retorno);
                    dgv.Rows.Clear();
                    SomarItens();
                    SomarTotal();
                    dgv.Refresh();
                    NrVenda();
                    LimparCampos();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }

        private void CadastrarVenda()
        {
            Venda dto = new Venda();
            BllVenda bll = new BllVenda();

            dto.Operacao = "Venda";
            dto.CaixaFunc = Convert.ToInt32(lblCaixaFunc.Text);
            dto.ClienteId = 1;
            dto.TipoPagamento = 2;
            dto.ValorTotal = Convert.ToDecimal(lblValor.Text);

            string retorno = bll.Cadastrar(dto);
            try
            {

                int id = Convert.ToInt32(retorno);

                if (id > 0)
                {
                    CadastrarPedido();
                }
            }
            catch
            {
                FNotificao.AlerForm("Erro Ao Registrar a Venda "+ retorno.ToString(),TipoNotificacao.erro);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

            string resultado = FNotificao.AlertConfirm("Deseja Encerrar a Caixa?", TipoNotificacao.pergunta);

            if (resultado.Equals("1"))
            {
                //FecharCaixa();
                this.Hide();
                MEstoqueOpera m = new MEstoqueOpera();
                m.FecharMEstoque();  //fechar o formulario M-Estoque
            }
            else
            {
                return;
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if(dgv.Rows.Count > 0)
            {
                _CaixaId = lblCaixaFunc.Text;// CaixaFuncionarioId Capturado
                _ValorTotal = lblValor.Text; // Valor Total Capturado

                FFinalizar frm = new FFinalizar(_CaixaId, _ValorTotal);
                frm.ShowDialog();
            }
            else
            {
                FNotificao.AlerForm("Nenhum Item na Tela de Venda",TipoNotificacao.aviso);
            }
                    
        }

        private void btnPesq_Click(object sender, EventArgs e)
        {
            MEstoque f = MEstoque.getInstancia(AcaoNaTela.Pesquisar);
            MEstoqueOpera m = new MEstoqueOpera();// Carregar Método Listar do Menu Estoque    
            m.Lis(); // Método publico para listar
            f.Show();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtCod.Text == string.Empty)
            {
                errorP.SetError(txtCod, "!");
                FNotificao.AlerForm("Informe o Código do Fármaco", TipoNotificacao.aviso);

            }
            else if (txtQtd.Text == string.Empty)
            {
                errorP.SetError(txtQtd, "!");
                FNotificao.AlerForm("Informe a Quantidade desejada", TipoNotificacao.aviso);

            }
            else if (int.Parse(txtQtd.Text) > int.Parse(txtEstok.Text))
            {
                errorP.SetError(txtEstok, "!");
                FNotificao.AlerForm("Estoque disponível Insuficiente", TipoNotificacao.aviso);

            }
            else
            {
           
                ReservarEstoque();
                SomarTotal();
                SomarItens();
                LimparCampos();
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgv.RowCount == 0)
            {

                FNotificao.AlerForm("Não Existe Nenhum Fármaco na Tela", TipoNotificacao.info);

            }
            else
            {
               string  resultado = FNotificao.AlertConfirm("Deseja Eliminar o Fármaco Selecionado?", TipoNotificacao.pergunta);
              
                if (resultado == "1")
                {
                    RetornoEstoque();
                    SomarTotal();
                    SomarItens();
                    LimparCampos();
                }
            }
        }

        private void btnMais_Click(object sender, EventArgs e)
        {
            MaisQtd();
        }

        private void btnMenos_Click(object sender, EventArgs e)
        {
            if ((txtPreco.Text != "") && (txtQtd.Text != ""))
            {
                Qt = int.Parse(txtQtd.Text);


                if (Qt == 1)
                {
                    txtQtd.Text = "1";
                    //Subtotal();
                }
                else
                {
                    Qt = int.Parse(txtQtd.Text) - 1;
                    txtQtd.Text = Qt.ToString();
                    //Subtotal();
                }
            }
        }

        private void txtPreco_TextChanged(object sender, EventArgs e)
        {
            try
            {
                precoV = Double.Parse(txtPreco.Text);

                txtPreco.Text = precoV.ToString("C2");
            }
            catch
            {
                
            }
          
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            string resultado = FNotificao.AlertConfirm("Deseja Encerrar a Caixa?", TipoNotificacao.pergunta);

            if (resultado.Equals("1"))
            {
                FecharCaixa();
                MEstoqueOpera m = new MEstoqueOpera();
                m.FecharMEstoque();  //fechar o formulario M-Estoque
            }
            else
            {
                return;
            }

        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {

        } 

        private void btnPause_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = true;
            btnPause.Visible = false;
            lblPause.Text = "Continuar";
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPlay.Visible = false;
            btnPause.Visible = true;
            lblPause.Text = "Pause";
        }
    }
}
