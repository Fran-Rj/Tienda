using Estudiantes.Data;
using Estudiantes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes.Vista
{
    public partial class VistaClientes : Form
    {
        public VistaClientes()
        {
            InitializeComponent();
        }

        void LoadInformation()
        {
            ClsEstudiante Cliente = new ClsEstudiante();
            var ok = Cliente.ListFinal();

            ListClient.Rows.Clear();
            foreach (var iterar in ok)
            {
                ListClient.Rows.Add(iterar.idCliente, iterar.nombresCliente, iterar.apellidos, iterar.usuario, iterar.contrasenia);
            }
        }

        void ClearInformation()
        {
            txtNombre.Clear();
            txtApellidos.Text = "";
            txtUsuario.Clear();
            txtContraseña.Text = "";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente es = new Cliente();
            es.nombresCliente = txtNombre.Text;
            es.apellidos = txtApellidos.Text;
            es.usuario = txtUsuario.Text;
            es.contrasenia = txtContraseña.Text;

            ClsEstudiante clsEstudiantes = new ClsEstudiante();
            clsEstudiantes.Guardar(es);
            ClearInformation();
            LoadInformation();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            String Id = ListClient.Rows[ListClient.CurrentRow.Index].Cells[0].Value.ToString();

            Cliente es = new Cliente();
            ClsEstudiante clsEstudiantes = new ClsEstudiante();

            es.idCliente = Convert.ToInt32(Id);
            es.nombresCliente = txtNombre.Text;
            es.apellidos = txtApellidos.Text;
            es.usuario = txtUsuario.Text;
            es.contrasenia = txtContraseña.Text;
            es.contrasenia = txtContraseña.Text;
            clsEstudiantes.Actualizar(es);

            ClearInformation();
            LoadInformation();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            String Id = ListClient.Rows[ListClient.CurrentRow.Index].Cells[0].Value.ToString();

            Cliente es = new Cliente();
            ClsEstudiante clsEstudiantes = new ClsEstudiante();

            es.idCliente = Convert.ToInt32(Id);
            es.nombresCliente = txtNombre.Text;
            es.apellidos = txtApellidos.Text;
            es.usuario = txtUsuario.Text;
            es.contrasenia = txtContraseña.Text;
            es.contrasenia = txtContraseña.Text;
            clsEstudiantes.Delete(es);

            ClearInformation();
            LoadInformation();
        }

        private void ListClient_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            String Nombre = ListClient.Rows[ListClient.CurrentRow.Index].Cells[1].Value.ToString();
            String Apellido = ListClient.Rows[ListClient.CurrentRow.Index].Cells[2].Value.ToString();
            String Usuario = ListClient.Rows[ListClient.CurrentRow.Index].Cells[3].Value.ToString();
            String Contraseña = ListClient.Rows[ListClient.CurrentRow.Index].Cells[4].Value.ToString();

            txtNombre.Text = Nombre;
            txtApellidos.Text = Apellido;
            txtUsuario.Text = Usuario;
            txtContraseña.Text = Contraseña;
        }
    }
}