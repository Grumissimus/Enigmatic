﻿using Enigmatic.Main.Interfaces;
using System.Collections.Generic;

namespace Enigmatic.Main.Parts
{
    public class Rotor : Wheel, IRotor
    {
        public string Turnover { get; }
        public int InitialPosition { get; }
        public int Deflection { get; protected set; }

        public Rotor(string input, string output, string turnover, char initialPosition = 'A') : base(input, output)
        {
            Deflection = 0;
            Turnover = turnover;
            InitialPosition = input.IndexOf(initialPosition);
        }

        public override char CipherInput(char input)
        {
            char tempInput = char.ToUpper(input);

            if (!_input.Contains(tempInput))
                return tempInput;

            int deflectedIndex = (_input.IndexOf(tempInput) + Deflection + _input.Length - InitialPosition) % _input.Length;

            tempInput = CipherMap.ContainsKey(_input[deflectedIndex]) ? CipherMap.GetByKey(_input[deflectedIndex]) : tempInput;

            int temp = _input.IndexOf(tempInput) - Deflection;
            deflectedIndex = ((temp < 0 ? _input.Length + temp : temp) + InitialPosition) % _input.Length;

            return char.IsLower(input) ? char.ToLower(_input[deflectedIndex]) : _input[deflectedIndex];
        }

        public override char CipherOutput(char output)
        {
            char tempOutput = char.ToUpper(output);

            if (!_output.Contains(tempOutput))
                return tempOutput;

            int deflectedIndex = (_input.IndexOf(tempOutput) + Deflection + _input.Length - InitialPosition) % _input.Length;

            tempOutput = CipherMap.ContainsValue(_input[deflectedIndex]) ? CipherMap.GetByValue(_input[deflectedIndex]) : tempOutput;

            int temp = _input.IndexOf(tempOutput) - Deflection;
            deflectedIndex = ((temp < 0 ? _input.Length + temp : temp) + InitialPosition) % _input.Length;

            return char.IsLower(output) ? char.ToLower(_input[deflectedIndex]) : _input[deflectedIndex];
        }

        public void IncrementDeflection()
        {
            Deflection = (Deflection + 1) % _input.Length;
        }

        public char DeflectAndCipher(char character)
        {
            if (!_input.Contains(character)) return character;

            IncrementDeflection();
            return CipherInput(character);
        }

        public bool IsInTurnover() => Turnover.Contains(_input[Deflection]);
    }
}
