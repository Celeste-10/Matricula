using Matricula.Modelos;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula.Controlador
{
    public class MatriculaContext: DbContext
    {
        public MatriculaContext(): base("name=ConexionStr")
        {
        }

        public DbSet<Facultad> Facultades { get; set; }
    }
}
