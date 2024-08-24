using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace prjTexto
{
    public partial class frmTexto : Form
    {
        public frmTexto()
        {
            InitializeComponent();
        }

        public void TotalLinhas()
        {
            int i = 0;
            while (i < txtTexto.Lines.Length - 1)
            {
                quantlinhas = quantlinhas + 1;
                i++;
            }
        }

        string linha = "";
        string NomeArquivo;
        int nro = 0;
        int quantlinhas;

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                NomeArquivo = saveFileDialog1.FileName;
                StreamWriter Arquivo = new StreamWriter(NomeArquivo, false, Encoding.Default);
                Arquivo.Write(txtTexto.Text);
                Arquivo.Close();
                lblpatharquivo.Text = saveFileDialog1.FileName;
            }
        }
        public void Limpar()
        {
            txtTexto.Clear();
            txtResposta.Clear();
            txtQuestaoCerta.Clear();
            txtpergunta.Clear();
            txtAlternativa4.Clear();
            txtAlternativa3.Clear();
            txtAlternativa2.Clear();
            txtAlternativa1.Clear();
            lblqtd.Text = "";
        }

        private void btnLer_Click(object sender, EventArgs e)
        {
            
            Limpar();
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.InitialDirectory = Application.StartupPath + @"\";
                NomeArquivo = openFileDialog1.FileName;
                StreamReader Arquivo = new StreamReader(NomeArquivo, Encoding.Default);
                txtTexto.Text = Arquivo.ReadToEnd(); // leio todo o arquivo
               // txtTexto.Text = Arquivo.ReadLine();  // ler uma linha
                Arquivo.Close(); // fecho o arquivo
                btnGravar.Enabled = true;
                btnProxima.Enabled = true;
                lblpatharquivo.Text = openFileDialog1.FileName;
            }
            TotalLinhas();
        }

        private void btnProxima_Click(object sender, EventArgs e)
        {         
            int qtd = 0, i = 0, sinal = 0;
            string[] questao = new string[8];
            progressBar1.Minimum = 1;
            progressBar1.Maximum = quantlinhas+1;
            
            if (nro > quantlinhas)
                return;
            
            linha = txtTexto.Lines[nro];
           
            qtd = linha.Length;
           
            while ((i < qtd - 1))
            {

                if (linha.Substring(i, 1) != ";")
                {
                    questao[sinal] = questao[sinal] + linha.Substring(i, 1);
                    i++;
                }
                else
                {
                    sinal = sinal + 1;
                    i++;
                }

            }
            nro++;
            progressBar1.Value = nro;
            lblqtd.Text = nro.ToString() + "/" + txtTexto.Lines.Length.ToString();
            txtpergunta.Text = questao[0].ToString();
            txtAlternativa1.Text = questao[1].ToString();
            txtAlternativa2.Text = questao[2].ToString();
            txtAlternativa3.Text = questao[3].ToString();
            txtAlternativa4.Text = questao[4].ToString();
            txtQuestaoCerta.Text = questao[5].ToString();
            txtResposta.Text = questao[int.Parse(questao[5])].ToString();
        }

        private void frmTexto_Load(object sender, EventArgs e)
        {
            btnGravar.Enabled = false;
            btnProxima.Enabled = false;
        }

    }
}
