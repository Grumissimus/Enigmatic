using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Machine.CipherStrategy
{
    public interface ICipherStrategy
    {
        string Apply(EnigmaMachine enigma, string message);
    }
}
