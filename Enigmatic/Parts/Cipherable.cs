using Enigmatic.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigmatic.Main.Parts
{
    public abstract class Cipherable : ICipherable
    {
        public Dictionary<char, char> InputMap { get; protected set; }
        public Dictionary<char, char> OutputMap { get; protected set; }

        public Cipherable(string map = "ABCDEFGHIJKLMNOPQRSTUVWXYZ")
        {
            ValidateMap(map);
            InputMap = new Dictionary<char, char>();
            OutputMap = new Dictionary<char, char>();

            for (int i = 0; i < map.Length; i++)
            {
                InputMap.Add(ToChar(i), map[i]);
                OutputMap.Add(map[i], ToChar(i));
            }
        }

        protected virtual string ValidateMap(string map)
        {
            map = map.ToUpper();

            if (map.Length < 26)
            {
                throw new ArgumentException("The map is less than 26 characters long.");
            }

            if (map.Length > 26)
            {
                throw new ArgumentException("The map is less than 26 characters long.");
            }

            if ( map.Distinct().Count() < 26 )
            {
                throw new ArgumentException("The map has repeating characters.");
            }

            if( !map.All( ch => ch >= 'A' && ch <= 'Z') )
            {
                throw new ArgumentException("The map contains invalid characters. The cipher map consists of only ANSI uppercase letters.");
            }

            return map;
        }

        public virtual char CipherInputCharacter(char character)
        {
            if (character >= 'a' && character <= 'z') character = char.ToUpper(character);
            if (!(character >= 'A' && character <= 'Z')) return character;

            return InputMap[character];
        }

        public virtual char CipherOutputCharacter(char character)
        {
            if (character >= 'a' && character <= 'z') character = char.ToUpper(character);
            if (!(character >= 'A' && character <= 'Z')) return character;

            return OutputMap[character];
        }

        public char ToChar(int wiring)
        {
            return (char)('A' + (wiring % 26));
        }

        public int ToWiring(char character)
        {
            if (character >= 'a' && character <= 'z') character = char.ToUpper(character);
            if (!(character >= 'A' && character <= 'Z')) return -1;

            return character - 'A';
        }
    }
}
