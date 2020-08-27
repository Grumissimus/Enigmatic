namespace Enigmatic.Main.Interfaces
{
    public interface IRotor : ICipherable
    {
        string Turnover { get; }
        int InitialPosition { get; }
        int Deflection { get; }
        char DeflectAndCipher(char character);
        void IncrementDeflection();
        bool IsInTurnover();
    }
}
