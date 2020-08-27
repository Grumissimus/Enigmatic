using Enigmatic.Main.Interfaces;

namespace Enigmatic.Main.Parts
{
    public static class RotorFactory
    {
        public static IRotor I(char initialPosition) => new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "R", initialPosition);
        public static IRotor II(char initialPosition) => new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", "F", initialPosition);
        public static IRotor III(char initialPosition) => new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", "W", initialPosition);
        public static IRotor IV(char initialPosition) => new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", "K", initialPosition);
        public static IRotor V(char initialPosition) => new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", "A", initialPosition);
        public static IRotor VI(char initialPosition) => new Rotor("JPGVOUMFYQBENHZRDKASXLICTW", "AN", initialPosition);
        public static IRotor VII(char initialPosition) => new Rotor("NZJHGRCXMYSWBOUFAIVLPEKQDT", "AN", initialPosition);
        public static IRotor VIII(char initialPosition) => new Rotor("FKQHTLXOCBJSPDZRAMEWNIUYGV", "AN", initialPosition);

        public static IRotor ThinBeta(char initialPosition) => new Rotor("LEYJVCNIXWPBQMDRTAKZGFUHOS", "", initialPosition);
        public static IRotor ThinGamma(char initialPosition) => new Rotor("FSOKANUERHMBTIYCWLQPZXVGJD", "", initialPosition);
    }
}
