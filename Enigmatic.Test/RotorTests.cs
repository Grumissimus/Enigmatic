using Enigmatic.Main;
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
            var testRotor = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q");
            testRotor.Rotate();
            Assert.AreEqual(testRotor.Shift, 1);
        }

        [Test]
        public void Rotor_DoesFullCircleCorrectly()
        {
            var testRotor = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q");
            for(int i = 0; i < 26; i++)
                testRotor.Rotate();

            Assert.AreEqual(testRotor.Shift, 0);
        }

        [Test]
        public void Rotor_TurnOverWorksCorrectly()
        {
            var testRotor = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q");
            for (int i = 0; i < (int)('Q' - 'A'); i++)
                testRotor.Rotate();

            Assert.IsTrue(testRotor.IsTurnover());
        }

        [TestCase('A', ExpectedResult = 'E')]
        [TestCase('C', ExpectedResult = 'M')]
        [TestCase('F', ExpectedResult = 'G')]
        [TestCase('Z', ExpectedResult = 'J')]
        public char Rotor_EncryptsCharactersCorrectly(char character)
        {
            var testRotor = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q");
            return testRotor.Encrypt(character);
        }

        [TestCase("AAA", ExpectedResult = "KMF")]
        [TestCase("ZZZ", ExpectedResult = "EKM")]
        public string Rotor_RotatesAndEncryptsCharactersCorrectly(string code)
        {
            StringBuilder result = new StringBuilder();
            var testRotor = new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q");

            foreach(char ch in code)
            {
                result.Append(testRotor.RotateAndEncrypt(ch));
            }

            return result.ToString();
        }
    }
}