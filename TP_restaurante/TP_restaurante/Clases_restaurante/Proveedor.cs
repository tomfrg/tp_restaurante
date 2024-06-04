using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_restaurante.Clases_restaurante
{
    public enum MedioDePago
    {
        contado,
        tarjeta,
        tranferencia
    }
    internal class Proveedor
    {
        private string _nombre;
        private int _cuit;
        private string _dirrecion;
        private string _productoQueProvee;
        private MedioDePago _medioDePago;
        private string _diaDeLaSemanaDeEntrega;
    }
}
