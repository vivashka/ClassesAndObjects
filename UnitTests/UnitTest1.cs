using ClassesAndObjects;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPokemonArrayRange()
        {
            //Arrange
            PokemonArray poks = new PokemonArray(10, true);
            //Assert
            Assert.ThrowsException<IndexOutOfRangeException>(() => (poks[-1]));
            Assert.ThrowsException<IndexOutOfRangeException>(() => (poks[12]));
        }
        [TestMethod]
        public void TestPokemonMake()
        {
            //Arrange
            Pokemon pok1 = new Pokemon();

            Pokemon pok2 = new Pokemon(20, 35, 3);

            Pokemon pok3 = new Pokemon(1, 1, 0);

            //Assert
            Assert.AreEqual(pok1, pok1);
            Assert.AreNotEqual(pok1, pok2);
            Assert.AreEqual(pok1, pok3);
            Assert.AreEqual(pok1, new Pokemon(pok1));
            
        }

        [TestMethod]
        public void TestPokemonArrayMake()
        {
            //Arrange
            PokemonArray pokemonArray = new PokemonArray(10, true);
            PokemonArray copdiedArray = new PokemonArray(pokemonArray);

            //Assert
            for (int i = 0; i < pokemonArray.Length; i++)
            {
                Assert.AreEqual(pokemonArray[i], copdiedArray[i]);
            }
        }
        [TestMethod]
        public void TestPokemonArrayShow()
        {
            //Arrange
            Pokemon pokemon = new Pokemon();

            //Act
            string expexted = "Характеристики покемона\nУрон - 17\nЗащита - 32\nВыносливость - 1\n";

            Assert.AreEqual(pokemon.Show(), expexted);
        }

    }
}