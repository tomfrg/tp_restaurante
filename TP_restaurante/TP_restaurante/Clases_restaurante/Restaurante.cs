using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_restaurante.Clases_restaurante
{
    internal static class Restaurante
    {
        public static string _nombre;
        public static List<Empleado> _listaEmpleados = new List<Empleado>();
        public static List<Menu> _listaMenu = new List<Menu>();
        public static List<Proveedor> _listaProveedores = new List<Proveedor>();
        public static int _cantidadDeMesas;
        public static void AgregarProveedor(Proveedor proveedor)
        {

        }
        public static void AgregarEmpleado(Empleado empleado)
        {
            if (!_listaEmpleados.Any(e => e == empleado))
            {
                _listaEmpleados.Add(empleado);
            }
            else
            {
                MessageBox.Show("Ya existe un usuario identico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void AgregarMenu(Menu menu)
        {

        }

    }

}
