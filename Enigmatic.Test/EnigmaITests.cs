using Enigmatic.Main.Machine;
using Enigmatic.Main.Machine.EnigmaI;
using Enigmatic.Main.Parts;
using NUnit.Framework;
using System.Text;

namespace Enigmatic.Test
{
    class EnigmaITests
    {
        IEnigma EnigmaI;

        [SetUp]
        public void Setup()
        {
        }

        [TestCase("AAAAA AAAAA", ExpectedResult = "SSKWS JNSEO")]
        [TestCase("HELLO WORLD", ExpectedResult = "KCUBR KIDKN")]
        [TestCase("VERY LONG TEXT TO CHECK IF THE ENIGMA WORKS CORRECTLY", ExpectedResult = "TCYH ISAY UBDN DT SRBXW WV BXM MVBBTF OITTO XXIYJKBIN")]
        [TestCase("EVEN LONGER TEXT TO CHECK IF THE ENIGMA I (ARMY) WORKS CORRECTLY AND CIPHERS EVERY CHARACTERS WITHOUT MISTAKES",
            ExpectedResult = "BPIU ISAYAZ SIVO KW DGSGM UM LDW ATASNT E (YELS) OFSCN OEMLKJAGT SLW PDMGRWF ZNTIQ BGZWCBGPGO MTBEBFW EDRIIAAB")]
        public string EnigmaI_EncryptsMessageCorrectly(string message)
        {
            EnigmaI = new EnigmaI("I II III", "A A A", "A", "");
            return EnigmaI.EncryptMessage(message);
        }

        [TestCase("AAAA AAAA AAAA", "B A A", ExpectedResult = "RLGO KTUC PSMR")]
        [TestCase("HELLO WORLD", "C K M", ExpectedResult = "NFTBU ZCGMB")]
        public string EnigmaI_EncryptsMessageCorrectlyWithSetInitialPositionsDifferentThanAAA(string message, string initPos)
        {
            EnigmaI = new EnigmaI("I II III", initPos, "A", "");
            return EnigmaI.EncryptMessage(message);
        }
    }
}
