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
                temp = enigma.EntryWheel.CipherInput(enigma.Plugboard.Cipher(ch));

                temp = enigma.RightRotor.DeflectAndCipher(temp);

                temp = enigma.RightRotor.IsInTurnover() ?
                    enigma.MiddleRotor.DeflectAndCipher(temp) :
                    enigma.MiddleRotor.CipherInput(temp);

                temp = enigma.MiddleRotor.IsInTurnover() ?
                    enigma.LeftRotor.DeflectAndCipher(temp) :
                    enigma.LeftRotor.CipherInput(temp);

                temp = enigma.ThinRotor.CipherInput(temp);

                temp = enigma.Reflector.CipherInput(temp);

                //Output route
                temp = enigma.ThinRotor.CipherOutput(temp);

                temp = enigma.LeftRotor.CipherOutput(temp);

                temp = enigma.MiddleRotor.CipherOutput(temp);

                temp = enigma.RightRotor.CipherOutput(temp);

                temp = enigma.EntryWheel.CipherOutput(temp);

                temp = enigma.Plugboard.Cipher(temp);

                encryptedMessage.Append(temp);
            }

            return message.ToString();
        }
    }
}
