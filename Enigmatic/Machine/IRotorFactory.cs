using Enigmatic.Main.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Machine
{
    public interface IReflectorFactory
    {
        public Reflector CreateReflector(string type);
    }
}
