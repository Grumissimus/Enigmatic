using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Machine.CipherStrategy
{
    /// <summary>
    /// A cipher strategy used with Enigma machines that use a thin rotor (Enigma M4).
    /// </summary>
    public class EnigmaM4CipherStrategy : ICipherStrategy
    {
        public EnigmaMachine Enigma { get; }

        public EnigmaM4CipherStrategy(EnigmaMachine enigma)
        {
            Enigma = enigma;
        }

        public string Apply(string message)
        {
            StringBuilder encryptedMessage = new StringBuilder();
            char temp;

            foreach (char ch in message)
            {
                //Input route
                temp = Enigma.EntryWheel.CipherCharacter(Enigma.Plugboard.CipherCharacter(ch));

                temp = Enigma.RightRotor.DeflectAndCipher(temp);

                temp = Enigma.RightRotor.IsInTurnover() ?
                    Enigma.MiddleRotor.DeflectAndCipher(temp) :
                    Enigma.MiddleRotor.CipherCharacter(temp);

                temp = Enigma.MiddleRotor.IsInTurnover() ?
                    Enigma.LeftRotor.DeflectAndCipher(temp) :
                    Enigma.LeftRotor.CipherCharacter(temp);

                temp = Enigma.ThinRotor.CipherCharacter(temp);

                temp = Enigma.Reflector.CipherCharacter(temp);

                //Output route
                temp = Enigma.ThinRotor.CipherCharacter(temp);

                temp = Enigma.LeftRotor.CipherCharacter(temp);

                temp = Enigma.MiddleRotor.CipherCharacter(temp);

                temp = Enigma.RightRotor.CipherCharacter(temp);

                temp = Enigma.EntryWheel.CipherCharacter(temp);

                temp = Enigma.Plugboard.CipherCharacter(temp);

                encryptedMessage.Append(temp);
            }

            return message.ToString();
        }
    }
}
