using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica3N
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string contraseña = txtPsw.Text.Trim();
            string usuario = txtUser.Text.Trim();
            if (string.IsNullOrEmpty(usuario) )
            {
                MessageBox.Show("Por favor, Ingresa el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUser.Focus();
                return;
            }
            if (string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Por favor, Ingresa la contraseña.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPsw.Focus();
                return;
            }
        }
    }
}
