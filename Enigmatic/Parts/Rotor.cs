using Enigmatic.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Enigmatic.Main.Parts
{
    public class Rotor : Cipherable, IRotor
    {
        public string Turnover { get; }
        public int InitialPosition { get; }
        public int Deflection { get; protected set; }

        public Rotor(string map, string turnover, char initialPosition = 'A') : base(map)
        {
            Turnover = turnover;
            InitialPosition = ToWiring(initialPosition);
        }

        protected override char CipherCharacter(char character, Dictionary<char, char> cipherMap)
        {
            character = char.ToUpper(character);
            if (!(character >= 'A' && character <= 'Z')) return character;

            character = ToChar( (ToWiring(character) + InitialPosition + Deflection) % 26 );

            character = cipherMap[character];
            int temp = ToWiring(character) - Deflection;

            character = ToChar( (temp < 0 ? 26 + temp : temp) % 26 );
            return character;
        }

        public void IncrementDeflection()
        {
            Deflection = (Deflection + 1) % 26;
        }

        public char DeflectAndCipher(char character)
        {
            character = char.ToUpper(character);
            if (!(character >= 'A' && character <= 'Z')) return character;

            IncrementDeflection();
            return CipherInputCharacter(character);
        }

        public bool IsInTurnover() => Turnover.Contains( ToChar(Deflection) );
    }
}
