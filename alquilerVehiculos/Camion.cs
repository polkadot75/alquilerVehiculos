﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class Camion : Vehiculo
    {
        private int kg;

        public int Kg { get => kg; set => kg = value; }
    }
}
