namespace Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            CharacterDirector director = new CharacterDirector();
            Character hero = director.BuildDefaultHero();
            Character enemy = director.BuildDefaultEnemy();
            Console.WriteLine("Герой");
            hero.PrintInfo();
            Console.WriteLine("\nВорог");
            enemy.PrintInfo();
        }
    }
}
