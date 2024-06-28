using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpRestauranteActualizado.Clases.Empleados
{
    internal class Encargado : Empleado
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private int _contacto;
        private double _sueldo;
        public Encargado(string nombre, string apellido, string direccion, int contacto, double sueldo) : base( nombre,  apellido,  direccion,  contacto,  sueldo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _contacto = contacto;
        }
        public void ComprarProducto(Producto producto, double stockIngresado, Proveedor proveedor)
        {
            double costeProducto = proveedor.CalcularCosteProducto(producto, stockIngresado);
            IngresarDeudaRestaurante(costeProducto);
            IngresarStockProducto(producto, stockIngresado);
            proveedor.IngresarDineroQueEsperaRecibir(costeProducto);
        }
        private void IngresarStockProducto(Producto producto, double stockIngresado)
        {
            producto.Stock = stockIngresado + producto.Stock;
        }
        public void PagarProveedor(Proveedor proveedor)
        {
            double deudaProveedor = proveedor.DineroQueEsperaRecibir;
            if (Restaurante.QuitarDinero(deudaProveedor))
            {
                proveedor.IngresarDinero(deudaProveedor);
                Restaurante.QuitarDeuda(deudaProveedor);
            }
            else
            {
                Console.WriteLine("No se puede pagar al proveedor, saldo insuficiente.");
            }
        }
        public void IngresarDinero(double dinero)
        {
            Restaurante.Dinero = dinero + Restaurante.Dinero;
        }
        private void IngresarDeudaRestaurante(double dinero)
        {
            Restaurante.Deuda = dinero + Restaurante.Deuda;
        }
        public bool EliminarProducto(Producto producto)
        {
            if (!Restaurante.ListaDeProductos.Contains(producto))
            {
                return false;
            }
            else
            {
                Restaurante.ListaDeProductos.Remove(producto);
                return true;
            }
        }
        public void PagarEmpleados()
        {
            Restaurante.OrdenarEmpleadosPorPrioridad();

            List<Empleado> empleadosSinPago = new List<Empleado>();

            foreach (var empleado in Restaurante.ListaEmpleadosPorPrioridad.ToList())
            {
                if (empleado.Sueldo <= Restaurante.Dinero)
                {
                    PagarEmpleado(empleado);
                    Restaurante.ListaEmpleadosPorPrioridad.Remove(empleado);
                }
                else
                {
                    empleadosSinPago.Add(empleado);
                }
            }
            if(Restaurante.ListaEmpleadosPorPrioridad.Count > 0)
            {
                EmpleadosSinPago();
            }
        }
        public void EmpleadosSinPago()
        {
            Console.WriteLine("EMPLEADOS SIN PAGO");
            foreach (var i in Restaurante.ListaEmpleadosPorPrioridad)
            {
                Console.WriteLine($"{i.Nombre} {i.Apellido}");
            }
        }
        private void PagarEmpleado(Empleado empleado)
        {
            empleado.Dinero += empleado.Sueldo;
            Restaurante.QuitarDinero(empleado.Sueldo);
        }

        #region METODOS DE MOSTRAR
        public void MostrarDeudaRestaurante()
        {
            Console.WriteLine($"$ {Restaurante.Deuda}");
        }
        public void MostrarDineroRestaurante()
        {
            Console.WriteLine($"$ {Restaurante.Dinero}");
        }
        public void MostrarStockCompras()
        {
            foreach (var items in Menu.ListaDelEnMenu)
            {
                Console.WriteLine($"{items.Stock} {items.Nombre}");
            }
        }
        public void MostrarPrecioCompras()
        {
            foreach (var items in Menu.ListaDelEnMenu)
            {
                Console.WriteLine($"${items.Precio} {items.Nombre}");
            }
        }
        public void MostrarStockProductos()
        {
            foreach (var items in Restaurante.ListaDeProductos)
            {
                Console.WriteLine($"{items.Stock} {items.Nombre}");
            }
        }
        public void MostrarPrecioProductos()
        {
            foreach (var items in Restaurante.ListaDeProductos)
            {
                Console.WriteLine($"${items.Precio} {items.Nombre}");
            }
        }
        #endregion

    }
}
