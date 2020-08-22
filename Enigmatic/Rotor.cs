﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main
{
    public class Rotor
    {
        public string Map { get; private set; }
        public string Turnover { get; private set; }
        public int Shift { get; private set; }

        public Rotor(string map, string turnover)
        {
            Map = map;
            Turnover = turnover;
            Shift = 0;
        }

        private int GetIndex(char character) => (character - 'A' + Shift) % 26;
        public char GetCurrentRotorSet() => (char)(Shift + 'A');
        public bool IsTurnover() => Turnover.Contains(GetCurrentRotorSet());

        public void Rotate()
        {
            Shift = (Shift + 1) % 26;
        }

        public char Encrypt(char character)
        {
            if (!(character >= 'A' && character <= 'Z')) return character;
            if (character >= 'a' && character <= 'z') character = char.ToUpper(character);

            return Map[GetIndex(character)];
        }

        public char RotateAndEncrypt(char character)
        {
            Rotate();
            return Encrypt(character);
        }
    }
}