using System;
using Pokemons;

namespace Pokemons
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // J'initialise mon jeu, je laisse le choix a l'utilisateur de son Pokemon//
            Console.WriteLine("Veuillez Choisir un Pokémon parmi les 3 suivants : 1 = Salameche - 2 = Carapuce - 3 = Bulbizarre");
            string ChoixPokemon = Console.ReadLine();
            int ChoixPokemons = int.Parse(ChoixPokemon);

            if (ChoixPokemons == 1)
            {
                Console.WriteLine("Très bien vous avez choisi Salameche");
            }

            if (ChoixPokemons == 2)
            {
                Console.WriteLine("Très bien vous avez choisi Carapuce");
            }

            if (ChoixPokemons == 3)
            {
                Console.WriteLine("Très bien vous avez choisi Bulbizarre");
            }

            Console.WriteLine("---------------------------------");
            bool game = true; // j'initialise le jeu 
            Pokemon pokemon = new Pokemon(); // je déclare la nouvelle variable Pokemon
            PokemonSauvage pokemonSauvage = new PokemonSauvage(); // je déclare la nouvelle variable Pokemon Sauvage

            // Je commence le combat en demandant à l'utilisateur ce qu'il souhaote faire//

            while (game && pokemon.Vivant)
            {
                if (pokemonSauvage.PointsDeVie <= 0)
                {
                    pokemonSauvage = new PokemonSauvage();
                    Pokemon.NombreCombats++;
                }

                Console.WriteLine("---------------------------------");

                // Début du combat, l'utilisateur a 3 choix possible
                Console.WriteLine("Votre Pokemon a une vitesse de " + pokemon.Vitesse);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Le Pokemon Sauvage a une vitesse de " + pokemonSauvage.VitessePokemon);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Choisissez une action : \n1 - Attaquer \n2 - Vous soigner  \n3 - Se protéger  \n4 - Voir stat");
                


                switch (Console.ReadLine())
                {
                    case "1":
                        pokemonSauvage.Attaquer(pokemon.Degats);
                        Console.WriteLine("---------------------------------");
                        break;
                    case "2":
                        pokemon.SeSoigner();
                        Console.WriteLine("-------------------------------");
                        break;
                    case "3":
                        pokemon.SeProteger(pokemon.Degats);
                        Console.WriteLine("-------------------------------");
                        break;
                    case "4":
                        Console.WriteLine("Votre Pokemon a une attaque de " + " " + pokemon.Degats + " degats" + " " +  ",une defense de " + "" + pokemon.Defense + " " + "et est équipé de" + " " + pokemon.Potion + " " +"potions");
                        Console.WriteLine("-------------------------------");
                        break;
                    


                }

                // si le pokemon sauavge n'a plus de vie alors le combat est fini, sinon il prend des dégats
                if (pokemonSauvage.PointsDeVie <= 0)
                {
                    Console.WriteLine("Félicitations, vous avez vaincu le " + pokemonSauvage.Nom + " !");
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Voulez-vous continuer à jouer ? (oui/non)");
                    if (Console.ReadLine() != "oui")
                    {
                        game = !game;
                    }
                }
                else
                {
                    pokemon.Attaquer(pokemonSauvage.Degats);

                }

                
            }

        }
    }
}