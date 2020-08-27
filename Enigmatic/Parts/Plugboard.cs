using Enigmatic.Main.Interfaces;
using System;
using System.Collections.Generic;

namespace Enigmatic.Main.Parts
{
    public class Plugboard : Cipherable, IPlugboard
    {
        public Plugboard()
        {
            InputMap = new Dictionary<char, char>();
            OutputMap = new Dictionary<char, char>();
        }
        public override char CipherInputCharacter(char character)
        {
            if (character >= 'a' && character <= 'z') character = char.ToUpper(character);
            if (!(character >= 'A' && character <= 'Z')) return character;

            return InputMap.ContainsKey(character) ? InputMap[character] : character;
        }

        public override char CipherOutputCharacter(char character)
        {
            if (character >= 'a' && character <= 'z') character = char.ToUpper(character);
            if (!(character >= 'A' && character <= 'Z')) return character;

            return OutputMap.ContainsKey(character) ? OutputMap[character] : character;
        }

        public void Connect(char A, char B)
        {
            A = char.ToUpper(A);
            B = char.ToUpper(B);

            if (!(A >= 'A' && A <= 'Z'))
                throw new ArgumentException($"Invalid character. Input can be only ASCII uppercase letter.");

            if (!(B >= 'A' && B <= 'Z'))
                throw new ArgumentException($"Invalid character. Output can be only ASCII uppercase letter.");

            if (InputMap.ContainsKey(A))
                throw new ArgumentException($"The {A} is already connected with {InputMap[A]}.");

            if (OutputMap.ContainsKey(B))
                throw new ArgumentException($"The {B} is already connected with {OutputMap[B]}.");

            InputMap.Add(A, B);
            OutputMap.Add(B, A);
        }
        public void Disconnect(char A)
        {
            char B = InputMap.TryGetValue(A, out B) ? B : throw new ArgumentException($"The {A} is not connected to any other input.");

            InputMap.Remove(A);
            OutputMap.Remove(B);
        }

        public void Disconnect(char A, char B)
        {
            InputMap.Remove(A);
            OutputMap.Remove(B);
        }
    }
}
