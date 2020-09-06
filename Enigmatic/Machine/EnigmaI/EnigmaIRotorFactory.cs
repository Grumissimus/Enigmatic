using Enigmatic.Main.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Machine.EnigmaI
{
    public class EnigmaIRotorFactory : IRotorFactory
    {
        public Rotor CreateRotor(string type, char initialPosition)
        {
            return type switch
            {
                "I" => new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "R", initialPosition),
                "II" => new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", "F", initialPosition),
                "III" => new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", "W", initialPosition),
                "IV" => new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", "K", initialPosition),
                "V" => new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", "A", initialPosition),
                _ => null
            };
        }
    }
}
