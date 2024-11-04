using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        private object Operaciones;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            RealizarOperacion(Operaciones.Suma);
        }
        private void btnResta_Click(object sender, EventArgs e)
        {
            RealizarOperacion(Operaciones.Resta);
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            RealizarOperacion(Operaciones.Multiplicacion);
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            RealizarOperacion(Operaciones.Division);
        }

        private void RealizarOperacion(Operaciones operacion)
        {
            double numero1, numero2;

            if (double.TryParse(textBox1.Text, out numero1) && double.TryParse(textBox2.Text, out numero2))
            {
                double resultado = 0;
                string operacionStr = "";

                switch (operacion)
                {
                    case Operaciones.Suma:
                        resultado = numero1 + numero2;
                        operacionStr = "Suma";
                        break;
                    case Operaciones.Resta:
                        resultado = numero1 - numero2;
                        operacionStr = "Resta";
                        break;
                    case Operaciones.Multiplicacion:
                        resultado = numero1 * numero2;
                        operacionStr = "Multiplicación";
                        break;
                    case Operaciones.Division:
                        if (numero2 == 0)
                        {
                            MessageBox.Show("No se puede dividir entre cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                        resultado = numero1 / numero2;
                        operacionStr = "División";
                        break;
                }

                lblResultado.Text = $"Resultado de {operacionStr}: {resultado}";
            }
            else
            {
                MessageBox.Show("Por favor, ingresa números válidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
