
namespace ClassesAndObjects
{
    public class PokemonArray
    {
        Pokemon[] array;
        static Random random = new Random();
        public static int count = 0;
        public int Length{
            get => array.Length;
        }

        public Pokemon this[int index]
        {
            get
            {
                    if (index >= 0 && index < array.Length)
                        return array[index];
                    else
                        throw new Exception("Индекс выходит за пределы коллекции");

            }
            set
            {
                if (index >= 0 && index < array.Length)
                    array[index] = value;
                else
                    throw new Exception("Индекс выходит за пределы коллекции");
            }
        }

        public PokemonArray()
        {
            count++;
            array = new Pokemon[3] 
            {
                new Pokemon(),
                new Pokemon(),
                new Pokemon(),
            };
        }

        public PokemonArray(int count, bool p) 
        {
            count++;
            array = new Pokemon[count];
            if (p)
            {
                for (int i = 0; i < count; i++)
                {
                    short atk = (short)random.Next(17, 415);
                    short def = (short)random.Next(32, 397);
                    short stm = (short)random.Next(1, 497);
                    array[i] = new Pokemon(atk, def, stm);
                }
            }
            else
            {
                for (int i = 0; i < count; i++)
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
            count++;
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
    }
}
