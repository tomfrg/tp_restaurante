using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_restaurante.Clases_restaurante
{
    public static class Cocina
    {
        private static List<Producto> productos = new List<Producto>();
        private static List<PlatoDeComida> platosDeComida = new List<PlatoDeComida>();

        public static void AgregarProducto(Producto producto)
        {
            // Verificar si el producto ya existe en la lista
            foreach (var prod in productos)
            {
                if (prod.Nombre == producto.Nombre)
                {
                    MessageBox.Show("Este producto, ya se agrego.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            productos.Add(producto);
        }

        //public static void CrearPlatoDeComida(string nombrePlato, Dictionary<Producto, int> ingredientes, TimeSpan tiempoDePreparacion)
        //{
        //    PlatoDeComida nuevoPlato = new PlatoDeComida(nombrePlato, ingredientes, tiempoDePreparacion);
        //    platosDeComida.Add(nuevoPlato);
        //}
    }
}
