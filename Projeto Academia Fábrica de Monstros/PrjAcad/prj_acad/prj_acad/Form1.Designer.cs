namespace prj_acad
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
            this.gbx_matricula = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbn_noite = new System.Windows.Forms.RadioButton();
            this.rbn_tarde = new System.Windows.Forms.RadioButton();
            this.rbn_manha = new System.Windows.Forms.RadioButton();
            this.lbl_nm_dias = new System.Windows.Forms.Label();
            this.chklstbx_dias = new System.Windows.Forms.CheckedListBox();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.lbl_nm_nome = new System.Windows.Forms.Label();
            this.btn_calc_mensa = new System.Windows.Forms.Button();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.lbl_digito_matri = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_incluir = new System.Windows.Forms.Button();
            this.gpbx_modalidaes = new System.Windows.Forms.GroupBox();
            this.lbl_nm_selecionadas = new System.Windows.Forms.Label();
            this.lstbx_selecionadas = new System.Windows.Forms.ListBox();
            this.lstbx_modali = new System.Windows.Forms.ListBox();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.gbx_matricula.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbx_modalidaes.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_matricula
            // 
            this.gbx_matricula.Controls.Add(this.groupBox1);
            this.gbx_matricula.Controls.Add(this.lbl_nm_dias);
            this.gbx_matricula.Controls.Add(this.chklstbx_dias);
            this.gbx_matricula.Controls.Add(this.btn_limpar);
            this.gbx_matricula.Controls.Add(this.txt_nome);
            this.gbx_matricula.Controls.Add(this.lbl_nm_nome);
            this.gbx_matricula.Controls.Add(this.btn_calc_mensa);
            this.gbx_matricula.Controls.Add(this.txt_matricula);
            this.gbx_matricula.Controls.Add(this.lbl_digito_matri);
            this.gbx_matricula.Location = new System.Drawing.Point(6, 5);
            this.gbx_matricula.Name = "gbx_matricula";
            this.gbx_matricula.Size = new System.Drawing.Size(320, 204);
            this.gbx_matricula.TabIndex = 0;
            this.gbx_matricula.TabStop = false;
            this.gbx_matricula.Text = "Matrícula";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbn_noite);
            this.groupBox1.Controls.Add(this.rbn_tarde);
            this.groupBox1.Controls.Add(this.rbn_manha);
            this.groupBox1.Location = new System.Drawing.Point(171, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 97);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Periodo";
            // 
            // rbn_noite
            // 
            this.rbn_noite.AutoSize = true;
            this.rbn_noite.Location = new System.Drawing.Point(6, 69);
            this.rbn_noite.Name = "rbn_noite";
            this.rbn_noite.Size = new System.Drawing.Size(50, 17);
            this.rbn_noite.TabIndex = 11;
            this.rbn_noite.TabStop = true;
            this.rbn_noite.Text = "Noite";
            this.rbn_noite.UseVisualStyleBackColor = true;
            // 
            // rbn_tarde
            // 
            this.rbn_tarde.AutoSize = true;
            this.rbn_tarde.Location = new System.Drawing.Point(6, 46);
            this.rbn_tarde.Name = "rbn_tarde";
            this.rbn_tarde.Size = new System.Drawing.Size(53, 17);
            this.rbn_tarde.TabIndex = 10;
            this.rbn_tarde.TabStop = true;
            this.rbn_tarde.Text = "Tarde";
            this.rbn_tarde.UseVisualStyleBackColor = true;
            // 
            // rbn_manha
            // 
            this.rbn_manha.AutoSize = true;
            this.rbn_manha.Location = new System.Drawing.Point(6, 23);
            this.rbn_manha.Name = "rbn_manha";
            this.rbn_manha.Size = new System.Drawing.Size(58, 17);
            this.rbn_manha.TabIndex = 9;
            this.rbn_manha.TabStop = true;
            this.rbn_manha.Text = "Manhã";
            this.rbn_manha.UseVisualStyleBackColor = true;
            // 
            // lbl_nm_dias
            // 
            this.lbl_nm_dias.AutoSize = true;
            this.lbl_nm_dias.Location = new System.Drawing.Point(19, 84);
            this.lbl_nm_dias.Name = "lbl_nm_dias";
            this.lbl_nm_dias.Size = new System.Drawing.Size(92, 13);
            this.lbl_nm_dias.TabIndex = 7;
            this.lbl_nm_dias.Text = "Selecione os Dias";
            // 
            // chklstbx_dias
            // 
            this.chklstbx_dias.FormattingEnabled = true;
            this.chklstbx_dias.Items.AddRange(new object[] {
            "Segunda-Feira",
            "Terça-Feira",
            "Quarta-Feira",
            "Quinta-Feira",
            "Sexta-Feira",
            "Sábado"});
            this.chklstbx_dias.Location = new System.Drawing.Point(5, 102);
            this.chklstbx_dias.Name = "chklstbx_dias";
            this.chklstbx_dias.Size = new System.Drawing.Size(142, 94);
            this.chklstbx_dias.TabIndex = 6;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Image = global::prj_acad.Properties.Resources.Saki_Snowish_Actions_edit_clear;
            this.btn_limpar.Location = new System.Drawing.Point(210, 12);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(76, 37);
            this.btn_limpar.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btn_limpar, "Limpar Campos");
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nome.Location = new System.Drawing.Point(37, 55);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(249, 20);
            this.txt_nome.TabIndex = 3;
            // 
            // lbl_nm_nome
            // 
            this.lbl_nm_nome.AutoSize = true;
            this.lbl_nm_nome.Location = new System.Drawing.Point(2, 58);
            this.lbl_nm_nome.Name = "lbl_nm_nome";
            this.lbl_nm_nome.Size = new System.Drawing.Size(34, 13);
            this.lbl_nm_nome.TabIndex = 2;
            this.lbl_nm_nome.Text = "Aluno";
            // 
            // btn_calc_mensa
            // 
            this.btn_calc_mensa.Image = global::prj_acad.Properties.Resources.Aha_Soft_Universal_Shop_Cash_register;
            this.btn_calc_mensa.Location = new System.Drawing.Point(130, 12);
            this.btn_calc_mensa.Name = "btn_calc_mensa";
            this.btn_calc_mensa.Size = new System.Drawing.Size(74, 37);
            this.btn_calc_mensa.TabIndex = 4;
            this.toolTip1.SetToolTip(this.btn_calc_mensa, "Calcular Mensalidade");
            this.btn_calc_mensa.UseVisualStyleBackColor = true;
            this.btn_calc_mensa.Click += new System.EventHandler(this.btn_calc_mensa_Click);
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(70, 22);
            this.txt_matricula.MaxLength = 4;
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(50, 20);
            this.txt_matricula.TabIndex = 1;
            // 
            // lbl_digito_matri
            // 
            this.lbl_digito_matri.AutoSize = true;
            this.lbl_digito_matri.BackColor = System.Drawing.Color.White;
            this.lbl_digito_matri.Location = new System.Drawing.Point(2, 25);
            this.lbl_digito_matri.Name = "lbl_digito_matri";
            this.lbl_digito_matri.Size = new System.Drawing.Size(67, 13);
            this.lbl_digito_matri.TabIndex = 0;
            this.lbl_digito_matri.Text = "Nº Matrícula";
            // 
            // btn_sair
            // 
            this.btn_sair.Image = global::prj_acad.Properties.Resources.Hopstarter_Sleek_Xp_Software_Windows_Turn_Off;
            this.btn_sair.Location = new System.Drawing.Point(292, 393);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(36, 31);
            this.btn_sair.TabIndex = 17;
            this.toolTip1.SetToolTip(this.btn_sair, "Sair");
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Image = global::prj_acad.Properties.Resources.Visualpharm_Must_Have_Remove;
            this.btn_remover.Location = new System.Drawing.Point(136, 104);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(45, 36);
            this.btn_remover.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btn_remover, "Remove Modalidade");
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_incluir
            // 
            this.btn_incluir.Image = global::prj_acad.Properties.Resources.Cheezen_Web_2_Check;
            this.btn_incluir.Location = new System.Drawing.Point(135, 58);
            this.btn_incluir.Name = "btn_incluir";
            this.btn_incluir.Size = new System.Drawing.Size(46, 40);
            this.btn_incluir.TabIndex = 1;
            this.toolTip1.SetToolTip(this.btn_incluir, "Inclui Modalidade");
            this.btn_incluir.UseVisualStyleBackColor = true;
            this.btn_incluir.Click += new System.EventHandler(this.btn_incluir_Click);
            // 
            // gpbx_modalidaes
            // 
            this.gpbx_modalidaes.BackColor = System.Drawing.Color.White;
            this.gpbx_modalidaes.Controls.Add(this.lbl_nm_selecionadas);
            this.gpbx_modalidaes.Controls.Add(this.lstbx_selecionadas);
            this.gpbx_modalidaes.Controls.Add(this.btn_remover);
            this.gpbx_modalidaes.Controls.Add(this.btn_incluir);
            this.gpbx_modalidaes.Controls.Add(this.lstbx_modali);
            this.gpbx_modalidaes.ForeColor = System.Drawing.Color.Black;
            this.gpbx_modalidaes.Location = new System.Drawing.Point(6, 213);
            this.gpbx_modalidaes.Name = "gpbx_modalidaes";
            this.gpbx_modalidaes.Size = new System.Drawing.Size(320, 174);
            this.gpbx_modalidaes.TabIndex = 1;
            this.gpbx_modalidaes.TabStop = false;
            this.gpbx_modalidaes.Text = "Modalidades";
            // 
            // lbl_nm_selecionadas
            // 
            this.lbl_nm_selecionadas.AutoSize = true;
            this.lbl_nm_selecionadas.Location = new System.Drawing.Point(213, 13);
            this.lbl_nm_selecionadas.Name = "lbl_nm_selecionadas";
            this.lbl_nm_selecionadas.Size = new System.Drawing.Size(71, 13);
            this.lbl_nm_selecionadas.TabIndex = 14;
            this.lbl_nm_selecionadas.Text = "Selecionadas";
            // 
            // lstbx_selecionadas
            // 
            this.lstbx_selecionadas.FormattingEnabled = true;
            this.lstbx_selecionadas.Location = new System.Drawing.Point(189, 34);
            this.lstbx_selecionadas.Name = "lstbx_selecionadas";
            this.lstbx_selecionadas.Size = new System.Drawing.Size(120, 134);
            this.lstbx_selecionadas.TabIndex = 3;
            // 
            // lstbx_modali
            // 
            this.lstbx_modali.FormattingEnabled = true;
            this.lstbx_modali.Items.AddRange(new object[] {
            "Hidroginastica",
            "Judô",
            "Karâte",
            "Musculação",
            "Natação",
            "Ritmica",
            "Spinning"});
            this.lstbx_modali.Location = new System.Drawing.Point(6, 20);
            this.lstbx_modali.Name = "lstbx_modali";
            this.lstbx_modali.Size = new System.Drawing.Size(120, 147);
            this.lstbx_modali.TabIndex = 0;
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(4, 397);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(128, 18);
            this.lbl_total.TabIndex = 15;
            this.lbl_total.Text = "TOTAL A PAGAR";
            // 
            // lbl_valor
            // 
            this.lbl_valor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_valor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_valor.Location = new System.Drawing.Point(138, 393);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(135, 26);
            this.lbl_valor.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(333, 432);
            this.ControlBox = false;
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.gpbx_modalidaes);
            this.Controls.Add(this.gbx_matricula);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gym Fábrica de Monstros";
            this.gbx_matricula.ResumeLayout(false);
            this.gbx_matricula.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbx_modalidaes.ResumeLayout(false);
            this.gpbx_modalidaes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_matricula;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.Label lbl_nm_nome;
        private System.Windows.Forms.Button btn_calc_mensa;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.Label lbl_digito_matri;
        private System.Windows.Forms.RadioButton rbn_noite;
        private System.Windows.Forms.RadioButton rbn_tarde;
        private System.Windows.Forms.RadioButton rbn_manha;
        private System.Windows.Forms.Label lbl_nm_dias;
        private System.Windows.Forms.CheckedListBox chklstbx_dias;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gpbx_modalidaes;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_incluir;
        private System.Windows.Forms.ListBox lstbx_modali;
        private System.Windows.Forms.Label lbl_nm_selecionadas;
        private System.Windows.Forms.ListBox lstbx_selecionadas;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.Button btn_sair;

    }
}

