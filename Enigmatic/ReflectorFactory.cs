using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main
{
    public static class ReflectorFactory
    {

        static Reflector Beta() => new Reflector("LEYJVCNIXWPBQMDRTAKZGFUHOS");
        static Reflector Gamma() => new Reflector("FSOKANUERHMBTIYCWLQPZXVGJD");
        static Reflector A() => new Reflector("EJMZALYXVBWFCRQUONTSPIKHGD");
        static Reflector B() => new Reflector("YRUHQSLDPXNGOKMIEBFZCWVJAT");
        static Reflector C() => new Reflector("FVPJIAOYEDRZXWGCTKUQSBNMHL");
        static Reflector BThin() => new Reflector("YRUHQSLDPXNGOKMIEBFZCWVJAT");
        static Reflector CThin() => new Reflector("FVPJIAOYEDRZXWGCTKUQSBNMHL");

        static Reflector RailwayUKW() => new Reflector("JVIUBHTCDYAKEQZPOSGXNRMWFL");
    }
}
