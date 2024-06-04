using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_restaurante.Clases_restaurante
{
    internal class PlatoDeComida
    {
        private string _nombre;
        private Dictionary<Producto, int> _ingredientes; // producto y cantidad requerido
        private DateTime _tiempoDePreparacion;
        public PlatoDeComida(string nombre, Dictionary<Producto, int> ingredientes, DateTime tiempoDePreparacion)
        {
            _nombre = nombre;
            _ingredientes = ingredientes;
            _tiempoDePreparacion = tiempoDePreparacion;
        }
        public string GetterNombrePlatoDeComida
        {
            get { return _nombre; }
        }
        public bool HayParaOfrecer()
        {
            foreach (var ingrediente in _ingredientes)
            {
                if (ingrediente.Key.Stock < ingrediente.Value)
                {
                    return false;
                }
            }
            return true;
        }
        public bool UsarIngredientes()
        {
            if (HayParaOfrecer())
            {
                foreach (var ingrediente in _ingredientes)
                {
                    ingrediente.Key.Stock -= ingrediente.Value;
                }
                return true;
            }
            return false;
        }
    }
}
