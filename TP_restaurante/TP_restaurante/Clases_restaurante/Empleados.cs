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
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private int _contacto;
        private double _sueldo;
        public RolesEmpleados _rol { get; }
        public string GetterNombre
        {
            get { return _nombre; }
        }
        public string GetterApellido
        {
            get { return _apellido; }
        }
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
    }
}
