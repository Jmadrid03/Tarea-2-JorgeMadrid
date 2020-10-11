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
    public partial class FrmPrograma_que_lea_un_Número_y_Calcule_el_Doble_y_el_Cubo : Form
    {
        public FrmPrograma_que_lea_un_Número_y_Calcule_el_Doble_y_el_Cubo()
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

                TxtPrimerN.Focus();
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double num1, res;

            num1 = Convert.ToDouble(TxtPrimerN.Text);

            if (num1 >= 10)
            {
                res = num1 * 2;
                TxtResultado.Text = res.ToString();
            }
            else
            {
                res = num1 * 3;
                TxtResultado.Text = res.ToString();
            }
        }
    }
}
