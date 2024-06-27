using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpRestauranteActualizado.Clases
{
    public abstract class Producto : IItemMenu
    {
        private string _nombre;
        private double _stock = 0;
        private double _precio = 0;

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
            return prod1.Nombre == prod2.Nombre && prod1.Precio == prod2.Precio;
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
            return Nombre == other.Nombre && _precio == other.Precio;
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
    internal class Ingrediente : Producto
    {
        public Ingrediente(string _nombre, double _precio) : base()
        {
            Nombre = _nombre;
            Precio = _precio;
        }

    }
    internal class Bebida : Producto
    {
        private bool _alcohol;
        public Bebida(string _nombre, double _precio, bool alcohol) : base()
        {
            Nombre = _nombre;
            Precio = _precio;
            _alcohol = alcohol;

        }
    }
}
