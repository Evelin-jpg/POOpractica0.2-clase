using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOpractica0._2_clase_
{
    class Computadora : ConsolaDeVideojuego
    {

        //Variable
        protected string hardware; 
        
         
        //Propiedad
        public string Hardware
        {
            get
            { 

                return hardware; 
            
            }

            set
            {

                hardware = value;
            
            }
        }

        //Constructor
        public Computadora() : base()
        {

            hardware = "";

        }
        public Computadora(string Tarjeta_de_memoria, string software, string Modelo,string hardware) : base(Tarjeta_de_memoria,software,Modelo)
        {

            this.hardware = hardware;

        }

        //Metodo
        public void MensajeDeRegresoPorChat()
        {
            System.Windows.Forms.MessageBox.Show("He derrotado al enemigo, pasemos a la siguiente mision! ");
        }

        public void RegresarMensaje()
        {

        }





    }
}
