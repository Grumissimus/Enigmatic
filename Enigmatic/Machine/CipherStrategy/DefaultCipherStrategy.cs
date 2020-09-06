using System.Text;

namespace Enigmatic.Main.Machine.CipherStrategy
{
    /// <summary>
    /// A ciphering strategy suitable for most Enigma machine models.
    /// </summary>
    public class DefaultCipherStrategy : ICipherStrategy
    {
        public DefaultCipherStrategy()
        {
        }

        public string Apply(EnigmaMachine enigma, string message)
        {
            StringBuilder encryptedMessage = new StringBuilder();
            char temp;

            foreach (char ch in message)
            {
                if (!char.IsLetter(ch) || !(char.ToUpper(ch) >= 'A' && char.ToUpper(ch) <= 'Z'))
                {
                    encryptedMessage.Append(ch);
                    continue;
                }

                //Input route
                temp = enigma.EntryWheel.CipherInput(enigma.Plugboard.Cipher(ch));

                temp = enigma.RightRotor.DeflectAndCipher(temp);

                temp = enigma.RightRotor.IsInTurnover() ?
                    enigma.MiddleRotor.DeflectAndCipher(temp) :
                    enigma.MiddleRotor.CipherInput(temp);

                temp = enigma.MiddleRotor.IsInTurnover() ?
                    enigma.LeftRotor.DeflectAndCipher(temp) :
                    enigma.LeftRotor.CipherInput(temp);

                temp = enigma.Reflector.CipherInput(temp);

                //Output route
                temp = enigma.LeftRotor.CipherOutput(temp);

                temp = enigma.MiddleRotor.CipherOutput(temp);

                temp = enigma.RightRotor.CipherOutput(temp);

                temp = enigma.EntryWheel.CipherOutput(temp);

                temp = enigma.Plugboard.Cipher(temp);

                encryptedMessage.Append(temp);
            }

            return encryptedMessage.ToString();
        }
    }
}
