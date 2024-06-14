using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_restaurante.Clases_restaurante
{
    public enum RolesEmpleados
    {
        Mesero,
        Cocinero,
        Delivery,
        Encargado
    }
    public class Empleado
    {
        public string _nombre { get; }
        public string _apellido { get; }
        private string _direccion;
        private int _contacto;
        private double _sueldo;
        public RolesEmpleados _rol { get; }

        public Empleado(string _nombre, string _apellido, string _direccion, int _contacto, double _sueldo, RolesEmpleados _rol)
        {
            this._nombre = _nombre;
            this._apellido = _apellido;
            this._direccion = _direccion;
            this._contacto = _contacto;
            this._sueldo = _sueldo;
            this._rol = _rol;
        }
        public Empleado(string _nombre, string _apellido, string _direccion, int _contacto, RolesEmpleados _rol)
        {
            this._nombre = _nombre;
            this._apellido = _apellido;
            this._direccion = _direccion;
            this._contacto = _contacto;
            this._rol = _rol;
        }
        public override string ToString()
        {
            return $"{_rol} - {_nombre} {_apellido}";
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
