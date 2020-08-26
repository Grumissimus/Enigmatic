using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Interfaces
{
    public interface IRotor : ICipherable
    {
        string Turnover { get; }
        int InitialPosition { get; }
        int Deflection { get; }
        char DeflectAndCipher(char character);
        void IncrementDeflection();
        bool IsInTurnover();
    }
}
