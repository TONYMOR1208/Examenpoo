using System;
using System.Collections.Generic;
using System.Text;

namespace ExamenPrimerParcial
{
    class Capitan:Tripulante,IcalculoBono
    {
        public int horasexperticia { get; set; }
        public int sueldo  {get; set;} 

        public int sueldototal {get; set;}
        public  double bono { get; set;}

        public Capitan(string nombre, int telefono, int cedula, int edad, string TiempoEnLaEmpresa, string sexo, string barco, int horasexperticia, int sueldo, int sueldototal, double bono)
            : base(nombre, telefono, cedula, edad, TiempoEnLaEmpresa, sexo, barco)
        {
            this.horasexperticia = horasexperticia;
            this.sueldo = sueldo;
            this.sueldototal = sueldototal;
            this.bono = bono;

        }

        public int calculoBono()
        {
            return 37474883;


        }

        public override  void imprimiratributos()
        {
            Console.WriteLine("   Datos del capitan  ");
            Console.WriteLine("---------------");
            Console.WriteLine("Cedula  :" + cedula);
            Console.WriteLine("Nombre " + nombre);
            Console.WriteLine("sexo :" + sexo);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Telefono: " + telefono);
            Console.WriteLine("Tiempo en la empresa : " + TiempoEnLaEmpresa);
            Console.WriteLine("Sueldo base :" + sueldo);
            Console.WriteLine("bono :" + bono);
            Console.WriteLine("Sueldo total: " + sueldototal);

        }

    }
}
