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
        public List<Carrera> CargarListadoDeCarreras()
        {
            StreamReader jsonStream = File.OpenText(urlCarrera);
            String json = jsonStream.ReadToEnd();
            jsonStream.Close();
            List<Carrera> lista_provicional = JsonConvert.DeserializeObject<List<Carrera>>(json);
            return lista_provicional;
        }
        public List<Carrera> CargarCarrera()
        {
            return CargarListadoDeCarreras();
        }

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
