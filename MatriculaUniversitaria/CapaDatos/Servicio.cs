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
        public string url;
        public Servicio(string ruta_archivo)
        {
            this.url = ruta_archivo;
            jsonStream = File.OpenText(ruta + ruta_archivo);
        }

        public Servicio() { }

        public String ObtenerArchivo()
        {
            StreamReader jsonStreamsssss = File.OpenText(ruta + this.url);
            String json = jsonStreamsssss.ReadToEnd();
            jsonStreamsssss.Close();
            return json;
        }

        public Boolean GuardarEnArchivo(string archivo, string ruta_archivo)
        {
            string rutaFinal = ruta + ruta_archivo;
            File.WriteAllText(rutaFinal, archivo);
            return true;
        }
    }
}
