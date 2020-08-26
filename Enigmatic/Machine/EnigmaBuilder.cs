using Enigmatic.Main.Interfaces;
using Enigmatic.Main.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Machine
{
    public class EnigmaBuilder
    {
        private Plugboard plugboard;

        private IStator EntryStator;
        private IStator Reflector;

        private IRotor leftRotor;
        private IRotor middleRotor;
        private IRotor rightRotor;
    }
}
