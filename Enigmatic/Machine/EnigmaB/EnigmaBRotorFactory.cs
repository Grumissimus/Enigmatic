using Enigmatic.Main.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Machine.EnigmaB
{
    public class EnigmaBRotorFactory : IRotorFactory
    {
        public Rotor CreateRotor(string type, char initialPosition)
        {
            return type switch
            {
                "I" => new Rotor("ABCDEFGHIJKLMNOPQRSTUVXYZÅÄÖ", "PSBGÖXQJDHOÄUCFRTEZVÅINLYMKA", "Ö", initialPosition),
                "II" => new Rotor("ABCDEFGHIJKLMNOPQRSTUVXYZÅÄÖ", "CHNSYÖADMOTRZXBÄIGÅEKQUPFLVJ", "Ö", initialPosition),
                "III" => new Rotor("ABCDEFGHIJKLMNOPQRSTUVXYZÅÄÖ", "ÅVQIAÄXRJBÖZSPCFYUNTHDOMEKGL", "Ö", initialPosition),
                _ => null
            };
        }
    }
}
