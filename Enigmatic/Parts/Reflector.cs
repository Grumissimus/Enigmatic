using Enigmatic.Main.Interfaces;

namespace Enigmatic.Main.Parts
{
    public class Reflector : Wheel
    {
        public Reflector(string output) : base(output)
        {
        }

        public Reflector(string input, string output) : base(input, output)
        {
        }
    }
}
