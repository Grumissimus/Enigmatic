using Enigmatic.Main.Common;
using Enigmatic.Main.Interfaces;
using System;
using System.Collections.Generic;

namespace Enigmatic.Main.Parts
{
    public class Plugboard : IPlugboard
    {
        private readonly string _validCharacters;
        public BiDictionary<char, char> Wiring { get; }

        public Plugboard()
        {
            _validCharacters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Wiring = new BiDictionary<char, char>();
        }

        public Plugboard(string validCharacters)
        {
            _validCharacters = validCharacters;
            Wiring = new BiDictionary<char, char>();
        }

        public Plugboard(string validCharacters, string[] connections)
        {
            _validCharacters = validCharacters;
            Wiring = new BiDictionary<char, char>();

            foreach (string conn in connections)
            {
                Connect(conn[0], conn[1]);
            }
        }

        public Plugboard(string validCharacters, string connections, char separator = ' ')
        {
            _validCharacters = validCharacters;
            Wiring = new BiDictionary<char, char>();

            foreach(string conn in connections.Split(separator))
            {
                Connect(conn[0], conn[1]);
            }
        }

        public char Cipher(char character)
        {
            if (Wiring.ContainsKey(character)) return Wiring.GetByKey(character);
            if (Wiring.ContainsValue(character)) return Wiring.GetByValue(character);

            return character;
        }

        public void Connect(char A, char B)
        {
            if( !_validCharacters.Contains(A) || !_validCharacters.Contains(B))
            {
                throw new ArgumentException("The attempted connection contains characters that are not considered valid.");
            }

            Wiring.Add(A, B);
        }

        public void Disconnect(char A)
        {
            Wiring.RemoveByKey(A);
            Wiring.RemoveByValue(A);
        }
    }
}
