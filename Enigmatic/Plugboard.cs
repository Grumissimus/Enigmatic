using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main
{
    public class Plugboard
    {
        private Dictionary<char, char> inputMap;

        public Plugboard()
        {
            inputMap = new Dictionary<char, char>();
        }

        public char Encrypt(char A) => inputMap.ContainsKey(A) ? inputMap[A] : A;

        public void Connect(char A, char B)
        {
            if (inputMap.ContainsKey(A))
                throw new ArgumentException($"The {A} is already connected with {inputMap[A]}.");

            if (inputMap.ContainsKey(B))
                throw new ArgumentException($"The {B} is already connected with {inputMap[B]}.");

            inputMap.Add(A, B);
            inputMap.Add(B, A);
        }

        public void Disconnect(char A)
        {
            char B = inputMap.TryGetValue(A, out B) ? B : throw new ArgumentException($"The {A} is not connected to any other input.");
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
