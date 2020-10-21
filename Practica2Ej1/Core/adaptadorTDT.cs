namespace Practica2Ej1
{
    public class adaptadorTDT : Aparato
    {
        private bool graba;
        private int tiempograba;

        public bool Graba
        {
            get { return graba; }
            set { graba = value; }
        }

        public int Tiempograba
        {
            get { return tiempograba; }
            set { tiempograba = value; }
        }

        public adaptadorTDT(int nSerie, string modelo, float reparacionHora, bool graba) : base(nSerie, modelo, reparacionHora)
        {
            this.graba = false;
            this.ReparacionHora = 5;
        }

        public adaptadorTDT(int nSerie, string modelo, float reparacionHora, bool graba, int tiempograba) : base(nSerie, modelo, reparacionHora)
        {
            this.graba = true;
            this.tiempograba = tiempograba;
            this.ReparacionHora = 5;
        }
        
        public override string ToString()
        {
            return base.ToString() + graba + tiempograba;
        }
    }
}