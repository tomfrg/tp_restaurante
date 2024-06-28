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
        private bool _cerrada = false;
        private Dictionary<IItemMenu, double> _pedidoDeCliente;
        public int Id
        { get { return _id; } }
        public bool Cerrada
        { 
            get { return _cerrada; } 
            set { _cerrada = value; }
        }
        public int Capacidad
        { get { return _capacidad; } }
        public double CosteTotal
        {  
            get { return _costeTotal; } 
            set { _costeTotal = value; }
        }
        public Dictionary<IItemMenu, double> PedidoDeCliente
        { 
            get { return _pedidoDeCliente;} 
            set { _pedidoDeCliente = value;}
        }
        public Mesa(int id, int capacidad) 
        {
            _id = id;
            _capacidad = capacidad;
        }
        public void MostrarCosteTotal()
        {
            Console.WriteLine($"-Coste total: ${CosteTotal}");
        }
        public void MostrarPedidol()
        {
            foreach(var i in  PedidoDeCliente)
            {
                Console.WriteLine($"{i.Key.Nombre} - {i.Value}");
            }
        }
        public void MostrarEstadoDeLaMesa()
        {
            if(Cerrada)
            {
                Console.WriteLine($" CERRADA ");
            }
            else
            {
                Console.WriteLine($" ABIERTO ");
            }
        }
    }
}
