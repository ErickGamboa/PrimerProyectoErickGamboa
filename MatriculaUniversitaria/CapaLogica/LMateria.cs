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

        /*
        Método que conecta la capa datos con la capa presentación recibiendo un objeto materia
        Retorna metodo de registrar materia
            */
        public Boolean RegistrarMateria(Materia materia)
        {
            return D_materia.RegistrarMateria(materia);
        }

        /*
        Método que conecta la capa datos con la capa presentación
        Retorna metodo de cargar materia
            */
        public List<Materia> CargarMaterias()
        {
            return D_materia.CargarListadoDeMaterias();
        }

        /*
        Método que conecta la capa datos con la capa presentación recibiendo un objeto materia
        Retorna metodo de eliminar materia
            */
        public Boolean EliminarMateria(Materia materia)
        {
            return D_materia.EliminarMateria(materia);
        }

        /*
        Método que conecta la capa datos con la capa presentación recibiendo un objeto materia
        Retorna metodo de editar materia
            */
        public Boolean EditarMateria(Materia materia)
        {
            return D_materia.EditarMateria(materia);
        }
    }
}
