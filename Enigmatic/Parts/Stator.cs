using Enigmatic.Main.Interfaces;

namespace Enigmatic.Main.Parts
{
    public abstract class Stator : Cipherable, IStator
    {
        public Stator(string map = "ABCDEFGHIJKLMNOPQRSTUVWXYZ") : base(map)
        {
        }
    }
}
