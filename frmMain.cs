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
        public int muertes = 0;
        int X = 17;

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

            timer1.Start();
            timer1.Enabled = true;
            timer2.Start();
            timer2.Enabled = true;
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
                    bala.imgBalas.Location.Y - 35);
                foreach (claseNave Enemigo in objEnemigo)
                {
                    if (bala.imgBalas.Bounds.IntersectsWith(Enemigo.imgNaveEnemigo.Bounds))
                    {
                        Enemigo.imgNaveEnemigo.Dispose();
                        bala.imgBalas.Dispose();
                        objEnemigo.Remove(Enemigo);

                        Score = Score + 5;
                        lblPuntos.Text = Score.ToString();
                        muertes = muertes + 1;
                        if (muertes == 5)
                        {
                            contador = 0;
                            muertes = 0;
                        }
                        break;
                    }
                }
            }
        }

        int contador, PosX, PosY;
        Random randomX = new Random();
        Random randomY = new Random();

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (contador < 1)
            {
                int x = 23;
                for (int i = 0; i < 5; i++)
                {
                    PosX = randomX.Next(0, 10);
                    PosY = randomY.Next(30, 40);
                    objNaveEnemigo = new claseNave();
                    objNaveEnemigo.crearEnemigos();
                    objEnemigo.Add(objNaveEnemigo);
                    objNaveEnemigo.imgNaveEnemigo.Location = new Point(x, PosY);
                    Controls.Add(objNaveEnemigo.imgNaveEnemigo);
                    x += objNaveEnemigo.imgNaveEnemigo.Size.Width * 2;
                }
                contador++;
            }
        }
    }
}
