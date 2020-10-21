using System;

namespace Practica2Ej1
{
    using Draw = System.Drawing;
    using WForms = System.Windows.Forms;

    public class MainWindowView : WForms.Form
    {
        public MainWindowView()
        {
            this.Build();
        }

        void Build()
        {
            var pnlMain = new WForms.TableLayoutPanel {
                Dock = WForms.DockStyle.Fill
            };

            pnlMain.Controls.Add( this.BuildOp1() );
            pnlMain.Controls.Add( this.BuildVar1() );
            pnlMain.Controls.Add( this.BuildVar2() );
            pnlMain.Controls.Add( this.BuildOperacion());
            pnlMain.Controls.Add( this.BuildTelevisor() );
            pnlMain.Controls.Add(this.BuildReproductorDVD());
            pnlMain.Controls.Add( this.BuildRadio() );
            pnlMain.Controls.Add( this.BuildBtOpera() );
            pnlMain.Controls.Add( this.BuildRes() );

            this.Controls.Add( pnlMain );
            this.Text = "Reparaciones";
            this.MinimumSize = new Draw.Size( 1000, 800 );
        }
        
        WForms.Panel BuildOp1()
        {
            var toret = new WForms.Panel {
                Dock = WForms.DockStyle.Fill,
            };
            
            
            this.EdOp1texto = new WForms.Label {
                Dock  = WForms.DockStyle.Left,
                Text = "Tiempo",
                Width = 150,
                Height = 150
                
            } ;
            
            toret.Controls.Add( this.EdOp1texto);
            
            this.EdOp1texto.Font = new Draw.Font(this.EdOp1texto.Font.FontFamily, 20f);
            
            this.EdOp1 = new WForms.TextBox {
                Dock = WForms.DockStyle.Fill,
                Text = "0",
                TextAlign = WForms.HorizontalAlignment.Right
            };
            
            this.EdOp1.Font = new Draw.Font(this.EdOp1.Font.FontFamily, 20f);

            toret.Controls.Add( this.EdOp1 );

            return toret;
        }
        
        WForms.Panel BuildVar1()
        {
            var toret = new WForms.Panel {
                Dock = WForms.DockStyle.Fill,
            };
            
            this.var1Texto = new WForms.Label {
                Dock  = WForms.DockStyle.Left,
                Text = "Numero de serie",
                Width = 300,
                Height = 300
            } ;
            toret.Controls.Add( this.var1Texto);
            
            this.var1Texto.Font = new Draw.Font(this.var1Texto.Font.FontFamily, 20f);
            
            this.var1valTexto = new WForms.TextBox {
                Dock  = WForms.DockStyle.Fill,
                Text = "0",
                TextAlign = WForms.HorizontalAlignment.Right
            };
            this.var1valTexto.Font = new Draw.Font(this.var1valTexto.Font.FontFamily, 20f);

            toret.Controls.Add( this.var1valTexto );

            return toret;
        }
        
        WForms.Panel BuildVar2()
        {
            var toret = new WForms.Panel {
                Dock = WForms.DockStyle.Fill,
            };
            
            this.var2Texto = new WForms.Label {
                Dock  = WForms.DockStyle.Left,
                Text = "Modelo",
                Width = 300,
                Height = 300
            } ;
            toret.Controls.Add( this.var2Texto);
            
            this.var2Texto.Font = new Draw.Font(this.var2Texto.Font.FontFamily, 20f);
            
            this.var2valTexto = new WForms.TextBox {
                Dock  = WForms.DockStyle.Fill,
                TextAlign = WForms.HorizontalAlignment.Right
            };
            this.var2valTexto.Font = new Draw.Font(this.var2valTexto.Font.FontFamily, 20f);

            toret.Controls.Add( this.var2valTexto );

            return toret;
        }

        WForms.Panel BuildTelevisor()
        {
            var toret = new WForms.Panel {
                Dock = WForms.DockStyle.Top
            };
            this.pulgadasLabel = new WForms.Label {
                Dock  = WForms.DockStyle.Left,
                Text = "Pulgadas",
                Width = 300,
                Height = 300
            } ;
            toret.Controls.Add( this.pulgadasLabel);
            
            this.pulgadasLabel.Font = new Draw.Font(this.pulgadasLabel.Font.FontFamily, 20f);
            
            this.pulgadasTexto = new WForms.TextBox {
                Dock  = WForms.DockStyle.Fill,
                TextAlign = WForms.HorizontalAlignment.Right
            };
            this.pulgadasTexto.Font = new Draw.Font(this.pulgadasTexto.Font.FontFamily, 20f);
            toret.Controls.Add( this.pulgadasTexto);

            return toret;
        }
        
