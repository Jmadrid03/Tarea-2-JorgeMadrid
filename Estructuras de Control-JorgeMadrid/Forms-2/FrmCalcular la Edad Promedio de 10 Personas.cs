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
    public partial class FrmCalcular_la_Edad_Promedio_de_10_Personas : Form
    {
        int contador = 1;
        public FrmCalcular_la_Edad_Promedio_de_10_Personas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (TxtNombreP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese el Nombre de la Persona.");
                TxtNombreP.Focus();
                return;
            }

            if (TxtEdadP.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingresar la Edad de la Persona.");
                TxtEdadP.Focus();
                return;
            }

            LsbPersona.Items.Add(TxtNombreP.Text.Trim());
            LsbEdad.Items.Add(TxtEdadP.Text.Trim());

            int edad, prom, suma=0; 

            edad = Convert.ToInt32(TxtEdadP.Text);

            prom = edad / 10;
            suma += edad;

            TxtResultado.Text = prom.ToString();

            TxtNombreP.Clear();
            TxtEdadP.Clear();
            TxtResultado.Clear();
            TxtNombreP.Focus();

            contador++;
            LblNombreP.Text = "Ingresar Nombre de la Persona # " + contador.ToString() + ": ";
            LblEdadPr.Text = "Ingresar la Edad de la Persona # " + contador.ToString() + ": ";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
