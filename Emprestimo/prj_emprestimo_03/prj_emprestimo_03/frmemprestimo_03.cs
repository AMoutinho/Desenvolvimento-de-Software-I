     
    #region Programinha de Emprestimo

        #region Inicializações do Formulário e Sistema
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
#endregion

        #region Inicialização
namespace prj_emprestimo_03
{
    public partial class frmemprestimo_03 : Form
    {
        public frmemprestimo_03()
        {
            InitializeComponent();
        }
#endregion

        #region Botão de Calcular
        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double ValorEmprestimo = 0;
            double Pagamento = 0;
            double taxaJuros = 0;
            double valorTotalPago = 0;
            double valorJurosPago = 0;
            int PeriodoPagamento = 0;

            try
            {
                taxaJuros = Convert.ToDouble(nuptaxa.Value);
                PeriodoPagamento = Convert.ToInt16(Convert.ToDouble(nupprazo.Value) * 12);
                ValorEmprestimo = Convert.ToDouble(txt_vl_emi.Text);
                if (taxaJuros >= 1)
                {
                    taxaJuros = taxaJuros / 100;
                }
                Pagamento = (ValorEmprestimo * Math.Pow((taxaJuros / 12) + 1, (PeriodoPagamento)) * taxaJuros / 12) / (Math.Pow(taxaJuros / 12 + 1, (PeriodoPagamento)) - 1);

                valorTotalPago = Pagamento * PeriodoPagamento;
                valorJurosPago = valorTotalPago - ValorEmprestimo;

                txt_rst_prest.Text = Pagamento.ToString("N2");
                txt_total_pago.Text = valorTotalPago.ToString("N2");
                txt_juros_pago.Text = valorJurosPago.ToString("N2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #region Classe Extenso
            clsExtenso.clsExtenso extenso = new clsExtenso.clsExtenso();
            lbl_rst_extensao.Text = extenso.Extenso_Valor(decimal.Parse(txt_rst_prest.Text));
            #endregion
        }
        #endregion

        #region Relógio
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString();
        }
        #endregion

        #region Digitar Apenas Números TxtBx
        private void txt_vl_emi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Habilita Botão do Calculo
        private void txt_vl_emi_TextChanged(object sender, EventArgs e)
        {
            // Habilita ou desabilita o botão dependendo do
            // tamanho do texto do TextBox
            if(txt_vl_emi.TextLength == 0)
            btn_calcular.Enabled = false;
            else
                btn_calcular.Enabled = true;
        
        }
        #endregion

        #region Carregamento do Formulário
        private void prj_emprestimo_03_Load(object sender, EventArgs e)
        {
            btn_calcular.Enabled = false;
        }
        #endregion

        #region Limpar Caixas
        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_juros_pago.Text = ("");
            txt_rst_prest.Text = ("");
            txt_total_pago.Text = ("");
            txt_vl_emi.Text = ("");
            nuptaxa.Value = 0;
            nupprazo.Value = 0;
            lbl_rst_extensao.Text = ("");
            txt_vl_emi.Focus();
        }
        #endregion

        #region Botão Sair
        private void btn_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair ?", "Calculo de Emprestimo", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                Close();
        }
    }
}
        #endregion

#endregion