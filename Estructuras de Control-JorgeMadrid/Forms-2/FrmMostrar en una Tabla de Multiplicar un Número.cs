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
    public partial class FrmMostrar_en_una_Tabla_de_Multiplicar_un_Número : Form
    {
        public FrmMostrar_en_una_Tabla_de_Multiplicar_un_Número()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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

                TxtNumero.Focus();
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (TxtNumero.Text.Trim().Length == 0)
            {
                MessageBox.Show("Igresar el Número.");
                TxtNumero.Focus();
                return;
            }

            int i;
            double num;

            num = Convert.ToDouble(TxtNumero.Text);

            for (i=1; i<=10; i++ )
            {
                LsbTabla.Items.Add(num + " * " + i + " = " + num * i);
            }
            LsbTabla.Items.Add(TxtNumero.Text.Trim());

            TxtNumero.Clear();
            TxtNumero.Focus();
            LsbTabla.ClearSelected();
        }
    }
}
