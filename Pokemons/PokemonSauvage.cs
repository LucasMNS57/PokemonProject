using System;
namespace Pokemons
{
    public class PokemonSauvage
    {
        public string Nom { get; set; }
        public int PointsDeVie { get; set; }
        public int Degats { get; set; }
        public int VitessePokemon { get; set; }

        int[] Vitesse = { 5, 20, 25 };
        string[] NomsRandoms = { "Bulbizarre", "Salamèche", "Carapuce" };
        int[] DegatsRandoms = { 1, 3, 10, };

        public PokemonSauvage()
        {
            Random random = new Random();
            Nom = NomsRandoms[random.Next(0, 3)];
            VitessePokemon = Vitesse[random.Next(0, 3)];
            Degats = DegatsRandoms[random.Next(0, 3)];
            PointsDeVie = 30;
            Degats = 3;

            Console.WriteLine("Attention, un " + Nom + " fonce sur toi !");
            

        }


        public PokemonSauvage(string nom, int pointsDeVie, int degats)
        {

            Nom = nom;
            PointsDeVie = pointsDeVie;
            Degats = degats;

        }

        public void Attaquer(int Degats)
        {
            PointsDeVie -= Degats;
            Console.WriteLine("Le " + Nom + " " + " reçoit " + " " + Degats + " points de dégâts," + "il a désormait" + " " + PointsDeVie + "PV");
        }

    }
}

