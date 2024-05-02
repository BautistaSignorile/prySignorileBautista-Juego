namespace prySignorileBautista_Juego
{
    public partial class frmMain : Form
    {
        //Zona declaracion variables globales

        claseNave objNaveJugador;
        claseNave objNaveEnemigo;
        claseNave objLaser;
        claseNave objLaserP;
        public int Score = 0;

        List<claseNave> objList = new List<claseNave>();
        List<claseNave> objEnemigo = new List<claseNave>();
        public frmMain()
        {
            InitializeComponent();
        } 
        private void frmMain_Load_2(object sender, EventArgs e)
        {
            objNaveJugador = new claseNave();

            objNaveJugador.crearJugador();

            objNaveJugador.imgNave.Location = new Point(152, 380);

            Controls.Add(objNaveJugador.imgNave);

            objNaveEnemigo = new claseNave();

            int X = 17;
            for (int i = 0; i < 7; i++)
            {
                objNaveEnemigo = new claseNave();
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

            }
            if (e.KeyCode == Keys.Left)
            {
                objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X - 5, objNaveJugador.imgNave.Location.Y);

            }

            if (e.KeyCode == Keys.Space)
            {
                objLaserP = new claseNave();
                objLaserP.crearLaserPlayer();

                objLaserP.imgBalas.Location = new Point(objNaveJugador.imgNave.Location.X + 15, objNaveJugador.imgNave.Location.Y - objNaveJugador.imgNave.Size.Height);
                Controls.Add(objLaserP.imgBalas);

                objList.Add(objLaserP);

            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            foreach (claseNave bala in objList)
            {
                bala.imgBalas.Location = new Point(bala.imgBalas.Location.X,
                    bala.imgBalas.Location.Y - 10);
                foreach (claseNave Enemigo in objEnemigo)
                {
                    if (bala.imgBalas.Bounds.IntersectsWith(Enemigo.imgNaveEnemigo.Bounds))
                    {
                        Enemigo.imgNaveEnemigo.Dispose();
                        bala.imgBalas.Dispose();
                    }
                }
            }
            
        }
    }
}
