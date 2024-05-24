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
        private float _precio;
        private Empleado _empleado;
        public int GetterStock
        {
            get { return _stock;  }
            set
            { 
                if (_empleado._rol == RolesEmpleados.Encargado)
                {
                    _stock = value;
                }
                else
                {
                    throw new UnauthorizedAccessException("Solo el encargado puede modificar el stock.");
                }
            }
        }
        public Producto(string _nombre, int _stock, float _precio)
        {
            this._nombre = _nombre;
            this._stock = _stock;
            this._precio = _precio;
        }
    }
}
