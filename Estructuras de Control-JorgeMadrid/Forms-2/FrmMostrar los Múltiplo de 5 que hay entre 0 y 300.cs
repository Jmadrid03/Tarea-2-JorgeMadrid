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
    public partial class FrmMostrar_los_Múltiplo_de_5_que_hay_entre_0_y_300 : Form
    {
        public FrmMostrar_los_Múltiplo_de_5_que_hay_entre_0_y_300()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();

                TxtResultado.Focus();
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            int i;

            for (i = 5; i <= 300; i+=5)
            {
                TxtResultado.Text = TxtResultado.Text + i.ToString() + " - ";
            }
        }
    }
}
