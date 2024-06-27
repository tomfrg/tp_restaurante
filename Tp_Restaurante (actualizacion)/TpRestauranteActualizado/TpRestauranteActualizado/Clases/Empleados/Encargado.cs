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
            Restaurante.IngresarDeuda(proveedor.CalcularCosteProducto(producto, stockIngresado));
            IngresarStockProducto(producto, stockIngresado);
            Restaurante.AgregarProducto(producto);
        }
        private void IngresarStockProducto(Producto producto, double stockIngresado)
        {
            producto.Stock = stockIngresado + producto.Stock;
        }
        public void PagarProveedor(double dinero, Proveedor proveedor)
        {
            proveedor.IngresarDineroProveedor(dinero);
            Restaurante.QuitarDinero(dinero);
            Restaurante.QuitarDeuda(dinero);
        }








        public void MostrarDeudaRestaurante()
        {
            Console.WriteLine($"$ {Restaurante.Deuda}");
        }
        public void MostrarDineroRestaurante()
        {
            Console.WriteLine($"$ {Restaurante.Dinero}");
        }
        public void MostrarStockProducto()
        {
            foreach (var ingredientes in Restaurante.ListaDeProductos)
            {
                Console.WriteLine($"{ingredientes.Stock} {ingredientes.Nombre}");
            }
        }
        public void MostrarStockProductos()
        {
            foreach (var ingredientes in Restaurante.ListaDeProductos)
            {
                Console.WriteLine($"{ingredientes.Stock} {ingredientes.Nombre}");
            }
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
    }
}
