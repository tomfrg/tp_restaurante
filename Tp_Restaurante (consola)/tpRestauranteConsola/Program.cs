﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tpRestauranteConsola.Clases;

namespace tpRestauranteConsola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Productos
            Producto carne = new Producto("carne", 560);
            Producto panRallado = new Producto("pan", 90);
            Producto huevo = new Producto("huevo", 300);
            Producto huevo2 = new Producto("huevo", 600);
            Producto harina = new Producto("harina", 200);
            Producto leche = new Producto("leche", 150);

            Restaurante.AgregarProducto(carne);
            Restaurante.AgregarProducto(carne);
            Restaurante.AgregarProducto(panRallado);
            Restaurante.AgregarProducto(huevo);
            Restaurante.AgregarProducto(huevo2);
            Restaurante.AgregarProducto(harina);
            Restaurante.AgregarProducto(leche);
            #endregion

            #region Empleados
            Empleado tomi = new Empleado("Tomas", "Fragnito", "esme123", 1139310243, RolesEmpleados.Encargado);
            Empleado tomi2 = new Empleado("Tomas", "Fragnito", "esme123", 1139310243, RolesEmpleados.Encargado);
            Empleado oscar = new Empleado("Oscar", "Lele", "esme553", 1114343243, RolesEmpleados.Cocinero);
            Empleado pablo = new Empleado("Pablo", "Koko", "esme999", 150978042, RolesEmpleados.Mesero);
            Empleado hector = new Empleado("Hector", "Mbappe", "esme451", 1198547632, RolesEmpleados.Delivery);
            Empleado mohamed = new Empleado("Mohamed", "Redriguez", "Colombres132", 1176341254, RolesEmpleados.Mesero);

            Restaurante.AgregarEmpleado(tomi);
            Restaurante.AgregarEmpleado(tomi);
            Restaurante.AgregarEmpleado(tomi2);
            Restaurante.AgregarEmpleado(oscar);
            Restaurante.AgregarEmpleado(pablo);
            Restaurante.AgregarEmpleado(hector);
            Restaurante.AgregarEmpleado(hector);
            Restaurante.AgregarEmpleado(mohamed);
            #endregion

            #region PlatosDeComida
            Dictionary<Producto, int> ingredientesMilanesa = new Dictionary<Producto, int>
            {
                {carne, 1},
                {huevo, 2},
                {panRallado, 2}
            };
            TimeSpan tiemporMilanesa = new TimeSpan(1, 30, 00);

            Dictionary<Producto, int> ingredientesBife = new Dictionary<Producto, int>
            {
                {carne, 1},
            };
            TimeSpan tiemporBife = new TimeSpan(1, 05, 00);

            Dictionary<Producto, int> ingredientesHuevoFrito = new Dictionary<Producto, int>
            {
                {huevo, 1},
            };
            TimeSpan tiemporHuevoFrito = new TimeSpan(0, 08, 00);

            PlatoDeComida milanesa = new PlatoDeComida("milanesa", ingredientesMilanesa, tiemporMilanesa);
            PlatoDeComida milanesa2 = new PlatoDeComida("milanesa", ingredientesMilanesa, tiemporMilanesa);
            PlatoDeComida bife = new PlatoDeComida("bife", ingredientesBife, tiemporBife);
            PlatoDeComida huevoFrito = new PlatoDeComida("huevoFrito", ingredientesHuevoFrito, tiemporHuevoFrito);

            Restaurante.AgregarPlatoDeComida(milanesa);
            Restaurante.AgregarPlatoDeComida(milanesa);
            Restaurante.AgregarPlatoDeComida(milanesa2);
            Restaurante.AgregarPlatoDeComida(bife);
            Restaurante.AgregarPlatoDeComida(huevoFrito);
            #endregion

            #region Proveedor
            List<DiasDeEngrega> diasDeEntregaMarolio = new List<DiasDeEngrega> { DiasDeEngrega.Lunes, DiasDeEngrega.Jueves };
            List<Producto> productosMarolio = new List<Producto> { carne, huevo, harina ,panRallado };

            List<DiasDeEngrega> diasDeEntregaSancor = new List<DiasDeEngrega> { DiasDeEngrega.Miercoles };
            List<Producto> productosSancor = new List<Producto> { leche };

            Proveedor Marolio = new Proveedor("Marolio", 11342, "aca a la vuelta", productosMarolio, MedioDePago.Contado, diasDeEntregaMarolio);
            Proveedor Sancor = new Proveedor("Sancor", 45345, "cerca", productosSancor, MedioDePago.Tarjeta, diasDeEntregaSancor);

            #endregion
            //--------------------------------------------------
            Console.WriteLine(Marolio.Dinero);
            Console.WriteLine(Sancor.Dinero);
            Restaurante.MostrarDinero(tomi);
            Restaurante.IngresarDinero(100000);
            Restaurante.MostrarDinero(tomi);

            Restaurante.ComprarProducto(huevo, 5, Marolio);
            Restaurante.ComprarProducto(carne, 15, Marolio);
            Restaurante.ComprarProducto(panRallado, 30, Marolio);
            Restaurante.ComprarProducto(harina, 20, Marolio);
            Restaurante.ComprarProducto(leche, 20, Sancor);


            Restaurante.MostrarStockProductos(mohamed);
            Restaurante.MostrarStockProductos(tomi);

            Restaurante.MostrarDinero(tomi);
            Console.WriteLine("-----------------------");

            Restaurante.EliminarProducto(harina);

            Restaurante.MostrarStockProductos(tomi);

            Restaurante.MostrarDinero(tomi);
            Console.WriteLine(Marolio.Dinero);
            Console.WriteLine(Sancor.Dinero);
        }
    }
}
