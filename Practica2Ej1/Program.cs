using System;

namespace Practica2Ej1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Aparato aparato = new Radio(1,"modelo",10,"mf");
            Reparacion r1 = new Reparacion(aparato,120);
            if (r1.tiempo <= 60)
            {
                //Console.WriteLine("hola");
                r1 = new Sustitucion(aparato,r1.tiempo);
                
                //Console.WriteLine("hola");
            }
            else
            {
                r1 = new Compleja(aparato,r1.tiempo);
            }
            Console.WriteLine(r1.ToString());
            //Console.WriteLine(sustitucion.ToString());
            
            
            
            //float a = r1.calcularPrecio(10, aparato);
            //Console.WriteLine(a);
        }
    }
}