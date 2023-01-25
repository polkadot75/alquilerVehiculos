using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class Flota
    {
        // en la clase flota se almacenarán los Vehiculos
        private String nombreZona;
        private ArrayList vehiculos;

        public Flota()
        {
            vehiculos = new ArrayList();
        }

        public string NombreZona { get => nombreZona; set => nombreZona = value; }  // se puede o no quitar el set y el get

        // public ArrayList Vehiculos { get => vehiculos; }

        public void addVehiculos(Vehiculo veh) // 
        {
            vehiculos.Add(veh); //Ir añadiendo los vehiculos en el ArrayList
        }

        public void removeVehiculo(String matricula)
        {
            foreach (Vehiculo veh in vehiculos) // Por cada objeto del ArrayList de vehiculos haz de la clase de Vehiculo, veh como posicion in vehiculos, arraylist
            {
                if (veh.Matricula.Equals(matricula))
                {
                    // Console.WriteLine(veh.Matricula);
                    vehiculos.Remove(veh);
                }
            }

        }
    }
}