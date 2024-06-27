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

            #region Mesa
            List<PlatoDeComida> listaPlatosDeComida = new List<PlatoDeComida> { milanesa };

            //Mesa mesa = new Mesa(1,pablo, );
            #endregion

            //--------------------------------------------------

            Marolio.MostrarDinero();
            Sancor.MostrarDinero();
            
            tomi.MostrarDineroRestaurante();
            Restaurante.IngresarDinero(100000);
            tomi.MostrarDineroRestaurante();

            tomi.ComprarProducto(huevo, 5, Marolio);
            tomi.ComprarProducto(carne, 15, Marolio);
            tomi.ComprarProducto(panRallado, 30, Marolio);
            tomi.ComprarProducto(harina, 20, Marolio);
            tomi.ComprarProducto(leche, 20, Sancor);
            tomi.ComprarProducto(cocaCola, 10, bebidasPuntoCom);
            tomi.ComprarProducto(vermu, 10, bebidasPuntoCom);

            Console.WriteLine("-----------------------");
            tomi.MostrarStockProducto();
            Console.WriteLine("-----------------------");

            tomi.MostrarDineroRestaurante();
            tomi.MostrarDeudaRestaurante();
            Console.WriteLine("-----------------------");

            tomi.EliminarProducto(harina);

            tomi.MostrarStockProducto();

            tomi.MostrarDineroRestaurante();
            Marolio.MostrarDinero();
            Sancor.MostrarDinero();
            Console.WriteLine("------------------------------------");
            milanesa.CocinarPlatoDeComida(10);
            milanesa.MostrarStock();
            tomi.MostrarStockProducto();
            Console.WriteLine("------------------------------------");
            Menu.MostrarMenu();
            tomi.MostrarDineroRestaurante();
            Console.WriteLine("------------------------------------");
            Dictionary<IItemMenu, double> pedidoDelCliente = new Dictionary<IItemMenu, double>
            {
                {milanesa, 4},
                {leche, 2},
            };
            Mesa mesa1 = new Mesa(1, 5, pedidoDelCliente);
            pablo.ServirPedidoDelCliente(mesa1);
            pablo.CobrarMesa(mesa1);
            mesa1.MostrarCosteTotal();
            Console.WriteLine("------------------------------------");
            Menu.MostrarMenu();
            tomi.MostrarDineroRestaurante();
            Menu.MostrarPrecio(milanesa);
            Menu.MostrarPrecio(leche);
            mesa1.MostrarPedidol();
        }
    }
}
