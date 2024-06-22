using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpRestauranteConsola.Clases
{
    public class Producto
    {
        private string _nombre;
        private double _stock = 0;
        private double _precio;
        public Producto(string _nombre, double _stock, double _precio)
        {
            this._nombre = _nombre;
            this._stock = _stock;
            this._precio = _precio;
        }
        public Producto(string _nombre, double _precio)
        {
            this._nombre = _nombre;
            this._precio = _precio;
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public double Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public static bool operator ==(Producto prod1, Producto prod2)
        {
            if (ReferenceEquals(prod1, null) && ReferenceEquals(prod2, null))
                return true;
            if (ReferenceEquals(prod1, null) || ReferenceEquals(prod2, null))
                return false;
            return prod1.Nombre == prod2.Nombre && prod1._precio == prod2._precio;
        }
        public static bool operator !=(Producto prod1, Producto prod2)
        {
            return !(prod1 == prod2);
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Producto other = (Producto)obj;
            return _nombre == other._nombre && _precio == other._precio;
        }
        public override int GetHashCode() // AVERIGUAR QUE ES
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + _nombre.GetHashCode();
                hash = hash * 23 + _precio.GetHashCode();
                return hash;
            }
        }
    }
}
