using Estudiantes.Data;
using Estudiantes.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes.Negocio
{
    class ClsEstudiante : ClsREstudiante
    {
        
        public void Guardar(Cliente es)
        {
            Create(es);
            MessageBox.Show("Guardado");
        }

        // Elimina una persona de la BD.
        public void Eliminar(Cliente es)
        {
            Delete(es);
            MessageBox.Show("Eliminado");
        }

        public void Actualizar(Cliente es)
        {
            Update(es);
            MessageBox.Show("Actualizado");
        }

        public List<Cliente> ListFinal()
        {
            List<Cliente> list = ListOfDataOfTableEstudiante();
            return list;
        }

    }
}
