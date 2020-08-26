using System;
using System.Text;

namespace Enigmatic.Main.Interfaces
{
    public interface ICipherable
    {
        int ToWiring(char character);
        char ToChar(int wiring);
        char CipherCharacter(char character);
    }
}
