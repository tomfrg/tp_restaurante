﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpRestauranteActualizado.Clases
{
    internal class PlatoDeComida : IItemMenu
    {
        private string _nombre;
        private Dictionary<Ingrediente, double> _ingrediente;
        private TimeSpan _tiempoDePreparacion;
        private double _stock = 0;
        private double _precio = 0;
        public double Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }
        public double Stock
        {
            get { return _stock; }
            set { _stock = value; }
        }
        public string Nombre
        {
            get { return _nombre; }
        }
        public TimeSpan TiempoDePreparacion
        {
            get { return _tiempoDePreparacion; }
        }
        public Dictionary<Ingrediente, double> Ingrediente
        {
            get { return _ingrediente; }
        }
        public PlatoDeComida(string nombre, Dictionary<Ingrediente, double> ingrediente, TimeSpan tiempoDePreparacion)
        {
            _nombre = nombre;
            _ingrediente = ingrediente;
            _tiempoDePreparacion = tiempoDePreparacion;
            CalcularCoste();
        }
        public bool RestarIngredientes()
        {
            foreach (var item in Ingrediente)
            {
                if (item.Key.Stock >= item.Value)
                {
                    item.Key.Stock -= item.Value;
                }
                else
                {
                    // Manejar el caso donde no hay suficiente stock
                    Console.WriteLine($"No hay suficiente stock de {item.Key.Nombre}");
                    return false;
                }
            }
            return true;
        }
        private void CalcularCoste()
        {
            foreach (var item in Ingrediente)
            {
                Precio = item.Key.Precio * item.Value;
            }
        }
    }
}
