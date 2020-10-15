namespace Practica2Ej1
{
    public class Radio : Aparato
    {
        private string bandas;

        public Radio(int nSerie, string modelo, float reparacionHora, string bandas) : base(nSerie, modelo, reparacionHora)
        {
            this.bandas = bandas;
            this.ReparacionHora = 5;
        }

        public string Bandas
        {
            get { return bandas; }
            set { bandas = value; }
        }
        
        public override string ToString()
        {
            return base.ToString() + bandas;
        }
    }
}