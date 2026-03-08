using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CharacterDirector
    {
        public Character BuildDefaultHero()
        {
            var builder = new HeroBuilder();
            builder.SetName("Пітер Паркер")
                   .SetRole("Супергерой")
                   .SetHeight(178)
                   .SetBuild("Спортивна")
                   .SetHairColor("Темно-русявий")
                   .SetEyeColor("Карі")
                   .SetClothing("Червоно-синій костюм Людини-Павука")
                   .AddInventoryItem("Павутиномет")
                   .AddInventoryItem("Павутина")
                   .AddInventoryItem("Маска");

            builder.AddGoodDeed("Врятував Нью-Йорк від Зеленого Гобліна");
            builder.AddGoodDeed("Захистив мирних жителів від Доктора Октопуса");
            return builder.Build();
        }

        public Character BuildDefaultEnemy()
        {
            var builder = new EnemyBuilder();
            builder.SetName("Едді Брок")
                   .SetRole("Веном")
                   .SetHeight(190)
                   .SetBuild("Масивна")
                   .SetHairColor("Чорний")
                   .SetEyeColor("Білі (без зіниць)")
                   .SetClothing("Чорний симбіотичний костюм")
                   .AddInventoryItem("Симбіот")
                   .AddInventoryItem("Язик-щупальце")
                   .AddInventoryItem("Гострі кігті");

            builder.AddEvilDeed("Напав на Людину-Павука");
            builder.AddEvilDeed("Тероризував журналістів Дейлі Б'югл");
            return builder.Build();
        }
    }
}
