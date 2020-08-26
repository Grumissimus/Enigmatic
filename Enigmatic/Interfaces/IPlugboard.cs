using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Interfaces
{
    public interface IPlugboard
    {
        void Connect(char A, char B);
        void Disconnect(char A);
        void Disconnect(char A, char B);
    }
}
