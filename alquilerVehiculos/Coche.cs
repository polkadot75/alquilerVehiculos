using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class Coche : Vehiculo
    {
        private int plazas;
        private int puertas;

        public Coche()
        {
            // this (Hace referencia a esta clase)
            // base (Hace referencia a otra clase)

            this.puertas = 5;

        }

        public int Puertas { get => puertas; set => puertas = value; }
        public int Plazas { get => plazas; set => plazas = value; }
    }
}