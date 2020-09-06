using Enigmatic.Main.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Machine
{
    public interface IRotorFactory
    {
        public Rotor CreateRotor(string type, char initialPosition);
    }
}
