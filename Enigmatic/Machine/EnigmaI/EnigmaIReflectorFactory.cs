using Enigmatic.Main.Parts;

namespace Enigmatic.Main.Machine.EnigmaI
{
    public class EnigmaIReflectorFactory : IReflectorFactory
    {
        public Reflector CreateReflector(string type)
        {
            return type switch
            {
                "A" => new Reflector("EJMZALYXVBWFCRQUONTSPIKHGD"),
                "B" => new Reflector("YRUHQSLDPXNGOKMIEBFZCWVJAT"),
                "C" => new Reflector("FVPJIAOYEDRZXWGCTKUQSBNMHL"),
                _ => null
            };
        }
    }
}