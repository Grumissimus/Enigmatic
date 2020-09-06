namespace Enigmatic.Main.Interfaces
{
    public interface IPlugboard
    {
        void Connect(char A, char B);
        void Disconnect(char A);
    }
}
