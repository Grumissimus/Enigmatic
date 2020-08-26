using Enigmatic.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Parts
{
    public class StaticReflector : Stator, IReflector
    {
        public StaticReflector(string map) : base(map)
        {
        }
    }
}
