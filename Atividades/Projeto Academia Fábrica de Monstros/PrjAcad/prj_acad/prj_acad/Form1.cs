using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace prj_acad
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(splash));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void splash()
        {
            Application.Run(new splash());
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_matricula.Text = ("");
            txt_nome.Text = ("");
            lbl_valor.Text = ("");
            lstbx_modali.Text = ("");
            lstbx_selecionadas.Text = ("");
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair ?", "GYM Fábrica de Monstros", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }

        private void btn_incluir_Click(object sender, EventArgs e)
        {
            if (lstbx_modali.SelectedIndex != -1)
            {
                lstbx_selecionadas.Items.Add(lstbx_modali.SelectedItem);
                lstbx_modali.Items.Remove(lstbx_modali.SelectedItem);
            }
            else
            {
                MessageBox.Show("Escolha uma modalidade!");
            }
            btn_incluir.Enabled = false;
        }

        private void txtnome_TextChanged(object sender, EventArgs e)
        {
            btn_calc_mensa.Enabled = false;
            if (txt_nome.Text.Length == 4 && txt_nome.Text != "")
            {
                btn_calc_mensa.Enabled = true;
            }
        }
        private void btn_remover_Click(object sender, EventArgs e)
        {
            if (lstbx_selecionadas.SelectedIndex != -1)
            {
                lstbx_modali.Items.Add(lstbx_selecionadas.SelectedItem);
                lstbx_selecionadas.Items.Remove(lstbx_selecionadas.SelectedItem);
            }
            else
            {
                MessageBox.Show("Escolha uma modalidade!");
            }
            btn_remover.Enabled = false;
        }

        private void btn_calc_mensa_Click(object sender, EventArgs e)
        {
            if (chklstbx_dias.CheckedItems.Count == 0)
            {
                MessageBox.Show("Selecione um dia da semana...");
                return;
            }
            else if (lstbx_selecionadas.Items.Count == 0)
            {
                MessageBox.Show("Selecione uma modalidade...");
                return;
            }

            if (rbn_manha.Checked && (chklstbx_dias.CheckedItems.Count <= 2))
            {
                int d = 20 * chklstbx_dias.CheckedItems.Count;
                lbl_valor.Text = "R$" + d.ToString();
            }
            else if (rbn_manha.Checked && (chklstbx_dias.CheckedItems.Count > 2))
            {
                int d = 30 * chklstbx_dias.CheckedItems.Count;
                lbl_valor.Text = "R$" + d.ToString();
            }
            else if (rbn_tarde.Checked && (chklstbx_dias.CheckedItems.Count > 2))
            {
                int d = 30 * chklstbx_dias.CheckedItems.Count;
                lbl_valor.Text = "R$" + d.ToString();
            }
            else if (rbn_tarde.Checked && (chklstbx_dias.CheckedItems.Count <= 2))
            {
                int d = 18 * chklstbx_dias.CheckedItems.Count;
                lbl_valor.Text = "R$" + d.ToString();
            }
            else if (rbn_noite.Checked && (chklstbx_dias.CheckedItems.Count <= 2))
            {
                int d = 17 * chklstbx_dias.CheckedItems.Count;
                lbl_valor.Text = "R$" + d.ToString();
            }
            else if (rbn_tarde.Checked && (chklstbx_dias.CheckedItems.Count > 2))
            {
                int d = 30 * chklstbx_dias.CheckedItems.Count;
                lbl_valor.Text = "R$" + d.ToString();
            }
        }

        private void lstbx_modali_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_incluir.Enabled = true;
        }

        private void lstbx_selecionadas_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_remover.Enabled = true;
        }

        private void txt_matricula_Click(object sender, EventArgs e)
        {

            btn_calc_mensa.Enabled = false;
            if (txt_matricula.Text.Length == 4 && txt_nome.Text != "")
            {
                btn_calc_mensa.Enabled = true;
            }
        }
    }

}