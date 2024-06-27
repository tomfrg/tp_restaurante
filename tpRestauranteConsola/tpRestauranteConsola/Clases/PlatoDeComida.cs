using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpRestauranteConsola.Clases
{
    internal class PlatoDeComida : IItemMenu
    {
        private string _nombre;
        private Dictionary<Ingrediente, double> _ingrediente;
        private TimeSpan _tiempoDePreparacion;
        private double _stock = 0;
        private double _precio = 0;
        public double Precio
        { 
            get { return _precio; } 
            set { _precio = value; }    
        }
        public double Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
        }
        public TimeSpan TiempoDePreparacion
        {
            get { return _tiempoDePreparacion; }
        }
        public Dictionary<Ingrediente, double> Ingrediente
        {
            get { return _ingrediente; }
        }
        public PlatoDeComida(string nombre, Dictionary<Ingrediente, double> ingrediente, TimeSpan tiempoDePreparacion)
        {
            _nombre = nombre;
            _ingrediente = ingrediente;
            _tiempoDePreparacion = tiempoDePreparacion;
            CalcularCoste();
        }
        private bool RestarIngredientes()
        {
            foreach (var item in Ingrediente)
            {
                if (item.Key.Stock >= item.Value)
                {
                    item.Key.Stock -= item.Value;
                }
                else
                {
                    // Manejar el caso donde no hay suficiente stock
                    Console.WriteLine($"No hay suficiente stock de {item.Key.Nombre}");
                    return false;
                }
            }
            return true;
        }
        public void CocinarPlatoDeComida(double cantidadParaCocinar)
        {
            if (RestarIngredientes())
            {
                Stock = cantidadParaCocinar + Stock;
            }
            else 
            {
                Console.WriteLine("error");
            }
        }
        public void CalcularCoste()
        {
            foreach(var item in Ingrediente)
            {
                Precio = item.Key.Precio * item.Value;
            }
        }
        public void MostrarStock()
        {
            Console.WriteLine(Stock);
        }
        public void MostrarPrecio()
        {
            Console.WriteLine(Precio);
        }
    }
}
