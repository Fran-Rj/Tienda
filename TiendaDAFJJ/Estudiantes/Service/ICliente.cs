using System;
using Estudiantes.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Estudiantes.Service
{
    interface IEstudiante
    {
        void Create(Cliente cliente);

        void Delete(Cliente cliente);

        void Update(Cliente cliente);

        List<Cliente> ListOfDataOfTableEstudiante();
    }
}


