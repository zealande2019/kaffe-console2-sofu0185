using System;
using System.Collections.Generic;
using System.Text;

namespace kaffe
{
    public class FlatWhite : Kaffe, Imælk
    {
        public override int Pris()
        {
            int result = 45 - Rabat;
            if (result < 0)
                result = 0;
            return result;
        }
        public int MlMælk() => 160;
        public override string Styrke() => "Mild";

        public FlatWhite(int rabat) : base(rabat) { }
    }
}
