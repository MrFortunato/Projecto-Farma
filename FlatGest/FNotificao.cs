using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlatGest
{
    public partial class FNotificao : Form
    {
       
        private static string Button_id;
        public FNotificao(string msg,TipoNotificacao tipo)
        {
            InitializeComponent();
            lblmsg.Text = msg;
            
            // Notificação personalizada
            switch (tipo)
            {
                case TipoNotificacao.sucesso:
                    pnback.BackColor = Color.SeaGreen;
                    btnOk.BackColor = Color.SeaGreen;
                    btnOk.OnHovercolor = Color.SeaGreen;
                    btnOk.Normalcolor = Color.SeaGreen;
                    lbltitulo.Text = "CONFIRMAÇÃO";
                    btnNao.Visible = false;
                    picErro.Visible = false;
                    picInfo.Visible = false;
                    picPergunta.Visible = false;
                    picAviso.Visible = false;
                    //FormFade.ShowAsyc(this);
                    break;

                case TipoNotificacao.erro:
                    pnback.BackColor = Color.FromArgb(192, 0, 0); 
                    btnOk.BackColor = Color.FromArgb(192, 0, 0);
                    btnOk.OnHovercolor = Color.FromArgb(192, 0, 0);
                    btnOk.Normalcolor = Color.FromArgb(192, 0, 0);
                    lbltitulo.Text = "ERRO";
                    btnNao.Visible = false;
                  
                    PicSucesso.Visible = false;
                    picInfo.Visible = false;
                    picPergunta.Visible = false;
                    picAviso.Visible = false;
                    break;

                case TipoNotificacao.info:
                    pnback.BackColor = Color.FromArgb(66, 103, 178);
                    btnOk.BackColor = Color.FromArgb(66, 103, 178);
                    btnOk.OnHovercolor = Color.FromArgb(66, 103, 178);
                    btnOk.Normalcolor = Color.FromArgb(66, 103, 178);
                    lbltitulo.Text = "INFORMAÇÃO";
                    btnNao.Visible = false;
                    picErro.Visible = false;
                    PicSucesso.Visible = false;
                    picPergunta.Visible = false;
                    picAviso.Visible = false;
                    break;

                case TipoNotificacao.aviso:
                    pnback.BackColor = Color.FromArgb(255,128,0);
                    btnOk.BackColor = Color.FromArgb(255, 128, 0);
                    btnOk.OnHovercolor = Color.FromArgb(255, 128, 0);
                    btnOk.Normalcolor = Color.FromArgb(255, 128, 0);
                    btnNao.Visible = false;
                    lbltitulo.Text = "ALERTA";
                    picErro.Visible = false;
                    PicSucesso.Visible = false;
                    picPergunta.Visible = false;
                    picInfo.Visible = false;
                    break;

                case TipoNotificacao.pergunta:
                    pnback.BackColor = Color.Gray;
                    btnOk.BackColor = Color.SeaGreen;
                    btnOk.OnHovercolor = Color.SeaGreen;
                    btnOk.Normalcolor = Color.SeaGreen;               
                    btnOk.Location = new Point(17, 243);
                    btnNao.Location = new Point(145, 243);
                    lbltitulo.Text = "PERGUNTA";
                    btnOk.Text = "Sim";
                    picAviso.Visible = false;
                    picErro.Visible = false;
                    PicSucesso.Visible = false;
                    picInfo.Visible = false;                
         
                    break;

            }
            
        }

        private void FNotificao_Load(object sender, EventArgs e)
        {
            //FormFade.ShowAsyc(this);
        }
    
        public static void AlerForm(string msg, TipoNotificacao tipo)
        {
            FNotificao frm = new FNotificao(msg, tipo);
            frm.ShowDialog();
           
        }

        public static string AlertConfirm(string msg, TipoNotificacao tipo)
        {
            FNotificao frm = new FNotificao(msg, tipo);
            frm.ShowDialog();
            return Button_id;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
            if(btnOk.Text == "Sim")
            {
                Button_id = "1";
            }
            
        }

        private void btnNao_Click(object sender, EventArgs e)
        {
            this.Close();
            if(btnNao.Text == "Não")
            {
                Button_id = "2";
            }
                     
        }
    }
}
public enum TipoNotificacao
{
    sucesso, info, erro, aviso, pergunta
}
