using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using Newtonsoft.Json;
using System.IO;
namespace CapaDatos
{
    public class DCarrera
    {
        static string urlCarrera = @"C:\Users\Usuario\Desktop\PrimerProyeto\MatriculaUniversitaria\Archivos\carreras.json";
        public DCarrera()
        {

        }

        /*
         Metodo que carga una lista de objetos tipo Carrera 
         que se encuentran almacenadosdesde un archivo jSon
         Retorna listado de las carreras
            */
        public List<Carrera> CargarListadoDeCarreras()
        {
            StreamReader jsonStream = File.OpenText(urlCarrera);
            String json = jsonStream.ReadToEnd();
            jsonStream.Close();
            List<Carrera> lista_provicional = JsonConvert.DeserializeObject<List<Carrera>>(json);
            return lista_provicional;
        }

        /*
         Metodo que retorna una lista de carreras hacia la capa lógica
         Retorna lista de carreras
             */
        public List<Carrera> CargarCarrera()
        {
            return CargarListadoDeCarreras();
        }

        /*
         Metodo que recibe un objeto de tipo carrera, lo serializa y lo guarda en el archivo Json
         Retorna true si el objeto se guarda en el archivo o false si no lo hace 
             */
        public bool RegistrarCarrera(Carrera carrera)
        {
            List<Carrera> lista_provicional = CargarListadoDeCarreras();
            string archivo;
            if (lista_provicional == null)
            {
                archivo = "[" + JsonConvert.SerializeObject(carrera) + "]";
                File.WriteAllText(urlCarrera, archivo);
                return true;
            }
            if (lista_provicional.Count != 0)
            {
                archivo = "[";
                foreach (Carrera item in lista_provicional)
                {
                    archivo += JsonConvert.SerializeObject(item) + ",";
                }
                archivo += JsonConvert.SerializeObject(carrera) + "]";
                File.WriteAllText(urlCarrera, archivo);
                return true;
            }

            return false;
        }

        /*
         Metodo que recibe una nueva lista para sustitur la lista existente en el archivo Json
             */
        public void GuardarCarrera(List<Carrera> lista)
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
                File.WriteAllText(urlCarrera, archivo);
            }
            else
            {
                archivo = null;
                File.WriteAllText(urlCarrera, archivo);
            }
        }

        /*
         Metodo que se encarga de eliminar un objeto carrera y guardar nuevamente la lista 
         Retorna true si se logra o false si no es así 
             */
        public bool EliminarCarrera(Carrera carrera)
        {
            List<Carrera> lista_provicional = CargarListadoDeCarreras();
            for (int i = 0; i < lista_provicional.Count; i++)
            {
                if (carrera.idcarrera == lista_provicional[i].idcarrera)
                {
                    lista_provicional.RemoveAt(i);
                    GuardarCarrera(lista_provicional);
                    return true;
                }
            }
            return false;
        }

        /*
        
         Metodo que se encarga de editar un objeto carrera y guardar nuevamente la lista 
         Retorna true si se logra o false si no es así 
         */
        public bool EditarCarrera(Carrera carrera)
        {
            List<Carrera> lista_provicional = CargarListadoDeCarreras();
            for (int i = 0; i < lista_provicional.Count; i++)
            {
                if (carrera.idcarrera == lista_provicional[i].idcarrera)
                {
                    lista_provicional.RemoveAt(i);
                    GuardarCarrera(lista_provicional);
                    lista_provicional.Add(carrera);
                    GuardarCarrera(lista_provicional);
                    return true;
                }
            }
            return false;
        }




    }
}
