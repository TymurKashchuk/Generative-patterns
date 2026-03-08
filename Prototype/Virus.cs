using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Virus : IClassicPrototype
    {
        public string Name { get; set; }
        public string Species { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public List<Virus> Children { get; set; }

        public Virus(string name, string species, double weight, int age)
        {
            Name = name;
            Species = species;
            Weight = weight;
            Age = age;
            Children = new List<Virus>();
        }

        public Virus(Virus prototype)
        {
            Name = prototype.Name;
            Species = prototype.Species;
            Weight = prototype.Weight;
            Age = prototype.Age;
            Children = new List<Virus>();
            foreach (var child in prototype.Children)
            {
                Children.Add((Virus)child.Clone());
            }
        }

        public virtual IClassicPrototype Clone()
        {
            return new Virus(this);
        }

        public void PrintInfo(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent * 4)}[{Species}] {Name} | Вага: {Weight} мг | Вік: {Age} год");
            foreach (var child in Children)
            {
                child.PrintInfo(indent + 1);
            }
        }
    }
}
