using System;

namespace Practica2Ej1
{
    public class Sustitucion : Reparacion
    {
        private float precio;
        private int mediaHora;
        public Sustitucion(Aparato aparato, int tiempo) : base(aparato, tiempo)
        {
            //Console.WriteLine("aqui");
            mediaHora = tiempo / 30;
            if (mediaHora < 1)
            {
                precio = aparato.ReparacionHora / 2;
            }
            else
            {
                precio = aparato.ReparacionHora * mediaHora;
            }
        }

        public float Precio
        {
            get { return precio; }
        }

        public override string ToString()
        {
            return "Sustitucion de piezas" + base.ToString() + precio;
        }
    }
}