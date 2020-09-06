using Enigmatic.Main.Interfaces;

namespace Enigmatic.Main.Parts
{
    public static class ReflectorFactory
    {
        public static Reflector A() => new Reflector("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "EJMZALYXVBWFCRQUONTSPIKHGD");
        public static Reflector B() => new Reflector("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "YRUHQSLDPXNGOKMIEBFZCWVJAT");
        public static Reflector C() => new Reflector("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "FVPJIAOYEDRZXWGCTKUQSBNMHL");
        public static Reflector Tirpitz() => new Reflector("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "GEKPBTAUMOCNILJDXZYFHWVQSR");
        public static Reflector UkwD() => new Reflector("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "IMETCGFRAYSQBZXWLHKDVUPOJN");
        public static Reflector Norenigma() => new Reflector("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "MOWJYPUXNDSRAIBFVLKZGQCHET");
        public static Reflector UkwKD() => new Reflector("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "KOTVPNLMJIAGHFBEWYXCZDQSRU");
        public static Reflector Railway() => new Reflector("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "QYHOGNECVPUZTFDJAXWMKISRBL");
    }
}
