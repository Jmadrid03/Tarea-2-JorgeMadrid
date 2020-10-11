using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estructuras_de_Control_JorgeMadrid.Forms_2
{
    public partial class FrmCalcular_el_Total_a_Pagar_en_una_Boleteria : Form
    {
        public FrmCalcular_el_Total_a_Pagar_en_una_Boleteria()
        {
            InitializeComponent();
        }

        private void FrmCalcular_el_Total_a_Pagar_en_una_Boleteria_Load(object sender, EventArgs e)
        {

        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (TextBox Txt in this.Controls.OfType<TextBox>())
                {
                    Txt.Clear();

                    TxtCantidad.Focus();
                }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double cant, res;

            cant = Convert.ToDouble(TxtCantidad.Text.Trim());

            if (cant >= 10)
            {
                res = cant * 80.00;
            }else
            {
                res = cant * 100.00;
            }

            TxtPagar.Text = res.ToString();
        }
    }
}
