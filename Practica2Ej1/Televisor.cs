namespace Practica2Ej1
{
    public class Televisor : Aparato
    {
        private int pulgadas;

        public Televisor(int nSerie, string modelo, float reparacionHora, int pulgadas) : base(nSerie, modelo, reparacionHora)
        {
            this.pulgadas = pulgadas;
            this.ReparacionHora = 10;
        }

        public int Pulgadas
        {
            get { return pulgadas; }
            set { pulgadas = value; }
        }
        
        public override string ToString()
        {
            return base.ToString() + pulgadas;
        }
    }
}