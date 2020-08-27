namespace Enigmatic.Main.Interfaces
{
    public interface ICipherable
    {
        int ToWiring(char character);
        char ToChar(int wiring);
        char CipherInputCharacter(char character);
        char CipherOutputCharacter(char character);
    }
}
