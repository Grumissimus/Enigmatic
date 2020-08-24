using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main
{
    public static class EntryWheelFactory
    {
        static EntryWheel Default() => new EntryWheel();
        static EntryWheel RailwayETW() => new EntryWheel("QWERTZUIOASDFGHJKPYXCVBNML");
        static EntryWheel SwissKETW() => new EntryWheel("QWERTZUIOASDFGHJKPYXCVBNML");
    }
}
