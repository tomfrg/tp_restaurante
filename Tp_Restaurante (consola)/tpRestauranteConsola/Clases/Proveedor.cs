﻿using System;
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
        public Proveedor(string nombre, int cuit, string dirrecion, List<Producto> productoQueProvee, MedioDePago medioDePago, List<DiasDeEngrega> diaDeEntrega)
        {
            _nombre = nombre;
            _cuit = cuit;
            _dirrecion = dirrecion;
            _productoQueProvee = productoQueProvee;
            _medioDePago = medioDePago;
            _diaDeEntrega = diaDeEntrega;
        }
    }
}
