using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = 0 , altura = 0, imc = 0;
            try
            {
                //Converte os textos em doubles para fazer as contas
                peso = double.Parse(tbPeso.Text);
                altura = double.Parse(tbAltura.Text);
            }
            catch (Exception)
            {
                tbPeso.Text = "0";
                tbAltura.Text = "0";
                MessageBox.Show("Digite o peso e a altura", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            //Calcula o imc com a fórmula peso/(altura²) e arredonda com 2 casas decimais
            imc = Math.Round(peso / (Math.Pow(altura, 2)),2);
            tbIMC.Text = imc.ToString();

            //Os valores e classificações abaixo foram retirados do site http://pt.wikipedia.org/wiki/%C3%8Dndice_de_massa_corporal
            if (imc < 18.5) { lblDescricao.Text = "Abaixo do Peso"; lblDescricao.ForeColor = Color.Orange; }
            else if (imc > 18.5 && imc < 25) { lblDescricao.Text = "Saudável"; lblDescricao.ForeColor = Color.Green; }
            else if (imc >= 25 && imc < 30) { lblDescricao.Text = "Sobrepeso"; lblDescricao.ForeColor = Color.Orange; }
            else if (imc >= 30 && imc < 35) { lblDescricao.Text = "Obesidade Grau I"; lblDescricao.ForeColor = Color.Red; }
            else if (imc >= 35 && imc < 40) { lblDescricao.Text = "Obesidade Grau II (severa)"; lblDescricao.ForeColor = Color.Red; }
            else if (imc >= 40) { lblDescricao.Text = "Obesidade Grau III (mórbida)"; lblDescricao.ForeColor = Color.Red; }
        }

        #region Validar entradas dos TextBoxes
        //Testa se o que está sendo digitado é número, Backspace(char 8) ou vírgula(char 44)
        //O resto não deixa concluir o evento
        private void tbPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 8) && (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }

        private void tbAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != 8) && (e.KeyChar != 44))
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}