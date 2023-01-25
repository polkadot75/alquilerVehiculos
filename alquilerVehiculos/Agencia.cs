using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class Agencia
    {
        private String nombre;
        private Flota flota;
        private ArrayList listaContratos;

        public Agencia()
        {
            this.listaContratos = new ArrayList();
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public ArrayList ListaContratos { get => listaContratos; set => listaContratos = value; }
        public Flota Flota { get => flota; set => flota = value; }

    }
}
