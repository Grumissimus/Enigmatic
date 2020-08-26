using Enigmatic.Main.Parts;
using NUnit.Framework;
using System.Text;

namespace Enigmatic.Test
{
    public class RotorTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Rotor_RotatesCorrectly()
        {
            var testRotor = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q", 'A');
            testRotor.IncrementDeflection();
            Assert.AreEqual(testRotor.Deflection, 1);
        }

        [Test]
        public void Rotor_DoesFullCircleCorrectly()
        {
            var testRotor = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q", 'A');
            for(int i = 0; i < 26; i++)
                testRotor.IncrementDeflection();

            Assert.AreEqual(testRotor.Deflection, 0);
        }

        [Test]
        public void Rotor_TurnOverWorksCorrectly()
        {
            var testRotor = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q", 'A');
            for (int i = 0; i < (int)('Q' - 'A'); i++)
                testRotor.IncrementDeflection();

            Assert.IsTrue( testRotor.IsInTurnover() );
        }

        [TestCase('A', ExpectedResult = 'E')]
        [TestCase('C', ExpectedResult = 'M')]
        [TestCase('F', ExpectedResult = 'G')]
        [TestCase('Z', ExpectedResult = 'J')]
        public char Rotor_EncryptsCharactersCorrectly(char character)
        {
            var testRotor = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q", 'A');
            return testRotor.CipherInputCharacter(character);
        }
    }
}