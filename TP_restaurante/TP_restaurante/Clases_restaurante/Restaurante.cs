using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_restaurante.Clases_restaurante
{
    internal static class Restaurante
    {
        public static string _nombre;
        public static List<Empleado> _listaEmpleados = new List<Empleado>();
        public static List<Menu> _listaMenu = new List<Menu>();
        public static List<PlatoDeComida> _listaPlatos = new List<PlatoDeComida>();
        public static List<Proveedor> _listaProveedores = new List<Proveedor>();
        public static List<Producto> listaDeProductos = new List<Producto>();
        public static int _cantidadDeMesas;
        public static List<PlatoDeComida> ListaPlatos
        {
            get { return _listaPlatos; }
        }
        public static List<Producto> ListaDeProductos
        {
            get { return listaDeProductos; }
        }
        public static bool AlmacenarProducto(Producto producto)
        {
            if (listaDeProductos.Contains(producto))
            {
                return false;
            }
            else
            {
                listaDeProductos.Add(producto);
                return true;
            }
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
        public static void RetornarLista(List<Producto> listaDeProductos)
        {
            foreach (var item in listaDeProductos)
            {
                Mostrar(item.Nombre, item.Stock);
            }
        }
        public static bool EliminarProducto(Producto producto)
        {
            return listaDeProductos.Remove(producto);
        }
        public static void AgregarProveedor(Proveedor proveedor)
        {

        }
        public static void AgregarEmpleado(Empleado empleado)
        {
            if (!_listaEmpleados.Any(e => e == empleado))
            {
                _listaEmpleados.Add(empleado);
            }
            else
            {
                MessageBox.Show("Ya existe un usuario identico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void EliminarEmpleado(Empleado empleado)
        {
            if (!_listaEmpleados.Any(e => e == empleado))
            {
                _listaEmpleados.Remove(empleado);
            }
        }
        public static void AgregarPlato(PlatoDeComida platoDeComida)
        {
            _listaPlatos.Add(platoDeComida);
        }
        public static void EliminarPlatoDeComida(PlatoDeComida platoDeComida)
        {
            if (!_listaPlatos.Any(e => e == platoDeComida))
            {
                _listaPlatos.Remove(platoDeComida);
            }
        }

    }

}
