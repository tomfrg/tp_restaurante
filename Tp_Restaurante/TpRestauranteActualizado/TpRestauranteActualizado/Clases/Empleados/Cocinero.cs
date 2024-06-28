using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpRestauranteActualizado.Clases.Empleados
{
    internal class Cocinero : Empleado
    {
        private string _nombre;
        private string _apellido;
        private string _direccion;
        private int _contacto;
        private double _sueldo;

        public Cocinero(string nombre, string apellido, string direccion, int contacto, double sueldo) : base(nombre, apellido, direccion, contacto, sueldo)
        {

        }
        public void CocinarPlatoDeComida(double cantidadParaCocinar, PlatoDeComida platoDeComida)
        {
            if (platoDeComida.RestarIngredientes())
            {
                platoDeComida.Stock = cantidadParaCocinar + platoDeComida.Stock;
            }
            else
            {
                Console.WriteLine("no hay suficientes ingredientes");
            }
        }
    }
}
