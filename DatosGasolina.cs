using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlaZuñiga3B_gasolina_.CLASES
{
    public class DatosGasolina
    {

        private string tipogasolina;

        public string Tipogasolina
        {
            get { return tipogasolina; }
            set { tipogasolina = value; }
        }

        private int cantidadgalones;

        public int Cantidadgalones
        {
            get { return cantidadgalones; }
            set { cantidadgalones = value; }
        }

        private double precioventa;

        public double PrecioVenta
        {
            get { return precioventa; }
            set { precioventa = value; }
        }

        public DatosGasolina(string tipogasolina, int cantidadgalones, double precioVenta)
        {
            Tipogasolina = tipogasolina;
            Cantidadgalones = cantidadgalones;
            PrecioVenta = precioVenta;
        }

        public double Subtotal
        {
            get { return Total - Iva; }

        }

        public double Iva
        {
            get { return Total * 0.12; }

        }

        public double Total
        {
            get { return cantidadgalones * precioventa; }
        }

    }
}
