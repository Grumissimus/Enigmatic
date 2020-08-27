using Enigmatic.Main.Interfaces;

namespace Enigmatic.Main.Parts
{
    public static class ReflectorFactory
    {
        public static IReflector A() => new StaticReflector("EJMZALYXVBWFCRQUONTSPIKHGD");
        public static IReflector B() => new StaticReflector("YRUHQSLDPXNGOKMIEBFZCWVJAT");
        public static IReflector C() => new StaticReflector("FVPJIAOYEDRZXWGCTKUQSBNMHL");
        public static IReflector Tirpitz() => new StaticReflector("GEKPBTAUMOCNILJDXZYFHWVQSR");

    }
}
