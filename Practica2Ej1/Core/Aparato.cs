namespace Practica2Ej1
{
    public class Aparato
    {
        private int nSerie;
        private string modelo;
        private float reparacionHora;

        public Aparato(int nSerie, string modelo, float reparacionHora)
        {
            this.nSerie = nSerie;
            this.modelo = modelo;
            this.reparacionHora = reparacionHora;
        }

        public int NSerie
        {
            get { return nSerie; }
            set { nSerie = value; }
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public float ReparacionHora
        {
            get { return reparacionHora; }
            set { reparacionHora = value; }
        }

        public override string ToString()
        {
            return nSerie + modelo + reparacionHora;
        }
    }
}