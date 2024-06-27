using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpRestauranteConsola.Clases
{
    internal class Mesa
    {
        private int _id;
        private Dictionary<IItemMenu, double> _pedidoDelCliente;
        private Empleado _mesero;
        private double _costeTotal = 0;
        private bool _cerrada = true;
        public int Id
        { get { return _id; } }
        public Empleado Mesero 
        { get { return _mesero; } }
        public Dictionary<IItemMenu, double> PedidoDelCliente
        { get { return _pedidoDelCliente; } }
        public double CosteTotal
        { 
            get { return _costeTotal; } 
            set { _costeTotal = value; }
        }
        public Mesa(int id, Empleado mesero, Dictionary<IItemMenu, double> pedidoDelCliente)
        {
            _id = id;
            _mesero = mesero;
            _pedidoDelCliente = pedidoDelCliente;
            CalcularCosteDelPedido();
        }
        public void CalcularCosteDelPedido()
        {
            foreach (var item in PedidoDelCliente)
            {
                CosteTotal = item.Key.Precio * item.Value;
            }
        }
        public bool ServirPedidoDelCliente()
        {
            if (CalcularSiHayPlata() && CalcularSiHayStock())
            {
                foreach (var i in PedidoDelCliente)
                {
                    foreach (var e in Menu.ListaDelEnMenu)
                    {
                        if (i.Key == e)
                        {
                            e.Stock = e.Stock - i.Value;
                        }
                    }
                }
                return true;
            }
            return false;
        }
        public bool CalcularSiHayPlata()
        {
            if(Restaurante.Dinero <= CosteTotal)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool CalcularSiHayStock()
        {
            foreach(var item in PedidoDelCliente)
            {
                if(item.Key.Stock <= 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void CobrarMesa()
        {
            Restaurante.IngresarDinero(CosteTotal);
        }
        public void MostrarCosteTotal()
        {
            Console.WriteLine(CosteTotal);
        }
    }
}
