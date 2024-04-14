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
        public PictureBox imgNaveEnemigo;


        public void crearJugador() 
        {
            vida = 100;
            nombre = "Jugador1";
            puntoDaño = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "enemy2.png";
            imgNave.BackColor = Color.Transparent;
            imgNave.Size = new Size(40,40);
        }

        public void crearEnemigos()
        {
            vida = 25;
            nombre = "Jugador2";
            puntoDaño = 2;
            imgNaveEnemigo = new PictureBox();
            imgNaveEnemigo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemigo.ImageLocation = "enemy1.png";
            imgNaveEnemigo.BackColor = Color.Transparent;
            imgNaveEnemigo.Size = new Size(45, 45);
        }
    }
}
