using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Xml.Linq;

namespace Practica2Ej1
{
    using WForms = System.Windows.Forms;

    public class MainWindowCtrl
    {
        public MainWindowCtrl()
        {
            this.View = new MainWindowView();
            this.View.bluerayBox.Visible = false;
            this.View.bluerayLabel.Visible = false;
            this.View.tiempoGrabaLabel.Visible = false;
            this.View.tiempoGrabaTexto.Visible = false;
            this.View.bandas.Visible = false;
            this.View.bandasLabel.Visible = false;
            this.View.BtOpera.Click += (sender,  args) => this.OnBtOperaClick();
            this.View.CbOperacion.SelectedIndexChanged += (sender,  args) => this.OnSelectAparatoClick();
            //if(this.View.CbOperacion.Text

        }
        
        static void SaveReparacion(string nf, IEnumerable<Reparacion> reparaciones)
        {
            var raiz = new XElement( "reparacion" );
    
            foreach(Reparacion reparacion in reparaciones) {
                raiz.Add( reparacion.SaveToXml() );
            }
            raiz.Save( nf );
        }

        void OnSelectAparatoClick()
        {
            //Console.Write(this.View.CbOperacion.Text);
            if (!this.View.CbOperacion.Text.Equals("Televisor"))
            {
                this.View.pulgadasLabel.Visible = false;
                this.View.pulgadasTexto.Visible = false;
            }else
            {
                this.View.pulgadasLabel.Visible = true;
                this.View.pulgadasTexto.Visible = true;
            }
            if (!this.View.CbOperacion.Text.Equals("Radio"))
            {
                this.View.bandasLabel.Visible = false;
                this.View.bandas.Visible = false;
            }else
            {
                this.View.bandasLabel.Visible = true;
                this.View.bandas.Visible = true;
            }
            if (!this.View.CbOperacion.Text.Equals("ReproductorDVD") && !this.View.CbOperacion.Text.Equals("AdaptadorTDT"))
            {
                this.View.bluerayBox.Visible = false;
                this.View.bluerayLabel.Visible = false;
                this.View.tiempoGrabaLabel.Visible = false;
                this.View.tiempoGrabaTexto.Visible = false;
            }
            else
            {
                if (this.View.CbOperacion.Text.Equals("ReproductorDVD"))
                {
                    this.View.bluerayBox.Visible = true;
                    this.View.bluerayLabel.Visible = true;
                }
                else
                {
                    this.View.bluerayBox.Visible = false;
                    this.View.bluerayLabel.Visible = false;
                }
                this.View.tiempoGrabaLabel.Visible = true;
                this.View.tiempoGrabaTexto.Visible = true;
            }
        }
        void OnBtOperaClick()
        {
            /////////////////////////////////////////////////////
            //////////////////////////////////////////////////
            //////////////////////////////////////////////////
            int op1;
            string strOp1 = this.View.EdOp1.Text;
            string aparato = this.View.CbOperacion.Text;
            string nSerie = this.View.var1valTexto.Text;
            string modelo = this.View.var2valTexto.Text;
            string bandas = this.View.bandas.Text;
            string pulgadas = this.View.pulgadasTexto.Text;
            string blueRay = this.View.bluerayBox.Text;
            string tiempoGraba = this.View.tiempoGrabaTexto.Text;
            bool BRbool = false;

            if (int.Parse(strOp1) <= 60)
            {
                Console.Write("Sustitucion");
                if (aparato.Equals("Televisor"))
                {
                    Console.Write("Tele");
                    Sustitucion Televisor = new Sustitucion(int.Parse(nSerie),modelo,10,pulgadas,int.Parse(strOp1));
                    this.View.EdRes.Text = Televisor.Precio.ToString();
                    SaveReparacion("reparaciones.xml", new [] {Televisor});
                }else if (aparato.Equals("Radio"))
                {
                    Console.Write("Radio");
                    Sustitucion Radio = new Sustitucion(int.Parse(nSerie),modelo,5,bandas,int.Parse(strOp1));
                    this.View.EdRes.Text = Radio.Precio.ToString();
                    SaveReparacion("reparaciones.xml", new [] {Radio});
                }else if (aparato.Equals("ReproductorDVD"))
                {
                    if (blueRay.Equals("si"))
                    {
                        BRbool = true;
                    }

                    if (int.Parse(tiempoGraba) > 0)
                    {
                        Sustitucion DVD = new Sustitucion(int.Parse(strOp1),int.Parse(nSerie),modelo,10,BRbool,true,int.Parse(tiempoGraba));
                        this.View.EdRes.Text = DVD.Precio.ToString();
                        SaveReparacion("reparaciones.xml", new [] {DVD});
                    }
                    else
                    {
                        Sustitucion DVD = new Sustitucion(int.Parse(strOp1),int.Parse(nSerie),modelo,10,BRbool,false);
                        this.View.EdRes.Text = DVD.Precio.ToString();
                        SaveReparacion("reparaciones.xml", new [] {DVD});
                    }
                }else if (aparato.Equals("AdaptadorTDT"))
                {
                    if (int.Parse(tiempoGraba) > 0)
                    {
                        Sustitucion TDT = new Sustitucion(int.Parse(strOp1),int.Parse(nSerie),modelo,5,true,int.Parse(tiempoGraba));
                        this.View.EdRes.Text = TDT.Precio.ToString();
                        SaveReparacion("reparaciones.xml", new [] {TDT});
                    }
                    else
                    {
                        Sustitucion TDT = new Sustitucion(int.Parse(strOp1),int.Parse(nSerie),modelo,5,false);
                        this.View.EdRes.Text = TDT.Precio.ToString();
                        SaveReparacion("reparaciones.xml", new [] {TDT});
                    } 
                }
            }
            else
            {
                Console.Write("Compleja");
                if (aparato.Equals("Televisor"))
                {
                    Console.Write("Compleja televisor");
                    Compleja Televisor = new Compleja(int.Parse(nSerie),modelo,10,pulgadas,int.Parse(strOp1));
                    this.View.EdRes.Text = Televisor.Precio.ToString();
                    SaveReparacion("reparaciones.xml", new [] {Televisor});
                }else if (aparato.Equals("Radio"))
                {
                    Compleja Radio = new Compleja(int.Parse(nSerie),modelo,5,bandas,int.Parse(strOp1));
                    this.View.EdRes.Text = Radio.Precio.ToString();
                    SaveReparacion("reparaciones.xml", new [] {Radio});
                }else if (aparato.Equals("ReproductorDVD"))
                {
                    if (blueRay.Equals("si"))
                    {
                        BRbool = true;
                    }

                    if (int.Parse(tiempoGraba) > 0)
                    {
                        Compleja DVD = new Compleja(int.Parse(strOp1),int.Parse(nSerie),modelo,10,BRbool,true,int.Parse(tiempoGraba));
                        this.View.EdRes.Text = DVD.Precio.ToString();
                        SaveReparacion("reparaciones.xml", new [] {DVD});
                    }
                    else
                    {
                        Compleja DVD = new Compleja(int.Parse(strOp1),int.Parse(nSerie),modelo,10,BRbool,false);
                        this.View.EdRes.Text = DVD.Precio.ToString();
                        SaveReparacion("reparaciones.xml", new [] {DVD});
                    }
                }else if (aparato.Equals("AdaptadorTDT"))
                {
                    if (int.Parse(tiempoGraba) > 0)
                    {
                        Compleja TDT = new Compleja(int.Parse(strOp1),int.Parse(nSerie),modelo,5,true,int.Parse(tiempoGraba));
                        this.View.EdRes.Text = TDT.Precio.ToString();
                        SaveReparacion("reparaciones.xml", new [] {TDT});
                    }
                    else
                    {
                        Compleja TDT = new Compleja(int.Parse(strOp1),int.Parse(nSerie),modelo,5,false);
                        this.View.EdRes.Text = TDT.Precio.ToString();
                        SaveReparacion("reparaciones.xml", new [] {TDT});
                    } 
                }
            }
            


            //Console.Write(op1);
        }
        public MainWindowView View {
            get;
            set;
        }
    }
}