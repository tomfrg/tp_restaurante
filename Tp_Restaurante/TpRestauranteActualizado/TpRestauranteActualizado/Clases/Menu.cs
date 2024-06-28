using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpRestauranteActualizado.Clases
{
    public interface IItemMenu //indica que puede formar parte del menu, si no tiene la interfaz firmada, no puede estar en el menu
    {
        string Nombre { get; }
        double Stock { get; set; }
        double Precio { get; }
    }
    internal static class Menu
    {
        private static List<IItemMenu> _listaDelEnMenu;

        static Menu()
        {
            _listaDelEnMenu = new List<IItemMenu>();
        }
        public static List<IItemMenu> ListaDelEnMenu
        {
            get { return _listaDelEnMenu; }
        }

        public static bool AgregarAlMenu(IItemMenu item)
        {
            foreach (var existingItem in _listaDelEnMenu)
            {
                if (existingItem.Nombre == item.Nombre)
                {
                    return false;
                }
            }
            _listaDelEnMenu.Add(item);
            return true;
        }

        public static bool EliminarDelMenu(IItemMenu item)
        {
            if (!_listaDelEnMenu.Contains(item))
            {
                return false;
            }
            _listaDelEnMenu.Remove(item);
            return true;
        }

        public static void MostrarStockDelMenu()
        {
            foreach (var item in _listaDelEnMenu)
            {
                Console.WriteLine($"{item.Stock} - {item.Nombre}");
            }
        }
        public static void MostrarPrecioDelMenu()
        {
            foreach (var item in _listaDelEnMenu)
            {
                Console.WriteLine($"${item.Precio} - {item.Nombre}");
            }
        }
        public static void MostrarPrecio(IItemMenu cosito)
        {
            foreach (var item in _listaDelEnMenu)
            {
                if (item == cosito)
                {
                    Console.WriteLine(item.Precio);
                }
            }
        }
    }
}
