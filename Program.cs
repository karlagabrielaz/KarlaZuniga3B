using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KarlaZuñiga3B_gasolina_.CLASES;

namespace KarlaZuñiga3B_gasolina_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("EMPRESA TERCER NIVEL CÍA. LTDA");
            Console.WriteLine("BIENVENIDO(A)");
            Console.WriteLine();

            DatosCliente datosCliente1 = new DatosCliente("Zúniga Reinoso", "Karla Gabriela", 1351289093, "Cdla Los Eléctricos");
            DatosCliente datosCliente2 = new DatosCliente("Espinales Moreira", "Diego Xavier", 1358897815, "Ciudad Jardín");

            DatosGasolina datosgasolina1 = new DatosGasolina("Extra", 3, 1.50);
            DatosGasolina datosgasolina2 = new DatosGasolina("Super", 5, 2.00);

            

            Console.WriteLine("Apellidos: {0}\nNombres: {1}\nCédula de Identidad: {2}\nDirección Domiciliaria: {3}", datosCliente1.Apellidos, datosCliente1.Nombres, datosCliente1.Cedula, datosCliente1.Direccion);
            Console.WriteLine();
            Console.WriteLine("Tipo Gasolina: {0}\nCantidad de galones: {1}\nPrecio de la gasolina: ${2}\n\nSubtotal: ${3}\nIVA: ${4}\nTotal: ${5}", datosgasolina1.Tipogasolina, datosgasolina1.Cantidadgalones, datosgasolina1.PrecioVenta, datosgasolina1.Subtotal, datosgasolina1.Iva, datosgasolina1.Total);

            
            Console.WriteLine("\n*****************************************\n");
       

            Console.WriteLine("Apellidos: {0}\nNombres: {1}\nCédula de Identidad: {2}\nDirección Domiciliaria: {3}", datosCliente2.Apellidos, datosCliente2.Nombres, datosCliente2.Cedula, datosCliente2.Direccion);
            Console.WriteLine();
            Console.WriteLine("Tipo Gasolina: {0}\nCantidad de galones: {1}\nPrecio de la gasolina: ${2}\n\nSubtotal: ${3}\nIVA: ${4}\nTotal: ${5}", datosgasolina2.Tipogasolina, datosgasolina2.Cantidadgalones, datosgasolina2.PrecioVenta, datosgasolina2.Subtotal, datosgasolina2.Iva, datosgasolina2.Total);

            Console.ReadKey();
        }
    }
}
