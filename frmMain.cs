namespace prySignorileBautista_Juego
{
    public partial class frmMain : Form
    {
        //Zona declaracion variables globales

        claseNave objNaveJugador;
        claseNave objNaveEnemigo;
        claseNave objLaser;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e) 
        {
            objNaveJugador = new claseNave();

            objNaveJugador.crearJugador();

            objNaveJugador.imgNave.Location = new Point(320, 600);
            Controls.Add(objNaveJugador.imgNave);


            //MessageBox.Show(objNaveJugador.nombre);
            objNaveEnemigo = new claseNave();
            int X = 23;
            for (int i = 0; i < 7; i++)
            {
                objNaveEnemigo.crearEnemigos();

                objNaveEnemigo.imgNaveEnemigo.Location = new Point(X, 50);
                Controls.Add(objNaveEnemigo.imgNaveEnemigo);
                X += objNaveEnemigo.imgNaveEnemigo.Size.Width * 2;

            }

            int x = 23;
            objLaser = new claseNave();
            for (int i = 0; i < 7; i++)
            {
                objLaser.crearLaserEnemigo();

                objLaser.imgBala.Location = new Point(x, 70);
                Controls.Add(objLaser.imgBala);
                x += objLaser.imgBala.Size.Width * 2;

            }



        }
        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X + 5, objNaveJugador.imgNave.Location.Y);
            }
            if (e.KeyCode == Keys.Left)
            {
                objNaveJugador.imgNave.Location = new Point(objNaveJugador.imgNave.Location.X - 5, objNaveJugador.imgNave.Location.Y);
            }
        }
    }
}
