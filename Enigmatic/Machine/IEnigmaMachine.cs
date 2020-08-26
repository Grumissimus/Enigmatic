using Enigmatic.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Machine
{
    public interface IEnigmaMachine
    {
        public string CipherMessage(string message);
    }
}
