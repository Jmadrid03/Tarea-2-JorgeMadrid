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
    public partial class FrmNotas_de_10_Estudiantes_y_Determinar_Cuántos_Aprobaron_y_Reprobaron : Form
    {
        int contador = 1;
        double na, nr;
        public FrmNotas_de_10_Estudiantes_y_Determinar_Cuántos_Aprobaron_y_Reprobaron()
        {
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtNombreE.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el Nombre del Estudiante.");
                TxtNombreE.Focus();
                return;
            }

            if (TxtNotas.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar la Calificación.");
                TxtNotas.Focus();
                return;
            }

            LsbEstudiantes.Items.Add(TxtNombreE.Text.Trim());
            LsbCalif.Items.Add(TxtNotas.Text.Trim());

            double cal, na, nr;


            cal = Convert.ToDouble(TxtNotas.Text.Trim());
            na = Convert.ToDouble(TxtAprobaron.Text.Trim());
            nr = Convert.ToDouble(TxtReprobaron.Text.Trim());

            na = 0; nr = 0;

            if (cal >= 65)
            {
                LsbCondicion.Items.Add("APROBADO");
                na++;
            }
            else
            {
                LsbCondicion.Items.Add("REPROBADO");
                nr++;
            }

            TxtAprobaron.Text = na.ToString();
            TxtReprobaron.Text = nr.ToString();

            TxtNombreE.Clear();
            TxtNotas.Clear();
            TxtAprobaron.Clear();
            TxtReprobaron.Clear();
            TxtNombreE.Focus();

            contador++;
            LblNombreE.Text = "Ingresar Nombre del Estudiante # " + contador.ToString() + ": ";
            LblCalificacion.Text = "Ingresar Nota del Estudiante # " + contador.ToString() + ": ";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
