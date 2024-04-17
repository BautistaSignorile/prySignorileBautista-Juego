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
            



        }

        private void frmMain_Load_1(object sender, EventArgs e)
        {
            objNaveJugador = new claseNave();

            objNaveJugador.crearJugador();

            objNaveJugador.imgNave.Location = new Point(152, 380);
            Controls.Add(objNaveJugador.imgNave);


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

                objLaser.imgBala.Location = new Point(objNaveEnemigo.imgNaveEnemigo.Location.X + 12 , 20);
                Controls.Add(objLaser.imgBala);
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
