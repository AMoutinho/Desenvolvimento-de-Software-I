namespace prj_tabuada_03
{
    partial class Tabuada_03
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tabuada_03));
            this.lbl_nm1 = new System.Windows.Forms.Label();
            this.txt_vl = new System.Windows.Forms.TextBox();
            this.txt_intervalo = new System.Windows.Forms.TextBox();
            this.lbl_nm2 = new System.Windows.Forms.Label();
            this.btn_for = new System.Windows.Forms.Button();
            this.btn_while = new System.Windows.Forms.Button();
            this.btn_sair = new System.Windows.Forms.Button();
            this.lbl_info_estrutura = new System.Windows.Forms.Label();
            this.lbl_rsp = new System.Windows.Forms.Label();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.btn_do_while = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nm1
            // 
            this.lbl_nm1.AutoSize = true;
            this.lbl_nm1.Location = new System.Drawing.Point(3, 7);
            this.lbl_nm1.Name = "lbl_nm1";
            this.lbl_nm1.Size = new System.Drawing.Size(104, 17);
            this.lbl_nm1.TabIndex = 0;
            this.lbl_nm1.Text = "Tabuada do Nº";
            // 
            // txt_vl
            // 
            this.txt_vl.Location = new System.Drawing.Point(126, 4);
            this.txt_vl.Name = "txt_vl";
            this.txt_vl.Size = new System.Drawing.Size(62, 22);
            this.txt_vl.TabIndex = 1;
            // 
            // txt_intervalo
            // 
            this.txt_intervalo.Location = new System.Drawing.Point(126, 32);
            this.txt_intervalo.Name = "txt_intervalo";
            this.txt_intervalo.Size = new System.Drawing.Size(62, 22);
            this.txt_intervalo.TabIndex = 3;
            // 
            // lbl_nm2
            // 
            this.lbl_nm2.AutoSize = true;
            this.lbl_nm2.Location = new System.Drawing.Point(3, 35);
            this.lbl_nm2.Name = "lbl_nm2";
            this.lbl_nm2.Size = new System.Drawing.Size(118, 17);
            this.lbl_nm2.TabIndex = 2;
            this.lbl_nm2.Text = "Vai do Nº 1 ao Nº";
            // 
            // btn_for
            // 
            this.btn_for.Location = new System.Drawing.Point(6, 101);
            this.btn_for.Name = "btn_for";
            this.btn_for.Size = new System.Drawing.Size(73, 23);
            this.btn_for.TabIndex = 4;
            this.btn_for.Text = "For";
            this.btn_for.UseVisualStyleBackColor = true;
            this.btn_for.Click += new System.EventHandler(this.btn_for_Click);
            // 
            // btn_while
            // 
            this.btn_while.Location = new System.Drawing.Point(89, 101);
            this.btn_while.Name = "btn_while";
            this.btn_while.Size = new System.Drawing.Size(73, 23);
            this.btn_while.TabIndex = 5;
            this.btn_while.Text = "While";
            this.btn_while.UseVisualStyleBackColor = true;
            this.btn_while.Click += new System.EventHandler(this.btn_while_Click);
            // 
            // btn_sair
            // 
            this.btn_sair.Location = new System.Drawing.Point(51, 422);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(155, 26);
            this.btn_sair.TabIndex = 11;
            this.btn_sair.Text = "Sair";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // lbl_info_estrutura
            // 
            this.lbl_info_estrutura.BackColor = System.Drawing.SystemColors.Info;
            this.lbl_info_estrutura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_info_estrutura.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_info_estrutura.ForeColor = System.Drawing.Color.White;
            this.lbl_info_estrutura.Location = new System.Drawing.Point(-3, 59);
            this.lbl_info_estrutura.Name = "lbl_info_estrutura";
            this.lbl_info_estrutura.Size = new System.Drawing.Size(264, 39);
            this.lbl_info_estrutura.TabIndex = 12;
            this.lbl_info_estrutura.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_rsp
            // 
            this.lbl_rsp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_rsp.Location = new System.Drawing.Point(6, 133);
            this.lbl_rsp.Name = "lbl_rsp";
            this.lbl_rsp.Size = new System.Drawing.Size(247, 282);
            this.lbl_rsp.TabIndex = 14;
            this.lbl_rsp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(194, 4);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(59, 50);
            this.btn_limpar.TabIndex = 13;
            this.btn_limpar.Text = "Limpar";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // btn_do_while
            // 
            this.btn_do_while.Location = new System.Drawing.Point(168, 101);
            this.btn_do_while.Name = "btn_do_while";
            this.btn_do_while.Size = new System.Drawing.Size(84, 23);
            this.btn_do_while.TabIndex = 6;
            this.btn_do_while.Text = "Do...While";
            this.btn_do_while.UseVisualStyleBackColor = true;
            this.btn_do_while.Click += new System.EventHandler(this.btn_do_while_Click);
            // 
            // Tabuada_03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 451);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_rsp);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.lbl_info_estrutura);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.btn_do_while);
            this.Controls.Add(this.btn_while);
            this.Controls.Add(this.btn_for);
            this.Controls.Add(this.txt_intervalo);
            this.Controls.Add(this.lbl_nm2);
            this.Controls.Add(this.txt_vl);
            this.Controls.Add(this.lbl_nm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Tabuada_03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabuada Laços";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nm1;
        private System.Windows.Forms.TextBox txt_vl;
        private System.Windows.Forms.TextBox txt_intervalo;
        private System.Windows.Forms.Label lbl_nm2;
        private System.Windows.Forms.Button btn_for;
        private System.Windows.Forms.Button btn_while;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Label lbl_info_estrutura;
        private System.Windows.Forms.Label lbl_rsp;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Button btn_do_while;
    }
}

