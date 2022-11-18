using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
    class JefeFlota : Tripulante, IcalculoBono
    {
        public string pesopescado { get; set; }
        public string peromerisco { get; set; }
        public int sueldob { get; set; }
        public int sueldototal { get; set; }
        public double bono { get; set; }
        public string bonopescado { get; set; }
        public string bonomarisco { get; set; }

        public JefeFlota(string nombre, int telefono, int cedula, int edad, string TiempoEnLaEmpresa, string sexo, string barco, string pesopescado, string peromerisco, int sueldo, int sueldototal, double bono, string bonopescado, string bonomarisco)
            : base(nombre, telefono, cedula, edad, TiempoEnLaEmpresa, sexo, barco)
        {
            this.pesopescado = pesopescado;
            this.peromerisco = peromerisco;
            this.sueldob = sueldo;
            this.sueldototal = sueldototal;
            this.bono = bono;
            this.bonopescado = bonopescado;
            this.bonomarisco = bonomarisco;
        }

        public int  calculoBono()
        {
            return 3944;



        }

        public override void imprimiratributos()
        {
            Console.WriteLine("   Datos del Jefe de flota  ");
            Console.WriteLine("---------------");
            Console.WriteLine("Cedula  :" + cedula);
            Console.WriteLine("Nombre " + nombre);
            Console.WriteLine("sexo :" + sexo);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Telefono: " + telefono);
            Console.WriteLine("Tiempo en la empresa : " + TiempoEnLaEmpresa);
            Console.WriteLine("Sueldo base: "+ sueldob);
            Console.WriteLine("Bono por pescado: " + bonopescado);
            Console.WriteLine("Bono por marisco: " + bonomarisco);
            Console.WriteLine("Sueldo Total: " + sueldototal);



        }

    }
}


