using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpRestauranteActualizado.Clases.Empleados
{
    internal class Mesero : Empleado, IConsumoTotal
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private int _contacto;
        private double _sueldo;
        private int _cantDeVentas = 0;
        private double _consumoTotal = 0;
        private Dictionary<IItemMenu, double> _pedidoDeCliente;
        public int CantDeVentas
        {
            get { return _cantDeVentas; }
            set { _cantDeVentas = value; }
        }
        public double ConsumoTotal
        {
            get { return _consumoTotal; }
            set { _consumoTotal = value; }
        }
        public Dictionary<IItemMenu, double> PedidoDeCliente
        {
            get { return _pedidoDeCliente; }
            set { _pedidoDeCliente = value; }
        }

        public Mesero(string nombre, string apellido, string direccion, int contacto, double sueldo) : base(nombre, apellido, direccion, contacto, sueldo)
        {

        }
        public void ServirPedidoDelCliente(Mesa mesa)
        {
            foreach (var item in mesa.PedidoDeCliente)
            {
                if (item.Key.Stock >= item.Value)
                {
                    item.Key.Stock -= item.Value;
                }
                else
                {
                    Console.WriteLine($"No hay suficiente stock de {item.Key.Nombre}");
                }
            }
        }
        public void CobrarMesa(Mesa mesa)
        {
            Restaurante.Dinero = mesa.CosteTotal + Restaurante.Dinero;
            ConsumoTotal = mesa.CosteTotal + ConsumoTotal;
            CantDeVentas += 1;
            mesa.Cerrada = false;
        }
        private void CalcularCosteTotal(Mesa mesa)
        {
            foreach (var item in mesa.PedidoDeCliente)
            {
                mesa.CosteTotal = (item.Key.Precio * item.Value) + mesa.CosteTotal;
            }
        }
        public void AtenderMesa(Mesa mesa, Dictionary<IItemMenu, double> pedidoDeCliente)
        {
            mesa.PedidoDeCliente = pedidoDeCliente;
            CalcularCosteTotal(mesa);
            mesa.Cerrada = true;
        }
    }
}
