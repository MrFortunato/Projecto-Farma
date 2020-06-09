namespace FlatGest
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnProduto;
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnEncerrar = new System.Windows.Forms.PictureBox();
            this.MenuVerical = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnPerfil = new System.Windows.Forms.Button();
            this.pnSubMenu1 = new System.Windows.Forms.Panel();
            this.btnRetorioInd = new System.Windows.Forms.Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.btnRvenda = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnRelatorio = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCaixa = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFornecedor = new System.Windows.Forms.Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btnCliente = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.pnSubMenu = new System.Windows.Forms.Panel();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnFarmaco = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.FormFade = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            btnProduto = new System.Windows.Forms.Button();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).BeginInit();
            this.MenuVerical.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.pnSubMenu1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.pnSubMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.PanelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProduto
            // 
            btnProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            btnProduto.FlatAppearance.BorderSize = 0;
            btnProduto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProduto.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnProduto.ForeColor = System.Drawing.Color.White;
            btnProduto.Image = global::FlatGest.Properties.Resources.add;
            btnProduto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProduto.Location = new System.Drawing.Point(10, 115);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new System.Drawing.Size(210, 38);
            btnProduto.TabIndex = 0;
            btnProduto.Text = "Fármaco";
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += new System.EventHandler(this.btnProdutos_Click);
            btnProduto.MouseHover += new System.EventHandler(this.btnProduto_MouseHover);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.Green;
            this.BarraTitulo.Controls.Add(this.btnRestaurar);
            this.BarraTitulo.Controls.Add(this.btnMinimizar);
            this.BarraTitulo.Controls.Add(this.btnEncerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(1215, 38);
            this.BarraTitulo.TabIndex = 0;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::FlatGest.Properties.Resources.expand_icon_18_64;
            this.btnMaximizar.Location = new System.Drawing.Point(927, -1);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(25, 25);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 2;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::FlatGest.Properties.Resources.restore_window_icon_18_64;
            this.btnRestaurar.Location = new System.Drawing.Point(1147, 6);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(25, 25);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 1;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::FlatGest.Properties.Resources.Minimizar_64;
            this.btnMinimizar.Location = new System.Drawing.Point(1109, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 3;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnEncerrar
            // 
            this.btnEncerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEncerrar.Image = global::FlatGest.Properties.Resources.x_mark_5_64;
            this.btnEncerrar.Location = new System.Drawing.Point(1183, 6);
            this.btnEncerrar.Name = "btnEncerrar";
            this.btnEncerrar.Size = new System.Drawing.Size(25, 25);
            this.btnEncerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnEncerrar.TabIndex = 0;
            this.btnEncerrar.TabStop = false;
            this.btnEncerrar.Click += new System.EventHandler(this.btnEncerrar_Click);
            // 
            // MenuVerical
            // 
            this.MenuVerical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.MenuVerical.Controls.Add(this.pnMenu);
            this.MenuVerical.Controls.Add(this.btnSair);
            this.MenuVerical.Controls.Add(this.pnSubMenu);
            this.MenuVerical.Controls.Add(this.panel1);
            this.MenuVerical.Controls.Add(btnProduto);
            this.MenuVerical.Controls.Add(this.pictureBox1);
            this.MenuVerical.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuVerical.Location = new System.Drawing.Point(0, 38);
            this.MenuVerical.Name = "MenuVerical";
            this.MenuVerical.Size = new System.Drawing.Size(220, 650);
            this.MenuVerical.TabIndex = 1;
            // 
            // pnMenu
            // 
            this.pnMenu.Controls.Add(this.btnPerfil);
            this.pnMenu.Controls.Add(this.pnSubMenu1);
            this.pnMenu.Controls.Add(this.panel6);
            this.pnMenu.Controls.Add(this.btnRelatorio);
            this.pnMenu.Controls.Add(this.panel5);
            this.pnMenu.Controls.Add(this.btnCaixa);
            this.pnMenu.Controls.Add(this.panel4);
            this.pnMenu.Controls.Add(this.btnFuncionario);
            this.pnMenu.Controls.Add(this.panel3);
            this.pnMenu.Controls.Add(this.btnFornecedor);
            this.pnMenu.Controls.Add(this.panel13);
            this.pnMenu.Controls.Add(this.btnCliente);
            this.pnMenu.Location = new System.Drawing.Point(0, 277);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(220, 367);
            this.pnMenu.TabIndex = 1;
            // 
            // btnPerfil
            // 
            this.btnPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnPerfil.FlatAppearance.BorderSize = 0;
            this.btnPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPerfil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPerfil.ForeColor = System.Drawing.Color.White;
            this.btnPerfil.Image = global::FlatGest.Properties.Resources.user__1_;
            this.btnPerfil.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPerfil.Location = new System.Drawing.Point(10, 133);
            this.btnPerfil.Name = "btnPerfil";
            this.btnPerfil.Size = new System.Drawing.Size(210, 38);
            this.btnPerfil.TabIndex = 22;
            this.btnPerfil.Text = "Perfil";
            this.btnPerfil.UseVisualStyleBackColor = false;
            this.btnPerfil.Click += new System.EventHandler(this.btnPerfil_Click);
            // 
            // pnSubMenu1
            // 
            this.pnSubMenu1.Controls.Add(this.btnRetorioInd);
            this.pnSubMenu1.Controls.Add(this.panel11);
            this.pnSubMenu1.Controls.Add(this.btnRvenda);
            this.pnSubMenu1.Controls.Add(this.panel7);
            this.pnSubMenu1.Location = new System.Drawing.Point(34, 219);
            this.pnSubMenu1.Name = "pnSubMenu1";
            this.pnSubMenu1.Size = new System.Drawing.Size(186, 91);
            this.pnSubMenu1.TabIndex = 27;
            this.pnSubMenu1.Visible = false;
            this.pnSubMenu1.MouseLeave += new System.EventHandler(this.pnSubMenu1_MouseLeave);
            // 
            // btnRetorioInd
            // 
            this.btnRetorioInd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRetorioInd.FlatAppearance.BorderSize = 0;
            this.btnRetorioInd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRetorioInd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetorioInd.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetorioInd.ForeColor = System.Drawing.Color.White;
            this.btnRetorioInd.Image = global::FlatGest.Properties.Resources.give_money;
            this.btnRetorioInd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRetorioInd.Location = new System.Drawing.Point(11, 40);
            this.btnRetorioInd.Name = "btnRetorioInd";
            this.btnRetorioInd.Size = new System.Drawing.Size(175, 38);
            this.btnRetorioInd.TabIndex = 16;
            this.btnRetorioInd.Text = "Rel. Individual";
            this.btnRetorioInd.UseVisualStyleBackColor = false;
            this.btnRetorioInd.Click += new System.EventHandler(this.btnRetorioInd_Click);
            this.btnRetorioInd.MouseLeave += new System.EventHandler(this.btnRetorioInd_MouseLeave);
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.Green;
            this.panel11.Location = new System.Drawing.Point(1, 40);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(10, 38);
            this.panel11.TabIndex = 15;
            // 
            // btnRvenda
            // 
            this.btnRvenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRvenda.FlatAppearance.BorderSize = 0;
            this.btnRvenda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRvenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRvenda.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRvenda.ForeColor = System.Drawing.Color.White;
            this.btnRvenda.Image = global::FlatGest.Properties.Resources.dashboard;
            this.btnRvenda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRvenda.Location = new System.Drawing.Point(11, 0);
            this.btnRvenda.Name = "btnRvenda";
            this.btnRvenda.Size = new System.Drawing.Size(175, 38);
            this.btnRvenda.TabIndex = 12;
            this.btnRvenda.Text = "Fluxo Caixa";
            this.btnRvenda.UseVisualStyleBackColor = false;
            this.btnRvenda.Click += new System.EventHandler(this.btnRvenda_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Green;
            this.panel7.Location = new System.Drawing.Point(1, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 38);
            this.panel7.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Green;
            this.panel6.Location = new System.Drawing.Point(0, 178);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 38);
            this.panel6.TabIndex = 26;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnRelatorio.FlatAppearance.BorderSize = 0;
            this.btnRelatorio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorio.ForeColor = System.Drawing.Color.White;
            this.btnRelatorio.Image = global::FlatGest.Properties.Resources.statistics;
            this.btnRelatorio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorio.Location = new System.Drawing.Point(10, 178);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(210, 38);
            this.btnRelatorio.TabIndex = 23;
            this.btnRelatorio.Text = "Relatórios";
            this.btnRelatorio.UseVisualStyleBackColor = false;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            this.btnRelatorio.MouseHover += new System.EventHandler(this.btnRelatorio_MouseHover);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Green;
            this.panel5.Location = new System.Drawing.Point(0, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 38);
            this.panel5.TabIndex = 25;
            // 
            // btnCaixa
            // 
            this.btnCaixa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCaixa.FlatAppearance.BorderSize = 0;
            this.btnCaixa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCaixa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaixa.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaixa.ForeColor = System.Drawing.Color.White;
            this.btnCaixa.Image = global::FlatGest.Properties.Resources.cashier_machine__1_;
            this.btnCaixa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCaixa.Location = new System.Drawing.Point(10, 2);
            this.btnCaixa.Name = "btnCaixa";
            this.btnCaixa.Size = new System.Drawing.Size(210, 38);
            this.btnCaixa.TabIndex = 16;
            this.btnCaixa.Text = "Caixa";
            this.btnCaixa.UseVisualStyleBackColor = false;
            this.btnCaixa.Click += new System.EventHandler(this.btnCaixa_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Location = new System.Drawing.Point(0, 133);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 38);
            this.panel4.TabIndex = 24;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFuncionario.FlatAppearance.BorderSize = 0;
            this.btnFuncionario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFuncionario.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.ForeColor = System.Drawing.Color.White;
            this.btnFuncionario.Image = global::FlatGest.Properties.Resources.man_working_on_a_laptop_from_side_view__1_;
            this.btnFuncionario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFuncionario.Location = new System.Drawing.Point(10, 133);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(210, 38);
            this.btnFuncionario.TabIndex = 21;
            this.btnFuncionario.Text = "Funcionários";
            this.btnFuncionario.UseVisualStyleBackColor = false;
            this.btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Location = new System.Drawing.Point(0, 89);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 38);
            this.panel3.TabIndex = 19;
            // 
            // btnFornecedor
            // 
            this.btnFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFornecedor.FlatAppearance.BorderSize = 0;
            this.btnFornecedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFornecedor.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFornecedor.ForeColor = System.Drawing.Color.White;
            this.btnFornecedor.Image = global::FlatGest.Properties.Resources.delivery_truck;
            this.btnFornecedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFornecedor.Location = new System.Drawing.Point(10, 89);
            this.btnFornecedor.Name = "btnFornecedor";
            this.btnFornecedor.Size = new System.Drawing.Size(210, 38);
            this.btnFornecedor.TabIndex = 20;
            this.btnFornecedor.Text = "Fornecedores";
            this.btnFornecedor.UseVisualStyleBackColor = false;
            this.btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.Green;
            this.panel13.Location = new System.Drawing.Point(0, 46);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(10, 38);
            this.panel13.TabIndex = 17;
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.Color.White;
            this.btnCliente.Image = global::FlatGest.Properties.Resources.conference_32;
            this.btnCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCliente.Location = new System.Drawing.Point(10, 46);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(210, 38);
            this.btnCliente.TabIndex = 18;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = global::FlatGest.Properties.Resources.stand_by__1_;
            this.btnSair.Location = new System.Drawing.Point(8, 608);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(32, 32);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.btnSair.TabIndex = 0;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // pnSubMenu
            // 
            this.pnSubMenu.Controls.Add(this.btnCategoria);
            this.pnSubMenu.Controls.Add(this.panel8);
            this.pnSubMenu.Controls.Add(this.btnEstoque);
            this.pnSubMenu.Controls.Add(this.panel9);
            this.pnSubMenu.Controls.Add(this.btnFarmaco);
            this.pnSubMenu.Controls.Add(this.panel10);
            this.pnSubMenu.Location = new System.Drawing.Point(0, 155);
            this.pnSubMenu.Name = "pnSubMenu";
            this.pnSubMenu.Size = new System.Drawing.Size(218, 122);
            this.pnSubMenu.TabIndex = 16;
            this.pnSubMenu.Visible = false;
            // 
            // btnCategoria
            // 
            this.btnCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnCategoria.FlatAppearance.BorderSize = 0;
            this.btnCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoria.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoria.ForeColor = System.Drawing.Color.White;
            this.btnCategoria.Image = global::FlatGest.Properties.Resources.list;
            this.btnCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategoria.Location = new System.Drawing.Point(43, 82);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(175, 38);
            this.btnCategoria.TabIndex = 18;
            this.btnCategoria.Text = "Categoria";
            this.btnCategoria.UseVisualStyleBackColor = false;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            this.btnCategoria.MouseLeave += new System.EventHandler(this.btnCategoria_MouseLeave);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Green;
            this.panel8.Location = new System.Drawing.Point(33, 82);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 38);
            this.panel8.TabIndex = 17;
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Image = global::FlatGest.Properties.Resources.worker_loading_boxes__1_;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(43, 41);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(175, 38);
            this.btnEstoque.TabIndex = 16;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Green;
            this.panel9.Location = new System.Drawing.Point(33, 41);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(10, 38);
            this.panel9.TabIndex = 15;
            // 
            // btnFarmaco
            // 
            this.btnFarmaco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.btnFarmaco.FlatAppearance.BorderSize = 0;
            this.btnFarmaco.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btnFarmaco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFarmaco.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFarmaco.ForeColor = System.Drawing.Color.White;
            this.btnFarmaco.Image = global::FlatGest.Properties.Resources.drugs__4_;
            this.btnFarmaco.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFarmaco.Location = new System.Drawing.Point(43, 0);
            this.btnFarmaco.Name = "btnFarmaco";
            this.btnFarmaco.Size = new System.Drawing.Size(175, 38);
            this.btnFarmaco.TabIndex = 12;
            this.btnFarmaco.Text = "Farmaco";
            this.btnFarmaco.UseVisualStyleBackColor = false;
            this.btnFarmaco.Click += new System.EventHandler(this.btnFarmaco_Click);
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.Green;
            this.panel10.Location = new System.Drawing.Point(33, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(10, 38);
            this.panel10.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Location = new System.Drawing.Point(0, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 38);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 109);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PanelContainer
            // 
            this.PanelContainer.Controls.Add(this.btnMaximizar);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(220, 38);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(995, 650);
            this.PanelContainer.TabIndex = 3;
            // 
            // FormFade
            // 
            this.FormFade.Delay = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 688);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.MenuVerical);
            this.Controls.Add(this.BarraTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.BarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEncerrar)).EndInit();
            this.MenuVerical.ResumeLayout(false);
            this.MenuVerical.PerformLayout();
            this.pnMenu.ResumeLayout(false);
            this.pnSubMenu1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.pnSubMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.PanelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BarraTitulo;
        private System.Windows.Forms.Panel MenuVerical;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.PictureBox btnEncerrar;
        public System.Windows.Forms.Panel PanelContainer;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnPerfil;
        private System.Windows.Forms.Panel pnSubMenu1;
        private System.Windows.Forms.Button btnRetorioInd;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Button btnRvenda;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnRelatorio;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCaixa;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFornecedor;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel pnSubMenu;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button btnFarmaco;
        private System.Windows.Forms.Panel panel10;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormFade;
    }
}

