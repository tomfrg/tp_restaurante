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
        private List<Dictionary<Producto, int>> _ingredientes; // producto y cantidad requerido
        private TimeSpan _tiempoDePreparacion;
        public string Nombre
        {
            get { return _nombre; }
        }
        public TimeSpan TiempoDePreparacion
        {
            get { return _tiempoDePreparacion; }
        }
        public List<Dictionary<Producto, int>> Ingredientes
        {
            get { return _ingredientes; }
        }
        public PlatoDeComida(string nombre, List<Dictionary<Producto, int>> ingredientes, TimeSpan tiempoDePreparacion)
        {
            _nombre = nombre;
            _ingredientes = ingredientes;
            _tiempoDePreparacion = tiempoDePreparacion;
        }
        public PlatoDeComida()
        {

        }
        public string GetterNombrePlatoDeComida
        {
            get { return _nombre; }
        }
        /*
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
         */
        public string ObtenerIngredientes()
        {
            {
                StringBuilder sb = new StringBuilder();
                foreach (var dict in _ingredientes)
                {
                    sb.Append($"{dict.Values} {dict.Keys}, ");
                }
                return sb.ToString();
            }
        }
    }
}
