using Estudiantes.Data;
using Estudiantes.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes.Repository
{
    class ClsREstudiante : ICliente
    {
        public void Create(Cliente cliente)
        {
            using (TiendaDAFJJEntities conexionBd = new TiendaDAFJJEntities())
            {
                try 
                {
                    conexionBd.Cliente.Add(cliente);
                    conexionBd.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error de base de datos" + ex);
                }
            }
        }

        public void Delete(Cliente cliente)
        {
            using (TiendaDAFJJEntities conexionBd = new TiendaDAFJJEntities())
            {
                cliente = conexionBd.Cliente.Find(cliente.idCliente);
                conexionBd.Cliente.Remove(cliente); //Remove = Eliminar
                conexionBd.SaveChanges();
            }
        }

        public void Update(Cliente cliente)
        {
            using (TiendaDAFJJEntities conexionBd = new TiendaDAFJJEntities())
            {
                Cliente es = conexionBd.Cliente.Find(cliente.idCliente);
                es.nombresCliente = cliente.nombresCliente;
                es.apellidos = cliente.apellidos;
                es.usuario = cliente.usuario;
                es.contrasenia = cliente.contrasenia;
                conexionBd.SaveChanges();
            }         
        }

        public List<Cliente> ListOfDataOfTableEstudiante()
        {
            using (TiendaDAFJJEntities conexionBd = new TiendaDAFJJEntities())
            {
                List<Cliente> ListaOfData = conexionBd.Cliente.ToList();
                return ListaOfData;
            }   
        }
    }

    internal interface ICliente
    {
    }
}
