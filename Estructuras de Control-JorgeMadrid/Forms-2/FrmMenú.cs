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
    public partial class FrmMenú : Form
    {
        public FrmMenú()
        {
            InitializeComponent();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            Forms_2.FrmCalcular_Promedio_de_Estudiante Estudiante = new Forms_2.FrmCalcular_Promedio_de_Estudiante();
            Estudiante.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Forms_2.FrmPlantear_un_Programa_que_Determine_el_Número_Menor_de_2_Números Numero = new Forms_2.FrmPlantear_un_Programa_que_Determine_el_Número_Menor_de_2_Números();
            Numero.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Forms_2.FrmDeterminar_si_un_Número_es_Positivo_o_Negativo positivo = new Forms_2.FrmDeterminar_si_un_Número_es_Positivo_o_Negativo();
            positivo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Forms_2.FrmPrograma_que_lea_un_Número_y_Calcule_el_Doble_y_el_Cubo Cubo = new Forms_2.FrmPrograma_que_lea_un_Número_y_Calcule_el_Doble_y_el_Cubo();
            Cubo.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Forms_2.FrmCalcular_el_Total_a_Pagar_por_una_Venta venta = new Forms_2.FrmCalcular_el_Total_a_Pagar_por_una_Venta();
            venta.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Forms_2.FrmCalcular_el_Total_a_Pagar_en_una_Boleteria boleto = new Forms_2.FrmCalcular_el_Total_a_Pagar_en_una_Boleteria();
            boleto.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Forms_2.FrmPlantear_un_Programa_que_Ordene_2_Números_Ascendentemente numero = new Forms_2.FrmPlantear_un_Programa_que_Ordene_2_Números_Ascendentemente();
            numero.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Forms_2.FrmMostrar_los_Múltiplo_de_5_que_hay_entre_0_y_300 multiplo = new Forms_2.FrmMostrar_los_Múltiplo_de_5_que_hay_entre_0_y_300();
            multiplo.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Forms_2.FrmCalcular_el_Promedio_de_10_Estudiantes_si_Aprobo_o_Repobo promedio = new Forms_2.FrmCalcular_el_Promedio_de_10_Estudiantes_si_Aprobo_o_Repobo();
            promedio.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Forms_2.FrmLeer_Descripción__Cantidad_y_Precio_Unitario_de_10_Productos producto = new Forms_2.FrmLeer_Descripción__Cantidad_y_Precio_Unitario_de_10_Productos();
            producto.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Forms_2.FrmCalcular_la_Edad_Promedio_de_10_Personas edad = new Forms_2.FrmCalcular_la_Edad_Promedio_de_10_Personas();
            edad.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Forms_2.FrmNotas_de_10_Estudiantes_y_Determinar_Cuántos_Aprobaron_y_Reprobaron notas = new Forms_2.FrmNotas_de_10_Estudiantes_y_Determinar_Cuántos_Aprobaron_y_Reprobaron();
            notas.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Forms_2.FrmMostrar_en_una_Tabla_de_Multiplicar_un_Número tabla = new Forms_2.FrmMostrar_en_una_Tabla_de_Multiplicar_un_Número();
            tabla.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Forms_2.FrmCalcular_la_suma_de_los_números_que_están_entre_1_y_100 suma = new Forms_2.FrmCalcular_la_suma_de_los_números_que_están_entre_1_y_100();
            suma.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Forms_2.FrmMostrar_los_números_desde__100_hasta_200 numero = new Forms_2.FrmMostrar_los_números_desde__100_hasta_200();
            numero.Show();
        }
    }
}
