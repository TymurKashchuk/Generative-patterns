namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Virus grandParent = new Virus("Alpha", "A", 10, 5);

            Virus parent1 = new Virus("Beta", "B", 6, 3);
            Virus parent2 = new Virus("Gamma", "B", 5, 3);

            Virus child1 = new Virus("Delta", "C", 2, 1);
            Virus child2 = new Virus("Epsilon", "C", 2.5, 1);

            parent1.Children.Add(child1);
            parent2.Children.Add(child2);

            grandParent.Children.Add(parent1);
            grandParent.Children.Add(parent2);

            Console.WriteLine("Оригінальне сімейство:");
            grandParent.PrintInfo();

            Virus cloned = (Virus)grandParent.Clone();

            Console.WriteLine("\nКлоноване сімейство:");
            cloned.PrintInfo();
        }
    }
}
