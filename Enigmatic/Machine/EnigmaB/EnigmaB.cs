using Enigmatic.Main.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Enigmatic.Main.Machine.EnigmaB
{
    class EnigmaB : IEnigma
    {
        private readonly EntryWheel etw;
        private Rotor leftRotor;
        private Rotor middleRotor;
        private Rotor rightRotor;
        private readonly Reflector ukw;

        public EnigmaB(string rotorSettings, string ringSettings)
        {
            var rotorFactory = new EnigmaBRotorFactory();

            etw = new EntryWheel("ABCDEFGHIJKLMNOPQRSTUVXYZÅÄÖ", "ABCDEFGHIJKLMNOPQRSTUVXYZÅÄÖ");
            ukw = new Reflector("ABCDEFGHIJKLMNOPQRSTUVXYZÅÄÖ", "LDGBÄNCPSKJAVFZHXUIÅRMQÖOTEY");

            string[] rotorTypes = rotorSettings.Split(' ');
            char[] ringTypes = ringSettings.Split(' ').Select(x => x[0]).ToArray();

            leftRotor = rotorFactory.CreateRotor(rotorTypes[0], ringTypes[0]);
            middleRotor = rotorFactory.CreateRotor(rotorTypes[1], ringTypes[1]);
            rightRotor = rotorFactory.CreateRotor(rotorTypes[2], ringTypes[2]);
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
    }
}
