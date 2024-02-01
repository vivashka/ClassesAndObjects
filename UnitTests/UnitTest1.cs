using ClassesAndObjects;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void TestPokemonMake()
        {
            //Arrange
            Pokemon pok1 = new Pokemon();
            //Act
            Pokemon pok2 = new Pokemon(20, 35, 3);

            Pokemon pok3 = new Pokemon(1, 1, 0);
            Pokemon pokCopy = new Pokemon(pok1);

            //Assert
            Assert.AreEqual(pok1, pok3);
            Assert.AreNotEqual(pok1, pok2);
            Assert.AreEqual(pok1, pokCopy);
            
        }

        [TestMethod]
        public void TestPokemonLevelUp()
        {
            //Arrange
            Pokemon pokemon = new Pokemon();

            //Act
            Pokemon pokemonSame = new Pokemon(pokemon);
            pokemon.LevelUp(2, 2, 2);
            Pokemon.SLevelUp(pokemonSame, 3, 3, 3);

            //Assert
            Assert.AreNotEqual(pokemonSame, pokemon);
        }
        [TestMethod]
        public void TestPokemonUnaryTasks()
        {
            //Arrange
            Pokemon pokemon = new Pokemon(18,32,5);

            //Act
            float cp = ~pokemon;
            Pokemon pokemon2 = pokemon--;
            

            //Assert
            Assert.AreNotEqual(pokemon.Stamina, pokemon2.Stamina);
            Assert.AreNotEqual(cp, 0);
            

        }
        [TestMethod]
        public void TestPokemonСonversionTask()
        {
            //Arrange
            Pokemon pokemon = new Pokemon(18, 32, 5);
            //Act
            double sumAvarage = pokemon;
            int sum = (int)pokemon;
            //Assert
            Assert.IsInstanceOfType(sumAvarage, typeof(double));
            Assert.IsInstanceOfType(sum, typeof(int));
        }

        [TestMethod]
        public void TestPokemonBinaryTask()
        {
            //Arrange
            Pokemon pokemon = new Pokemon(18, 32, 5);
            //Act
            Pokemon moreStm = new Pokemon(pokemon >> 5);
            Pokemon moreDef = new Pokemon(pokemon > 10);
            Pokemon moreAtk = new Pokemon(pokemon < 10);
            //Assert
            Assert.AreNotEqual(moreDef.Stamina, pokemon.Defence);
            Assert.AreNotEqual(moreStm, pokemon.Stamina);
            Assert.AreNotEqual(moreAtk, pokemon.Attack);
        }

        [TestMethod]
        public void TestPokemonArrayMake()
        {
            //Arrange
            PokemonArray pokemonArrMain = new PokemonArray();
            
            PokemonArray pokemonArray = new PokemonArray(10, true);
            //Act
            PokemonArray copdiedArray = new PokemonArray(pokemonArray);

            pokemonArray[1] = pokemonArray[1];


            for (int i = 0; i < pokemonArray.Length; i++)
            {
                //Assert
                Assert.AreEqual(pokemonArray[i], copdiedArray[i]);
            }
            Assert.AreEqual(pokemonArray[1], pokemonArray[1]);
            Assert.AreEqual(pokemonArrMain.Length, 3);
        }

        [TestMethod]
        public void TestPokemonArrayRange()
        {
            //Arrange
            PokemonArray poks = new PokemonArray(10, true);
            //Assert
            Assert.ThrowsException<Exception>(() => (poks[-1]));
            Assert.ThrowsException<Exception>(() => (poks[12]));
        }

        //[TestMethod]
        //public void TestProgramMode()
        //{
        //    //Arrange
        //    PokemonArray pokemon = new PokemonArray(50, true);

        //    //Act
        //    int mode = ClassesAndObjects.Program.ModePokemons(pokemon);

        //    //Assert
        //    Assert.IsNotNull(mode);
        //}

        [TestMethod]
        public void TestPokemonShow()
        {
            //Arrange
            Pokemon pokemon = new Pokemon();

            //Act
            string pokeball = pokemon.ToString();

            string expect = $"\nХарактеристики покемона\nУрон - 17\nЗащита - 32\nВыносливость - 1\n";

            //Assert
            Assert.AreEqual(pokeball, expect);
        }
        [TestMethod]
        public void TestPokemonArrayShow()
        {
            //Arrange
            PokemonArray pokemon = new PokemonArray();

            //Act
            string pokeball = pokemon.ShowPokemons();

            string expect = $"\nХарактеристики покемона\nУрон - 17\nЗащита - 32\nВыносливость - 1\n\nХарактеристики покемона\nУрон - 17\nЗащита - 32\nВыносливость - 1\n\nХарактеристики покемона\nУрон - 17\nЗащита - 32\nВыносливость - 1\n";

            //Assert
            Assert.AreEqual(pokeball, expect);
        }
    }
}