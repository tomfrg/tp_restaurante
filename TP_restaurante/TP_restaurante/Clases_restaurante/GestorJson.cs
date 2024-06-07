using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TP_restaurante.Clases_restaurante
{
    public class GestorJson<T>
    {
        private string rutaCarpeta;
        private string nombreArchivo;

        public GestorJson(string rutaCarpeta, string nombreArchivo)
        {
            this.rutaCarpeta = rutaCarpeta;
            this.nombreArchivo = nombreArchivo;
        }

        public bool ArchivoExiste()
        {
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            return File.Exists(rutaCompleta);
        }

        public void CrearArchivo(List<T> listaInicial)
        {
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            string jsonString = JsonSerializer.Serialize(listaInicial, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(rutaCompleta, jsonString);
        }

        public List<T> CargarDesdeArchivo()
        {
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            string jsonString = File.ReadAllText(rutaCompleta);
            return JsonSerializer.Deserialize<List<T>>(jsonString);
        }

        public void AgregarAlArchivo(T objeto)
        {
            string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);
            List<T> lista = CargarDesdeArchivo();
            lista.Add(objeto);
            string jsonString = JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(rutaCompleta, jsonString);
        }
    }
}
