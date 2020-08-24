using System;
using System.Collections.Generic;
using System.Data;

namespace Enigmatic.Main
{
    public class Reflector
    {
        public string InputMap { get; private set; }

        public Reflector(string map)
        {
            InputMap = map;
        }

        private int GetIndex(char character) => (character - 'A') % 26;

        public char Encrypt(char character)
        {
            if (character >= 'a' && character <= 'z') character = char.ToUpper(character);
            if (!(character >= 'A' && character <= 'Z')) return character;

            return InputMap[GetIndex(character)];
        }
    }
}
