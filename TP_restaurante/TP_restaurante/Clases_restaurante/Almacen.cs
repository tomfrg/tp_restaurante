using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_restaurante.Clases_restaurante
{
    internal class Almacen
    {
        public static List<Producto> listaDeProductos = new List<Producto>();
        public static void AlmacenarProducto(Producto producto)
        {
            listaDeProductos.Add(producto);
        }
        public static void ConsultarStock()
        {
            foreach (var item in listaDeProductos)
            {
                Mostrar(item.Nombre, item.Stock);
            }
        }
        public static void Mostrar(string nombre, int cantidad)
        {
            Console.WriteLine($"{nombre}: {cantidad}");
        }
    }
}

