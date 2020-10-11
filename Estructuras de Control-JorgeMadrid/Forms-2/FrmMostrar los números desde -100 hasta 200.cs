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
    public partial class FrmMostrar_los_números_desde__100_hasta_200 : Form
    {
        public FrmMostrar_los_números_desde__100_hasta_200()
        {
            InitializeComponent();
        }

        private void FrmMostrar_los_números_desde__100_hasta_200_Load(object sender, EventArgs e)
        {

        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            int i;

            for (i=-100; i<=200; i++)
            {
                TxtNumeros.Text = TxtNumeros.Text + i.ToString() + ("-");
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();

                TxtNumeros.Focus();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
