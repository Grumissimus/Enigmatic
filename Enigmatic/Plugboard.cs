using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main
{
    public class Plugboard
    {
        private readonly Dictionary<char, char> inputMap;

        public Plugboard()
        {
            inputMap = new Dictionary<char, char>();
        }

        public char Encrypt(char A) => inputMap.ContainsKey(A) ? inputMap[A] : A;

        public void Connect(char A, char B)
        {
            if (inputMap.ContainsKey(A))
            {
                Console.Error.WriteLine($"The {A} is already connected with {inputMap[A]}.");
                return;
            }

            if (inputMap.ContainsKey(B))
            {
                Console.Error.WriteLine($"The {B} is already connected with {inputMap[B]}.");
                return;
            }

            inputMap.Add(A, B);
            inputMap.Add(B, A);
        }

        public void Disconnect(char A)
        {
            if ( !inputMap.ContainsKey(A) )
            {
                Console.Error.WriteLine($"The {A} is not connected to any other input.");
                return;
            }

            char B = inputMap[B];

            inputMap.Remove(A);
            inputMap.Remove(B);
        }

        public void Disconnect(char A, char B)
        {
            try { 
                inputMap.Remove(A);
                inputMap.Remove(B);
            } 
            catch ( ArgumentNullException ex )
            {
                Console.Error.WriteLine( ex.Message );
            }
        }
    }
}
