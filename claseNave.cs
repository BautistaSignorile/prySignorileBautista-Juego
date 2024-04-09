using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prySignorileBautista_Juego
{
    internal class claseNave
    {
        //Caracteristicas

        public  int vida;
        public  string nombre;
        public int puntoDaño;
        public PictureBox imgNave;

        public void crearJugador() 
        {
            vida = 100;
            nombre = "Jugador1";
            puntoDaño = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://banner2.cleanpng.com/20180326/ble/kisspng-sprite-space-shuttle-story-spacecraft-2d-computer-space-craft-5ab949f72ef7e7.7634883715220925351924.jpg";
        }

        public void crearEnemigos()
        {
            vida = 25;
            nombre = "Jugador2";
            puntoDaño = 2;
        }
    }
}
