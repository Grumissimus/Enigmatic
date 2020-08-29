using Enigmatic.Main.Parts;
using NUnit.Framework;
using System.Text;

namespace Enigmatic.Test
{
    public class EntryWheelTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [TestCase("ABCDEFGHIJKLMNOPQRSTUVWXYZ", ExpectedResult = "ABCDEFGHIJKLMNOPQRSTUVWXYZ")]
        public string DefaultEntryWheel_CipherCharactersCorrectly(string alphabet)
        {
            EntryWheel entryWheel = EntryWheelFactory.Default();
            StringBuilder message = new StringBuilder();
            foreach (char ch in alphabet)
            {
                message.Append(entryWheel.CipherInputCharacter(ch));
            }

            return message.ToString();
        }

        [TestCase("ABCDEFGHIJKLMNOPQRSTUVWXYZ", ExpectedResult = "QWERTZUIOASDFGHJKPYXCVBNML")]
        public string ETW_K_CipherCharactersCorrectly(string alphabet)
        {
            EntryWheel entryWheel = EntryWheelFactory.Etw();
            StringBuilder message = new StringBuilder();
            foreach (char ch in alphabet)
            {
                message.Append(entryWheel.CipherInputCharacter(ch));
            }

            return message.ToString();
        }
        [TestCase("ABCDEFGHIJKLMNOPQRSTUVWXYZ", ExpectedResult = "KZROUQHYAIGBLWVSTDXFPNMCJE")]
        public string Tirpitz_CipherCharactersCorrectly(string alphabet)
        {
            EntryWheel entryWheel = EntryWheelFactory.Tirpitz();
            StringBuilder message = new StringBuilder();
            foreach (char ch in alphabet)
            {
                message.Append(entryWheel.CipherInputCharacter(ch));
            }

            return message.ToString();
        }
    }
}