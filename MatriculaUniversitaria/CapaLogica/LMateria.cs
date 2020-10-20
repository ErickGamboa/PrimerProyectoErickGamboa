using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaLogica
{
    public class LMateria
    {
        public DMateria D_materia;

        public LMateria()
        {
            this.D_materia = new DMateria();
        }
        public Boolean RegistrarMateria(Materia materia)
        {
            return D_materia.RegistrarMateria(materia);
        }
        public List<Materia> CargarMaterias()
        {
            return D_materia.CargarListadoDeMaterias();
        }
        public Boolean EliminarMateria(Materia materia)
        {
            return D_materia.EliminarMateria(materia);
        }
    }
}
