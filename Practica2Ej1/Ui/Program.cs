using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using WForms = System.Windows.Forms;

namespace Practica2Ej1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine( "Reparaciones recuperadas:" );
            foreach (Reparacion r in recuperaReparacion( "reparaciones.xml" )) {
                //Console.WriteLine( "aqui");
                Console.WriteLine( r.ToString());
            }
            
            WForms.Application.Run( new MainWindowCtrl().View);
        }
        
        static void SaveReparacion(string nf, IEnumerable<Reparacion> reparaciones)
        {
            var raiz = new XElement( "reparacion" );
    
            foreach(Reparacion reparacion in reparaciones) {
                raiz.Add( reparacion.SaveToXml() );
            }
            raiz.Save( nf );
        }
        
        static IEnumerable<Reparacion> recuperaReparacion(string nf)
        {
            var docXml = XElement.Load( nf );
            
            IEnumerable<Reparacion> toret =
                from reparacionXml in docXml.Elements( "Radio" )
                select new Reparacion(
                   // int nserie, string modelo, float reparacionHora, string bandas, int tiempo
                    (int) reparacionXml.Element( "Numero_de_serie" ),
                    (string) reparacionXml.Element( "Modelo" ),
                    (float) reparacionXml.Element( "Precio_de_la_reparacion_por_hora" ),
                    (string) reparacionXml.Element( "Bandas" ),
                    (int) reparacionXml.Element("Tiempo_que_dura_la_reparacion"));
            
            return toret;
        }
    }
}