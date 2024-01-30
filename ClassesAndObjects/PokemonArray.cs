
namespace ClassesAndObjects
{
    internal class PokemonArray
    {
        Pokemon[] array;
        static Random random = new Random();
        public int Length{
            get => array.Length;
        }
        public PokemonArray() 
        {
            array = new Pokemon[3] 
            {
                new Pokemon(),
                new Pokemon(),
                new Pokemon(),
            };
        }

        public PokemonArray(int count) 
        {
            array = new Pokemon[count];
            for (int i = 0; i < count; i++)
            {
                short atk = (short)random.Next(17, 414);
                short def = (short)random.Next(32, 396);
                short stm = (short)random.Next(1, 496);
                array[i] = new Pokemon(atk, def, stm);
            }
        }

        public PokemonArray(PokemonArray p)
        {
            array = new Pokemon[p.Length];
            for (int i = 0; i < p.Length; i++)
                array[i] = new Pokemon(p.array[i]);
        }

        public void ShowPokemons()
        {
            for(int i = 0; i < array.Length;i++)
            {
                array[i].Show();
            }
        }
        public int ModePokemons()
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
