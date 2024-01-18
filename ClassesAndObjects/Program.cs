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
        }
    }
}