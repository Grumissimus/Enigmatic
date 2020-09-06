using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Machine
{
    public interface IEnigma
    {
        void Reset();
        string EncryptMessage(string message);
    }
}
