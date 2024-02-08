namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new Personnage();
        Personnage dragon = new();
        public Form1()
        {
            InitializeComponent();
            joueur.PointsDeVie = 10;
            dragon.PointsDeVie = joueur.PointsDeVie * 3;
            joueur.PointsDePuissance = 1;
            dragon.PointsDePuissance = joueur.PointsDePuissance * 3;
            
            //MessageBox.Show(joueur.PointsDeVie.ToString());//
        }

        private void ActualiserLabel()
        {
            lbl_pointsVieJoueur.Text = " Point de vie :" +
                joueur.PointsDeVie.ToString();

            lbl_pointsVieDragon.Text = " Point de vie :" + 
                dragon.PointsDeVie.ToString();

            lbl_puissanceAttaqueJoueur.Text = " Puissance d'attaque :" +
                joueur.PointsDePuissance.ToString();

            lbl_puissanceAttaqueDragon.Text = " Puissance d'attaque :" +
                dragon.PointsDePuissance.ToString();
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            dragon.PointsDeVie -= joueur.PointsDePuissance;
            TourDragon();
            ActualiserLabel();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            joueur.PointsDeVie += 5;
            TourDragon();
            ActualiserLabel();
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            joueur.PointsDePuissance += 1;
            TourDragon();
            ActualiserLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualiserLabel();
        }

        private void TourDragon()
        {
            joueur.PointsDeVie -= dragon.PointsDePuissance;
        }
    }
}