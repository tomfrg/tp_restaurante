using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpRestauranteActualizado.Clases.Empleados
{
    internal class Delivery : Empleado
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private int _contacto;
        private double _sueldo;

        public Delivery(string nombre, string apellido, string direccion, int contacto, double sueldo) : base(nombre, apellido, direccion, contacto, sueldo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _contacto = contacto;

        }
    }
}
