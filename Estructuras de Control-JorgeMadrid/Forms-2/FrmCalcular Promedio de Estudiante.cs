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
    public partial class FrmCalcular_Promedio_de_Estudiante : Form
    {
        public FrmCalcular_Promedio_de_Estudiante()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach(TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Clear();

                TxtPrimeracal.Focus();
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double cal1, cal2, cal3, prom;
            string Condicion;

            cal1 = Convert.ToDouble(TxtPrimeracal.Text.Trim());
            cal2 = Convert.ToDouble(TxtSegundacal.Text.Trim());
            cal3 = Convert.ToDouble(TxtTerceracal.Text.Trim());

            prom = (cal1 + cal2 + cal3) / 3;


            if (prom >= 65)
            {
                Condicion = "APROBADO";
                TxtPromedio.Text = prom.ToString("N2");
                TxtCondición.Text = Condicion;
            }
            else
            {
                Condicion = "REPROBADO";
                TxtPromedio.Text = prom.ToString("N2");
                TxtCondición.Text = Condicion;
            }
        
        }

    }
}