        WForms.Panel BuildReproductorDVD()
        {
            var toret = new WForms.Panel {
                Dock = WForms.DockStyle.Top
            };
            
            this.tiempoGrabaLabel = new WForms.Label {
                Dock  = WForms.DockStyle.Left,
                Text = "Tiempo de Grabacion",
                Width = 300,
                Height = 300
            };
            this.tiempoGrabaLabel.Font = new Draw.Font(this.tiempoGrabaLabel.Font.FontFamily, 20f);
            toret.Controls.Add( this.tiempoGrabaLabel);
            
            this.tiempoGrabaTexto = new WForms.TextBox {
                Dock = WForms.DockStyle.Fill,
                Text = "0",
                TextAlign = WForms.HorizontalAlignment.Right,
            };
            this.tiempoGrabaTexto.Font = new Draw.Font(this.tiempoGrabaTexto.Font.FontFamily, 20f);

            toret.Controls.Add( this.tiempoGrabaTexto );

            this.bluerayBox = new WForms.ComboBox {
                Dock = WForms.DockStyle.Left,
                DropDownStyle = WForms.ComboBoxStyle.DropDownList
            };
            
            this.bluerayBox.Items.AddRange( new [] {
                "si", "no"
            } );
            this.bluerayBox.Text = (string) this.bluerayBox.Items[ 0 ];
            this.bluerayBox.Font = new Draw.Font(this.bluerayBox.Font.FontFamily, 20f);
            toret.Controls.Add( this.bluerayBox );
            toret.MaximumSize = new Draw.Size( int.MaxValue, this.bluerayBox.Height );
            
            this.bluerayLabel = new WForms.Label {
                Dock  = WForms.DockStyle.Left,
                Text = "BlueRay",
                Width = 300,
                Height = 300
            };
            this.bluerayLabel.Font = new Draw.Font(this.bluerayLabel.Font.FontFamily, 20f);
            toret.Controls.Add( this.bluerayLabel);
            
            return toret;
        }
        WForms.Panel BuildRadio()
        {
            var toret = new WForms.Panel {
                Dock = WForms.DockStyle.Top
            };

            this.bandas = new WForms.ComboBox {
                Dock = WForms.DockStyle.Left,
                DropDownStyle = WForms.ComboBoxStyle.DropDownList
            };
            
            this.bandas.Items.AddRange( new [] {
                "mf", "sf"
            } );
            this.bandas.Text = (string) this.bandas.Items[ 0 ];
            this.bandas.Font = new Draw.Font(this.bandas.Font.FontFamily, 20f);
            toret.Controls.Add( this.bandas );
            toret.MaximumSize = new Draw.Size( int.MaxValue, this.bandas.Height );
            
            this.bandasLabel = new WForms.Label {
                Dock  = WForms.DockStyle.Left,
                Text = "Bandas",
                Width = 300,
                Height = 300
            };
            this.bandasLabel.Font = new Draw.Font(this.bandasLabel.Font.FontFamily, 20f);
            toret.Controls.Add( this.bandasLabel);
            
            return toret;
        }
        
        WForms.Panel BuildOperacion()
        {
            var toret = new WForms.Panel {
                Dock = WForms.DockStyle.Top
            };

            this.CbOperacion = new WForms.ComboBox {
                Dock = WForms.DockStyle.Fill,
                DropDownStyle = WForms.ComboBoxStyle.DropDownList
            };
            
            this.CbOperacion.Items.AddRange( new [] {
                "Televisor", "ReproductorDVD", "AdaptadorTDT", "Radio"
            } );
            this.CbOperacion.Text = (string) this.CbOperacion.Items[ 0 ];
            this.CbOperacion.Font = new Draw.Font(this.CbOperacion.Font.FontFamily, 20f);
            //Console.Write(this.CbOperacion.Text);
            toret.Controls.Add( this.CbOperacion );
            toret.MaximumSize = new Draw.Size( int.MaxValue, this.CbOperacion.Height );

            return toret;
        }
        
        WForms.Button BuildBtOpera()
        {
            this.BtOpera = new WForms.Button {
                Dock = WForms.DockStyle.Top,
                Text = "Calcular precio"
            };
            this.BtOpera.Height = 50;
            this.BtOpera.Width = 50;
            this.BtOpera.Font = new Draw.Font(this.BtOpera.Font.FontFamily, 20f);

            return this.BtOpera;
        }
        
        WForms.Panel BuildRes()
        {
            var toret = new WForms.Panel {
                Dock = WForms.DockStyle.Top
            };

            EdRestexto = new WForms.Label
            {
                Dock = WForms.DockStyle.Left,
                Text = "Precio"
            };
            this.EdRestexto.Font = new Draw.Font(this.EdRestexto.Font.FontFamily, 20f);
            
            toret.Controls.Add( this.EdRestexto );

            this.EdRes = new WForms.TextBox {
                Dock = WForms.DockStyle.Fill,
                Text = "0",
                TextAlign = WForms.HorizontalAlignment.Right,
                ReadOnly = true
            };
            this.EdRes.Font = new Draw.Font(this.EdRes.Font.FontFamily, 20f);

            toret.Controls.Add( this.EdRes );

            return toret;
        }
        
        public WForms.TextBox EdOp1 {
            get; private set;
        }
        
        public WForms.TextBox var1valTexto {
            get; private set;
        }
        
        public WForms.Label var1Texto {
            get; private set;
        }
        
        public WForms.TextBox var2valTexto {
            get; private set;
        }
        public WForms.Label pulgadasLabel {
            get; private set;
        }
        
        public WForms.TextBox pulgadasTexto {
            get; private set;
        }

        
        public WForms.Label var2Texto {
            get; private set;
        }
        
        public WForms.Label EdOp1texto {
            get; private set;
        }
        
        public WForms.ComboBox CbOperacion {
            get; private set;
        }
        
        public WForms.Label bluerayLabel {
            get; private set;
        }
        
        public WForms.ComboBox bandas {
            get; private set;
        }
        
        public WForms.Label bandasLabel {
            get; private set;
        }
        
        public WForms.ComboBox bluerayBox {
            get; private set;
        }
        
        public WForms.Button BtOpera {
            get; private set;
        }
        
        public WForms.TextBox EdRes {
            get; private set;
        }
        
        public WForms.Label EdRestexto {
            get; private set;
        }
        
        public WForms.TextBox tiempoGrabaTexto {
            get; private set;
        }
        
        public WForms.Label tiempoGrabaLabel {
            get; private set;
        }
    }
}