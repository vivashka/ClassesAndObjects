namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pokemon pikachu = new Pokemon();
            pikachu.Show();
            pikachu.LevelUp(10).Show();

            Pokemon raichu = new Pokemon(10);
            raichu.Show();

            raichu = new Pokemon(45, 67, 10);
            raichu.Show();
            Pokemon.SLevelUp(raichu, 4, 5, -10).Show();

            Pokemon megaRaichu = new Pokemon(raichu);
            megaRaichu.Show();
            Pokemon.SLevelUp(megaRaichu, 40, 50, 10).Show();

            float cp = ~megaRaichu;
            Console.WriteLine(cp);

            Pokemon megaRaichu2 = --megaRaichu;
            Console.WriteLine(megaRaichu.Stamina) ;
            Console.WriteLine(megaRaichu2.Stamina);
            megaRaichu2 = megaRaichu--;
            Console.WriteLine(megaRaichu.Stamina);
            Console.WriteLine(megaRaichu2.Stamina);

            Console.WriteLine("");
            PokemonArray poks = new PokemonArray(3);
            Console.WriteLine(poks.ModePokemons());
            poks.ShowPokemons();
        }
    }
}