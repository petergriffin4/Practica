using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string correo = txtContraseña.Text.Trim();
            string contrasena = txtContraseña.Text.Trim();

            // Validar los campos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(contrasena))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!correo.Contains("@"))
            {
                MessageBox.Show("El correo electrónico debe contener '@'.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Si todas las validaciones son correctas
            MessageBox.Show("Se ha registrado correctamente.", "Registro exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    
    }
}
