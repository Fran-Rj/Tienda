using Estudiantes.Data;
using Estudiantes.Negocio;
using Estudiantes.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Estudiante : Form
    {
        public Estudiante()
        {
            InitializeComponent();
        }

        VistaClientes showClients = new VistaClientes();

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            String email = txtEmail.Text;
            String password = txtPassword.Text;

            String MyName = "fran";
            String MyPassword = "f123";

            if (email == "" && password == "")
            {
                MessageBox.Show("Llenar datos!");

                txtEmail.Clear();
                txtPassword.Clear();
            }
            else if (email != MyName && password != MyPassword)
            {
                MessageBox.Show("Verificar datos!");
            }
            else
            {
                showClients.Show();
                this.Hide();
            }
        }
    }
}
