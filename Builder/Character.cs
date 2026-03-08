using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Character
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public int Height { get; set; }
        public string Build { get; set; }
        public string HairColor { get; set; }
        public string EyeColor { get; set; }
        public string Clothing { get; set; }
        public List<string> Inventory { get; set; } = new List<string>();
        public List<string> GoodDeeds { get; set; } = new List<string>();
        public List<string> EvilDeeds { get; set; } = new List<string>();

        public void PrintInfo()
        {
            Console.WriteLine($"Ім'я:{Name}");
            Console.WriteLine($"Роль:{Role}");
            Console.WriteLine($"Зріст:{Height} см");
            Console.WriteLine($"Статура:{Build}");
            Console.WriteLine($"Волосся:{HairColor}");
            Console.WriteLine($"Очі:{EyeColor}");
            Console.WriteLine($"Одяг:{Clothing}");
            Console.WriteLine($"Інвентар:{string.Join(", ", Inventory)}");
            if (GoodDeeds.Count > 0)
                Console.WriteLine($"Добрі справи: {string.Join(", ", GoodDeeds)}");
            if (EvilDeeds.Count > 0)
                Console.WriteLine($"Злі справи: {string.Join(", ", EvilDeeds)}");
        }
    }
}
