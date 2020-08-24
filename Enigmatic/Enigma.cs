using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main
{
    public class Enigma
    {
        public Plugboard Plugboard { get; private set; }
        public EntryWheel EntryWheel { get; private set; }
        public Rotor[] Rotors { get; private set; }
        public Reflector Reflector { get; private set; }

        public Enigma(Plugboard plugboard, EntryWheel entryWheel, Rotor[] rotors, Reflector reflector)
        {
            Plugboard = plugboard;
            EntryWheel = entryWheel;
            Rotors = rotors;
            Reflector = reflector;
        }

        public string EncryptMessage(string message)
        {
            StringBuilder encryptedMessage = new StringBuilder();
            char tempChar;

            foreach(char ch in message)
            {
                tempChar = EntryWheel.Encrypt( Plugboard.Encrypt(ch) );

                for(int i = 0; i < Rotors.Length; i++)
                {
                    switch (i)
                    {
                        case 0:
                            tempChar = Rotors[i].RotateAndEncrypt(tempChar);
                            break;
                        case 1:
                        case 2:
                        case 3:
                            tempChar = Rotors[i].IsTurnover() ? Rotors[i].RotateAndEncrypt(tempChar) : Rotors[i].Encrypt(tempChar);
                            break;
                        default:
                            break;
                    }
                }

                tempChar = Reflector.Encrypt(tempChar);

                for (int i = Rotors.Length-1; i >= 0; i--)
                {
                    tempChar = Rotors[i].Encrypt(tempChar);
                }

                encryptedMessage.Append(tempChar);
            }

            return encryptedMessage.ToString();
        }
    }
}
