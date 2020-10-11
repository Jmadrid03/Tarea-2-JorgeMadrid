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
    public partial class FrmCalcular_el_Total_a_Pagar_por_una_Venta : Form
    {
        public FrmCalcular_el_Total_a_Pagar_por_una_Venta()
        {
            InitializeComponent();
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

                TxtProducto.Focus();
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double cant, prec, sub, descto, tolp;

            cant = Convert.ToDouble(TxtCantidad.Text.Trim());
            prec = Convert.ToDouble(TxtPreciou.Text.Trim());

            sub = cant * prec;

            if (cant >= 3)
            {
                descto = sub * 0.20;
            }
            else
            {
                descto = 0;
            }

            tolp = sub - descto;

            TxtSubtotal.Text = sub.ToString();
            TxtDescto.Text = descto.ToString();
            TxtPagar.Text = tolp.ToString();
        }
    }
}
