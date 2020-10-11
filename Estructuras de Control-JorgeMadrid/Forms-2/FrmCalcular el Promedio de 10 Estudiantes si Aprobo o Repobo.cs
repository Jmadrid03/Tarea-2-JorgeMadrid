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
    public partial class FrmCalcular_el_Promedio_de_10_Estudiantes_si_Aprobo_o_Repobo : Form
    {
        int contador = 1;
        public FrmCalcular_el_Promedio_de_10_Estudiantes_si_Aprobo_o_Repobo()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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

                TxtNombre.Focus();
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el Nombre del Estudiante.");
                TxtNombre.Focus();
                return;
            }

            if (TxtCalificacion.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar la Calificación.");
                TxtCalificacion.Focus();
                return;
            }

            LsbEstudiantes.Items.Add(TxtNombre.Text.Trim());
            LsbCalif.Items.Add(TxtCalificacion.Text.Trim());

            double cal;

            cal = Convert.ToDouble(TxtCalificacion.Text);

            if (cal >= 65)
            {
                LsbCondicion.Items.Add("APROBADO");
            } else
            {
                LsbCondicion.Items.Add("REPROBADO");
            }

            TxtNombre.Clear();
            TxtCalificacion.Clear();
            TxtNombre.Focus();

            contador++;
            LblNombreE.Text = "NOMBRE DEL ESTUDIANTE " + contador.ToString() + ": ";
            LblCalificacion.Text = "CALIFICACIÓN DEL ESTUDIANTE " + contador.ToString() + ": ";
        }

        private void FrmCalcular_el_Promedio_de_10_Estudiantes_si_Aprobo_o_Repobo_Load(object sender, EventArgs e)
        {

        }
    }
}
