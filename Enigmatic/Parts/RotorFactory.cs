using Enigmatic.Main.Interfaces;

namespace Enigmatic.Main.Parts
{
    public static class RotorFactory
    {
        public static Rotor I(char initialPosition) => new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "R", initialPosition);
        public static Rotor II(char initialPosition) => new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", "F", initialPosition);
        public static Rotor III(char initialPosition) => new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", "W", initialPosition);
        public static Rotor IV(char initialPosition) => new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", "K", initialPosition);
        public static Rotor V(char initialPosition) => new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", "A", initialPosition);
        public static Rotor VI(char initialPosition) => new Rotor("JPGVOUMFYQBENHZRDKASXLICTW", "AN", initialPosition);
        public static Rotor VII(char initialPosition) => new Rotor("NZJHGRCXMYSWBOUFAIVLPEKQDT", "AN", initialPosition);
        public static Rotor VIII(char initialPosition) => new Rotor("FKQHTLXOCBJSPDZRAMEWNIUYGV", "AN", initialPosition);

        public static Rotor ThinBeta(char initialPosition) => new Rotor("LEYJVCNIXWPBQMDRTAKZGFUHOS", "", initialPosition);
        public static Rotor ThinGamma(char initialPosition) => new Rotor("FSOKANUERHMBTIYCWLQPZXVGJD", "", initialPosition);
    }
}
