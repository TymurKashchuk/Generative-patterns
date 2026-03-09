using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class EnemyBuilder : ICharacterBuilder
    {
        private Character _character = new Character();

        public ICharacterBuilder SetName(string name)
        {
            _character.Name = name;
            return this;
        }

        public ICharacterBuilder SetRole(string role)
        {
            _character.Role = role;
            return this;
        }

        public ICharacterBuilder SetHeight(int height)
        {
            _character.Height = height;
            return this;
        }

        public ICharacterBuilder SetBuild(string build)
        {
            _character.Build = build;
            return this;
        }

        public ICharacterBuilder SetHairColor(string hairColor)
        {
            _character.HairColor = hairColor;
            return this;
        }

        public ICharacterBuilder SetEyeColor(string eyeColor)
        {
            _character.EyeColor = eyeColor;
            return this;
        }

        public ICharacterBuilder SetClothing(string clothing)
        {
            _character.Clothing = clothing;
            return this;
        }

        public ICharacterBuilder AddInventoryItem(string item)
        {
            _character.Inventory.Add(item);
            return this;
        }

        public EnemyBuilder AddEvilDeed(string evil)
        {
            _character.EvilDeeds.Add(evil);
            return this;
        }

        public Character Build()
        {
            return _character;
        }
    }
}
