using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class Moto : Vehiculo //Hereda de Vehiculo
    {
        private int cc;

        public int Cc { get => cc; set => cc = value; }
    }
}
