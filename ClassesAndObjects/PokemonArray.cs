
namespace ClassesAndObjects
{
    internal class PokemonArray
    {
        Pokemon[] array;
        public Pokemon[] Array{ get; set; }
        public PokemonArray() {
            Array = new Pokemon[] 
            {
                new Pokemon(),
                new Pokemon(),
                new Pokemon(),
                
            };
        }
    }
}
