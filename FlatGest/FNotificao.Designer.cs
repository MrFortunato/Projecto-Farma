namespace FlatGest
{
    partial class FNotificao
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.FormFade = new Bunifu.Framework.UI.BunifuFormFadeTransition(this.components);
            this.pnback = new System.Windows.Forms.Panel();
            this.picAviso = new System.Windows.Forms.PictureBox();
            this.picPergunta = new System.Windows.Forms.PictureBox();
            this.picInfo = new System.Windows.Forms.PictureBox();
            this.picErro = new System.Windows.Forms.PictureBox();
            this.PicSucesso = new System.Windows.Forms.PictureBox();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.lblmsg = new System.Windows.Forms.Label();
            this.btnOk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnNao = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.moveForm = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnback.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAviso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPergunta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSucesso)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 6;
            this.bunifuElipse1.TargetControl = this;
            // 
            // FormFade
            // 
            this.FormFade.Delay = 1;
            // 
            // pnback
            // 
            this.pnback.BackColor = System.Drawing.Color.SeaGreen;
            this.pnback.Controls.Add(this.picAviso);
            this.pnback.Controls.Add(this.picPergunta);
            this.pnback.Controls.Add(this.picInfo);
            this.pnback.Controls.Add(this.picErro);
            this.pnback.Controls.Add(this.PicSucesso);
            this.pnback.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnback.Location = new System.Drawing.Point(0, 0);
            this.pnback.Name = "pnback";
            this.pnback.Size = new System.Drawing.Size(262, 115);
            this.pnback.TabIndex = 0;
            // 
            // picAviso
            // 
            this.picAviso.Image = global::FlatGest.Properties.Resources.exclamation_sign;
            this.picAviso.Location = new System.Drawing.Point(85, 12);
            this.picAviso.Name = "picAviso";
            this.picAviso.Size = new System.Drawing.Size(90, 90);
            this.picAviso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAviso.TabIndex = 4;
            this.picAviso.TabStop = false;
            // 
            // picPergunta
            // 
            this.picPergunta.Image = global::FlatGest.Properties.Resources.question_mark_on_a_circular_black_background;
            this.picPergunta.Location = new System.Drawing.Point(85, 12);
            this.picPergunta.Name = "picPergunta";
            this.picPergunta.Size = new System.Drawing.Size(90, 90);
            this.picPergunta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPergunta.TabIndex = 3;
            this.picPergunta.TabStop = false;
            // 
            // picInfo
            // 
            this.picInfo.Image = global::FlatGest.Properties.Resources.information;
            this.picInfo.Location = new System.Drawing.Point(84, 12);
            this.picInfo.Name = "picInfo";
            this.picInfo.Size = new System.Drawing.Size(90, 90);
            this.picInfo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picInfo.TabIndex = 2;
            this.picInfo.TabStop = false;
            // 
            // picErro
            // 
            this.picErro.Image = global::FlatGest.Properties.Resources.cancel1;
            this.picErro.Location = new System.Drawing.Point(85, 12);
            this.picErro.Name = "picErro";
            this.picErro.Size = new System.Drawing.Size(90, 90);
            this.picErro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picErro.TabIndex = 1;
            this.picErro.TabStop = false;
            // 
            // PicSucesso
            // 
            this.PicSucesso.Image = global::FlatGest.Properties.Resources._checked;
            this.PicSucesso.Location = new System.Drawing.Point(84, 12);
            this.PicSucesso.Name = "PicSucesso";
            this.PicSucesso.Size = new System.Drawing.Size(90, 90);
            this.PicSucesso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicSucesso.TabIndex = 0;
            this.PicSucesso.TabStop = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.Location = new System.Drawing.Point(20, 128);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(225, 28);
            this.lbltitulo.TabIndex = 1;
            this.lbltitulo.Text = "SUCESSO";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblmsg
            // 
            this.lblmsg.Font = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmsg.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblmsg.Location = new System.Drawing.Point(12, 165);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(238, 69);
            this.lblmsg.TabIndex = 2;
            this.lblmsg.Text = "Venda Efetuada com Sucesso!!!";
            this.lblmsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnOk
            // 
            this.btnOk.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnOk.BackColor = System.Drawing.Color.SeaGreen;
            this.btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOk.BorderRadius = 7;
            this.btnOk.ButtonText = "Ok";
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DisabledColor = System.Drawing.Color.Gray;
            this.btnOk.Iconcolor = System.Drawing.Color.Transparent;
            this.btnOk.Iconimage = null;
            this.btnOk.Iconimage_right = null;
            this.btnOk.Iconimage_right_Selected = null;
            this.btnOk.Iconimage_Selected = null;
            this.btnOk.IconMarginLeft = 0;
            this.btnOk.IconMarginRight = 0;
            this.btnOk.IconRightVisible = true;
            this.btnOk.IconRightZoom = 0D;
            this.btnOk.IconVisible = true;
            this.btnOk.IconZoom = 90D;
            this.btnOk.IsTab = false;
            this.btnOk.Location = new System.Drawing.Point(79, 243);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Normalcolor = System.Drawing.Color.SeaGreen;
            this.btnOk.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.btnOk.OnHoverTextColor = System.Drawing.Color.White;
            this.btnOk.selected = false;
            this.btnOk.Size = new System.Drawing.Size(100, 36);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "Ok";
            this.btnOk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnOk.Textcolor = System.Drawing.Color.White;
            this.btnOk.TextFont = new System.Drawing.Font("Leelawadee", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnNao
            // 
            this.btnNao.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNao.BorderRadius = 0;
            this.btnNao.ButtonText = "Não";
            this.btnNao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNao.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNao.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNao.Iconimage = null;
            this.btnNao.Iconimage_right = null;
            this.btnNao.Iconimage_right_Selected = null;
            this.btnNao.Iconimage_Selected = null;
            this.btnNao.IconMarginLeft = 0;
            this.btnNao.IconMarginRight = 0;
            this.btnNao.IconRightVisible = true;
            this.btnNao.IconRightZoom = 0D;
            this.btnNao.IconVisible = true;
            this.btnNao.IconZoom = 90D;
            this.btnNao.IsTab = false;
            this.btnNao.Location = new System.Drawing.Point(79, 243);
            this.btnNao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNao.Name = "btnNao";
            this.btnNao.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNao.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNao.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNao.selected = false;
            this.btnNao.Size = new System.Drawing.Size(100, 36);
            this.btnNao.TabIndex = 4;
            this.btnNao.Text = "Não";
            this.btnNao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNao.Textcolor = System.Drawing.Color.White;
            this.btnNao.TextFont = new System.Drawing.Font("Leelawadee", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNao.Click += new System.EventHandler(this.btnNao_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 7;
            this.bunifuElipse2.TargetControl = this.btnNao;
            // 
            // moveForm
            // 
            this.moveForm.Fixed = true;
            this.moveForm.Horizontal = true;
            this.moveForm.TargetControl = this.pnback;
            this.moveForm.Vertical = true;
            // 
            // FNotificao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(262, 307);
            this.Controls.Add(this.btnNao);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.lbltitulo);
            this.Controls.Add(this.pnback);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FNotificao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FNotificao";
            this.Load += new System.EventHandler(this.FNotificao_Load);
            this.pnback.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAviso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPergunta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picErro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicSucesso)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuFormFadeTransition FormFade;
        private Bunifu.Framework.UI.BunifuFlatButton btnOk;
        private System.Windows.Forms.Label lblmsg;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Panel pnback;
        private System.Windows.Forms.PictureBox PicSucesso;
        private System.Windows.Forms.PictureBox picErro;
        private System.Windows.Forms.PictureBox picPergunta;
        private System.Windows.Forms.PictureBox picInfo;
        private System.Windows.Forms.PictureBox picAviso;
        private Bunifu.Framework.UI.BunifuFlatButton btnNao;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl moveForm;
    }
}