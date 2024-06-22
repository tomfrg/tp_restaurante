using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpRestauranteConsola.Clases
{
    internal class PlatoDeComida
    {
        private string _nombre;
        private Dictionary<Producto, int> _ingredientes; // producto y cantidad requerido
        private TimeSpan _tiempoDePreparacion;
        public string Nombre
        {
            get { return _nombre; }
        }
        public TimeSpan TiempoDePreparacion
        {
            get { return _tiempoDePreparacion; }
        }
        public Dictionary<Producto, int> Ingredientes
        {
            get { return _ingredientes; }
        }
        public PlatoDeComida(string nombre, Dictionary<Producto, int> ingredientes, TimeSpan tiempoDePreparacion)
        {
            _nombre = nombre;
            _ingredientes = ingredientes;
            _tiempoDePreparacion = tiempoDePreparacion;
        }
    }
}
