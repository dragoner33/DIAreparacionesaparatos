using System;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml.Linq;

namespace Practica2Ej1
{
    public class Reparacion
    {
        //private Aparato aparato;
        public int tiempo;
        private int nserie;
        private string modelo;
        private float reparacionHora;
        private string bandas;
        private int pulgadas;
        private bool blueray;
        private bool graban;
        private int tiempoGrab;
        private int tipo;

       /* public Reparacion(Aparato aparato, int tiempo)
        {
            this.aparato = aparato;
            this.tiempo = tiempo;
        }*/
        
        public Reparacion(int nserie, string modelo, float reparacionHora, string bandas, int tiempo)
        {
            this.nserie = nserie;
            this.modelo = modelo;
            this.reparacionHora = reparacionHora;
            this.bandas = bandas;
            this.tiempo = tiempo;
        }

        public Reparacion(int nserie, string modelo, float reparacionHora, int pulgadas, int tiempo)
        {
            this.tiempo = tiempo;
            this.nserie = nserie;
            this.modelo = modelo;
            this.reparacionHora = reparacionHora;
            this.pulgadas = pulgadas;
        }

        public Reparacion(int tiempo, int nserie, string modelo, float reparacionHora, bool blueray, bool graban, int tiempoGrab)
        {
            this.tiempo = tiempo;
            this.nserie = nserie;
            this.modelo = modelo;
            this.reparacionHora = reparacionHora;
            this.blueray = blueray;
            this.graban = graban;
            this.tiempoGrab = tiempoGrab;
            this.tipo = 5;
        }
        
        public Reparacion(int tiempo, int nserie, string modelo, float reparacionHora, bool blueray, bool graban)
        {
            this.tiempo = tiempo;
            this.nserie = nserie;
            this.modelo = modelo;
            this.reparacionHora = reparacionHora;
            this.blueray = blueray;
            this.graban = graban;
            this.tipo = 5;

            //this.tiempoGrab = tiempoGrab;
        }
        
        public Reparacion(int tiempo, int nserie, string modelo, float reparacionHora, bool graban, int tiempoGrab)
        {
            this.tiempo = tiempo;
            this.nserie = nserie;
            this.modelo = modelo;
            this.reparacionHora = reparacionHora;
            this.graban = graban;
            this.tiempoGrab = tiempoGrab;
            this.tipo = 6;

        }
        
        public Reparacion(int tiempo, int nserie, string modelo, float reparacionHora, bool graban)
        {
            this.tiempo = tiempo;
            this.nserie = nserie;
            this.modelo = modelo;
            this.reparacionHora = reparacionHora;
            this.graban = graban;
            this.tipo = 6;

            this.tiempoGrab = tiempoGrab;
        }

        public override string ToString()
        {
            return  "tiempo: " + tiempo;
        }

        public XElement SaveToXml()
        {
            var raizReparacion = new XElement("vacio");
            int caseSwitch;

            if (pulgadas > 0)
            {
                caseSwitch = 1;
            }else if (bandas.Length > 0)
            {
                caseSwitch = 2;
            }else if(tipo == 5)
            {
                caseSwitch = 3;
            }else if(tipo == 6){
                caseSwitch = 4;
            }
            else
            {
                caseSwitch = 0;
            }

            switch (caseSwitch)
            {
                case 1:
                    raizReparacion = new XElement("Televisor");

                    raizReparacion.Add(new XElement("Modelo", this.modelo),
                        new XElement("Numero_de_serie", this.nserie),
                        new XElement("Pulgadas", this.pulgadas),
                        new XElement("Precio_de_la_reparacion_por_hora", this.reparacionHora),
                        new XElement("Tiempo_que_dura_la_reparacion", this.tiempo)
                    );
                    return raizReparacion;
                case 2:
                    raizReparacion = new XElement("Radio");

                    raizReparacion.Add(new XElement("Modelo", this.modelo),
                        new XElement("Numero_de_serie", this.nserie),
                        new XElement("Bandas", this.bandas),
                        new XElement("Precio_de_la_reparacion_por_hora", this.reparacionHora),
                        new XElement("Tiempo_que_dura_la_reparacion", this.tiempo));
                    return raizReparacion;
                    //break;
                case 3:
                    raizReparacion = new XElement("ReproductorDVD");

                    if (graban)
                    {
                        raizReparacion.Add(new XElement("Modelo", this.modelo),
                            new XElement("Numero_de_serie", this.nserie),
                            new XElement("Blueray", this.blueray),
                            new XElement("Graba",this.graban),
                            new XElement("Tiempo_grabacion", this.tiempoGrab),
                            new XElement("Precio_de_la_reparacion_por_hora", this.reparacionHora),
                            new XElement("Tiempo_que_dura_la_reparacion", this.tiempo));
                    }
                    else
                    {
                        raizReparacion.Add(new XElement("Modelo", this.modelo),
                            new XElement("Numero_de_serie", this.nserie),
                            new XElement("Blueray", this.blueray),
                            new XElement("Graba",this.graban),
                            new XElement("Precio_de_la_reparacion_por_hora", this.reparacionHora),
                            new XElement("Tiempo_que_dura_la_reparacion", this.tiempo));
                    }

                    return raizReparacion;
                    //break;
                case 4:
                    raizReparacion = new XElement("Adaptador_TDT");
                    
                    if (graban)
                    {
                        raizReparacion.Add(new XElement("Modelo", this.modelo),
                            new XElement("Numero_de_serie", this.nserie),
                            new XElement("Graba",this.graban),
                            new XElement("Tiempo_grabacion", this.tiempoGrab),
                            new XElement("Precio_de_la_reparacion_por_hora", this.reparacionHora),
                            new XElement("Tiempo_que_dura_la_reparacion", this.tiempo));
                    }
                    else
                    {
                        raizReparacion.Add(new XElement("Modelo", this.modelo),
                            new XElement("Numero_de_serie", this.nserie),
                            new XElement("Graba",this.graban),
                            new XElement("Precio_de_la_reparacion_por_hora", this.reparacionHora),
                            new XElement("Tiempo_que_dura_la_reparacion", this.tiempo));
                    }
                    return raizReparacion;
                default:
                    raizReparacion = new XElement("Aparato");

                    raizReparacion.Add(new XElement("Modelo", this.modelo),
                        new XElement("Numero_de_serie", this.nserie),
                        new XElement("Precio_de_la_reparacion_por_hora", this.reparacionHora),
                        new XElement("Tiempo_que_dura_la_reparacion", this.tiempo));
                    
                    return raizReparacion;
            }
        }
    }
    
}