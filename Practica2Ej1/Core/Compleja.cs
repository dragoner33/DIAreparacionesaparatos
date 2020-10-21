namespace Practica2Ej1
{
    public class Compleja : Reparacion
    {
        private double precio;
        private int mediaHora;

        public Compleja(int nserie, string modelo, float reparacionHora, string bandas, int tiempo) : base(nserie, modelo, reparacionHora, bandas, tiempo)
        {
            this.mediaHora = tiempo / 30;
            precio = (reparacionHora / 2) * mediaHora;
            precio = precio + (precio * 0.25);

        }
        
        public Compleja(int nserie, string modelo, float reparacionHora, int pulgadas, int tiempo) : base(nserie, modelo, reparacionHora, pulgadas, tiempo)
        {
            this.mediaHora = tiempo / 30;
            precio = (reparacionHora / 2) * mediaHora;
            precio = precio + (precio * 0.25);
        }
        public Compleja(int tiempo, int nserie, string modelo, float reparacionHora, bool blueray, bool graban, int tiempoGrab) : base(tiempo, nserie, modelo, reparacionHora, blueray, graban, tiempoGrab)
        {
            this.mediaHora = tiempo / 30;
            precio = (reparacionHora / 2) * mediaHora;
            precio = precio + (precio * 0.25);

        }

        public Compleja(int tiempo, int nserie, string modelo, float reparacionHora, bool blueray, bool graban) : base(tiempo, nserie, modelo, reparacionHora, blueray, graban)
        {
            this.mediaHora = tiempo / 30;
            precio = (reparacionHora / 2) * mediaHora;
            precio = precio + (precio * 0.25);

        }

        public Compleja(int tiempo, int nserie, string modelo, float reparacionHora, bool graban, int tiempoGrab) : base(tiempo, nserie, modelo, reparacionHora, graban, tiempoGrab)
        {
            this.mediaHora = tiempo / 30;
            precio = (reparacionHora / 2) * mediaHora;
            precio = precio + (precio * 0.25);
        }

        public Compleja(int tiempo, int nserie, string modelo, float reparacionHora, bool graban) : base(tiempo, nserie, modelo, reparacionHora, graban)
        {
            this.mediaHora = tiempo / 30;
            precio = (reparacionHora / 2) * mediaHora;
            precio = precio + (precio * 0.25);
        }
        
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }
        public override string ToString()
        {
            return "Reparacion Compleja " + base.ToString() + " precio: " + precio;
        }
    }
}