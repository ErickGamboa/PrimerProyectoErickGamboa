using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace CapaDatos
{
    public class Servicio
    {
        private StreamReader jsonStream;
        static string ruta = @"C:\Users\Usuario\Desktop\PrimerProyeto\MatriculaUniversitaria\Archivos\";

        public Servicio(string ruta_archivo)
        {
            jsonStream = File.OpenText(ruta + ruta_archivo);
        }

        public String ObtenerArchivo()
        {
            String json = jsonStream.ReadToEnd();
            return json;
        }
    }
}
