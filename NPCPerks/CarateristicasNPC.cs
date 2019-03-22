using System;
using System.Collections.Generic;
using System.Text;

namespace NPCPerks
{
    [Flags]
    enum CarateristicasNPC
    {
        Stealth = 1 << 0, //0001
        Combat = 1 << 1, //0010
        Lockpick = 1 << 2, //0100
        Luck = 1 << 3 //1000
    }
}
