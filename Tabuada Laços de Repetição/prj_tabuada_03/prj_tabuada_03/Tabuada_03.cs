        #region Inicialização dos Componentes
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_tabuada_03
{
    public partial class Tabuada_03 : Form
    {
        public Tabuada_03()
        {
            InitializeComponent();
        }
#endregion
        #region Sair
        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion
        #region Laço FOR
        private void btn_for_Click(object sender, EventArgs e)
        {
            int valortabuada_b, inter_a, rst_c, i;
            valortabuada_b = int.Parse(txt_vl.Text);
            inter_a = int.Parse(txt_intervalo.Text);
            for (i = 1; i <= inter_a; i++)
            {
                rst_c = valortabuada_b * i;
                lbl_info_estrutura.BackColor = Color.Black;
                lbl_info_estrutura.Text = "Estrutura FOR";
                lbl_info_estrutura.Visible = true;
                lbl_rsp.BackColor = Color.White;
                lbl_rsp.BackColor = Color.Red;
                lbl_rsp.Text += valortabuada_b.ToString() + " x " + i.ToString() + " = " + rst_c.ToString() + "\n";
            }
        }
#endregion
        #region Limpar
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_vl.Text = ("");
            txt_intervalo.Text = ("");
            lbl_rsp.Text = ("");
            lbl_info_estrutura.Text = ("");
        }
        #endregion
        #region Laço WHILE
        private void btn_while_Click(object sender, EventArgs e)
        {
            int valortabuada_b, inter_a, rst_c, i;
            valortabuada_b = int.Parse(txt_vl.Text);
            inter_a = int.Parse(txt_intervalo.Text);
            for (i = 1; i <= inter_a; i++)
            {
                rst_c = valortabuada_b * i;
                lbl_info_estrutura.BackColor = Color.Black;
                lbl_info_estrutura.Text = "Estrutura WHILE";
                lbl_info_estrutura.Visible = true;
                lbl_rsp.BackColor = Color.White;
                lbl_rsp.BackColor = Color.Blue;
                lbl_rsp.Text += valortabuada_b.ToString() + " x " + i.ToString() + " = " + rst_c.ToString() + "\n";
            }
        }
        #endregion
        #region Laço DO...WHILE
        private void btn_do_while_Click(object sender, EventArgs e)
        {
            int valortabuada_b, inter_a, rst_c, i;
            valortabuada_b = int.Parse(txt_vl.Text);
            inter_a = int.Parse(txt_intervalo.Text);
            for (i = 1; i <= inter_a; i++)
            {
                rst_c = valortabuada_b * i;
                lbl_info_estrutura.BackColor = Color.Black;
                lbl_info_estrutura.Text = "Estrutura DO...WHILE";
                lbl_info_estrutura.Visible = true;
                lbl_rsp.BackColor = Color.White;
                lbl_rsp.BackColor = Color.Green;
                lbl_rsp.Text += valortabuada_b.ToString() + " x " + i.ToString() + " = " + rst_c.ToString() + "\n";
            }
       
        }

    }

}
        #endregion



