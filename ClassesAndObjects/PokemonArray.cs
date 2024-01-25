
namespace ClassesAndObjects
{
    internal class PokemonArray
    {
        Pokemon[] array = new Pokemon[0];
        static Random random = new Random();
        public Pokemon[] Arr{
            get => array;
            set
            {
                if (value == null || value.Length <= 0)
                {
                    Console.WriteLine("Количестов покемонов должно быть больше 0");
                }
                else
                {
                    array = value;
                }
            }
        }
        public PokemonArray() 
        {
            Arr = new Pokemon[3] 
            {
                new Pokemon(),
                new Pokemon(),
                new Pokemon(),
            };
        }

        public PokemonArray(int count) 
        {
            Arr = new Pokemon[count];
            for (int i = 0; i < count; i++)
            {
                short atk = (short)random.Next(17, 414);
                short def = (short)random.Next(32, 396);
                short stm = (short)random.Next(1, 496);
                Arr[i] = new Pokemon(atk, def, stm);
            }
        }

        public void ShowPokemons()
        {
            for(int i = 0; i < Arr.Length;i++)
            {
                Console.WriteLine(Arr[i]);
            }
        }
        public int ModePokemons()
        {
            int mode = 0;
            for (int i = 0; i < Arr.Length; i++)
            {
                mode += Arr[i].Stamina;
            }
            return mode;
        }
    }
}
