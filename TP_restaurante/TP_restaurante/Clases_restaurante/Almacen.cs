﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
namespace TP_restaurante.Clases_restaurante
{
    internal class Almacen
    {
        public static List<Producto> listaDeProductos = new List<Producto>();
        public List<Producto> ListaDeProductos
        {
            get { return listaDeProductos; }
        }
        public static bool AlmacenarProducto(Producto producto)
        {
            if (listaDeProductos.Contains(producto))
            {
                return false;
            }
            else
            {
                listaDeProductos.Add(producto);
                return true;
            }
        }
        public static void ConsultarStock()
        {
            foreach (var item in listaDeProductos)
            {
                Mostrar(item.Nombre, item.Stock);
            }
        }
        public static void Mostrar(string nombre, int cantidad)
        {
            Console.WriteLine($"{nombre}: {cantidad}");
        }
        public static void RetornarLista(List<Producto> listaDeProductos) 
        {
            foreach (var item in listaDeProductos)
            {
                Mostrar(item.Nombre, item.Stock);
            }
        }
        public static bool EliminarProducto(Producto producto)
        {
            return listaDeProductos.Remove(producto);
        }


    }
}
/*

