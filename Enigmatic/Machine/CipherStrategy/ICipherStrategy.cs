using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Machine.CipherStrategy
{
    public interface ICipherStrategy
    {
        public EnigmaMachine Enigma { get; }
        string Apply(string message);
    }
}
