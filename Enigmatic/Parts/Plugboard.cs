using Enigmatic.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Enigmatic.Main.Parts
{
    public class Plugboard : Cipherable, IPlugboard
    {
        public Plugboard()
        {
            CipherMap = new Dictionary<char, char>();
        }

        public void Connect(char A, char B)
        {
            A = char.ToUpper(A);
            B = char.ToUpper(B);

            if( !(A >= 'A' && A <= 'Z'))
                throw new ArgumentException($"Invalid character. Input can be only ASCII uppercase letter.");

            if (!(B >= 'A' && B <= 'Z'))
                throw new ArgumentException($"Invalid character. Output can be only ASCII uppercase letter.");

            if (CipherMap.ContainsKey(A))
                throw new ArgumentException($"The {A} is already connected with {CipherMap[A]}.");

            if (CipherMap.ContainsKey(B))
                throw new ArgumentException($"The {B} is already connected with {CipherMap[B]}.");

            CipherMap.Add(A, B);
            CipherMap.Add(B, A);
        }
        public void Disconnect(char A)
        {
            char B = CipherMap.TryGetValue(A, out B) ? B : throw new ArgumentException($"The {A} is not connected to any other input.");

            CipherMap.Remove(A);
            CipherMap.Remove(B);
        }

        public void Disconnect(char A, char B)
        {
            CipherMap.Remove(A);
            CipherMap.Remove(B);
        }
    }
}
