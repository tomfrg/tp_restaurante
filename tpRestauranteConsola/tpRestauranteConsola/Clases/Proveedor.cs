using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpRestauranteConsola.Clases
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
        public double Dinero
        {
            get { return _dinero; }
            set { _dinero = value; }
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
        public void PagarProveedor(double dinero)
        {
            Dinero = Dinero + dinero;
        }
        public void SumarStockProducto(Producto producto, double stockIngresado)
        {
            producto.Stock = producto.Stock + stockIngresado;
        }
        public double CalcularCosteProducto(Producto producto, double stockIngresado) // cambiar calcular precio dentro de clase producto y hacer algo parecido comno en plato de comifa
        {
            double costeTotal = stockIngresado * producto.Precio;
            return costeTotal;
        }
        public void ComprarProducto(Producto producto, double stockIngresado)
        {
            double coste = CalcularCosteProducto(producto, stockIngresado);
            SumarStockProducto(producto, stockIngresado);
            SaldarPago(coste);
        }
        public void ComprarProducto(Producto producto, double stockIngresado, DateTime fechaDePago)
        {
            //completar
            double coste = CalcularCosteProducto(producto, stockIngresado);
            DateTime contador = new DateTime(2024, 6, 22);
            while (true)
            {
                if (contador == fechaDePago)
                {
                    SumarStockProducto(producto, stockIngresado);
                    SaldarPago(coste);
                    break;
                }
            }
        }
        public void SaldarPago(double coste)
        {
            Restaurante.QuitarDinero(coste);
            PagarProveedor(coste);
        }
        public void MostrarDinero()
        {
            Console.WriteLine($"$ {Dinero}");
        }
    }
}
