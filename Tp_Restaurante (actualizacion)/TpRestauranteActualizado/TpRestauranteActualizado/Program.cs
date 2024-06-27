using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpRestauranteActualizado.Clases;
using TpRestauranteActualizado.Clases.Empleados;

namespace TpRestauranteActualizado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-
            // DECLARACIONES DE OBJETOS
            //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-

            //--------------------------------------------------
            #region Productos
            Ingrediente carne = new Ingrediente("carne", 560);
            Ingrediente panRallado = new Ingrediente("pan", 90);
            Ingrediente huevo = new Ingrediente("huevo", 300);
            Ingrediente huevo2 = new Ingrediente("huevo", 600);
            Ingrediente harina = new Ingrediente("harina", 200);
            Ingrediente leche = new Ingrediente("leche", 150);
            Ingrediente papa = new Ingrediente("papa", 100);
            Bebida cocaCola = new Bebida("coca-cola", 1200, false);
            Bebida vermu = new Bebida("vermu", 3000, true);

            Restaurante.AgregarProducto(carne);
            Restaurante.AgregarProducto(carne);
            Restaurante.AgregarProducto(panRallado);
            Restaurante.AgregarProducto(huevo);
            Restaurante.AgregarProducto(huevo2);
            Restaurante.AgregarProducto(harina);
            Restaurante.AgregarProducto(leche);
            Restaurante.AgregarProducto(cocaCola);
            #endregion

            //--------------------------------------------------
            #region Empleados
            Encargado tomi = new Encargado("Tomas", "Fragnito", "esme123", 1139310243,14000);
            Encargado tomi2 = new Encargado("Tomas", "Fragnito", "esme123", 1139310243, 14000);
            Cocinero oscar = new Cocinero("Oscar", "Lele", "esme553", 1114343243, 14000);
            Mesero pablo = new Mesero("Pablo", "Koko", "esme999", 150978042, 14000);
            Delivery hector = new Delivery("Hector", "Mbappe", "esme451", 1198547632, 14000);
            Mesero mohamed = new Mesero("Mohamed", "Redriguez", "Colombres132", 1176341254, 14000);

            Restaurante.AgregarEmpleado(tomi);
            Restaurante.AgregarEmpleado(tomi);
            Restaurante.AgregarEmpleado(tomi2);
            Restaurante.AgregarEmpleado(oscar);
            Restaurante.AgregarEmpleado(pablo);
            Restaurante.AgregarEmpleado(hector);
            Restaurante.AgregarEmpleado(hector);
            Restaurante.AgregarEmpleado(mohamed);
            #endregion

            //--------------------------------------------------
            #region PlatosDeComida
            Dictionary<Ingrediente, double> ingredientesMilanesa = new Dictionary<Ingrediente, double>
            {
                {carne, 1},
                {huevo, 2},
                {panRallado, 2}
            };
            TimeSpan tiemporMilanesa = new TimeSpan(1, 30, 00);

            Dictionary<Ingrediente, double> ingredientesBife = new Dictionary<Ingrediente, double>
            {
                {carne, 1},
            };
            TimeSpan tiemporBife = new TimeSpan(1, 05, 00);

            Dictionary<Ingrediente, double> ingredientesHuevoFrito = new Dictionary<Ingrediente, double>
            {
                {huevo, 1},
            };
            TimeSpan tiemporHuevoFrito = new TimeSpan(0, 08, 00);

            Dictionary<Ingrediente, double> ingredientesPureDePapa = new Dictionary<Ingrediente, double>
            {
                {papa, 1},
                {leche, 2},
            };
            TimeSpan tiempoPureDePapa = new TimeSpan(0, 10, 00);

            PlatoDeComida milanesa = new PlatoDeComida("milanesa", ingredientesMilanesa, tiemporMilanesa);
            PlatoDeComida milanesa2 = new PlatoDeComida("milanesa", ingredientesMilanesa, tiemporMilanesa);
            PlatoDeComida bife = new PlatoDeComida("bife", ingredientesBife, tiemporBife);
            PlatoDeComida huevoFrito = new PlatoDeComida("huevoFrito", ingredientesHuevoFrito, tiemporHuevoFrito);
            PlatoDeComida pureDePapa = new PlatoDeComida("pureDePapa", ingredientesPureDePapa, tiempoPureDePapa);

            Menu.AgregarAlMenu(milanesa);
            Menu.AgregarAlMenu(milanesa);
            Menu.AgregarAlMenu(milanesa2);
            Menu.AgregarAlMenu(bife);
            Menu.AgregarAlMenu(huevoFrito);
            Menu.AgregarAlMenu(pureDePapa);
            Menu.AgregarAlMenu(vermu);
            Menu.AgregarAlMenu(cocaCola);
            Menu.AgregarAlMenu(leche);
            #endregion

            //--------------------------------------------------
            #region Proveedor
            List<DiasDeEngrega> diasDeEntregaMarolio = new List<DiasDeEngrega> { DiasDeEngrega.Lunes, DiasDeEngrega.Jueves };
            List<Producto> productosMarolio = new List<Producto> { carne, huevo, harina, panRallado };

            List<DiasDeEngrega> diasDeEntregaSancor = new List<DiasDeEngrega> { DiasDeEngrega.Miercoles };
            List<Producto> productosSancor = new List<Producto> { leche };

            List<DiasDeEngrega> diasDeEntregaBebidasPuntoCom = new List<DiasDeEngrega> { DiasDeEngrega.Miercoles };
            List<Producto> productosBebidasPuntoCom = new List<Producto> { cocaCola, vermu };

            Proveedor Marolio = new Proveedor("Marolio", 11342, "aca a la vuelta", productosMarolio, MedioDePago.Contado, diasDeEntregaMarolio);
            Proveedor Sancor = new Proveedor("Sancor", 45345, "cerca", productosSancor, MedioDePago.Tarjeta, diasDeEntregaSancor);
            Proveedor bebidasPuntoCom = new Proveedor("bebidasPuntoCom", 25345, "por ahi", productosBebidasPuntoCom, MedioDePago.Contado, diasDeEntregaBebidasPuntoCom);

            #endregion

            //--------------------------------------------------
            #region Mesa
            Dictionary<IItemMenu, double> pedidoDelCliente = new Dictionary<IItemMenu, double>
            {
                {milanesa, 4},
                {leche, 2},
            };
            Mesa mesa1 = new Mesa(1, 5, pedidoDelCliente);
            #endregion


            //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-
            // FUNCIONAMIENTO DEL CODIGO
            //-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-

            //--------------------------------------------------
            #region MUESTRA DEL ESTADO INICIAL DEL RESTAURANTE
            Console.WriteLine("---ESTADO INICIAL DEL RESTAURANTE---");
            tomi.MostrarDineroRestaurante();
            Console.WriteLine("DINERO INGRESADO:");
            tomi.IngresarDinero(100000);
            tomi.MostrarDineroRestaurante();
            Console.WriteLine("LISTA EMPLEADOS:");
            Restaurante.MostrarEmpleados();

            Console.WriteLine("");
            #endregion

            //--------------------------------------------------
            #region STOCK DE PRODUCTOS
            Console.WriteLine("---STOCK INICIAL DE PRODUCTOS---");
            tomi.MostrarStockProductos();
            Console.WriteLine("");
            Console.WriteLine("---PRECIO DE PRODUCTOS---");
            tomi.MostrarPrecioProductos();

            Console.WriteLine("");
            #endregion

            //--------------------------------------------------
            #region COMPRA DE PRODUCTOS
            Console.WriteLine("---COMPRAR PRODUCTOS------");
            tomi.ComprarProducto(huevo, 5, Marolio);
            tomi.ComprarProducto(carne, 15, Marolio);
            tomi.ComprarProducto(panRallado, 30, Marolio);
            tomi.ComprarProducto(harina, 20, Marolio);
            tomi.ComprarProducto(leche, 20, Sancor);
            tomi.ComprarProducto(cocaCola, 10, bebidasPuntoCom);
            tomi.ComprarProducto(vermu, 10, bebidasPuntoCom);

            Console.WriteLine("");
            #endregion

            //--------------------------------------------------
            #region STOCK DE PRODUCTOS
            Console.WriteLine("---STOCK DE PRODUCTOS---");
            tomi.MostrarStockProductos();
            Console.WriteLine("");
            Console.WriteLine("---PRECIOS DE PRODUCTOS---");
            tomi.MostrarPrecioProductos();

            Console.WriteLine("");
            #endregion

            //--------------------------------------------------
            #region COCINAR PLATOS DE COMIDA
            Console.WriteLine("---COCINAR DE PLATOS DE COMIDA------");
            milanesa.CocinarPlatoDeComida(10);

            Console.WriteLine("");
            #endregion

            //--------------------------------------------------
            #region STOCK DE PLATOS DE COMIDA
            Console.WriteLine("---STOCK DE PLATOS DE COMIDA------");
            Menu.MostrarStockDelMenu();

            Console.WriteLine("");
            #endregion

            //--------------------------------------------------
            #region ESTADO DE RESTAURANTE
            Console.WriteLine("---ESTADO DE RESTAURANTE------");
            Console.WriteLine("DINERO");
            tomi.MostrarDineroRestaurante();
            Console.WriteLine("DEUDA");
            tomi.MostrarDeudaRestaurante();

            Console.WriteLine("");
            #endregion

            //--------------------------------------------------

            #region PAGAR A LOS PROVEEDORES
            Console.WriteLine("---PAGAR A LOS PROVEEDORES------");
            Marolio.MostrarDinero();
            Console.WriteLine("pagar al proveedor");
            tomi.PagarProveedor(Marolio);
            tomi.PagarProveedor(bebidasPuntoCom);
            tomi.PagarProveedor(Sancor);

            Console.WriteLine("el proveedor cobro");
            Marolio.MostrarDinero();
            bebidasPuntoCom.MostrarDinero();
            Sancor.MostrarDinero();

            Console.WriteLine("");
            Console.WriteLine("ESTADO DE RESTAURANTE");
            Console.WriteLine("DINERO");
            tomi.MostrarDineroRestaurante();
            Console.WriteLine("DEUDA");
            tomi.MostrarDeudaRestaurante();

            Console.WriteLine("");
            #endregion

            //--------------------------------------------------
            #region MOSTRAR STOCK DE PRODUCTOS
            Console.WriteLine("---MOSTRAR STOCK DE PRODUCTOS------");
            tomi.MostrarStockCompras();

            Console.WriteLine("");
            #endregion

            //--------------------------------------------------
            #region MOSTRAR MENU

            Console.WriteLine("---MOSTRAR MENU------");
            Console.WriteLine("TODO EL MENU:");
            Menu.MostrarStockDelMenu();

            Console.WriteLine("");
            Console.WriteLine("PRECIOS DEL MENU:");
            Menu.MostrarPrecioDelMenu();

            Console.WriteLine("");
            #endregion

            //--------------------------------------------------
            #region MESAS ASIGNADAS

            Console.WriteLine("---MESAS ASIGNADAS------");
            pablo.ServirPedidoDelCliente(mesa1);
            pablo.CobrarMesa(mesa1);
            Console.WriteLine("COSTE TOTAL DE LA MESA:");
            mesa1.MostrarCosteTotal();
            mesa1.MostrarPedidol();

            Console.WriteLine("");
            #endregion

            //--------------------------------------------------
            #region ESTADO DE RESTAURANTE
            Console.WriteLine("---ESTADO DE RESTAURANTE------");
            Console.WriteLine("DINERO");
            tomi.MostrarDineroRestaurante();
            Console.WriteLine("DEUDA");
            tomi.MostrarDeudaRestaurante();

            Console.WriteLine("");
            #endregion
        }
    }
}
