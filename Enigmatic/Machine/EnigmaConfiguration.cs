using Enigmatic.Main.Interfaces;
using Enigmatic.Main.Parts;
using System;

namespace Enigmatic.Main.Machine
{
    public class EnigmaConfiguration
    {
        public Plugboard Plugboard { get; private set; }
        public EntryWheel EntryWheel { get; private set; }
        public Rotor LeftRotor { get; private set; }
        public Rotor MiddleRotor { get; private set; }
        public Rotor RightRotor { get; private set; }
        public Rotor ThinRotor { get; private set; }

        public Reflector Reflector { get; private set; }

        public EnigmaConfiguration SetPlugboard(Plugboard plugboard)
        {
            Plugboard = plugboard;
            return this;
        }

        public EnigmaConfiguration SetEntryWheel(EntryWheel entryWheel)
        {
            EntryWheel = entryWheel;
            return this;
        }

        public EnigmaConfiguration SetRightRotor(Rotor rightRotor)
        {
            RightRotor = rightRotor;
            return this;
        }

        public EnigmaConfiguration SetMiddleRotor(Rotor middleRotor)
        {
            MiddleRotor = middleRotor;
            return this;
        }

        public EnigmaConfiguration SetLeftRotor(Rotor leftRotor)
        {
            LeftRotor = leftRotor;
            return this;
        }

        public EnigmaConfiguration SetThinRotor(Rotor thinRotor)
        {
            ThinRotor = thinRotor;
            return this;
        }

        public EnigmaConfiguration SetReflector(Reflector reflector)
        {
            Reflector = reflector;
            return this;
        }

        public void Validate()
        {
            if (Plugboard == null)
                throw new ArgumentException("A plugboard hasn't been set.");

            if (EntryWheel == null)
                throw new ArgumentException("An entry wheel hasn't been set.");

            if (Reflector == null)
                throw new ArgumentException("A reflector hasn't been set.");

            if (RightRotor == null)
                throw new ArgumentException("A right rotor hasn't been set.");

            if (MiddleRotor == null)
                throw new ArgumentException("A middle rotor hasn't been set.");

            if (LeftRotor == null)
                throw new ArgumentException("A left rotor hasn't been set.");
        }
    }
}
