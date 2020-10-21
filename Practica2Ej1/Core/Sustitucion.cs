using System;

namespace Practica2Ej1
{
    public class Sustitucion : Reparacion
    {
        private double precio;
        private int mediaHora;

        public Sustitucion(int nserie, string modelo, float reparacionHora, string bandas, int tiempo) : base(nserie, modelo, reparacionHora, bandas, tiempo)
        {
            this.mediaHora = tiempo / 30;
            if (tiempo > 30)
            {
                this.precio = reparacionHora * 2;
                if (this.precio < 10)
                {
                    this.precio = 10;
                }
            }
            else
            {
                this.precio = 10;
            }

        }

        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public Sustitucion(int nserie, string modelo, float reparacionHora, int pulgadas, int tiempo) : base(nserie, modelo, reparacionHora, pulgadas, tiempo)
        {
            this.mediaHora = tiempo / 30; 
            if (mediaHora > 1)
            {
                this.precio = 20;
            }
            else
            {
                this.precio = 10;
            }
        }

        public Sustitucion(int tiempo, int nserie, string modelo, float reparacionHora, bool blueray, bool graban, int tiempoGrab) : base(tiempo, nserie, modelo, reparacionHora, blueray, graban, tiempoGrab)
        {
            this.mediaHora = tiempo / 30; 
            if (tiempo > 30)
            {
                Console.Write("Hola aqui estoy");
                this.precio = 20;
            }
            else
            {
                Console.Write("nope");
                this.precio = 10;
            }

        }

        public Sustitucion(int tiempo, int nserie, string modelo, float reparacionHora, bool blueray, bool graban) : base(tiempo, nserie, modelo, reparacionHora, blueray, graban)
        {
            this.mediaHora = tiempo / 30; 
            if (tiempo > 30)
            {
                this.precio = 20;
            }
            else
            {
                this.precio = 10;
            }

        }

        public Sustitucion(int tiempo, int nserie, string modelo, float reparacionHora, bool graban, int tiempoGrab) : base(tiempo, nserie, modelo, reparacionHora, graban, tiempoGrab)
        {
            this.mediaHora = tiempo / 30;
            if (mediaHora > 1)
            {
                this.precio = reparacionHora * 2;
                if (this.precio < 10)
                {
                    this.precio = 10;
                }
            }
            else
            {
                this.precio = 10;
            }
        }

        public Sustitucion(int tiempo, int nserie, string modelo, float reparacionHora, bool graban) : base(tiempo, nserie, modelo, reparacionHora, graban)
        {
            this.mediaHora = tiempo / 30; 
            if (mediaHora > 1)
            {
                this.precio = reparacionHora * 2;
                if (this.precio < 10)
                {
                    this.precio = 10;
                }
            }
            else
            {
                this.precio = 10;
            }
        }

        public override string ToString()
        {
            return "Sustitucion de piezas" + base.ToString() + " precio: " + precio;
        }
    }
}