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
    public partial class FrmCalcular_la_suma_de_los_números_que_están_entre_1_y_100 : Form
    {
        public FrmCalcular_la_suma_de_los_números_que_están_entre_1_y_100()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            int i, sum;

            for (i=1; i<=100; i++)
            {
                sum = +i;

                TxtSuma.Text = TxtSuma.Text + sum.ToString() + (" ");
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();

                TxtSuma.Focus();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
