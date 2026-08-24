using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract3_Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Clean_Click(object sender, EventArgs e)
        {
            TXT_Num1.Clear();
            TXT_Num2.Clear();
            TXT_Resultado.Clear();
        }

        private void BTN_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Calc_Click(object sender, EventArgs e)
        {
            double total = 0;
            if (string.IsNullOrEmpty(TXT_Num1.Text) || string.IsNullOrEmpty(TXT_Num2.Text))
            {
                MessageBox.Show("Termine de ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (RB_Sum.Checked == true)
            {
                LBL_Signo.Text = "+";
                total = Convert.ToDouble(TXT_Num1.Text) + Convert.ToDouble(TXT_Num2.Text);
                TXT_Resultado.Text = total.ToString();
            }
            else if (RB_Rest.Checked == true)
            {
                LBL_Signo.Text = "-";
                total = Convert.ToDouble(TXT_Num1.Text) - Convert.ToDouble(TXT_Num2.Text);
                TXT_Resultado.Text = total.ToString();
            }
            else if (RB_Mult.Checked == true)
            {
                LBL_Signo.Text = "*";
                total = Convert.ToDouble(TXT_Num1.Text) * Convert.ToDouble(TXT_Num2.Text);
                TXT_Resultado.Text = total.ToString();
            }
            else if (RB_Div.Checked == true)
            {
                if (Convert.ToDouble(TXT_Num2.Text) == 0)
                {
                    MessageBox.Show("No se permite división por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    LBL_Signo.Text = "/";
                    total = Convert.ToDouble(TXT_Num1.Text) / Convert.ToDouble(TXT_Num2.Text);
                    TXT_Resultado.Text = total.ToString();
                }
            }
        }
    }
}
