﻿using Enigmatic.Main.Interfaces;
using Enigmatic.Main.Machine.CipherStrategy;
using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main.Machine
{
    public class EnigmaMachine : IEnigmaMachine
    {
        public IPlugboard Plugboard { get; private set; }

        public IStator EntryWheel { get; private set; }

        public IRotor LeftRotor { get; private set; }
        public IRotor MiddleRotor { get; private set; }
        public IRotor RightRotor { get; private set; }
        public IRotor ThinRotor { get; private set; }

        public IStator Reflector { get; private set; }

        public ICipherStrategy CipherStrategy { get; private set; }

        public EnigmaMachine(ICipherStrategy cipherStrategy, EnigmaConfiguration configuration)
        {
            configuration.Validate();

            Plugboard = configuration.Plugboard;
            EntryWheel = configuration.EntryWheel;

            RightRotor = configuration.RightRotor;
            MiddleRotor = configuration.MiddleRotor;
            LeftRotor = configuration.LeftRotor;
            ThinRotor = configuration.ThinRotor;

            Reflector = configuration.Reflector;

            CipherStrategy = cipherStrategy;
        }

        public string CipherMessage(string message)
        {
            return CipherStrategy.Apply(this, message);
        }
    }
}