using Enigmatic.Main.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Machine.EnigmaZ
{
    public class EnigmaZRotorFactory : IRotorFactory
    {
        public Rotor CreateRotor(string type, char initialPosition)
        {
            return type switch
            {
                "I" => new Rotor("1234567890", "6418270359", "0", initialPosition),
                "II" => new Rotor("1234567890", "5841097632", "0", initialPosition),
                "III" => new Rotor("1234567890", "3581620794", "0", initialPosition),
                _ => null
            };
        }
    }
}
