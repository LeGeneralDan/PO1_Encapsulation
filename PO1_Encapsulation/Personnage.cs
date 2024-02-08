using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
        private string nom;
        private int pointsDeVie;
        private int pointsDePuissance;

        public string Nom { get => nom; set => nom = value; }
        public int PointsDeVie
        {
            get => pointsDeVie;
            set
            {

                if (value > 0)
                {
                    pointsDeVie = value;
                }
                else 
                { 
                    pointsDeVie = 0;
                }
            }
        }
        public int PointsDePuissance { get => pointsDePuissance; set => pointsDePuissance = value; }

        public bool EstEnVie
        {
            get
            {
                if(pointsDeVie > 0)
                {
                    return true;
                }
                return false;
            }
        }
    }
}
