﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_restaurante.Clases_restaurante
{
    public class Producto
    {
        private string _nombre;
        private int _stock;
        private double _precio;
        private RolesEmpleados _rol = RolesEmpleados.Encargado;
        public Producto(string _nombre, int _stock, double _precio)
        {
            this._nombre = _nombre;
            this._stock = _stock;
            this._precio = _precio;
        }

        public string Nombre
        {
            get { return _nombre; }
        }
        public int Stock
        {
            get { return _stock; }
            set
            {
                if (_rol == RolesEmpleados.Encargado)
                {
                    _stock = value;
                }
            }
        }
        public override string ToString()
        {
            return $"{Stock} - {Nombre}";
        }
    }
}
