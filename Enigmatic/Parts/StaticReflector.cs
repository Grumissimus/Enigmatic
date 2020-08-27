using Enigmatic.Main.Interfaces;

namespace Enigmatic.Main.Parts
{
    public class StaticReflector : Stator, IReflector
    {
        public StaticReflector(string map) : base(map)
        {
        }
    }
}
