using Enigmatic.Main.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Machine.EnigmaZ
{
    public class EnigmaZ : IEnigma
    {

        private readonly EntryWheel etw = new EntryWheel("1234567890", "1234567890");
        private readonly Rotor leftRotor;
        private readonly Rotor middleRotor;
        private readonly Rotor rightRoor;
        private readonly Rotor ukw = new Rotor("1234567890", "5079183642", "9", '0');

        public EnigmaZ(string RotorSetting)
        {

        }

        public string EncryptMessage(string message)
        {
            StringBuilder cipherMessage = new StringBuilder();



            return cipherMessage.ToString();
        }

        public void Reset()
        {

        }
    }
}
