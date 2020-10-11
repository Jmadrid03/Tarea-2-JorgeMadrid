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
    public partial class FrmPlantear_un_Programa_que_Ordene_2_Números_Ascendentemente : Form
    {
        public FrmPlantear_un_Programa_que_Ordene_2_Números_Ascendentemente()
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

                TxtPrimerN.Focus();
            }
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            double num1, num2, ascen, descen;

            num1 = Convert.ToDouble(TxtPrimerN.Text.Trim());
            num2 = Convert.ToDouble(TxtSegundoN.Text.Trim());

            if (num1 > num2)
            {
                ascen = num2;
                descen = num1;
                TxtDescen.Text = ascen.ToString();
                TxtAscen.Text = descen.ToString();
            }else
            {
                ascen = num1;
                descen = num2;
                TxtDescen.Text = ascen.ToString();
                TxtAscen.Text = descen.ToString();
            }
            
            }
        }
    }

