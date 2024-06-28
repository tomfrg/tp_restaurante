using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpRestauranteActualizado.Clases
{
    public class Empleado
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private int _contacto;
        private double _dinero;
        private double _sueldo;

        public Empleado(string nombre, string apellido, string direccion, int contacto, double sueldo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _contacto = contacto;
            _sueldo = sueldo;
        }
        public string Nombre
        { get { return _nombre; } }
        public string Apellido
        { get { return _apellido; } }
        public double Sueldo
        { get { return _sueldo; } }
        public double Dinero
        { 
            get { return _dinero; } 
            set { _dinero = value; }
        }
        public static bool operator ==(Empleado e1, Empleado e2)
        {
            if (ReferenceEquals(e1, null) && ReferenceEquals(e2, null))
                return true;

            if (ReferenceEquals(e1, null) || ReferenceEquals(e2, null))
                return false;

            return e1._nombre == e2._nombre && e1._apellido == e2._apellido && e1._contacto == e2._contacto;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return !(e1 == e2);
        }

        public override bool Equals(object obj)
        {
            if (obj is Empleado empleado)
            {
                return this == empleado;
            }
            return false;
        }

        public override int GetHashCode()
        {
            unchecked // Permite el overflow aritmético
            {
                int hash = 17;
                hash = hash * 23 + (_nombre != null ? _nombre.GetHashCode() : 0);
                hash = hash * 23 + (_apellido != null ? _apellido.GetHashCode() : 0);
                hash = hash * 23 + _contacto.GetHashCode();
                return hash;
            }
        }
    }
}
