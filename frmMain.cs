namespace prySignorileBautista_Juego
{
    public partial class frmMain : Form
    {
        //Zona declaracion variables globales

        claseNave objNaveJugador;
        claseNave objNaveEnemigo;
        claseNave objLaser;
        claseNave objLaserP;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {




        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            objNaveJugador = new claseNave();

            objNaveJugador.crearJugador();

            objNaveJugador.imgNave.Location = new Point(152, 380);
            Controls.Add(objNaveJugador.imgNave);

            objLaserP = new claseNave();
            objLaserP.crearLaserPlayer();

            objLaserP.imgBalas.Location = new Point(objNaveJugador.imgNave.Location.X + 14, objNaveJugador.imgNave.Location.Y - objNaveJugador.imgNave.Size.Height);
            Controls.Add(objLaserP.imgBalas);


            //MessageBox.Show(objNaveJugador.nombre);
            objNaveEnemigo = new claseNave();
            int X = 17;
            for (int i = 0; i < 7; i++)
            {
                objNaveEnemigo.crearEnemigos();

                objNaveEnemigo.imgNaveEnemigo.Location = new Point(X, 20);
                Controls.Add(objNaveEnemigo.imgNaveEnemigo);
                X += objNaveEnemigo.imgNaveEnemigo.Size.Width + 17;

                objLaser = new claseNave();
                objLaser.crearLaserEnemigo();

                objLaser.imgBala.Location = new Point(objNaveEnemigo.imgNaveEnemigo.Location.X + 12, objNaveEnemigo.imgNaveEnemigo.Location.Y + 20);
                Controls.Add(objLaser.imgBala);
            }
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X + 5, objNaveJugador.imgNave.Location.Y);
                objLaserP.imgBalas.Location = new Point(objLaserP.imgBalas.Location.X + 5, objLaserP.imgBalas.Location.Y);
            }
            if (e.KeyCode == Keys.Left)
            {
                objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X - 5, objNaveJugador.imgNave.Location.Y);
                objLaserP.imgBalas.Location = new Point(objLaserP.imgBalas.Location.X - 5, objLaserP.imgBalas.Location.Y);
            }

            if (e.KeyCode == Keys.Space)
            {
                objLaserP.imgBalas.Location = new Point(objLaserP.imgBalas.Location.X, objLaserP.imgBalas.Location.Y - 50);
            }

            timer1.Enabled = true;

            //if (e.KeyCode == Keys.Up)
            //{
            //    objLaserP.imgBalas.Location = new Point(objLaserP.imgBalas.Location.X, objLaserP.imgBalas.Location.Y + 50);
            //}
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            objLaserP.imgBalas.Location = new Point(objLaserP.imgBalas.Location.X, objLaserP.imgBalas.Location.Y - 50);
        }

        private void frmMain_Load_2(object sender, EventArgs e)
        {
            objNaveJugador = new claseNave();

            objNaveJugador.crearJugador();

            objNaveJugador.imgNave.Location = new Point(152, 380);
            Controls.Add(objNaveJugador.imgNave);

            objLaserP = new claseNave();
            objLaserP.crearLaserPlayer();

            objLaserP.imgBalas.Location = new Point(objNaveJugador.imgNave.Location.X + 14, objNaveJugador.imgNave.Location.Y - objNaveJugador.imgNave.Size.Height);
            Controls.Add(objLaserP.imgBalas);


            //MessageBox.Show(objNaveJugador.nombre);
            objNaveEnemigo = new claseNave();
            int X = 17;
            for (int i = 0; i < 7; i++)
            {
                objNaveEnemigo.crearEnemigos();

                objNaveEnemigo.imgNaveEnemigo.Location = new Point(X, 20);
                Controls.Add(objNaveEnemigo.imgNaveEnemigo);
                X += objNaveEnemigo.imgNaveEnemigo.Size.Width + 17;

                objLaser = new claseNave();
                objLaser.crearLaserEnemigo();

                objLaser.imgBala.Location = new Point(objNaveEnemigo.imgNaveEnemigo.Location.X + 12, objNaveEnemigo.imgNaveEnemigo.Location.Y + 20);
                Controls.Add(objLaser.imgBala);
            }
        }

        private void frmMain_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X + 5, objNaveJugador.imgNave.Location.Y);
                objLaserP.imgBalas.Location = new Point(objLaserP.imgBalas.Location.X + 5, objLaserP.imgBalas.Location.Y);
            }
            if (e.KeyCode == Keys.Left)
            {
                objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X - 5, objNaveJugador.imgNave.Location.Y);
                objLaserP.imgBalas.Location = new Point(objLaserP.imgBalas.Location.X - 5, objLaserP.imgBalas.Location.Y);
            }

            if (e.KeyCode == Keys.Space)
            {
                objLaserP.imgBalas.Location = new Point(objLaserP.imgBalas.Location.X, objLaserP.imgBalas.Location.Y);
            }

            timer1.Enabled = true;
        }
    }
}
