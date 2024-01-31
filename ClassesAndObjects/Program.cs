namespace ClassesAndObjects
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Pokemon pikachu = new Pokemon();
            //pikachu.Show();
            //pikachu.LevelUp(10).Show();

            Pokemon raichu = new Pokemon(20);
            //raichu.Show();

            //raichu = new Pokemon(45, 67, 10);
            //raichu.Show();
            //Pokemon.SLevelUp(raichu, 4, 5, -10).Show();

            //Pokemon megaRaichu = new Pokemon(raichu);
            //megaRaichu.Show();
            //Pokemon.SLevelUp(megaRaichu, 40, 50, 10).Show();

            //Console.WriteLine(~megaRaichu);
            //Console.WriteLine(Pokemon.count);

            //Pokemon megaRaichu2 = --megaRaichu;
            //Console.WriteLine(megaRaichu.Stamina) ;
            //Console.WriteLine(megaRaichu2.Stamina);
            //megaRaichu2 = megaRaichu--;
            //Console.WriteLine(megaRaichu.Stamina);
            //Console.WriteLine(megaRaichu2.Stamina);



            Console.WriteLine("--------------");
            PokemonArray poks = new PokemonArray(10, true);
            int modepoks = ModePokemons(poks);
            Console.WriteLine($"Мода выносливости = {modepoks}");
            poks[0] = new(48, 56, 12);
            poks[10] = raichu;
            poks.ShowPokemons();
            poks[-1] = new(48, 56, 12);
            poks[12] = raichu;
            poks.ShowPokemons();
            Console.WriteLine(PokemonArray.count);

        }
        public static int ModePokemons(PokemonArray array)
        {
            short[] staminaArray = new short[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                staminaArray[i] = array[i].Stamina;
            }
            Array.Sort(staminaArray);
            int count = 1;
            int maxcount = 0;
            short mode = 0;
            for (int i = 0; i < staminaArray.Length - 1; i++)
            {
                if (staminaArray[i] == staminaArray[i + 1])
                {
                    count++;
                    if (count > maxcount)
                    {
                        maxcount = count;
                        mode = staminaArray[i];
                    }
                }
                else
                {
                    count = 1;
                }
            }

            //for (int i = 0; i < staminaArray.Length; i++)
            //{
            //    if (array[i].Stamina == mode)
            //    {
            //        Console.Write($"{i} - ");
            //        array[i].Show();
            //    }
            //}
            return mode;
        }
    }
}