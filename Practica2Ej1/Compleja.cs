namespace Practica2Ej1
{
    public class Compleja : Reparacion
    {
        private float precio;
        private int mediaHora;
        public Compleja(Aparato aparato, int tiempo) : base(aparato, tiempo)
        {
            mediaHora = tiempo / 30;
            precio = aparato.ReparacionHora * mediaHora;
            precio = precio + ((precio * 25) / 100);
        }

        public float Precio
        {
            get { return precio; }
        }
        
        public override string ToString()
        {
            return "Reparacion Compleja " + base.ToString() + precio;
        }
    }
}