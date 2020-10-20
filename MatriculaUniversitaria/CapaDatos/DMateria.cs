using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using System.IO;
using Newtonsoft.Json;

namespace CapaDatos
{
    public class DMateria
    {

        static string urlMaterias = @"C:\Users\Usuario\Desktop\PrimerProyeto\MatriculaUniversitaria\Archivos\materias.json";
        public DMateria()
        {

        }

        public List <Materia> CargarListadoDeMaterias()
        {
            StreamReader jsonStream = File.OpenText(urlMaterias);
            String json = jsonStream.ReadToEnd();
            jsonStream.Close();
            List<Materia> lista_provicional = JsonConvert.DeserializeObject<List<Materia>>(json);
            return lista_provicional;
        }

        public bool RegistrarMateria(Materia materia)
        {
            List<Materia> lista_provicional = CargarListadoDeMaterias();
            string archivo;
            if (lista_provicional == null)
            {
                archivo = "[" + JsonConvert.SerializeObject(materia) + "]";
                File.WriteAllText(urlMaterias, archivo);
                return true;
            }
            if (lista_provicional.Count != 0)
            {
                archivo = "[";
                foreach (Materia item in lista_provicional)
                {
                    archivo += JsonConvert.SerializeObject(item) + ",";
                }
                archivo += JsonConvert.SerializeObject(materia) + "]";
                File.WriteAllText(urlMaterias, archivo);
                return true;
            }

            return false;
        }
        public void GuardarMateria(List<Materia> lista)
        {
            string archivo;
            if (lista.Count != 0)
            {
                archivo = "[";
                for (int i = 0; i < lista.Count - 1; i++)
                {
                    archivo += JsonConvert.SerializeObject(lista[i]) + ",";
                }
                int x = lista.Count - 1;
                archivo += JsonConvert.SerializeObject(lista[x]) + "]";
                File.WriteAllText(urlMaterias, archivo);
            }
            else
            {
                archivo = null;
                File.WriteAllText(urlMaterias, archivo);
            }
        }
        public bool EliminarMateria(Materia materia)
        {
            List<Materia> lista_provicional = CargarListadoDeMaterias();
            for (int i = 0; i < lista_provicional.Count; i++)
            {
                if (materia.idMateria == lista_provicional[i].idMateria)
                {
                    lista_provicional.RemoveAt(i);
                    GuardarMateria(lista_provicional);
                    return true;
                }
            }
            return false;
        }

        public bool EditarMateria(Materia materia)
        {
            List<Materia> lista_provicional = CargarListadoDeMaterias();
            for (int i = 0; i < lista_provicional.Count; i++)
            {
                if (materia.idMateria == lista_provicional[i].idMateria)
                {
                    lista_provicional.RemoveAt(i);
                    GuardarMateria(lista_provicional);
                    lista_provicional.Add(materia);
                    GuardarMateria(lista_provicional);
                    return true;
                }
            }
            return false;
        }
    }
}
