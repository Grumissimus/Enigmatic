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
                .SetPlugboard(new Plugboard())
                .SetEntryWheel(EntryWheelFactory.Default())
                .SetRightRotor( RotorFactory.III('A') )
                .SetMiddleRotor(RotorFactory.II('A') )
                .SetLeftRotor(RotorFactory.I('A') )
                .SetReflector( (StaticReflector)ReflectorFactory.A() );
            EnigmaI = new EnigmaMachine(new DefaultCipherStrategy(), config);
        }

        [TestCase("AAAAA AAAAA", ExpectedResult = "SSKWS JNSEO")]
        [TestCase("HELLO WORLD", ExpectedResult = "KCUBR KIDKN")]
        [TestCase("VERY LONG TEXT TO CHECK IF THE ENIGMA WORKS CORRECTLY", ExpectedResult = "TCYH ISAY UBDN DT SRBXW WV BXM MVBBTF OITTO XXIYJKBIN")]
        public string EnigmaI_EncryptsMessageCorrectly(string message)
        {
            return EnigmaI.CipherMessage(message);
        }
    }
}
