using Enigmatic.Main.Interfaces;
using Enigmatic.Main.Machine.CipherStrategy;
using Enigmatic.Main.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Machine
{
    public class EnigmaConfiguration
    {
        public IPlugboard Plugboard { get; private set;  }
        public IStator EntryWheel { get; private set; }
        public IRotor LeftRotor { get; private set; }
        public IRotor MiddleRotor { get; private set; }
        public IRotor RightRotor { get; private set; }
        public IRotor ThinRotor { get; private set; }

        public IStator Reflector { get; private set; }

        public EnigmaConfiguration InstallPlugboard(IPlugboard plugboard)
        {
            Plugboard = plugboard;
            return this;
        }

        public EnigmaConfiguration InstallEntryWheel(IStator entryWheel)
        {
            EntryWheel = entryWheel;
            return this;
        }

        public EnigmaConfiguration InstallRightRotor(IRotor rightRotor)
        {
            RightRotor = rightRotor;
            return this;
        }

        public EnigmaConfiguration InstallMiddleRotor(IRotor middleRotor)
        {
            MiddleRotor = middleRotor;
            return this;
        }

        public EnigmaConfiguration InstallLeftRotor(IRotor leftRotor)
        {
            LeftRotor = leftRotor;
            return this;
        }

        public EnigmaConfiguration InstallThinRotor(IRotor thinRotor)
        {
            ThinRotor = thinRotor;
            return this;
        }

        public EnigmaConfiguration InstallReflector(IStator reflector)
        {
            Reflector = reflector;
            return this;
        }

        public void Validate()
        {
            if( Plugboard == null)
                throw new ArgumentException("A plugboard hasn't been installed.");

            if (EntryWheel == null)
                throw new ArgumentException("An entry wheel hasn't been installed.");

            if (Reflector == null)
                throw new ArgumentException("A reflector hasn't been installed.");

            if (RightRotor == null)
                throw new ArgumentException("A right rotor hasn't been installed.");

            if (MiddleRotor == null)
                throw new ArgumentException("A middle rotor hasn't been installed.");

            if (LeftRotor == null)
                throw new ArgumentException("A left rotor hasn't been installed.");
        }
    }
}
