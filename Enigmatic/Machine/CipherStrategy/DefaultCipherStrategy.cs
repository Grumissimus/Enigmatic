using Enigmatic.Main.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Machine.CipherStrategy
{
    /// <summary>
    /// A ciphering strategy suitable for most Enigma machine models.
    /// </summary>
    public class DefaultCipherStrategy : ICipherStrategy
    {
        public EnigmaMachine Enigma { get; }

        public DefaultCipherStrategy(EnigmaMachine enigma)
        {
            Enigma = enigma;
        }

        public string Apply(string message)
        {
            StringBuilder encryptedMessage = new StringBuilder();
            char temp;

            foreach(char ch in message)
            {
                //Input route
                temp = Enigma.EntryWheel.CipherCharacter( Enigma.Plugboard.CipherCharacter(ch) );

                temp = Enigma.RightRotor.DeflectAndCipher(temp);

                temp = Enigma.RightRotor.IsInTurnover() ?
                    Enigma.MiddleRotor.DeflectAndCipher(temp) :
                    Enigma.MiddleRotor.CipherCharacter(temp);

                temp = Enigma.MiddleRotor.IsInTurnover() ?
                    Enigma.LeftRotor.DeflectAndCipher(temp) :
                    Enigma.LeftRotor.CipherCharacter(temp);

                temp = Enigma.Reflector.CipherCharacter(temp);

                //Output route
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
