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
        private static List<Proveedor> _listaProveedores = new List<Proveedor>();
        private static List<Producto> _listaDeProductos = new List<Producto>();
        private static List<Mesa> _listaDeMesas = new List<Mesa>();
        private static double _dinero = 0;
        public static List<Producto> ListaDeProductos
        { get { return _listaDeProductos; } }
        public static List<Proveedor> ListaProveedores
        { get { return _listaProveedores; } }
        public static List<Empleado> ListaEmpleados
        { get { return _listaEmpleados; } }
        public static double Dinero
        {  get { return _dinero; } }

        //--------------------------------------------------------------------------------
        public static void IngresarDinero(double dinero)
        {
            _dinero = dinero + _dinero;
        }
        public static bool QuitarDinero(double dinero)
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
        public static bool MostrarDineroRestaurante(Empleado empleado)
        {
            if (empleado.Rol == RolesEmpleados.Encargado)
            {
                Console.WriteLine($"$ {_dinero}");
                return true;
            }
            else
            {
                return false;
            }

        }
        //--------------------------------------------------------------------------------
        public static bool AgregarProducto(Producto producto)
        {
            foreach(var Ingrediente in ListaDeProductos)
            {
                if (Ingrediente.Nombre == producto.Nombre)
                {
                    return false;
                }
            }
            ListaDeProductos.Add(producto);
                return true;
        }
        public static bool MostrarStockProducto(Empleado empleado)
        {
            if (empleado.Rol == RolesEmpleados.Encargado)
            {
                foreach (var ingredientes in ListaDeProductos)
                {
                    Console.WriteLine($"{ingredientes.Stock} {ingredientes.Nombre}");
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
            if (!ListaDeProductos.Contains(producto))
            {
                return false; 
            }
            else
            {
                ListaDeProductos.Remove(producto);
                return true;
            }
        }
        //--------------------------------------------------------------------------------
        public static bool AgregarProveedor(Proveedor proveedor)
        {
            foreach (var proveedores in ListaProveedores)
            {
                if (proveedores.Nombre == proveedor.Nombre)
                {
                    return false;
                }
            }
            ListaProveedores.Add(proveedor);
            return true;
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
        //--------------------------------------------------------------------------------
        public static bool AgregarEmpleado(Empleado empleado)
        {
            foreach (var empleados in ListaEmpleados)
            {
                if (empleados.Nombre == empleado.Nombre)
                {
                    return false;
                }
            }
            ListaEmpleados.Add(empleado);
            return true;
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
        //--------------------------------------------------------------------------------
        /*
        public static bool AgregarPlatoDeComida(PlatoDeComida platoDeComida)
        {
            foreach (var platos in ListaPlatoDeComida)
            {
                if (platos.Nombre == platoDeComida.Nombre)
                {
                    return false;
                }
            }
            ListaPlatoDeComida.Add(platoDeComida);
            return true;
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
        */
        //--------------------------------------------------------------------------------

    }
}
