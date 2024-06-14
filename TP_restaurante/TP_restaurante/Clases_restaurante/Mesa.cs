using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_restaurante.Clases_restaurante
{
    internal class Mesa
    {
        private int _id;
        private int _capacidad;
        public Mesa(int id, int capacidad)
        {
            this._id = id;
            this._capacidad = capacidad;
        }
        /*
        public bool AsignarPlato(PlatoDeComida platoDeComida)
        {
            if (platoDeComida.HayParaOfrecer())
            {
                platoDeComida.UsarIngredientes();
                return true;
            }
            else
            {
                Console.WriteLine("No hay suficiente stock para preparar el plato de comida.");
                return false;
            }
        }
        */
    }
}
