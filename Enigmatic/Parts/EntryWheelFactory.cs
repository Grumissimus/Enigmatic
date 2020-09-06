namespace Enigmatic.Main.Parts
{
    public static class EntryWheelFactory
    {
        public static EntryWheel Default() => new EntryWheel("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        public static EntryWheel Etw() => new EntryWheel("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "QWERTZUIOASDFGHJKPYXCVBNML");
        public static EntryWheel Tirpitz() => new EntryWheel("ABCDEFGHIJKLMNOPQRSTUVWXYZ", "KZROUQHYAIGBLWVSTDXFPNMCJE");
    }
}
