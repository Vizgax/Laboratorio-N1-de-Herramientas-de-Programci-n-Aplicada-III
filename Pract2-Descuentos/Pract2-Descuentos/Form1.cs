using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract2_Descuentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Calc_Click_1(object sender, EventArgs e)
        {
            double desc_din;
            if (string.IsNullOrEmpty(txt_VVenta.Text))
            {
                MessageBox.Show("Agregué un monto al campo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(txt_VVenta.Text) >= 500)
            {
                desc_din = double.Parse(txt_VVenta.Text) * 0.3;
                txt_Desc_Din.Text = Convert.ToString(desc_din);
                txt_Desc_Porc.Text = "30%";
                txt_VFin.Text = Convert.ToString(double.Parse(txt_VVenta.Text) - desc_din);
            }
            else if (double.Parse(txt_VVenta.Text) >= 300 && double.Parse(txt_VVenta.Text) <= 499)
            {
                desc_din = double.Parse(txt_VVenta.Text) * 0.20;
                txt_Desc_Din.Text = Convert.ToString(desc_din);
                txt_Desc_Porc.Text = "20%";
                txt_VFin.Text = Convert.ToString(double.Parse(txt_VVenta.Text) - desc_din);
            }
            else if (double.Parse(txt_VVenta.Text) > 100 && double.Parse(txt_VVenta.Text) <= 299)
            {
                desc_din = double.Parse(txt_VVenta.Text) * 0.10;
                txt_Desc_Din.Text = Convert.ToString(desc_din);
                txt_Desc_Porc.Text = "10%";
                txt_VFin.Text = Convert.ToString(double.Parse(txt_VVenta.Text) - desc_din);
            }
            else
            {
                txt_Desc_Din.Text = "No aplica";
                txt_Desc_Porc.Text = "No aplica";
                txt_VFin.Text = Convert.ToString(double.Parse(txt_VVenta.Text));
            }
        }

        private void btn_Clean_Click_1(object sender, EventArgs e)
        {
            txt_Desc_Din.Clear();
            txt_Desc_Porc.Clear();
            txt_VFin.Clear();
            txt_VVenta.Clear();
        }
    }
}
