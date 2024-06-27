using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpRestauranteActualizado.Clases
{
    internal class Mesa
    {
        private int _id;
        private int _capacidad;
        private double _costeTotal;
        private Dictionary<IItemMenu, double> _pedidoDeCliente;
        public int Id
        { get { return _id; } }
        public int Capacidad
        { get { return _capacidad; } }
        public double CosteTotal
        {  
            get { return _costeTotal; } 
            set { _costeTotal = value; }
        }
        public Dictionary<IItemMenu, double> PedidoDeCliente
        { get { return _pedidoDeCliente;} }
        public Mesa(int id, int capacidad, Dictionary<IItemMenu, double> pedidoDeCliente) 
        {
            _id = id;
            _capacidad = capacidad;
            _pedidoDeCliente = pedidoDeCliente;
            CalcularCosteTotal();
        }
        private void CalcularCosteTotal()
        {
            foreach(var item in PedidoDeCliente)
            {
                CosteTotal = item.Key.Precio + CosteTotal;
            }
        }
        public void MostrarCosteTotal()
        {
            Console.WriteLine($" coste total : {CosteTotal}");
        }
        public void MostrarPedidol()
        {
            foreach(var i in  PedidoDeCliente)
            {
                Console.WriteLine($"{i.Key.Nombre} - {i.Value}");
            }
        }
    }
}
