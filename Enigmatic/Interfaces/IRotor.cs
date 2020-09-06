namespace Enigmatic.Main.Interfaces
{
    public interface IRotor
    {
        string Turnover { get; }
        int InitialPosition { get; }
        int Deflection { get; }

        char DeflectAndCipher(char character);
        void IncrementDeflection();
        bool IsInTurnover();
    }
}
