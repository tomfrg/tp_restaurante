using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpRestauranteActualizado.Clases
{
    public enum MedioDePago
    {
        Contado,
        Tarjeta,
        Tranferencia
    }
    public enum DiasDeEngrega
    {
        Lunes,
        Martes,
        Miercoles,
        Jueves,
        Viernes
    }
    internal class Proveedor
    {
        private string _nombre;
        private int _cuit;
        private string _dirrecion;
        private List<Producto> _productoQueProvee;
        private MedioDePago _medioDePago;
        private List<DiasDeEngrega> _diaDeEntrega;
        private double _dinero = 0;
        private double _dineroQueEsperaRecibir = 0;
        public double Dinero
        {
            get { return _dinero; }
            set { _dinero = value; }
        }
        public double DineroQueEsperaRecibir
        {
            get { return _dineroQueEsperaRecibir; }
            set { _dineroQueEsperaRecibir = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
        }
        public Proveedor(string nombre, int cuit, string dirrecion, List<Producto> productoQueProvee, MedioDePago medioDePago, List<DiasDeEngrega> diaDeEntrega)
        {
            _nombre = nombre;
            _cuit = cuit;
            _dirrecion = dirrecion;
            _productoQueProvee = productoQueProvee;
            _medioDePago = medioDePago;
            _diaDeEntrega = diaDeEntrega;
        }
        public void DefinirDiaDeSaldoDePago(DateTime dia)
        {

        }
        public void IngresarDinero(double dinero)
        {
            Dinero = dinero + Dinero;
            DineroQueEsperaRecibir = dinero - DineroQueEsperaRecibir;
        }
        public void IngresarDineroQueEsperaRecibir(double dinero)
        {
            DineroQueEsperaRecibir = dinero + DineroQueEsperaRecibir;
        }
        public double CalcularCosteProducto(Producto producto, double stockIngresado) 
        {
            double costeTotal = stockIngresado * producto.Precio;
            return costeTotal;
        }
        public void MostrarDinero()
        {
            Console.WriteLine($"$ {Dinero}");
        }
    }
}
