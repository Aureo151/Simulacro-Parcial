using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro_Parcial
{
    internal class EstudianteArchivo
    {
        public void Guardar (string archivo, List <Estudiante> estudiantes)
        {
            string json = JsonConvert.SerializeObject(estudiantes);
            System.IO.File.WriteAllText(archivo, json);
        }
        public List<Estudiante> Leer(string archivo)
        {
            List<Estudiante> lista = new List<Estudiante>();
            StreamReader jsonStream = File.OpenText(archivo);
            string json = jsonStream.ReadToEnd();
            jsonStream.Close();

            lista = JsonConvert.DeserializeObject<List<Estudiante>>(json);
            return lista;
        }
    }
}
