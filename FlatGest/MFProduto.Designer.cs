namespace FlatGest
{
    partial class MFProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnStock;
            System.Windows.Forms.Button btnEditar;
            System.Windows.Forms.Button btnNovo;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnPerfil = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.ProdutoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeProduto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeTipoFarmaco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Medida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomePais = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlImg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImgPesq = new System.Windows.Forms.PictureBox();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.barraTitulo = new System.Windows.Forms.Panel();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.btnSair = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            btnStock = new System.Windows.Forms.Button();
            btnEditar = new System.Windows.Forms.Button();
            btnNovo = new System.Windows.Forms.Button();
            this.pnPerfil.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPesq)).BeginInit();
            this.barraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStock
            // 
            btnStock.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            btnStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            btnStock.FlatAppearance.BorderSize = 0;
            btnStock.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            btnStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnStock.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnStock.ForeColor = System.Drawing.Color.White;
            btnStock.Image = global::FlatGest.Properties.Resources.add;
            btnStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStock.Location = new System.Drawing.Point(537, 536);
            btnStock.Name = "btnStock";
            btnStock.Size = new System.Drawing.Size(123, 38);
            btnStock.TabIndex = 35;
            btnStock.Text = " + Estoque";
            btnStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnStock.UseVisualStyleBackColor = false;
            btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btnEditar
            // 
            btnEditar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEditar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnEditar.ForeColor = System.Drawing.Color.White;
            btnEditar.Image = global::FlatGest.Properties.Resources.edit_5_32;
            btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnEditar.Location = new System.Drawing.Point(411, 536);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new System.Drawing.Size(105, 38);
            btnEditar.TabIndex = 33;
            btnEditar.Text = "Editar";
            btnEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            btnNovo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            btnNovo.FlatAppearance.BorderSize = 0;
            btnNovo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            btnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnNovo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnNovo.ForeColor = System.Drawing.Color.White;
            btnNovo.Image = global::FlatGest.Properties.Resources.add_24;
            btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnNovo.Location = new System.Drawing.Point(31, 67);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new System.Drawing.Size(105, 38);
            btnNovo.TabIndex = 31;
            btnNovo.Text = "Fármaco";
            btnNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnNovo.UseVisualStyleBackColor = false;
            btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // pnPerfil
            // 
            this.pnPerfil.Controls.Add(this.panel2);
            this.pnPerfil.Controls.Add(this.btnSair);
            this.pnPerfil.Controls.Add(this.label1);
            this.pnPerfil.Controls.Add(this.lblNome);
            this.pnPerfil.Controls.Add(this.pictureBox7);
            this.pnPerfil.Controls.Add(this.shapeContainer1);
            this.pnPerfil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnPerfil.Location = new System.Drawing.Point(0, 0);
            this.pnPerfil.Name = "pnPerfil";
            this.pnPerfil.Size = new System.Drawing.Size(1215, 748);
            this.pnPerfil.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dgv);
            this.panel2.Controls.Add(this.ImgPesq);
            this.panel2.Controls.Add(this.txtPesquisar);
            this.panel2.Controls.Add(this.barraTitulo);
            this.panel2.Controls.Add(this.panel14);
            this.panel2.Controls.Add(btnStock);
            this.panel2.Controls.Add(this.panel15);
            this.panel2.Controls.Add(this.panel16);
            this.panel2.Controls.Add(btnEditar);
            this.panel2.Controls.Add(btnNovo);
            this.panel2.Controls.Add(this.panel17);
            this.panel2.Controls.Add(this.shapeContainer2);
            this.panel2.Location = new System.Drawing.Point(98, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1029, 622);
            this.panel2.TabIndex = 12;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            this.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeight = 30;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdutoId,
            this.NomeProduto,
            this.NomeCateg,
            this.NomeTipoFarmaco,
            this.Medida,
            this.NomePais,
            this.UrlImg});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv.EnableHeadersVisualStyles = false;
            this.dgv.GridColor = System.Drawing.Color.SteelBlue;
            this.dgv.Location = new System.Drawing.Point(22, 153);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(66)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(983, 351);
            this.dgv.TabIndex = 75;
            // 
            // ProdutoId
            // 
            this.ProdutoId.DataPropertyName = "ProdutoId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ProdutoId.DefaultCellStyle = dataGridViewCellStyle2;
            this.ProdutoId.HeaderText = "Codigo";
            this.ProdutoId.Name = "ProdutoId";
            this.ProdutoId.ReadOnly = true;
            this.ProdutoId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ProdutoId.Width = 80;
            // 
            // NomeProduto
            // 
            this.NomeProduto.DataPropertyName = "NomeProduto";
            this.NomeProduto.HeaderText = "Fármaco";
            this.NomeProduto.Name = "NomeProduto";
            this.NomeProduto.ReadOnly = true;
            this.NomeProduto.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NomeProduto.Width = 200;
            // 
            // NomeCateg
            // 
            this.NomeCateg.DataPropertyName = "NomeCateg";
            this.NomeCateg.HeaderText = "Categoria";
            this.NomeCateg.Name = "NomeCateg";
            this.NomeCateg.ReadOnly = true;
            this.NomeCateg.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.NomeCateg.Width = 200;
            // 
            // NomeTipoFarmaco
            // 
            this.NomeTipoFarmaco.DataPropertyName = "NomeTipoFarmaco";
            this.NomeTipoFarmaco.HeaderText = "Tipo de Fármaco";
            this.NomeTipoFarmaco.Name = "NomeTipoFarmaco";
            this.NomeTipoFarmaco.ReadOnly = true;
            this.NomeTipoFarmaco.Width = 200;
            // 
            // Medida
            // 
            this.Medida.DataPropertyName = "Medida";
            this.Medida.HeaderText = "U. Medida";
            this.Medida.Name = "Medida";
            this.Medida.ReadOnly = true;
            // 
            // NomePais
            // 
            this.NomePais.DataPropertyName = "NomePais";
            this.NomePais.HeaderText = "País";
            this.NomePais.Name = "NomePais";
            this.NomePais.ReadOnly = true;
            this.NomePais.Width = 200;
            // 
            // UrlImg
            // 
            this.UrlImg.DataPropertyName = "UrlImg";
            this.UrlImg.HeaderText = "UrlImg";
            this.UrlImg.Name = "UrlImg";
            this.UrlImg.ReadOnly = true;
            this.UrlImg.Visible = false;
            // 
            // ImgPesq
            // 
            this.ImgPesq.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImgPesq.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImgPesq.Image = global::FlatGest.Properties.Resources.searching_magnifying_glass;
            this.ImgPesq.Location = new System.Drawing.Point(967, 76);
            this.ImgPesq.Name = "ImgPesq";
            this.ImgPesq.Size = new System.Drawing.Size(25, 25);
            this.ImgPesq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgPesq.TabIndex = 74;
            this.ImgPesq.TabStop = false;
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.BackColor = System.Drawing.Color.White;
            this.txtPesquisar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPesquisar.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.txtPesquisar.Location = new System.Drawing.Point(784, 84);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(210, 20);
            this.txtPesquisar.TabIndex = 58;
            this.txtPesquisar.Text = "Procurar...";
            this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter);
            this.txtPesquisar.Leave += new System.EventHandler(this.txtPesquisar_Leave);
            // 
            // barraTitulo
            // 
            this.barraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.barraTitulo.Controls.Add(this.btnMaximizar);
            this.barraTitulo.Controls.Add(this.btnRestaurar);
            this.barraTitulo.Controls.Add(this.btnMinimizar);
            this.barraTitulo.Controls.Add(this.btnFechar);
            this.barraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.barraTitulo.Location = new System.Drawing.Point(0, 0);
            this.barraTitulo.Name = "barraTitulo";
            this.barraTitulo.Size = new System.Drawing.Size(1029, 28);
            this.barraTitulo.TabIndex = 38;
            this.barraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.barraTitulo_MouseDown);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::FlatGest.Properties.Resources.expand_icon_18_64;
            this.btnMaximizar.Location = new System.Drawing.Point(968, 2);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(22, 24);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 72;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::FlatGest.Properties.Resources.restore_window_icon_18_64;
            this.btnRestaurar.Location = new System.Drawing.Point(968, 2);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(22, 24);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 71;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::FlatGest.Properties.Resources.Minimizar_64;
            this.btnMinimizar.Location = new System.Drawing.Point(935, 2);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(22, 24);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 73;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = global::FlatGest.Properties.Resources.x_mark_5_64;
            this.btnFechar.Location = new System.Drawing.Point(1003, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(22, 24);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnFechar.TabIndex = 70;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // panel14
            // 
            this.panel14.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel14.BackColor = System.Drawing.Color.Green;
            this.panel14.Location = new System.Drawing.Point(527, 536);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(10, 38);
            this.panel14.TabIndex = 34;
            // 
            // panel15
            // 
            this.panel15.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel15.BackColor = System.Drawing.Color.Green;
            this.panel15.Location = new System.Drawing.Point(401, 536);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(10, 38);
            this.panel15.TabIndex = 32;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.Color.Green;
            this.panel16.Location = new System.Drawing.Point(21, 67);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(10, 38);
            this.panel16.TabIndex = 30;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.Color.Green;
            this.panel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel17.Location = new System.Drawing.Point(0, 604);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1029, 18);
            this.panel17.TabIndex = 28;
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer2.Size = new System.Drawing.Size(1029, 622);
            this.shapeContainer2.TabIndex = 76;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape2
            // 
            this.lineShape2.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            this.lineShape2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape2.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape1";
            this.lineShape2.X1 = 783;
            this.lineShape2.X2 = 993;
            this.lineShape2.Y1 = 106;
            this.lineShape2.Y2 = 106;
            // 
            // btnSair
            // 
            this.btnSair.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.Image = global::FlatGest.Properties.Resources.cross_square_button;
            this.btnSair.Location = new System.Drawing.Point(1184, 5);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(25, 25);
            this.btnSair.TabIndex = 7;
            this.btnSair.TabStop = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(1068, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 30);
            this.label1.TabIndex = 11;
            this.label1.Text = "Farmaco";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Depth = 0;
            this.lblNome.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(61, 34);
            this.lblNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(132, 19);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Fortunato Cassule";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::FlatGest.Properties.Resources.user;
            this.pictureBox7.Location = new System.Drawing.Point(32, 31);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.TabIndex = 5;
            this.pictureBox7.TabStop = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1215, 748);
            this.shapeContainer1.TabIndex = 1;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lineShape1.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 32;
            this.lineShape1.X2 = 1178;
            this.lineShape1.Y1 = 61;
            this.lineShape1.Y2 = 61;
            // 
            // MFProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 748);
            this.Controls.Add(this.pnPerfil);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MFProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MFProduto";
            this.Load += new System.EventHandler(this.MFProduto_Load);
            this.pnPerfil.ResumeLayout(false);
            this.pnPerfil.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgPesq)).EndInit();
            this.barraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPerfil;
        private System.Windows.Forms.PictureBox btnSair;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialLabel lblNome;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdutoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeProduto;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeTipoFarmaco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Medida;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomePais;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlImg;
        private System.Windows.Forms.PictureBox ImgPesq;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Panel barraTitulo;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
    }
}