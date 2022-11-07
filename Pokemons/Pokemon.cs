using System;
namespace Pokemons
{
    public class Pokemon
    {
        public string Nom { get; set; }
        public int PointsDeVie { get; set; }
        public int Degats { get; set; }
        public int Defense { get; set; }
        public int Potion { get; set; }
        public int Vitesse { get; set; }
        public bool Vivant { get; set; } = true;
        public static int NombreCombats = 0;

        int[] DegatsRandoms = { 2, 5, 7 };
        int[] VitesseRandom = { 10, 15, 50 };

        public Pokemon()
        {
            Random random = new Random();
            PointsDeVie = 50;
            Defense = 1;
            Degats = DegatsRandoms[random.Next(0, 3)];
            Potion = 3;
            Vitesse = VitesseRandom[random.Next(0, 3)];

        }


        public Pokemon(string nom, int pointsDeVie, int degats, int vitesse, int defense, int potion)
        {
            Nom = nom;
            PointsDeVie = pointsDeVie;
            Degats = degats;
            Vitesse = vitesse;
            Defense = defense;
            Potion = potion;

        }

        

        public void Attaquer(int degats)
        {
            PointsDeVie -= degats;
            Console.WriteLine("Votre Pokemon " + Nom + " " + "a subi" + " " + degats + " " + "degats, il possède maintenant" + " " + PointsDeVie + "PV");
            
        }

        public void SeProteger(int degats)
        {
            PointsDeVie -= degats;
            PointsDeVie += Defense;
            Console.WriteLine("Votre Pokemon" + Nom + " " + "a subi" + " " + degats + "degats" + " " + "grâce à sa protection");
            
        }

        public void SeSoigner()
        {
            PointsDeVie += Potion;
            Console.WriteLine("Votre Pokemon" + Nom + "s'est soigné" + "il possède desormais : " + PointsDeVie + "PV");
            
        }

        public void GameOver()
        {
            Console.WriteLine("Votre Pokemon a été mis KO");
            Vivant = false;
        }

        public static string AfficherNombreCombats()
        {
            return "Vous avez effectué " + NombreCombats + " combats.";
        }
    }
}
