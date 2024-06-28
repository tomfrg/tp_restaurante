using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpRestauranteActualizado.Clases.Empleados
{
    internal class Delivery : Empleado, IConsumoTotal
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private int _contacto;
        private double _sueldo;
        private double _consumoTotal;
        private double _costePedido;
        private int _cantDeVentas = 0;
        public Dictionary<IItemMenu, double> _pedidoDeCliente;
        public int CantDeVentas
        {
            get { return _cantDeVentas; }
            set { _cantDeVentas = value; }
        }
        public Dictionary<IItemMenu, double> PedidoDeCliente
        { get { return _pedidoDeCliente; } }
        public double ConsumoTotal
        {
            get { return _consumoTotal; }
            set { _consumoTotal = value; }
        }
        public double CostePedido
        {
            get { return _costePedido; }
            set { _costePedido = value; }
        }
        public Delivery(string nombre, string apellido, string direccion, int contacto, double sueldo) : base(nombre, apellido, direccion, contacto, sueldo)
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
        public void EnviarPedido(Dictionary<IItemMenu, double> pedidoDeCliente)
        {
            CalcularCostePedido();
            CalcularConsumoTotal();
        }
        private void CalcularConsumoTotal()
        {
            foreach (var item in PedidoDeCliente)
            {
                ConsumoTotal = CostePedido + ConsumoTotal;
            }
        }
        private void CalcularCostePedido() //calcular envio y propina
        {
            foreach (var item in PedidoDeCliente)
            {
                CostePedido = (item.Key.Precio * item.Value) + CostePedido;
            }
        }
        public void CobrarDelivery()
        {
            Restaurante.Dinero = ConsumoTotal + Restaurante.Dinero;
            CantDeVentas += 1;
            CostePedido = 0;
        }
    }
}
