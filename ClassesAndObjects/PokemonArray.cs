
namespace ClassesAndObjects
{
    public class PokemonArray
    {
        Pokemon[] array;
        static Random random = new Random();
        static int counter;
        public int Length
        {
            get => array.Length;
        }
        public static int Counter
        {
            get => counter;
            set => counter = value;
        }

        public Pokemon this[int index]
        {
            get
            {
                if (index >= 0 && index <= array.Length)
                    return array[index];
                else
                    throw new Exception("Индекс выходит за пределы коллекции");
            }
            set
            {
                if (index >= 0 && index <= array.Length)
                    array[index] = value;
            }
        }

        public PokemonArray()
        {
            Counter++;
            array = new Pokemon[3] 
            {
                new Pokemon(),
                new Pokemon(),
                new Pokemon(),
            };
        }

        public PokemonArray(int amount, bool p) 
        {
            Counter++;
            array = new Pokemon[amount];
            if (p)
            {
                for (int i = 0; i < amount; i++)
                {
                    short atk = (short)random.Next(17, 415);
                    short def = (short)random.Next(32, 397);
                    short stm = (short)random.Next(1, 497);
                    array[i] = new Pokemon(atk, def, stm);
                }
            }
            else
            {
                for (int i = 0; i < amount; i++)
                {
                    Console.WriteLine("Введите атаку от 17 до 414");
                    short atk = LabLibrary.LabLib.ExtensionDoWhile<short>();
                    Console.WriteLine("Введите защиту от 32 до 396");
                    short def = LabLibrary.LabLib.ExtensionDoWhile<short>();
                    Console.WriteLine("Введите атаку от 1 до 496");
                    short stm = LabLibrary.LabLib.ExtensionDoWhile<short>();
                    array[i] = new Pokemon(atk, def, stm);
                }
            }
            
        }

        public PokemonArray(PokemonArray p)
        {
            Counter++;
            array = new Pokemon[p.Length];
            for (int i = 0; i < p.Length; i++)
                array[i] = new Pokemon(p.array[i]);
        }

        public string ShowPokemons()
        {
            string printPoks = "";
            for(int i = 0; i < array.Length;i++)
            {
                printPoks += array[i];
            }
            return printPoks;
        }
    }
}
