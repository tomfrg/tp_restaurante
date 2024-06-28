using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpRestauranteActualizado.Clases.Empleados;

namespace TpRestauranteActualizado.Clases
{
    internal static class Restaurante
    {
        private static List<Empleado> _listadoEmpleadoPorPrioridad = new List<Empleado>();
        private static List<Empleado> _listaEmpleados = new List<Empleado>();
        private static List<Proveedor> _listaProveedores = new List<Proveedor>();
        private static List<Producto> _listaDeProductos = new List<Producto>();
        private static List<Mesa> _listaDeMesas = new List<Mesa>();
        private static double _dinero = 0;
        private static double _deuda = 0;
        public static List<Producto> ListaDeProductos
        { 
            get { return _listaDeProductos; } 
            set { _listaDeProductos = value;}
        }
        public static List<Proveedor> ListaProveedores
        { get { return _listaProveedores; } }
        public static List<Empleado> ListaEmpleados
        { get { return _listaEmpleados; } }
        public static List<Empleado> ListaEmpleadosPorPrioridad
        { get { return _listadoEmpleadoPorPrioridad; } }
        public static double Dinero
        {
            get { return _dinero; } 
            set { _dinero = value; }
        }
        public static double Deuda
        { 
            get { return _deuda; } 
            set { _deuda = value; }
        }

        //--------------------------------------------------------------------------------
        public static void QuitarDeuda(double dinero)
        {
            Deuda = Deuda - dinero;
            if (Deuda < 0)
            {
                Deuda = 0;
            }
        }
        public static bool QuitarDinero(double dinero)
        {
            if (dinero > Dinero)
            {
                Console.WriteLine("Saldo insuficiente");
                return false;
            }
            else
            {
                Dinero = Dinero - dinero;
                return true;
            }
        }

        //--------------------------------------------------------------------------------
        public static bool AgregarProducto(Producto producto)
        {
            foreach (var productos in ListaDeProductos)
            {
                if (productos.Nombre == producto.Nombre)
                {
                    return false;
                }
            }
            ListaDeProductos.Add(producto);
            return true;
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
        public static void OrdenarEmpleadosPorPrioridad()
        {
            foreach(var i in ListaEmpleados)
            {
                if (i is Encargado) 
                {
                    ListaEmpleadosPorPrioridad.Add(i);
                }
            }
            foreach (var i in ListaEmpleados)
            {
                if (i is Cocinero) 
                {
                    ListaEmpleadosPorPrioridad.Add(i);
                }
            }
            foreach (var i in ListaEmpleados)
            {
                if (i is Mesero) 
                {
                    ListaEmpleadosPorPrioridad.Add(i);
                }
            }
            foreach (var i in ListaEmpleados) 
            {
                if (i is Delivery) 
                {
                    ListaEmpleadosPorPrioridad.Add(i);
                }
            }
        }
        public static void MostrarSueldoTotalDeTodos()
        {
            double sueldoTotal = 0;
            foreach(var i in ListaEmpleados)
            {
                sueldoTotal = sueldoTotal + i.Sueldo;
            }
            Console.WriteLine($"${sueldoTotal}");
        }
        public static void MostrarEmpleados()
        {
            foreach(var i in ListaEmpleados)
            {
                Console.WriteLine($"{i.Nombre} {i.Apellido}");
            }
        }
        public static void MostrarEmpleadosQueue()
        {
            foreach (var i in ListaEmpleadosPorPrioridad)
            {
                Console.WriteLine($"{i.Nombre} {i.Apellido}");
            }
        }
        //--------------------------------------------------------------------------------
        public static void MostrarLista<T>(List<T> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }
        public static void MostrarQueue<T>(Queue<T> list)
        {
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }


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
