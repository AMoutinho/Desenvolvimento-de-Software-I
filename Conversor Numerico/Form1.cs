using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prj_conversao_03
{
    public partial class frmconversao : Form
    {
        string caracteres = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ", numDigitado, resFinal, numAux, baseValida;
        int qtdCaracteres, numAux2, restoMod, resParcial;
        public frmconversao()
        {
            InitializeComponent();
        }

        private void btn_converte_Click(object sender, EventArgs e)
        {
           
            if (nudBaseO.Value >= 2 && nudBaseR.Value >= 2)
            {
                baseValida = "1";
                resParcial = 0;
                resFinal = null;
                txt_resultado.Text = null;

                qtdCaracteres = txt_origem_num.Text.Trim().Length;
                numDigitado = txt_origem_num.Text.ToUpper();

                
                for (int a = 0; a < qtdCaracteres; a++)
                {
                    
                    if (baseValida == "1")
                    {
                       
                        for (int x = int.Parse(nudBaseO.Value.ToString()); x < caracteres.Length; x++)
                        {
                            
                            if (!numDigitado.Contains(caracteres[x]))
                            {
                                baseValida = "1";
                            }
                           
                            else
                            {
                                baseValida = caracteres[x].ToString();
                                break;
                            }
                        }
                    }
                }
                if (baseValida == "1")
                {
                    
                    for (int i = 1; i <= qtdCaracteres; i++)
                    {
                       
                        numAux = numDigitado[qtdCaracteres - i].ToString();
                        
                        numAux2 = caracteres.IndexOf(numAux);
                        resParcial = resParcial + numAux2 * int.Parse(Math.Pow(double.Parse(nudBaseO.Value.ToString()), double.Parse((i - 1).ToString())).ToString());
                    }
                    while (resParcial >= double.Parse(nudBaseR.Value.ToString()))
                    {
                        
                        restoMod = resParcial % int.Parse(nudBaseR.Value.ToString());
                        
                        resParcial = resParcial / int.Parse(nudBaseR.Value.ToString());
                        
                        resFinal = caracteres.Substring(restoMod, 1) + resFinal;
                    }
                    
                    resFinal = caracteres[int.Parse(resParcial.ToString())].ToString() + resFinal;
                    
                    txt_resultado.Text = resFinal;
                }
                
                else
                {
                    MessageBox.Show("O número digitado possui caracteres além da base de origem informada: " + baseValida, "Base inválida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            txt_origem_num.Text = ("");
            txt_resultado.Text = ("");
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }

}

    

    

