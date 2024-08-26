using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_mdi
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        //\\//\\///\// MENU - ARQUIVO \\//\\//\\//\\//\\//

        #region Item 1 [MENU ARQUIVO]
        private void Item1_submenu_arquivo_Click(object sender, EventArgs e)
        {
            // Item1_menu_arquivo form = new Item1_menu_arquivo();
            // form.Show();

            Item1_menu_arquivo form = new Item1_menu_arquivo();
            form.MdiParent = this;
            form.Show();
        }
        #endregion

        #region Item 2 [MENU ARQUIVO]
        private void Item2_submenu_arquivo_Click(object sender, EventArgs e)
        {
            //  Item2_menu_arquivo form = new Item2_menu_arquivo();
            //  form.Show();

            Item2_menu_arquivo form = new Item2_menu_arquivo();
            form.MdiParent = this;
            form.Show();
        }
        #endregion

        #region Item 3 [MENU ARQUIVO]
        private void Item3_submenu_arquivo_Click(object sender, EventArgs e)
        {
            // Item3_menu_arquivo form = new Item3_menu_arquivo();
            //  form.Show();

            Item3_menu_arquivo form = new Item3_menu_arquivo();
            form.MdiParent = this;
            form.Show();
        }
        #endregion

        //\\//\\//\\//\\ MENU - JANELA /\\//\\//\\//\/\//

        #region OPÇÃO CASCATA
        private void Item1_cascata_janela_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
        #endregion

        #region OPÇÃO HORIZONTAL
        private void Item2_horizontal_janela_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }
        #endregion

        #region OPÇÃO VERTICAL
        private void Item3_vertical_janela_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }
        #endregion

        #region OPÇÃO ÍCONES MINIMIZADOS
        private void Item4_icones_minimizados_janela_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.ArrangeIcons);
        }
        #endregion

        #region Plano de Fundo MDI
        private void Principal_Load(object sender, EventArgs e)
        {
            MdiClient ctlMDI = (MdiClient)this.Controls[this.Controls.Count - 1];
            ctlMDI.BackColor = Color.Black;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //    .Text = DateTime.Now.ToString("HH:mm:ss");
        }
        #endregion

        #region SAIR
        private void sairDaAplicaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(" Deseja sair? ", "Aplicação MDI ", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion
    }

    }

       

        //\\//\\//\\//\\//\\//\\//\\////\\//\\//\\//\\//\\//\\//\\//

