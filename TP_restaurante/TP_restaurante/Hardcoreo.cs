using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_restaurante.Clases_restaurante;

namespace TP_restaurante
{

    public static class Hardcoreo
    {
        public static List<Producto> _listaProductos = new List<Producto>
        {
            new Producto("Manzana", 50, 1.20),
            new Producto("Banana", 30, 0.80),
            new Producto("Naranja", 20, 0.90),
            new Producto("Fresa", 100, 2.00),
            new Producto("Pera", 40, 1.50),
            new Producto("Melón", 15, 3.00),
            new Producto("Sandía", 10, 4.00)
        };

        public static List<Empleado> _listaEmpleados = new List<Empleado>
        {
            new Empleado("Juan", "Pérez", "Calle Falsa 123", 123456789, RolesEmpleados.Cocinero),
            new Empleado("Ana", "Gómez", "Av. Siempre Viva 742", 987654321, RolesEmpleados.Mesero),
            new Empleado("Tomas", "Fragnito", "Esmeralda", 124356342, RolesEmpleados.Encargado)
        };

        public static void Hardcorear(Form1 form1)
        {
            foreach (var usuario in _listaEmpleados)
            {
                Restaurante.AgregarEmpleado(usuario);
            }

            foreach (var producto in _listaProductos)
            {
                Almacen.AlmacenarProducto(producto);
            }

        }
    }
}
