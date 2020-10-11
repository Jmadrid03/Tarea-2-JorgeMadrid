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
    public partial class FrmPlantear_un_Programa_que_Determine_el_Número_Menor_de_2_Números : Form
    {
        public FrmPlantear_un_Programa_que_Determine_el_Número_Menor_de_2_Números()
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
            double num1, num2, res;

            num1 = Convert.ToDouble(TxtPrimerN.Text.Trim());
            num2 = Convert.ToDouble(TxtSegundoN.Text.Trim());

            if(num1 < num2)
            {
                res = num1;
            }
            else
            {
                res = num2;
            }

            TxtResultado.Text = res.ToString();
        }
    }
}
