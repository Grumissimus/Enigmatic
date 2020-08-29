using Enigmatic.Main.Interfaces;

namespace Enigmatic.Main.Parts
{
    public static class ReflectorFactory
    {
        public static IReflector A() => new Reflector("EJMZALYXVBWFCRQUONTSPIKHGD");
        public static IReflector B() => new Reflector("YRUHQSLDPXNGOKMIEBFZCWVJAT");
        public static IReflector C() => new Reflector("FVPJIAOYEDRZXWGCTKUQSBNMHL");
        public static IReflector Tirpitz() => new Reflector("GEKPBTAUMOCNILJDXZYFHWVQSR");
        public static IReflector UkwD() => new Reflector("IMETCGFRAYSQBZXWLHKDVUPOJN");
        public static IReflector Norenigma() => new Reflector("MOWJYPUXNDSRAIBFVLKZGQCHET");
        public static IReflector UkwKD() => new Reflector("KOTVPNLMJIAGHFBEWYXCZDQSRU");
        public static IReflector Railway() => new Reflector("QYHOGNECVPUZTFDJAXWMKISRBL");
    }
}
