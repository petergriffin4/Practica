using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            double celsius;

            // Intenta convertir el texto ingresado a un número
            if (double.TryParse(txtCelsius.Text, out celsius))
            {
                // Convierte Celsius a Fahrenheit
                double fahrenheit = (celsius * 9 / 5) + 32;
                lblResultado.Text = $"Temperatura en Fahrenheit: {fahrenheit:F2} °F";
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un número válido en Celsius.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
