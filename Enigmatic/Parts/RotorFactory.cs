using Enigmatic.Main.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Parts
{
    public static class RotorFactory
    {
        public static IRotor I(char initialPosition)
        {
            return new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q", initialPosition);
        }
        public static IRotor II(char initialPosition)
        {
            return new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", "E", initialPosition);
        }
        public static IRotor III(char initialPosition)
        {
            return new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", "V", initialPosition);
        }
        public static IRotor IV(char initialPosition)
        {
            return new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", "J", initialPosition);
        }
        public static IRotor V(char initialPosition)
        {
            return new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", "Z", initialPosition);
        }
        public static IRotor VI(char initialPosition)
        {
            return new Rotor("JPGVOUMFYQBENHZRDKASXLICTW", "ZM", initialPosition);
        }
        public static IRotor VII(char initialPosition)
        {
            return new Rotor("NZJHGRCXMYSWBOUFAIVLPEKQDT", "ZM", initialPosition);
        }
        public static IRotor VIII(char initialPosition)
        {
            return new Rotor("FKQHTLXOCBJSPDZRAMEWNIUYGV", "ZM", initialPosition);
        }

        public static IRotor ThinBeta(char initialPosition)
        {
            return new Rotor("LEYJVCNIXWPBQMDRTAKZGFUHOS", "", initialPosition);
        }
        public static IRotor ThinGamma(char initialPosition)
        {
            return new Rotor("FSOKANUERHMBTIYCWLQPZXVGJD", "", initialPosition);
        }
    }
}
