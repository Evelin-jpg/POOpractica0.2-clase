using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOpractica0._2_clase_
{
    class ConsolaDeVideojuego
    {
        //Variables

       public string Tarjeta_de_memoria;
       public string Software;
       public string Modelo;
        private int myVar;

        //Propiedades
        public string Tarjeta_De_Memoria
        {
            get
            {
                return Tarjeta_de_memoria;

            }
            set
            {
                Tarjeta_de_memoria = value;

            }
        }
        public string SOFTWARE
        {
            get
            {
                return Software;

            }
            set
            {
                Software = value;

            }
        }
        public string MODELO
        {
            get
            {
                return Modelo;

            }
            set
            {
                Modelo = value;

            }
        }
        //Constructores
        public ConsolaDeVideojuego()
        {
            Tarjeta_De_Memoria = "";
            Software = "";
            Modelo = "";
        }
        public ConsolaDeVideojuego(string Tarjeta_De_Memoria, string software, string modelo)
        {
            this.Tarjeta_De_Memoria = Tarjeta_De_Memoria;
            this.Software = software;
            this.Modelo = modelo;
        }

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value;}
        }

        //Metodo
        public void MensajePorChat()
        {
            System.Windows.Forms.MessageBox.Show("Vence al enemigo para ganar el nivel xd");
        }

        public void EnviarMensaje ()
        {

        }


    }
}
