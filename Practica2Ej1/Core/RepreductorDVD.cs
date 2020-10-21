using System;

namespace Practica2Ej1
{
    public class RepreductorDVD : Aparato
    {
        private bool blueray;
        private bool graban;
        private int tiempo;

        public RepreductorDVD(int nSerie, string modelo, float reparacionHora, bool blueray, bool graban) : base(nSerie, modelo, reparacionHora)
        {
            this.blueray = blueray;
            this.graban = false;
            this.ReparacionHora = 10;
        }
        
        public RepreductorDVD(int nSerie, string modelo, float reparacionHora, bool blueray, bool graban, int tiempo) : base(nSerie, modelo, reparacionHora)
        {
            this.blueray = blueray;
            this.graban = true;
            this.tiempo = tiempo;
            this.ReparacionHora = 10;
        }

        public bool Blueray
        {
            get { return blueray; }
            set { blueray = value; }
        }

        public bool Graban
        {
            get { return graban; }
            set { graban = value; }
        }
        
        public override string ToString()
        {
            return base.ToString() + graban + tiempo;
        }
    }
}