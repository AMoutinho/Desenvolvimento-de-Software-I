namespace prjTexto
{
    partial class frmTexto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTexto));
            this.lblqtd = new System.Windows.Forms.Label();
            this.lblpatharquivo = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPerg = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.lblE = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.r4 = new System.Windows.Forms.RadioButton();
            this.btnProxima = new System.Windows.Forms.Button();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAlternativa4 = new System.Windows.Forms.TextBox();
            this.txtAlternativa3 = new System.Windows.Forms.TextBox();
            this.txtAlternativa2 = new System.Windows.Forms.TextBox();
            this.txtAlternativa1 = new System.Windows.Forms.TextBox();
            this.txtpergunta = new System.Windows.Forms.TextBox();
            this.tabResp = new System.Windows.Forms.TabPage();
            this.txtErradas = new System.Windows.Forms.TextBox();
            this.txtCertas = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuestaoCerta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResposta = new System.Windows.Forms.TextBox();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnLer = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPerg.SuspendLayout();
            this.tabResp.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblqtd
            // 
            this.lblqtd.AutoSize = true;
            this.lblqtd.Location = new System.Drawing.Point(19, 3);
            this.lblqtd.Name = "lblqtd";
            this.lblqtd.Size = new System.Drawing.Size(30, 13);
            this.lblqtd.TabIndex = 18;
            this.lblqtd.Text = "QTD";
            // 
            // lblpatharquivo
            // 
            this.lblpatharquivo.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpatharquivo.Location = new System.Drawing.Point(4, 31);
            this.lblpatharquivo.Name = "lblpatharquivo";
            this.lblpatharquivo.Size = new System.Drawing.Size(466, 26);
            this.lblpatharquivo.TabIndex = 16;
            this.lblpatharquivo.Text = "Mostrando o Arquivo Texto Selecionado";
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPerg);
            this.tabControl1.Controls.Add(this.tabResp);
            this.tabControl1.Location = new System.Drawing.Point(3, 170);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(470, 219);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPerg
            // 
            this.tabPerg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPerg.Controls.Add(this.label8);
            this.tabPerg.Controls.Add(this.lblE);
            this.tabPerg.Controls.Add(this.lblC);
            this.tabPerg.Controls.Add(this.txtE);
            this.tabPerg.Controls.Add(this.label5);
            this.tabPerg.Controls.Add(this.label4);
            this.tabPerg.Controls.Add(this.txtC);
            this.tabPerg.Controls.Add(this.progressBar1);
            this.tabPerg.Controls.Add(this.r4);
            this.tabPerg.Controls.Add(this.btnProxima);
            this.tabPerg.Controls.Add(this.r3);
            this.tabPerg.Controls.Add(this.r2);
            this.tabPerg.Controls.Add(this.r1);
            this.tabPerg.Controls.Add(this.lblqtd);
            this.tabPerg.Controls.Add(this.label1);
            this.tabPerg.Controls.Add(this.txtAlternativa4);
            this.tabPerg.Controls.Add(this.txtAlternativa3);
            this.tabPerg.Controls.Add(this.txtAlternativa2);
            this.tabPerg.Controls.Add(this.txtAlternativa1);
            this.tabPerg.Controls.Add(this.txtpergunta);
            this.tabPerg.Location = new System.Drawing.Point(4, 4);
            this.tabPerg.Name = "tabPerg";
            this.tabPerg.Padding = new System.Windows.Forms.Padding(5);
            this.tabPerg.Size = new System.Drawing.Size(462, 193);
            this.tabPerg.TabIndex = 0;
            this.tabPerg.Text = "Perguntas";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(388, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 11);
            this.label8.TabIndex = 29;
            this.label8.Text = "%";
            // 
            // lblE
            // 
            this.lblE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblE.Location = new System.Drawing.Point(417, 23);
            this.lblE.Name = "lblE";
            this.lblE.Size = new System.Drawing.Size(40, 11);
            this.lblE.TabIndex = 28;
            // 
            // lblC
            // 
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(340, 23);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(33, 11);
            this.lblC.TabIndex = 27;
            // 
            // txtE
            // 
            this.txtE.BackColor = System.Drawing.Color.Bisque;
            this.txtE.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtE.Location = new System.Drawing.Point(421, 1);
            this.txtE.Name = "txtE";
            this.txtE.ReadOnly = true;
            this.txtE.Size = new System.Drawing.Size(29, 20);
            this.txtE.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(377, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Errada";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(304, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Certa";
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.Bisque;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.Location = new System.Drawing.Point(342, 1);
            this.txtC.Name = "txtC";
            this.txtC.ReadOnly = true;
            this.txtC.Size = new System.Drawing.Size(29, 20);
            this.txtC.TabIndex = 23;
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.Bisque;
            this.progressBar1.ForeColor = System.Drawing.Color.Red;
            this.progressBar1.Location = new System.Drawing.Point(14, 36);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(436, 11);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 17;
            // 
            // r4
            // 
            this.r4.AutoSize = true;
            this.r4.Location = new System.Drawing.Point(16, 168);
            this.r4.Name = "r4";
            this.r4.Size = new System.Drawing.Size(31, 17);
            this.r4.TabIndex = 22;
            this.r4.TabStop = true;
            this.r4.Text = "4";
            this.r4.UseVisualStyleBackColor = true;
            // 
            // btnProxima
            // 
            this.btnProxima.Image = global::prjTexto.Properties.Resources.user_go;
            this.btnProxima.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnProxima.Location = new System.Drawing.Point(176, 2);
            this.btnProxima.Name = "btnProxima";
            this.btnProxima.Size = new System.Drawing.Size(45, 28);
            this.btnProxima.TabIndex = 15;
            this.btnProxima.Text = "Ler";
            this.btnProxima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProxima.UseVisualStyleBackColor = true;
            this.btnProxima.Click += new System.EventHandler(this.btnProxima_Click);
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Location = new System.Drawing.Point(16, 142);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(31, 17);
            this.r3.TabIndex = 21;
            this.r3.TabStop = true;
            this.r3.Text = "3";
            this.r3.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(17, 115);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(31, 17);
            this.r2.TabIndex = 20;
            this.r2.TabStop = true;
            this.r2.Text = "2";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Location = new System.Drawing.Point(17, 89);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(31, 17);
            this.r1.TabIndex = 19;
            this.r1.TabStop = true;
            this.r1.Text = "1";
            this.r1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Perguntas";
            // 
            // txtAlternativa4
            // 
            this.txtAlternativa4.BackColor = System.Drawing.Color.Bisque;
            this.txtAlternativa4.Location = new System.Drawing.Point(53, 165);
            this.txtAlternativa4.Name = "txtAlternativa4";
            this.txtAlternativa4.ReadOnly = true;
            this.txtAlternativa4.Size = new System.Drawing.Size(397, 20);
            this.txtAlternativa4.TabIndex = 4;
            // 
            // txtAlternativa3
            // 
            this.txtAlternativa3.BackColor = System.Drawing.Color.Bisque;
            this.txtAlternativa3.Location = new System.Drawing.Point(53, 139);
            this.txtAlternativa3.Name = "txtAlternativa3";
            this.txtAlternativa3.ReadOnly = true;
            this.txtAlternativa3.Size = new System.Drawing.Size(397, 20);
            this.txtAlternativa3.TabIndex = 3;
            // 
            // txtAlternativa2
            // 
            this.txtAlternativa2.BackColor = System.Drawing.Color.Bisque;
            this.txtAlternativa2.Location = new System.Drawing.Point(53, 113);
            this.txtAlternativa2.Name = "txtAlternativa2";
            this.txtAlternativa2.ReadOnly = true;
            this.txtAlternativa2.Size = new System.Drawing.Size(397, 20);
            this.txtAlternativa2.TabIndex = 2;
            // 
            // txtAlternativa1
            // 
            this.txtAlternativa1.BackColor = System.Drawing.Color.Bisque;
            this.txtAlternativa1.Location = new System.Drawing.Point(53, 87);
            this.txtAlternativa1.Name = "txtAlternativa1";
            this.txtAlternativa1.ReadOnly = true;
            this.txtAlternativa1.Size = new System.Drawing.Size(397, 20);
            this.txtAlternativa1.TabIndex = 1;
            // 
            // txtpergunta
            // 
            this.txtpergunta.BackColor = System.Drawing.Color.Bisque;
            this.txtpergunta.Location = new System.Drawing.Point(14, 49);
            this.txtpergunta.Multiline = true;
            this.txtpergunta.Name = "txtpergunta";
            this.txtpergunta.ReadOnly = true;
            this.txtpergunta.Size = new System.Drawing.Size(436, 34);
            this.txtpergunta.TabIndex = 0;
            // 
            // tabResp
            // 
            this.tabResp.BackColor = System.Drawing.Color.Transparent;
            this.tabResp.Controls.Add(this.txtErradas);
            this.tabResp.Controls.Add(this.txtCertas);
            this.tabResp.Controls.Add(this.label11);
            this.tabResp.Controls.Add(this.label10);
            this.tabResp.Controls.Add(this.label9);
            this.tabResp.Controls.Add(this.label3);
            this.tabResp.Controls.Add(this.txtQuestaoCerta);
            this.tabResp.Controls.Add(this.label2);
            this.tabResp.Controls.Add(this.txtResposta);
            this.tabResp.Location = new System.Drawing.Point(4, 4);
            this.tabResp.Name = "tabResp";
            this.tabResp.Padding = new System.Windows.Forms.Padding(3);
            this.tabResp.Size = new System.Drawing.Size(462, 193);
            this.tabResp.TabIndex = 1;
            this.tabResp.Text = "Respostas";
            this.tabResp.UseVisualStyleBackColor = true;
            // 
            // txtErradas
            // 
            this.txtErradas.BackColor = System.Drawing.Color.Bisque;
            this.txtErradas.Location = new System.Drawing.Point(249, 43);
            this.txtErradas.Name = "txtErradas";
            this.txtErradas.ReadOnly = true;
            this.txtErradas.Size = new System.Drawing.Size(44, 20);
            this.txtErradas.TabIndex = 8;
            // 
            // txtCertas
            // 
            this.txtCertas.BackColor = System.Drawing.Color.Bisque;
            this.txtCertas.Location = new System.Drawing.Point(179, 43);
            this.txtCertas.Name = "txtCertas";
            this.txtCertas.ReadOnly = true;
            this.txtCertas.Size = new System.Drawing.Size(44, 20);
            this.txtCertas.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(250, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Erradas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(181, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Certas";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(199, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Avaliação em %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resp";
            // 
            // txtQuestaoCerta
            // 
            this.txtQuestaoCerta.BackColor = System.Drawing.Color.Bisque;
            this.txtQuestaoCerta.Location = new System.Drawing.Point(21, 125);
            this.txtQuestaoCerta.Name = "txtQuestaoCerta";
            this.txtQuestaoCerta.ReadOnly = true;
            this.txtQuestaoCerta.Size = new System.Drawing.Size(26, 20);
            this.txtQuestaoCerta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Resposta";
            // 
            // txtResposta
            // 
            this.txtResposta.BackColor = System.Drawing.Color.Bisque;
            this.txtResposta.Location = new System.Drawing.Point(19, 87);
            this.txtResposta.Name = "txtResposta";
            this.txtResposta.ReadOnly = true;
            this.txtResposta.Size = new System.Drawing.Size(416, 20);
            this.txtResposta.TabIndex = 0;
            // 
            // txtTexto
            // 
            this.txtTexto.BackColor = System.Drawing.Color.Bisque;
            this.txtTexto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTexto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtTexto.Location = new System.Drawing.Point(7, 60);
            this.txtTexto.MaxLength = 50000;
            this.txtTexto.Multiline = true;
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTexto.Size = new System.Drawing.Size(463, 104);
            this.txtTexto.TabIndex = 11;
            this.txtTexto.TabStop = false;
            this.txtTexto.WordWrap = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Arquivo Texto|*.txt|Arquivo CSV|*.csv";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Arquivo Texto|*.txt|Arquivo CSV|*.csv";
            // 
            // btnGravar
            // 
            this.btnGravar.Image = global::prjTexto.Properties.Resources.disk;
            this.btnGravar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGravar.Location = new System.Drawing.Point(114, 2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(116, 25);
            this.btnGravar.TabIndex = 13;
            this.btnGravar.Text = "Gravar Arquivo";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnLer
            // 
            this.btnLer.Image = global::prjTexto.Properties.Resources.book;
            this.btnLer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLer.Location = new System.Drawing.Point(3, 2);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(105, 26);
            this.btnLer.TabIndex = 12;
            this.btnLer.Text = "Ler Arquivo";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // frmTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 391);
            this.Controls.Add(this.lblpatharquivo);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.txtTexto);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTexto";
            this.Text = "Trabalhando com Arquivo Texto";
            this.Load += new System.EventHandler(this.frmTexto_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPerg.ResumeLayout(false);
            this.tabPerg.PerformLayout();
            this.tabResp.ResumeLayout(false);
            this.tabResp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblqtd;
        private System.Windows.Forms.Label lblpatharquivo;
        private System.Windows.Forms.Button btnProxima;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPerg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAlternativa4;
        private System.Windows.Forms.TextBox txtAlternativa3;
        private System.Windows.Forms.TextBox txtAlternativa2;
        private System.Windows.Forms.TextBox txtAlternativa1;
        private System.Windows.Forms.TextBox txtpergunta;
        private System.Windows.Forms.TabPage tabResp;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuestaoCerta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResposta;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnLer;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton r4;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtErradas;
        private System.Windows.Forms.TextBox txtCertas;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblE;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.TextBox txtE;
    }
}

