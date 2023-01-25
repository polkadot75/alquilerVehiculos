using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace alquilerVehiculos
{
    internal class Program
    {
        // Aquí debería mostrar los 3 dni's


        static void Main(string[] args)
        {
            Coche coche1 = new Coche();
            coche1.Matricula = "1111ZZZ";
            coche1.Matricula = "Nissan";
            coche1.Matricula = "Juke";
            coche1.Puertas = 5;


            Moto moto1 = new Moto();
            moto1.Matricula = "2222XXX";
            moto1.Matricula = "DUCATI";
            moto1.Matricula = "PANIGALE R";
            moto1.Cc = 1199;

            Camion camion1 = new Camion();
            camion1.Matricula = "3333YYY";
            camion1.Matricula = "Mercedes";
            camion1.Matricula = "K1";
            camion1.Kg = 2500;

            Cliente cliente1 = new Cliente();
            cliente1.Nif = "11111111A";
            cliente1.Nombre = "Josep";

            Cliente cliente2 = new Cliente();
            cliente2.Nif = "22222222B";
            cliente2.Nombre = "Ricardo";

            ContratoAlquiler contratoAlquiler1 = new ContratoAlquiler();
            contratoAlquiler1.Vehiculo = coche1; // no se pone el nombre de la matricula se pone el nombre del objeto como haríamos en la bbdd
            contratoAlquiler1.Cliente = cliente1;
            contratoAlquiler1.FechaInicio = DateTime.Parse("23/01/2023");
            contratoAlquiler1.FechaFin = DateTime.Parse("30/01/2023");

            ContratoAlquiler contratoAlquiler2 = new ContratoAlquiler();
            contratoAlquiler2.Vehiculo = moto1; // no se pone el nombre de la matricula se pone el nombre del objeto como haríamos en la bbdd
            contratoAlquiler2.Cliente = cliente1;
            contratoAlquiler2.FechaInicio = DateTime.Parse("01/02/2023");
            contratoAlquiler2.FechaFin = DateTime.Parse("05/02/2023");

            ContratoAlquiler contratoAlquiler3 = new ContratoAlquiler();
            contratoAlquiler3.Vehiculo = camion1; // no se pone el nombre de la matricula se pone el nombre del objeto como haríamos en la bbdd
            contratoAlquiler3.Cliente = cliente2;
            contratoAlquiler3.FechaInicio = DateTime.Parse("15/02/2023");
            contratoAlquiler3.FechaFin = DateTime.Parse("17/02/2023");

            contratoAlquiler3.Vehiculo.ToString();

            Console.WriteLine(contratoAlquiler1.nDias());

            // Console.WriteLine(contratoAlquiler3.FechaInicio.ToString());
            // Console.WriteLine(contratoAlquiler3.ToString());

            Console.WriteLine(cliente1);
            Console.WriteLine(contratoAlquiler1.Cliente.Nombre);

            VehiculosRent vehiculosRent = new VehiculosRent(); //El array list es un atributo dentro de una clase
            
            vehiculosRent.Nif = "11112233E";
            vehiculosRent.Nombre = "Comercial Motera";

            vehiculosRent.ListaClientes.Add(cliente1);
            vehiculosRent.ListaClientes.Add(cliente2);

            /*ArrayList cosas = new ArrayList(20); //tamaño variable, redimensiona espacio de memoria, aunque por rendimiento se reserva un espacio de memoria inical , se almacenan objetos
             
            cosas.Add(cliente1); // para añadir al ArrayList
            cosas.Add(cliente2);

            Console.WriteLine(cosas.Count); */// cuenta los espacios de memoria

            // No se usa ni los writeLine  ni los ReadLine porque no es necesario que el cliente almacene ni escriba ningun tipo de dato

            Flota flota = new Flota(); 

            flota.addVehiculos(coche1);
            flota.addVehiculos(moto1);
            flota.addVehiculos(camion1);
            flota.removeVehiculo("1111ZZZ");

        }
    }
}
