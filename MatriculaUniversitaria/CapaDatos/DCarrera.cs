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


    }
}
