using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pract1_Controlares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            string dia = TBT_D.Text, mes = TBT_M.Text, ano = TBT_A.Text;
            if (string.IsNullOrEmpty(TBT_A.Text) || string.IsNullOrEmpty(TBT_D.Text) || string.IsNullOrEmpty(TBT_M.Text))
            {
                MessageBox.Show("Llené todo los campos para poder avanzar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                lbl_Mostrar.Text = "El dia de hoy es: " + dia + "\nEn el mes: " + mes + "\nEn el ano: " + ano;
            }
        }

        private void BTN_Clean_Click(object sender, EventArgs e)
        {
            lbl_Mostrar.Text = "La fecha es:";
            TBT_A.Clear();
            TBT_D.Clear();
            TBT_M.Clear();
        }

        private void btn_Fin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
