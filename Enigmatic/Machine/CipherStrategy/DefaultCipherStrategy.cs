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
                temp = enigma.EntryWheel.CipherInputCharacter(enigma.Plugboard.CipherInputCharacter(ch));

                temp = enigma.RightRotor.DeflectAndCipher(temp);

                temp = enigma.RightRotor.IsInTurnover() ?
                    enigma.MiddleRotor.DeflectAndCipher(temp) :
                    enigma.MiddleRotor.CipherInputCharacter(temp);

                temp = enigma.MiddleRotor.IsInTurnover() ?
                    enigma.LeftRotor.DeflectAndCipher(temp) :
                    enigma.LeftRotor.CipherInputCharacter(temp);

                temp = enigma.Reflector.CipherInputCharacter(temp);

                //Output route
                temp = enigma.LeftRotor.CipherOutputCharacter(temp);

                temp = enigma.MiddleRotor.CipherOutputCharacter(temp);

                temp = enigma.RightRotor.CipherOutputCharacter(temp);

                temp = enigma.EntryWheel.CipherOutputCharacter(temp);

                temp = enigma.Plugboard.CipherOutputCharacter(temp);

                encryptedMessage.Append(temp);
            }

            return encryptedMessage.ToString();
        }
    }
}
