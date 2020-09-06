using Enigmatic.Main.Machine;
using Enigmatic.Main.Machine.CipherStrategy;
using Enigmatic.Main.Parts;
using NUnit.Framework;
using System.Text;

namespace Enigmatic.Test
{
    class EnigmaITests
    {
        EnigmaMachine EnigmaI;

        [SetUp]
        public void Setup()
        {
            var config = new EnigmaConfiguration()
                .SetPlugboard(new Plugboard("ABCDEFGHIJKLMNOPQRSTUVWXYZ"))
                .SetEntryWheel(EntryWheelFactory.Default())
                .SetRightRotor(RotorFactory.III('A'))
                .SetMiddleRotor(RotorFactory.II('A'))
                .SetLeftRotor(RotorFactory.I('A'))
                .SetReflector(ReflectorFactory.A());
            EnigmaI = new EnigmaMachine(new DefaultCipherStrategy(), config);
        }

        [TestCase("AAAAA AAAAA", ExpectedResult = "SSKWS JNSEO")]
        [TestCase("HELLO WORLD", ExpectedResult = "KCUBR KIDKN")]
        [TestCase("VERY LONG TEXT TO CHECK IF THE ENIGMA WORKS CORRECTLY", ExpectedResult = "TCYH ISAY UBDN DT SRBXW WV BXM MVBBTF OITTO XXIYJKBIN")]
        [TestCase("EVEN LONGER TEXT TO CHECK IF THE ENIGMA I (ARMY) WORKS CORRECTLY AND CIPHERS EVERY CHARACTERS WITHOUT MISTAKES",
            ExpectedResult = "BPIU ISAYAZ SIVO KW DGSGM UM LDW ATASNT E (YELS) OFSCN OEMLKJAGT SLW PDMGRWF ZNTIQ BGZWCBGPGO MTBEBFW EDRIIAAB")]
        public string EnigmaI_EncryptsMessageCorrectly(string message)
        {
            return EnigmaI.CipherMessage(message);
        }

        [TestCase("AAAA AAAA AAAA", new char[] { 'B', 'A', 'A' }, ExpectedResult = "ISSK WSJN SEOW")]
        [TestCase("HELLO WORLD", new char[] { 'C', 'K', 'M' }, ExpectedResult = "KKAMA JGMBW")]
        public string EnigmaI_EncryptsMessageCorrectlyWithSetInitialPositionsDifferentThanAAA(string message, char[] initPos)
        {
            var config = new EnigmaConfiguration()
                .SetPlugboard(new Plugboard("ABCDEFGHIJKLMNOPQRSTUVWXYZ"))
                .SetEntryWheel(EntryWheelFactory.Default())
                .SetRightRotor(RotorFactory.III(initPos[0]))
                .SetMiddleRotor(RotorFactory.II(initPos[1]))
                .SetLeftRotor(RotorFactory.I(initPos[2]))
                .SetReflector(ReflectorFactory.A());
            EnigmaI = new EnigmaMachine(new DefaultCipherStrategy(), config);
            return EnigmaI.CipherMessage(message);
        }
    }
}
