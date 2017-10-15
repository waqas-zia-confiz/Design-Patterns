using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyWeight
{
    class CharacterFactory
    {
        private Dictionary<char, Character> _characters =
          new Dictionary<char, Character>();

        public Character GetCharacter(char key)
        {
            Character character = null;
            if (_characters.ContainsKey(key))            
                character = _characters[key];
            else {
                character = new ConcreteCharacter(key);
                _characters.Add(key, character);
            }
            return character;
        }
    }
}
