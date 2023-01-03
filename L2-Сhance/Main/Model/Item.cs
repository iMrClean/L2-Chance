using L2_Сhance.Main.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace L2_Сhance.Main.Model
{
    internal interface Item
    {

        bool DoMagic();
        int GetCurrentChance();
    }
}
