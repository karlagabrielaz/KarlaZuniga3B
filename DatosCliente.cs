using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarlaZuñiga3B_gasolina_.CLASES
{
    public class DatosCliente
    {
        private string apellidos;

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        private string nombres;

        public string Nombres
        {
            get { return nombres; }
            set { nombres = value; }
        }

        private int cedula;

        public int Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        private string direccion;

        public DatosCliente(string apellidos, string nombres, int cedula, string direccion)
        {
            Apellidos = apellidos;
            Nombres = nombres;
            Cedula = cedula;
            Direccion = direccion;
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }




    }
}
