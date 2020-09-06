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
            Rotor testRotor = RotorFactory.I('A');
            testRotor.IncrementDeflection();
            Assert.AreEqual(testRotor.Deflection, 1);
        }

        [Test]
        public void Rotor_DoesFullCircleCorrectly()
        {
            var testRotor = RotorFactory.I('A');
            for (int i = 0; i < 26; i++)
                testRotor.IncrementDeflection();

            Assert.AreEqual(testRotor.Deflection, 0);
        }

        [Test]
        public void Rotor_TurnOverWorksCorrectly()
        {
            var testRotor = RotorFactory.I('A');
            for (int i = 0; i < 'R' - 'A'; i++)
                testRotor.IncrementDeflection();

            Assert.IsTrue( testRotor.IsInTurnover() );
        }

        [TestCase('A', ExpectedResult = 'E')]
        [TestCase('C', ExpectedResult = 'M')]
        [TestCase('F', ExpectedResult = 'G')]
        [TestCase('Z', ExpectedResult = 'J')]
        public char Rotor_EncryptsCharactersCorrectly(char character)
        {
            var testRotor = RotorFactory.I('A');
            return testRotor.CipherInput(character);
        }
    }
}