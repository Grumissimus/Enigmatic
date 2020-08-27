namespace Enigmatic.Main.Interfaces
{
    public interface IPlugboard : ICipherable
    {
        void Connect(char A, char B);
        void Disconnect(char A);
        void Disconnect(char A, char B);
    }
}
