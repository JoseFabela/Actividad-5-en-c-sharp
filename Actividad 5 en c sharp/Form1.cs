using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Actividad_5_en_c_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        


        private void btnIdentificar_Click_1(object sender, EventArgs e)
        {
            // Obtener el arreglo de enteros desde el cuadro de texto
            int[] numeros = txtNumeros.Text.Split(',').Select(int.Parse).ToArray();

            // Mostrar la cantidad de elementos en el arreglo
            MessageBox.Show($"El arreglo tiene {numeros.Length} elementos.");

            // Mostrar el elemento más grande del arreglo
            MessageBox.Show($"El elemento más grande del arreglo es {numeros.Max()}.");

            // Mostrar el elemento más pequeño del arreglo
            MessageBox.Show($"El elemento más pequeño del arreglo es {numeros.Min()}.");
        }
    }
}



