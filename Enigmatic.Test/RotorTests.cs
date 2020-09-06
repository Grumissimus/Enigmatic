using Enigmatic.Main.Machine;
using Enigmatic.Main.Machine.EnigmaI;
using Enigmatic.Main.Parts;
using NUnit.Framework;
using System.Text;

namespace Enigmatic.Test
{
    public class RotorTests
    {
        IRotorFactory rotorFactory;
        [SetUp]
        public void Setup()
        {
            rotorFactory = new EnigmaIRotorFactory();
        }

        [Test]
        public void Rotor_RotatesCorrectly()
        {

            Rotor testRotor = rotorFactory.CreateRotor("I", 'A');
            testRotor.IncrementDeflection();
            Assert.AreEqual(testRotor.Deflection, 1);
        }

        [Test]
        public void Rotor_DoesFullCircleCorrectly()
        {
            var testRotor = rotorFactory.CreateRotor("I", 'A');
            for (int i = 0; i < 26; i++)
                testRotor.IncrementDeflection();

            Assert.AreEqual(testRotor.Deflection, 0);
        }

        [Test]
        public void Rotor_TurnOverWorksCorrectly()
        {
            var testRotor = rotorFactory.CreateRotor("I", 'A');
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
            var testRotor = rotorFactory.CreateRotor("I", 'A');
            return testRotor.CipherInput(character);
        }
    }
}