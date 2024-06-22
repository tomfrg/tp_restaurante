using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpRestauranteConsola.Clases
{
    internal static class Restaurante
    {
        private static List<Empleado> _listaEmpleados = new List<Empleado>();
        private static List<Menu> _listaMenu = new List<Menu>();
        private static List<PlatoDeComida> _listaPlatoDeComida = new List<PlatoDeComida>();
        private static List<Proveedor> _listaProveedores = new List<Proveedor>();
        private static List<Producto> _listaDeProductos = new List<Producto>();
        public static double _dinero = 0;
        private static List<Producto> ListaDeProductos
        { get { return _listaDeProductos; } }
        public static void IngresarDinero(double dinero)
        {
            _dinero = dinero + _dinero;
        }
        private static bool QuitarDinero(double dinero)
        {
            if (dinero > _dinero)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            else
            {
                _dinero = _dinero - dinero;
                Console.WriteLine(dinero);
                return true;
            }
        }
        public static bool MostrarDinero(Empleado empleado)
        {
            if (empleado._rol == RolesEmpleados.Encargado)
            {
                Console.WriteLine($"$ {_dinero}");
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool AgregarProducto(Producto producto)
        {
            if (_listaDeProductos.Contains(producto))
            {
                return false;
            }
            else
            {
                _listaDeProductos.Add(producto);
                return true;
            }
        }
        public static bool ComprarProducto(Producto producto, double stockIngresado)
        {
            double costeTotal = stockIngresado * producto.Precio;
            if (QuitarDinero(costeTotal))
            {
                producto.Stock = producto.Stock + stockIngresado;
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool MostrarStockProductos(Empleado empleado)
        {
            if (empleado._rol == RolesEmpleados.Encargado)
            {
                foreach (var producto in _listaDeProductos)
                {
                    Console.WriteLine($"{producto.Stock} {producto.Nombre}");
                }
                return true;
            }
            else
            {
                return false;
            }

        }
        public static bool EliminarProducto(Producto producto)
        {
            if (!_listaDeProductos.Contains(producto))
            {
                return false; 
            }
            else
            {
                _listaDeProductos.Remove(producto);
                return true;
            }
        }

        public static bool AgregarProveedor(Proveedor proveedor)
        {
            if (_listaProveedores.Contains(proveedor))
            {
                return false;
            }
            else
            {
                _listaProveedores.Add(proveedor);
                return true;
            }
        }
        public static bool EliminarProveedor(Proveedor proveedor)
        {
            if (_listaProveedores.Contains(proveedor))
            {
                return false;
            }
            else
            {
                _listaProveedores.Remove(proveedor);
                return true;
            }
        }

        public static bool AgregarEmpleado(Empleado empleado)
        {
            if (_listaEmpleados.Contains(empleado))
            {
                return false;
            }
            else
            {
                _listaEmpleados.Add(empleado);
                return true;
            }
        }
        public static bool EliminarEmpleado(Empleado empleado)
        {
            if (_listaEmpleados.Contains(empleado))
            {
                return false;
            }
            else
            {
                _listaEmpleados.Remove(empleado);
                return true;
            }
        }

        public static bool AgregarPlatoDeComida(PlatoDeComida platoDeComida)
        {
            if (_listaPlatoDeComida.Contains(platoDeComida))
            {
                return false;
            }
            else
            {
                _listaPlatoDeComida.Add(platoDeComida);
                return true;
            }
        }
        public static bool EliminarPlatoDeComida(PlatoDeComida platoDeComida)
        {
            if (_listaPlatoDeComida.Contains(platoDeComida))
            {
                return false;
            }
            else
            {
                _listaPlatoDeComida.Remove(platoDeComida);
                return true;
            }
        }

    }
}
