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

        public override char CipherCharacter(char character)
        {
            character = ToChar((ToWiring(character) + InitialPosition + Deflection) % 26);

            if (character >= 'a' && character <= 'z') character = char.ToUpper(character);
            if (!(character >= 'A' && character <= 'Z')) return character;

            character = CipherMap[character];
            character = ToChar((ToWiring(character) - Deflection) % 26);
            return character;
        }

        public void IncrementDeflection()
        {
            Deflection = (Deflection + 1) % 26;
        }

        public char DeflectAndCipher(char character)
        {
            IncrementDeflection();
            return CipherCharacter(character);
        }

        public bool IsInTurnover() => Turnover.Contains( ToChar(Deflection) );

    }
}
