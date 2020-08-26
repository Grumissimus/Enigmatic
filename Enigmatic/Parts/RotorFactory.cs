using Enigmatic.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Parts
{
    public static class RotorFactory
    {
        public static IRotor I(char initialPosition) => new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q", initialPosition);
        public static IRotor II(char initialPosition) => new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", "E", initialPosition);
        public static IRotor III(char initialPosition) => new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", "V", initialPosition);
        public static IRotor IV(char initialPosition) => new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", "J", initialPosition);
        public static IRotor V(char initialPosition) => new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", "Z", initialPosition);
        public static IRotor VI(char initialPosition) => new Rotor("JPGVOUMFYQBENHZRDKASXLICTW", "ZM", initialPosition);
        public static IRotor VII(char initialPosition) => new Rotor("NZJHGRCXMYSWBOUFAIVLPEKQDT", "ZM", initialPosition);
        public static IRotor VIII(char initialPosition) => new Rotor("FKQHTLXOCBJSPDZRAMEWNIUYGV", "ZM", initialPosition);

        public static IRotor ThinBeta(char initialPosition) => new Rotor("LEYJVCNIXWPBQMDRTAKZGFUHOS", "", initialPosition);
        public static IRotor ThinGamma(char initialPosition) => new Rotor("FSOKANUERHMBTIYCWLQPZXVGJD", "", initialPosition);
    }
}
