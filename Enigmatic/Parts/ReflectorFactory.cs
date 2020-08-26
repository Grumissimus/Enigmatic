using Enigmatic.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Parts
{
    public static class ReflectorFactory
    {
        public static IReflector A()
        {
            return new StaticReflector("EJMZALYXVBWFCRQUONTSPIKHGD");
        }
        public static IReflector B()
        {
            return new StaticReflector("YRUHQSLDPXNGOKMIEBFZCWVJAT");
        }
        public static IReflector C()
        {
            return new StaticReflector("FVPJIAOYEDRZXWGCTKUQSBNMHL");
        }
        public static IReflector Tirpitz()
        {
            return new StaticReflector("GEKPBTAUMOCNILJDXZYFHWVQSR");
        }

    }
}
