using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_restaurante.Clases_restaurante
{
    internal class Producto
    {
        private string _nombre;
        private int _stock;
        private double _precio;
        public Producto(string _nombre, int _stock, double _precio)
        {
            this._nombre = _nombre;
            this._stock = _stock;
            this._precio = _precio;
        }
        public string Nombre
        {
            get { return _nombre; }
        }
        public int Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        public bool ModificarStock(int nuevoStock, Empleado empleado)
        {
            {
                if (empleado._rol == RolesEmpleados.Encargado)
                {
                    Stock = nuevoStock;
                    return true;
                }
                else
                {
                    Console.WriteLine("Solo el encargado puede modificar el stock.");
                    return false;
                }
            }
        }
    }
}
