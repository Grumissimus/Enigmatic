namespace Enigmatic.Main.Parts
{
    public static class EntryWheelFactory
    {
        public static EntryWheel Default() => new EntryWheel();
        public static EntryWheel ETW() => new EntryWheel("QWERTZUIOASDFGHJKPYXCVBNML");
        public static EntryWheel Tirpitz() => new EntryWheel("KZROUQHYAIGBLWVSTDXFPNMCJE");
    }
}
