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
        public PictureBox imgBala;
        public PictureBox imgBalas;
        public string direccion = "Right";
        public int numVecesCambiadoDireccion = 0;



        public void crearJugador() 
        {
            vida = 100;
            nombre = "Jugador1";
            puntoDaño = 1;
            imgNave = new PictureBox();
            imgNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNave.ImageLocation = "https://64.media.tumblr.com/f0f05efc7077d56d7f2b7cd08740fbf0/e2c00fe2299666b8-d6/s1280x1920/11cf7d2006086ece3a7e47b4fe4ac96710265eb8.gif";
            imgNave.BackColor = Color.Transparent;
            imgNave.Size = new Size(35,35);
        }

        public void crearEnemigos()
        {
            vida = 25;
            nombre = "Jugador2";
            puntoDaño = 2;
            imgNaveEnemigo = new PictureBox();
            imgNaveEnemigo.SizeMode = PictureBoxSizeMode.StretchImage;
            imgNaveEnemigo.ImageLocation = "https://66.media.tumblr.com/5c56bf25fafc43d473d73cb4da4a35fe/tumblr_mfi0zq4lkO1rfjowdo1_500.gif";
            imgNaveEnemigo.BackColor = Color.Transparent;
            imgNaveEnemigo.Size = new Size(30, 30);
        }
        public void crearLaserEnemigo()
        {
            imgBala = new PictureBox();
            imgBala.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBala.ImageLocation = "https://i0.wp.com/donaldcarling.wordpress.com/wp-content/uploads/2016/03/blast-harrier-laser-1.png?w=502&h=893&ssl=1";
            imgBala.BackColor = Color.Transparent;
            imgBala.Size = new Size(7, 20);
        }
        public void crearLaserPlayer()
        {
            imgBalas = new PictureBox();
            imgBalas.SizeMode = PictureBoxSizeMode.StretchImage;
            imgBalas.ImageLocation = "https://donaldcarling.wordpress.com/wp-content/uploads/2016/03/mega-laser-1.png";
            imgBalas.BackColor = Color.Transparent;
            imgBalas.Size = new Size(7, 20);
        }
    }
}
