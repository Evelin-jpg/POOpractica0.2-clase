using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POOpractica0._2_clase_
{
    public partial class Form1 : Form
    {
        ConsolaDeVideojuego Xbox = new ConsolaDeVideojuego(); //Se crea el objeto


        public Form1()
        {
            InitializeComponent();
        }

        //Evento y Metodo
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_MensajePorChat_Click(object sender, EventArgs e)
        {
            Xbox.MensajePorChat();
        }

        //Evento y Metodo
        Computadora hp = new Computadora(); //Se crea el objeto
        private void btn_MensajeDeRegresoPorChat_Click(object sender, EventArgs e)
        {
            hp.MensajeDeRegresoPorChat();
        }
    }
}
