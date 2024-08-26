namespace prj_emprestimo_03
{
    partial class frmemprestimo_03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmemprestimo_03));
            this.txt_vl_emi = new System.Windows.Forms.TextBox();
            this.lbl_nm_1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_rst_extensao = new System.Windows.Forms.Label();
            this.lbl_nm_4 = new System.Windows.Forms.Label();
            this.txt_rst_prest = new System.Windows.Forms.TextBox();
            this.lbl_nm_inf = new System.Windows.Forms.Label();
            this.nupprazo = new System.Windows.Forms.NumericUpDown();
            this.lbl_nm_3 = new System.Windows.Forms.Label();
            this.nuptaxa = new System.Windows.Forms.NumericUpDown();
            this.lbl_nm_inf0 = new System.Windows.Forms.Label();
            this.lbl_nm_2 = new System.Windows.Forms.Label();
            this.lbl_nm_5 = new System.Windows.Forms.Label();
            this.txt_total_pago = new System.Windows.Forms.TextBox();
            this.lbl_nm_6 = new System.Windows.Forms.Label();
            this.txt_juros_pago = new System.Windows.Forms.TextBox();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupprazo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuptaxa)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_vl_emi
            // 
            this.txt_vl_emi.BackColor = System.Drawing.SystemColors.Info;
            this.txt_vl_emi.Location = new System.Drawing.Point(167, 21);
            this.txt_vl_emi.Name = "txt_vl_emi";
            this.txt_vl_emi.Size = new System.Drawing.Size(175, 27);
            this.txt_vl_emi.TabIndex = 0;
            this.toolTip1.SetToolTip(this.txt_vl_emi, "Informe o valor do emprestimo");
            this.txt_vl_emi.TextChanged += new System.EventHandler(this.txt_vl_emi_TextChanged);
            this.txt_vl_emi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_vl_emi_KeyPress);
            // 
            // lbl_nm_1
            // 
            this.lbl_nm_1.AutoSize = true;
            this.lbl_nm_1.Location = new System.Drawing.Point(6, 25);
            this.lbl_nm_1.Name = "lbl_nm_1";
            this.lbl_nm_1.Size = new System.Drawing.Size(160, 19);
            this.lbl_nm_1.TabIndex = 1;
            this.lbl_nm_1.Text = "Valor do Emprestimo";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_rst_extensao);
            this.groupBox1.Controls.Add(this.lbl_nm_4);
            this.groupBox1.Controls.Add(this.txt_rst_prest);
            this.groupBox1.Controls.Add(this.lbl_nm_inf);
            this.groupBox1.Controls.Add(this.nupprazo);
            this.groupBox1.Controls.Add(this.lbl_nm_3);
            this.groupBox1.Controls.Add(this.nuptaxa);
            this.groupBox1.Controls.Add(this.lbl_nm_inf0);
            this.groupBox1.Controls.Add(this.lbl_nm_2);
            this.groupBox1.Controls.Add(this.lbl_nm_1);
            this.groupBox1.Controls.Add(this.txt_vl_emi);
            this.groupBox1.Location = new System.Drawing.Point(7, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 274);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados";
            // 
            // lbl_rst_extensao
            // 
            this.lbl_rst_extensao.BackColor = System.Drawing.Color.SeaShell;
            this.lbl_rst_extensao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_rst_extensao.Location = new System.Drawing.Point(10, 150);
            this.lbl_rst_extensao.Name = "lbl_rst_extensao";
            this.lbl_rst_extensao.Size = new System.Drawing.Size(332, 113);
            this.lbl_rst_extensao.TabIndex = 14;
            // 
            // lbl_nm_4
            // 
            this.lbl_nm_4.AutoSize = true;
            this.lbl_nm_4.Location = new System.Drawing.Point(110, 94);
            this.lbl_nm_4.Name = "lbl_nm_4";
            this.lbl_nm_4.Size = new System.Drawing.Size(139, 19);
            this.lbl_nm_4.TabIndex = 8;
            this.lbl_nm_4.Text = "Prestação Mensal";
            // 
            // txt_rst_prest
            // 
            this.txt_rst_prest.BackColor = System.Drawing.Color.SeaShell;
            this.txt_rst_prest.Enabled = false;
            this.txt_rst_prest.Location = new System.Drawing.Point(42, 116);
            this.txt_rst_prest.Name = "txt_rst_prest";
            this.txt_rst_prest.Size = new System.Drawing.Size(276, 27);
            this.txt_rst_prest.TabIndex = 7;
            this.txt_rst_prest.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbl_nm_inf
            // 
            this.lbl_nm_inf.AutoSize = true;
            this.lbl_nm_inf.Location = new System.Drawing.Point(260, 58);
            this.lbl_nm_inf.Name = "lbl_nm_inf";
            this.lbl_nm_inf.Size = new System.Drawing.Size(84, 19);
            this.lbl_nm_inf.TabIndex = 6;
            this.lbl_nm_inf.Text = "(em Anos)";
            // 
            // nupprazo
            // 
            this.nupprazo.BackColor = System.Drawing.SystemColors.Info;
            this.nupprazo.Location = new System.Drawing.Point(219, 54);
            this.nupprazo.Name = "nupprazo";
            this.nupprazo.Size = new System.Drawing.Size(40, 27);
            this.nupprazo.TabIndex = 5;
            // 
            // lbl_nm_3
            // 
            this.lbl_nm_3.AutoSize = true;
            this.lbl_nm_3.Location = new System.Drawing.Point(165, 58);
            this.lbl_nm_3.Name = "lbl_nm_3";
            this.lbl_nm_3.Size = new System.Drawing.Size(52, 19);
            this.lbl_nm_3.TabIndex = 4;
            this.lbl_nm_3.Text = "Prazo";
            // 
            // nuptaxa
            // 
            this.nuptaxa.BackColor = System.Drawing.SystemColors.Info;
            this.nuptaxa.Location = new System.Drawing.Point(71, 55);
            this.nuptaxa.Name = "nuptaxa";
            this.nuptaxa.Size = new System.Drawing.Size(38, 27);
            this.nuptaxa.TabIndex = 3;
            // 
            // lbl_nm_inf0
            // 
            this.lbl_nm_inf0.AutoSize = true;
            this.lbl_nm_inf0.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nm_inf0.Location = new System.Drawing.Point(110, 60);
            this.lbl_nm_inf0.Name = "lbl_nm_inf0";
            this.lbl_nm_inf0.Size = new System.Drawing.Size(24, 19);
            this.lbl_nm_inf0.TabIndex = 3;
            this.lbl_nm_inf0.Text = "%";
            // 
            // lbl_nm_2
            // 
            this.lbl_nm_2.AutoSize = true;
            this.lbl_nm_2.Location = new System.Drawing.Point(29, 59);
            this.lbl_nm_2.Name = "lbl_nm_2";
            this.lbl_nm_2.Size = new System.Drawing.Size(41, 19);
            this.lbl_nm_2.TabIndex = 2;
            this.lbl_nm_2.Text = "Taxa";
            // 
            // lbl_nm_5
            // 
            this.lbl_nm_5.AutoSize = true;
            this.lbl_nm_5.Location = new System.Drawing.Point(28, 287);
            this.lbl_nm_5.Name = "lbl_nm_5";
            this.lbl_nm_5.Size = new System.Drawing.Size(126, 19);
            this.lbl_nm_5.TabIndex = 10;
            this.lbl_nm_5.Text = "Valor Total Pago";
            // 
            // txt_total_pago
            // 
            this.txt_total_pago.BackColor = System.Drawing.Color.SeaShell;
            this.txt_total_pago.Enabled = false;
            this.txt_total_pago.Location = new System.Drawing.Point(7, 309);
            this.txt_total_pago.Name = "txt_total_pago";
            this.txt_total_pago.Size = new System.Drawing.Size(167, 27);
            this.txt_total_pago.TabIndex = 9;
            this.txt_total_pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nm_6
            // 
            this.lbl_nm_6.AutoSize = true;
            this.lbl_nm_6.Location = new System.Drawing.Point(224, 288);
            this.lbl_nm_6.Name = "lbl_nm_6";
            this.lbl_nm_6.Size = new System.Drawing.Size(101, 19);
            this.lbl_nm_6.TabIndex = 12;
            this.lbl_nm_6.Text = "Juros Pagos";
            // 
            // txt_juros_pago
            // 
            this.txt_juros_pago.BackColor = System.Drawing.Color.SeaShell;
            this.txt_juros_pago.Enabled = false;
            this.txt_juros_pago.Location = new System.Drawing.Point(197, 310);
            this.txt_juros_pago.Name = "txt_juros_pago";
            this.txt_juros_pago.Size = new System.Drawing.Size(160, 27);
            this.txt_juros_pago.TabIndex = 13;
            this.txt_juros_pago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_hora
            // 
            this.lbl_hora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_hora.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_hora.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.Black;
            this.lbl_hora.Location = new System.Drawing.Point(7, 401);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(350, 36);
            this.lbl_hora.TabIndex = 15;
            this.lbl_hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_calcular
            // 
            this.helpProvider1.SetHelpNavigator(this.btn_calcular, System.Windows.Forms.HelpNavigator.Index);
            this.btn_calcular.Image = global::prj_emprestimo_03.Properties.Resources.Calcular_Emprestimo;
            this.btn_calcular.Location = new System.Drawing.Point(7, 340);
            this.btn_calcular.Name = "btn_calcular";
            this.helpProvider1.SetShowHelp(this.btn_calcular, true);
            this.btn_calcular.Size = new System.Drawing.Size(75, 57);
            this.btn_calcular.TabIndex = 16;
            this.toolTip1.SetToolTip(this.btn_calcular, "Calcular Emprestimo");
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Image = global::prj_emprestimo_03.Properties.Resources.Limpar;
            this.btn_limpar.Location = new System.Drawing.Point(147, 341);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 56);
            this.btn_limpar.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btn_limpar, "Limpar");
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Image = global::prj_emprestimo_03.Properties.Resources.Sair;
            this.btn_sair.Location = new System.Drawing.Point(282, 340);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 56);
            this.btn_sair.TabIndex = 18;
            this.toolTip1.SetToolTip(this.btn_sair, "Sair ");
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\MOUTINHO\\Desktop\\Emprestimo\\Ajuda do Programa\\help_emprestimo.html.html";
            // 
            // frmemprestimo_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 444);
            this.ControlBox = false;
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_hora);
            this.Controls.Add(this.txt_juros_pago);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbl_nm_6);
            this.Controls.Add(this.txt_total_pago);
            this.Controls.Add(this.lbl_nm_5);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.Index);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmemprestimo_03";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Emprestimo";
            this.Load += new System.EventHandler(this.prj_emprestimo_03_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupprazo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuptaxa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_vl_emi;
        private System.Windows.Forms.Label lbl_nm_1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbl_nm_4;
        private System.Windows.Forms.TextBox txt_rst_prest;
        private System.Windows.Forms.Label lbl_nm_inf;
        private System.Windows.Forms.NumericUpDown nupprazo;
        private System.Windows.Forms.Label lbl_nm_3;
        private System.Windows.Forms.NumericUpDown nuptaxa;
        private System.Windows.Forms.Label lbl_nm_inf0;
        private System.Windows.Forms.Label lbl_nm_2;
        private System.Windows.Forms.TextBox txt_juros_pago;
        private System.Windows.Forms.Label lbl_nm_6;
        private System.Windows.Forms.Label lbl_nm_5;
        private System.Windows.Forms.TextBox txt_total_pago;
        private System.Windows.Forms.Label lbl_rst_extensao;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

