using Enigmatic.Main.Interfaces;
using System;

namespace Enigmatic.Main.Parts
{
    public abstract class Stator : Cipherable, IStator
    {
        public Stator(string map = "ABCDEFGHIJKLMNOPQRSTUVWXYZ") : base(map)
        {
        }
    }
}
