using Enigmatic.Main.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigmatic.Main.Machine.EnigmaZ
{
    public class EnigmaZ : IEnigma
    {

        private readonly EntryWheel etw;
        private readonly Rotor leftRotor;
        private readonly Rotor middleRotor;
        private readonly Rotor rightRotor;
        private readonly Rotor ukw;

        public EnigmaZ(string rotorSettings, string ringSettings)
        {
            var rotorFactory = new EnigmaZRotorFactory();
            etw = new EntryWheel("1234567890", "1234567890");

            string[] rotorTypes = rotorSettings.Split(' ');
            char[] ringTypes = ringSettings.Split(' ').Select(x => x[0]).ToArray();

            leftRotor = rotorFactory.CreateRotor(rotorTypes[0], ringTypes[0]);
            middleRotor = rotorFactory.CreateRotor(rotorTypes[1], ringTypes[1]);
            rightRotor = rotorFactory.CreateRotor(rotorTypes[2], ringTypes[2]);

            ukw = new Rotor("1234567890", "5079183642", "0", '0');
        }

        public string EncryptMessage(string message)
        {
            StringBuilder cipherMessage = new StringBuilder();

            char curChar;

            foreach (char c in message)
            {
                curChar = etw.CipherInput(c);
                curChar = rightRotor.DeflectAndCipher(curChar);
                curChar = rightRotor.IsInTurnover() ? middleRotor.DeflectAndCipher(curChar) : middleRotor.CipherInput(curChar);
                curChar = middleRotor.IsInTurnover() ? leftRotor.DeflectAndCipher(curChar) : leftRotor.CipherInput(curChar);
                curChar = ukw.CipherInput(curChar);
                curChar = leftRotor.CipherOutput(curChar);
                curChar = middleRotor.CipherOutput(curChar);
                curChar = rightRotor.CipherOutput(curChar);
                curChar = etw.CipherOutput(curChar);

                cipherMessage.Append(curChar);
            }

            return cipherMessage.ToString();
        }

        public void Reset()
        {

        }
    }
}
