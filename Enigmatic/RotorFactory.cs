using System;
using System.Collections.Generic;
using System.Text;

namespace Enigmatic.Main
{
    public static class RotorFactory
    {
        static Rotor IC() => new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q");
        static Rotor IIC() => new Rotor("HQZGPJTMOBLNCIFDYAWVEUSRKX", "E");
        static Rotor IIIC() => new Rotor("UQNTLSZFMREHDPXKIBVYGJCWOA", "V");

        static Rotor RailwayI() => new Rotor("JGDQOXUSCAMIFRVTPNEWKBLZYH", "Q");
        static Rotor RailwayII() => new Rotor("NTZPSFBOKMWRCJDIVLAEYUXHGQ", "E");
        static Rotor RailwayIII() => new Rotor("JVIUBHTCDYAKEQZPOSGXNRMWFL", "V");

        static Rotor I() => new Rotor("EKMFLGDQVZNTOWYHXUSPAIBRCJ", "Q");
        static Rotor II() => new Rotor("AJDKSIRUXBLHWTMCQGZNPYFVOE", "E");
        static Rotor III() => new Rotor("BDFHJLCPRTXVZNYEIWGAKMUSQO", "V");
        static Rotor IV() => new Rotor("ESOVPZJAYQUIRHXLNFTGKDCMWB", "J");
        static Rotor V() => new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", "Z");
        static Rotor VI() => new Rotor("JPGVOUMFYQBENHZRDKASXLICTW", "ZM");
        static Rotor VII() => new Rotor("VZBRGITYUPSDNHLXAWMJQOFECK", "ZM");
        static Rotor VIII() => new Rotor("FKQHTLXOCBJSPDZRAMEWNIUYGV", "ZM");
    }

}
