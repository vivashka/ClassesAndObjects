namespace ClassesAndObjects
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Использование конструкторов---------------"); 
            Pokemon pikachu = new Pokemon();
            pikachu.Show();

            Pokemon raichu = new Pokemon(17, 32, 3);
            raichu.Show();

            Pokemon megaRaichu = new Pokemon(raichu);
            megaRaichu.Show();

            Console.WriteLine("Повышение уровня-------------");
            pikachu.LevelUp(10).Show();
            Pokemon.SLevelUp(raichu, 4, 5, -10).Show();

            Console.WriteLine("Унарные операции-------------");
            Console.WriteLine("Сила мегарайчу - " + ~megaRaichu);
            Console.WriteLine(Pokemon.count);

            Pokemon megaRaichu2 = --megaRaichu;
            Console.WriteLine("Выносливость мегарайчу уменьшилась - " + megaRaichu.Stamina);
            Console.WriteLine("Выносливость мегарайчу уменьшилась - " + megaRaichu2.Stamina);
            megaRaichu2 = megaRaichu--;
            Console.WriteLine("Выносливость мегарайчу уменьшилась - " + megaRaichu.Stamina);
            Console.WriteLine("Выносливость мегарайчу НЕ уменьшилась - " + megaRaichu2.Stamina);
            Console.WriteLine("Проверка работы Equals - " + raichu.Equals(megaRaichu));
            
            Console.WriteLine("Количество созданных покемонов " + Pokemon.count);

            Console.WriteLine("Работа с массивом---------------------------");
            PokemonArray poks = new PokemonArray(10, true);
            
            poks[0] = new(1, 1, 1);
            poks[9] = raichu;
            poks.ShowPokemons();
            //Показать для вывода ошибки!!!!
            //poks[-1] = new(48, 56, 12);
            //poks[12] = raichu;
            //poks.ShowPokemons();

            int modepoks = ModePokemons(poks);
            Console.WriteLine($"Мода выносливости = {modepoks}");

            Console.WriteLine("Количество созданных коллекций покемонов " + PokemonArray.counter);
            Console.WriteLine("Количество созданных покемонов " + Pokemon.count);
            

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