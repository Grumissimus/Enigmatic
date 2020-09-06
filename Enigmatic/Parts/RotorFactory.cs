using Enigmatic.Main.Interfaces;

namespace Enigmatic.Main.Parts
{
    public static class RotorFactory
    {
        public static Rotor I(char initialPosition) => new Rotor("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "EKMFLGDQVZNTOWYHXUSPAIBRCJ", "R", initialPosition);
        public static Rotor II(char initialPosition) => new Rotor("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "AJDKSIRUXBLHWTMCQGZNPYFVOE", "F", initialPosition);
        public static Rotor III(char initialPosition) => new Rotor("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "BDFHJLCPRTXVZNYEIWGAKMUSQO", "W", initialPosition);
        public static Rotor IV(char initialPosition) => new Rotor("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "ESOVPZJAYQUIRHXLNFTGKDCMWB", "K", initialPosition);
        public static Rotor V(char initialPosition) => new Rotor("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "VZBRGITYUPSDNHLXAWMJQOFECK", "A", initialPosition);
        public static Rotor VI(char initialPosition) => new Rotor("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "JPGVOUMFYQBENHZRDKASXLICTW", "AN", initialPosition);
        public static Rotor VII(char initialPosition) => new Rotor("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "NZJHGRCXMYSWBOUFAIVLPEKQDT", "AN", initialPosition);
        public static Rotor VIII(char initialPosition) => new Rotor("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "FKQHTLXOCBJSPDZRAMEWNIUYGV", "AN", initialPosition);

        public static Rotor ThinBeta(char initialPosition) => new Rotor("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "LEYJVCNIXWPBQMDRTAKZGFUHOS", "", initialPosition);
        public static Rotor ThinGamma(char initialPosition) => new Rotor("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "FSOKANUERHMBTIYCWLQPZXVGJD", "", initialPosition);
    }
}
