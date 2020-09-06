using Enigmatic.Main.Parts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Enigmatic.Main.Machine.EnigmaI
{
    public class EnigmaI : IEnigma
    {
        private Plugboard plugboard;
        private readonly EntryWheel etw = new EntryWheel("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        private Rotor leftRotor;
        private Rotor middleRotor;
        private Rotor rightRotor;
        private readonly Reflector ukw;

        public EnigmaI(string rotorSettings, string ringSettings, string uwkType = "A", string plugboardSettings = "")
        {
            var rotorFactory = new EnigmaIRotorFactory();
            var reflectorFactory = new EnigmaIReflectorFactory();

            plugboard = new Plugboard("ABCDEFGHIJKLMNOPQRSTUVWXYZ", plugboardSettings);

            string[] rotorTypes = rotorSettings.Split(' ');
            char[] ringTypes = ringSettings.Split(' ').Select( x => x[0] ).ToArray();

            leftRotor = rotorFactory.CreateRotor(rotorTypes[0], ringTypes[0]);
            middleRotor = rotorFactory.CreateRotor(rotorTypes[1], ringTypes[1]);
            rightRotor = rotorFactory.CreateRotor(rotorTypes[2], ringTypes[2]);

            ukw = reflectorFactory.CreateReflector(uwkType);
        }

        public string EncryptMessage(string message)
        {
            StringBuilder cipherMessage = new StringBuilder();
            char curChar;

            foreach(char c in message)
            {
                curChar = plugboard.Cipher(c);
                curChar = etw.CipherInput(curChar);
                curChar = rightRotor.DeflectAndCipher(curChar);
                curChar = rightRotor.IsInTurnover() ? middleRotor.DeflectAndCipher(curChar) : middleRotor.CipherInput(curChar);
                curChar = middleRotor.IsInTurnover() ? leftRotor.DeflectAndCipher(curChar) : leftRotor.CipherInput(curChar);
                curChar = ukw.CipherInput(curChar);
                curChar = leftRotor.CipherOutput(curChar);
                curChar = middleRotor.CipherOutput(curChar);
                curChar = rightRotor.CipherOutput(curChar);
                curChar = etw.CipherOutput(curChar);
                curChar = plugboard.Cipher(curChar);

                cipherMessage.Append(curChar);
            }

            return cipherMessage.ToString();
        }
    }
}
