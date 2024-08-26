namespace prj_mdi
{
    partial class Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">verdade se for necessário descartar os recursos gerenciados; caso contrário, falso.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte do Designer - não modifique
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menu_principal = new System.Windows.Forms.MenuStrip();
            this.Menu_Arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Item1_submenu_arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Item2_submenu_arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Item3_submenu_arquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Aplicações_Abertas = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Janela = new System.Windows.Forms.ToolStripMenuItem();
            this.Item1_cascata_janela = new System.Windows.Forms.ToolStripMenuItem();
            this.Item2_horizontal_janela = new System.Windows.Forms.ToolStripMenuItem();
            this.Item3_vertical_janela = new System.Windows.Forms.ToolStripMenuItem();
            this.Item4_icones_minimizados_janela = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.iniciarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairDaAplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_principal.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_principal
            // 
            this.menu_principal.AutoSize = false;
            this.menu_principal.BackColor = System.Drawing.SystemColors.ControlText;
            this.menu_principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Arquivo,
            this.Menu_Aplicações_Abertas,
            this.Menu_Janela});
            this.menu_principal.Location = new System.Drawing.Point(0, 0);
            this.menu_principal.MdiWindowListItem = this.Menu_Aplicações_Abertas;
            this.menu_principal.Name = "menu_principal";
            this.menu_principal.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menu_principal.Size = new System.Drawing.Size(648, 24);
            this.menu_principal.TabIndex = 0;
            // 
            // Menu_Arquivo
            // 
            this.Menu_Arquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Item1_submenu_arquivo,
            this.Item2_submenu_arquivo,
            this.Item3_submenu_arquivo});
            this.Menu_Arquivo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Arquivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Menu_Arquivo.Name = "Menu_Arquivo";
            this.Menu_Arquivo.Size = new System.Drawing.Size(63, 20);
            this.Menu_Arquivo.Text = "Arquivo";
            // 
            // Item1_submenu_arquivo
            // 
            this.Item1_submenu_arquivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Item1_submenu_arquivo.Name = "Item1_submenu_arquivo";
            this.Item1_submenu_arquivo.Size = new System.Drawing.Size(111, 22);
            this.Item1_submenu_arquivo.Text = "Item 1";
            this.Item1_submenu_arquivo.Click += new System.EventHandler(this.Item1_submenu_arquivo_Click);
            // 
            // Item2_submenu_arquivo
            // 
            this.Item2_submenu_arquivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Item2_submenu_arquivo.Name = "Item2_submenu_arquivo";
            this.Item2_submenu_arquivo.Size = new System.Drawing.Size(111, 22);
            this.Item2_submenu_arquivo.Text = "Item 2";
            this.Item2_submenu_arquivo.Click += new System.EventHandler(this.Item2_submenu_arquivo_Click);
            // 
            // Item3_submenu_arquivo
            // 
            this.Item3_submenu_arquivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Item3_submenu_arquivo.Name = "Item3_submenu_arquivo";
            this.Item3_submenu_arquivo.Size = new System.Drawing.Size(111, 22);
            this.Item3_submenu_arquivo.Text = "Item 3";
            this.Item3_submenu_arquivo.Click += new System.EventHandler(this.Item3_submenu_arquivo_Click);
            // 
            // Menu_Aplicações_Abertas
            // 
            this.Menu_Aplicações_Abertas.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Aplicações_Abertas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Menu_Aplicações_Abertas.Name = "Menu_Aplicações_Abertas";
            this.Menu_Aplicações_Abertas.Size = new System.Drawing.Size(123, 20);
            this.Menu_Aplicações_Abertas.Text = "Aplicações Abertas";
            // 
            // Menu_Janela
            // 
            this.Menu_Janela.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Item1_cascata_janela,
            this.Item2_horizontal_janela,
            this.Item3_vertical_janela,
            this.Item4_icones_minimizados_janela});
            this.Menu_Janela.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Janela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Menu_Janela.Name = "Menu_Janela";
            this.Menu_Janela.Size = new System.Drawing.Size(110, 20);
            this.Menu_Janela.Text = "Modo de Janelas";
            // 
            // Item1_cascata_janela
            // 
            this.Item1_cascata_janela.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item1_cascata_janela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Item1_cascata_janela.Name = "Item1_cascata_janela";
            this.Item1_cascata_janela.Size = new System.Drawing.Size(199, 22);
            this.Item1_cascata_janela.Text = "Cascata";
            this.Item1_cascata_janela.Click += new System.EventHandler(this.Item1_cascata_janela_Click);
            // 
            // Item2_horizontal_janela
            // 
            this.Item2_horizontal_janela.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item2_horizontal_janela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Item2_horizontal_janela.Name = "Item2_horizontal_janela";
            this.Item2_horizontal_janela.Size = new System.Drawing.Size(199, 22);
            this.Item2_horizontal_janela.Text = "Lado a Lado Horizontal";
            this.Item2_horizontal_janela.Click += new System.EventHandler(this.Item2_horizontal_janela_Click);
            // 
            // Item3_vertical_janela
            // 
            this.Item3_vertical_janela.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item3_vertical_janela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Item3_vertical_janela.Name = "Item3_vertical_janela";
            this.Item3_vertical_janela.Size = new System.Drawing.Size(199, 22);
            this.Item3_vertical_janela.Text = "Lado a Lado Vertical";
            this.Item3_vertical_janela.Click += new System.EventHandler(this.Item3_vertical_janela_Click);
            // 
            // Item4_icones_minimizados_janela
            // 
            this.Item4_icones_minimizados_janela.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item4_icones_minimizados_janela.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Item4_icones_minimizados_janela.Name = "Item4_icones_minimizados_janela";
            this.Item4_icones_minimizados_janela.Size = new System.Drawing.Size(199, 22);
            this.Item4_icones_minimizados_janela.Text = "Ícones Minimizados";
            this.Item4_icones_minimizados_janela.Click += new System.EventHandler(this.Item4_icones_minimizados_janela_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Black;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 399);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(648, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // iniciarToolStripMenuItem
            // 
            this.iniciarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairDaAplicaçãoToolStripMenuItem});
            this.iniciarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciarToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.iniciarToolStripMenuItem.Image = global::prj_mdi.Properties.Resources.icone_menu_iniciar;
            this.iniciarToolStripMenuItem.Name = "iniciarToolStripMenuItem";
            this.iniciarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.iniciarToolStripMenuItem.Text = "Iniciar";
            // 
            // sairDaAplicaçãoToolStripMenuItem
            // 
            this.sairDaAplicaçãoToolStripMenuItem.BackColor = System.Drawing.Color.Black;
            this.sairDaAplicaçãoToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.sairDaAplicaçãoToolStripMenuItem.Image = global::prj_mdi.Properties.Resources.icone_sair2;
            this.sairDaAplicaçãoToolStripMenuItem.Name = "sairDaAplicaçãoToolStripMenuItem";
            this.sairDaAplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.sairDaAplicaçãoToolStripMenuItem.Text = "Sair da Aplicação";
            this.sairDaAplicaçãoToolStripMenuItem.Click += new System.EventHandler(this.sairDaAplicaçãoToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(648, 423);
            this.Controls.Add(this.menu_principal);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu_principal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
           // this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menu_principal.ResumeLayout(false);
            this.menu_principal.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu_principal;
        private System.Windows.Forms.ToolStripMenuItem Menu_Arquivo;
        private System.Windows.Forms.ToolStripMenuItem Item1_submenu_arquivo;
        private System.Windows.Forms.ToolStripMenuItem Item2_submenu_arquivo;
        private System.Windows.Forms.ToolStripMenuItem Item3_submenu_arquivo;
        private System.Windows.Forms.ToolStripMenuItem Menu_Aplicações_Abertas;
        private System.Windows.Forms.ToolStripMenuItem Menu_Janela;
        private System.Windows.Forms.ToolStripMenuItem Item1_cascata_janela;
        private System.Windows.Forms.ToolStripMenuItem Item2_horizontal_janela;
        private System.Windows.Forms.ToolStripMenuItem Item3_vertical_janela;
        private System.Windows.Forms.ToolStripMenuItem Item4_icones_minimizados_janela;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem iniciarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairDaAplicaçãoToolStripMenuItem;
    }
}

