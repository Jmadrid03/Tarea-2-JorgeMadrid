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
    public partial class FrmDeterminar_si_un_Número_es_Positivo_o_Negativo : Form
    {
        public FrmDeterminar_si_un_Número_es_Positivo_o_Negativo()
        {
            InitializeComponent();
        }

        private void FrmDeterminar_si_un_Número_es_Positivo_o_Negativo_Load(object sender, EventArgs e)
        {

        }

        private void TxtPrimerN_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            foreach (TextBox Txt in this.Controls.OfType<TextBox>())
            {
                Txt.Clear();

                TxtPrimerN.Focus();
            }
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            double num; 
            string res;

            num = Convert.ToDouble(TxtPrimerN.Text.Trim());

            if(num >= 1)
            {
                res = "POSITIVO";
                TxtResultado.Text = res;
            }
            else
            {
                res = "NEGATIVO";
                TxtResultado.Text = res;
            }
        }
    }
}
