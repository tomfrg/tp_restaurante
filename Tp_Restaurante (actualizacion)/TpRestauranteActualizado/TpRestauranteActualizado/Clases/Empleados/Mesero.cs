using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *             Dictionary<IItemMenu, double> pedidoDelCliente = new Dictionary<IItemMenu, double>
            {
                {milanesa, 4},
                {leche, 2},
            };
            Mesa mesa1 = new Mesa(1, pablo, pedidoDelCliente);
            mesa1.ServirPedidoDelCliente(); quita del stok los ingredientes
            mesa1.CobrarMesa(); suma plata al reataurante
            mesa1.MostrarCosteTotal(); muestra el coste total del pedido
 */
namespace TpRestauranteActualizado.Clases.Empleados
{
    internal class Mesero : Empleado
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private int _contacto;
        private double _sueldo;

        public Mesero(string nombre, string apellido, string direccion, int contacto, double sueldo) : base(nombre, apellido, direccion, contacto, sueldo)
        {
            _nombre = nombre;
            _apellido = apellido;
            _direccion = direccion;
            _contacto = contacto;
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
        }
    }
}
