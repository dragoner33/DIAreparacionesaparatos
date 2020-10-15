using System;

namespace Practica2Ej1
{
    public class Reparacion
    {
        private Aparato aparato;
        public int tiempo;
        
        public Reparacion(Aparato aparato, int tiempo)
        {
            this.aparato = aparato;
            this.tiempo = tiempo;
        }

        public override string ToString()
        {
            return this.aparato.ToString() + tiempo;
        }
    }
    
}