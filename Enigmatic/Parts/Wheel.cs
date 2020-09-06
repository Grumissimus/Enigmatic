using Enigmatic.Main.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigmatic.Main.Parts
{
    public abstract class Wheel
    {
        protected string _input;
        protected string _output;
        public BiDictionary<char, char> CipherMap { get; protected set; }

        public Wheel(string output)
        {
            Initialize("ABCDEFGHIJKLMNOPQRSTUVWXYZ", output);
        }

        public Wheel(string input, string output)
        {
            Initialize(input, output);
        }

        protected virtual void Initialize(string input, string output)
        {
            input = input.ToUpper();
            output = output.ToUpper();

            if (input.Length != output.Length) 
                throw new ArgumentException("The input and output map don't have the same length.");

            if (input.Distinct().Count() != input.Length)
                throw new ArgumentException("The input map has repeating characters.");

            if (output.Distinct().Count() != output.Length)
                throw new ArgumentException("The output map has repeating characters.");

            if (input.Except(output).Count() > 0)
                throw new ArgumentException("The input map contains characters that output map doesn't have.");

            if (output.Except(input).Count() > 0)
                throw new ArgumentException("The output map contains characters that input map doesn't have.");

            _input = input;
            _output = output;
            CipherMap = new BiDictionary<char, char>();

            for (int i = 0; i < input.Length; i++)
            {
                CipherMap.Add(char.ToLower(input[i]), char.ToLower(output[i]));
                CipherMap.Add(input[i], output[i]);
            }
        }

        public virtual char CipherInput(char input) => CipherMap.ContainsKey(input) ? CipherMap.GetByKey(input) : input;
        public virtual char CipherOutput(char output) => CipherMap.ContainsValue(output) ? CipherMap.GetByValue(output) : output;
    }
}
