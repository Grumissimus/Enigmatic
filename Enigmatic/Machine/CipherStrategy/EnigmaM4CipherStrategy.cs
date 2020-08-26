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
        public EnigmaM4CipherStrategy()
        {
        }

        public string Apply(EnigmaMachine enigma, string message)
        {
            StringBuilder encryptedMessage = new StringBuilder();
            char temp;

            foreach (char ch in message)
            {
                //Input route
                temp = enigma.EntryWheel.CipherInputCharacter(enigma.Plugboard.CipherInputCharacter(ch));

                temp = enigma.RightRotor.DeflectAndCipher(temp);

                temp = enigma.RightRotor.IsInTurnover() ?
                    enigma.MiddleRotor.DeflectAndCipher(temp) :
                    enigma.MiddleRotor.CipherInputCharacter(temp);

                temp = enigma.MiddleRotor.IsInTurnover() ?
                    enigma.LeftRotor.DeflectAndCipher(temp) :
                    enigma.LeftRotor.CipherInputCharacter(temp);

                temp = enigma.ThinRotor.CipherInputCharacter(temp);

                temp = enigma.Reflector.CipherInputCharacter(temp);

                //Output route
                temp = enigma.ThinRotor.CipherOutputCharacter(temp);

                temp = enigma.LeftRotor.CipherOutputCharacter(temp);

                temp = enigma.MiddleRotor.CipherOutputCharacter(temp);

                temp = enigma.RightRotor.CipherOutputCharacter(temp);

                temp = enigma.EntryWheel.CipherOutputCharacter(temp);

                temp = enigma.Plugboard.CipherOutputCharacter(temp);

                encryptedMessage.Append(temp);
            }

            return message.ToString();
        }
    }
}
