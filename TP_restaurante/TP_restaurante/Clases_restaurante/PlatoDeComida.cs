using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TP_restaurante.Clases_restaurante
{
    internal class PlatoDeComida
    {
        private string _nombre;
        private int _cantidadIngredientes;
        private DateTime _tiempoDePreparacion;

        public bool HayParaOfrecer(int _stock)
        {
            return false;
        }
    }
}
