using Matricula.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricula.Controlador
{
    public class FacultadControlador
    {
        public Boolean Save(Facultad facultad)
        {
            Boolean guardado = false;
            using (var db = new MatriculaContext())
            {
                db.Facultades.Add(facultad);
                db.SaveChanges();
                guardado = true;
            }
            return guardado;

        }
    }
}
