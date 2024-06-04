using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_restaurante.Clases_restaurante
{
    internal class Menu
    {
        private List<PlatoDeComida> _platosDeComida;
        public Menu(List<PlatoDeComida> platosDeComida)
        {
            _platosDeComida = platosDeComida;
        }
        public void CrearPlatoDeComida(string nombrePlatoDeComida, Dictionary<Producto, int> ingredientes, DateTime timpoDePreparacion)
        {
            PlatoDeComida nuevoPlato = new PlatoDeComida(nombrePlatoDeComida, ingredientes, timpoDePreparacion);
            _platosDeComida.Add(nuevoPlato);
        }
        public bool EliminarPlatoDeComida(string nombrePlatoDeComida)
        {
            PlatoDeComida platoAEliminar = _platosDeComida.FirstOrDefault(plato => plato.GetterNombrePlatoDeComida == nombrePlatoDeComida);
            if (platoAEliminar != null)
            {
                _platosDeComida.Remove(platoAEliminar);
                return true;
            }
            return false;
        }
        public void ModificarPlatoDeComida(string nombrePlatoDeComida, Dictionary<Producto, int> ingredientes, DateTime timpoDePreparacion)
        {
            EliminarPlatoDeComida(nombrePlatoDeComida);
            CrearPlatoDeComida(nombrePlatoDeComida, ingredientes, timpoDePreparacion);
        }
    }
}
